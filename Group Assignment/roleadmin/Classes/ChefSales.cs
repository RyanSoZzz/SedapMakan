using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Group_Assignment.roleadmin.Classes
{
    public class ChefSales
    {
        //Backing Fields -------------------------------------------------------------------------------
        //Chef Fields
        private string _chefID;
        private string _chefName;
        private string _numOfSales;
        private string _totalSales;
        private string _yearlySales;
        private string _monthlySales;
        private string _salary;

        //Sales Fields
        private string _salesDesc;
        private string _salesDate;
        private string _salesCat;


        //Public Fields
        public string ChefID
        {
            get { return _chefID; }
            set { _chefID = value; }
        }

        public string ChefName
        {
            get { return _chefName; }
            set { _chefName = value; }
        }
        public string NumOfSales
        {
            get { return _numOfSales; }
            set { _numOfSales = value; }
        }
        public string TotalSales
        {
            get { return _totalSales; }
            set { _totalSales= value; }
        }
        public string YearlySales
        {
            get { return _yearlySales; }
            set { _yearlySales = value; }
        }
        public string MonthlySales
        {
            get { return _monthlySales; }
            set { _monthlySales = value; }
        }

        public string Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string SalesDesc
        {
            get { return _salesDesc; }
            set { _salesDesc = value; }
        }

        public string SalesDate
        {
            get { return _salesDate; }
            set { _salesDate = value; }
        }

        public string SalesCat
        {
            get { return _salesCat; }
            set { _salesCat = value; }
        }


        //Constructors ----------------------------------------------------------------------------------
        //Default Constructor
        public ChefSales()
        {
            _chefID = "unknown";
            _chefName = "unknown";
            _numOfSales = "unknown";
            _totalSales = "unknown";
            _yearlySales = "unknown";
            _monthlySales = "unknown";
            _salary = "unknown";
            _salesDesc = "unknown";
            _salesDate = "unknown";
            _salesCat = "unknown";
        }

        //Methods -----------------------------------------------------------------------------------
        //Count total sales
        public static string getTotSales(string ChefID, string time)
        {
            string query = "";
            string res = "";
            DataTable data = new DataTable();
            if (time == "all")
            {
                if (ChefID == null)
                {
                    query = @"SELECT SUM(O.TotalOrderFee) FROM [Order] O;";
                }
                else //Have chefID
                {
                    query = @"SELECT SUM(O.TotalOrderFee) FROM [Order] O
                                WHERE O.ChefID = @ChefID;";
                }
            }
            else if (time == "year")
            {
                if (ChefID == null)
                {
                    query = @"SELECT SUM(O.TotalOrderFee) FROM [Order] O O.Date > DATEADD(YEAR, -1, GETDATE());";
                }
                else //Have chefID
                {
                    query = @"SELECT SUM(O.TotalOrderFee) FROM [Order] O
                                WHERE O.ChefID = @ChefID
                                AND O.Date > DATEADD(YEAR, -1, GETDATE());";
                }

            }
            else if (time == "monthly")
            {
                if (ChefID == null)
                {
                    query = @"SELECT SUM(O.TotalOrderFee) FROM [Order] O Where O.Date > DATEADD(MONTH, -1, GETDATE());";
                }
                else //Have chefID
                {
                    query = @"SELECT SUM(O.TotalOrderFee) FROM [Order] O
                                WHERE O.ChefID = @ChefID
                                AND O.Date > DATEADD(MONTH, -1, GETDATE());";
                }
            }
            else
            {
                erMsg("Invalid Time Filter");
                return null;
            }

            data = DatabaseHelper.ExecuteQuery(query);
            if (data.Rows[0][0] != null || data.Rows[0][0].ToString() == "")
                return "0";
            else
            {
                res = data.Rows[0][0].ToString();
                return res;
            }
        }


        //Count monthly sales
        public static DataTable COTM()
        {
            DataTable data = new DataTable();
            string query = @"SELECT TOP 5 A.Name AS Chef, SUM(O.TotalOrderFee) AS TotalSales FROM [Order] O
                            JOIN Chef C on O.ChefID = C.ChefID
                            JOIN Account A on C.AccountID = A.AccountID
                            GROUP BY O.ChefID, A.Name
                            ORDER BY TotalSales desc;";
            data = DatabaseHelper.ExecuteQuery(query);
            return data;
        }

        //Get list of Sales
        public static DataTable getSales(string paramTime, string paramCat)
        {
            DataTable data = new DataTable();
            DataTable res = new DataTable();
            res.Columns.Add("SalesID", typeof(string));
            res.Columns.Add("ChefID", typeof(string));
            res.Columns.Add("Name", typeof(string));
            res.Columns.Add("TotalSales", typeof(string));
            res.Columns.Add("Date", typeof(string));
            res.Columns.Add("Category(s)", typeof(string));
            res.Columns.Add("Status", typeof(string));


            string tempOID = null;
            string tempChefID = null;
            string tempChefName = null;
            decimal tempTotSales = 0;
            string tempDate = null;
            string tempCat = null;
            string tempStatus = null;
            string query;

            string[] categories = new string[99];
            int numOfCat = 0;

            if (paramCat == "All")
            {
                if (paramTime == "All-Time")
                {
                    query = @"SELECT O.OrderID as SalesID, O.ChefID, A.Name, O.TotalOrderFee as TotalSales,
                    O.Date, M.Category, O.Status FROM [Order] O
                    JOIN OrderItem OI ON O.OrderID = OI.OrderID
                    JOIN Menus M ON OI.MenuID = M.MenuID
                    JOIN Chef C ON O.ChefID = C.ChefID
                    JOIN Account A ON A.AccountID = C.AccountID;";
                }
                else if (paramTime == "Monthly")
                {
                    query = @"SELECT O.OrderID as SalesID, O.ChefID, A.Name, O.TotalOrderFee as TotalSales,
                    O.Date, M.Category, O.Status FROM [Order] O
                    JOIN OrderItem OI ON O.OrderID = OI.OrderID
                    JOIN Menus M ON OI.MenuID = M.MenuID
                    JOIN Chef C ON O.ChefID = C.ChefID
                    JOIN Account A ON A.AccountID = C.AccountID
                    WHERE O.Date > DATEADD(MONTH, -1, GETDATE());";
                }
                else if (paramTime == "Yearly")
                {
                    query = @"SELECT O.OrderID as SalesID, O.ChefID, A.Name, O.TotalOrderFee as TotalSales,
                    O.Date, M.Category, O.Status FROM [Order] O
                    JOIN OrderItem OI ON O.OrderID = OI.OrderID
                    JOIN Menus M ON OI.MenuID = M.MenuID
                    JOIN Chef C ON O.ChefID = C.ChefID
                    JOIN Account A ON A.AccountID = C.AccountID
                    WHERE O.Date > DATEADD(YEAR, -1, GETDATE());";
                }
                else
                {
                    erMsg("Invalid Time Filter");
                    return null;
                }
            }
            else if (paramCat != null)
            {
                if (paramTime == "All-Time")
                {
                    query = $@"SELECT O.OrderID as SalesID, O.ChefID, A.Name, O.TotalOrderFee as TotalSales,
                    O.Date, M.Category, O.Status FROM [Order] O
                    JOIN OrderItem OI ON O.OrderID = OI.OrderID
                    JOIN Menus M ON OI.MenuID = M.MenuID
                    JOIN Chef C ON O.ChefID = C.ChefID
                    JOIN Account A ON A.AccountID = C.AccountID
                    WHERE M.Category LIKE '%{paramCat}%';";
                }
                else if (paramTime == "Monthly")
                {
                    query = $@"SELECT O.OrderID as SalesID, O.ChefID, A.Name, O.TotalOrderFee as TotalSales,
                    O.Date, M.Category, O.Status FROM [Order] O
                    JOIN OrderItem OI ON O.OrderID = OI.OrderID
                    JOIN Menus M ON OI.MenuID = M.MenuID
                    JOIN Chef C ON O.ChefID = C.ChefID
                    JOIN Account A ON A.AccountID = C.AccountID
                    WHERE M.Category LIKE '%{paramCat}%'
                    AND O.Date > DATEADD(MONTH, -1, GETDATE());";
                }
                else if (paramTime == "Yearly")
                {
                    query = $@"SELECT O.OrderID as SalesID, O.ChefID, A.Name, O.TotalOrderFee as TotalSales,
                    O.Date, M.Category, O.Status FROM [Order] O
                    JOIN OrderItem OI ON O.OrderID = OI.OrderID
                    JOIN Menus M ON OI.MenuID = M.MenuID
                    JOIN Chef C ON O.ChefID = C.ChefID
                    JOIN Account A ON A.AccountID = C.AccountID
                    WHERE M.Category LIKE '%{paramCat}%'
                    AND O.Date > DATEADD(YEAR, -1, GETDATE());";
                }
                else
                {
                    erMsg("Invalid Time Filter");
                    return null;
                }
            }
            else
            {
                erMsg("Invalid Time Filter");
                return null;
            }

            data = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                string rowCat = row["Category"].ToString();
                if (tempOID != null)
                {
                    if (row["SalesID"].ToString() == tempOID)
                    {
                        tempTotSales += Convert.ToDecimal(row["TotalSales"].ToString());
                        //if current row = old row: Check if category already exist, update string category
                        bool addCat = true;
                        for (int i = 0; i < numOfCat; i++)
                        {
                            if (rowCat == categories[i])
                            {
                                addCat = false;
                            }
                        }
                        if (addCat)
                        {
                            categories[numOfCat] = rowCat;
                            tempCat += ", " + rowCat;
                            numOfCat++;
                        }
                    }
                    else
                    {
                        //else add old info into res and update all temp values
                        res.Rows.Add(tempOID, tempChefID, tempChefName, tempTotSales.ToString(), tempDate, tempCat, tempStatus);

                        tempOID = row["SalesID"].ToString();
                        tempChefID = row["ChefID"].ToString();
                        tempChefName = row["Name"].ToString();
                        tempTotSales = Convert.ToDecimal(row["TotalSales"].ToString());
                        tempDate = ((DateTime)row["Date"]).ToString("yyyy-MM-dd");
                        tempCat = rowCat;
                        tempStatus = row["Status"].ToString();

                        numOfCat = 1;
                        categories[0] = tempCat;
                    }
                }
                else
                {
                    tempOID = row["SalesID"].ToString();
                    tempChefID = row["ChefID"].ToString();
                    tempChefName = row["Name"].ToString();
                    tempTotSales = Convert.ToDecimal(row["TotalSales"].ToString());
                    tempDate = ((DateTime)row["Date"]).ToString("yyyy-MM-dd");
                    tempCat = rowCat;
                    tempStatus = row["Status"].ToString();
                    categories[numOfCat] = tempCat;
                    numOfCat = 1;
                }
            }
            //Inserting last value due to the nature of the logic
            res.Rows.Add(tempOID, tempChefID, tempChefName, tempTotSales, tempDate, tempCat, tempStatus);
            return res;
        }

        //Get chef based on search string
        public static ChefSales getChef(string search)
        {
            DataTable data = new DataTable();
            string numOfSales, totalSales, yearlySales, monthlySales;
            //Get ChefName
            string query1 = $@"SELECT C.ChefID, A.Name, AR.Salary FROM Chef C
                            JOIN Account A ON C.AccountID = A.AccountID
                            JOIN AccountRoles AR ON A.AccountID = AR.AccID
                            WHERE C.ChefID LIKE '{search}' or C.AccountID LIKE '{search}' or A.Name LIKE '{search}';";
            //Get Number of Sales by chef
            string query2 = $@"SELECT COUNT(*) AS NumOfSales FROM [Order] O 
                            JOIN Chef C ON O.ChefID = C.ChefID
                            join Account A ON C.AccountID = A.AccountID
                            WHERE C.ChefID LIKE '{search}' or C.AccountID LIKE '{search}' or A.Name LIKE '{search}';";
            //Get total sales for all, year, and month
            string query3 = $@"SELECT SUM(O.TotalOrderFee) FROM [Order] O
                            JOIN Chef C ON O.ChefID = C.ChefID
                            JOIN Account A ON A.AccountID = C.AccountID
                            WHERE C.ChefID LIKE '{search}' or C.AccountID LIKE '{search}' or A.Name LIKE '{search}';";

            string query4 = $@"SELECT SUM(O.TotalOrderFee) FROM [Order] O
                            JOIN Chef C ON O.ChefID = C.ChefID
                            JOIN Account A ON A.AccountID = C.AccountID
                            WHERE (C.ChefID LIKE '{search}' or C.AccountID LIKE '{search}' or A.Name LIKE '{search}')
                            AND O.Date > DATEADD(YEAR, -1, GETDATE());";

            string query5 = $@"SELECT SUM(O.TotalOrderFee) FROM [Order] O
                            JOIN Chef C ON O.ChefID = C.ChefID
                            JOIN Account A ON A.AccountID = C.AccountID
                            WHERE (C.ChefID LIKE '{search}' or C.AccountID LIKE '{search}' or A.Name LIKE '{search}')
                            AND O.Date > DATEADD(MONTH, -1, GETDATE());";

            data = DatabaseHelper.ExecuteQuery(query1);
            ChefSales chefInfo = new ChefSales();
            try
            {
                if (data.Rows.Count == 0)
                    throw new Exception("No chef found.");

                chefInfo.ChefID = data.Rows[0][0].ToString();
                chefInfo.ChefName = data.Rows[0][1].ToString();
                chefInfo.Salary = data.Rows[0][2].ToString();

                DataTable salesData = DatabaseHelper.ExecuteQuery(query2);
                var value = salesData.Rows[0][0];
                chefInfo.NumOfSales = (value != DBNull.Value) ? value.ToString() : "0";

                DataTable totalSalesData = DatabaseHelper.ExecuteQuery(query3);
                value = totalSalesData.Rows[0][0];
                chefInfo.TotalSales = (value != DBNull.Value) ? value.ToString() : "0";

                DataTable yearlySalesData = DatabaseHelper.ExecuteQuery(query4);
                value = yearlySalesData.Rows[0][0];
                chefInfo.YearlySales = (value != DBNull.Value) ? value.ToString() : "0";

                DataTable monthlySalesData = DatabaseHelper.ExecuteQuery(query5);
                value = monthlySalesData.Rows[0][0];
                chefInfo.MonthlySales = (value != DBNull.Value) ? value.ToString() : "0";
            }
            catch (Exception ex)
            {
                erMsg("An error occured while retrieving chef data:\n" + ex.Message);
                return null;
            }
            return chefInfo;
        }

        //Call error message
        private static void erMsg (string text)
        {
            System.Windows.Forms.MessageBox.Show($"{text}", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
