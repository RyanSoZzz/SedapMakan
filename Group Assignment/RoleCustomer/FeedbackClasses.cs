using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group_Assignment.RoleCustomer
{
    public class FeedbackObj : DatabaseHelper // Assuming DatabaseHelper is a class that handles database operations
    {
        public bool isValid { get; private set; } = false;
        public string FeedbackID { get; set; }
        public string ManagerID { get; set; }
        public string CustomerID { get; set; }
        public string OrderID { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }
        public string Customer_Feedback { get; set; }
        public string Manager_Response { get; set; }

        public static string getCustomerIDfromOrderID(string orderId)
        {
            string query = "SELECT * FROM [Order] WHERE OrderID = @OrderID";
            DataTable dt = ExecuteQuery(query, new System.Data.SqlClient.SqlParameter("@OrderID", orderId));
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["CustomerID"].ToString(); // Return the DataTable containing the CustomerID
            }
            else
            {
                return null; // No data found for the given OrderID
            }
        }
        public static DataTable getFeedbackDetailsByOrderID(string orderId)
        {
            string query = @"SELECT * FROM Feedback WHERE OrderID = @OrderID";
            DataTable dt = ExecuteQuery(query,
                new System.Data.SqlClient.SqlParameter("@OrderID", orderId));
            if (dt != null)
            {
                return dt; // Return the DataTable containing feedback details
            }
            else
            {
                return null;
            }
        }
        private int createNewFeedback(string orderId, string feedback, int rating)
        {
            //get last feedbackid from the database
            string query = "SELECT TOP 1 FeedbackID FROM [Feedback] ORDER BY FeedbackID DESC";
            int lastFeedbackCount = 0;
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                lastFeedbackCount = Convert.ToInt32(dt.Rows[0]["FeedbackID"].ToString().Substring(2, 6));
            }

            //Create a new feedback row
            query = @"INSERT INTO Feedback (FeedbackID, ManagerID, CustomerID, OrderID, Date, Rating, Customer_Feedback, Response) 
                             VALUES (@feedbackid, @managerid, @customerid, @orderid, @date, @rating, @customer_fb, @response);";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@feedbackid", "fb" + (lastFeedbackCount+1).ToString("D6")),
                new SqlParameter("@managerid", DBNull.Value), // Initially no manager assigned
                new SqlParameter("@customerid", getCustomerIDfromOrderID(orderId)),
                new SqlParameter("@orderid", orderId),
                new SqlParameter("@date", DateTime.Now),
                new SqlParameter("@rating", rating),
                new SqlParameter("@customer_fb", feedback),
                new SqlParameter("@response", DBNull.Value)
            };
            if (ExecuteNonQuery(query, parameters) > 0)
            {
                return 0; // Feedback created successfully
            }
            else
            {
                return -1; // Failed to create feedback
            }
        }

        public FeedbackObj(string orderId, string feedback, int rating)
        {
            try
            {
                //Check if there is any feedback submitted
                string query = @"SELECT * FROM Feedback WHERE OrderID = @orderid";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@orderid", orderId)
                };
                DataTable dt = ExecuteQuery(query, parameters);
                if (dt != null && dt.Rows.Count > 0)
                {
                    //Assign values to the properties of FeedbackObj based on the orderId
                    FeedbackID = dt.Rows[0]["FeedbackID"].ToString();
                    ManagerID = dt.Rows[0]["ManagerID"] != DBNull.Value ? dt.Rows[0]["ManagerID"].ToString() : null;
                    CustomerID = dt.Rows[0]["CustomerID"].ToString();
                    OrderID = dt.Rows[0]["OrderID"].ToString();
                    Date = Convert.ToDateTime(dt.Rows[0]["Date"]);
                    Rating = Convert.ToInt32(dt.Rows[0]["Rating"]);
                    Customer_Feedback = dt.Rows[0]["Customer_Feedback"].ToString();
                    Manager_Response = dt.Rows[0]["Response"] != DBNull.Value ? dt.Rows[0]["Response"].ToString() : null; // Set the response from the parameter

                    isValid = true;
                }
                else
                {
                    //Make a new feedback row
                    if (createNewFeedback(orderId, feedback, rating) == 0)
                    {
                        // If feedback creation is successful, retrieve the newly created feedback details
                        DataTable newFeedbackDetails = getFeedbackDetailsByOrderID(orderId);
                        if (newFeedbackDetails != null && newFeedbackDetails.Rows.Count > 0)
                        {
                            FeedbackID = newFeedbackDetails.Rows[0]["FeedbackID"].ToString();
                            ManagerID = newFeedbackDetails.Rows[0]["ManagerID"] != DBNull.Value ? newFeedbackDetails.Rows[0]["ManagerID"].ToString() : null;
                            CustomerID = newFeedbackDetails.Rows[0]["CustomerID"].ToString();
                            OrderID = newFeedbackDetails.Rows[0]["OrderID"].ToString();
                            Date = Convert.ToDateTime(newFeedbackDetails.Rows[0]["Date"]);
                            Rating = Convert.ToInt32(newFeedbackDetails.Rows[0]["Rating"]);
                            Customer_Feedback = newFeedbackDetails.Rows[0]["Customer_Feedback"].ToString();
                            Manager_Response = newFeedbackDetails.Rows[0]["Response"] != DBNull.Value ? newFeedbackDetails.Rows[0]["Response"].ToString() : null; // Handle null response

                            isValid = true;
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve newly created feedback details.", "Create New Feedback Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to create new feedback details.", "Create New Feedback Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as when the order ID does not exist or database connection issues
                MessageBox.Show("Error creating feedback: " + ex.Message, "Create New Feedback Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public FeedbackObj(string orderId)
        {
            try
            {
                //Assign values to the properties of FeedbackObj based on the orderId
                DataTable dt = getFeedbackDetailsByOrderID(orderId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    FeedbackID = dt.Rows[0]["FeedbackID"].ToString();
                    ManagerID = dt.Rows[0]["ManagerID"] != DBNull.Value ? dt.Rows[0]["ManagerID"].ToString() : null;
                    CustomerID = dt.Rows[0]["CustomerID"].ToString();
                    OrderID = dt.Rows[0]["OrderID"].ToString();
                    Date = Convert.ToDateTime(dt.Rows[0]["Date"]);
                    Rating = Convert.ToInt32(dt.Rows[0]["Rating"]);
                    Customer_Feedback = dt.Rows[0]["Customer_Feedback"].ToString();
                    Manager_Response = dt.Rows[0]["Response"] != DBNull.Value ? dt.Rows[0]["Response"].ToString() : null; // Handle null response

                    isValid = true;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as when the order ID does not exist or database connection issues
                MessageBox.Show("Error retrieving feedback details: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.WriteLine("Error retrieving feedback details: " + ex.Message);
            }

        }

        public static DataTable recentFeedback()
        {
            DataTable data = new DataTable();
            string query = @"SELECT TOP 5 Customer_Feedback FROM Feedback ORDER BY Date DESC;";
            data = DatabaseHelper.ExecuteQuery(query);
            return data;
        }
    }

    public class FeedbackResponse
    {
        public string FeedbackID { get; set; }
        public string Customer_Feedback { get; set; }
        public string CustomerID { get; set; }
        public string OrderID { get; set; }
        public string Response { get; set; }
        public double Rating { get; set; }
        public static List<string> GetFeedbackIDWithoutResponses()
        {
            string query = "SELECT * FROM Feedback WHERE Response IS NULL";
            DataTable dtfbID = DatabaseHelper.ExecuteQuery(query);
            return dtfbID.AsEnumerable().Select(row => row.Field<string>("FeedbackID")).ToList(); // LINQ to convert DataTable to List<string>
        }

        public FeedbackResponse(string feedbackID)
        {
            string query = "SELECT * FROM Feedback WHERE FeedbackID = @FeedbackID";
            DataTable dt = DatabaseHelper.ExecuteQuery(query, new System.Data.SqlClient.SqlParameter("@FeedbackID", feedbackID)); // Execute the query with the provided feedback ID
            if (dt != null && dt.Rows.Count > 0) // Check if the DataTable has rows
            {
                DataRow row = dt.Rows[0];

                FeedbackID = row["FeedbackID"].ToString();
                Customer_Feedback = row["Customer_Feedback"].ToString();
                CustomerID = row["CustomerID"].ToString();
                OrderID = row["OrderID"].ToString();
                Rating = row["Rating"] != DBNull.Value ? Convert.ToDouble(row["Rating"]) : 0.0;

            }

        }

        public static string AddResponse(string feedbackID, string response, string managerID)
        {
            string query = "UPDATE Feedback SET Response = @Response, ManagerID = @managerID WHERE FeedbackID = @FeedbackID";
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query,
                new System.Data.SqlClient.SqlParameter("@FeedbackID", feedbackID),
                new System.Data.SqlClient.SqlParameter("@Response", response),
                new System.Data.SqlClient.SqlParameter("@ManagerID", managerID));

            if (rowsAffected > 0)
            {
                return "Response added successfully.";
            }
            else
            {
                return "Failed to add response. Please try again.";
            }
        }
    }
}
