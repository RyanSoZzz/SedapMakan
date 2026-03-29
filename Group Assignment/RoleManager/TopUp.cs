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
    public partial class TopUp : Form
    {
        string customerID; // Variable to store the customer ID
        string EWalletID; // Variable to store the e-wallet ID
        public TopUp()
        {
            InitializeComponent();
            customerID = null; // Initialize customerID to null
            txtTopUp.Enabled = false; // Initially disable the top-up input field
            btnTopUp.Enabled = false; // Initially disable the top-up button
        }
        private void resetForm()
        {
            txtCustID.Clear(); // Clear the customer ID input field
            txtName.Clear(); // Clear the name input field
            txtBalance.Clear(); // Clear the balance input field
            txtTopUp.Clear(); // Clear the top-up amount input field
            txtCustID.Enabled = true; // Re-enable the customer ID input field for new entries
            btnConfirmCustID.Enabled = true; // Re-enable the confirm button for new entries
            txtTopUp.Enabled = false; // Disable the top-up input field until a customer ID is confirmed
            btnTopUp.Enabled = false; // Disable the top-up button until a customer ID is confirmed
        }
        private void btnConfirmCustID_Click(object sender, EventArgs e)
        {
            try { 

                string customerID = txtCustID.Text.Trim();
                string name = EWalletTopUp.getCustomerNameFromCustomerID(customerID); // Get the customer name using the customer ID
                float balance = EWalletTopUp.getBalanceFromCustomerID(customerID); // Get the balance using the customer ID
                if (string.IsNullOrEmpty(customerID))
                {
                    MessageBox.Show("Please enter a Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                else
                {
                    if (balance == -1 || name == null)
                    {
                        MessageBox.Show("Customer ID not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.customerID = customerID; // Store the customer ID for later use
                        this.EWalletID = EWalletTopUp.getEWalletIDfromCustomerID(customerID); // Get the e-wallet ID using the customer ID
                        txtName.Text = name; // Display the customer's name in the name input field
                        txtBalance.Text = balance.ToString("C"); // Display the balance in currency format
                        MessageBox.Show("Customer ID confirmed. You can now proceed with the top-up.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTopUp.Enabled = true; // Enable the top-up input field
                        btnTopUp.Enabled = true; // Enable the top-up button
                        txtCustID.Enabled = false; // Disable the customer ID input field to prevent further changes
                        btnConfirmCustID.Enabled = false; // Disable the confirm button to prevent re-confirmation
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while confirming the Customer ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            try
            {
                float topUpAmount;
                topUpAmount = float.TryParse(txtTopUp.Text.Trim(), out topUpAmount) ? topUpAmount : -1; // Try to parse the top-up amount from the input field
                if (topUpAmount <= 0)
                {
                    MessageBox.Show("Please enter a valid top-up amount greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (EWalletTopUp.topupEWalletByEWalletID(customerID, EWalletID, topUpAmount) == -1)
                {
                    MessageBox.Show("Top-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Top-up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetForm(); // Reset the form after a successful top-up
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during the top-up process: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
