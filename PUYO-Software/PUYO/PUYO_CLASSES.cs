using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUYO
{
    public class PUYO_FUNCTION
    {
        public static List<POS_TRANSACTION> POS_TRANSACTIONS = new List<POS_TRANSACTION>();

        public static List<RESTOCKING_TRANSACTION> RESTROCKING_TRANSACTIONS = new List<RESTOCKING_TRANSACTION>();

        //public static List<EXPIRATION_TRANSACTION> EXPIRATION_TRANSACTIONS = new List<EXPIRATION_TRANSACTION>();

        public static string ID_PADDING(string ID)
        {
            string ID_VALUE_SUBSTRING = ID.Substring(0, 2);
            string ID_NUMBER_SUBSTRING = ID.Substring(2);
            int GET_NUMBER = Convert.ToInt32(ID_NUMBER_SUBSTRING) + 1;
            string FINAL_PADDING = ID_VALUE_SUBSTRING + GET_NUMBER.ToString("00000");
            return FINAL_PADDING;
        }

        public static string GET_MASTER_TRANSACTION_ID()
        {
            //The Transaction_Type can be 'expired' and 'sold'

            PUYODataContext a = new PUYODataContext();

            string Master_Transaction_ID;

            var Get_Last_Master_Transaction = from Master_Transaction in a.Master_Transactions
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
                string New_Master_Transaction_ID = ID_PADDING(Get_Last_Master_Transaction_ID);
                Master_Transaction_ID = New_Master_Transaction_ID;
            }

            DateTime Now_Date = DateTime.Now;

            Master_Transaction New_Master_Transaction = new Master_Transaction();

            New_Master_Transaction.Master_Transaction_ID = Master_Transaction_ID;
            New_Master_Transaction.Master_Transaction_Date = Now_Date;

            a.Master_Transactions.InsertOnSubmit(New_Master_Transaction);
            a.SubmitChanges();

            return Master_Transaction_ID;
        }

        //public static string GET_MASTER_EXPIRY_ID()
        //{
        //    PUYODataContext a = new PUYODataContext();

        //    string Master_Expiry_ID;

        //    var Get_Last_Master_Expiry = from Expiry_Master_Transaction in a.Expiries
        //                                 orderby Expiry_Master_Transaction.Master_Expiry_ID descending
        //                                 select Expiry_Master_Transaction.Master_Expiry_ID;

        //    int Count_Master_Expiry = Get_Last_Master_Expiry.Count();

        //    if (Count_Master_Expiry == 0)
        //    {
        //        Master_Expiry_ID = "ME00001";
        //    }
        //    else
        //    {
        //        var Get_Last_Master_Expiry_ID = Get_Last_Master_Expiry.First().ToString();
        //        string New_Master_Expiry_ID = ID_PADDING(Get_Last_Master_Expiry_ID);
        //        Master_Expiry_ID = New_Master_Expiry_ID;
        //    }

        //    DateTime Now_Date = DateTime.Now;

        //    Master_Expiry New_Master_Expiry = new Master_Expiry();

        //    New_Master_Expiry.Master_Expiry_ID = Master_Expiry_ID;
        //    New_Master_Expiry.Master_Expiry_Date = Now_Date;

        //    a.Master_Expiries.InsertOnSubmit(New_Master_Expiry);
        //    a.SubmitChanges();

        //    PUYOWAREHOUSEDataContext b = new PUYOWAREHOUSEDataContext();

        //    Warehouse_Master_Expiry New_Warehouse_Master_Expiry = new Warehouse_Master_Expiry();

        //    New_Warehouse_Master_Expiry.Master_Expiry_ID = Master_Expiry_ID;
        //    New_Warehouse_Master_Expiry.Master_Expiry_Date = Now_Date;

        //    b.Warehouse_Master_Expiries.InsertOnSubmit(New_Warehouse_Master_Expiry);
        //    b.SubmitChanges();

        //    return Master_Expiry_ID;
        //}

        public static int GET_SUM()
        {
            int sum = 0;

            foreach (POS_TRANSACTION TRANSACTION_ITEM in POS_TRANSACTIONS)
            {
                sum += TRANSACTION_ITEM.TOTAL_PRICE;
            }

            return sum;
        }

        //public static int GET_EXPIRY_SUM()
        //{
        //    int sum = 0;

        //    foreach (EXPIRATION_TRANSACTION EXPIRED_ITEM in EXPIRATION_TRANSACTIONS)
        //    {
        //        sum += EXPIRED_ITEM.TOTAL_COST;
        //    }

        //    return sum;
        //}

        public static void SUBMIT_TRANSACTION(string MASTER_TRANSACTION_ID, string DATA_TYPE)
        {
            string Master_Transaction_ID = MASTER_TRANSACTION_ID;

            PUYODataContext a = new PUYODataContext();

            // Loop through all the rows in the data grid view and prepare to submit the data
            foreach (POS_TRANSACTION TRANSACTION_ITEM in POS_TRANSACTIONS)
            {
                //This is the data of the name of the product
                string Product_Name_Single = TRANSACTION_ITEM.PRODUCT_NAME;

                var Get_Product_ID = from Product_Get in a.Products
                                     where Product_Get.Product_Name.Equals(Product_Name_Single)
                                     select Product_Get.Product_ID;

                string Product_ID_Single = Get_Product_ID.First().ToString();

                //This is the data of the price of the product
                string Price_Single = TRANSACTION_ITEM.PRODUCT_PRICE.ToString();

                //This is the data of the quantity of the product
                string Product_Quantity_Single = TRANSACTION_ITEM.PRODUCT_QUANTITY.ToString();

                //This is the data of the total price of the product
                string Total_Price_Single = TRANSACTION_ITEM.TOTAL_PRICE.ToString();

                string Transaction_ID;

                var Get_Last_Transaction = from Transaction in a.Transactions
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
                    string New_Transaction_ID = ID_PADDING(Get_Last_Transaction_ID);
                    Transaction_ID = New_Transaction_ID;
                }

                //Reduce the stock from the master_product database
                var Get_Product_Stock = from Product_Get in a.Products
                                     where Product_Get.Product_Name.Equals(Product_Name_Single)
                                     select Product_Get.Product_Stock;

                int Get_Product_Stock_INT = int.Parse(Get_Product_Stock.First().ToString());

                Product Update_Product_Stock = a.Products.FirstOrDefault(ProductStock => ProductStock.Product_ID.Equals(Product_ID_Single));
                Update_Product_Stock.Product_Stock = Get_Product_Stock_INT - TRANSACTION_ITEM.PRODUCT_QUANTITY;

                //Submitting to the database
                Transaction New_Transaction = new Transaction();
                New_Transaction.Master_Transaction_ID = Master_Transaction_ID;
                New_Transaction.Product_ID = Product_ID_Single;
                New_Transaction.Quantity = Convert.ToInt32(Product_Quantity_Single);
                New_Transaction.Transaction_ID = Transaction_ID;
                New_Transaction.Total_Price = Convert.ToInt32(Total_Price_Single);
                New_Transaction.Status = DATA_TYPE;

                a.Transactions.InsertOnSubmit(New_Transaction);
                a.SubmitChanges();
            }
            POS_TRANSACTIONS.Clear();
        }

        //public static void SUBMIT_EXPIRY(string MASTER_EXPIRY_TRANSACTION_ID)
        //{
        //    //string Master_Transaction_ID = MASTER_TRANSACTION_ID;

        //    string Master_Expiry_Transaction_ID = MASTER_EXPIRY_TRANSACTION_ID;

        //    PUYODataContext a = new PUYODataContext();

        //    foreach (EXPIRATION_TRANSACTION EXPIRED_ITEM in EXPIRATION_TRANSACTIONS)
        //    {
        //        string Product_Name_Single = EXPIRED_ITEM.PRODUCT_NAME;

        //        var Get_Product_ID = from Product_Get in a.Products
        //                             where Product_Get.Product_Name.Equals(Product_Name_Single)
        //                             select Product_Get.Product_ID;

        //        string Product_ID_Single = Get_Product_ID.First().ToString();

        //        string Price_Single = EXPIRED_ITEM.PRODUCT_PRICE.ToString();

        //        string Product_Quantity_Single = EXPIRED_ITEM.PRODUCT_QUANTITY.ToString();

        //        string Total_Price_Single = EXPIRED_ITEM.TOTAL_COST.ToString();

        //        string Expiry_ID;

        //        var Get_Last_Expiry = from Expiry_Transaction in a.Expiries
        //                              orderby Expiry_Transaction.Expiry_ID descending
        //                              select Expiry_Transaction.Expiry_ID;

        //        int Count_Expiries = Get_Last_Expiry.Count();

        //        if (Count_Expiries == 0)
        //        {
        //            Expiry_ID = "EI00001";
        //        }
        //        else
        //        {
        //            var Get_Last_Expiry_ID = Get_Last_Expiry.First().ToString();
        //            string New_Expiry_ID = ID_PADDING(Get_Last_Expiry_ID);
        //            Expiry_ID = New_Expiry_ID;
        //        }

        //        var Get_Product_Stock = from Product_Get in a.Products
        //                                where Product_Get.Product_Name.Equals(Product_Name_Single)
        //                                select Product_Get.Product_Stock;

        //        int Get_Product_Stock_INT = int.Parse(Get_Product_Stock.First().ToString());

        //        Product Update_Product_Stock = a.Products.FirstOrDefault(Productstock => Productstock.Product_ID.Equals(Product_ID_Single));
        //        Update_Product_Stock.Product_Stock = Get_Product_Stock_INT - EXPIRED_ITEM.PRODUCT_QUANTITY;

        //        //Submit to the cashier first

        //        Expiry New_Expiry = new Expiry();
        //        New_Expiry.Master_Expiry_ID = MASTER_EXPIRY_TRANSACTION_ID;
        //        New_Expiry.Product_ID = Product_ID_Single;
        //        New_Expiry.Quantity = Convert.ToInt32(Product_Quantity_Single);
        //        New_Expiry.Expiry_ID = Expiry_ID;
        //        New_Expiry.Total_Cost = Convert.ToInt32(Total_Price_Single);

        //        a.Expiries.InsertOnSubmit(New_Expiry);
        //        a.SubmitChanges();

        //        //Then submit to the warehouse

        //        PUYOWAREHOUSEDataContext b = new PUYOWAREHOUSEDataContext();

        //        Warehouse_Expiry New_Warehouse_Expiry = new Warehouse_Expiry();
        //        New_Warehouse_Expiry.Master_Expiry_ID = MASTER_EXPIRY_TRANSACTION_ID;
        //        New_Warehouse_Expiry.Product_ID = Product_ID_Single;
        //        New_Warehouse_Expiry.Quantity = Convert.ToInt32(Product_Quantity_Single);
        //        New_Warehouse_Expiry.Expiry_ID = Expiry_ID;
        //        New_Warehouse_Expiry.Total_Cost = Convert.ToInt32(Total_Price_Single);

        //        b.Warehouse_Expiries.InsertOnSubmit(New_Warehouse_Expiry);
        //        b.SubmitChanges();
        //    }
            
        //}

        public static void SUBMIT_RESTOCKING()
        {
            PUYODataContext a = new PUYODataContext();

            // Loop through all the rows in the data grid view and prepare to submit the data
            foreach (RESTOCKING_TRANSACTION RESTOCKING_ITEM in RESTROCKING_TRANSACTIONS)
            {
                string Product_Name_Single = RESTOCKING_ITEM.PRODUCT_NAME;

                var Get_Product_Id = from Product_Get in a.Products
                                     where Product_Get.Product_Name.Equals(Product_Name_Single)
                                     select Product_Get.Product_ID;

                string Product_ID_Single = Get_Product_Id.First().ToString();

                int Added_Stock = RESTOCKING_ITEM.PRODUCT_QUANTITY_ADDED;

                var Get_Product_Stock = from Product_Get in a.Products
                                        where Product_Get.Product_Name.Equals(Product_Name_Single)
                                        select Product_Get.Product_Stock;

                int Get_Product_Stock_INT = int.Parse(Get_Product_Stock.First().ToString());

                Product Update_Product_Stock = a.Products.FirstOrDefault(ProductStock => ProductStock.Product_ID.Equals(Product_ID_Single));

                Update_Product_Stock.Product_Stock = Get_Product_Stock_INT + RESTOCKING_ITEM.PRODUCT_QUANTITY_ADDED;

                a.SubmitChanges();
            }
            RESTROCKING_TRANSACTIONS.Clear();
        }
    }

    public class POS_TRANSACTION
    {

        public string PRODUCT_NAME;
        public int PRODUCT_PRICE;
        public int PRODUCT_QUANTITY;
        public int TOTAL_PRICE;

        public POS_TRANSACTION()
        {

        }

        public POS_TRANSACTION(string PRODUCT_NAME, int PRODUCT_PRICE, int PRODUCT_QUANTITY, int TOTAL_PRICE)
        {
            this.PRODUCT_NAME = PRODUCT_NAME;
            this.PRODUCT_PRICE = PRODUCT_PRICE;
            this.PRODUCT_QUANTITY = PRODUCT_QUANTITY;
            this.TOTAL_PRICE = TOTAL_PRICE;
        }
    }

    //public class EXPIRATION_TRANSACTION
    //{
    //    public string PRODUCT_NAME;
    //    public int PRODUCT_PRICE;
    //    public int PRODUCT_QUANTITY;
    //    public int TOTAL_COST;

    //    public EXPIRATION_TRANSACTION()
    //    {

    //    }

    //    public EXPIRATION_TRANSACTION(string PRODUCT_NAME, int PRODUCT_PRICE, int PRODUCT_QUANTITY, int TOTAL_COST)
    //    {
    //        this.PRODUCT_NAME = PRODUCT_NAME;
    //        this.PRODUCT_PRICE = PRODUCT_PRICE;
    //        this.PRODUCT_QUANTITY = PRODUCT_QUANTITY;
    //        this.TOTAL_COST = TOTAL_COST;
    //    }
    //}

    public class RESTOCKING_TRANSACTION
    {
        public string PRODUCT_NAME;
        public int PRODUCT_QUANTITY_ADDED;

        public RESTOCKING_TRANSACTION()
        {

        }

        public RESTOCKING_TRANSACTION(string PRODUCT_NAME, int PRODUCT_QUANTITY_ADDED)
        {
            this.PRODUCT_NAME = PRODUCT_NAME;
            this.PRODUCT_QUANTITY_ADDED = PRODUCT_QUANTITY_ADDED;
        }
    }
}
