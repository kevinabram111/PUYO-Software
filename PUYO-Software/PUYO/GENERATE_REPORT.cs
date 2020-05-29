using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUYO
{
    public partial class GENERATE_REPORT : Form
    {
        public GENERATE_REPORT()
        {
            InitializeComponent();
            TodayDateText.Text = DateTime.Now.ToShortDateString();

            PUYOWAREHOUSEDataContext a = new PUYOWAREHOUSEDataContext();

            var stores = from Stores in a.Warehouse_Stores
                         select Stores.Store_ID;
            Store_Combo.DataSource = stores;
            Store_Combo.DisplayMember = "Store_ID";
        }

        private void DATA_GRID_REPORT_UPDATE()
        {
            if (ReportCombo.Text.Equals("Product_Sales"))
            {
                using (PUYO_WAREHOUSE_ENTITY db = new PUYO_WAREHOUSE_ENTITY())
                {
                    DisplayDataGrid.DataSource = db.GET_PRODUCT_SALES(Store_Combo.Text, DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    ReportTypeText.Text = "Report Type: " + ReportCombo.Text + " For " + Store_Combo.Text;
                }
            }
            else if (ReportCombo.Text.Equals("Average_Sales"))
            {
                using (PUYO_WAREHOUSE_AVG_ENTITY db = new PUYO_WAREHOUSE_AVG_ENTITY())
                {
                    DisplayDataGrid.DataSource = db.GET_AVERAGE_SALES_FORECAST(Store_Combo.Text, DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    ReportTypeText.Text = "Report Type: " + ReportCombo.Text + " For " + Store_Combo.Text;
                }
            }
            else if (ReportCombo.Text.Equals("Product_Sales_All"))
            {
                using (PUYO_WAREHOUSE_ALL_ENTITY db = new PUYO_WAREHOUSE_ALL_ENTITY())
                {
                    DisplayDataGrid.DataSource = db.GET_PRODUCT_SALES_ALL(DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    ReportTypeText.Text = "Report Type: " + ReportCombo.Text;
                }
            }
            else if (ReportCombo.Text.Equals("Expired_Products"))
            {
                using (PUYO_WAREHOUSE_EXP_ENTITY db = new PUYO_WAREHOUSE_EXP_ENTITY())
                {
                    DisplayDataGrid.DataSource = db.GET_EXPIRED_PRODUCTS(Store_Combo.Text, DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    ReportTypeText.Text = "Report Type: " + ReportCombo.Text + " For " + Store_Combo.Text;
                }
            }
            else if (ReportCombo.Text.Equals("Expired_Products_All"))
            {
                using (PUYO_WAREHOUSE_EXP1_ALL_ENTITY db = new PUYO_WAREHOUSE_EXP1_ALL_ENTITY())
                {
                    DisplayDataGrid.DataSource = db.GET_EXPIRED_PRODUCTS_ALL(DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    ReportTypeText.Text = "Report Type: " + ReportCombo.Text;
                }
            }
            else if (ReportCombo.Text.Equals("Restocking_Single_Store"))
            {
                using (PUYO_WAREHOUSE_RESTOCK1_ENTITY db = new PUYO_WAREHOUSE_RESTOCK1_ENTITY())
                {
                    DisplayDataGrid.DataSource = db.RESTOCKING(Store_Combo.Text, DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    ReportTypeText.Text = "Report Type: " + ReportCombo.Text + " For " + Store_Combo.Text;
                }
            }
            else if (ReportCombo.Text.Equals("Restocking_All"))
            {
                using (PUYO_WAREHOUSE_RESTOCK1_ALL_ENTITY db = new PUYO_WAREHOUSE_RESTOCK1_ALL_ENTITY())
                {
                    DisplayDataGrid.DataSource = db.RESTOCKING_ALL(DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    ReportTypeText.Text = "Report Type: " + ReportCombo.Text;
                }
            }
        }

        private void GENERATE_REPORT_Load(object sender, EventArgs e)
        {
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WAREHOUSE a = new WAREHOUSE();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DateFromPicker.Value.Date);
            Console.WriteLine(DateToPicker.Value.Date);


            if (ReportCombo.Text.Equals("Product_Sales"))
            {
                using (PUYO_WAREHOUSE_ENTITY db = new PUYO_WAREHOUSE_ENTITY())
                {
                    GET_PRODUCT_SALESBindingSource.DataSource = db.GET_PRODUCT_SALES(Store_Combo.Text, DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                     new Microsoft.Reporting.WinForms.ReportParameter("StoreID", Store_Combo.Text),
                     new Microsoft.Reporting.WinForms.ReportParameter("FromDate", DateFromPicker.Value.Date.ToShortDateString()),
                     new Microsoft.Reporting.WinForms.ReportParameter("ToDate", DateToPicker.Value.Date.ToShortDateString())
                    };
                    GenerateReportViewer.LocalReport.SetParameters(parameters);
                    GenerateReportViewer.RefreshReport();
                    DisplayDataGrid.DataSource = GET_PRODUCT_SALESBindingSource;
                }
            }

            else if (ReportCombo.Text.Equals("Average_Sales"))
            {
                using (PUYO_WAREHOUSE_AVG_ENTITY db = new PUYO_WAREHOUSE_AVG_ENTITY())
                {
                    GET_AVERAGE_SALESBindingSource.DataSource = db.GET_AVERAGE_SALES_FORECAST(Store_Combo.Text, DateFromPicker.Value.Date, DateToPicker.Value.Date);
                    Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                     new Microsoft.Reporting.WinForms.ReportParameter("StoreID", Store_Combo.Text),
                     new Microsoft.Reporting.WinForms.ReportParameter("FromDate", DateFromPicker.Value.Date.ToShortDateString()),
                     new Microsoft.Reporting.WinForms.ReportParameter("ToDate", DateToPicker.Value.Date.ToShortDateString())
                    };
                    GenerateReportViewer.LocalReport.SetParameters(parameters);
                    GenerateReportViewer.RefreshReport();
                    DisplayDataGrid.DataSource = GET_AVERAGE_SALESBindingSource;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void mAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN a = new LOGIN();
            a.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DATA_GRID_REPORT_UPDATE();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void DateFromPicker_ValueChanged(object sender, EventArgs e)
        {
            DATA_GRID_REPORT_UPDATE();
        }

        private void DateToPicker_ValueChanged(object sender, EventArgs e)
        {
            DATA_GRID_REPORT_UPDATE();
        }

        private void ReportCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DATA_GRID_REPORT_UPDATE();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void GENERATE_REPORT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void DisplayDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sEMIAVERAGEFORECASTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEMI_AVERAGE_FORECAST a = new SEMI_AVERAGE_FORECAST();
            a.Show();
            this.Hide();
        }
    }
}
