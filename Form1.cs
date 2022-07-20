using System;
using System.Drawing;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class Form1 : Form
    {

        private Action<string> _pushToLogValueDelegate;
        private Action _activatePcFlagsDelegate;
        private Action _deactivatePcFlagsDelegate;
        private Action _activateLoginFlagsDelegate;
        private Action _deactivateLoginFlagsDelegate;


        public Form1()
        {
            InitializeComponent();

            //txtPC.Text = "m-stis20";
            //txtLogin.Text = "dmitriev_ei";

        }

        public void btnBase1C_Click(object sender, EventArgs e)
        {

            if (rb1CToPC.Checked)
            {
                Base1CFormPC base1CForm = new Base1CFormPC();
                base1CForm.Show();
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

                if (_pushToLogValueDelegate == null)
                {
                    _pushToLogValueDelegate += PushToLog;
                }

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

        private void txtPC_TextChanged(object sender, EventArgs e)
        {
            if (txtPC.Text != "")
            {
                _activatePcFlagsDelegate = PcFlagsActivate;
                _deactivatePcFlagsDelegate = PcFlagsDeactivate;
                Engine.PcTestConnectionAsync(txtPC.Text, _activatePcFlagsDelegate, _deactivatePcFlagsDelegate);
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text != "")
            {
                _activateLoginFlagsDelegate = LoginFlagsActivate;
                _deactivateLoginFlagsDelegate = LoginFlagsDeactivate;
                Engine.CheckUserInAdAsync(txtLogin.Text, _activateLoginFlagsDelegate, _deactivateLoginFlagsDelegate);
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
            //Дективируем контролы для принтеров
            btnPrinters.Enabled = false;
            rbPrintersToPc.Enabled = false;
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
            //активируем контролы для принтеров
            rbPrintersToPc.Enabled = true;
            rbPrintersToPc.Checked = true;
            btnPrinters.Enabled = true;
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
            //деактивируем контролы для принтеров
            btnPrinters.Enabled = false;
            rbPrintersToMwmts.Enabled = false;
            rbPrintersToRdp.Enabled = false;
            rbPrintersToTs01.Enabled = false;
            rbPrintersToTs01.Checked = false;
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
            //Активируем контролы для принтеров
            rbPrintersToMwmts.Enabled = true;
            rbPrintersToRdp.Enabled = true;
            rbPrintersToTs01.Enabled = true;
            rbPrintersToTs01.Checked = true;
            btnPrinters.Enabled = true;
        }
    }
}

