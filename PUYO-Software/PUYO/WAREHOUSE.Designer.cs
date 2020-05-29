namespace PUYO
{
    partial class WAREHOUSE
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
            this.Now_Date_Text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Warehouse_Grid = new System.Windows.Forms.DataGridView();
            this.Date_Group = new System.Windows.Forms.GroupBox();
            this.Select_Date_Button = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_Text = new System.Windows.Forms.TextBox();
            this.Date_Check = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATASUBMISSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEMIAVERAGEFORECASTINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAINMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Store_Check = new System.Windows.Forms.CheckBox();
            this.Store_Combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Radio_Sold_Products = new System.Windows.Forms.RadioButton();
            this.Radio_Expired_Products = new System.Windows.Forms.RadioButton();
            this.Radio_All = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse_Grid)).BeginInit();
            this.Date_Group.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Now_Date_Text
            // 
            this.Now_Date_Text.AutoSize = true;
            this.Now_Date_Text.Location = new System.Drawing.Point(91, 86);
            this.Now_Date_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Now_Date_Text.Name = "Now_Date_Text";
            this.Now_Date_Text.Size = new System.Drawing.Size(97, 13);
            this.Now_Date_Text.TabIndex = 14;
            this.Now_Date_Text.Text = "<TODAY\'S DATE>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "TODAY DATE:";
            // 
            // Warehouse_Grid
            // 
            this.Warehouse_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Warehouse_Grid.Location = new System.Drawing.Point(11, 107);
            this.Warehouse_Grid.Margin = new System.Windows.Forms.Padding(2);
            this.Warehouse_Grid.Name = "Warehouse_Grid";
            this.Warehouse_Grid.RowTemplate.Height = 24;
            this.Warehouse_Grid.Size = new System.Drawing.Size(437, 330);
            this.Warehouse_Grid.TabIndex = 11;
            // 
            // Date_Group
            // 
            this.Date_Group.Controls.Add(this.Select_Date_Button);
            this.Date_Group.Controls.Add(this.monthCalendar2);
            this.Date_Group.Controls.Add(this.label1);
            this.Date_Group.Controls.Add(this.Date_Text);
            this.Date_Group.Enabled = false;
            this.Date_Group.Location = new System.Drawing.Point(463, 107);
            this.Date_Group.Margin = new System.Windows.Forms.Padding(2);
            this.Date_Group.Name = "Date_Group";
            this.Date_Group.Padding = new System.Windows.Forms.Padding(2);
            this.Date_Group.Size = new System.Drawing.Size(247, 330);
            this.Date_Group.TabIndex = 10;
            this.Date_Group.TabStop = false;
            this.Date_Group.Text = "Select by date";
            // 
            // Select_Date_Button
            // 
            this.Select_Date_Button.Location = new System.Drawing.Point(9, 232);
            this.Select_Date_Button.Name = "Select_Date_Button";
            this.Select_Date_Button.Size = new System.Drawing.Size(227, 93);
            this.Select_Date_Button.TabIndex = 7;
            this.Select_Date_Button.Text = "Select Date";
            this.Select_Date_Button.UseVisualStyleBackColor = true;
            this.Select_Date_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(9, 24);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 6;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date:";
            // 
            // Date_Text
            // 
            this.Date_Text.Location = new System.Drawing.Point(43, 192);
            this.Date_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Date_Text.Name = "Date_Text";
            this.Date_Text.Size = new System.Drawing.Size(193, 20);
            this.Date_Text.TabIndex = 2;
            // 
            // Date_Check
            // 
            this.Date_Check.AutoSize = true;
            this.Date_Check.Location = new System.Drawing.Point(463, 85);
            this.Date_Check.Margin = new System.Windows.Forms.Padding(2);
            this.Date_Check.Name = "Date_Check";
            this.Date_Check.Size = new System.Drawing.Size(119, 17);
            this.Date_Check.TabIndex = 9;
            this.Date_Check.Text = "Select another date";
            this.Date_Check.UseVisualStyleBackColor = true;
            this.Date_Check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem,
            this.dATASUBMISSIONToolStripMenuItem,
            this.sEMIAVERAGEFORECASTINGToolStripMenuItem,
            this.mAINMENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.pOSToolStripMenuItem.Text = "WAREHOUSE";
            // 
            // dATASUBMISSIONToolStripMenuItem
            // 
            this.dATASUBMISSIONToolStripMenuItem.Name = "dATASUBMISSIONToolStripMenuItem";
            this.dATASUBMISSIONToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.dATASUBMISSIONToolStripMenuItem.Text = "GENERATE REPORT";
            this.dATASUBMISSIONToolStripMenuItem.Click += new System.EventHandler(this.dATASUBMISSIONToolStripMenuItem_Click);
            // 
            // sEMIAVERAGEFORECASTINGToolStripMenuItem
            // 
            this.sEMIAVERAGEFORECASTINGToolStripMenuItem.Name = "sEMIAVERAGEFORECASTINGToolStripMenuItem";
            this.sEMIAVERAGEFORECASTINGToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.sEMIAVERAGEFORECASTINGToolStripMenuItem.Text = "SEMI AVERAGE FORECAST";
            this.sEMIAVERAGEFORECASTINGToolStripMenuItem.Click += new System.EventHandler(this.sEMIAVERAGEFORECASTINGToolStripMenuItem_Click);
            // 
            // mAINMENUToolStripMenuItem
            // 
            this.mAINMENUToolStripMenuItem.Name = "mAINMENUToolStripMenuItem";
            this.mAINMENUToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mAINMENUToolStripMenuItem.Text = "MAIN MENU";
            this.mAINMENUToolStripMenuItem.Click += new System.EventHandler(this.mAINMENUToolStripMenuItem_Click);
            // 
            // Store_Check
            // 
            this.Store_Check.AutoSize = true;
            this.Store_Check.Location = new System.Drawing.Point(11, 42);
            this.Store_Check.Margin = new System.Windows.Forms.Padding(2);
            this.Store_Check.Name = "Store_Check";
            this.Store_Check.Size = new System.Drawing.Size(110, 17);
            this.Store_Check.TabIndex = 17;
            this.Store_Check.Text = "Select by store ID";
            this.Store_Check.UseVisualStyleBackColor = true;
            this.Store_Check.CheckedChanged += new System.EventHandler(this.Store_Check_CheckedChanged);
            // 
            // Store_Combo
            // 
            this.Store_Combo.Enabled = false;
            this.Store_Combo.FormattingEnabled = true;
            this.Store_Combo.Items.AddRange(new object[] {
            "SI00001"});
            this.Store_Combo.Location = new System.Drawing.Point(126, 40);
            this.Store_Combo.Name = "Store_Combo";
            this.Store_Combo.Size = new System.Drawing.Size(121, 21);
            this.Store_Combo.TabIndex = 18;
            this.Store_Combo.SelectedIndexChanged += new System.EventHandler(this.Store_Combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "View Data By:";
            // 
            // Radio_Sold_Products
            // 
            this.Radio_Sold_Products.AutoSize = true;
            this.Radio_Sold_Products.Location = new System.Drawing.Point(418, 44);
            this.Radio_Sold_Products.Name = "Radio_Sold_Products";
            this.Radio_Sold_Products.Size = new System.Drawing.Size(94, 17);
            this.Radio_Sold_Products.TabIndex = 20;
            this.Radio_Sold_Products.Text = "Sold_Products";
            this.Radio_Sold_Products.UseVisualStyleBackColor = true;
            this.Radio_Sold_Products.CheckedChanged += new System.EventHandler(this.Radio_Transactions_CheckedChanged);
            // 
            // Radio_Expired_Products
            // 
            this.Radio_Expired_Products.AutoSize = true;
            this.Radio_Expired_Products.Location = new System.Drawing.Point(510, 44);
            this.Radio_Expired_Products.Name = "Radio_Expired_Products";
            this.Radio_Expired_Products.Size = new System.Drawing.Size(108, 17);
            this.Radio_Expired_Products.TabIndex = 21;
            this.Radio_Expired_Products.Text = "Expired_Products";
            this.Radio_Expired_Products.UseVisualStyleBackColor = true;
            this.Radio_Expired_Products.CheckedChanged += new System.EventHandler(this.Radio_Expired_Products_CheckedChanged);
            // 
            // Radio_All
            // 
            this.Radio_All.AutoSize = true;
            this.Radio_All.Checked = true;
            this.Radio_All.Location = new System.Drawing.Point(376, 44);
            this.Radio_All.Name = "Radio_All";
            this.Radio_All.Size = new System.Drawing.Size(36, 17);
            this.Radio_All.TabIndex = 23;
            this.Radio_All.TabStop = true;
            this.Radio_All.Text = "All";
            this.Radio_All.UseVisualStyleBackColor = true;
            this.Radio_All.CheckedChanged += new System.EventHandler(this.Radio_All_CheckedChanged);
            // 
            // WAREHOUSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(729, 448);
            this.Controls.Add(this.Radio_All);
            this.Controls.Add(this.Radio_Expired_Products);
            this.Controls.Add(this.Radio_Sold_Products);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Store_Combo);
            this.Controls.Add(this.Store_Check);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Now_Date_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Warehouse_Grid);
            this.Controls.Add(this.Date_Group);
            this.Controls.Add(this.Date_Check);
            this.Name = "WAREHOUSE";
            this.Text = "WAREHOUSE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WAREHOUSE_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse_Grid)).EndInit();
            this.Date_Group.ResumeLayout(false);
            this.Date_Group.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Now_Date_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Warehouse_Grid;
        private System.Windows.Forms.GroupBox Date_Group;
        private System.Windows.Forms.Button Select_Date_Button;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Date_Text;
        private System.Windows.Forms.CheckBox Date_Check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATASUBMISSIONToolStripMenuItem;
        private System.Windows.Forms.CheckBox Store_Check;
        private System.Windows.Forms.ComboBox Store_Combo;
        private System.Windows.Forms.ToolStripMenuItem mAINMENUToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Radio_Sold_Products;
        private System.Windows.Forms.RadioButton Radio_Expired_Products;
        private System.Windows.Forms.RadioButton Radio_All;
        private System.Windows.Forms.ToolStripMenuItem sEMIAVERAGEFORECASTINGToolStripMenuItem;
    }
}