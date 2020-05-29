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
    public partial class WAREHOUSE : Form
    {
        public WAREHOUSE()
        {
            InitializeComponent();

            PUYOWAREHOUSEDataContext DataContext = new PUYOWAREHOUSEDataContext();

            var Store_List = from Stores in DataContext.Warehouse_Stores
                             select Stores.Store_ID;

            Store_Combo.DataSource = Store_List;
            Store_Combo.DisplayMember = "Store_ID";

            UPDATE_DATA_GRID();
        }

        private void UPDATE_DATA_GRID()
        {
            string Now_Date = DateTime.Now.ToShortDateString();

            Now_Date_Text.Text = Now_Date;

            PUYOWAREHOUSEDataContext DataContext = new PUYOWAREHOUSEDataContext();

            if (Store_Check.Checked == true)
            {
                if(Date_Check.Checked == true)
                {
                    if (Radio_All.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Date_Text.Text) && Stores.Store_ID.Equals(Store_Combo.Text)
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                    else if(Radio_Expired_Products.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Date_Text.Text) && Transactions.Status.Equals("EXPIRED") && Stores.Store_ID.Equals(Store_Combo.Text)
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                    else if(Radio_Sold_Products.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Date_Text.Text) && Transactions.Status.Equals("SOLD") && Stores.Store_ID.Equals(Store_Combo.Text)
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                }
                else if(Date_Check.Checked == false)
                {
                    if (Radio_All.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Now_Date) && Stores.Store_ID.Equals(Store_Combo.Text)
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                    else if (Radio_Expired_Products.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Now_Date) && Transactions.Status.Equals("EXPIRED") && Stores.Store_ID.Equals(Store_Combo.Text)
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                    else if (Radio_Sold_Products.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Now_Date) && Transactions.Status.Equals("SOLD") && Stores.Store_ID.Equals(Store_Combo.Text)
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                }
            }
            else if (Store_Check.Checked == false)
            {
                if(Date_Check.Checked == true)
                {
                    if (Radio_All.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Date_Text.Text)
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                    else if (Radio_Expired_Products.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Date_Text.Text) && Transactions.Status.Equals("EXPIRED")
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                    else if (Radio_Sold_Products.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Date_Text.Text) && Transactions.Status.Equals("SOLD")
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                }
                else if(Date_Check.Checked == false)
                {
                    if (Radio_All.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Now_Date)
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status};
                        Warehouse_Grid.DataSource = dataquery;
                    }
                    else if (Radio_Expired_Products.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Now_Date) && Transactions.Status.Equals("EXPIRED")
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                    else if (Radio_Sold_Products.Checked == true)
                    {
                        var dataquery = from Transactions in DataContext.Warehouse_Transactions
                                        join Master_Transactions in DataContext.Warehouse_Master_Transactions on Transactions.Master_Transaction_ID equals Master_Transactions.Master_Transaction_ID
                                        join Stores in DataContext.Warehouse_Stores on Master_Transactions.Store_ID equals Stores.Store_ID
                                        where Master_Transactions.Master_Transaction_Date.Equals(Now_Date) && Transactions.Status.Equals("SOLD")
                                        select new { Stores.Store_ID, Stores.Store_Location, Master_Transactions.Master_Transaction_Date, Transactions.Master_Transaction_ID, Transactions.Transaction_ID, Transactions.Product_ID, Transactions.Quantity, Transactions.Total_Price, Transactions.Status };
                        Warehouse_Grid.DataSource = dataquery;
                    }
                }
            }
        }

        private void dATASUBMISSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GENERATE_REPORT a = new GENERATE_REPORT();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Date_Text.Text.Equals(""))
            {
                Date_Text.Text = DateTime.Now.ToShortDateString();
            }
            UPDATE_DATA_GRID();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Date_Check.Checked == true)
            {
                Date_Group.Enabled = true;
                if (Date_Text.Text.Equals(""))
                {
                    Date_Text.Text = DateTime.Now.ToShortDateString();
                }
            }
            else
            {
                Date_Group.Enabled = false;
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            Date_Text.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void mAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN a = new LOGIN();
            a.Show();
            this.Hide();
        }

        private void WAREHOUSE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Store_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UPDATE_DATA_GRID(); 
        }

        private void Radio_All_CheckedChanged(object sender, EventArgs e)
        {
            UPDATE_DATA_GRID();
        }

        private void Radio_Transactions_CheckedChanged(object sender, EventArgs e)
        {
            UPDATE_DATA_GRID();
        }

        private void Radio_Expired_Products_CheckedChanged(object sender, EventArgs e)
        {
            UPDATE_DATA_GRID();
        }

        private void Store_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Store_Check.Checked == true)
            {
                Store_Combo.Enabled = true;
                Store_Combo.Text = "SI00001";
            }
            else
            {
                Store_Combo.Enabled = false;
            }
            UPDATE_DATA_GRID();
        }

        private void sEMIAVERAGEFORECASTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEMI_AVERAGE_FORECAST a = new SEMI_AVERAGE_FORECAST();
            a.Show();
            this.Hide();
        }
    }
}
