using System;
using System.IO;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class Base1CFormPC : Form
    {

        string path = $@"\\{Data.PcName}\c$\Users\{Data.Login}\AppData\Roaming\1C\1CEStart\1cestart.cfg";

        public Base1CFormPC()
        {
            InitializeComponent();


            //Путь до файла
            StreamReader sr = new StreamReader(path);
            //Читаем первую строку
            var line = sr.ReadLine();
            //Продолжаем читать весь файл
            while (line != null)
            {
                if (line == Data.doc)
                {
                    cb1cDoPc.Checked = true;
                } 
                else if (line == Data.buh)
                {
                    cb1cBuhCorpPc.Checked = true;
                } 
                else if (line == Data.upr)
                {
                    cbUprPc.Checked = true;
                }
                else if (line == Data.zup)
                {
                    cbZupPc.Checked = true;
                }
                else if (line == Data.uat)
                {
                    cbUatPc.Checked = true;
                }
                //Читаем следующую строку
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
        }

        private void btnPushBase_Click(object sender, EventArgs e)
        {

                //Open the File
                StreamWriter sw = new StreamWriter(path, false);

                if (cb1cDoPc.Checked)
                {
                     sw.WriteLine(Data.doc);
                }
                else if (cb1cBuhCorpPc.Checked)
                {
                    sw.WriteLine(Data.buh);
                }
                else if (cbUatPc.Checked)
                {
                    sw.WriteLine(Data.uat);
                }
                else if (cbUprPc.Checked)
                {
                    sw.WriteLine(Data.upr);
                }
                else if (cbZupPc.Checked)
                {
                    sw.WriteLine(Data.zup);
                }

                //close the file
                sw.Close();

            Base1CFormPC.ActiveForm.Close();

        }
    }
}
