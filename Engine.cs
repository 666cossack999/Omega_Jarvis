using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Omega_Jarvis
{
    public static class Engine
    {
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
                         getNode = array[1].Replace("$","").ToLower();
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
            
            //Получаем ИД диска
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
    }
}
