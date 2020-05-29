namespace PUYO
{
    partial class EXPIRY_FORM
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
            this.label7 = new System.Windows.Forms.Label();
            this.StockData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Barcode_Text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Barcode_Quantity_Text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Save_Data_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Product_Name_Combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Product_Type_Combo = new System.Windows.Forms.ComboBox();
            this.Add_Data_Button = new System.Windows.Forms.Button();
            this.Quantity_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TransactionData = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPIRYFORMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATASUBMISSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAINMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.StockData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Stock of Product";
            // 
            // StockData
            // 
            this.StockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockData.Location = new System.Drawing.Point(810, 67);
            this.StockData.Name = "StockData";
            this.StockData.Size = new System.Drawing.Size(336, 383);
            this.StockData.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Barcode_Text);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Barcode_Quantity_Text);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(13, 307);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(244, 158);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Barcode Expiry Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Barcode:";
            // 
            // Barcode_Text
            // 
            this.Barcode_Text.Location = new System.Drawing.Point(84, 20);
            this.Barcode_Text.Name = "Barcode_Text";
            this.Barcode_Text.Size = new System.Drawing.Size(146, 20);
            this.Barcode_Text.TabIndex = 16;
            this.Barcode_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Barcode_Text_KeyDown_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Barcode_Quantity_Text
            // 
            this.Barcode_Quantity_Text.Location = new System.Drawing.Point(84, 46);
            this.Barcode_Quantity_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Barcode_Quantity_Text.Name = "Barcode_Quantity_Text";
            this.Barcode_Quantity_Text.Size = new System.Drawing.Size(146, 20);
            this.Barcode_Quantity_Text.TabIndex = 5;
            this.Barcode_Quantity_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Barcode_Quantity_Text_KeyDown_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Quantity:";
            // 
            // Save_Data_Button
            // 
            this.Save_Data_Button.Location = new System.Drawing.Point(615, 318);
            this.Save_Data_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Data_Button.Name = "Save_Data_Button";
            this.Save_Data_Button.Size = new System.Drawing.Size(180, 132);
            this.Save_Data_Button.TabIndex = 23;
            this.Save_Data_Button.Text = "Save Data";
            this.Save_Data_Button.UseVisualStyleBackColor = true;
            this.Save_Data_Button.Click += new System.EventHandler(this.Save_Data_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Product_Name_Combo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Product_Type_Combo);
            this.groupBox1.Controls.Add(this.Add_Data_Button);
            this.groupBox1.Controls.Add(this.Quantity_Text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(270, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(332, 158);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Expiry Data ";
            // 
            // Product_Name_Combo
            // 
            this.Product_Name_Combo.FormattingEnabled = true;
            this.Product_Name_Combo.Location = new System.Drawing.Point(86, 46);
            this.Product_Name_Combo.Margin = new System.Windows.Forms.Padding(2);
            this.Product_Name_Combo.Name = "Product_Name_Combo";
            this.Product_Name_Combo.Size = new System.Drawing.Size(237, 21);
            this.Product_Name_Combo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Name:";
            // 
            // Product_Type_Combo
            // 
            this.Product_Type_Combo.FormattingEnabled = true;
            this.Product_Type_Combo.Location = new System.Drawing.Point(86, 23);
            this.Product_Type_Combo.Margin = new System.Windows.Forms.Padding(2);
            this.Product_Type_Combo.Name = "Product_Type_Combo";
            this.Product_Type_Combo.Size = new System.Drawing.Size(237, 21);
            this.Product_Type_Combo.TabIndex = 6;
            // 
            // Add_Data_Button
            // 
            this.Add_Data_Button.Location = new System.Drawing.Point(86, 93);
            this.Add_Data_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Data_Button.Name = "Add_Data_Button";
            this.Add_Data_Button.Size = new System.Drawing.Size(236, 50);
            this.Add_Data_Button.TabIndex = 5;
            this.Add_Data_Button.Text = "Add Data";
            this.Add_Data_Button.UseVisualStyleBackColor = true;
            this.Add_Data_Button.Click += new System.EventHandler(this.Add_Data_Button_Click);
            // 
            // Quantity_Text
            // 
            this.Quantity_Text.Location = new System.Drawing.Point(86, 69);
            this.Quantity_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity_Text.Name = "Quantity_Text";
            this.Quantity_Text.Size = new System.Drawing.Size(237, 20);
            this.Quantity_Text.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Type:";
            // 
            // TransactionData
            // 
            this.TransactionData.AllowUserToAddRows = false;
            this.TransactionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionData.Location = new System.Drawing.Point(11, 46);
            this.TransactionData.Margin = new System.Windows.Forms.Padding(2);
            this.TransactionData.Name = "TransactionData";
            this.TransactionData.ReadOnly = true;
            this.TransactionData.RowTemplate.Height = 24;
            this.TransactionData.Size = new System.Drawing.Size(784, 244);
            this.TransactionData.TabIndex = 21;
            this.TransactionData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionData_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem,
            this.eXPIRYFORMToolStripMenuItem,
            this.aDDSTOCKToolStripMenuItem,
            this.dATASUBMISSIONToolStripMenuItem,
            this.mAINMENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1217, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.pOSToolStripMenuItem.Text = "POS";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click_1);
            // 
            // eXPIRYFORMToolStripMenuItem
            // 
            this.eXPIRYFORMToolStripMenuItem.Name = "eXPIRYFORMToolStripMenuItem";
            this.eXPIRYFORMToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.eXPIRYFORMToolStripMenuItem.Text = "EXPIRY FORM";
            // 
            // aDDSTOCKToolStripMenuItem
            // 
            this.aDDSTOCKToolStripMenuItem.Name = "aDDSTOCKToolStripMenuItem";
            this.aDDSTOCKToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aDDSTOCKToolStripMenuItem.Text = "ADD STOCK";
            this.aDDSTOCKToolStripMenuItem.Click += new System.EventHandler(this.aDDSTOCKToolStripMenuItem_Click_1);
            // 
            // dATASUBMISSIONToolStripMenuItem
            // 
            this.dATASUBMISSIONToolStripMenuItem.Name = "dATASUBMISSIONToolStripMenuItem";
            this.dATASUBMISSIONToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.dATASUBMISSIONToolStripMenuItem.Text = "DATA SUBMISSION";
            this.dATASUBMISSIONToolStripMenuItem.Click += new System.EventHandler(this.dATASUBMISSIONToolStripMenuItem_Click_1);
            // 
            // mAINMENUToolStripMenuItem
            // 
            this.mAINMENUToolStripMenuItem.Name = "mAINMENUToolStripMenuItem";
            this.mAINMENUToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mAINMENUToolStripMenuItem.Text = "MAIN MENU";
            this.mAINMENUToolStripMenuItem.Click += new System.EventHandler(this.mAINMENUToolStripMenuItem_Click_1);
            // 
            // EXPIRY_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1217, 483);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StockData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Save_Data_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TransactionData);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EXPIRY_FORM";
            this.Text = "EXPIRY_FORM";
            ((System.ComponentModel.ISupportInitialize)(this.StockData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView StockData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Barcode_Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Barcode_Quantity_Text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Save_Data_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Product_Name_Combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Product_Type_Combo;
        private System.Windows.Forms.Button Add_Data_Button;
        private System.Windows.Forms.TextBox Quantity_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TransactionData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATASUBMISSIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSTOCKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAINMENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXPIRYFORMToolStripMenuItem;
    }
}