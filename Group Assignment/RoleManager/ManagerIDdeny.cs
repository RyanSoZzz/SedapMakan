using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.RoleCustomer;

namespace Group_Assignment.RoleManager
{
    public partial class ManagerIDdeny : Form
    {
        private string refundID;
        private readonly string managerID; // Assuming you have a manager ID to pass to the ManagerIDdeny class

        public ManagerIDdeny(string refundID, string managerID)
        {
            InitializeComponent();
            this.refundID = refundID;
            this.managerID = managerID; // Initialize the manager ID
        }
        // Default constructor for designer support
        public ManagerIDdeny()
        {
            InitializeComponent();
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            string result = RefundRequest.DenyRefund(refundID, managerID);
            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
