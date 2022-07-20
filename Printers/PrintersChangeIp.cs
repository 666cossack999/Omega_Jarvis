using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
