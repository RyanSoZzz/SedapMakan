using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group_Assignment.RoleCustomer
{
    public class EWalletTopUp : DatabaseHelper
    {
        private decimal _ewalletBal;

        public decimal EWalletBal
        {
            get { return _ewalletBal; }
            set { _ewalletBal = value; }
        }

        //Get most recent top up
        public static string[] recentTopUp()
        {
            DataTable data = new DataTable();
            string[] res = new string[3];
            string query = @"SELECT TOP 1 A.Name, E.Amount, E.Date FROM EWalletTopup E
                                JOIN Customer C ON E.CustomerID = C.CustomerID
                                JOIN Account A ON C.AccountID = A.AccountID
                                ORDER BY E.Date desc;";
            data = ExecuteQuery(query);

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

        //Get list of top up
        public static DataTable getTopUp(string param, string search)
        {
            DataTable data = new DataTable();
            string query;
            if (param == "All-Time")
                query = @"SELECT T.TopUpID, T.CustomerID, A.Name, T.Amount, T.Date, T.Status
                        FROM EWalletTopup T
                        JOIN Customer C ON T.CustomerID = C.CustomerID
                        JOIN Account A ON C.AccountID = A.AccountID";

            else if (param == "Monthly")
                query = @"SELECT T.TopUpID, T.CustomerID, A.Name, T.Amount, T.Date, T.Status
                        FROM EWalletTopup T
                        JOIN Customer C ON T.CustomerID = C.CustomerID
                        JOIN Account A ON C.AccountID = A.AccountID
                        WHERE (T.Date > DATEADD(MONTH, -1, GETDATE()))";

            else if (param == "Yearly")
                query = @"SELECT T.TopUpID, T.CustomerID, A.Name, T.Amount, T.Date, T.Status
                        FROM EWalletTopup T
                        JOIN Customer C ON T.CustomerID = C.CustomerID
                        JOIN Account A ON C.AccountID = A.AccountID
                        WHERE (T.Date > DATEADD(YEAR, -1, GETDATE()))";

            else
            {
                MessageBox.Show("Invalid Filter");
                return null;
            }

            if (search == null || search == "")
                query += ";";
            else
            {
                query += $@" AND (T.CustomerID LIKE '{search}' or A.Name LIKE '{search}');";
            }

            data = ExecuteQuery(query);
            return data;
        }
    

        public static string getInProgressOrderIDFromAccID(int accid)
        {
            string query = "SELECT * FROM [Order] WHERE CustomerID = @custid and Status = 'In Progress'";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@custid", getCustomerIDFromAccID(accid)),
            };
            DataTable dt = ExecuteQuery(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["OrderID"].ToString();
            }
            else
            {
                // Handle the case where no data is found or an error occurs
                return null; // Indicating an error or no order ID found
            }
        }
        public static string getCustomerIDFromAccID(int AccID)
        {
            string query = "SELECT * FROM Customer WHERE AccountID = @accid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@accid", AccID),
            };
            DataTable dt = ExecuteQuery(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["CustomerID"].ToString();
            }
            else
            {
                // Handle the case where no data is found or an error occurs
                return null; // Indicating an error or no customer ID found
            }
        }

        public static string getEWalletIDfromCustomerID(string CustID)
        {
            string query = "SELECT * FROM EWallet WHERE CustomerID = @custid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@custid", CustID),
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["EWalletID"].ToString();
            }
            else
            {
                // Handle the case where no data is found or an error occurs
                return null; // Indicating an error or no e-wallet ID found
            }
        }

        public static float getBalanceFromCustomerID(string CustID)
        {
            string query = "SELECT * FROM EWallet WHERE CustomerID = @custid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@custid", CustID),
            };

            DataTable dt = ExecuteQuery(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToSingle(dt.Rows[0]["Balance"]);
            }
            else
            {
                // Handle the case where no data is found or an error occurs
                return -1; // Indicating an error or no balance found
            }
        }

        public static int topupEWalletByEWalletID(string customerid, string EWalletID, float amount)
        {
            //Get the sequence for TopUpID
            string query = @"Select top 1 TopUpID from EWalletTopup order by TopUpID desc";
            DataTable dt = ExecuteQuery(query);
            int sequence = 1; // Default sequence
            if (dt != null || dt.Rows.Count != 0)
            {
                if (dt.Rows[0]["TopUpID"].ToString().Substring(2, 8) == DateTime.Now.ToString("yyyyMMdd"))
                {
                    string sequenceStr = dt.Rows[0]["TopUpID"].ToString().Substring(10);
                    if (int.TryParse(sequenceStr, out int seq))
                    {
                        sequence = seq + 1; // Increment the sequence
                    }
                }
            }

            //Inserting a new TopUpID with sequence number
            float lastBalance = getBalanceFromCustomerID(customerid);
            string status = "In Progress"; // Default status before balance update
            string topupID = "tu" + DateTime.Now.ToString("yyyyMMdd") + sequence.ToString("D3");

            //Update the balance in EWallet
            if (updateBalanceByEWAlletID(EWalletID, lastBalance + amount) == 0)
                status = "Completed"; // Update status to Success if balance update is successful
            else
                status = "Failed";

            //Insert the log
            query = @"INSERT INTO EWalletTopUp(TopUpID, EWalletID, CustomerID, Amount, Date, Status)
                            VALUES (@topupid, @ewalletid, @customerid, @amount, @date, @status)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@topupid", topupID),
                new SqlParameter("@ewalletid", EWalletID),
                new SqlParameter("@customerid", customerid),
                new SqlParameter("@amount", lastBalance - amount),
                new SqlParameter("@date", DateTime.Now),
                new SqlParameter("@status", status)
            };

            //Define whether the query was successful
            if (ExecuteNonQuery(query, parameters) > 0)
                return 0; // Success
            else
            {
                updateBalanceByEWAlletID(EWalletID, lastBalance - amount); // Revert balance update if it fails
                return -1; // Error
            }
        }

        public static int updateBalanceByEWAlletID(string EWalletID, float newBalance)
        {
            string query = "UPDATE EWallet SET Balance = @newbalance WHERE EWalletID = @ewalletid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@newbalance", newBalance),
                new SqlParameter("@ewalletid", EWalletID),
            };
            
            if (ExecuteNonQuery(query, parameters) > 0)
            {
                return 0; // Success
            }
            else
            {
                return -1; // Error
            }
        }
        public static string getCustomerNameFromCustomerID(string CustID)
        {
            string query = "SELECT AccountID FROM Customer WHERE CustomerID = @custid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@custid", CustID),
            };
            DataTable dt = ExecuteQuery(query, parameters);
            if (dt == null || dt.Rows.Count == 0)
            {
                // Handle the case where no data is found or an error occurs
                return null; // Indicating an error or no customer details found
            }
            string query2 = "SELECT Name FROM Account WHERE AccountID = @accid";
            SqlParameter[] parameters2 = new SqlParameter[]
            {
                new SqlParameter("@accid", dt.Rows[0]["AccountID"]),
            };
            DataTable dt2 = ExecuteQuery(query2, parameters2);
            if (dt2 != null && dt2.Rows.Count > 0)
            {
                return dt2.Rows[0]["Name"].ToString(); // Return the customer's name
            }
            else
            {
                // Handle the case where no data is found or an error occurs
                return null; // Indicating an error or no customer details found
            }
        }
    }
}
