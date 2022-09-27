namespace ProjectUSBDeviceList
{
    partial class FormMain
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.vendorIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorIDColumn,
            this.deviceIDColumn,
            this.deviceNameColumn});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(831, 246);
            this.dataGrid.TabIndex = 6;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 264);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(127, 38);
            this.buttonShow.TabIndex = 7;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // vendorIDColumn
            // 
            this.vendorIDColumn.HeaderText = "Vendor ID";
            this.vendorIDColumn.Name = "vendorIDColumn";
            this.vendorIDColumn.ReadOnly = true;
            this.vendorIDColumn.Width = 150;
            // 
            // deviceIDColumn
            // 
            this.deviceIDColumn.HeaderText = "Device ID";
            this.deviceIDColumn.Name = "deviceIDColumn";
            this.deviceIDColumn.ReadOnly = true;
            this.deviceIDColumn.Width = 150;
            // 
            // deviceNameColumn
            // 
            this.deviceNameColumn.HeaderText = "Device Name";
            this.deviceNameColumn.Name = "deviceNameColumn";
            this.deviceNameColumn.ReadOnly = true;
            this.deviceNameColumn.Width = 500;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 430);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGrid);
            this.Name = "FormMain";
            this.Text = "USB Device List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameColumn;
        private System.Windows.Forms.Button buttonShow;
    }
}

