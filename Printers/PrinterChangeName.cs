using System;
using System.Windows.Forms;

namespace Omega_Jarvis.Printers
{
    public partial class PrinterChangeName : Form
    {
        private Action<string> _pushToLogDelegate;
        public PrinterChangeName(Action<string> pushToLogDelegate, bool pcChecked)
        {
            InitializeComponent();
            cbPc.Enabled = pcChecked;
            _pushToLogDelegate = pushToLogDelegate;
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if (cbPc.Checked)
            {
                Engine.ChangeNamePrinterAsync(Data.PcName, txtOldName.Text, txtNewName.Text, _pushToLogDelegate);
            }
            if (cbTs01.Checked)
            {
                foreach (var item in Data.ts01)
                {
                    Engine.ChangeNamePrinterAsync(item, txtOldName.Text, txtNewName.Text, _pushToLogDelegate);
                }
            }
            if (cbRDP.Checked)
            {
                foreach (var item in Data.rdp)
                {
                    Engine.ChangeNamePrinterAsync(item, txtOldName.Text, txtNewName.Text, _pushToLogDelegate);
                }
            }
            if (cbMwmts02.Checked)
            {
                Engine.ChangeNamePrinterAsync(Data.mwmts02, txtOldName.Text, txtNewName.Text, _pushToLogDelegate);
            }
            if (cbMwmts04.Checked)
            {
                Engine.ChangeNamePrinterAsync(Data.mwmts04, txtOldName.Text, txtNewName.Text, _pushToLogDelegate);
            }
        }
    }
}
