namespace BioLink_1.Pages
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainExport_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualExport_SubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mt_pl = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainExport_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainExport_Menu
            // 
            this.MainExport_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManualExport_SubMenu});
            this.MainExport_Menu.Name = "MainExport_Menu";
            this.MainExport_Menu.Size = new System.Drawing.Size(128, 36);
            this.MainExport_Menu.Text = "Export File";
            this.MainExport_Menu.Click += new System.EventHandler(this.MainExport_Menu_Click);
            // 
            // ManualExport_SubMenu
            // 
            this.ManualExport_SubMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ManualExport_SubMenu.Name = "ManualExport_SubMenu";
            this.ManualExport_SubMenu.Size = new System.Drawing.Size(197, 26);
            this.ManualExport_SubMenu.Text = "Manual Export";
            this.ManualExport_SubMenu.Click += new System.EventHandler(this.ManualExport_SubMenu_Click);
            // 
            // mt_pl
            // 
            this.mt_pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mt_pl.HorizontalScrollbarBarColor = true;
            this.mt_pl.HorizontalScrollbarHighlightOnWheel = false;
            this.mt_pl.HorizontalScrollbarSize = 10;
            this.mt_pl.Location = new System.Drawing.Point(20, 100);
            this.mt_pl.Name = "mt_pl";
            this.mt_pl.Size = new System.Drawing.Size(1279, 781);
            this.mt_pl.TabIndex = 1;
            this.mt_pl.VerticalScrollbarBarColor = true;
            this.mt_pl.VerticalScrollbarHighlightOnWheel = false;
            this.mt_pl.VerticalScrollbarSize = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 901);
            this.Controls.Add(this.mt_pl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Resizable = false;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainExport_Menu;
        private System.Windows.Forms.ToolStripMenuItem ManualExport_SubMenu;
        private MetroFramework.Controls.MetroPanel mt_pl;
    }
}