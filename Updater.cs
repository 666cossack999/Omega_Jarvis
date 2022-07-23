using System;
using System.Windows.Forms;

namespace Omega_Jarvis
{
    public partial class Updater : Form
    {
        private static string _updateUri;
        private Action<long> _setMaximumProgressBar;
        private Action _progressBarValueStep;
        public Updater(string updateUri)
        {
            InitializeComponent();
            _updateUri = updateUri;
            _setMaximumProgressBar = SetMaximumProgressBar;
            _progressBarValueStep = StepProgressBar;
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            OmegaClient.DownloadFile(_updateUri, _setMaximumProgressBar, _progressBarValueStep);
            label1.Text = "Загружено";
        }

        private void SetMaximumProgressBar(long maximum)
        {
            pbUpdate.Maximum = (int)maximum;
        }

        private void StepProgressBar()
        {
            pbUpdate.Value++;
        }
    }
}
