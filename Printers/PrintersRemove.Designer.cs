namespace Omega_Jarvis.Printers
{
    partial class PrintersRemove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintersRemove));
            this.gbPrintersRemove = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbMwmts02 = new System.Windows.Forms.CheckBox();
            this.cbMwmts04 = new System.Windows.Forms.CheckBox();
            this.cbRDP = new System.Windows.Forms.CheckBox();
            this.cbTs01 = new System.Windows.Forms.CheckBox();
            this.cbPc = new System.Windows.Forms.CheckBox();
            this.lbPrinterName = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.gbPrintersRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrintersRemove
            // 
            this.gbPrintersRemove.Controls.Add(this.btnRemove);
            this.gbPrintersRemove.Controls.Add(this.cbMwmts02);
            this.gbPrintersRemove.Controls.Add(this.cbMwmts04);
            this.gbPrintersRemove.Controls.Add(this.cbRDP);
            this.gbPrintersRemove.Controls.Add(this.cbTs01);
            this.gbPrintersRemove.Controls.Add(this.cbPc);
            this.gbPrintersRemove.Controls.Add(this.lbPrinterName);
            this.gbPrintersRemove.Controls.Add(this.txtPrinterName);
            this.gbPrintersRemove.Location = new System.Drawing.Point(12, 12);
            this.gbPrintersRemove.Name = "gbPrintersRemove";
            this.gbPrintersRemove.Size = new System.Drawing.Size(201, 138);
            this.gbPrintersRemove.TabIndex = 0;
            this.gbPrintersRemove.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(6, 62);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 63);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbMwmts02
            // 
            this.cbMwmts02.AutoSize = true;
            this.cbMwmts02.Location = new System.Drawing.Point(117, 85);
            this.cbMwmts02.Name = "cbMwmts02";
            this.cbMwmts02.Size = new System.Drawing.Size(73, 17);
            this.cbMwmts02.TabIndex = 1;
            this.cbMwmts02.Text = "m-wmts02";
            this.cbMwmts02.UseVisualStyleBackColor = true;
            // 
            // cbMwmts04
            // 
            this.cbMwmts04.AutoSize = true;
            this.cbMwmts04.Location = new System.Drawing.Point(117, 108);
            this.cbMwmts04.Name = "cbMwmts04";
            this.cbMwmts04.Size = new System.Drawing.Size(73, 17);
            this.cbMwmts04.TabIndex = 1;
            this.cbMwmts04.Text = "m-wmts04";
            this.cbMwmts04.UseVisualStyleBackColor = true;
            // 
            // cbRDP
            // 
            this.cbRDP.AutoSize = true;
            this.cbRDP.Location = new System.Drawing.Point(117, 62);
            this.cbRDP.Name = "cbRDP";
            this.cbRDP.Size = new System.Drawing.Size(49, 17);
            this.cbRDP.TabIndex = 1;
            this.cbRDP.Text = "RDP";
            this.cbRDP.UseVisualStyleBackColor = true;
            // 
            // cbTs01
            // 
            this.cbTs01.AutoSize = true;
            this.cbTs01.Location = new System.Drawing.Point(117, 39);
            this.cbTs01.Name = "cbTs01";
            this.cbTs01.Size = new System.Drawing.Size(52, 17);
            this.cbTs01.TabIndex = 1;
            this.cbTs01.Text = "TS01";
            this.cbTs01.UseVisualStyleBackColor = true;
            // 
            // cbPc
            // 
            this.cbPc.AutoSize = true;
            this.cbPc.Location = new System.Drawing.Point(117, 16);
            this.cbPc.Name = "cbPc";
            this.cbPc.Size = new System.Drawing.Size(41, 17);
            this.cbPc.TabIndex = 1;
            this.cbPc.Text = "ПК";
            this.cbPc.UseVisualStyleBackColor = true;
            // 
            // lbPrinterName
            // 
            this.lbPrinterName.AutoSize = true;
            this.lbPrinterName.Location = new System.Drawing.Point(6, 20);
            this.lbPrinterName.Name = "lbPrinterName";
            this.lbPrinterName.Size = new System.Drawing.Size(79, 13);
            this.lbPrinterName.TabIndex = 1;
            this.lbPrinterName.Text = "Имя принтера";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(6, 36);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(100, 20);
            this.txtPrinterName.TabIndex = 0;
            // 
            // PrintersRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 157);
            this.Controls.Add(this.gbPrintersRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintersRemove";
            this.Text = "Удалить принтер";
            this.gbPrintersRemove.ResumeLayout(false);
            this.gbPrintersRemove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrintersRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox cbRDP;
        private System.Windows.Forms.CheckBox cbTs01;
        private System.Windows.Forms.CheckBox cbPc;
        private System.Windows.Forms.Label lbPrinterName;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.CheckBox cbMwmts02;
        private System.Windows.Forms.CheckBox cbMwmts04;
    }
}