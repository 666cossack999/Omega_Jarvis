using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class Base1CFormServer : Form
    {
        
        public Base1CFormServer()
        {
            InitializeComponent();

            //Путь до файла
            try
            {
                StreamReader sr = new StreamReader(Data.ConfigOnServer);
                //Читаем первую строку
                var line = sr.ReadLine();
                //Продолжаем читать весь файл
                while (line != null)
                {
                    if (line == Data.doc)
                    {
                        cb1cDoSrv.Checked = true;
                    }
                    else if (line == Data.buh)
                    {
                        cb1cBuhCorpSrv.Checked = true;
                    }
                    else if (line == Data.upr)
                    {
                        cbUprSrv.Checked = true;
                    }
                    else if (line == Data.zup)
                    {
                        cbZupSrv.Checked = true;
                    }
                    else if (line == Data.uat)
                    {
                        cbUatSrv.Checked = true;
                    }
                    //Читаем следующую строку
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Неправильный путь",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            
            
           
        }

        private void btnPushBaseSrv_Click(object sender, EventArgs e)
        {
                 
            StreamWriter sw = new StreamWriter(Data.ConfigOnServer, false);

            if (cb1cDoSrv.Checked)
            {
                sw.WriteLine(Data.doc);
            }
            else if (cb1cBuhCorpSrv.Checked)
            {
                sw.WriteLine(Data.buh);
            }
            else if (cbUatSrv.Checked)
            {
                sw.WriteLine(Data.uat);
            }
            else if (cbUprSrv.Checked)
            {
                sw.WriteLine(Data.upr);
            }
            else if (cbZupSrv.Checked)
            {
                sw.WriteLine(Data.zup);
            }

            //close the file
            sw.Close();

            Base1CFormServer.ActiveForm.Close();
        }

        private void Base1CFormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Извлекаем диск
            var psDisMountImage = PowerShell.Create()
                                         .AddCommand("Dismount-DiskImage")
                                         .AddParameter("ImagePath", Data.ServerImagePath)
                                         .Invoke();
        }
    }
}
