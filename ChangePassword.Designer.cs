﻿namespace member_space
{
    partial class ChangePassword
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
            this.LcpNewPass = new System.Windows.Forms.Label();
            this.LcpConfirmPass = new System.Windows.Forms.Label();
            this.textBcpNewPass = new System.Windows.Forms.TextBox();
            this.textBcpConfirmPass = new System.Windows.Forms.TextBox();
            this.BcpBacktoLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LcpNewPass
            // 
            this.LcpNewPass.AutoSize = true;
            this.LcpNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LcpNewPass.Location = new System.Drawing.Point(127, 127);
            this.LcpNewPass.Name = "LcpNewPass";
            this.LcpNewPass.Size = new System.Drawing.Size(176, 29);
            this.LcpNewPass.TabIndex = 0;
            this.LcpNewPass.Text = "New Password";
            // 
            // LcpConfirmPass
            // 
            this.LcpConfirmPass.AutoSize = true;
            this.LcpConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LcpConfirmPass.Location = new System.Drawing.Point(93, 228);
            this.LcpConfirmPass.Name = "LcpConfirmPass";
            this.LcpConfirmPass.Size = new System.Drawing.Size(210, 29);
            this.LcpConfirmPass.TabIndex = 1;
            this.LcpConfirmPass.Text = "Confirm Password";
            // 
            // textBcpNewPass
            // 
            this.textBcpNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBcpNewPass.Location = new System.Drawing.Point(376, 134);
            this.textBcpNewPass.Name = "textBcpNewPass";
            this.textBcpNewPass.Size = new System.Drawing.Size(181, 22);
            this.textBcpNewPass.TabIndex = 2;
            // 
            // textBcpConfirmPass
            // 
            this.textBcpConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBcpConfirmPass.Location = new System.Drawing.Point(376, 234);
            this.textBcpConfirmPass.Name = "textBcpConfirmPass";
            this.textBcpConfirmPass.Size = new System.Drawing.Size(181, 22);
            this.textBcpConfirmPass.TabIndex = 3;
            this.textBcpConfirmPass.TextChanged += new System.EventHandler(this.textBcpConfirmPass_TextChanged);
            // 
            // BcpBacktoLogin
            // 
            this.BcpBacktoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BcpBacktoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BcpBacktoLogin.ForeColor = System.Drawing.Color.White;
            this.BcpBacktoLogin.Location = new System.Drawing.Point(588, 320);
            this.BcpBacktoLogin.Name = "BcpBacktoLogin";
            this.BcpBacktoLogin.Size = new System.Drawing.Size(122, 54);
            this.BcpBacktoLogin.TabIndex = 4;
            this.BcpBacktoLogin.Text = "Back To Login";
            this.BcpBacktoLogin.UseVisualStyleBackColor = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BcpBacktoLogin);
            this.Controls.Add(this.textBcpConfirmPass);
            this.Controls.Add(this.textBcpNewPass);
            this.Controls.Add(this.LcpConfirmPass);
            this.Controls.Add(this.LcpNewPass);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LcpNewPass;
        private System.Windows.Forms.Label LcpConfirmPass;
        private System.Windows.Forms.TextBox textBcpNewPass;
        private System.Windows.Forms.TextBox textBcpConfirmPass;
        private System.Windows.Forms.Button BcpBacktoLogin;
    }
}