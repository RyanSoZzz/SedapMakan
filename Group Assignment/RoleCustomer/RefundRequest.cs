using Group_Assignment.RoleCustomer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // Ensure you have the correct using directive for SQL operations
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group_Assignment
{
    public class RefundRequest
    {
        public string RefundID { get; set; }
        public string ManagerID { get; set; }
        public string CustomerID { get; set; }
        public string OrderID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string RefundReason { get; set; } // Reason for the refund request
        public Order theOrder { get; private set; }
        public bool isValid { get; private set; } = false;

        //For making new one, you have to insert reason
        //For get the RefundRequest by order obj, just call by obj and null reason
        public RefundRequest(Order TheOrder, string refundReason)
        {
            try
            {
                theOrder = TheOrder;
                if (refundReason == null)
                {
                    loadTheRefundRequest();
                    return;
                }
                RefundReason = refundReason;
                createNewRefundRequest();
            } catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex, "Refund Request Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private int loadTheRefundRequest()
        {
            if (theOrder != null && theOrder.OrderID != null)
            {
                //Check if the refund have been made before or not
                string query = @"SELECT * FROM RefundRequest WHERE OrderID = @orderid AND Status IN ('Pending', 'Accepted')";
                SqlParameter[] sp = new SqlParameter[]
                {
                            new SqlParameter("@orderid", theOrder.OrderID),
                };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, sp);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    //Load the existing request
                    if (dt != null && dt.Rows.Count > 0) // Check if the DataTable has rows

                    {
                        row = dt.Rows[0];

                        RefundID = row["RefundID"].ToString();
                        ManagerID = row["ManagerID"] != DBNull.Value ? row["ManagerID"].ToString() : null;
                        CustomerID = row["CustomerID"].ToString();
                        OrderID = row["OrderID"].ToString();
                        Amount = row["Amount"] != DBNull.Value ? Convert.ToInt32(row["Amount"]) : 0;
                        Date = Convert.ToDateTime(row["Date"]);
                        Status = row["Status"].ToString();
                        RefundReason = row["Reason"].ToString();

                        isValid = true;
                        return 0;
                    }
                }
            }
            return -1;
        }

        private int createNewRefundRequest()
        {
            if (theOrder != null && theOrder.OrderID != null)
            {
                if (loadTheRefundRequest() == 0)
                {
                    return 0;
                }


                //Making new refund request
                string query = @"SELECT TOP 1 RefundID FROM RefundRequest ORDER BY RefundID DESC;";
                int lastRefundIDCount = 0;
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                if (dt != null && dt.Rows.Count > 0) {

                    string lastRefundID = dt.Rows[0]["RefundID"].ToString();
                    lastRefundIDCount = Convert.ToInt32(lastRefundID.Substring(lastRefundID.Length - 6));
                }

                query = @"INSERT INTO RefundRequest(RefundID, ManagerID, CustomerID, OrderID, Amount, Date, Status, Reason)
                VALUES (@refundid, @managerid, @customerid, @orderid, @amount, @date, @status, @refundreason);";
                SqlParameter[] sp = new SqlParameter[]
                {
                new SqlParameter("@refundid", "refund" + (lastRefundIDCount + 1).ToString("D6")),
                new SqlParameter("@managerid", DBNull.Value),
                new SqlParameter("@customerid", theOrder.CustomerID),
                new SqlParameter("@orderid", theOrder.OrderID),
                new SqlParameter("@amount", theOrder.TotalOrderFee),
                new SqlParameter("@date", DateTime.Now),
                new SqlParameter("@status", "Pending"),
                new SqlParameter("@refundreason", RefundReason),
                };

                int executeResult = DatabaseHelper.ExecuteNonQuery(query, sp);

                //Get New Values
                query = @"SELECT * FROM RefundRequest WHERE RefundID = @refundID";
                dt = DatabaseHelper.ExecuteQuery(query, new SqlParameter("@refundID", "refund" + (lastRefundIDCount + 1).ToString("D6")));

                //Insert New Values
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    RefundID = row["RefundID"].ToString();
                    ManagerID = row["ManagerID"] != DBNull.Value ? row["ManagerID"].ToString() : null;
                    CustomerID = row["ManagerID"].ToString();
                    OrderID = row["ManagerID"].ToString();
                    Amount = row["Amount"] != DBNull.Value ? Convert.ToInt32(row["Amount"]) : 0;
                    Date = Convert.ToDateTime(row["Date"]);
                    Status = row["Status"].ToString();
                    RefundReason = row["Reason"].ToString();

                    isValid = true;
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public RefundRequest(string refundID)
        {
            string query = "SELECT * FROM RefundRequest WHERE RefundID = @RefundID";
            DataTable dtrefdetail = DatabaseHelper.ExecuteQuery(query, new System.Data.SqlClient.SqlParameter("@RefundID", refundID)); // Execute the query with the provided refund ID
            if (dtrefdetail == null || dtrefdetail.Rows.Count == 0) // Check if the DataTable is null
            {
                throw new Exception("Refund request not found."); // Throw an exception if the refund request is not found
            }
            if (dtrefdetail != null && dtrefdetail.Rows.Count > 0) // Check if the DataTable has rows

            {
                DataRow row = dtrefdetail.Rows[0];


                RefundID = row["RefundID"].ToString();
                ManagerID = row["ManagerID"] != DBNull.Value ? row["ManagerID"].ToString() : null;
                CustomerID = row["CustomerID"].ToString();
                OrderID = row["OrderID"].ToString();
                Amount = row["Amount"] != DBNull.Value ? Convert.ToInt32(row["Amount"]) : 0;
                Date = Convert.ToDateTime(row["Date"]);
                Status = row["Status"].ToString();
                RefundReason = row["Reason"].ToString();

            }

        }
        public static List<string> GetPendingRefundID() // Method to retrieve all pending refund IDs
        {
            string query = "SELECT RefundID FROM RefundRequest WHERE Status = 'Pending'";
            DataTable dtrefID = DatabaseHelper.ExecuteQuery(query);
            return dtrefID.AsEnumerable().Select(row => row.Field<string>("RefundID")).ToList(); // LINQ to convert DataTable to List<string>
        }

        public static string ConfirmRefund(string refundID, string managerID)
        {
            try
            {
                string query = "UPDATE RefundRequest SET Status = 'Accepted', ManagerID = @ManagerID WHERE RefundID = @RefundID";// Update the status of the refund request to 'Accepted'
                string refunddetailsQuery = "SELECT * FROM RefundRequest WHERE RefundID = @RefundID"; // Query to get refund details
                DataTable refundDetails = DatabaseHelper.ExecuteQuery(refunddetailsQuery, new SqlParameter("@RefundID", refundID)); // Execute the query to get refund details
                string customerID = refundDetails.Rows[0]["CustomerID"].ToString(); // Get the CustomerID from the refund details
                decimal amount = refundDetails.Rows[0]["Amount"] != DBNull.Value ? Convert.ToDecimal(refundDetails.Rows[0]["Amount"]) : 0m;
                // Get the Amount from the refund details
                // Update the customer's balance or perform any other necessary actions here
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter("@RefundID", refundID), new SqlParameter("@ManagerID", managerID));

                if (rowsAffected <= 0)
                {
                    return "Failed to confirm refund. Please check the refund ID.";
                }

                string updateCustomerBalanceQuery = "UPDATE EWallet SET Balance = Balance + @Amount WHERE CustomerID = @CustomerID"; // Query to update customer's balance
                int CustomerBalance = DatabaseHelper.ExecuteNonQuery(updateCustomerBalanceQuery, new SqlParameter("@Amount", amount), new SqlParameter("@CustomerID", customerID)); // Execute the query to update customer's balance
                if (CustomerBalance <= 0)
                    return "Refund confirmed, but failed to update e-wallet.";
                else
                    return "Refund confirmed and e-wallet updated successfully.";
            }
            catch (Exception ex)
            {
                return "An error occurred while confirming the refund: " + ex.Message; // Return an error message if an exception occurs
            }

        }

        public static string DenyRefund(string refundID, string managerID)
        {
            try
            {
                string query = "UPDATE RefundRequest SET Status = 'Rejected', ManagerID = @ManagerID WHERE RefundID = @RefundID"; // Update the status of the refund request to 'Denied'
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter("@RefundID", refundID), new SqlParameter("@ManagerID", managerID));
                if (rowsAffected > 0)
                {
                    return "Refund denied successfully.";
                }
                else
                {
                    return "Failed to deny refund. Please check the refund ID.";
                }
            }
            catch (Exception ex)
            {
                return "An error occurred while denying the refund: " + ex.Message; // Return an error message if an exception occurs
            }
        }
    }
}
