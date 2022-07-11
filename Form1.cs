using System;
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

