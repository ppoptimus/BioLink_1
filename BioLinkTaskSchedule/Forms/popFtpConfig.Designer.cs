namespace BioLinkTaskSchedule.Forms
{
    partial class popFtpConfig
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
            this.btnCheckFtp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFtpPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnFtpCancel = new System.Windows.Forms.Button();
            this.btnSaveFtpConfig = new System.Windows.Forms.Button();
            this.btnBrows = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheckFtp
            // 
            this.btnCheckFtp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckFtp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCheckFtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckFtp.Location = new System.Drawing.Point(173, 246);
            this.btnCheckFtp.Name = "btnCheckFtp";
            this.btnCheckFtp.Size = new System.Drawing.Size(128, 34);
            this.btnCheckFtp.TabIndex = 26;
            this.btnCheckFtp.Text = "Test Connection";
            this.btnCheckFtp.UseVisualStyleBackColor = false;
            this.btnCheckFtp.Click += new System.EventHandler(this.btnCheckFtp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Server File Path";
            // 
            // txtFtpPath
            // 
            this.txtFtpPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFtpPath.Location = new System.Drawing.Point(173, 134);
            this.txtFtpPath.MaxLength = 255;
            this.txtFtpPath.Name = "txtFtpPath";
            this.txtFtpPath.Size = new System.Drawing.Size(317, 27);
            this.txtFtpPath.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(571, 99);
            this.txtPort.MaxLength = 10;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(66, 27);
            this.txtPort.TabIndex = 14;
            // 
            // btnFtpCancel
            // 
            this.btnFtpCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnFtpCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFtpCancel.FlatAppearance.BorderSize = 0;
            this.btnFtpCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFtpCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFtpCancel.ForeColor = System.Drawing.Color.White;
            this.btnFtpCancel.Location = new System.Drawing.Point(403, 246);
            this.btnFtpCancel.Name = "btnFtpCancel";
            this.btnFtpCancel.Size = new System.Drawing.Size(87, 34);
            this.btnFtpCancel.TabIndex = 23;
            this.btnFtpCancel.Text = "Cancel";
            this.btnFtpCancel.UseVisualStyleBackColor = false;
            this.btnFtpCancel.Click += new System.EventHandler(this.btnFtpCancel_Click);
            // 
            // btnSaveFtpConfig
            // 
            this.btnSaveFtpConfig.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveFtpConfig.Enabled = false;
            this.btnSaveFtpConfig.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnSaveFtpConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveFtpConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFtpConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFtpConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveFtpConfig.Location = new System.Drawing.Point(307, 246);
            this.btnSaveFtpConfig.Name = "btnSaveFtpConfig";
            this.btnSaveFtpConfig.Size = new System.Drawing.Size(90, 34);
            this.btnSaveFtpConfig.TabIndex = 24;
            this.btnSaveFtpConfig.Text = "Save";
            this.btnSaveFtpConfig.UseVisualStyleBackColor = false;
            this.btnSaveFtpConfig.Click += new System.EventHandler(this.btnSaveFtpConfig_Click);
            // 
            // btnBrows
            // 
            this.btnBrows.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrows.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrows.Location = new System.Drawing.Point(571, 36);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(66, 27);
            this.btnBrows.TabIndex = 12;
            this.btnBrows.Text = "Browse";
            this.btnBrows.UseVisualStyleBackColor = false;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Source File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Host name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(173, 207);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(317, 27);
            this.txtPassword.TabIndex = 21;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(173, 171);
            this.txtUserName.MaxLength = 255;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(317, 27);
            this.txtUserName.TabIndex = 20;
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(173, 99);
            this.txtServer.MaxLength = 255;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(317, 27);
            this.txtServer.TabIndex = 13;
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(173, 36);
            this.txtSource.MaxLength = 255;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(392, 27);
            this.txtSource.TabIndex = 11;
            // 
            // popFtpConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 319);
            this.Controls.Add(this.btnCheckFtp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFtpPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnFtpCancel);
            this.Controls.Add(this.btnSaveFtpConfig);
            this.Controls.Add(this.btnBrows);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "popFtpConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckFtp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFtpPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnFtpCancel;
        private System.Windows.Forms.Button btnSaveFtpConfig;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtSource;
    }
}