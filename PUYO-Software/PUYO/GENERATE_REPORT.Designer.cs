namespace PUYO
{
    partial class GENERATE_REPORT
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GET_PRODUCT_SALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PUYO_WAREHOUSEDataSet = new PUYO.PUYO_WAREHOUSEDataSet();
            this.DateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.DateToPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Store_Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATASUBMISSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEMIAVERAGEFORECASTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAINMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TodayDateText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReportCombo = new System.Windows.Forms.ComboBox();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.GET_PRODUCT_SALESTableAdapter = new PUYO.PUYO_WAREHOUSEDataSetTableAdapters.GET_PRODUCT_SALESTableAdapter();
            this.GenerateReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DisplayedData = new System.Windows.Forms.Label();
            this.DisplayDataGrid = new System.Windows.Forms.DataGridView();
            this.ReportTypeText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GET_AVERAGE_SALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GET_PRODUCT_SALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUYO_WAREHOUSEDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GET_AVERAGE_SALESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GET_PRODUCT_SALESBindingSource
            // 
            this.GET_PRODUCT_SALESBindingSource.AllowNew = false;
            this.GET_PRODUCT_SALESBindingSource.DataMember = "GET_PRODUCT_SALES";
            this.GET_PRODUCT_SALESBindingSource.DataSource = this.PUYO_WAREHOUSEDataSet;
            // 
            // PUYO_WAREHOUSEDataSet
            // 
            this.PUYO_WAREHOUSEDataSet.DataSetName = "PUYO_WAREHOUSEDataSet";
            this.PUYO_WAREHOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateFromPicker
            // 
            this.DateFromPicker.Location = new System.Drawing.Point(320, 74);
            this.DateFromPicker.Name = "DateFromPicker";
            this.DateFromPicker.Size = new System.Drawing.Size(200, 20);
            this.DateFromPicker.TabIndex = 1;
            this.DateFromPicker.ValueChanged += new System.EventHandler(this.DateFromPicker_ValueChanged);
            // 
            // DateToPicker
            // 
            this.DateToPicker.Location = new System.Drawing.Point(588, 74);
            this.DateToPicker.Name = "DateToPicker";
            this.DateToPicker.Size = new System.Drawing.Size(200, 20);
            this.DateToPicker.TabIndex = 2;
            this.DateToPicker.ValueChanged += new System.EventHandler(this.DateToPicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Store:";
            // 
            // Store_Combo
            // 
            this.Store_Combo.FormattingEnabled = true;
            this.Store_Combo.Items.AddRange(new object[] {
            "SI00001"});
            this.Store_Combo.Location = new System.Drawing.Point(53, 74);
            this.Store_Combo.Name = "Store_Combo";
            this.Store_Combo.Size = new System.Drawing.Size(209, 21);
            this.Store_Combo.TabIndex = 5;
            this.Store_Combo.Text = "SI00001";
            this.Store_Combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem,
            this.dATASUBMISSIONToolStripMenuItem,
            this.sEMIAVERAGEFORECASTToolStripMenuItem,
            this.mAINMENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1294, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.pOSToolStripMenuItem.Text = "WAREHOUSE";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // dATASUBMISSIONToolStripMenuItem
            // 
            this.dATASUBMISSIONToolStripMenuItem.Name = "dATASUBMISSIONToolStripMenuItem";
            this.dATASUBMISSIONToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.dATASUBMISSIONToolStripMenuItem.Text = "GENERATE REPORT";
            // 
            // sEMIAVERAGEFORECASTToolStripMenuItem
            // 
            this.sEMIAVERAGEFORECASTToolStripMenuItem.Name = "sEMIAVERAGEFORECASTToolStripMenuItem";
            this.sEMIAVERAGEFORECASTToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.sEMIAVERAGEFORECASTToolStripMenuItem.Text = "SEMI AVERAGE FORECAST";
            this.sEMIAVERAGEFORECASTToolStripMenuItem.Click += new System.EventHandler(this.sEMIAVERAGEFORECASTToolStripMenuItem_Click);
            // 
            // mAINMENUToolStripMenuItem
            // 
            this.mAINMENUToolStripMenuItem.Name = "mAINMENUToolStripMenuItem";
            this.mAINMENUToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mAINMENUToolStripMenuItem.Text = "MAIN MENU";
            this.mAINMENUToolStripMenuItem.Click += new System.EventHandler(this.mAINMENUToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(513, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Generate a report on specified from date and to date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Today\'s Date: ";
            // 
            // TodayDateText
            // 
            this.TodayDateText.AutoSize = true;
            this.TodayDateText.Location = new System.Drawing.Point(639, 50);
            this.TodayDateText.Name = "TodayDateText";
            this.TodayDateText.Size = new System.Drawing.Size(82, 13);
            this.TodayDateText.TabIndex = 19;
            this.TodayDateText.Text = "<Today\'s Date>";
            this.TodayDateText.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Select report type: ";
            // 
            // ReportCombo
            // 
            this.ReportCombo.FormattingEnabled = true;
            this.ReportCombo.Items.AddRange(new object[] {
            "Product_Sales",
            "Average_Sales",
            "Product_Sales_All",
            "Expired_Products",
            "Expired_Products_All",
            "Restocking_Single_Store",
            "Restocking_All"});
            this.ReportCombo.Location = new System.Drawing.Point(125, 110);
            this.ReportCombo.Name = "ReportCombo";
            this.ReportCombo.Size = new System.Drawing.Size(395, 21);
            this.ReportCombo.TabIndex = 22;
            this.ReportCombo.Text = "Product_Sales";
            this.ReportCombo.SelectedIndexChanged += new System.EventHandler(this.ReportCombo_SelectedIndexChanged);
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(562, 103);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(226, 32);
            this.GenerateReportButton.TabIndex = 23;
            this.GenerateReportButton.Text = "Generate Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GET_PRODUCT_SALESTableAdapter
            // 
            this.GET_PRODUCT_SALESTableAdapter.ClearBeforeFill = true;
            // 
            // GenerateReportViewer
            // 
            this.GenerateReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GET_PRODUCT_SALESBindingSource;
            this.GenerateReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.GenerateReportViewer.LocalReport.ReportEmbeddedResource = "PUYO.Sales_Report.rdlc";
            this.GenerateReportViewer.Location = new System.Drawing.Point(15, 141);
            this.GenerateReportViewer.Name = "GenerateReportViewer";
            this.GenerateReportViewer.ServerReport.BearerToken = null;
            this.GenerateReportViewer.Size = new System.Drawing.Size(773, 543);
            this.GenerateReportViewer.TabIndex = 24;
            this.GenerateReportViewer.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // DisplayedData
            // 
            this.DisplayedData.AutoSize = true;
            this.DisplayedData.Location = new System.Drawing.Point(825, 50);
            this.DisplayedData.Name = "DisplayedData";
            this.DisplayedData.Size = new System.Drawing.Size(79, 13);
            this.DisplayedData.TabIndex = 25;
            this.DisplayedData.Text = "Displayed Data";
            // 
            // DisplayDataGrid
            // 
            this.DisplayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayDataGrid.Location = new System.Drawing.Point(829, 103);
            this.DisplayDataGrid.Name = "DisplayDataGrid";
            this.DisplayDataGrid.Size = new System.Drawing.Size(448, 220);
            this.DisplayDataGrid.TabIndex = 26;
            this.DisplayDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayDataGrid_CellContentClick);
            // 
            // ReportTypeText
            // 
            this.ReportTypeText.AutoSize = true;
            this.ReportTypeText.Location = new System.Drawing.Point(826, 77);
            this.ReportTypeText.Name = "ReportTypeText";
            this.ReportTypeText.Size = new System.Drawing.Size(69, 13);
            this.ReportTypeText.TabIndex = 27;
            this.ReportTypeText.Text = "Report Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(449, 46);
            this.button1.TabIndex = 28;
            this.button1.Text = "Save Report Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GET_AVERAGE_SALESBindingSource
            // 
            this.GET_AVERAGE_SALESBindingSource.AllowNew = false;
            this.GET_AVERAGE_SALESBindingSource.DataMember = "GET_AVERAGE_SALES_FORECAST";
            this.GET_AVERAGE_SALESBindingSource.DataSource = this.PUYO_WAREHOUSEDataSet;
            // 
            // GENERATE_REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1294, 696);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReportTypeText);
            this.Controls.Add(this.DisplayDataGrid);
            this.Controls.Add(this.DisplayedData);
            this.Controls.Add(this.GenerateReportViewer);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.ReportCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TodayDateText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Store_Combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateToPicker);
            this.Controls.Add(this.DateFromPicker);
            this.Name = "GENERATE_REPORT";
            this.Text = "GENERATE_REPORT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GENERATE_REPORT_FormClosing);
            this.Load += new System.EventHandler(this.GENERATE_REPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GET_PRODUCT_SALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUYO_WAREHOUSEDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GET_AVERAGE_SALESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateFromPicker;
        private System.Windows.Forms.DateTimePicker DateToPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Store_Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATASUBMISSIONToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TodayDateText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ReportCombo;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.ToolStripMenuItem mAINMENUToolStripMenuItem;
        private System.Windows.Forms.BindingSource GET_PRODUCT_SALESBindingSource;
        private PUYO_WAREHOUSEDataSet PUYO_WAREHOUSEDataSet;
        private PUYO_WAREHOUSEDataSetTableAdapters.GET_PRODUCT_SALESTableAdapter GET_PRODUCT_SALESTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer GenerateReportViewer;
        private System.Windows.Forms.Label DisplayedData;
        private System.Windows.Forms.DataGridView DisplayDataGrid;
        private System.Windows.Forms.Label ReportTypeText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem sEMIAVERAGEFORECASTToolStripMenuItem;
        private System.Windows.Forms.BindingSource GET_AVERAGE_SALESBindingSource;
    }
}