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
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.tabSetSchedule = new MetroFramework.Controls.MetroTabPage();
            this.sdPath = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cbxTaskStart = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl = new MetroFramework.Controls.MetroPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabConfigPath.SuspendLayout();
            this.tabSetSchedule.SuspendLayout();
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
            this.tabControl.SelectedIndex = 1;
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
            this.tabConfigPath.Controls.Add(this.txtPath);
            this.tabConfigPath.Controls.Add(this.label1);
            this.tabConfigPath.Controls.Add(this.btnBrowse);
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
            // tabSetSchedule
            // 
            this.tabSetSchedule.Controls.Add(this.btnSubmit);
            this.tabSetSchedule.Controls.Add(this.pnl);
            this.tabSetSchedule.Controls.Add(this.label2);
            this.tabSetSchedule.Controls.Add(this.cbxTaskStart);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPath.Location = new System.Drawing.Point(101, 53);
            this.txtPath.MaxLength = 1200;
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(502, 32);
            this.txtPath.TabIndex = 5;
            // 
            // cbxTaskStart
            // 
            this.cbxTaskStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTaskStart.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbxTaskStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxTaskStart.FormattingEnabled = true;
            this.cbxTaskStart.ItemHeight = 21;
            this.cbxTaskStart.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "OneTime"});
            this.cbxTaskStart.Location = new System.Drawing.Point(28, 40);
            this.cbxTaskStart.Name = "cbxTaskStart";
            this.cbxTaskStart.Size = new System.Drawing.Size(191, 27);
            this.cbxTaskStart.TabIndex = 2;
            this.cbxTaskStart.UseCustomBackColor = true;
            this.cbxTaskStart.UseCustomForeColor = true;
            this.cbxTaskStart.UseSelectable = true;
            this.cbxTaskStart.UseStyleColors = true;
            this.cbxTaskStart.SelectedIndexChanged += new System.EventHandler(this.cbxTaskStart_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "When to start task ";
            // 
            // pnl
            // 
            this.pnl.HorizontalScrollbarBarColor = true;
            this.pnl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl.HorizontalScrollbarSize = 10;
            this.pnl.Location = new System.Drawing.Point(234, 40);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(501, 192);
            this.pnl.TabIndex = 4;
            this.pnl.VerticalScrollbarBarColor = true;
            this.pnl.VerticalScrollbarHighlightOnWheel = false;
            this.pnl.VerticalScrollbarSize = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(637, 247);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 33);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
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
            this.tabSetSchedule.ResumeLayout(false);
            this.tabSetSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCloseForm;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabConfigPath;
        private MetroFramework.Controls.MetroTabPage tabSetSchedule;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.SaveFileDialog sdPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private MetroFramework.Controls.MetroPanel pnl;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cbxTaskStart;
    }
}