﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management.Automation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public static class Engine
    {
        /// <summary>
        /// Проверяет, есть ли пользователь в AD
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <returns>bool</returns>
        private static bool CheckUserInAd(string login)
        {
            try
            {
                var psCheckLogin = PowerShell.Create()
                                     .AddCommand("Get-AdUser")
                                     .AddParameter("Identity", login)
                                     .Invoke();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                            ex.Message.ToString(),
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                return false;
            }

        }

        /// <summary>
        /// Проверяет, есть ли пользователь в AD асинхронно и активирует кнопки для Баз 1С
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        public async static void CheckUserInAdAsync(string login, Action loginFlagsActivate)
        {
            bool checkLogin = await Task.Run(() => CheckUserInAd(login));

            if (checkLogin)
            {
                loginFlagsActivate();
                Data.Login = login;
            }
        }

        /// <summary>
        /// Проверяет, есть ли пользователь в AD асинхронно
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        public async static void CheckUserInAdAsync(string login)
        {
           bool checkLogin = await Task.Run(() => CheckUserInAd(login));
        }

        /// <summary>
        /// Проверяет ПК в сети
        /// </summary>
        /// <param name="pcName">Имя ПК</param>
        /// <returns>bool</returns>
        private static bool PcTestConnection(string pcName)
        {
            var psCheckPc = PowerShell.Create()
                                          .AddCommand("Test-Connection")
                                          .AddParameter("ComputerName", pcName)
                                          .AddParameter("Count", 1)
                                          .Invoke();
            if (psCheckPc.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверяет ПК в сети ассинхронно
        /// </summary>
        /// <param name="pcName">Имя ПК</param>
        /// <returns>bool</returns>
        public async static void PcTestConnectionAsync(string pcName, Action activatePcFlagDelegate)
        {
            bool checkPc = await Task.Run(() => PcTestConnection(pcName));

            if (checkPc)
            {
                activatePcFlagDelegate();
                Data.PcName = pcName;
            }

        }

        /// <summary>
        /// Ищет на какой ноде TS01 или RDP в данный момент работает пользователь
        /// </summary>
        /// <returns></returns>
        public static string GetNode()
        {
            string getNode = "";
            Process process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = @"/C chcp 65001 & openfiles.exe /query /s ts-fs /FO CSV";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            if ((process.StandardOutput != null))
            {
                var result = process.StandardOutput.ReadToEnd().Trim().Replace("\"", "");
                var lines = result.Split('\n');

                foreach (var line in lines)
                {
                    if (line.Contains("S-1-5-21-2657382475-1131176568-1475707238-25943"))
                    {
                        string[] array = line.Split(',');
                        getNode = array[1].Replace("$", "").ToLower();
                    }
                }

            }

            return getNode;

        }

        /// <summary>
        /// Получает SID пользователя в AD
        /// </summary>
        /// <returns>SID пользователя</returns>
        public static string GetUserSid()
        {
            var psGetSid = PowerShell.Create()
                                     .AddCommand("Get-AdUser")
                                     .AddParameter("Identity", Data.Login)
                                     .Invoke();

            string sid = psGetSid[0].Properties["SID"].Value.ToString();
            return sid;

        }

        /// <summary>
        /// Монтирует диск с сервера ts-fs к вашему ПК
        /// </summary>
        /// <param name="sid">SID пользователя в AD</param>
        /// <returns>true: получилось примонтировать. False: не получилось примонтировать</returns>
        public static bool MountDisk(string sid)
        {
            Data.ServerImagePath = $@"\\ts-fs\d$\Shares\Profiles\Profiles8\UVHD-{sid}.vhdx";

            var psMountImage = PowerShell.Create()
                                         .AddCommand("Mount-DiskImage")
                                         .AddParameter("ImagePath", Data.ServerImagePath)
                                         .Invoke();

            return (psMountImage.Count != 0) ? true : false;

        }
        /// <summary>
        /// Демонтирует диск от вашего ПК с сервера ts-fs
        /// </summary>
        public static void DismountDisk()
        {
            //Извлекаем диск
            var psDisMountImage = PowerShell.Create()
                                            .AddCommand("Dismount-DiskImage")
                                            .AddParameter("ImagePath", Data.ServerImagePath)
                                            .Invoke();
        }

        /// <summary>
        /// Ищет путь конфига 1С на примонтированном диске на вашем ПК
        /// </summary>
        /// <returns>Путь до конфига</returns>
        public static string GetPathOnServer()
        {
            //Узнаём буквы всех дисков
            var psGetVolume = PowerShell.Create()
                                   .AddCommand("Get-Volume")
                                   .Invoke();

            //Узнаём букву примонтированного диска и присваиваем путь до файла
            for (int i = 0; i < psGetVolume.Count; i++)
            {
                var getVolume = psGetVolume[i].Properties["FileSystemLabel"].Value.ToString();

                if (getVolume == "User Disk")
                {
                    var letter = psGetVolume[i].Properties["DriveLetter"].Value.ToString();
                    return $@"{letter}:\AppData\Roaming\1C\1CEStart\1cestart.cfg";
                }

            }
            return "";
        }

        /// <summary>
        /// Добавляет пользователя в группу
        /// </summary>
        /// <param name="username">Логин</param>
        /// <param name="adGroup">группа</param>
        public static void AddUserToGroup(string username, string adGroup)
        {
            var psMountImage = PowerShell.Create()
                                         .AddCommand("Add-ADGroupMember")
                                         .AddParameter("Identity", adGroup)
                                         .AddParameter("Members", username)
                                         .Invoke();
        }

        /// <summary>
        /// Удаляет пользователя из группы в AD
        /// </summary>
        /// <param name="username">Логин</param>
        /// <param name="adGroup">Группа</param>
        public static void DeleteUserFromGroup(string username, string adGroup)
        {
            var psDeleteFromGroup = PowerShell.Create()
                                              .AddCommand("Remove-ADGroupMember")
                                              .AddParameter("Identity", adGroup)
                                              .AddParameter("Members", username)
                                              .AddParameter("Confirm", false)
                                              .Invoke();
        }

        /// <summary>
        /// Добавляет принтер
        /// </summary>
        /// <param name="computerName">Имя машины куда поставить</param>
        /// <param name="ip">ip-адрес принтера</param>
        /// <param name="printerName">Имя принтера</param>
        /// <param name="driverName">Имя драйвера</param>
        private static void AddPrinter(string computerName, string ip, string printerName, string driverName)
        {
            var checkPortExists = PowerShell.Create()
                                            .AddCommand("Get-Printerport")
                                            .AddParameter("ComputerName", computerName)
                                            .AddParameter("Name", ip)
                                            .AddParameter("ErrorAction", "SilentlyContinue")
                                            .Invoke();

            if (checkPortExists.Count == 0)
            {
                var addPrinterPort = PowerShell.Create()
                                               .AddCommand("Add-PrinterPort")
                                               .AddParameter("ComputerName", computerName)
                                               .AddParameter("Name", ip)
                                               .AddParameter("PrinterHostAddress", ip)
                                               .Invoke();

                var addPrinter = PowerShell.Create()
                                           .AddCommand("Add-Printer")
                                           .AddParameter("ComputerName", computerName)
                                           .AddParameter("Name", printerName)
                                           .AddParameter("DriverName", driverName)
                                           .AddParameter("PortName", ip)
                                           .Invoke();
            }
            else
            {
                MessageBox.Show(
                    "Порт занят",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /// <summary>
        /// Добавляет принтер асинхронно
        /// </summary>
        /// <param name="computerName">Имя машины куда поставить</param>
        /// <param name="ip">ip-адрес принтера</param>
        /// <param name="printerName">Имя принтера</param>
        /// <param name="driverName">Имя драйвера</param>
        public async static void AddPrinterAsync(string computerName, string ip, string printerName, string driverName, Action<string> pushToLogDelegate)
        {
            pushToLogDelegate($"Запустил процесс добавления принтера {printerName} на {computerName}");

            await Task.Run(() => AddPrinter(computerName, ip, printerName, driverName));

            pushToLogDelegate($"Принтер {printerName} добавлен на: {computerName}");
        }

        /// <summary>
        /// Удаляет принтер
        /// </summary>
        /// <param name="printerName">Имя принтера</param>
        /// <param name="computerName">Имя компьютера</param>
        private static void RemovePrinter(string printerName, string computerName)
        {
            //Вычисляем старый IP
            var getOldIpPrinter = PowerShell.Create()
                                            .AddCommand("Get-Printer")
                                            .AddParameter("ComputerName", computerName)
                                            .AddParameter("Name", printerName)
                                            .Invoke();

            try
            {
                string oldIp = getOldIpPrinter[0].Properties["PortName"].Value.ToString();

                //Удаляем принтер
                var removePrinter = PowerShell.Create()
                                              .AddCommand("Remove-Printer")
                                              .AddParameter("ComputerName", computerName)
                                              .AddParameter("Name", printerName)
                                              .Invoke();
                //Удаляем старый порт
                var removeOldIpPrinter = PowerShell.Create()
                                                   .AddCommand("Remove-PrinterPort")
                                                   .AddParameter("ComputerName", computerName)
                                                   .AddParameter("Name", oldIp)
                                                   .Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                            ex.Message.ToString() + $" Машина {computerName}",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
            }




        }

        /// <summary>
        /// Удаляет принтер асинхронно
        /// </summary>
        /// <param name="printerName">Имя принтера</param>
        /// <param name="computerName">Имя компьютера</param>
        public async static void RemovePrinterAsync(string printerName, string computerName, Action<string> pushToLogDelegate)
        {
            pushToLogDelegate($"Запустил процесс удаления принтера {printerName} на {computerName}");

            await Task.Run(() => RemovePrinter(printerName, computerName));

            pushToLogDelegate($"Принтер {printerName} удалён с: {computerName}");
            pushToLogDelegate($"Порт принтера удалён");
        }

        /// <summary>
        /// Меняет IP-адрес у принтера и удаляет старый
        /// </summary>
        /// <param name="printerName">Имя принтера</param>
        /// <param name="computerName">Имя компьютера</param>
        /// <param name="newIp">Новый IP</param>
        private static void ChangeIpPrinter(string printerName, string computerName, string newIp)
        {
            //Вычисляем старый IP
            var getOldIpPrinter = PowerShell.Create()
                                            .AddCommand("Get-Printer")
                                            .AddParameter("ComputerName", computerName)
                                            .AddParameter("Name", printerName)
                                            .Invoke();

            string oldIp = getOldIpPrinter[0].Properties["PortName"].Value.ToString();

            //Добавляем новый порт
            var addNewPort = PowerShell.Create()
                                       .AddCommand("Add-PrinterPort")
                                       .AddParameter("Name", newIp)
                                       .AddParameter("PrinterHostAddress", newIp)
                                       .Invoke();

            //Ставим принтеру новый порт
            var changeIpPrinter = PowerShell.Create()
                                            .AddCommand("Set-Printer")
                                            .AddParameter("ComputerName", computerName)
                                            .AddParameter("PortName", newIp)
                                            .AddParameter("Name", printerName)
                                            .Invoke();

            //Удаляем старый порт
            var removeOldIpPrinter = PowerShell.Create()
                                               .AddCommand("Remove-PrinterPort")
                                               .AddParameter("ComputerName", computerName)
                                               .AddParameter("Name", oldIp)
                                               .Invoke();
        }

        /// <summary>
        /// Меняет IP-адрес у принтера и удаляет старый асинхронно
        /// </summary>
        /// <param name="printerName">Имя принтера</param>
        /// <param name="computerName">Имя компьютера</param>
        /// <param name="newIp">Новый IP</param>
        public async static void ChangeIpPrinterAsync(string printerName, string computerName, string newIp, Action<string> pushToLogDelegate)
        {
            pushToLogDelegate($"Меняю IP принтера {printerName} на {computerName}");

            await Task.Run(() => ChangeIpPrinter(printerName, computerName, newIp));

            pushToLogDelegate($"У принтера {printerName} изменён ip на: {newIp} на машине: {computerName}");
            pushToLogDelegate($"Старый порт принтера удалён");
        }

        /// <summary>
        /// Изменяет имя принтера
        /// </summary>
        /// <param name="computerName">Имя машины</param>
        /// <param name="oldName">Старое имя</param>
        /// <param name="newName">Новое имя</param>
        private static bool ChangeNamePrinter(string computerName, string oldName, string newName)
        {
            try
            {
                var psRenamePrinter = PowerShell.Create()
                                            .AddCommand("Rename-Printer")
                                            .AddParameter("CimSession", computerName)
                                            .AddParameter("Name", oldName)
                                            .AddParameter("NewName", newName)
                                            .Invoke();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                            ex.Message.ToString(),
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                return false;
            }

        }

        /// <summary>
        /// Изменяет имя принтера асинхронно
        /// </summary>
        /// <param name="computerName">Имя машины</param>
        /// <param name="oldName">Старое имя</param>
        /// <param name="newName">Новое имя</param>
        public async static void ChangeNamePrinterAsync(string computerName, string oldName, string newName, Action<string> pushToLogDelegate)
        {
            pushToLogDelegate($"Меняю имя принтера {oldName} на {newName} на машине {computerName}");

            bool falg = await Task.Run(() => ChangeNamePrinter(computerName, oldName, newName));

            if (falg)
            {
                pushToLogDelegate($"У принтера {oldName} сменилось имя на: {newName} на машине: {computerName}");
            }
            else
            {
                pushToLogDelegate($"На машине: {computerName} у принтера {oldName} Не удалось изменить имя...");
            }

        }

        /// <summary>
        /// Выгружает список установленых драйверов принтера на машине
        /// </summary>
        /// <param name="computerName">машина</param>
        /// <returns>Список драйверов List<string></returns>
        public static List<string> CheckPrinterDrivers(string computerName)
        {
            var checkPrinterDrivers = PowerShell.Create()
                                                .AddCommand("Get-PrinterDriver")
                                                .AddParameter("ComputerName", computerName)
                                                .AddParameter("ErrorAction", "SilentlyContinue")
                                                .Invoke();

            List<string> list = new List<string>();

            foreach (var item in checkPrinterDrivers)
            {
                list.Add(item.Properties["Name"].Value.ToString());
            }

            return list;
        }

        /// <summary>
        /// Список групп пользователя
        /// </summary>
        /// <param name="login">пользователь</param>
        /// <returns>список групп</returns>
        public static List<string> CheckUserGroups (string login)
        {
            List<string> list = new List<string>();

            try
            {
                var checkUserGroups = PowerShell.Create()
                                            .AddScript($"Get-ADPrincipalGroupMembership {login} | Sort-Object | select -ExpandProperty name")
                                            .Invoke();

                foreach (var item in checkUserGroups)
                {
                    list.Add(item.BaseObject.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                            ex.Message.ToString(),
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);

                list.Add(ex.Message.ToString());
            }
            

            return list;
        }
    }
}
