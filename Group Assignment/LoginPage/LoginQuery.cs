using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Group_Assignment.RoleCustomer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Group_Assignment.LoginPage
{
    public class LoginQuery : DatabaseHelper
    {
        //updateUserQuery: Updates the account details in the database
        public static int updateUserQuery(string oldusername, string newusername, string password, string phonenumber, bool showWarning = false)
        {
            string query = @"UPDATE Account SET Name = @newusername, Password = @password, PhoneNumber = @phonenumber 
                WHERE Name = @oldusername";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@newusername", newusername),
                new SqlParameter("@password", password),
                new SqlParameter("@phonenumber", phonenumber),
                new SqlParameter("@oldusername", oldusername)
            };
            int result = ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                if (showWarning)
                    MessageBox.Show("Account details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0; // Return 0 for success
            }
            else
            {
                if (showWarning)
                    MessageBox.Show("Failed to update account details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 for failure
            }
        }

        //loginQuery: Checks if the username and password match an existing account in the database
        public static int verifyLoginQuery(string username, string password, bool showWarning = false)
        {
            // Proceed with the login logic
            string query = "SELECT AccountID FROM Account WHERE Name = @username AND Password = @password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            DataTable result = ExecuteQuery(query, parameters);
            if (result != null && result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["AccountID"]); // Return AccountID on successful login
            }
            else
            {
                if (showWarning)
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 for failure
            }
        }

        public static int addAccountQuery(string username, string password, string gender, string phonenumber, bool showWarning = false)
        {
            // Proceed with the sign-up logic
            string query = @"
                    INSERT INTO Account (Name, Password, Gender, PhoneNumber)
                    VALUES (@username, @password, @gender, @phonenumber);";

            for (int i = 0; i < 30; i++)
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@gender", gender),
                new SqlParameter("@phonenumber", phonenumber)
                };

                if (ExecuteNonQuery(query, parameters) > 0)
                {
                    if (addRoleQuery(getAccountIdFromUsername(username), "R004") == 0) // Assigning default role R004 (Customer) to the new account
                    {
                        if (showWarning)
                            MessageBox.Show("Account created successfully with default role!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return 0; // Return 0 for success
                    }
                    else // If role assignment fails, remove the account
                    {
                        //remove account if role assignment fails
                        removeAccountQuery(getAccountIdFromUsername(username), true);
                    }
                }
            }
            if (showWarning)
                MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1; // Return -1 for failure
        }

        public static void removeSpecificRoleQuery(int accid, string roleid = null)
        {
            // Proceed with the role table and ewallet and topup table removal logic
            // this is called when needing to remove only one role from the account roles table
            SqlParameter[] parameters = null;
            string query = "";
            if (roleid == "R004")
            {
                query = @"DELETE FROM AccountRoles WHERE AccID = @accid and RoleID = @roleid;
                                 DELETE from EWalletTopup where CustomerID = @custid;
                                 DELETE from Ewallet where CustomerID = @custid;
                                 DELETE from customer where CustomerID = @custid;";
                parameters = new SqlParameter[]
                {
                new SqlParameter("@accid", accid),
                new SqlParameter("@custid", "cust" + accid.ToString("D6")),
                new SqlParameter("@roleid", roleid)
                };
            }
            else if (roleid == "R003")
            {
                query = @"DELETE FROM AccountRoles WHERE AccID = @accid and RoleID = @roleid;
                                 DELETE from chef where ChefID = @chefid;";
                parameters = new SqlParameter[]
                {
                new SqlParameter("@accid", accid),
                new SqlParameter("@chefid", "chef" + accid.ToString("D6")),
                new SqlParameter("@roleid", roleid)
                };

            }
            else if (roleid == "R002")
            {
                query = @"DELETE FROM AccountRoles WHERE AccID = @accid and RoleID = @roleid;
                                 DELETE from manager where ManagerID = @managerid;";
                parameters = new SqlParameter[]
                {
                new SqlParameter("@accid", accid),
                new SqlParameter("@managerid", "manager" + accid.ToString("D6")),
                new SqlParameter("@roleid", roleid)
                };

            }
            else if (roleid == "R001")
            {
                query = @"DELETE FROM AccountRoles WHERE AccID = @accid and RoleID = @roleid;
                                 DELETE from admin where adminID = @adminid;";
                parameters = new SqlParameter[]
                {
                new SqlParameter("@accid", accid),
                new SqlParameter("@adminid", "admin" + accid.ToString("D6")),
                new SqlParameter("@roleid", roleid)
                };

            }
            else
            {
                query = @"DELETE from admin where adminID = @adminid;
                          DELETE from manager where ManagerID = @managerid;
                          DELETE from chef where ChefID = @chefid;
                          DELETE from EWalletTopup where CustomerID = @custid;
                          DELETE from Ewallet where CustomerID = @custid;
                          DELETE from customer where CustomerID = @custid;";
                parameters = new SqlParameter[]
                {
                new SqlParameter("@adminid", "admin" + accid.ToString("D6")),
                new SqlParameter("@custid", "cust" + accid.ToString("D6")),
                new SqlParameter("@managerid", "manager" + accid.ToString("D6")),
                new SqlParameter("@chefid", "chef" + accid.ToString("D6")),
                };
            }
            ExecuteNonQuery(query, parameters);
        }

        public static void removeAccountQuery(int accid, bool showWarning = false)
        {
            // Proceed with the account table removal logic
            // this is called for delete account table, and everything in the accountroles table
            removeSpecificRoleQuery(accid);
            removeAllRolesQuery(accid);
            string query = @"DELETE FROM Account WHERE AccountID = @accid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@accid", accid)
            };
            
        }

        public static int addRoleQuery(int accid, string roleid, bool showWarning = false)
        {
            // Proceed with the role assignment logic
            int ifsalary;
            switch (roleid)
            {
                case "R001":
                    ifsalary = 5000;
                    break;
                case "R002":
                    ifsalary = 10000;
                    break;
                case "R003":
                    ifsalary = 1500;
                    break;
                default:
                    ifsalary = 0;
                    break;
            }
            string query = @"INSERT INTO AccountRoles (AccID, RoleID, Salary, LastAccessed)
                    VALUES (@accid, @roleid, @salary, @date);";
            DateTime today = DateTime.Now.Date;
            SqlParameter[] parameters = null;
            parameters = new SqlParameter[]
                {
                new SqlParameter("@accid", accid),
                new SqlParameter("@salary", ifsalary),
                new SqlParameter("@date", today),
                new SqlParameter("@roleid", roleid)
                };
            if (roleid == "R004")
            {
                query = @"INSERT INTO AccountRoles (AccID, RoleID, Salary, LastAccessed)
                    VALUES (@accid, @roleid, @salary, @date);
                    INSERT INTO Customer (CustomerID, AccountID)
                    VALUES (@customerID, @accid);
                    INSERT INTO EWallet (EWalletID, CustomerID, Balance)
                    VALUES (@ewalletid, @customerID, @balance)";
                parameters = new SqlParameter[]
                {
                new SqlParameter("@accid", accid),
                new SqlParameter("@salary", ifsalary),
                new SqlParameter("@date", today),
                new SqlParameter("@roleid", roleid),
                new SqlParameter("@customerID", "cust" + accid.ToString("D6")),
                new SqlParameter("@ewalletid", "ewallet" + accid.ToString("D6")),
                new SqlParameter("@balance", SqlDbType.Decimal)
                {
                    Precision = 10,
                    Scale = 2,
                    Value = 0.00m
                }
                };
            }
            addToRoleTableQuery(accid, roleid);
            


            if (ExecuteNonQuery(query, parameters) > 0)
            {
                if (showWarning)
                    MessageBox.Show("Role assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0; // Return 0 for success
            }
            else
            {
                if (showWarning)
                    MessageBox.Show("Failed to assign role. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 for failure
            }
        }

        public static void addToRoleTableQuery(int accid, string roleid)
        {
            // Proceed with the role assignment logic
            string query = "";
            if (roleid == "R001")
            {
                query = @"INSERT INTO Admin (AdminID, AccountID)
                    VALUES (@adminid, @accid)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@adminid", "admin" + accid.ToString("D6")),
                    new SqlParameter("@accid", accid)
                };
                ExecuteNonQuery(query, parameters);
            }
            if (roleid == "R002")
            {
                query = @"INSERT INTO Manager (ManagerID, AccountID)
                    VALUES (@managerid, @accid)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@managerid", "manager" + accid.ToString("D6")),
                    new SqlParameter("@accid", accid)
                };
                ExecuteNonQuery(query, parameters);
            }
            if (roleid == "R003")
            {
                query = @"INSERT INTO Chef (ChefID, AccountID)
                    VALUES (@chefid, @accid)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@chefid", "chef" + accid.ToString("D6")),
                    new SqlParameter("@accid", accid)
                };
                ExecuteNonQuery(query, parameters);
            }
        }

        public static int removeAllRolesQuery(int accid, bool showWarning = false)
        {
            // Proceed with the role removal logic
            string query = @"DELETE FROM AccountRoles WHERE AccID = @accid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@accid", accid),
            };
            if (ExecuteNonQuery(query, parameters) > 0)
            {
                if (showWarning)
                    MessageBox.Show("All Roles removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0; // Return 0 for success
            }
            else
            {
                if (showWarning)
                    MessageBox.Show("Failed to remove all roles. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 for failure
            }
        }

        public static int getAccountIdFromUsername(string username, bool showWarning = false)
        {
            string query = "SELECT AccountID FROM Account WHERE Name = @username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };
            DataTable result = ExecuteQuery(query, parameters);
            if (result != null && result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["AccountID"]);
            }
            else
            {
                if (showWarning)
                    MessageBox.Show("Account not found. Please check your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return null if account not found
            }
        }

        public static DataTable getAccountDetailsFromAccID(int accid, bool showWarning = false)
        {
            // Proceed with the account details retrieval logic
            string query = @"SELECT A.*, AR.*, R.Name AS RoleName FROM AccountRoles AR
                JOIN Account A ON AR.AccID = A.AccountID 
                JOIN Role R ON AR.RoleID = R.RoleID
                WHERE AccID = @accid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@accid", accid)
            };
            DataTable result = ExecuteQuery(query, parameters);
            if (result != null && result.Rows.Count > 0)
            {
                return result; // Return the account details DataTable
            }
            else
            {
                if (showWarning)
                    MessageBox.Show("Account not found. Please check your account ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Return null if account not found
            }
        }
    }
}
