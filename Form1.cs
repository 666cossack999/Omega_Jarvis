using Omega_Jarvis.Groups;
using Omega_Jarvis.Printers;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class Form1 : Form
    {

        private Action<string> _pushToLogValueDelegate;
        private Action _activatePcFlagsDelegate;
        private Action _activateLoginFlagsDelegate;
        private bool _pcChecked = false;
        public readonly string _version = "1.0";


        public Form1()
        {
            InitializeComponent();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

        }

        public void btnBase1C_Click(object sender, EventArgs e)
        {

            if (rb1CToPC.Checked)
            {
                try
                {
                    Base1CFormPC base1CForm = new Base1CFormPC();
                    base1CForm.Show();
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
                }

            }
            else if (rb1CToServer.Checked)
            {
                lblProgress.Text = "Вычисляю ID пользователя";
                PushToLog("Вычисляю ID пользователя");
                string sid = Engine.GetUserSid();

                lblProgress.Text = "Ищу путь до виртуального диска";
                PushToLog("Ищу путь до виртуального диска");

                //Монтируем диск
                lblProgress.Text = "Монтирую диск к вашему ПК";
                PushToLog("Монтирую диск к вашему ПК");
                bool Flag = Engine.MountDisk(sid);

                if (Flag)
                {
                    lblProgress.Text = "Ищу конфиг на сервере";
                    PushToLog("Ищу конфиг на сервере");
                    Data.ConfigOnServer = Engine.GetPathOnServer();
                }
                else
                {
                    lblProgress.Text = "Диск занят, ищу ноду...";
                    PushToLog("Диск занят, ищу ноду...");
                    string node = Engine.GetNode();
                    Data.ConfigOnServer = $@"\\{node}\c$\Users\{Data.Login}\AppData\Roaming\1C\1CEStart\1cestart.cfg";

                }
                lblProgress.Text = "готово";
                PushToLog("готово");
                lblProgress.Visible = false;

                Base1CFormServer base1CForm = new Base1CFormServer(_pushToLogValueDelegate);
                base1CForm.Show();
            }
            else
            {
                MessageBox.Show(
                    "Выбери куда прописывать базу!!!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        /// <summary>
        /// Дописывает текст в ТекстБокс Лог
        /// </summary>
        /// <param name="text">Текст</param>
        private void PushToLog(string text)
        {
            tbLog.AppendText(text + Environment.NewLine);
        }

        /// <summary>
        /// Деактивация интерфейса с неверным именем ПК
        /// </summary>
        private void PcFlagsDeactivate()
        {
            labelPC.ForeColor = Color.Red;
            //Деактивируем контролы для баз 1С
            btnBase1C.Enabled = false;
            rb1CToPC.Enabled = false;
            rb1CToPC.Checked = false;
        }

        /// <summary>
        /// Активация интерфейса с верным именем ПК
        /// </summary>
        private void PcFlagsActivate()
        {
            labelPC.ForeColor = Color.Green;
            //активируем контролы для баз 1С
            rb1CToPC.Enabled = true;
            rb1CToPC.Checked = true;
            btnBase1C.Enabled = true;
        }

        /// <summary>
        /// Деактивация интерфейса с неверным логином
        /// </summary>
        private void LoginFlagsDeactivate()
        {
            labelLogin.ForeColor = Color.Red;
            //деактивируем контролы для баз 1С
            btnBase1C.Enabled = false;
            rb1CToServer.Enabled = false;
            rb1CToServer.Checked = false;

        }

        /// <summary>
        /// Активация интерфеса с верным Логином
        /// </summary>
        private void LoginFlagsActivate()
        {
            labelLogin.ForeColor = Color.Green;
            //активируем контролы для баз 1С
            rb1CToServer.Enabled = true;
            rb1CToServer.Checked = true;
            btnBase1C.Enabled = true;
        }

        /// <summary>
        /// Проверяем логин и имя пк в AD
        /// </summary>
        private void btnCheckLoginPc_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "")
            {
                _activateLoginFlagsDelegate = LoginFlagsActivate;
                Engine.CheckUserInAdAsync(txtLogin.Text, _activateLoginFlagsDelegate);
            }
            if (txtPC.Text != "")
            {
                _activatePcFlagsDelegate = PcFlagsActivate;
                Engine.PcTestConnectionAsync(txtPC.Text, _activatePcFlagsDelegate);
            }
        }

        private void txtPC_TextChanged(object sender, EventArgs e)
        {
            PcFlagsDeactivate();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            txtGroupsFrom.Text = txtLogin.Text;
            LoginFlagsDeactivate();
        }

        private void btnPrinters_Click(object sender, EventArgs e)
        {
            if (Data.PcName != null)
            {
                _pcChecked = true;
            }
            //Добавляем принтеры
            if (rbPrintersAdd.Checked)
            {
                PrintersAdd printersAdd = new PrintersAdd(_pushToLogValueDelegate, _pcChecked);
                printersAdd.Show();
            }
            //Удаляем принтеры
            if (rbPrintersRemove.Checked)
            {
                PrintersRemove printersRemove = new PrintersRemove(_pushToLogValueDelegate, _pcChecked);
                printersRemove.Show();
            }
            //меняем ip-адрес принтера
            if (rbPrintersChangeIp.Checked)
            {
                PrintersChangeIp printersChangeIp = new PrintersChangeIp(_pushToLogValueDelegate, _pcChecked);
                printersChangeIp.Show();
            }
            //изменяем имя принтера
            if (rbPrintersChangeName.Checked)
            {
                PrinterChangeName printerChangeName = new PrinterChangeName(_pushToLogValueDelegate, _pcChecked);
                printerChangeName.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _pushToLogValueDelegate = PushToLog;
            Data.PrinterDrivers = Engine.CheckPrinterDrivers("srv-rdsh-c1-01");

            txtPC.Text = "m-stis20";
            txtLogin.Text = "dmitriev_ei";
        }

        /// <summary>
        /// Проверяет версию программы и загружает обновление
        /// </summary>
        private void checkForUpdate()
        {
            string URL = "ftp://193.178.169.117/upload/";
            string AppName = "OmegaJarvis.exe";
            string serverVersionName = "version.txt";
            string ServerVersion = OmegaClient.GetVersion(URL + serverVersionName);




            if (_version != ServerVersion)
            {
                DialogResult result = MessageBox.Show(
                                            "Установить?",
                                            "Вышло обновление!",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1,
                                            MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    Updater updater = new Updater(URL + AppName);
                    updater.Show();
                }
            }
        }
        
        private void btnCopyGroups_Click(object sender, EventArgs e)
        {
            Engine.CheckUserInAdAsync(txtGroupsTo.Text);
            Data.UserFromGroups = Engine.CheckUserGroups(txtGroupsFrom.Text);

            CopyGroups copygroups = new CopyGroups(txtGroupsFrom.Text, txtGroupsTo.Text);
            copygroups.Show();
        }
    }
}

