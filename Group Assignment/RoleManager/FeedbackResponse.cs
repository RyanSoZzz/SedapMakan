using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment
{
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
            string query = "SELECT * FROM Feedback WHERE Response  = ''";
            DataTable dtfbID = DatabaseHelper.ExecuteQuery(query);
            return dtfbID.AsEnumerable().Select(row => row.Field<string>("FeedbackID")).ToList(); // LINQ to convert DataTable to List<string>
        }

        public FeedbackResponse(string feedbackID)
        {
            try 
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
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the initialization
                throw new Exception("Error retrieving feedback details: " + ex.Message);
            }


        }

        public static string AddResponse(string feedbackID, string response, string managerID)
        {
            try 
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
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the response addition
                return "Error adding response: " + ex.Message;
            }

        }
    }
}
    


