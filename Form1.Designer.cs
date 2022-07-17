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
            this.eventBox = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.gbBase1C = new System.Windows.Forms.GroupBox();
            this.btnBase1C = new System.Windows.Forms.Button();
            this.rbToServer = new System.Windows.Forms.RadioButton();
            this.rbToPC = new System.Windows.Forms.RadioButton();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.eventBox.SuspendLayout();
            this.gbBase1C.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(12, 29);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(187, 20);
            this.txtPC.TabIndex = 0;
            this.txtPC.TextChanged += new System.EventHandler(this.txtPC_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(205, 29);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(174, 20);
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
            this.labelLogin.Location = new System.Drawing.Point(202, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // eventBox
            // 
            this.eventBox.Controls.Add(this.lblProgress);
            this.eventBox.Controls.Add(this.progress);
            this.eventBox.Controls.Add(this.gbBase1C);
            this.eventBox.Location = new System.Drawing.Point(12, 55);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(367, 383);
            this.eventBox.TabIndex = 2;
            this.eventBox.TabStop = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(0, 344);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 6;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 360);
            this.progress.Name = "progress";
            this.progress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progress.Size = new System.Drawing.Size(367, 23);
            this.progress.TabIndex = 5;
            this.progress.Visible = false;
            // 
            // gbBase1C
            // 
            this.gbBase1C.Controls.Add(this.btnBase1C);
            this.gbBase1C.Controls.Add(this.rbToServer);
            this.gbBase1C.Controls.Add(this.rbToPC);
            this.gbBase1C.Location = new System.Drawing.Point(6, 10);
            this.gbBase1C.Name = "gbBase1C";
            this.gbBase1C.Size = new System.Drawing.Size(355, 69);
            this.gbBase1C.TabIndex = 5;
            this.gbBase1C.TabStop = false;
            this.gbBase1C.Text = "Базы 1С";
            // 
            // btnBase1C
            // 
            this.btnBase1C.Location = new System.Drawing.Point(6, 19);
            this.btnBase1C.Name = "btnBase1C";
            this.btnBase1C.Size = new System.Drawing.Size(215, 40);
            this.btnBase1C.TabIndex = 3;
            this.btnBase1C.Text = "Прописать базы 1С";
            this.btnBase1C.UseVisualStyleBackColor = true;
            this.btnBase1C.Click += new System.EventHandler(this.btnBase1C_Click);
            // 
            // rbToServer
            // 
            this.rbToServer.AutoSize = true;
            this.rbToServer.Checked = true;
            this.rbToServer.Location = new System.Drawing.Point(223, 42);
            this.rbToServer.Name = "rbToServer";
            this.rbToServer.Size = new System.Drawing.Size(112, 17);
            this.rbToServer.TabIndex = 4;
            this.rbToServer.TabStop = true;
            this.rbToServer.Text = "На диск Сервера";
            this.rbToServer.UseVisualStyleBackColor = true;
            // 
            // rbToPC
            // 
            this.rbToPC.AutoSize = true;
            this.rbToPC.Location = new System.Drawing.Point(223, 19);
            this.rbToPC.Name = "rbToPC";
            this.rbToPC.Size = new System.Drawing.Size(57, 17);
            this.rbToPC.TabIndex = 4;
            this.rbToPC.Text = "На ПК";
            this.rbToPC.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(384, 533);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPC);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Omega_Jarvis";
            this.eventBox.ResumeLayout(false);
            this.eventBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox eventBox;
        private System.Windows.Forms.Button btnBase1C;
        private System.Windows.Forms.RadioButton rbToServer;
        private System.Windows.Forms.RadioButton rbToPC;
        private System.Windows.Forms.GroupBox gbBase1C;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox tbLog;
    }
}

