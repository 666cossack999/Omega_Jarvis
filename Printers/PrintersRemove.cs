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
        }
    }
}
