namespace Omega_Jarvis
{
    partial class Base1CFormServer
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
            this.cb1cDoSrv = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPushBaseSrv = new System.Windows.Forms.Button();
            this.cbUatSrv = new System.Windows.Forms.CheckBox();
            this.cbZupSrv = new System.Windows.Forms.CheckBox();
            this.cbUprSrv = new System.Windows.Forms.CheckBox();
            this.cb1cBuhCorpSrv = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb1cDoSrv
            // 
            this.cb1cDoSrv.AutoSize = true;
            this.cb1cDoSrv.Location = new System.Drawing.Point(6, 19);
            this.cb1cDoSrv.Name = "cb1cDoSrv";
            this.cb1cDoSrv.Size = new System.Drawing.Size(134, 17);
            this.cb1cDoSrv.TabIndex = 0;
            this.cb1cDoSrv.Text = "1C Документооборот";
            this.cb1cDoSrv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPushBaseSrv);
            this.groupBox1.Controls.Add(this.cbUatSrv);
            this.groupBox1.Controls.Add(this.cbZupSrv);
            this.groupBox1.Controls.Add(this.cbUprSrv);
            this.groupBox1.Controls.Add(this.cb1cBuhCorpSrv);
            this.groupBox1.Controls.Add(this.cb1cDoSrv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnPushBaseSrv
            // 
            this.btnPushBaseSrv.Location = new System.Drawing.Point(6, 134);
            this.btnPushBaseSrv.Name = "btnPushBaseSrv";
            this.btnPushBaseSrv.Size = new System.Drawing.Size(263, 43);
            this.btnPushBaseSrv.TabIndex = 1;
            this.btnPushBaseSrv.Text = "Сохранить";
            this.btnPushBaseSrv.UseVisualStyleBackColor = true;
            this.btnPushBaseSrv.Click += new System.EventHandler(this.btnPushBaseSrv_Click);
            // 
            // cbUatSrv
            // 
            this.cbUatSrv.AutoSize = true;
            this.cbUatSrv.Location = new System.Drawing.Point(6, 111);
            this.cbUatSrv.Name = "cbUatSrv";
            this.cbUatSrv.Size = new System.Drawing.Size(48, 17);
            this.cbUatSrv.TabIndex = 0;
            this.cbUatSrv.Text = "УАТ";
            this.cbUatSrv.UseVisualStyleBackColor = true;
            // 
            // cbZupSrv
            // 
            this.cbZupSrv.AutoSize = true;
            this.cbZupSrv.Location = new System.Drawing.Point(6, 88);
            this.cbZupSrv.Name = "cbZupSrv";
            this.cbZupSrv.Size = new System.Drawing.Size(49, 17);
            this.cbZupSrv.TabIndex = 0;
            this.cbZupSrv.Text = "ЗУП";
            this.cbZupSrv.UseVisualStyleBackColor = true;
            // 
            // cbUprSrv
            // 
            this.cbUprSrv.AutoSize = true;
            this.cbUprSrv.Location = new System.Drawing.Point(6, 65);
            this.cbUprSrv.Name = "cbUprSrv";
            this.cbUprSrv.Size = new System.Drawing.Size(99, 17);
            this.cbUprSrv.TabIndex = 0;
            this.cbUprSrv.Text = "Управляющий";
            this.cbUprSrv.UseVisualStyleBackColor = true;
            // 
            // cb1cBuhCorpSrv
            // 
            this.cb1cBuhCorpSrv.AutoSize = true;
            this.cb1cBuhCorpSrv.Location = new System.Drawing.Point(6, 42);
            this.cb1cBuhCorpSrv.Name = "cb1cBuhCorpSrv";
            this.cb1cBuhCorpSrv.Size = new System.Drawing.Size(134, 17);
            this.cb1cBuhCorpSrv.TabIndex = 0;
            this.cb1cBuhCorpSrv.Text = "Бухгалтерия корп 3.0";
            this.cb1cBuhCorpSrv.UseVisualStyleBackColor = true;
            // 
            // Base1CFormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 209);
            this.Controls.Add(this.groupBox1);
            this.Name = "Base1CFormServer";
            this.Text = "Базы 1С на сервере";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Base1CFormServer_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cb1cDoSrv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPushBaseSrv;
        private System.Windows.Forms.CheckBox cbUatSrv;
        private System.Windows.Forms.CheckBox cbZupSrv;
        private System.Windows.Forms.CheckBox cbUprSrv;
        private System.Windows.Forms.CheckBox cb1cBuhCorpSrv;
    }
}