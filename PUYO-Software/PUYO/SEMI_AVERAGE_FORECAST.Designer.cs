namespace PUYO
{
    partial class SEMI_AVERAGE_FORECAST
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATASUBMISSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAINMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEMIAVERAGEFORECASTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FORECAST_GRID = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateToPicker = new System.Windows.Forms.DateTimePicker();
            this.DateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new PUYO.PUYO_WAREHOUSE_DATA_SETTableAdapters.TableAdapterManager();
            this.DataPreview = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Generate_Forecasting = new System.Windows.Forms.Button();
            this.FORECAST_RESULT = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FORECAST_GRID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORECAST_RESULT)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 17;
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
            this.dATASUBMISSIONToolStripMenuItem.Click += new System.EventHandler(this.dATASUBMISSIONToolStripMenuItem_Click);
            // 
            // mAINMENUToolStripMenuItem
            // 
            this.mAINMENUToolStripMenuItem.Name = "mAINMENUToolStripMenuItem";
            this.mAINMENUToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mAINMENUToolStripMenuItem.Text = "MAIN MENU";
            this.mAINMENUToolStripMenuItem.Click += new System.EventHandler(this.mAINMENUToolStripMenuItem_Click);
            // 
            // sEMIAVERAGEFORECASTToolStripMenuItem
            // 
            this.sEMIAVERAGEFORECASTToolStripMenuItem.Name = "sEMIAVERAGEFORECASTToolStripMenuItem";
            this.sEMIAVERAGEFORECASTToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.sEMIAVERAGEFORECASTToolStripMenuItem.Text = "SEMI AVERAGE FORECAST";
            // 
            // FORECAST_GRID
            // 
            this.FORECAST_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FORECAST_GRID.Location = new System.Drawing.Point(50, 230);
            this.FORECAST_GRID.Name = "FORECAST_GRID";
            this.FORECAST_GRID.Size = new System.Drawing.Size(479, 136);
            this.FORECAST_GRID.TabIndex = 18;
            this.FORECAST_GRID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FORECAST_GRID_CellContentClick);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "From:";
            // 
            // DateToPicker
            // 
            this.DateToPicker.Location = new System.Drawing.Point(50, 114);
            this.DateToPicker.Name = "DateToPicker";
            this.DateToPicker.Size = new System.Drawing.Size(200, 20);
            this.DateToPicker.TabIndex = 20;
            this.DateToPicker.ValueChanged += new System.EventHandler(this.DateToPicker_ValueChanged);
            // 
            // DateFromPicker
            // 
            this.DateFromPicker.Location = new System.Drawing.Point(50, 78);
            this.DateFromPicker.Name = "DateFromPicker";
            this.DateFromPicker.Size = new System.Drawing.Size(200, 20);
            this.DateFromPicker.TabIndex = 19;
            this.DateFromPicker.ValueChanged += new System.EventHandler(this.DateFromPicker_ValueChanged);
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(50, 140);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(200, 61);
            this.InsertDataButton.TabIndex = 24;
            this.InsertDataButton.Text = "Insert Data";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "SEMI AVERAGE FORECAST ODD DATA";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = PUYO.PUYO_WAREHOUSE_DATA_SETTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Warehouse_Master_TransactionTableAdapter = null;
            this.tableAdapterManager1.Warehouse_Product_TypeTableAdapter = null;
            this.tableAdapterManager1.Warehouse_ProductTableAdapter = null;
            this.tableAdapterManager1.Warehouse_StoreTableAdapter = null;
            this.tableAdapterManager1.Warehouse_TransactionTableAdapter = null;
            // 
            // DataPreview
            // 
            this.DataPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPreview.Location = new System.Drawing.Point(289, 78);
            this.DataPreview.Name = "DataPreview";
            this.DataPreview.Size = new System.Drawing.Size(240, 123);
            this.DataPreview.TabIndex = 26;
            this.DataPreview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data Preview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Analyze Forecasting Data For: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 390);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(327, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // Generate_Forecasting
            // 
            this.Generate_Forecasting.Location = new System.Drawing.Point(383, 374);
            this.Generate_Forecasting.Name = "Generate_Forecasting";
            this.Generate_Forecasting.Size = new System.Drawing.Size(146, 36);
            this.Generate_Forecasting.TabIndex = 31;
            this.Generate_Forecasting.Text = "Generate_Forecasting";
            this.Generate_Forecasting.UseVisualStyleBackColor = true;
            this.Generate_Forecasting.Click += new System.EventHandler(this.button1_Click);
            // 
            // FORECAST_RESULT
            // 
            this.FORECAST_RESULT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FORECAST_RESULT.Location = new System.Drawing.Point(50, 416);
            this.FORECAST_RESULT.Name = "FORECAST_RESULT";
            this.FORECAST_RESULT.Size = new System.Drawing.Size(479, 121);
            this.FORECAST_RESULT.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Data: ";
            // 
            // SEMI_AVERAGE_FORECAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(546, 558);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FORECAST_RESULT);
            this.Controls.Add(this.Generate_Forecasting);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertDataButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateToPicker);
            this.Controls.Add(this.DateFromPicker);
            this.Controls.Add(this.FORECAST_GRID);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SEMI_AVERAGE_FORECAST";
            this.Text = "SEMI_AVERAGE_FORECAST";
            this.Load += new System.EventHandler(this.SEMI_AVERAGE_FORECAST_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FORECAST_GRID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FORECAST_RESULT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATASUBMISSIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAINMENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEMIAVERAGEFORECASTToolStripMenuItem;
        private System.Windows.Forms.DataGridView FORECAST_GRID;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateToPicker;
        private System.Windows.Forms.DateTimePicker DateFromPicker;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Label label1;
        private PUYO_WAREHOUSE_DATA_SETTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView DataPreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Generate_Forecasting;
        private System.Windows.Forms.DataGridView FORECAST_RESULT;
        private System.Windows.Forms.Label label7;
    }
}