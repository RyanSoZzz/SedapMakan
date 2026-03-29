using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.LoginPage;

namespace Group_Assignment.roleadmin.Classes
{
    public class Users
    {
        //Fields ---------------------------------------------------------------------------------------
        //Backing Fields
        private string _accountID;
        private string _username;
        private string _password;
        private string _gender;
        private string _phoneNum;
        private string[] _roles;
        private string _lastAccessed;

        //Public Fields
        public string AccountID
        {
            get { return _accountID; }
            set { _accountID = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string PhoneNum
        {
            get { return _phoneNum; }
            set { _phoneNum = value; }
        }

        public string[] Roles
        {
            get { return _roles; }
            set { _roles = value; }
        }

        public string LastAccessed
        {
            get { return _lastAccessed; }
            set { _lastAccessed = value; }
        }


        //Constructors ---------------------------------------------------------------------------------
        //Default Constructor
        public Users()
        {
            _accountID = "unknown";
            _username = "unknown";
            _password = "unknown";
            _gender = "unknown";
            _phoneNum = "unknown";
            _roles = null;
            _lastAccessed = "unknown";
        }

        //Methods --------------------------------------------------------------------------------------
        //Get Number of users within time range, role
        public static string getTotalUser(string role, string time)
        {
            DataTable data;
            string query = "";
            //!= null --> To get total based on role; == null --> To get total based on time
            if (time == "all")
            {
                if (role == "all")
                {
                    query = @"SELECT COUNT(*) FROM Account;";
                }
                else if (role == "admin")
                {
                    query = @"SELECT COUNT(*) FROM AccountRoles AR
                    JOIN Account A ON AR.AccID = A.AccountID 
                    JOIN Role R ON AR.RoleID = R.RoleID
				    WHERE R.RoleID = 'R001';";
                }
                else if (role == "manager")
                {
                    query = @"SELECT COUNT(*) FROM AccountRoles AR
                    JOIN Account A ON AR.AccID = A.AccountID 
                    JOIN Role R ON AR.RoleID = R.RoleID
				    WHERE R.RoleID = 'R002';";
                }
                else if (role == "chef")
                {
                    query = @"SELECT COUNT(*) FROM AccountRoles AR
                    JOIN Account A ON AR.AccID = A.AccountID 
                    JOIN Role R ON AR.RoleID = R.RoleID
				    WHERE R.RoleID = 'R003';";
                }
                else if (role == "customer")
                {
                    query = @"SELECT COUNT(*) FROM AccountRoles AR
                    JOIN Account A ON AR.AccID = A.AccountID 
                    JOIN Role R ON AR.RoleID = R.RoleID
				    WHERE R.RoleID = 'R004';";
                }
            }
            else
            {
                query = @"SELECT COUNT(*) AS WeeklyUser FROM Account A
                        JOIN AccountRoles AR on A.AccountID = AR.AccID
                        WHERE AR.LastAccessed > DATEADD(WEEK, -1, GETDATE());";
            }
            data = DatabaseHelper.ExecuteQuery(query);
            if (data.Rows.Count == 0)
                return "null";
            else
            {
                string res = data.Rows[0][0].ToString();
                return res;
            }
        }

        //Get list of users based on Role
        public static DataTable getUsers(string para)
        {
            DataTable data = new DataTable();
            DataTable res = new DataTable();
            res.Columns.Add("AccountID", typeof(string));
            res.Columns.Add("Name", typeof(string));
            res.Columns.Add("Password", typeof(string));
            res.Columns.Add("Gender", typeof(string));
            res.Columns.Add("PhoneNum", typeof(string));
            res.Columns.Add("Roles", typeof(string));
            res.Columns.Add("LastAccessed", typeof(string));

            string[] accRoles = new string[5];
            int numOfRoles = 0;
            string tempID = null;
            string tempName = null;
            string tempPassword = null;
            string tempGender = null;
            string tempPhone = null;
            string tempRoles = null;
            string tempLast = null;
            string query = "";

            if (para == "All")
            {
                query = @"SELECT A.*, AR.RoleID as Role, AR.LastAccessed FROM Account A
                            JOIN AccountRoles AR ON A.AccountID = AR.AccID order by AR.AccID;";
            }
            else if (para == "Admin")
            {
                query = @"SELECT A.*, AR.RoleID as Role, AR.LastAccessed FROM Account A
                            JOIN AccountRoles AR ON A.AccountID = AR.AccID
                            WHERE AR.RoleID = 'R001' order by AR.AccID;";
            }
            else if (para == "Manager")
            {
                query = @"SELECT A.*, AR.RoleID as Role, AR.LastAccessed FROM Account A
                            JOIN AccountRoles AR ON A.AccountID = AR.AccID
                            WHERE AR.RoleID = 'R002' order by AR.AccID;";
            }
            else if (para == "Chef")
            {
                query = @"SELECT A.*, AR.RoleID as Role, AR.LastAccessed FROM Account A
                            JOIN AccountRoles AR ON A.AccountID = AR.AccID
                            WHERE AR.RoleID = 'R003' order by AR.AccID;";
            }
            else if (para == "Customer")
            {
                query = @"SELECT A.*, AR.RoleID as Role, AR.LastAccessed FROM Account A
                            JOIN AccountRoles AR ON A.AccountID = AR.AccID
                            WHERE AR.RoleID = 'R004' order by AR.AccID;";
            }
            else
            {
                //Do search
                query = $@"SELECT A.*, AR.RoleID as Role, AR.LastAccessed FROM Account A
                            JOIN AccountRoles AR ON A.AccountID = AR.AccID
                            WHERE A.AccountID LIKE '{para}' or A.Name LIKE '{para}' order by AR.AccID;";
            }

            data = DatabaseHelper.ExecuteQuery(query);
            //Checking for multiple roles & Changing ID into 'Role1, Role2, ....'
            if (data.Rows.Count <= 0)
            {
                return data;
            } 
            foreach (DataRow row in data.Rows)
            {
                if (tempID != null)
                {
                    if (row["AccountID"].ToString() == tempID)
                    {
                        if (row["Role"].ToString() == "R001")
                        {
                            tempRoles += ", Admin";
                        }
                        else if (row["Role"].ToString() == "R002")
                        {
                            tempRoles += ", Manager";
                        }
                        else if (row["Role"].ToString() == "R003")
                        {
                            tempRoles += ", Chef";
                        }
                        else if (row["Role"].ToString() == "R004")
                        {
                            tempRoles += ", Customer";
                        }
                    }
                    else
                    {
                        res.Rows.Add(tempID, tempName, tempPassword, tempGender, tempPhone, tempRoles, tempLast);

                        tempID = row["AccountID"].ToString();
                        tempName = row["Name"].ToString();
                        tempPassword = row["Password"].ToString();
                        tempGender = row["Gender"].ToString();
                        tempPhone = row["PhoneNumber"].ToString();
                        if (row["Role"].ToString() == "R001")
                        {
                            tempRoles = "Admin";
                        }
                        else if (row["Role"].ToString() == "R002")
                        {
                            tempRoles = "Manager";
                        }
                        else if (row["Role"].ToString() == "R003")
                        {
                            tempRoles = "Chef";
                        }
                        else if (row["Role"].ToString() == "R004")
                        {
                            tempRoles = "Customer";
                        }
                        try
                        {
                            tempLast = ((DateTime)row["LastAccessed"]).ToString("yyyy-MM-dd");
                        }
                        catch
                        {
                            tempLast = "unknown";
                        }
                    }
                }
                else
                {
                    tempID = row["AccountID"].ToString();
                    if (row["AccountID"].ToString() == tempID)
                    {
                        if (row["Role"].ToString() == "R001")
                        {
                            tempRoles = "Admin";
                        }
                        else if (row["Role"].ToString() == "R002")
                        {
                            tempRoles = "Manager";
                        }
                        else if (row["Role"].ToString() == "R003")
                        {
                            tempRoles = "Chef";
                        }
                        else if (row["Role"].ToString() == "R004")
                        {
                            tempRoles = "Customer";
                        }
                    }
                    tempName = row["Name"].ToString();
                    tempPassword = row["Password"].ToString();
                    tempGender = row["Gender"].ToString();
                    tempPhone = row["PhoneNumber"].ToString();
                    tempLast = ((DateTime)row["LastAccessed"]).ToString("yyyy-MM-dd");
                }
            }   
            //Adding last row
            res.Rows.Add(tempID, tempName, tempPassword, tempGender, tempPhone, tempRoles, tempLast);
            return res;
        }

        public static string[] userRoles (string id)
        {
            string[] res = new string[5];
            string query = $@"SELECT * FROM AccountRoles WHERE AccID = '{id}' order by AccID;";
            int numOfRoles = 0;
            try
            {
                DataTable data = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    res[numOfRoles] = row["RoleID"].ToString();
                    numOfRoles++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Account does not have roles");
                return null;
            }
            return res;
        }

        public static void deleteUser(int id)
        {
            try
            {
                LoginQuery.removeAccountQuery(id, false);
            }
            finally
            {
                MessageBox.Show("Account has been succesfully deleted");
            }

        }

        public static void updateInfo(string username, string password, string gender, string phoneNum, string id)
        {
            string query = $@"UPDATE Account SET Name = '{username}',
                                                Password = '{password}',
                                                Gender = '{gender}',
                                                PhoneNumber = '{phoneNum}'
                                                WHERE AccountID = '{id}';";
            try
            {
                DatabaseHelper.ExecuteQuery(query);
            }
            finally
            {
                MessageBox.Show("Account details has been updated");
            }
        }

        public static decimal getSalary(string id, string roleID)
        {
            decimal res = 0;
            string query = $@"SELECT AR.Salary FROM AccountRoles AR WHERE AR.AccID = '{id}' AND RoleID = '{roleID}';";
            object result = DatabaseHelper.ExecuteQuery(query).Rows[0][0];
            res = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            return res;
        }
        public static void updateSalary(string id, string roleID, decimal newBal)
        {
            string query = $@"UPDATE AccountRoles SET Salary = {newBal} WHERE AccID = '{id}' AND RoleID = '{roleID}';";
            DatabaseHelper.ExecuteQuery(query);
        }
        public static decimal getEWallet(string id)
        {
            decimal res = 0;
            string query = $@"SELECT E.Balance FROM EWallet E WHERE CustomerID = 
                            (SELECT CustomerID FROM Customer C WHERE C.AccountID = '{id}');"; 
            object result = DatabaseHelper.ExecuteQuery(query).Rows[0][0];
            res = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            return res;
        }
        public static void updateEWallet(string id, decimal newBal)
        {
            string query = $@"UPDATE EWallet SET Balance = {newBal} WHERE CustomerID = 
                            (SELECT CustomerID FROM Customer C WHERE C.AccountID = '{id}');";
            DatabaseHelper.ExecuteQuery(query);
        }
    }
}
