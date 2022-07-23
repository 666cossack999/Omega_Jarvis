using System;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class PrintersAdd : Form
    {
        private Action<string> _PushToLogDelegate;

        public PrintersAdd(Action<string> pushToLogDelegate, bool pcChecked)
        {
            InitializeComponent();
            cboxDrivers.DataSource = Data.PrinterDrivers;
            _PushToLogDelegate = pushToLogDelegate;
            cbPrinterToPc.Enabled = pcChecked;
        }

        private void btnPrinterAdd_Click(object sender, EventArgs e)
        {
            if (cbPrinterToPc.Checked)
            {
                Engine.AddPrinterAsync(Data.PcName, txtPrinterIp.Text, txtPrinterName.Text, cboxDrivers.Text, _PushToLogDelegate);
            }
            if (cbPrinterToTs01.Checked)
            {
                foreach (string item in Data.ts01)
                {
                    Engine.AddPrinterAsync(item, txtPrinterIp.Text, txtPrinterName.Text, cboxDrivers.Text, _PushToLogDelegate);
                }
            }
            if (cbPrinterToRdp.Checked)
            {
                foreach (var item in Data.rdp)
                {
                    Engine.AddPrinterAsync(item, txtPrinterIp.Text, txtPrinterName.Text, cboxDrivers.Text, _PushToLogDelegate);
                }
            }
            if (cbPrinterToMwmts02.Checked)
            {
                Engine.AddPrinterAsync(Data.mwmts02, txtPrinterIp.Text, txtPrinterName.Text, cboxDrivers.Text, _PushToLogDelegate);
            }
            if (cbPrinterToMwmts04.Checked)
            {
                Engine.AddPrinterAsync(Data.mwmts04, txtPrinterIp.Text, txtPrinterName.Text, cboxDrivers.Text, _PushToLogDelegate);
            }
        }
    }
}
