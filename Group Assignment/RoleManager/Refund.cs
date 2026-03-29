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
    public partial class Refund : Form
    {
        private readonly string managerID; // Assuming you have a manager ID to pass to the Refund class
        public Refund(string managerID)
        {
            InitializeComponent();
            this.managerID = managerID;
        }

        private void Refund_Load(object sender, EventArgs e)
        {
            loadrefundID();
            cmbRefundID.SelectedIndex = -1; // Set the selected index to -1 to ensure no item is selected initially
            txtCustomerID.Clear();
            txtOrderID.Clear();
            txtAmount.Clear();
            txtStatus.Clear();
        }
        private void loadrefundID()
        {
            try 
            {
                cmbRefundID.Items.Clear();
                foreach (string refundID in RefundRequest.GetPendingRefundID()) // Assuming GetPendingRefundID returns a List<string> of refund IDs
                {
                    cmbRefundID.Items.Add(refundID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading refund IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbRefundID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                if (cmbRefundID.SelectedItem == null) return;
                RefundRequest selectedRefund = new RefundRequest(cmbRefundID.SelectedItem.ToString()); // Assuming GetRefundByID returns a RefundRequest object
                if (selectedRefund == null)
                {
                    MessageBox.Show("Refund details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtCustomerID.Text = selectedRefund.CustomerID;
                txtOrderID.Text = selectedRefund.OrderID;
                txtAmount.Text = selectedRefund.Amount.ToString("C"); // Format as currency
                txtStatus.Text = selectedRefund.Status;
                richTxtReason.Text = selectedRefund.RefundReason; // Assuming RefundRequest has a RefundReason property
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading refund details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmRefund_Click(object sender, EventArgs e)
        {
            try 
            {
                if (cmbRefundID.SelectedItem == null)
                {
                    MessageBox.Show("Please select a refund request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string selectedRefundID = cmbRefundID.SelectedItem.ToString();
                ManagerIDaccept managerIDConfirmAndDeny = new ManagerIDaccept(selectedRefundID, managerID);
                managerIDConfirmAndDeny.ShowDialog(this); // Show the confirmation dialog
                cmbRefundID.SelectedIndex = -1;
                Refund_Load(sender, e); // Refresh the refund list after confirmation
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while confirming the refund: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                if (cmbRefundID.SelectedItem == null)
                {
                    MessageBox.Show("Please select a refund request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string selectedRefundID = cmbRefundID.SelectedItem.ToString();
                ManagerIDdeny managerIDDeny = new ManagerIDdeny(selectedRefundID, managerID);
                managerIDDeny.ShowDialog(this); // Show the denial dialog
                cmbRefundID.SelectedIndex = -1;
                Refund_Load(sender, e); // Refresh the refund list after denial
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while denying the refund: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
