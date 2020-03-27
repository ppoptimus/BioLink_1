namespace BioLink_1.Pages
{
    partial class UC_ManualExport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxBeginTime = new MetroFramework.Controls.MetroComboBox();
            this.dtpBeginDate = new MetroFramework.Controls.MetroDateTime();
            this.dtpEndDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbt1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbxEndTime = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnViewData = new MetroFramework.Controls.MetroButton();
            this.btnExportCSV = new MetroFramework.Controls.MetroButton();
            this.btnExportText = new MetroFramework.Controls.MetroButton();
            this.cbxEvent = new MetroFramework.Controls.MetroComboBox();
            this.cbxDevices = new MetroFramework.Controls.MetroComboBox();
            this.cbxUsers = new MetroFramework.Controls.MetroComboBox();
            this.cbxUserGroup = new MetroFramework.Controls.MetroComboBox();
            this.gvViewData = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gvViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBeginTime
            // 
            this.cbxBeginTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBeginTime.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbxBeginTime.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbxBeginTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxBeginTime.FormattingEnabled = true;
            this.cbxBeginTime.ItemHeight = 29;
            this.cbxBeginTime.Items.AddRange(new object[] {
            "09:00"});
            this.cbxBeginTime.Location = new System.Drawing.Point(271, 69);
            this.cbxBeginTime.Name = "cbxBeginTime";
            this.cbxBeginTime.PromptText = "00:00";
            this.cbxBeginTime.Size = new System.Drawing.Size(186, 35);
            this.cbxBeginTime.TabIndex = 0;
            this.cbxBeginTime.UseSelectable = true;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBeginDate.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.dtpBeginDate.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtpBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginDate.Location = new System.Drawing.Point(28, 69);
            this.dtpBeginDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(206, 35);
            this.dtpBeginDate.TabIndex = 2;
            this.dtpBeginDate.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.dtpEndDate.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(567, 69);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(206, 35);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.Location = new System.Drawing.Point(28, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Begin From Date";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // lbt1
            // 
            this.lbt1.AutoSize = true;
            this.lbt1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbt1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbt1.Location = new System.Drawing.Point(271, 35);
            this.lbt1.Name = "lbt1";
            this.lbt1.Size = new System.Drawing.Size(111, 25);
            this.lbt1.TabIndex = 3;
            this.lbt1.Text = "Begin Time";
            this.lbt1.UseCustomBackColor = true;
            this.lbt1.UseCustomForeColor = true;
            this.lbt1.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel3.Location = new System.Drawing.Point(567, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "End To Date";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel4.Location = new System.Drawing.Point(815, 35);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "End Date";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // cbxEndTime
            // 
            this.cbxEndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEndTime.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbxEndTime.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbxEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxEndTime.FormattingEnabled = true;
            this.cbxEndTime.ItemHeight = 29;
            this.cbxEndTime.Items.AddRange(new object[] {
            "09:00"});
            this.cbxEndTime.Location = new System.Drawing.Point(815, 69);
            this.cbxEndTime.Name = "cbxEndTime";
            this.cbxEndTime.PromptText = "00:00";
            this.cbxEndTime.Size = new System.Drawing.Size(186, 35);
            this.cbxEndTime.TabIndex = 0;
            this.cbxEndTime.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel5.Location = new System.Drawing.Point(28, 134);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 25);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Event";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel6.Location = new System.Drawing.Point(271, 134);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 25);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Devices";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel7.Location = new System.Drawing.Point(587, 134);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(115, 25);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "User Group";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel8.Location = new System.Drawing.Point(815, 133);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 25);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Users";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // btnViewData
            // 
            this.btnViewData.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnViewData.ForeColor = System.Drawing.Color.Gray;
            this.btnViewData.Location = new System.Drawing.Point(28, 256);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(113, 51);
            this.btnViewData.TabIndex = 5;
            this.btnViewData.Text = "View";
            this.btnViewData.UseCustomBackColor = true;
            this.btnViewData.UseCustomForeColor = true;
            this.btnViewData.UseSelectable = true;
            this.btnViewData.UseStyleColors = true;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExportCSV.ForeColor = System.Drawing.Color.Gray;
            this.btnExportCSV.Location = new System.Drawing.Point(147, 256);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(157, 51);
            this.btnExportCSV.TabIndex = 5;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseCustomBackColor = true;
            this.btnExportCSV.UseCustomForeColor = true;
            this.btnExportCSV.UseSelectable = true;
            this.btnExportCSV.UseStyleColors = true;
            // 
            // btnExportText
            // 
            this.btnExportText.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExportText.ForeColor = System.Drawing.Color.Gray;
            this.btnExportText.Location = new System.Drawing.Point(310, 256);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(248, 51);
            this.btnExportText.TabIndex = 5;
            this.btnExportText.Text = "Export Text (With format)";
            this.btnExportText.UseCustomBackColor = true;
            this.btnExportText.UseCustomForeColor = true;
            this.btnExportText.UseSelectable = true;
            this.btnExportText.UseStyleColors = true;
            // 
            // cbxEvent
            // 
            this.cbxEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEvent.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbxEvent.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbxEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxEvent.FormattingEnabled = true;
            this.cbxEvent.ItemHeight = 29;
            this.cbxEvent.Items.AddRange(new object[] {
            "09:00"});
            this.cbxEvent.Location = new System.Drawing.Point(28, 166);
            this.cbxEvent.Name = "cbxEvent";
            this.cbxEvent.PromptText = "00:00";
            this.cbxEvent.Size = new System.Drawing.Size(206, 35);
            this.cbxEvent.TabIndex = 0;
            this.cbxEvent.UseSelectable = true;
            // 
            // cbxDevices
            // 
            this.cbxDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDevices.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbxDevices.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbxDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.ItemHeight = 29;
            this.cbxDevices.Items.AddRange(new object[] {
            "09:00"});
            this.cbxDevices.Location = new System.Drawing.Point(271, 166);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.PromptText = "00:00";
            this.cbxDevices.Size = new System.Drawing.Size(275, 35);
            this.cbxDevices.TabIndex = 0;
            this.cbxDevices.UseSelectable = true;
            // 
            // cbxUsers
            // 
            this.cbxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUsers.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbxUsers.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbxUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.ItemHeight = 29;
            this.cbxUsers.Items.AddRange(new object[] {
            "09:00"});
            this.cbxUsers.Location = new System.Drawing.Point(815, 166);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.PromptText = "00:00";
            this.cbxUsers.Size = new System.Drawing.Size(186, 35);
            this.cbxUsers.TabIndex = 0;
            this.cbxUsers.UseSelectable = true;
            // 
            // cbxUserGroup
            // 
            this.cbxUserGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUserGroup.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbxUserGroup.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbxUserGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxUserGroup.FormattingEnabled = true;
            this.cbxUserGroup.ItemHeight = 29;
            this.cbxUserGroup.Items.AddRange(new object[] {
            "09:00"});
            this.cbxUserGroup.Location = new System.Drawing.Point(587, 166);
            this.cbxUserGroup.Name = "cbxUserGroup";
            this.cbxUserGroup.PromptText = "00:00";
            this.cbxUserGroup.Size = new System.Drawing.Size(186, 35);
            this.cbxUserGroup.TabIndex = 0;
            this.cbxUserGroup.UseSelectable = true;
            // 
            // gvViewData
            // 
            this.gvViewData.AllowUserToResizeRows = false;
            this.gvViewData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvViewData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvViewData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvViewData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvViewData.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvViewData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvViewData.EnableHeadersVisualStyles = false;
            this.gvViewData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvViewData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvViewData.Location = new System.Drawing.Point(0, 345);
            this.gvViewData.Name = "gvViewData";
            this.gvViewData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvViewData.RowHeadersWidth = 51;
            this.gvViewData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvViewData.RowTemplate.Height = 24;
            this.gvViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvViewData.Size = new System.Drawing.Size(1280, 423);
            this.gvViewData.TabIndex = 8;
            // 
            // UC_ManualExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lbt1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.cbxEndTime);
            this.Controls.Add(this.cbxDevices);
            this.Controls.Add(this.cbxUserGroup);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.cbxEvent);
            this.Controls.Add(this.cbxBeginTime);
            this.Controls.Add(this.btnExportText);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.gvViewData);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "UC_ManualExport";
            this.Size = new System.Drawing.Size(1280, 768);
            ((System.ComponentModel.ISupportInitialize)(this.gvViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbxBeginTime;
        private MetroFramework.Controls.MetroDateTime dtpBeginDate;
        private MetroFramework.Controls.MetroDateTime dtpEndDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbt1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbxEndTime;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnViewData;
        private MetroFramework.Controls.MetroButton btnExportCSV;
        private MetroFramework.Controls.MetroButton btnExportText;
        private MetroFramework.Controls.MetroComboBox cbxEvent;
        private MetroFramework.Controls.MetroComboBox cbxDevices;
        private MetroFramework.Controls.MetroComboBox cbxUsers;
        private MetroFramework.Controls.MetroComboBox cbxUserGroup;
        private MetroFramework.Controls.MetroGrid gvViewData;
    }
}
