using System;
using System.Windows.Forms;

namespace Omega_Jarvis.Printers
{
    public partial class PrintersChangeIp : Form
    {
        private Action<string> _pushToLogDelegate;

        public PrintersChangeIp(Action<string> pushToLogDelegate, bool pcChecked)
        {
            InitializeComponent();
            cbPc.Enabled = pcChecked;
            _pushToLogDelegate = pushToLogDelegate;
        }

        private void btnChangeIp_Click(object sender, EventArgs e)
        {
            if (cbPc.Checked)
            {
                Engine.ChangeIpPrinterAsync(txtPrinterName.Text, Data.PcName, txtNewIp.Text, _pushToLogDelegate);
            }
            if (cbTs01.Checked)
            {
                foreach (var item in Data.ts01)
                {
                    Engine.ChangeIpPrinterAsync(txtPrinterName.Text, item, txtNewIp.Text, _pushToLogDelegate);
                }
            }
            if (cbRDP.Checked)
            {
                foreach (var item in Data.rdp)
                {
                    Engine.ChangeIpPrinterAsync(txtPrinterName.Text, item, txtNewIp.Text, _pushToLogDelegate);
                }
            }
            if (cbMwmts02.Checked)
            {
                Engine.ChangeIpPrinterAsync(txtPrinterName.Text, Data.mwmts02, txtNewIp.Text, _pushToLogDelegate);
            }
            if (cbMwmts04.Checked)
            {
                Engine.ChangeIpPrinterAsync(txtPrinterName.Text, Data.mwmts04, txtNewIp.Text, _pushToLogDelegate);
            }
        }
    }
}
