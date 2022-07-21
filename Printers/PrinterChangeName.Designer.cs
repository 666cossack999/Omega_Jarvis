namespace Omega_Jarvis.Printers
{
    partial class PrinterChangeName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrinterChangeName));
            this.gbPrinterChangeName = new System.Windows.Forms.GroupBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.cbMwmts04 = new System.Windows.Forms.CheckBox();
            this.cbMwmts02 = new System.Windows.Forms.CheckBox();
            this.cbRDP = new System.Windows.Forms.CheckBox();
            this.cbTs01 = new System.Windows.Forms.CheckBox();
            this.cbPc = new System.Windows.Forms.CheckBox();
            this.lbNewName = new System.Windows.Forms.Label();
            this.lbOldName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtOldName = new System.Windows.Forms.TextBox();
            this.gbPrinterChangeName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrinterChangeName
            // 
            this.gbPrinterChangeName.Controls.Add(this.btnChangeName);
            this.gbPrinterChangeName.Controls.Add(this.cbMwmts04);
            this.gbPrinterChangeName.Controls.Add(this.cbMwmts02);
            this.gbPrinterChangeName.Controls.Add(this.cbRDP);
            this.gbPrinterChangeName.Controls.Add(this.cbTs01);
            this.gbPrinterChangeName.Controls.Add(this.cbPc);
            this.gbPrinterChangeName.Controls.Add(this.lbNewName);
            this.gbPrinterChangeName.Controls.Add(this.lbOldName);
            this.gbPrinterChangeName.Controls.Add(this.txtNewName);
            this.gbPrinterChangeName.Controls.Add(this.txtOldName);
            this.gbPrinterChangeName.Location = new System.Drawing.Point(12, 12);
            this.gbPrinterChangeName.Name = "gbPrinterChangeName";
            this.gbPrinterChangeName.Size = new System.Drawing.Size(357, 125);
            this.gbPrinterChangeName.TabIndex = 0;
            this.gbPrinterChangeName.TabStop = false;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(6, 56);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(251, 63);
            this.btnChangeName.TabIndex = 2;
            this.btnChangeName.Text = "Сменить имя";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // cbMwmts04
            // 
            this.cbMwmts04.AutoSize = true;
            this.cbMwmts04.Location = new System.Drawing.Point(271, 102);
            this.cbMwmts04.Name = "cbMwmts04";
            this.cbMwmts04.Size = new System.Drawing.Size(73, 17);
            this.cbMwmts04.TabIndex = 2;
            this.cbMwmts04.Text = "m-wmts04";
            this.cbMwmts04.UseVisualStyleBackColor = true;
            // 
            // cbMwmts02
            // 
            this.cbMwmts02.AutoSize = true;
            this.cbMwmts02.Location = new System.Drawing.Point(271, 79);
            this.cbMwmts02.Name = "cbMwmts02";
            this.cbMwmts02.Size = new System.Drawing.Size(73, 17);
            this.cbMwmts02.TabIndex = 2;
            this.cbMwmts02.Text = "m-wmts02";
            this.cbMwmts02.UseVisualStyleBackColor = true;
            // 
            // cbRDP
            // 
            this.cbRDP.AutoSize = true;
            this.cbRDP.Location = new System.Drawing.Point(271, 56);
            this.cbRDP.Name = "cbRDP";
            this.cbRDP.Size = new System.Drawing.Size(49, 17);
            this.cbRDP.TabIndex = 2;
            this.cbRDP.Text = "RDP";
            this.cbRDP.UseVisualStyleBackColor = true;
            // 
            // cbTs01
            // 
            this.cbTs01.AutoSize = true;
            this.cbTs01.Location = new System.Drawing.Point(271, 33);
            this.cbTs01.Name = "cbTs01";
            this.cbTs01.Size = new System.Drawing.Size(52, 17);
            this.cbTs01.TabIndex = 2;
            this.cbTs01.Text = "TS01";
            this.cbTs01.UseVisualStyleBackColor = true;
            // 
            // cbPc
            // 
            this.cbPc.AutoSize = true;
            this.cbPc.Location = new System.Drawing.Point(271, 10);
            this.cbPc.Name = "cbPc";
            this.cbPc.Size = new System.Drawing.Size(41, 17);
            this.cbPc.TabIndex = 2;
            this.cbPc.Text = "ПК";
            this.cbPc.UseVisualStyleBackColor = true;
            // 
            // lbNewName
            // 
            this.lbNewName.AutoSize = true;
            this.lbNewName.Location = new System.Drawing.Point(145, 14);
            this.lbNewName.Name = "lbNewName";
            this.lbNewName.Size = new System.Drawing.Size(112, 13);
            this.lbNewName.TabIndex = 1;
            this.lbNewName.Text = "Новое имя принтера";
            // 
            // lbOldName
            // 
            this.lbOldName.AutoSize = true;
            this.lbOldName.Location = new System.Drawing.Point(6, 14);
            this.lbOldName.Name = "lbOldName";
            this.lbOldName.Size = new System.Drawing.Size(116, 13);
            this.lbOldName.TabIndex = 1;
            this.lbOldName.Text = "Старое имя принтера";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(145, 30);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(112, 20);
            this.txtNewName.TabIndex = 1;
            // 
            // txtOldName
            // 
            this.txtOldName.Location = new System.Drawing.Point(6, 30);
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.Size = new System.Drawing.Size(133, 20);
            this.txtOldName.TabIndex = 0;
            // 
            // PrinterChangeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 145);
            this.Controls.Add(this.gbPrinterChangeName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrinterChangeName";
            this.Text = "Сменить имя принтера";
            this.gbPrinterChangeName.ResumeLayout(false);
            this.gbPrinterChangeName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrinterChangeName;
        private System.Windows.Forms.CheckBox cbMwmts04;
        private System.Windows.Forms.CheckBox cbMwmts02;
        private System.Windows.Forms.CheckBox cbRDP;
        private System.Windows.Forms.CheckBox cbTs01;
        private System.Windows.Forms.CheckBox cbPc;
        private System.Windows.Forms.Label lbNewName;
        private System.Windows.Forms.Label lbOldName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtOldName;
        private System.Windows.Forms.Button btnChangeName;
    }
}