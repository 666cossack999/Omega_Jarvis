namespace Omega_Jarvis
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPC = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labelPC = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.gbAllButtons = new System.Windows.Forms.GroupBox();
            this.gbPrinters = new System.Windows.Forms.GroupBox();
            this.rbPrintersToRdp = new System.Windows.Forms.RadioButton();
            this.rbPrintersToMwmts = new System.Windows.Forms.RadioButton();
            this.rbPrintersToTs01 = new System.Windows.Forms.RadioButton();
            this.rbPrintersToPc = new System.Windows.Forms.RadioButton();
            this.btnPrinters = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.gbBase1C = new System.Windows.Forms.GroupBox();
            this.btnBase1C = new System.Windows.Forms.Button();
            this.rb1CToServer = new System.Windows.Forms.RadioButton();
            this.rb1CToPC = new System.Windows.Forms.RadioButton();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.gbAllButtons.SuspendLayout();
            this.gbPrinters.SuspendLayout();
            this.gbBase1C.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(12, 29);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(178, 20);
            this.txtPC.TabIndex = 0;
            this.txtPC.TextChanged += new System.EventHandler(this.txtPC_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(199, 29);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // labelPC
            // 
            this.labelPC.AutoSize = true;
            this.labelPC.Location = new System.Drawing.Point(12, 9);
            this.labelPC.Name = "labelPC";
            this.labelPC.Size = new System.Drawing.Size(50, 13);
            this.labelPC.TabIndex = 1;
            this.labelPC.Text = "Имя ПК:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(201, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // gbAllButtons
            // 
            this.gbAllButtons.Controls.Add(this.gbPrinters);
            this.gbAllButtons.Controls.Add(this.lblProgress);
            this.gbAllButtons.Controls.Add(this.gbBase1C);
            this.gbAllButtons.Location = new System.Drawing.Point(12, 55);
            this.gbAllButtons.Name = "gbAllButtons";
            this.gbAllButtons.Size = new System.Drawing.Size(367, 383);
            this.gbAllButtons.TabIndex = 2;
            this.gbAllButtons.TabStop = false;
            // 
            // gbPrinters
            // 
            this.gbPrinters.Controls.Add(this.rbPrintersToRdp);
            this.gbPrinters.Controls.Add(this.rbPrintersToMwmts);
            this.gbPrinters.Controls.Add(this.rbPrintersToTs01);
            this.gbPrinters.Controls.Add(this.rbPrintersToPc);
            this.gbPrinters.Controls.Add(this.btnPrinters);
            this.gbPrinters.Location = new System.Drawing.Point(6, 85);
            this.gbPrinters.Name = "gbPrinters";
            this.gbPrinters.Size = new System.Drawing.Size(355, 69);
            this.gbPrinters.TabIndex = 8;
            this.gbPrinters.TabStop = false;
            this.gbPrinters.Text = "Принтеры";
            // 
            // rbPrintersToRdp
            // 
            this.rbPrintersToRdp.AutoSize = true;
            this.rbPrintersToRdp.Enabled = false;
            this.rbPrintersToRdp.Location = new System.Drawing.Point(290, 42);
            this.rbPrintersToRdp.Name = "rbPrintersToRdp";
            this.rbPrintersToRdp.Size = new System.Drawing.Size(48, 17);
            this.rbPrintersToRdp.TabIndex = 1;
            this.rbPrintersToRdp.Text = "RDP";
            this.rbPrintersToRdp.UseVisualStyleBackColor = true;
            // 
            // rbPrintersToMwmts
            // 
            this.rbPrintersToMwmts.AutoSize = true;
            this.rbPrintersToMwmts.Enabled = false;
            this.rbPrintersToMwmts.Location = new System.Drawing.Point(227, 42);
            this.rbPrintersToMwmts.Name = "rbPrintersToMwmts";
            this.rbPrintersToMwmts.Size = new System.Drawing.Size(60, 17);
            this.rbPrintersToMwmts.TabIndex = 1;
            this.rbPrintersToMwmts.Text = "m-wmts";
            this.rbPrintersToMwmts.UseVisualStyleBackColor = true;
            // 
            // rbPrintersToTs01
            // 
            this.rbPrintersToTs01.AutoSize = true;
            this.rbPrintersToTs01.Enabled = false;
            this.rbPrintersToTs01.Location = new System.Drawing.Point(290, 19);
            this.rbPrintersToTs01.Name = "rbPrintersToTs01";
            this.rbPrintersToTs01.Size = new System.Drawing.Size(51, 17);
            this.rbPrintersToTs01.TabIndex = 1;
            this.rbPrintersToTs01.Text = "TS01";
            this.rbPrintersToTs01.UseVisualStyleBackColor = true;
            // 
            // rbPrintersToPc
            // 
            this.rbPrintersToPc.AutoSize = true;
            this.rbPrintersToPc.Enabled = false;
            this.rbPrintersToPc.Location = new System.Drawing.Point(227, 19);
            this.rbPrintersToPc.Name = "rbPrintersToPc";
            this.rbPrintersToPc.Size = new System.Drawing.Size(57, 17);
            this.rbPrintersToPc.TabIndex = 1;
            this.rbPrintersToPc.Text = "На ПК";
            this.rbPrintersToPc.UseVisualStyleBackColor = true;
            // 
            // btnPrinters
            // 
            this.btnPrinters.Enabled = false;
            this.btnPrinters.Location = new System.Drawing.Point(6, 19);
            this.btnPrinters.Name = "btnPrinters";
            this.btnPrinters.Size = new System.Drawing.Size(215, 40);
            this.btnPrinters.TabIndex = 0;
            this.btnPrinters.Text = "Принтеры";
            this.btnPrinters.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(0, 344);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 6;
            // 
            // gbBase1C
            // 
            this.gbBase1C.Controls.Add(this.btnBase1C);
            this.gbBase1C.Controls.Add(this.rb1CToServer);
            this.gbBase1C.Controls.Add(this.rb1CToPC);
            this.gbBase1C.Location = new System.Drawing.Point(6, 10);
            this.gbBase1C.Name = "gbBase1C";
            this.gbBase1C.Size = new System.Drawing.Size(355, 69);
            this.gbBase1C.TabIndex = 5;
            this.gbBase1C.TabStop = false;
            this.gbBase1C.Text = "Базы 1С";
            // 
            // btnBase1C
            // 
            this.btnBase1C.Enabled = false;
            this.btnBase1C.Location = new System.Drawing.Point(6, 19);
            this.btnBase1C.Name = "btnBase1C";
            this.btnBase1C.Size = new System.Drawing.Size(215, 40);
            this.btnBase1C.TabIndex = 3;
            this.btnBase1C.Text = "Прописать базы 1С";
            this.btnBase1C.UseVisualStyleBackColor = true;
            this.btnBase1C.Click += new System.EventHandler(this.btnBase1C_Click);
            // 
            // rb1CToServer
            // 
            this.rb1CToServer.AutoSize = true;
            this.rb1CToServer.Enabled = false;
            this.rb1CToServer.Location = new System.Drawing.Point(227, 42);
            this.rb1CToServer.Name = "rb1CToServer";
            this.rb1CToServer.Size = new System.Drawing.Size(79, 17);
            this.rb1CToServer.TabIndex = 4;
            this.rb1CToServer.Text = "На Сервер";
            this.rb1CToServer.UseVisualStyleBackColor = true;
            // 
            // rb1CToPC
            // 
            this.rb1CToPC.AutoSize = true;
            this.rb1CToPC.Enabled = false;
            this.rb1CToPC.Location = new System.Drawing.Point(227, 19);
            this.rb1CToPC.Name = "rb1CToPC";
            this.rb1CToPC.Size = new System.Drawing.Size(57, 17);
            this.rb1CToPC.TabIndex = 4;
            this.rb1CToPC.Text = "На ПК";
            this.rb1CToPC.UseVisualStyleBackColor = true;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 444);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(367, 80);
            this.tbLog.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 533);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.gbAllButtons);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPC);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Omega_Jarvis";
            this.gbAllButtons.ResumeLayout(false);
            this.gbAllButtons.PerformLayout();
            this.gbPrinters.ResumeLayout(false);
            this.gbPrinters.PerformLayout();
            this.gbBase1C.ResumeLayout(false);
            this.gbBase1C.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.GroupBox gbAllButtons;
        private System.Windows.Forms.Button btnBase1C;
        private System.Windows.Forms.RadioButton rb1CToServer;
        private System.Windows.Forms.RadioButton rb1CToPC;
        private System.Windows.Forms.GroupBox gbBase1C;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.GroupBox gbPrinters;
        private System.Windows.Forms.RadioButton rbPrintersToPc;
        private System.Windows.Forms.Button btnPrinters;
        private System.Windows.Forms.RadioButton rbPrintersToRdp;
        private System.Windows.Forms.RadioButton rbPrintersToMwmts;
        private System.Windows.Forms.RadioButton rbPrintersToTs01;
    }
}

