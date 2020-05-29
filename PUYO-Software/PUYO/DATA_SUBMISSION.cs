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
    public partial class DATA_SUBMISSION : Form
    {
        public DATA_SUBMISSION()
        {
            InitializeComponent();

            string Now_Date = DateTime.Now.ToShortDateString();

            label3.Text = Now_Date;

            PUYODataContext a = new PUYODataContext();

            var dataquery = from Transactions in a.Transactions
                            join Master_Transactions in a.Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                            where Master_Transactions.Master_Transaction_Date.Equals(Now_Date)
                            select new { Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
            dataGridView1.DataSource = dataquery;

            PUYOWAREHOUSEDataContext b = new PUYOWAREHOUSEDataContext();

            var stores = from Stores in b.Warehouse_Stores
                         select Stores.Store_ID;
            Store_Combo.DataSource = stores;
            Store_Combo.DisplayMember = "Store_ID";
        }

        private void Data_Submission_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Date_Text.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           POS a = new POS();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PUYOWAREHOUSEDataContext a = new PUYOWAREHOUSEDataContext();

            string Master_Transaction_ID;

            var Get_Last_Master_Transaction = from Master_Transaction in a.Warehouse_Master_Transactions
                                              orderby Master_Transaction.Master_Transaction_ID descending
                                              select Master_Transaction.Master_Transaction_ID;

            int Count_Master_Transaction = Get_Last_Master_Transaction.Count();

            if (Count_Master_Transaction == 0)
            {
                Master_Transaction_ID = "MT00001";
            }
            else
            {
                var Get_Last_Master_Transaction_ID = Get_Last_Master_Transaction.First().ToString();
                string New_Master_Transaction_ID = PUYO_FUNCTION.ID_PADDING(Get_Last_Master_Transaction_ID);
                Master_Transaction_ID = New_Master_Transaction_ID;
            }

            DateTime Now_Date = DateTime.Now;

            Warehouse_Master_Transaction New_Master_Transaction = new Warehouse_Master_Transaction();

            New_Master_Transaction.Master_Transaction_ID = Master_Transaction_ID;
            New_Master_Transaction.Master_Transaction_Date = Now_Date;

            //This will change depending on the ID of the cashier
            New_Master_Transaction.Store_ID = Store_Combo.Text;

            a.Warehouse_Master_Transactions.InsertOnSubmit(New_Master_Transaction);
            a.SubmitChanges();

            int Data_Row_Number = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Warehouse_Transaction New_Transaction = new Warehouse_Transaction();

                //This is the data of the name of the product
                string Product_ID_Single = (dataGridView1.Rows[Data_Row_Number].Cells[3].Value).ToString();

                //This is the data of the price of the product
                var Get_Product_Id = from Product_Get in a.Warehouse_Products
                                     where Product_Get.Product_ID.Equals(Product_ID_Single)
                                     select Product_Get.Product_ID;

                string Price_Single = Get_Product_Id.First().ToString();

                //This is the data of the quantity of the product
                string Product_Quantity_Single = (dataGridView1.Rows[Data_Row_Number].Cells[4].Value).ToString();

                //This is the data of the total price of the product
                string Total_Price_Single = (dataGridView1.Rows[Data_Row_Number].Cells[5].Value).ToString();

                //This is the data of the status of the product
                string Status_Single = (dataGridView1.Rows[Data_Row_Number].Cells[6].Value.ToString());

                string Transaction_ID;

                var Get_Last_Transaction = from Transaction in a.Warehouse_Transactions
                                           orderby Transaction.Transaction_ID descending
                                           select Transaction.Transaction_ID;

                int Count_Transaction = Get_Last_Transaction.Count();

                if (Count_Transaction == 0)
                {
                    Transaction_ID = "TI00001";
                }
                else
                {
                    var Get_Last_Transaction_ID = Get_Last_Transaction.First().ToString();
                    string New_Transaction_ID = PUYO_FUNCTION.ID_PADDING(Get_Last_Transaction_ID);
                    Transaction_ID = New_Transaction_ID;
                }

                New_Transaction.Master_Transaction_ID = Master_Transaction_ID;
                New_Transaction.Product_ID = Product_ID_Single;
                New_Transaction.Quantity = Convert.ToInt32(Product_Quantity_Single);
                New_Transaction.Transaction_ID = Transaction_ID;
                New_Transaction.Total_Price = Convert.ToInt32(Total_Price_Single);
                New_Transaction.Status = Status_Single;

                a.Warehouse_Transactions.InsertOnSubmit(New_Transaction);
                a.SubmitChanges();

                Data_Row_Number += 1;
            }
            MessageBox.Show("Data Successfully Sent To Warehouse", "Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.None);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Enabled = true;
                if (Date_Text.Text.Equals(""))
                {
                    Date_Text.Text = DateTime.Now.ToShortDateString();
                }
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Date_Text.Text.Equals(""))
            {
                Date_Text.Text = DateTime.Now.ToShortDateString();
            }

            string Now_Date = DateTime.Now.ToShortDateString();

            label3.Text = Now_Date;

            PUYODataContext a = new PUYODataContext();
            var dataquery = from Transactions in a.Transactions
                            join Master_Transactions in a.Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                            where Master_Transactions.Master_Transaction_Date.Equals(Date_Text.Text)
                            select new { Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status};
            dataGridView1.DataSource = dataquery;
        }

        private void mAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN a = new LOGIN();
            a.Show();
            this.Hide();
        }

        private void aDDSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_STOCK a = new ADD_STOCK();
            a.Show();
            this.Hide();
        }

        private void DATA_SUBMISSION_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void eXPIRYFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXPIRY_FORM a = new EXPIRY_FORM();
            a.Show();
            this.Hide();
        }
    }
}
