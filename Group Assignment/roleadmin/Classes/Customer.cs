using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Group_Assignment.roleadmin.Classes
{
    public class Customer
    {
        //Fields -------------------------------------------------------------------------------------
        //Backing Fields
        private string _custID;
        private string _custName;
        private string _EWalletBal;
        private string _EWalletID;
        private string _NumOfOrder;
        private string _NumOfFeedback;

        //Public Fields
        public string CustID
        {
            get { return _custID; }
            set { _custID = value; }
        }
        
        public string CustName
        {
            get { return _custName; }
            set { _custName = value; }
        }

        public string EWalletBal
        {
            get { return _EWalletBal; }
            set { _EWalletBal = value; }
        }

        public string EwalletID
        {
            get { return _EWalletID; }
            set { _EWalletID = value; }
        }

        public string NumOfOrder
        {
            get { return _NumOfOrder; }
            set { _NumOfOrder = value; }
        }

        public string NumOfFeedback
        {
            get { return _NumOfFeedback; }
            set { _NumOfFeedback = value; }
        }

        //Constructors ------------------------------------------------------------------------------------
        //Default Constructor
        public Customer ()
        {
            _custID = "unknown";
            _custName = "unknown";
            _EWalletBal = "unknown";
            _EWalletID= "unknown";
            _NumOfOrder= "unknown";
            _NumOfFeedback= "unknown";
        }
        
        //Menthods ----------------------------------------------------------------------------------------
        //Get the Person with the most order & the most spent
        public static string[] topCustomer (string param)
        {
            DataTable data = new DataTable ();
            string query = "";
            string[] res = new string[2];
            if (param == "amount")
            {
                query = @"SELECT A.Name, tempTable.TotalSpent
                                    FROM Account A
                                    JOIN Customer C ON A.AccountID = C.AccountID
                                    JOIN (
                                    SELECT TOP 1 O.CustomerID, SUM(O.TotalOrderFee) AS TotalSpent
                                    FROM [Order] O
                                    GROUP BY O.CustomerID
                                    ORDER BY TotalSpent DESC) AS tempTable ON C.CustomerID = tempTable.CustomerID;";
            }
            else if (param == "order")
            {
                query = @"SELECT TOP 1 A.Name, COUNT(O.OrderID) AS OrderCount
                            FROM [Order] O
                            JOIN Customer C ON O.CustomerID = C.CustomerID
                            JOIN Account A ON C.AccountID = A.AccountID
                            GROUP BY A.Name;";
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect Parameter");
                return null;
            }
            data = DatabaseHelper.ExecuteQuery(query);
            if (data.Rows.Count == 0)
                return Enumerable.Repeat("null", res.Length).ToArray();
            else
            {
                res[0] = data.Rows[0][0].ToString();
                res[1] = data.Rows[0][1].ToString();
                return res;
            }
        }

        //Get the customer based on search
        public static Customer getCust(string search)
        {
            DataTable data = new DataTable();
            string numOfSales, totalSales, yearlySales, monthlySales;
            //Get ChefName
            string query = $@"SELECT C.CustomerID, A.Name, EW.Balance, EW.EWalletID, 
                                COUNT(O.OrderID) AS OrderCount, COUNT(F.FeedbackID) AS FeedbackCount
                                FROM Customer C
                                JOIN EWallet EW ON C.CustomerID = EW.CustomerID
                                JOIN Feedback F ON C.CustomerID = F.CustomerID
                                JOIN [Order] O ON C.CustomerID = O.CustomerID
                                JOIN Account A ON C.AccountID = A.AccountID
                                WHERE C.CustomerID LIKE '{search}' or C.AccountID LIKE '{search}' or A.Name LIKE '{search}'
                                GROUP BY C.CustomerID, A.Name, EW.Balance, EW.EWalletID;";
            data = DatabaseHelper.ExecuteQuery(query);
            Customer custInfo = new Customer();
            try
            {
                if (data.Rows.Count == 0)
                    throw new Exception("No Customer found.");

                custInfo.CustID = data.Rows[0][0].ToString();
                custInfo.CustName = data.Rows[0][1].ToString();
                custInfo.EWalletBal = data.Rows[0][2].ToString();
                custInfo.EwalletID = data.Rows[0][3].ToString();
                custInfo.NumOfOrder = data.Rows[0][4].ToString();
                custInfo.NumOfFeedback = data.Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occured while retrieving customer data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return custInfo;
        }
    }
}
