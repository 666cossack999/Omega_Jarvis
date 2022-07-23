using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Omega_Jarvis.Groups
{
    public partial class CopyGroups : Form
    {
        private string _groupsFromLogin;
        private string _groupsToLogin;
        private Action<string> _pushToLogValueDelegate;

        public CopyGroups(string groupsFromLogin, string groupsToLogin, Action<string> pushToLogValueDelegate)
        {
            InitializeComponent();
            _groupsFromLogin = groupsFromLogin;
            _groupsToLogin = groupsToLogin;
            _pushToLogValueDelegate = pushToLogValueDelegate;
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

        /// <summary>
        /// Добавляет элемент в список кому
        /// </summary>
        private void PushGroupTo()
        {
            var selectedItems = listBoxFrom.SelectedItems;
            foreach (string item in selectedItems)
            {
                ListBoxTo.Items.Add(item);
                lblCountValueTo.Text = ListBoxTo.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Удаляет элемент из списка "Кому"
        /// </summary>
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

        private void btnGroupPush_Click(object sender, EventArgs e)
        {
            PushGroupTo();
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            RemoveGroupTo();
        }

        private void ListBoxTo_DoubleClick(object sender, EventArgs e)
        {
            RemoveGroupTo();
        }

        private void btnAllGroupPush_Click(object sender, EventArgs e)
        {
            foreach (var item in Data.UserFromGroups)
            {
                ListBoxTo.Items.Add(item);
            }
            lblCountValueTo.Text = ListBoxTo.Items.Count.ToString();
        }

        private void btnAllGroupClear_Click(object sender, EventArgs e)
        {
            ListBoxTo.Items.Clear();
            lblCountValueTo.Text = ListBoxTo.Items.Count.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (string item in ListBoxTo.Items)
            {
                Engine.PushUserToGroupAsync(_groupsToLogin, item, _pushToLogValueDelegate);
            }
            
        }
    }
}
