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
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                //Читаем первую строку
                var line = sr.ReadLine();
                //Продолжаем читать весь файл
                while (line != null)
                {
                    switch (line)
                    {
                        case Data.doc:
                            cb1cDoPc.Checked = true;
                            break;
                        case Data.buh:
                            cb1cBuhCorpPc.Checked = true;
                            break;
                        case Data.upr:
                            cbUprPc.Checked = true;
                            break;
                        case Data.zup:
                            cbZupPc.Checked = true;
                            break;
                        case Data.uat:
                            cbUatPc.Checked = true;
                            break;
                        case Data.kanban:
                            cbKanbanPc.Checked = true;
                            break;
                        case Data.timeTracking:
                            cbTimeTrackPc.Checked = true;
                            break;
                        case Data.buh20Rb:
                            cbBuh20RbPc.Checked = true;
                            break;
                        case Data.buhTruck:
                            cbBuhTruckRbPc.Checked = true;
                            break;
                        case Data.buhRbCopy:
                            cbBuhRbCopyPc.Checked = true;
                            break;
                        case Data.zupRb:
                            cbZupRbPc.Checked = true;
                            break;

                        default:
                            break;
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
            StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default);

            if (cb1cDoPc.Checked)
            {
                 sw.WriteLine(Data.doc);
            }

            if (cb1cBuhCorpPc.Checked)
            {
                sw.WriteLine(Data.buh);
            }

            if (cbUatPc.Checked)
            {
                sw.WriteLine(Data.uat);
            }

            if (cbUprPc.Checked)
            {
                sw.WriteLine(Data.upr);
            }
            
            if (cbZupPc.Checked)
            {
                sw.WriteLine(Data.zup);
            }

            if(cbKanbanPc.Checked)
            {
            sw.WriteLine(Data.kanban);
            }

            if (cbTimeTrackPc.Checked)
            {
                sw.WriteLine(Data.timeTracking);
            }
            if (cbBuh20RbPc.Checked)
            {
                sw.WriteLine(Data.buh20Rb);
            }
            if (cbBuhTruckRbPc.Checked)
            {
                sw.WriteLine(Data.buhTruck);
            }
            if (cbBuhRbCopyPc.Checked)
            {
                sw.WriteLine(Data.buhRbCopy);
            }
            if (cbZupRbPc.Checked)
            {
                sw.WriteLine(Data.zupRb);
            }
                      
            //close the file
            sw.Close();
                

            Base1CFormPC.ActiveForm.Close();

        }
    }
}
