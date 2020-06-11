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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.sdPath = new System.Windows.Forms.SaveFileDialog();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabConfigPath.SuspendLayout();
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
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 286);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            this.tabControl.UseCustomBackColor = true;
            this.tabControl.UseCustomForeColor = true;
            this.tabControl.UseSelectable = true;
            this.tabControl.UseStyleColors = true;
            // 
            // tabConfigPath
            // 
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
            this.tabConfigPath.Size = new System.Drawing.Size(752, 244);
            this.tabConfigPath.TabIndex = 0;
            this.tabConfigPath.Text = " Set Auto Export  ";
            this.tabConfigPath.VerticalScrollbarBarColor = true;
            this.tabConfigPath.VerticalScrollbarHighlightOnWheel = false;
            this.tabConfigPath.VerticalScrollbarSize = 10;
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPath.Location = new System.Drawing.Point(122, 82);
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
            this.label1.Location = new System.Drawing.Point(24, 88);
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
            this.btnBrowse.Location = new System.Drawing.Point(630, 82);
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
            // btnSubmit
            // 
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Location = new System.Drawing.Point(685, 368);
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
            // lblCurrentPath
            // 
            this.lblCurrentPath.AutoSize = true;
            this.lblCurrentPath.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentPath.Location = new System.Drawing.Point(214, 62);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentPath.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(119, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current path : ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblCloseForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Config Path";
            this.TopMost = true;
            this.tabControl.ResumeLayout(false);
            this.tabConfigPath.ResumeLayout(false);
            this.tabConfigPath.PerformLayout();
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
    }
}