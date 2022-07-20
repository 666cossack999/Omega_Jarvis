using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
