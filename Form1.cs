using System;
using System.Management.Automation;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class Form1 : Form
    {

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
                lblProgress.Text = "Вычисляю ID пользователя";
                progress.Visible = true;
                progress.Value = 10;

                //Получаем ИД диска
                var psGetSid = PowerShell.Create()
                                         .AddCommand("Get-AdUser")
                                         .AddParameter("Identity", Data.Login)
                                         .Invoke();
                lblProgress.Text = "Ищу путь до виртуального диска";
                progress.Value = 30;

                var sid = psGetSid[0].Properties["SID"].Value.ToString();
                Data.ServerImagePath = $@"\\ts-fs\d$\Shares\Profiles\Profiles8\UVHD-{sid}.vhdx";

                //Монтируем диск
                lblProgress.Text = "Монтирую диск к вашему ПК";
                progress.Value = 50;

                var psMountImage = PowerShell.Create()
                                             .AddCommand("Mount-DiskImage")
                                             .AddParameter("ImagePath", Data.ServerImagePath)
                                             .Invoke();
                lblProgress.Text = "Вычисляю букву диска";
                progress.Value = 60;

                //Узнаём буквы всех дисков
                var psGetVolume = PowerShell.Create()
                                       .AddCommand("Get-Volume")
                                       .Invoke();
                //Узнаём букву примонтированного диска и присваиваем путь до файла
                for (int i = 0; i < psGetVolume.Count; i++)
                {
                    progress.Value += 5;

                    var getVolume = psGetVolume[i].Properties["FileSystemLabel"].Value.ToString();

                    if (getVolume == "User Disk")
                    {
                        var letter = psGetVolume[i].Properties["DriveLetter"].Value.ToString();
                        Data.ConfigOnServer = $@"{letter}:\AppData\Roaming\1C\1CEStart\1cestart.cfg";

                        var path = Data.ConfigOnServer;
                    }

                }
                progress.Value = 100;
                progress.Visible = false;
                lblProgress.Visible = false;

                Base1CFormServer base1CForm = new Base1CFormServer();
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

    }
}

