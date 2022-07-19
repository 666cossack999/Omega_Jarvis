using System;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class Form1 : Form
    {

        private Action<string> _pushToLogValueDelegate;

        public Form1()
        {
            InitializeComponent();

            txtPC.Text = "m-stis20";
            txtLogin.Text = "dmitriev_ei";
        }


        public void btnBase1C_Click(object sender, EventArgs e)
        {
            if (rbToPC.Checked)
            {
                Base1CFormPC base1CForm = new Base1CFormPC();
                base1CForm.Show();
            }
            else if (rbToServer.Checked)
            {
                progress.Value += 10;
                lblProgress.Text = "Вычисляю ID пользователя";
                PushToLog("Вычисляю ID пользователя");
                progress.Visible = true;
                string sid = Engine.GetUserSid();

                lblProgress.Text = "Ищу путь до виртуального диска";
                PushToLog("Ищу путь до виртуального диска");
                progress.Value += 20;
                           
                //Монтируем диск
                lblProgress.Text = "Монтирую диск к вашему ПК";
                PushToLog("Монтирую диск к вашему ПК");
                progress.Value += 10;
                bool Flag = Engine.MountDisk(sid);

                if (Flag)
                {
                    lblProgress.Text = "Ищу конфиг на сервере";
                    PushToLog("Ищу конфиг на сервере");
                    progress.Value += 30;
                    Data.ConfigOnServer = Engine.GetPathOnServer();
                }
                else
                {
                    lblProgress.Text = "Диск занят, ищу ноду...";
                    PushToLog("Диск занят, ищу ноду...");
                    progress.Value += 10;
                    string node = Engine.GetNode();
                    Data.ConfigOnServer = $@"\\{node}\c$\Users\{Data.Login}\AppData\Roaming\1C\1CEStart\1cestart.cfg";

                }
                lblProgress.Text = "готово";
                PushToLog("готово");
                progress.Value = 0;
                progress.Visible = false;
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
            Data.PcName = txtPC.Text;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            Data.Login = txtLogin.Text;
        }

        public void PushToLog(string text)
        {
            tbLog.AppendText (text + Environment.NewLine);
        }

    }
}

