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
    public partial class SEMI_AVERAGE_FORECAST : Form
    {
        //public string[] Arrays = { "Silky Choco", "Silky Strawberry", "Choco-Berry", "Mint-Choco", "Silky Mango", "Silky Vanilla" };
        //public int[] EmptyArray = {0,0,0,0 ,0,0,0,0};

        //Dummy Data
        private int qty1 = 95;
        private int qty2 = 96;
        private int qty3 = 93;
        private int qty4 = 98;
        private int qty5 = 91;
        private int qty6 = 100;
        private int qty7 = 89;
        private int qty8 = 102;

        private int count = 0;


        public SEMI_AVERAGE_FORECAST()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM";
            dateTimePicker1.ShowUpDown = true;

            RESET_DUMMY_DATA();

            FORECAST_GRID.ColumnCount = 7;
            FORECAST_GRID.Columns[0].Name = "Silky Choco";
            FORECAST_GRID.Columns[1].Name = "Silky Strawberry";
            FORECAST_GRID.Columns[2].Name = "Choco-Berry";
            FORECAST_GRID.Columns[3].Name = "Caramel-Berry";
            FORECAST_GRID.Columns[4].Name = "Mint-Choco";
            FORECAST_GRID.Columns[5].Name = "Silky Mango";
            FORECAST_GRID.Columns[6].Name = "Silky Vanilla";

            FORECAST_RESULT.ColumnCount = 7;
            FORECAST_RESULT.Columns[0].Name = "Silky Choco";
            FORECAST_RESULT.Columns[1].Name = "Silky Strawberry";
            FORECAST_RESULT.Columns[2].Name = "Choco-Berry";
            FORECAST_RESULT.Columns[3].Name = "Caramel-Berry";
            FORECAST_RESULT.Columns[4].Name = "Mint-Choco";
            FORECAST_RESULT.Columns[5].Name = "Silky Mango";
            FORECAST_RESULT.Columns[6].Name = "Silky Vanilla";
        }

        private void RESET_DUMMY_DATA()
        {
            qty1 = 95;
            qty2 = 96;
            qty3 = 93;
            qty4 = 98;
            qty5 = 91;
            qty6 = 100;
            qty7 = 89;
            qty8 = 102;
            count = 0;
        }

        private void DUMMY_DATA_UPDATE()
        {
            qty1 = qty1 + 2;
            qty2 = qty2 + 2;
            qty3 = qty3 + 3;
            qty4 = qty4 + 3;
            qty5 = qty5 + 4;
            qty6 = qty6 + 4;
            qty7 = qty7 + 5;
            qty8 = qty8 + 5;
        }

        private void UPDATE_DATA_GRID()
        {
            using (PUYO_WAREHOUSE_ALL_ENTITY db = new PUYO_WAREHOUSE_ALL_ENTITY())
            {
                DataPreview.DataSource = db.GET_PRODUCT_SALES_ALL(DateFromPicker.Value.Date, DateToPicker.Value.Date);
            }
        }

        private void ADD_SEMI_AVERAGE_FORECAST_DATA()
        {
            //int countProduct = 0;
            //foreach (DataGridViewRow row in DataPreview.Rows)
            //{
            //    countProduct = 0;
            //    foreach (string productName in Arrays)
            //    {
            //        countProduct = countProduct + 1;
            //        if (productName.Equals(row.Cells[1].Value.ToString()))
            //        {
            //            EmptyArray[countProduct] = Convert.ToInt32(row.Cells[2].Value.ToString());
            //        }
            //    }
            //}
            //FORECAST_GRID.Rows.Add(EmptyArray[0], EmptyArray[1], EmptyArray[2], EmptyArray[3], EmptyArray[4], EmptyArray[5], EmptyArray[6], EmptyArray[7]);
        }

        private void SEMI_AVERAGE_FORECAST_Load(object sender, EventArgs e)
        {

        }

        private void FORECAST_GRID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            DUMMY_DATA_UPDATE();
            FORECAST_GRID.Rows.Add(qty1, qty2, qty3, qty4, qty5, qty6, qty7, qty8);
            FORECAST_GRID.Rows[count].HeaderCell.Value = DateFromPicker.Value.ToString("MMMM");
            count = count + 1;
            //FORECAST_GRID.Rows.Add("10", "10", "10", "10", "10", "10", "10", "10");
            //FORECAST_GRID.Rows[0].HeaderCell.Value = "January";
            //FORECAST_GRID.Rows.Add("10", "10", "10", "10", "10", "10", "10", "10");
            //FORECAST_GRID.Rows[1].HeaderCell.Value = "December";
            //FORECAST_GRID.Rows.Add("10", "10", "10", "10", "10", "10", "10", "10");
            //FORECAST_GRID.Rows[2].HeaderCell.Value = "November";
        }

        private void DateFromPicker_ValueChanged(object sender, EventArgs e)
        {
            UPDATE_DATA_GRID();
        }

        private void DateToPicker_ValueChanged(object sender, EventArgs e)
        {
            UPDATE_DATA_GRID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var GetRowCount = FORECAST_GRID.Rows.Count;
            var GetMiddleValue = GetRowCount / 2;

            Console.WriteLine(GetMiddleValue);

            //Initialize the necessary variables first
            var CountNumber = 0;
            int[] TotalGroupA = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] TotalGroupB = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //Now to seperate them into 2 groups and sum the values

            foreach (DataGridViewRow Rows in FORECAST_GRID.Rows)
            {
                if (CountNumber == GetMiddleValue)
                {
                    TotalGroupA[0] = TotalGroupA[0] + Convert.ToInt32(Rows.Cells[0].Value);
                    TotalGroupA[1] = TotalGroupA[1] + Convert.ToInt32(Rows.Cells[1].Value);
                    TotalGroupA[2] = TotalGroupA[2] + Convert.ToInt32(Rows.Cells[2].Value);
                    TotalGroupA[3] = TotalGroupA[3] + Convert.ToInt32(Rows.Cells[3].Value);
                    TotalGroupA[4] = TotalGroupA[4] + Convert.ToInt32(Rows.Cells[4].Value);
                    TotalGroupA[5] = TotalGroupA[5] + Convert.ToInt32(Rows.Cells[5].Value);
                    TotalGroupA[6] = TotalGroupA[6] + Convert.ToInt32(Rows.Cells[6].Value);
                    //TotalGroupA[7] = TotalGroupA[7] + Convert.ToInt32(Rows.Cells[7].Value);
                }
                else
                {
                    TotalGroupB[0] = TotalGroupB[0] + Convert.ToInt32(Rows.Cells[0].Value);
                    TotalGroupB[1] = TotalGroupB[1] + Convert.ToInt32(Rows.Cells[1].Value);
                    TotalGroupB[2] = TotalGroupB[2] + Convert.ToInt32(Rows.Cells[2].Value);
                    TotalGroupB[3] = TotalGroupB[3] + Convert.ToInt32(Rows.Cells[3].Value);
                    TotalGroupB[4] = TotalGroupB[4] + Convert.ToInt32(Rows.Cells[4].Value);
                    TotalGroupB[5] = TotalGroupB[5] + Convert.ToInt32(Rows.Cells[5].Value);
                    TotalGroupB[6] = TotalGroupB[6] + Convert.ToInt32(Rows.Cells[6].Value);
                    //TotalGroupB[7] = TotalGroupB[7] + Convert.ToInt32(Rows.Cells[7].Value);
                }
                CountNumber = CountNumber + 1;
            }

            //Initialize then the average 

            //Start with the a value
            int[] TotalAverageA = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            TotalAverageA[0] = TotalGroupA[0] / GetMiddleValue;
            TotalAverageA[1] = TotalGroupA[1] / GetMiddleValue;
            TotalAverageA[2] = TotalGroupA[2] / GetMiddleValue;
            TotalAverageA[3] = TotalGroupA[3] / GetMiddleValue;
            TotalAverageA[4] = TotalGroupA[4] / GetMiddleValue;
            TotalAverageA[5] = TotalGroupA[5] / GetMiddleValue;
            TotalAverageA[6] = TotalGroupA[6] / GetMiddleValue;
            TotalAverageA[7] = TotalGroupA[7] / GetMiddleValue;

            //Then start with the b value
            int[] TotalAverageB = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            TotalAverageB[0] = TotalGroupB[0] / GetMiddleValue;
            TotalAverageB[1] = TotalGroupB[1] / GetMiddleValue;
            TotalAverageB[2] = TotalGroupB[2] / GetMiddleValue;
            TotalAverageB[3] = TotalGroupB[3] / GetMiddleValue;
            TotalAverageB[4] = TotalGroupB[4] / GetMiddleValue;
            TotalAverageB[5] = TotalGroupB[5] / GetMiddleValue;
            TotalAverageB[6] = TotalGroupB[6] / GetMiddleValue;
            TotalAverageB[7] = TotalGroupB[7] / GetMiddleValue;

            int[] VARIABLE_A = TotalAverageA;

            //Then start to calculate the 'B' value 

            int[] VARIABLE_B = { 0, 0, 0, 0, 0, 0, 0, 0 };

            VARIABLE_B[0] = (TotalAverageB[0] - TotalAverageA[0]) / GetMiddleValue;
            VARIABLE_B[1] = (TotalAverageB[1] - TotalAverageA[1]) / GetMiddleValue;
            VARIABLE_B[2] = (TotalAverageB[2] - TotalAverageA[2]) / GetMiddleValue;
            VARIABLE_B[3] = (TotalAverageB[3] - TotalAverageA[3]) / GetMiddleValue;
            VARIABLE_B[4] = (TotalAverageB[4] - TotalAverageA[4]) / GetMiddleValue;
            VARIABLE_B[5] = (TotalAverageB[5] - TotalAverageA[5]) / GetMiddleValue;
            VARIABLE_B[6] = (TotalAverageB[6] - TotalAverageA[6]) / GetMiddleValue;
            VARIABLE_B[7] = (TotalAverageB[7] - TotalAverageA[7]) / GetMiddleValue;

            //Set the final value

            int[] FINAL_VARIABLE = { 0, 0, 0, 0, 0, 0, 0, 0 };

            FINAL_VARIABLE[0] = VARIABLE_A[0] + ((VARIABLE_B[0]) * 2);
            FINAL_VARIABLE[1] = VARIABLE_A[1] + ((VARIABLE_B[1]) * 2);
            FINAL_VARIABLE[2] = VARIABLE_A[2] + ((VARIABLE_B[2]) * 2);
            FINAL_VARIABLE[3] = VARIABLE_A[3] + ((VARIABLE_B[3]) * 2);
            FINAL_VARIABLE[4] = VARIABLE_A[4] + ((VARIABLE_B[4]) * 2);
            FINAL_VARIABLE[5] = VARIABLE_A[5] + ((VARIABLE_B[5]) * 2);
            FINAL_VARIABLE[6] = VARIABLE_A[6] + ((VARIABLE_B[6]) * 2);
            FINAL_VARIABLE[7] = VARIABLE_A[7] + ((VARIABLE_B[7]) * 2);

            FORECAST_RESULT.Rows.Add(FINAL_VARIABLE[0], FINAL_VARIABLE[1], FINAL_VARIABLE[2], FINAL_VARIABLE[3], FINAL_VARIABLE[4], FINAL_VARIABLE[5], FINAL_VARIABLE[6], FINAL_VARIABLE[7]);
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WAREHOUSE a = new WAREHOUSE();
            a.Show();
            this.Hide();
        }

        private void dATASUBMISSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GENERATE_REPORT a = new GENERATE_REPORT();
            a.Show();
            this.Hide();
        }

        private void mAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN a = new LOGIN();
            a.Show();
            this.Hide();
        }
    }
}
