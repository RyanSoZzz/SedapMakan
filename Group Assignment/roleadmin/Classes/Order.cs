using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group_Assignment.roleadmin.Classes
{
    public class Order
    {
        //Fields ------------------------------------------------------------------------------


        //Constructors ------------------------------------------------------------------------


        //Methods -----------------------------------------------------------------------------
        //Get most recent order
        public static string[] recentOrder()
        {
            DataTable data = new DataTable();
            string[] res = new string[3];
            string query = @"SELECT TOP 1 A.Name, O.TotalOrderFee, O.Date FROM [Order] O
                                JOIN Customer C ON O.CustomerID = C.CustomerID
                                JOIN Account A ON C.AccountID = A.AccountID
                                ORDER BY O.Date desc;";
            data = DatabaseHelper.ExecuteQuery(query);
            if (data.Rows.Count == 0)
                return Enumerable.Repeat("null", res.Length).ToArray();
            else
            {
                res[0] = data.Rows[0][0].ToString();
                res[1] = data.Rows[0][1].ToString();
                res[2] = data.Rows[0][2].ToString();
                return res;
            }
        }
        
        //Get list of all orders
        public static DataTable getOrders(string param, string search)
        {
            DataTable data = new DataTable();
            string query;
            if (param == "All-Time")
                query = @"SELECT O.OrderID, O.CustomerID, A.Name, O.TotalOrderFee as TotalFee, O.Date, O.Status
                        FROM [Order] O
                        JOIN Customer C on O.CustomerID = C.CustomerID
                        JOIN Account A on C.AccountID = A.AccountID";

            else if (param == "Monthly")
                query = @"SELECT O.OrderID, O.CustomerID, A.Name, O.TotalOrderFee as TotalFee, O.Date, O.Status
                        FROM [Order] O
                        JOIN Customer C on O.CustomerID = C.CustomerID
                        JOIN Account A on C.AccountID = A.AccountID
                        WHERE (O.Date > DATEADD(MONTH, -1, GETDATE()))";

            else if (param == "Yearly")
                query = @"SELECT O.OrderID, O.CustomerID, A.Name, O.TotalOrderFee as TotalFee, O.Date, O.Status
                        FROM [Order] O
                        JOIN Customer C on O.CustomerID = C.CustomerID
                        JOIN Account A on C.AccountID = A.AccountID
                        WHERE (O.Date > DATEADD(YEAR, -1, GETDATE()))";
            else
            {
                MessageBox.Show("Invalid Filter");
                return null;
            }
            if (search == null || search == "")
                query += ";";
            else
            {
                query += $@" AND (O.CustomerID LIKE '{search}' OR A.Name LIKE '{search}');";
            }
            data = DatabaseHelper.ExecuteQuery(query);
            return data;
        }
    }
}
