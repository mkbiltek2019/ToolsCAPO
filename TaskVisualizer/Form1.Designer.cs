﻿namespace TaskVisualizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtServerName = new System.Windows.Forms.ComboBox();
            this.butSkipNext = new System.Windows.Forms.Button();
            this.lblCaseName = new System.Windows.Forms.Label();
            this.butStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.butRun = new System.Windows.Forms.Button();
            this.timerToEnd = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.FormattingEnabled = true;
            this.txtServerName.Items.AddRange(new object[] {
            "WR-7-BASE-74\\SQLEXPRESS",
            "SZSZ\\SQLEXPRESS"});
            this.txtServerName.Location = new System.Drawing.Point(78, 5);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(272, 21);
            this.txtServerName.TabIndex = 27;
            // 
            // butSkipNext
            // 
            this.butSkipNext.Location = new System.Drawing.Point(165, 55);
            this.butSkipNext.Name = "butSkipNext";
            this.butSkipNext.Size = new System.Drawing.Size(75, 23);
            this.butSkipNext.TabIndex = 26;
            this.butSkipNext.Text = "Skip";
            this.butSkipNext.UseVisualStyleBackColor = true;
            this.butSkipNext.Click += new System.EventHandler(this.butSkipNext_Click);
            // 
            // lblCaseName
            // 
            this.lblCaseName.AutoSize = true;
            this.lblCaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCaseName.Location = new System.Drawing.Point(12, 81);
            this.lblCaseName.Name = "lblCaseName";
            this.lblCaseName.Size = new System.Drawing.Size(77, 16);
            this.lblCaseName.TabIndex = 24;
            this.lblCaseName.Text = "CaseName";
            // 
            // butStop
            // 
            this.butStop.Enabled = false;
            this.butStop.Location = new System.Drawing.Point(84, 55);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(75, 23);
            this.butStop.TabIndex = 23;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ServerName";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(250, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.Text = "szsz";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(78, 29);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 18;
            this.txtUser.Text = "szsz";
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(12, 55);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(66, 23);
            this.butRun.TabIndex = 17;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // timerToEnd
            // 
            this.timerToEnd.Interval = 1000;
            this.timerToEnd.Tick += new System.EventHandler(this.timerToEnd_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 115);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.butSkipNext);
            this.Controls.Add(this.lblCaseName);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.butRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtServerName;
        private System.Windows.Forms.Button butSkipNext;
        private System.Windows.Forms.Label lblCaseName;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Timer timerToEnd;
    }
}
