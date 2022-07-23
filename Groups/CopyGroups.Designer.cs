namespace Omega_Jarvis.Groups
{
    partial class CopyGroups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyGroups));
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCountValueTo = new System.Windows.Forms.Label();
            this.lblCountValueFrom = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAllGroupClear = new System.Windows.Forms.Button();
            this.btnAllGroupPush = new System.Windows.Forms.Button();
            this.btnGroupClear = new System.Windows.Forms.Button();
            this.btnGroupPush = new System.Windows.Forms.Button();
            this.ListBoxTo = new System.Windows.Forms.ListBox();
            this.lblGroupsToLogin = new System.Windows.Forms.Label();
            this.lblCountTo = new System.Windows.Forms.Label();
            this.lblCountFrom = new System.Windows.Forms.Label();
            this.lblGroupsFromLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 11);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(43, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "С кого:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(421, 11);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 13);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "Кому:";
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.Location = new System.Drawing.Point(3, 27);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFrom.Size = new System.Drawing.Size(341, 394);
            this.listBoxFrom.TabIndex = 1;
            this.listBoxFrom.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFrom_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCountValueTo);
            this.panel1.Controls.Add(this.lblCountValueFrom);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAllGroupClear);
            this.panel1.Controls.Add(this.btnAllGroupPush);
            this.panel1.Controls.Add(this.btnGroupClear);
            this.panel1.Controls.Add(this.btnGroupPush);
            this.panel1.Controls.Add(this.ListBoxTo);
            this.panel1.Controls.Add(this.listBoxFrom);
            this.panel1.Controls.Add(this.lblGroupsToLogin);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblCountTo);
            this.panel1.Controls.Add(this.lblCountFrom);
            this.panel1.Controls.Add(this.lblGroupsFromLogin);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 2;
            // 
            // lblCountValueTo
            // 
            this.lblCountValueTo.AutoSize = true;
            this.lblCountValueTo.Location = new System.Drawing.Point(725, 11);
            this.lblCountValueTo.Name = "lblCountValueTo";
            this.lblCountValueTo.Size = new System.Drawing.Size(0, 13);
            this.lblCountValueTo.TabIndex = 4;
            // 
            // lblCountValueFrom
            // 
            this.lblCountValueFrom.AutoSize = true;
            this.lblCountValueFrom.Location = new System.Drawing.Point(297, 11);
            this.lblCountValueFrom.Name = "lblCountValueFrom";
            this.lblCountValueFrom.Size = new System.Drawing.Size(0, 13);
            this.lblCountValueFrom.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAllGroupClear
            // 
            this.btnAllGroupClear.Location = new System.Drawing.Point(362, 270);
            this.btnAllGroupClear.Name = "btnAllGroupClear";
            this.btnAllGroupClear.Size = new System.Drawing.Size(44, 23);
            this.btnAllGroupClear.TabIndex = 2;
            this.btnAllGroupClear.Text = "<<-";
            this.btnAllGroupClear.UseVisualStyleBackColor = true;
            // 
            // btnAllGroupPush
            // 
            this.btnAllGroupPush.Location = new System.Drawing.Point(362, 181);
            this.btnAllGroupPush.Name = "btnAllGroupPush";
            this.btnAllGroupPush.Size = new System.Drawing.Size(44, 23);
            this.btnAllGroupPush.TabIndex = 2;
            this.btnAllGroupPush.Text = "->>";
            this.btnAllGroupPush.UseVisualStyleBackColor = true;
            // 
            // btnGroupClear
            // 
            this.btnGroupClear.Location = new System.Drawing.Point(362, 241);
            this.btnGroupClear.Name = "btnGroupClear";
            this.btnGroupClear.Size = new System.Drawing.Size(44, 23);
            this.btnGroupClear.TabIndex = 2;
            this.btnGroupClear.Text = "<-";
            this.btnGroupClear.UseVisualStyleBackColor = true;
            this.btnGroupClear.Click += new System.EventHandler(this.btnOneGroup_Click);
            // 
            // btnGroupPush
            // 
            this.btnGroupPush.Location = new System.Drawing.Point(362, 152);
            this.btnGroupPush.Name = "btnGroupPush";
            this.btnGroupPush.Size = new System.Drawing.Size(44, 23);
            this.btnGroupPush.TabIndex = 2;
            this.btnGroupPush.Text = "->";
            this.btnGroupPush.UseVisualStyleBackColor = true;
            this.btnGroupPush.Click += new System.EventHandler(this.btnOneGroup_Click);
            // 
            // ListBoxTo
            // 
            this.ListBoxTo.FormattingEnabled = true;
            this.ListBoxTo.Location = new System.Drawing.Point(424, 27);
            this.ListBoxTo.Name = "ListBoxTo";
            this.ListBoxTo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxTo.Size = new System.Drawing.Size(349, 394);
            this.ListBoxTo.Sorted = true;
            this.ListBoxTo.TabIndex = 1;
            this.ListBoxTo.DoubleClick += new System.EventHandler(this.ListBoxTo_DoubleClick);
            // 
            // lblGroupsToLogin
            // 
            this.lblGroupsToLogin.AutoSize = true;
            this.lblGroupsToLogin.Location = new System.Drawing.Point(457, 11);
            this.lblGroupsToLogin.Name = "lblGroupsToLogin";
            this.lblGroupsToLogin.Size = new System.Drawing.Size(0, 13);
            this.lblGroupsToLogin.TabIndex = 0;
            // 
            // lblCountTo
            // 
            this.lblCountTo.AutoSize = true;
            this.lblCountTo.Location = new System.Drawing.Point(654, 11);
            this.lblCountTo.Name = "lblCountTo";
            this.lblCountTo.Size = new System.Drawing.Size(75, 13);
            this.lblCountTo.TabIndex = 0;
            this.lblCountTo.Text = "Кол-во групп:";
            // 
            // lblCountFrom
            // 
            this.lblCountFrom.AutoSize = true;
            this.lblCountFrom.Location = new System.Drawing.Point(225, 11);
            this.lblCountFrom.Name = "lblCountFrom";
            this.lblCountFrom.Size = new System.Drawing.Size(75, 13);
            this.lblCountFrom.TabIndex = 0;
            this.lblCountFrom.Text = "Кол-во групп:";
            // 
            // lblGroupsFromLogin
            // 
            this.lblGroupsFromLogin.AutoSize = true;
            this.lblGroupsFromLogin.Location = new System.Drawing.Point(46, 11);
            this.lblGroupsFromLogin.Name = "lblGroupsFromLogin";
            this.lblGroupsFromLogin.Size = new System.Drawing.Size(0, 13);
            this.lblGroupsFromLogin.TabIndex = 0;
            // 
            // CopyGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CopyGroups";
            this.Text = "CopyGroups";
            this.Load += new System.EventHandler(this.CopyGroups_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAllGroupPush;
        private System.Windows.Forms.Button btnGroupPush;
        private System.Windows.Forms.ListBox ListBoxTo;
        private System.Windows.Forms.Label lblCountValueFrom;
        private System.Windows.Forms.Label lblCountTo;
        private System.Windows.Forms.Label lblCountFrom;
        private System.Windows.Forms.Label lblCountValueTo;
        private System.Windows.Forms.Label lblGroupsToLogin;
        private System.Windows.Forms.Label lblGroupsFromLogin;
        private System.Windows.Forms.Button btnAllGroupClear;
        private System.Windows.Forms.Button btnGroupClear;
    }
}