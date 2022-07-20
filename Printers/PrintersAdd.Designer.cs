namespace Omega_Jarvis
{
    partial class PrintersAdd
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
            this.txtPrinterIp = new System.Windows.Forms.TextBox();
            this.lbPrinterIp = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.lbPrinterName = new System.Windows.Forms.Label();
            this.lbPrinterDriver = new System.Windows.Forms.Label();
            this.gbPrintersAdd = new System.Windows.Forms.GroupBox();
            this.cboxDrivers = new System.Windows.Forms.ComboBox();
            this.btnPrinterAdd = new System.Windows.Forms.Button();
            this.cbPrinterToMwmts04 = new System.Windows.Forms.CheckBox();
            this.cbPrinterToMwmts02 = new System.Windows.Forms.CheckBox();
            this.cbPrinterToRdp = new System.Windows.Forms.CheckBox();
            this.cbPrinterToTs01 = new System.Windows.Forms.CheckBox();
            this.cbPrinterToPc = new System.Windows.Forms.CheckBox();
            this.gbPrintersAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrinterIp
            // 
            this.txtPrinterIp.Location = new System.Drawing.Point(9, 32);
            this.txtPrinterIp.Name = "txtPrinterIp";
            this.txtPrinterIp.Size = new System.Drawing.Size(158, 20);
            this.txtPrinterIp.TabIndex = 0;
            // 
            // lbPrinterIp
            // 
            this.lbPrinterIp.AutoSize = true;
            this.lbPrinterIp.Location = new System.Drawing.Point(6, 16);
            this.lbPrinterIp.Name = "lbPrinterIp";
            this.lbPrinterIp.Size = new System.Drawing.Size(100, 13);
            this.lbPrinterIp.TabIndex = 1;
            this.lbPrinterIp.Text = "IP-адрес принтера";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(173, 32);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(153, 20);
            this.txtPrinterName.TabIndex = 0;
            // 
            // lbPrinterName
            // 
            this.lbPrinterName.AutoSize = true;
            this.lbPrinterName.Location = new System.Drawing.Point(170, 16);
            this.lbPrinterName.Name = "lbPrinterName";
            this.lbPrinterName.Size = new System.Drawing.Size(79, 13);
            this.lbPrinterName.TabIndex = 1;
            this.lbPrinterName.Text = "Имя принтера";
            // 
            // lbPrinterDriver
            // 
            this.lbPrinterDriver.AutoSize = true;
            this.lbPrinterDriver.Location = new System.Drawing.Point(329, 16);
            this.lbPrinterDriver.Name = "lbPrinterDriver";
            this.lbPrinterDriver.Size = new System.Drawing.Size(130, 13);
            this.lbPrinterDriver.TabIndex = 1;
            this.lbPrinterDriver.Text = "Имя драйвера принтера";
            // 
            // gbPrintersAdd
            // 
            this.gbPrintersAdd.Controls.Add(this.cboxDrivers);
            this.gbPrintersAdd.Controls.Add(this.btnPrinterAdd);
            this.gbPrintersAdd.Controls.Add(this.cbPrinterToMwmts04);
            this.gbPrintersAdd.Controls.Add(this.cbPrinterToMwmts02);
            this.gbPrintersAdd.Controls.Add(this.cbPrinterToRdp);
            this.gbPrintersAdd.Controls.Add(this.cbPrinterToTs01);
            this.gbPrintersAdd.Controls.Add(this.cbPrinterToPc);
            this.gbPrintersAdd.Controls.Add(this.lbPrinterIp);
            this.gbPrintersAdd.Controls.Add(this.lbPrinterDriver);
            this.gbPrintersAdd.Controls.Add(this.txtPrinterIp);
            this.gbPrintersAdd.Controls.Add(this.lbPrinterName);
            this.gbPrintersAdd.Controls.Add(this.txtPrinterName);
            this.gbPrintersAdd.Location = new System.Drawing.Point(12, 12);
            this.gbPrintersAdd.Name = "gbPrintersAdd";
            this.gbPrintersAdd.Size = new System.Drawing.Size(534, 97);
            this.gbPrintersAdd.TabIndex = 2;
            this.gbPrintersAdd.TabStop = false;
            // 
            // cboxDrivers
            // 
            this.cboxDrivers.FormattingEnabled = true;
            this.cboxDrivers.Location = new System.Drawing.Point(332, 31);
            this.cboxDrivers.Name = "cboxDrivers";
            this.cboxDrivers.Size = new System.Drawing.Size(196, 21);
            this.cboxDrivers.TabIndex = 3;
            // 
            // btnPrinterAdd
            // 
            this.btnPrinterAdd.Location = new System.Drawing.Point(412, 58);
            this.btnPrinterAdd.Name = "btnPrinterAdd";
            this.btnPrinterAdd.Size = new System.Drawing.Size(116, 23);
            this.btnPrinterAdd.TabIndex = 3;
            this.btnPrinterAdd.Text = "Добавить";
            this.btnPrinterAdd.UseVisualStyleBackColor = true;
            this.btnPrinterAdd.Click += new System.EventHandler(this.btnPrinterAdd_Click);
            // 
            // cbPrinterToMwmts04
            // 
            this.cbPrinterToMwmts04.AutoSize = true;
            this.cbPrinterToMwmts04.Location = new System.Drawing.Point(316, 62);
            this.cbPrinterToMwmts04.Name = "cbPrinterToMwmts04";
            this.cbPrinterToMwmts04.Size = new System.Drawing.Size(90, 17);
            this.cbPrinterToMwmts04.TabIndex = 2;
            this.cbPrinterToMwmts04.Text = "На m-wmts04";
            this.cbPrinterToMwmts04.UseVisualStyleBackColor = true;
            // 
            // cbPrinterToMwmts02
            // 
            this.cbPrinterToMwmts02.AutoSize = true;
            this.cbPrinterToMwmts02.Location = new System.Drawing.Point(220, 62);
            this.cbPrinterToMwmts02.Name = "cbPrinterToMwmts02";
            this.cbPrinterToMwmts02.Size = new System.Drawing.Size(90, 17);
            this.cbPrinterToMwmts02.TabIndex = 2;
            this.cbPrinterToMwmts02.Text = "На m-wmts02";
            this.cbPrinterToMwmts02.UseVisualStyleBackColor = true;
            // 
            // cbPrinterToRdp
            // 
            this.cbPrinterToRdp.AutoSize = true;
            this.cbPrinterToRdp.Location = new System.Drawing.Point(148, 62);
            this.cbPrinterToRdp.Name = "cbPrinterToRdp";
            this.cbPrinterToRdp.Size = new System.Drawing.Size(66, 17);
            this.cbPrinterToRdp.TabIndex = 2;
            this.cbPrinterToRdp.Text = "На RDP";
            this.cbPrinterToRdp.UseVisualStyleBackColor = true;
            // 
            // cbPrinterToTs01
            // 
            this.cbPrinterToTs01.AutoSize = true;
            this.cbPrinterToTs01.Location = new System.Drawing.Point(73, 62);
            this.cbPrinterToTs01.Name = "cbPrinterToTs01";
            this.cbPrinterToTs01.Size = new System.Drawing.Size(69, 17);
            this.cbPrinterToTs01.TabIndex = 2;
            this.cbPrinterToTs01.Text = "На TS01";
            this.cbPrinterToTs01.UseVisualStyleBackColor = true;
            // 
            // cbPrinterToPc
            // 
            this.cbPrinterToPc.AutoSize = true;
            this.cbPrinterToPc.Location = new System.Drawing.Point(9, 62);
            this.cbPrinterToPc.Name = "cbPrinterToPc";
            this.cbPrinterToPc.Size = new System.Drawing.Size(58, 17);
            this.cbPrinterToPc.TabIndex = 2;
            this.cbPrinterToPc.Text = "На ПК";
            this.cbPrinterToPc.UseVisualStyleBackColor = true;
            // 
            // PrintersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 122);
            this.Controls.Add(this.gbPrintersAdd);
            this.Name = "PrintersAdd";
            this.Text = "Добавить принтер";
            this.gbPrintersAdd.ResumeLayout(false);
            this.gbPrintersAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrinterIp;
        private System.Windows.Forms.Label lbPrinterIp;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label lbPrinterName;
        private System.Windows.Forms.Label lbPrinterDriver;
        private System.Windows.Forms.GroupBox gbPrintersAdd;
        private System.Windows.Forms.CheckBox cbPrinterToMwmts04;
        private System.Windows.Forms.CheckBox cbPrinterToMwmts02;
        private System.Windows.Forms.CheckBox cbPrinterToRdp;
        private System.Windows.Forms.CheckBox cbPrinterToTs01;
        private System.Windows.Forms.CheckBox cbPrinterToPc;
        private System.Windows.Forms.Button btnPrinterAdd;
        private System.Windows.Forms.ComboBox cboxDrivers;
    }
}