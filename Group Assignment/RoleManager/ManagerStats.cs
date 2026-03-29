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
    public partial class ManagerStats : Form
    {
        private readonly string managerID; // Assuming you have a manager ID to pass to the ManagerStats class
        public ManagerStats(string managerID)
        {
            InitializeComponent();
            this.managerID = managerID;
        }

        private void ManagerStats_Load(object sender, EventArgs e)
        {
            try
            {
                txtManagerID.Text = this.managerID; // Assuming you have a TextBox or similar control to display the manager ID
                ManagerStatistics stats = new ManagerStatistics(managerID);
                txtRefundDenied.Text = stats.deniedRefundsCount.ToString();
                txtRefundAccepted.Text = stats.acceptedRefundsCount.ToString();
                txtFeedbackResp.Text = stats.feedbacksrespondedCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading manager statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
