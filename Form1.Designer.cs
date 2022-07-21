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
            this.rbPrintersChangeName = new System.Windows.Forms.RadioButton();
            this.rbPrintersRemove = new System.Windows.Forms.RadioButton();
            this.rbPrintersChangeIp = new System.Windows.Forms.RadioButton();
            this.rbPrintersAdd = new System.Windows.Forms.RadioButton();
            this.btnPrinters = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.gbBase1C = new System.Windows.Forms.GroupBox();
            this.btnBase1C = new System.Windows.Forms.Button();
            this.rb1CToServer = new System.Windows.Forms.RadioButton();
            this.rb1CToPC = new System.Windows.Forms.RadioButton();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnCheckLoginPc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbAllButtons.SuspendLayout();
            this.gbPrinters.SuspendLayout();
            this.gbBase1C.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(12, 29);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(120, 20);
            this.txtPC.TabIndex = 0;
            this.txtPC.TextChanged += new System.EventHandler(this.txtPC_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(144, 29);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(122, 20);
            this.txtLogin.TabIndex = 1;
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
            this.labelLogin.Location = new System.Drawing.Point(146, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // gbAllButtons
            // 
            this.gbAllButtons.Controls.Add(this.button1);
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
            this.gbPrinters.Controls.Add(this.rbPrintersChangeName);
            this.gbPrinters.Controls.Add(this.rbPrintersRemove);
            this.gbPrinters.Controls.Add(this.rbPrintersChangeIp);
            this.gbPrinters.Controls.Add(this.rbPrintersAdd);
            this.gbPrinters.Controls.Add(this.btnPrinters);
            this.gbPrinters.Location = new System.Drawing.Point(6, 85);
            this.gbPrinters.Name = "gbPrinters";
            this.gbPrinters.Size = new System.Drawing.Size(355, 69);
            this.gbPrinters.TabIndex = 8;
            this.gbPrinters.TabStop = false;
            this.gbPrinters.Text = "Принтеры";
            // 
            // rbPrintersChangeName
            // 
            this.rbPrintersChangeName.AutoSize = true;
            this.rbPrintersChangeName.Location = new System.Drawing.Point(248, 42);
            this.rbPrintersChangeName.Name = "rbPrintersChangeName";
            this.rbPrintersChangeName.Size = new System.Drawing.Size(101, 17);
            this.rbPrintersChangeName.TabIndex = 9;
            this.rbPrintersChangeName.Text = "Изменить Имя";
            this.rbPrintersChangeName.UseVisualStyleBackColor = true;
            // 
            // rbPrintersRemove
            // 
            this.rbPrintersRemove.AutoSize = true;
            this.rbPrintersRemove.Location = new System.Drawing.Point(173, 42);
            this.rbPrintersRemove.Name = "rbPrintersRemove";
            this.rbPrintersRemove.Size = new System.Drawing.Size(68, 17);
            this.rbPrintersRemove.TabIndex = 8;
            this.rbPrintersRemove.Text = "Удалить";
            this.rbPrintersRemove.UseVisualStyleBackColor = true;
            // 
            // rbPrintersChangeIp
            // 
            this.rbPrintersChangeIp.AutoSize = true;
            this.rbPrintersChangeIp.Location = new System.Drawing.Point(248, 19);
            this.rbPrintersChangeIp.Name = "rbPrintersChangeIp";
            this.rbPrintersChangeIp.Size = new System.Drawing.Size(89, 17);
            this.rbPrintersChangeIp.TabIndex = 7;
            this.rbPrintersChangeIp.Text = "Изменить IP";
            this.rbPrintersChangeIp.UseVisualStyleBackColor = true;
            // 
            // rbPrintersAdd
            // 
            this.rbPrintersAdd.AutoSize = true;
            this.rbPrintersAdd.Checked = true;
            this.rbPrintersAdd.Location = new System.Drawing.Point(173, 19);
            this.rbPrintersAdd.Name = "rbPrintersAdd";
            this.rbPrintersAdd.Size = new System.Drawing.Size(75, 17);
            this.rbPrintersAdd.TabIndex = 6;
            this.rbPrintersAdd.TabStop = true;
            this.rbPrintersAdd.Text = "Добавить";
            this.rbPrintersAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrinters
            // 
            this.btnPrinters.Location = new System.Drawing.Point(6, 19);
            this.btnPrinters.Name = "btnPrinters";
            this.btnPrinters.Size = new System.Drawing.Size(160, 40);
            this.btnPrinters.TabIndex = 5;
            this.btnPrinters.Text = "Принтер";
            this.btnPrinters.UseVisualStyleBackColor = true;
            this.btnPrinters.Click += new System.EventHandler(this.btnPrinters_Click);
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
            this.rb1CToPC.TabIndex = 3;
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
            this.tbLog.TabIndex = 10;
            // 
            // btnCheckLoginPc
            // 
            this.btnCheckLoginPc.Location = new System.Drawing.Point(272, 27);
            this.btnCheckLoginPc.Name = "btnCheckLoginPc";
            this.btnCheckLoginPc.Size = new System.Drawing.Size(107, 23);
            this.btnCheckLoginPc.TabIndex = 2;
            this.btnCheckLoginPc.Text = "Проверить";
            this.btnCheckLoginPc.UseVisualStyleBackColor = true;
            this.btnCheckLoginPc.Click += new System.EventHandler(this.btnCheckLoginPc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 533);
            this.Controls.Add(this.btnCheckLoginPc);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.gbAllButtons);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPC);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Omega_Jarvis";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.RadioButton rbPrintersAdd;
        private System.Windows.Forms.Button btnPrinters;
        private System.Windows.Forms.RadioButton rbPrintersChangeName;
        private System.Windows.Forms.RadioButton rbPrintersRemove;
        private System.Windows.Forms.RadioButton rbPrintersChangeIp;
        private System.Windows.Forms.Button btnCheckLoginPc;
        private System.Windows.Forms.Button button1;
    }
}

