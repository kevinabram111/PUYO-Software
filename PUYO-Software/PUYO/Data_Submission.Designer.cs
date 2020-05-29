namespace PUYO
{
    partial class DATA_SUBMISSION
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
            this.aDDSTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAINMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Date_Text = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Date_Select_Button = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Store_Combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eXPIRYFORMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.pOSToolStripMenuItem.Text = "POS";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // dATASUBMISSIONToolStripMenuItem
            // 
            this.dATASUBMISSIONToolStripMenuItem.Name = "dATASUBMISSIONToolStripMenuItem";
            this.dATASUBMISSIONToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.dATASUBMISSIONToolStripMenuItem.Text = "DATA SUBMISSION";
            // 
            // aDDSTOCKToolStripMenuItem
            // 
            this.aDDSTOCKToolStripMenuItem.Name = "aDDSTOCKToolStripMenuItem";
            this.aDDSTOCKToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aDDSTOCKToolStripMenuItem.Text = "ADD STOCK";
            this.aDDSTOCKToolStripMenuItem.Click += new System.EventHandler(this.aDDSTOCKToolStripMenuItem_Click);
            // 
            // mAINMENUToolStripMenuItem
            // 
            this.mAINMENUToolStripMenuItem.Name = "mAINMENUToolStripMenuItem";
            this.mAINMENUToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mAINMENUToolStripMenuItem.Text = "MAIN MENU";
            this.mAINMENUToolStripMenuItem.Click += new System.EventHandler(this.mAINMENUToolStripMenuItem_Click);
            // 
            // Date_Text
            // 
            this.Date_Text.Location = new System.Drawing.Point(43, 200);
            this.Date_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Date_Text.Name = "Date_Text";
            this.Date_Text.Size = new System.Drawing.Size(193, 20);
            this.Date_Text.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(461, 36);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Select another date";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Date_Select_Button);
            this.groupBox1.Controls.Add(this.monthCalendar2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Date_Text);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(461, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(247, 273);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select by date";
            // 
            // Date_Select_Button
            // 
            this.Date_Select_Button.Location = new System.Drawing.Point(43, 226);
            this.Date_Select_Button.Name = "Date_Select_Button";
            this.Date_Select_Button.Size = new System.Drawing.Size(193, 42);
            this.Date_Select_Button.TabIndex = 7;
            this.Date_Select_Button.Text = "Select Date";
            this.Date_Select_Button.UseVisualStyleBackColor = true;
            this.Date_Select_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(9, 24);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 6;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 306);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(461, 335);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(247, 53);
            this.Submit_Button.TabIndex = 6;
            this.Submit_Button.Text = "Submit Data";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TODAY DATE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "<TODAY\'S DATE>";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Store_Combo
            // 
            this.Store_Combo.FormattingEnabled = true;
            this.Store_Combo.Location = new System.Drawing.Point(73, 27);
            this.Store_Combo.Name = "Store_Combo";
            this.Store_Combo.Size = new System.Drawing.Size(121, 21);
            this.Store_Combo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Store_ID: ";
            // 
            // eXPIRYFORMToolStripMenuItem
            // 
            this.eXPIRYFORMToolStripMenuItem.Name = "eXPIRYFORMToolStripMenuItem";
            this.eXPIRYFORMToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.eXPIRYFORMToolStripMenuItem.Text = "EXPIRY_FORM";
            this.eXPIRYFORMToolStripMenuItem.Click += new System.EventHandler(this.eXPIRYFORMToolStripMenuItem_Click);
            // 
            // DATA_SUBMISSION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(739, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Store_Combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DATA_SUBMISSION";
            this.Text = "DATA_SUBMISSION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DATA_SUBMISSION_FormClosing);
            this.Load += new System.EventHandler(this.Data_Submission_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATASUBMISSIONToolStripMenuItem;
        private System.Windows.Forms.TextBox Date_Text;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button Date_Select_Button;
        private System.Windows.Forms.ToolStripMenuItem mAINMENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSTOCKToolStripMenuItem;
        private System.Windows.Forms.ComboBox Store_Combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem eXPIRYFORMToolStripMenuItem;
    }
}