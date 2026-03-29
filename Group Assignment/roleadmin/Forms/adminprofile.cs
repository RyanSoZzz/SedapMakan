using Group_Assignment.LoginPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.RoleCustomer;

namespace Group_Assignment.roleadmin.Forms
{
    public partial class adminprofile : Form
    {
        DataTable userDetails;
        string custID;

        public adminprofile(DataTable UserDetails)
        {
            InitializeComponent();
            userDetails = UserDetails;
            custID = EWalletTopUp.getCustomerIDFromAccID(Convert.ToInt32(userDetails.Rows[0]["AccountID"]));
            lblUsername.Text = userDetails.Rows[0]["Name"].ToString();
            lblAccId.Text = "accid: " + userDetails.Rows[0]["AccountID"].ToString();
            lblPhoneNumber.Text = "phone number: " + userDetails.Rows[0]["PhoneNumber"].ToString();
        }

        public void refreshProfile()
        {
            userDetails = LoginQuery.getAccountDetailsFromAccID(Convert.ToInt32(userDetails.Rows[0]["AccountID"]));
            lblUsername.Text = userDetails.Rows[0]["Name"].ToString();
            lblAccId.Text = "accid: " + userDetails.Rows[0]["AccountID"].ToString();
            lblPhoneNumber.Text = "phone number: " + userDetails.Rows[0]["PhoneNumber"].ToString();
        }

        private void txtNewUsername_Click(object sender, EventArgs e)
        {
            txtNewUsername.SelectAll();
        }

        private void txtNewPass_Click(object sender, EventArgs e)
        {
            txtNewPass.SelectAll();
        }

        private void txtNewPhone_Click(object sender, EventArgs e)
        {
            txtNewPhone.SelectAll();
        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNewUsername.Text == "")
                {
                    txtNewUsername.Text = "Enter username";
                    txtNewUsername.ForeColor = Color.Gray;
                    return;
                }


                if (txtNewUsername.Text.Contains(" ") && txtNewUsername.Text != "Enter username")
                {
                    int cursorPosition = txtNewUsername.SelectionStart;

                    //Remove spaces from the username
                    txtNewUsername.Text = txtNewUsername.Text.Replace(" ", "");

                    //Restore the cursor position
                    txtNewUsername.SelectionStart = (Math.Max(0, cursorPosition - 1));
                }
                else if (txtNewUsername.Text.Any(char.IsUpper) && txtNewUsername.Text != "Enter username")
                {
                    int cursorPosition = txtNewUsername.SelectionStart;
                    // Convert to lowercase if it contains uppercase letters
                    txtNewUsername.Text = txtNewUsername.Text.ToLower();
                        
                    //Restore the cursor position
                    txtNewUsername.SelectionStart = (Math.Max(0, cursorPosition));
                }

                txtNewUsername.ForeColor = Color.Black;
                lblInvalidUsername.Visible = false;
            }
            catch { }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPass.Text == "" || txtNewPass.Text == "Password")
                {
                    txtNewPass.Text = "Password";
                    txtNewPass.ForeColor = Color.Gray;
                    txtNewPass.UseSystemPasswordChar = false;
                    return;
                }

                if (txtNewPass.Text.StartsWith(" "))
                {
                    txtNewPass.Text = txtNewPass.Text.Trim();
                }

                txtNewPass.ForeColor = Color.Black;
                lblInvalidPass.Visible = false;
            }
            catch { }
        }

        private void txtNewPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPhone.Text == "" || txtNewPhone.Text == "011-XXXXXXX")
                {
                    txtNewPhone.Text = "011-XXXXXXX";
                    txtNewPhone.ForeColor = Color.Gray;
                    return;
                }

                if (txtNewPhone.Text.Contains(" ") && txtNewPhone.Text != "011-XXXXXXX")
                {
                    int cursorPosition = txtNewPhone.SelectionStart;

                    //Remove spaces from the username
                    txtNewPhone.Text = txtNewPhone.Text.Replace(" ", "");

                    //Restore the cursor position
                    txtNewPhone.SelectionStart = (Math.Max(0, cursorPosition - 1));
                }
                txtNewPhone.ForeColor = Color.Black;
                lblInvalidPhone.Visible = false;
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username, password,phonenumber;
            int result;
            Dictionary<int, string> errorCodes = CredentialValidation.errorCodes;

            // Validate the input fields before proceeding
            result = CredentialValidation.usernameValidation(txtNewUsername.Text);
            if (txtNewUsername.Text == "Enter username" || result != 0)
            {
                if (txtNewUsername.Text == "Enter username")
                    username = userDetails.Rows[0]["Name"].ToString();
                else
                {
                    MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblInvalidUsername.Visible = true;  
                    txtNewUsername.Focus();
                    return;
                }
            }
            else username = txtNewUsername.Text;

            result = CredentialValidation.passwordValidation(txtNewPass.Text);
            if (txtNewPass.Text == "Password" || result != 0)
            {
                if (txtNewPass.Text == "Password")
                    password = userDetails.Rows[0]["Password"].ToString();
                else
                {
                    MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblInvalidPass.Visible = true;
                    txtNewPass.Focus();
                    return;
                }
            }
            else password = txtNewPass.Text;

            result = CredentialValidation.phoneNumberValidation(txtNewPhone.Text);
            if (txtNewPhone.Text == "" || txtNewPhone.Text == "011-XXXXXXX" || result != 0)
            {
                if (txtNewPhone.Text == "011-XXXXXXX")
                    phonenumber = userDetails.Rows[0]["PhoneNumber"].ToString();
                else
                {
                    MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblInvalidPhone.Visible = true;
                    txtNewPhone.Focus();
                    return;
                }
            }
            else phonenumber = txtNewPhone.Text;

            //Proceed with the update if all validations pass
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Enabled = false;
            try
            {
                if (LoginQuery.updateUserQuery(userDetails.Rows[0]["Name"].ToString(), username, password, phonenumber, true) == 0)
                {
                    refreshProfile();
                }
            }
            finally
            {
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.FromArgb(230,230,230);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.FromArgb(25, 25, 25);
        }
        
    }
}
