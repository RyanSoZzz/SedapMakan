using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Ensure you have the correct using directive for SQL operations
using Group_Assignment.RoleCustomer;

namespace Group_Assignment.RoleManager
{
    public partial class FeedbackRespondConfirm : Form
    {
        
        private readonly string feedbackID;
        private readonly string response;
        private readonly string managerID;

        public FeedbackRespondConfirm(string feedbackID, string response, string managerid)
        {
            InitializeComponent();
            this.feedbackID = feedbackID;
            this.response = response;
            this.managerID = managerid; // Store the manager ID for later use
        }
        public FeedbackRespondConfirm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string result = FeedbackResponse.AddResponse(feedbackID, response, managerID);
            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the confirmation dialog without making any changes
        }
    }
}
