namespace Omega_Jarvis
{
    partial class Base1CFormPC
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
            this.btnPushBase = new System.Windows.Forms.Button();
            this.cb1cDoPc = new System.Windows.Forms.CheckBox();
            this.cb1cBuhCorpPc = new System.Windows.Forms.CheckBox();
            this.cbUatPc = new System.Windows.Forms.CheckBox();
            this.cbZupPc = new System.Windows.Forms.CheckBox();
            this.cbUprPc = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPushBase
            // 
            this.btnPushBase.Location = new System.Drawing.Point(11, 134);
            this.btnPushBase.Name = "btnPushBase";
            this.btnPushBase.Size = new System.Drawing.Size(260, 41);
            this.btnPushBase.TabIndex = 1;
            this.btnPushBase.Text = "Прописать Базы";
            this.btnPushBase.UseVisualStyleBackColor = true;
            this.btnPushBase.Click += new System.EventHandler(this.btnPushBase_Click);
            // 
            // cb1cDoPc
            // 
            this.cb1cDoPc.AutoSize = true;
            this.cb1cDoPc.Location = new System.Drawing.Point(11, 19);
            this.cb1cDoPc.Name = "cb1cDoPc";
            this.cb1cDoPc.Size = new System.Drawing.Size(118, 17);
            this.cb1cDoPc.TabIndex = 2;
            this.cb1cDoPc.Text = "Документооборот";
            this.cb1cDoPc.UseVisualStyleBackColor = true;
            // 
            // cb1cBuhCorpPc
            // 
            this.cb1cBuhCorpPc.AutoSize = true;
            this.cb1cBuhCorpPc.Location = new System.Drawing.Point(11, 42);
            this.cb1cBuhCorpPc.Name = "cb1cBuhCorpPc";
            this.cb1cBuhCorpPc.Size = new System.Drawing.Size(175, 17);
            this.cb1cBuhCorpPc.TabIndex = 2;
            this.cb1cBuhCorpPc.Text = "Бухгалтерия предприятия 3.0";
            this.cb1cBuhCorpPc.UseVisualStyleBackColor = true;
            // 
            // cbUatPc
            // 
            this.cbUatPc.AutoSize = true;
            this.cbUatPc.Location = new System.Drawing.Point(11, 65);
            this.cbUatPc.Name = "cbUatPc";
            this.cbUatPc.Size = new System.Drawing.Size(48, 17);
            this.cbUatPc.TabIndex = 2;
            this.cbUatPc.Text = "УАТ";
            this.cbUatPc.UseVisualStyleBackColor = true;
            // 
            // cbZupPc
            // 
            this.cbZupPc.AutoSize = true;
            this.cbZupPc.Location = new System.Drawing.Point(11, 88);
            this.cbZupPc.Name = "cbZupPc";
            this.cbZupPc.Size = new System.Drawing.Size(49, 17);
            this.cbZupPc.TabIndex = 2;
            this.cbZupPc.Text = "ЗУП";
            this.cbZupPc.UseVisualStyleBackColor = true;
            // 
            // cbUprPc
            // 
            this.cbUprPc.AutoSize = true;
            this.cbUprPc.Location = new System.Drawing.Point(11, 111);
            this.cbUprPc.Name = "cbUprPc";
            this.cbUprPc.Size = new System.Drawing.Size(99, 17);
            this.cbUprPc.TabIndex = 2;
            this.cbUprPc.Text = "Управляющий";
            this.cbUprPc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPushBase);
            this.groupBox1.Controls.Add(this.cb1cDoPc);
            this.groupBox1.Controls.Add(this.cb1cBuhCorpPc);
            this.groupBox1.Controls.Add(this.cbUatPc);
            this.groupBox1.Controls.Add(this.cbZupPc);
            this.groupBox1.Controls.Add(this.cbUprPc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Base1CFormPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 208);
            this.Controls.Add(this.groupBox1);
            this.Name = "Base1CFormPC";
            this.Text = "Базы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPushBase;
        private System.Windows.Forms.CheckBox cb1cDoPc;
        private System.Windows.Forms.CheckBox cb1cBuhCorpPc;
        private System.Windows.Forms.CheckBox cbUatPc;
        private System.Windows.Forms.CheckBox cbZupPc;
        private System.Windows.Forms.CheckBox cbUprPc;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}