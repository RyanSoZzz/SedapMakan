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
    public partial class ManagerIDaccept : Form
    {
        
        private readonly string refundID;
        private readonly string managerID; // Assuming you have a manager ID to pass to the ManagerIDaccept class

        public ManagerIDaccept(string refundID, string managerID)
        {
            InitializeComponent();
            this.refundID = refundID;
            this.managerID = managerID; // Initialize the manager ID
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string result = RefundRequest.ConfirmRefund(refundID, managerID);
            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

