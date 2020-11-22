namespace BioLinkTaskSchedule.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblCloseForm = new System.Windows.Forms.Label();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabConfigPath = new MetroFramework.Controls.MetroTabPage();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrows = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.sdPath = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFtpPath = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabConfigPath.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCloseForm
            // 
            this.lblCloseForm.AutoSize = true;
            this.lblCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCloseForm.Location = new System.Drawing.Point(762, 13);
            this.lblCloseForm.Name = "lblCloseForm";
            this.lblCloseForm.Size = new System.Drawing.Size(27, 25);
            this.lblCloseForm.TabIndex = 0;
            this.lblCloseForm.Text = "X";
            this.lblCloseForm.Click += new System.EventHandler(this.lblCloseForm_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConfigPath);
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(760, 340);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            this.tabControl.UseCustomBackColor = true;
            this.tabControl.UseCustomForeColor = true;
            this.tabControl.UseSelectable = true;
            this.tabControl.UseStyleColors = true;
            // 
            // tabConfigPath
            // 
            this.tabConfigPath.Controls.Add(this.btnSubmit);
            this.tabConfigPath.Controls.Add(this.label2);
            this.tabConfigPath.Controls.Add(this.lblCurrentPath);
            this.tabConfigPath.Controls.Add(this.txtPath);
            this.tabConfigPath.Controls.Add(this.label1);
            this.tabConfigPath.Controls.Add(this.btnBrowse);
            this.tabConfigPath.HorizontalScrollbarBarColor = true;
            this.tabConfigPath.HorizontalScrollbarHighlightOnWheel = false;
            this.tabConfigPath.HorizontalScrollbarSize = 10;
            this.tabConfigPath.Location = new System.Drawing.Point(4, 38);
            this.tabConfigPath.Name = "tabConfigPath";
            this.tabConfigPath.Size = new System.Drawing.Size(752, 298);
            this.tabConfigPath.TabIndex = 0;
            this.tabConfigPath.Text = " Set Auto Export    ";
            this.tabConfigPath.VerticalScrollbarBarColor = true;
            this.tabConfigPath.VerticalScrollbarHighlightOnWheel = false;
            this.tabConfigPath.VerticalScrollbarSize = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Location = new System.Drawing.Point(630, 223);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 42);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseCustomBackColor = true;
            this.btnSubmit.UseCustomForeColor = true;
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.UseStyleColors = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(119, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current path : ";
            // 
            // lblCurrentPath
            // 
            this.lblCurrentPath.AutoSize = true;
            this.lblCurrentPath.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentPath.Location = new System.Drawing.Point(214, 73);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentPath.TabIndex = 6;
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPath.Location = new System.Drawing.Point(122, 93);
            this.txtPath.MaxLength = 1200;
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(502, 32);
            this.txtPath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 99);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrowse.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.Location = new System.Drawing.Point(630, 93);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 32);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseCustomBackColor = true;
            this.btnBrowse.UseCustomForeColor = true;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.UseStyleColors = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.label9);
            this.metroTabPage1.Controls.Add(this.txtFtpPath);
            this.metroTabPage1.Controls.Add(this.label8);
            this.metroTabPage1.Controls.Add(this.txtPort);
            this.metroTabPage1.Controls.Add(this.btnUpload);
            this.metroTabPage1.Controls.Add(this.btnBrows);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label7);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.txtPassword);
            this.metroTabPage1.Controls.Add(this.txtUserName);
            this.metroTabPage1.Controls.Add(this.txtServer);
            this.metroTabPage1.Controls.Add(this.txtSource);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 298);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "   Ftp File";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(526, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(572, 99);
            this.txtPort.MaxLength = 10;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(82, 27);
            this.txtPort.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(345, 246);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(95, 40);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrows
            // 
            this.btnBrows.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrows.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrows.Location = new System.Drawing.Point(588, 36);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(66, 27);
            this.btnBrows.TabIndex = 1;
            this.btnBrows.Text = "Browse";
            this.btnBrows.UseVisualStyleBackColor = false;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Source File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Host name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(190, 207);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(317, 27);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(190, 171);
            this.txtUserName.MaxLength = 255;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(317, 27);
            this.txtUserName.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(190, 99);
            this.txtServer.MaxLength = 255;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(317, 27);
            this.txtServer.TabIndex = 2;
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(190, 36);
            this.txtSource.MaxLength = 255;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(392, 27);
            this.txtSource.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(24, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Config Path";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Server File Path";
            // 
            // txtFtpPath
            // 
            this.txtFtpPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFtpPath.Location = new System.Drawing.Point(190, 134);
            this.txtFtpPath.MaxLength = 255;
            this.txtFtpPath.Name = "txtFtpPath";
            this.txtFtpPath.Size = new System.Drawing.Size(317, 27);
            this.txtFtpPath.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblCloseForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.tabControl.ResumeLayout(false);
            this.tabConfigPath.ResumeLayout(false);
            this.tabConfigPath.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCloseForm;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabConfigPath;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.SaveFileDialog sdPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.Label lblCurrentPath;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFtpPath;
    }
}