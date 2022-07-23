using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Omega_Jarvis.Groups
{
    public partial class CopyGroups : Form
    {
        private string _groupsFromLogin;
        private string _groupsToLogin;

        public CopyGroups(string groupsFromLogin, string groupsToLogin)
        {
            InitializeComponent();
            _groupsFromLogin = groupsFromLogin;
            _groupsToLogin = groupsToLogin;
        }

        private void CopyGroups_Load(object sender, EventArgs e)
        {
            listBoxFrom.DataSource = Data.UserFromGroups;
            lblCountValueFrom.Text = Data.UserFromGroups.Count.ToString();
            lblGroupsFromLogin.Text = _groupsFromLogin;
            lblGroupsToLogin.Text = _groupsToLogin;
        }

        private void listBoxFrom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PushGroupTo();
        }

        private void PushGroupTo()
        {
            var selectedItems = listBoxFrom.SelectedItems;
            foreach (string item in selectedItems)
            {
                ListBoxTo.Items.Add(item);
                lblCountValueTo.Text = ListBoxTo.Items.Count.ToString();
            }
        }

        private void RemoveGroupTo()
        {
            List<string> items = new List<string>();

            var listBoxItems = ListBoxTo.SelectedItems;

            foreach (var item in listBoxItems)
            {
                items.Add(item.ToString());
            }

            foreach (var item in items)
            {
                ListBoxTo.Items.Remove(item);
            }
            lblCountValueTo.Text = ListBoxTo.Items.Count.ToString();
        }

        private void btnOneGroup_Click(object sender, EventArgs e)
        {
            PushGroupTo();
        }

        private void ListBoxTo_DoubleClick(object sender, EventArgs e)
        {
            RemoveGroupTo();
        }
    }
}
