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
    public partial class EXPIRY_FORM : Form
    {
        public EXPIRY_FORM()
        {
            InitializeComponent(); 

            this.KeyPreview = true;

            this.KeyPreview = true;

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

            TransactionData.ColumnCount = 4;
            TransactionData.Columns[0].Name = "Product_Name";
            TransactionData.Columns[1].Name = "Price";
            TransactionData.Columns[2].Name = "Product_Qty";
            TransactionData.Columns[3].Name = "Total";

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete_Product";

            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Text = "Delete";

            TransactionData.Columns.Add(deleteButtonColumn);

            REFRESH_STOCKDATA();
        }

        private void REFRESH_STOCKDATA()
        {
            PUYODataContext a = new PUYODataContext();
            var productStockGet = from products in a.Products
                                  select new { products.Product_ID, products.Product_Name, products.Product_Stock };

            StockData.DataSource = productStockGet;
        }

        private void UPDATE_TOTAL(int sum)
        {
        }

        private void ADD_DATA(string PRODUCT_NAME, int PRODUCT_PRICE, int PRODUCT_QUANTITY, int PRODUCT_TOTAL)
        {
            bool Product_Found = false;

            int Row_Number = 0;

            foreach (POS_TRANSACTION TRANSACTION_ITEM in PUYO_FUNCTION.POS_TRANSACTIONS)
            {
                if (TRANSACTION_ITEM.PRODUCT_NAME.Equals(PRODUCT_NAME))
                {
                    TRANSACTION_ITEM.PRODUCT_QUANTITY += PRODUCT_QUANTITY;
                    TRANSACTION_ITEM.TOTAL_PRICE = TRANSACTION_ITEM.PRODUCT_PRICE * TRANSACTION_ITEM.PRODUCT_QUANTITY;
                    TransactionData.Rows[Row_Number].Cells[2].Value = TRANSACTION_ITEM.PRODUCT_QUANTITY;
                    TransactionData.Rows[Row_Number].Cells[3].Value = TRANSACTION_ITEM.TOTAL_PRICE;
                    Product_Found = true;
                }

                Row_Number = Row_Number + 1;

            }

            if (Product_Found == false)
            {
                TransactionData.Rows.Add(PRODUCT_NAME, PRODUCT_PRICE, PRODUCT_QUANTITY, PRODUCT_TOTAL);
                POS_TRANSACTION NEW_ITEM = new POS_TRANSACTION(PRODUCT_NAME, PRODUCT_PRICE, PRODUCT_QUANTITY, PRODUCT_TOTAL);
                PUYO_FUNCTION.POS_TRANSACTIONS.Add(NEW_ITEM);
            }

            int sum = PUYO_FUNCTION.GET_SUM();

            UPDATE_TOTAL(sum);
        }

        private void ADD_DATA_TO_GRID()
        {
            PUYODataContext a = new PUYODataContext();

            var productPriceQuery = from Product_Price in a.Products
                                    where Product_Price.Barcode_Number.Equals(Barcode_Text.Text)
                                    select Product_Price.Product_Price;

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

            int totalINT = productPriceINT * productQuantityINT;

            var productNameQuery = from Product_2 in a.Products
                                   where Product_2.Barcode_Number.Equals(Barcode_Text.Text)
                                   select Product_2.Product_Name;

            string productName = productNameQuery.First().ToString();

            ADD_DATA(productName, productPriceINT, productQuantityINT, totalINT);
        }

        private void INVENTORY_ALERT()
        {
            foreach (DataGridViewRow row in StockData.Rows)
            {
                if (Convert.ToUInt32(row.Cells[2].Value.ToString()) <= 10)
                {
                    MessageBox.Show(row.Cells[1].Value.ToString() + " is almost out of stock", "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_DATA_TO_GRID();
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

            int totalINT = productPriceINT * productQuantityINT;

            ADD_DATA(productName, productPriceINT, productQuantityINT, totalINT);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = TransactionData.CurrentCell.RowIndex;
            int columnindex = TransactionData.CurrentCell.ColumnIndex;

            if (columnindex == 4)
            {
                TransactionData.Rows.RemoveAt(rowindex);

                PUYO_FUNCTION.POS_TRANSACTIONS.RemoveAt(rowindex);

                int sum = PUYO_FUNCTION.GET_SUM();

                UPDATE_TOTAL(sum);
            }
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

        private void dATASUBMISSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PUYO_FUNCTION.POS_TRANSACTIONS.Clear();

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            ADD_DATA_TO_GRID();
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

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void POS_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void POS_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Barcode_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Barcode_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                Barcode_Quantity_Text.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ADD_DATA_TO_GRID();
                Barcode_Text.Text = "";
                Barcode_Quantity_Text.Text = "";
            }
        }

        private void Barcode_Quantity_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)
            {
                Barcode_Text.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ADD_DATA_TO_GRID();
                Barcode_Text.Text = "";
                Barcode_Quantity_Text.Text = "";
            }
        }

        private void Barcode_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void POS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void eXPIRYFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXPIRY_FORM a = new EXPIRY_FORM();
            a.Show();
            this.Hide();
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

            int totalINT = productPriceINT * productQuantityINT;

            ADD_DATA(productName, productPriceINT, productQuantityINT, totalINT);
        }

        private void Save_Data_Button_Click(object sender, EventArgs e)
        {
            PUYO_FUNCTION.SUBMIT_TRANSACTION(PUYO_FUNCTION.GET_MASTER_TRANSACTION_ID(), "EXPIRED");

            TransactionData.Rows.Clear();
            TransactionData.Refresh();

            REFRESH_STOCKDATA();

            INVENTORY_ALERT();

            MessageBox.Show("Data Successfully Added", "Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.None);
        }

        private void pOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PUYO_FUNCTION.POS_TRANSACTIONS.Clear();

            POS a = new POS();
            a.Show();
            this.Hide();
        }

        private void aDDSTOCKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PUYO_FUNCTION.POS_TRANSACTIONS.Clear();

            ADD_STOCK a = new ADD_STOCK();
            a.Show();
            this.Hide();
        }

        private void dATASUBMISSIONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PUYO_FUNCTION.POS_TRANSACTIONS.Clear();

            DATA_SUBMISSION a = new DATA_SUBMISSION();
            a.Show();
            this.Hide();
        }

        private void mAINMENUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PUYO_FUNCTION.POS_TRANSACTIONS.Clear();

            LOGIN a = new LOGIN();
            a.Show();
            this.Hide();
        }

        private void Barcode_Text_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Barcode_Quantity_Text.Focus();
            }
        }

        private void Barcode_Quantity_Text_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ADD_DATA_TO_GRID();
                Barcode_Text.Focus();
                Barcode_Text.Text = "";
                Barcode_Quantity_Text.Text = "";
            }
        }

        private void TransactionData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
