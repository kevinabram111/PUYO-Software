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
    public partial class ADD_STOCK : Form
    {
        public ADD_STOCK()
        {
            InitializeComponent();

            PUYODataContext a = new PUYODataContext();
            var productTypeQuery = from Product_Type in a.Product_Types
                                   select Product_Type.Product_Type_Name;
            Product_Type_Combo.DataSource = productTypeQuery;
            Product_Type_Combo.DisplayMember = "Product_Type_Name";

            var productName = from Product in a.Products
                              where Product.Product_Type_ID.Equals("PT00001")
                              select Product.Product_Name;
            Product_Name_Combo.DataSource = productName;
            Product_Name_Combo.DisplayMember = "Product_Name";

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Product_Name";
            dataGridView1.Columns[1].Name = "Product_Quantity";

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete_Product";

            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Text = "Delete";

            dataGridView1.Columns.Add(deleteButtonColumn);

            REFRESH_STOCKDATA();
        }

        private void REFRESH_STOCKDATA()
        {
            PUYODataContext a = new PUYODataContext();
            var productStockGet = from products in a.Products
                                  select new { products.Product_ID, products.Product_Name, products.Product_Stock };

            dataGridView2.DataSource = productStockGet;
        }

        private void ADD_DATA(string PRODUCT_NAME, int STOCKING_QUANTITY)
        {
            bool Product_Found = false;

            int Row_Number = 0;

            foreach (RESTOCKING_TRANSACTION RESTOCKING_ITEM in PUYO_FUNCTION.RESTROCKING_TRANSACTIONS)
            {
                if (RESTOCKING_ITEM.PRODUCT_NAME.Equals(PRODUCT_NAME))
                {
                    RESTOCKING_ITEM.PRODUCT_QUANTITY_ADDED += STOCKING_QUANTITY;
                    dataGridView1.Rows[Row_Number].Cells[1].Value = RESTOCKING_ITEM.PRODUCT_QUANTITY_ADDED;
                    Product_Found = true;
                }

                Row_Number = Row_Number + 1;
            }

            if (Product_Found == false)
            {
                dataGridView1.Rows.Add(PRODUCT_NAME, STOCKING_QUANTITY);
                RESTOCKING_TRANSACTION NEW_ITEM = new RESTOCKING_TRANSACTION(PRODUCT_NAME, STOCKING_QUANTITY);
                PUYO_FUNCTION.RESTROCKING_TRANSACTIONS.Add(NEW_ITEM);
            }
        }

        private void ADD_BARCODE_DATA()
        {
            PUYODataContext a = new PUYODataContext();

            string barcode = Barcode_Text.Text;

            var productNameQuery = from Product in a.Products
                                   where Product.Barcode_Number.Equals(Barcode_Text.Text)
                                   select Product.Product_Name;

            string productName = productNameQuery.First().ToString();

            var productPriceQuery = from Product in a.Products
                                    where Product.Barcode_Number.Equals(Barcode_Text.Text)
                                    select Product.Product_Price;

            string productPrice = productPriceQuery.First().ToString();

            int productPriceINT = Convert.ToInt32(productPrice);

            int productQuantityINT;

            if (Barcode_Quantity_Text.Text.Equals(""))
            {
                productQuantityINT = 1;
            }
            else
            {
                productQuantityINT = Convert.ToInt32(Barcode_Quantity_Text.Text);
            }

            ADD_DATA(productName, productQuantityINT);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //Add Data Button
        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PUYODataContext a = new PUYODataContext();
            string ProductTypeName = Product_Type_Combo.Text;
            var typeProduct = from Product_Type in a.Product_Types
                              where Product_Type.Product_Type_Name.Equals(ProductTypeName)
                              select Product_Type.Product_Type_ID;
            string typeID = typeProduct.First().ToString();

            var productName = from Product in a.Products
                              where Product.Product_Type_ID.Equals(typeID)
                              select Product.Product_Name;
            Product_Name_Combo.DataSource = productName;
            Product_Name_Combo.DisplayMember = "Product_Name";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Save Data Button
        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void dATASUBMISSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DATA_SUBMISSION a = new DATA_SUBMISSION();
            a.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PUYO_FUNCTION.POS_TRANSACTIONS.Clear();

            LOGIN a = new LOGIN();
            a.Show();
            this.Hide();
        }

        private void aDDSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PUYO_FUNCTION.POS_TRANSACTIONS.Clear();

            ADD_STOCK a = new ADD_STOCK();
            a.Show();
            this.Hide();
        }

        private void Save_Data_Button_Click(object sender, EventArgs e)
        {
            PUYO_FUNCTION.SUBMIT_RESTOCKING();

            REFRESH_STOCKDATA();

            MessageBox.Show("Data Successfully Added", "Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.None);
        }

        private void Add_Data_Button_Click(object sender, EventArgs e)
        {
            PUYODataContext a = new PUYODataContext();

            string productName = Product_Name_Combo.Text;

            var productPriceQuery = from Product in a.Products
                                    where Product.Product_Name.Equals(productName)
                                    select Product.Product_Price;

            string productPrice = productPriceQuery.First().ToString();

            int productPriceINT = Convert.ToInt32(productPrice);

            int productQuantityINT;

            if (Quantity_Text.Text.Equals(""))
            {
                productQuantityINT = 1;
            }
            else
            {
                productQuantityINT = Convert.ToInt32(Quantity_Text.Text);
            }

            ADD_DATA(productName, productQuantityINT);

            Quantity_Text.Text = "";
        }

        private void Product_Type_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            if (columnindex == 2)
            {
                dataGridView1.Rows.RemoveAt(rowindex);

                PUYO_FUNCTION.RESTROCKING_TRANSACTIONS.RemoveAt(rowindex);
            }
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PUYO_FUNCTION.RESTROCKING_TRANSACTIONS.Clear();

            POS a = new POS();
            a.Show();
            this.Hide();
        }

        private void dATASUBMISSIONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PUYO_FUNCTION.RESTROCKING_TRANSACTIONS.Clear();

            DATA_SUBMISSION a = new DATA_SUBMISSION();
            a.Show();
            this.Hide();
        }

        private void mAINMENUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PUYO_FUNCTION.RESTROCKING_TRANSACTIONS.Clear();

            LOGIN a = new LOGIN();
            a.Show();
            this.Hide();
        }

        private void aDDSTOCKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ADD_STOCK_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void eXPIRYFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PUYO_FUNCTION.RESTROCKING_TRANSACTIONS.Clear();

            EXPIRY_FORM a = new EXPIRY_FORM();
            a.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ADD_BARCODE_DATA();
        }

        private void ADD_STOCK_Load(object sender, EventArgs e)
        {

        }

        private void Barcode_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Barcode_Quantity_Text.Focus();
            }
        }

        private void Barcode_Quantity_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ADD_BARCODE_DATA();
                Barcode_Text.Focus();
                Barcode_Text.Text = "";
                Barcode_Quantity_Text.Text = "";
            }
        }
    }
}
