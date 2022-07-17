using System;
using System.IO;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class Base1CFormServer : Form
    {
        readonly Form1 form1;
        public Base1CFormServer(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();

            //Путь до файла
            try
            {
                StreamReader sr = new StreamReader(Data.ConfigOnServer, System.Text.Encoding.Default);
                //Читаем первую строку
                var line = sr.ReadLine();
                //Продолжаем читать весь файл
                while (line != null)
                {
                    switch (line)
                    {
                        case Data.doc:
                            cb1cDoSrv.Checked = true;
                            break;
                        case Data.buh:
                            cb1cBuhCorpSrv.Checked = true;
                            break;
                        case Data.upr:
                            cbUprSrv.Checked = true;
                            break;
                        case Data.zup:
                            cbZupSrv.Checked = true;
                            break;
                        case Data.uat:
                            cbUatSrv.Checked = true;
                            break;
                        case Data.kanban:
                            cbKanbanSrv.Checked = true;
                            break;
                        case Data.timeTracking:
                            cbTimeTrackSrv.Checked = true;
                            break;
                        case Data.buh20Rb:
                            cbBuh20RbSrv.Checked = true;
                            break;
                        case Data.buhTruck:
                            cbBuhTruckRbSrv.Checked = true;
                            break;
                        case Data.buhRbCopy:
                            cbBuhRbCopySrv.Checked = true;
                            break;
                        case Data.zupRb:
                            cbZupRbSrv.Checked = true;
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
                 
            StreamWriter sw = new StreamWriter(Data.ConfigOnServer, false, System.Text.Encoding.Default);

            if (cb1cDoSrv.Checked)
            {
                sw.WriteLine(Data.doc);
            }
            
            if (cb1cBuhCorpSrv.Checked)
            {
                sw.WriteLine(Data.buh);
                Engine.AddUserToGroup(Data.Login, Data.adBuh);
                form1.PushToLog($"Добавлен в группу: {Data.adBuh}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adBuh);
                    form1.PushToLog($"Удалён из группы: {Data.adBuh}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adBuh}");
                }
                
            }
            
            if (cbUatSrv.Checked)
            {
                sw.WriteLine(Data.uat);
                Engine.AddUserToGroup(Data.Login, Data.adUat);
                form1.PushToLog($"Добавлен в группу: {Data.adUat}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adUat);
                    form1.PushToLog($"Удалён из группы: {Data.adUat}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adUat}");
                }                
            }
                   
            if (cbUprSrv.Checked)
            {
                sw.WriteLine(Data.upr);
                Engine.AddUserToGroup(Data.Login, Data.adUpr);
                form1.PushToLog($"Добавлен в группу: {Data.adUpr}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adUpr);
                    form1.PushToLog($"Удалён из группы: {Data.adUpr}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adUpr}");
                }
                
            }
            
            if (cbZupSrv.Checked)
            {
                sw.WriteLine(Data.zup);
                Engine.AddUserToGroup(Data.Login, Data.adZup);
                form1.PushToLog($"Добавлен в группу: {Data.adZup}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adZup);
                    form1.PushToLog($"Удалён из группы: {Data.adZup}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adZup}");
                }
                
            }
        
            if (cbKanbanSrv.Checked)
            {
                sw.WriteLine(Data.kanban);
                Engine.AddUserToGroup(Data.Login, Data.adKanban);
                form1.PushToLog($"Добавлен в группу: {Data.adKanban}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adKanban);
                    form1.PushToLog($"Удалён из группы: {Data.adKanban}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adKanban}");
                }
                
            }

            if (cbTimeTrackSrv.Checked)
            {
                sw.WriteLine(Data.timeTracking);
                Engine.AddUserToGroup(Data.Login, Data.adTimeTracking);
                form1.PushToLog($"Добавлен в группу: {Data.adTimeTracking}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adTimeTracking);
                    form1.PushToLog($"Удалён из группы: {Data.adTimeTracking}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adTimeTracking}");
                }
                
            }
        
            if (cbBuh20RbSrv.Checked)
            {
                sw.WriteLine(Data.buh20Rb);
                Engine.AddUserToGroup(Data.Login, Data.adBuh20Rb);
                form1.PushToLog($"Добавлен в группу: {Data.adBuh20Rb}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adBuh20Rb);
                    form1.PushToLog($"Удалён из группы: {Data.adBuh20Rb}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adBuh20Rb}");
                }
                
            }
        
            if (cbBuhTruckRbSrv.Checked)
            {
                sw.WriteLine(Data.buhTruck);
                Engine.AddUserToGroup(Data.Login, Data.adBuhTruck);
                form1.PushToLog($"Добавлен в группу: {Data.adBuhTruck}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adBuhTruck);
                    form1.PushToLog($"Удалён из группы: {Data.adBuhTruck}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adBuhTruck}");
                }
                
            }
        
            if (cbBuhRbCopySrv.Checked)
            {
                sw.WriteLine(Data.buhRbCopy);
                Engine.AddUserToGroup(Data.Login, Data.adBuhRbCopy);
                form1.PushToLog($"Добавлен в группу: {Data.adBuhRbCopy}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adBuhRbCopy);
                    form1.PushToLog($"Удалён из группы: {Data.adBuhRbCopy}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adBuhRbCopy}");
                }
                
            }

            if (cbZupRbSrv.Checked)
            {
                sw.WriteLine(Data.zupRb);
                Engine.AddUserToGroup(Data.Login, Data.adZupRb);
                form1.PushToLog($"Добавлен в группу: {Data.adZupRb}");
            }
            else
            {
                try
                {
                    Engine.DeleteUserFromGroup(Data.Login, Data.adZupRb);
                    form1.PushToLog($"Удалён из группы: {Data.adZupRb}");
                }
                catch (Exception)
                {
                    form1.PushToLog($"Не состоит в группе {Data.adZupRb}");
                }
                
            }
        
            //close the file
            sw.Close();

            Base1CFormServer.ActiveForm.Close();
        }

        private void Base1CFormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Engine.DismountDisk();
        }

    }
}
