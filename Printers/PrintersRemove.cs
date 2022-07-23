using System;
using System.Windows.Forms;

namespace Omega_Jarvis.Printers
{
    public partial class PrintersRemove : Form
    {
        private Action<string> _pushToLogDelegate;

        public PrintersRemove(Action<string> pushToLogDelegate, bool pcChecked)
        {
            InitializeComponent();
            cbPc.Enabled = pcChecked;
            _pushToLogDelegate = pushToLogDelegate;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbPc.Checked)
            {
                Engine.RemovePrinterAsync(txtPrinterName.Text, Data.PcName, _pushToLogDelegate);
            }
            if (cbTs01.Checked)
            {
                foreach (var item in Data.ts01)
                {
                    Engine.RemovePrinterAsync(txtPrinterName.Text, item, _pushToLogDelegate);
                }
            }
            if (cbRDP.Checked)
            {
                foreach (var item in Data.rdp)
                {
                    Engine.RemovePrinterAsync(txtPrinterName.Text, item, _pushToLogDelegate);
                }
            }
            if (cbMwmts02.Checked)
            {
                Engine.RemovePrinterAsync(txtPrinterName.Text, Data.mwmts02, _pushToLogDelegate);
            }
            if (cbMwmts04.Checked)
            {
                Engine.RemovePrinterAsync(txtPrinterName.Text, Data.mwmts04, _pushToLogDelegate);
            }
        }
    }
}
