using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows; // Ensure you have the correct using directive for DataTable

namespace Group_Assignment
{
    public class ManagerStatistics
    {
        public string deniedRefundsCount { get; private set; } // Variable to store the count of denied refunds
        public string acceptedRefundsCount { get; private set; } // Variable to store the count of accepted refunds
        public string feedbacksrespondedCount { get; private set; } // Variable to store the count of feedbacks responded to
        private readonly string managerID;
        public ManagerStatistics(string managerID) 
        {
            try 
            {
                this.managerID = managerID; // Store the manager ID for later use
                string queryDeniedRefunds = "SELECT COUNT(*) AS TotalDeniedRefunds FROM RefundRequest WHERE Status = 'Rejected' AND ManagerID = @ManagerID";
                DataTable dtDeniedRefunds = DatabaseHelper.ExecuteQuery(queryDeniedRefunds, new System.Data.SqlClient.SqlParameter("@ManagerID", managerID)); // Execute the query with the provided manager ID
                if (dtDeniedRefunds != null && dtDeniedRefunds.Rows.Count > 0) // Check if the DataTable has rows
                {
                    deniedRefundsCount = dtDeniedRefunds.Rows[0]["TotalDeniedRefunds"].ToString(); // Get the count of denied refunds
                }
                else
                {
                    deniedRefundsCount = "0"; // Default to 0 if no data is found
                }
                string queryAcceptedRefunds = "SELECT COUNT(*) AS TotalAcceptedRefunds FROM RefundRequest WHERE Status = 'Accepted' AND ManagerID = @ManagerID";
                DataTable dtAcceptedRefunds = DatabaseHelper.ExecuteQuery(queryAcceptedRefunds, new System.Data.SqlClient.SqlParameter("@ManagerID", managerID)); // Execute the query with the provided manager ID
                if (dtAcceptedRefunds != null && dtAcceptedRefunds.Rows.Count > 0) // Check if the DataTable has rows
                {
                    acceptedRefundsCount = dtAcceptedRefunds.Rows[0]["TotalAcceptedRefunds"].ToString(); // Get the count of accepted refunds
                }
                else
                {
                    acceptedRefundsCount = "0"; // Default to 0 if no data is found
                }
                string queryFeedbacksResponded = "SELECT COUNT(*) AS TotalFeedbacksResponded FROM Feedback WHERE Response IS NOT NULL AND ManagerID = @ManagerID";
                DataTable dtFeedbacksResponded = DatabaseHelper.ExecuteQuery(queryFeedbacksResponded, new System.Data.SqlClient.SqlParameter("@ManagerID", managerID)); // Execute the query with the provided manager ID
                if (dtFeedbacksResponded != null && dtFeedbacksResponded.Rows.Count > 0) // Check if the DataTable has rows
                {
                    feedbacksrespondedCount = dtFeedbacksResponded.Rows[0]["TotalFeedbacksResponded"].ToString(); // Get the count of feedbacks responded to
                }
                else
                {
                    feedbacksrespondedCount = "0"; // Default to 0 if no data is found
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the initialization
                deniedRefundsCount = "0"; // Default to 0 if an error occurs
                acceptedRefundsCount = "0"; // Default to 0 if an error occurs
                feedbacksrespondedCount = "0"; // Default to 0 if an error occurs
                MessageBox.Show("An error occurred while initializing ManagerStatistics: " + ex.Message); // Log the error message
            }

        }
    }
}
