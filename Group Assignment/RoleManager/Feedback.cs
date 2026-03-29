using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.RoleCustomer;

namespace Group_Assignment.RoleManager
{
    public partial class Feedback : Form
    {
        private readonly string managerID; // Assuming you have a manager ID to pass to the Feedback class
        public Feedback(string managerID)
        {
            InitializeComponent();
            this.managerID = managerID;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            loadfeedbackID();
            cmbFeedback.SelectedIndex = -1; // Set the selected index to -1 to ensure no item is selected initially
            txtCustomerID.Clear();
            txtOrderID.Clear();
            richtxtFeedback.Clear();
            lblRating.Text = string.Empty; // Clear the rating label
            richTxtRespond.Clear(); // Clear the response text box
        }

        private void loadfeedbackID()
        {
            cmbFeedback.Items.Clear();
            foreach (string feedbackID in FeedbackResponse.GetFeedbackIDWithoutResponses()) // Assuming GetFeedbackResponses returns a List<string> of feedback IDs
            {
                cmbFeedback.Items.Add(feedbackID);
            }
        }

        private void cmbFeedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFeedback.SelectedItem == null) return;
            FeedbackResponse selectedFeedback = new FeedbackResponse(cmbFeedback.SelectedItem.ToString()); // Assuming GetFeedbackByID returns a FeedbackResponse object
            if (selectedFeedback == null)
            {
                MessageBox.Show("Feedback details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtCustomerID.Text = selectedFeedback.CustomerID;
            txtOrderID.Text = selectedFeedback.OrderID;
            richtxtFeedback.Text = selectedFeedback.Customer_Feedback;
            lblRating.Text = selectedFeedback.Rating.ToString(); // Assuming Rating is a double
        }

        private void btnConfirmFeed_Click(object sender, EventArgs e)
        {
            if (cmbFeedback.SelectedItem == null)
            {
                MessageBox.Show("Please select a feedback request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string feedbackID = cmbFeedback.SelectedItem.ToString();
            string response = richTxtRespond.Text.Trim();
            if (string.IsNullOrEmpty(response))
            {
                MessageBox.Show("Please enter a response.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FeedbackRespondConfirm feedbackRespondConfirm = new FeedbackRespondConfirm(feedbackID, response, managerID);
            feedbackRespondConfirm.ShowDialog(); // Show the confirmation dialog
            cmbFeedback.SelectedIndex = -1; // Reset the selection after confirmation
            Feedback_Load(sender, e); // Reload the feedback list to reflect any changes
        }
    }
}
