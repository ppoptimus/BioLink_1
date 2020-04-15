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
            this.lblCloseForm = new System.Windows.Forms.Label();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabConfigPath = new MetroFramework.Controls.MetroTabPage();
            this.tabSetSchedule = new MetroFramework.Controls.MetroTabPage();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sdPath = new System.Windows.Forms.SaveFileDialog();
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
            this.tabControl.Controls.Add(this.tabSetSchedule);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControl.Location = new System.Drawing.Point(20, 66);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 337);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            this.tabControl.UseCustomBackColor = true;
            this.tabControl.UseCustomForeColor = true;
            this.tabControl.UseSelectable = true;
            this.tabControl.UseStyleColors = true;
            // 
            // tabConfigPath
            // 
            this.tabConfigPath.Controls.Add(this.metroLabel1);
            this.tabConfigPath.Controls.Add(this.btnBrowse);
            this.tabConfigPath.Controls.Add(this.txtPath);
            this.tabConfigPath.HorizontalScrollbarBarColor = true;
            this.tabConfigPath.HorizontalScrollbarHighlightOnWheel = false;
            this.tabConfigPath.HorizontalScrollbarSize = 10;
            this.tabConfigPath.Location = new System.Drawing.Point(4, 38);
            this.tabConfigPath.Name = "tabConfigPath";
            this.tabConfigPath.Size = new System.Drawing.Size(752, 295);
            this.tabConfigPath.TabIndex = 0;
            this.tabConfigPath.Text = "Config Path";
            this.tabConfigPath.VerticalScrollbarBarColor = true;
            this.tabConfigPath.VerticalScrollbarHighlightOnWheel = false;
            this.tabConfigPath.VerticalScrollbarSize = 10;
            // 
            // tabSetSchedule
            // 
            this.tabSetSchedule.HorizontalScrollbarBarColor = true;
            this.tabSetSchedule.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSetSchedule.HorizontalScrollbarSize = 10;
            this.tabSetSchedule.Location = new System.Drawing.Point(4, 38);
            this.tabSetSchedule.Name = "tabSetSchedule";
            this.tabSetSchedule.Size = new System.Drawing.Size(752, 295);
            this.tabSetSchedule.TabIndex = 1;
            this.tabSetSchedule.Text = "Set Schedule";
            this.tabSetSchedule.VerticalScrollbarBarColor = true;
            this.tabSetSchedule.VerticalScrollbarHighlightOnWheel = false;
            this.tabSetSchedule.VerticalScrollbarSize = 10;
            // 
            // txtPath
            // 
            // 
            // 
            // 
            this.txtPath.CustomButton.Image = null;
            this.txtPath.CustomButton.Location = new System.Drawing.Point(449, 2);
            this.txtPath.CustomButton.Name = "";
            this.txtPath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPath.CustomButton.TabIndex = 1;
            this.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPath.CustomButton.UseSelectable = true;
            this.txtPath.CustomButton.Visible = false;
            this.txtPath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(124, 53);
            this.txtPath.MaxLength = 2000;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.ShortcutsEnabled = true;
            this.txtPath.Size = new System.Drawing.Size(479, 32);
            this.txtPath.TabIndex = 2;
            this.txtPath.UseCustomForeColor = true;
            this.txtPath.UseSelectable = true;
            this.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrowse.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBrowse.Location = new System.Drawing.Point(609, 53);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 32);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseCustomBackColor = true;
            this.btnBrowse.UseCustomForeColor = true;
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.UseStyleColors = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Path Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblCloseForm);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private MetroFramework.Controls.MetroTabPage tabSetSchedule;
        private MetroFramework.Controls.MetroTextBox txtPath;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.SaveFileDialog sdPath;
    }
}