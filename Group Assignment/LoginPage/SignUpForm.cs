using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.LoginPage
{
    public partial class SignUpForm : Form, IFormWithAllUniversalEvents
    {
        public event EventHandler<FormEventArgs> changeFormEvent;
        public SignUpForm()
        {
            InitializeComponent();

            this.AcceptButton = btnCreate; // Set the default button to btnCreate
        }

        //Change Page Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            changeFormEvent?.Invoke(this, new FormEventArgs(new LoginForm()));
        }

        //Username, Password, and PhoneNumber TextBox
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnCreate.PerformClick(); // Simulates clicking the button
            }
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    txtUsername.Text = "Enter username";
                    txtUsername.SelectAll();
                    txtUsername.ForeColor = Color.Gray;
                    return;
                }


                if (txtUsername.Text.Contains(" ") && txtUsername.Text != "Enter username")
                {
                    int cursorPosition = txtUsername.SelectionStart;

                    //Remove spaces from the username
                    txtUsername.Text = txtUsername.Text.Replace(" ", "");

                    //Restore the cursor position
                    txtUsername.SelectionStart = (Math.Max(0, cursorPosition - 1));
                }
                else if (txtUsername.Text.Any(char.IsUpper) && txtUsername.Text != "Enter username")
                {
                    int cursorPosition = txtUsername.SelectionStart;
                    // Convert to lowercase if it contains uppercase letters
                    txtUsername.Text = txtUsername.Text.ToLower();

                    //Restore the cursor position
                    txtUsername.SelectionStart = (Math.Max(0, cursorPosition));
                }

                    txtUsername.ForeColor = Color.White;
                lblInvalidUN.Visible = false;
            }
            catch { }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "" || txtPassword.Text == "Password")
                {
                    txtPassword.Text = "Password";
                    txtPassword.SelectAll();
                    txtPassword.ForeColor = Color.Gray;
                    txtPassword.UseSystemPasswordChar = false;
                    return;
                }

                if (txtPassword.Text.StartsWith(" "))
                {
                    txtPassword.Text = txtPassword.Text.Trim();
                }

                if (cbShowPassword.Checked)
                    txtPassword.UseSystemPasswordChar = false;
                else
                    txtPassword.UseSystemPasswordChar = true;

                txtPassword.ForeColor = Color.White;
                lblInvalidPW.Visible = false;
            }
            catch { }
        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPhoneNumber.Text == "" || txtPhoneNumber.Text == "011-XXXXXXX")
                {
                    txtPhoneNumber.Text = "011-XXXXXXX";
                    txtPhoneNumber.SelectAll();
                    txtPhoneNumber.ForeColor = Color.Gray;
                    return;
                }

                if (txtPhoneNumber.Text.Contains(" ") && txtPhoneNumber.Text != "011-XXXXXXX")
                {
                    int cursorPosition = txtPhoneNumber.SelectionStart;

                    //Remove spaces from the username
                    txtPhoneNumber.Text = txtPhoneNumber.Text.Replace(" ", "");

                    //Restore the cursor position
                    txtPhoneNumber.SelectionStart = (Math.Max(0, cursorPosition - 1));
                }
                txtPhoneNumber.ForeColor = Color.White;
                lblInvalidPhone.Visible = false;
            }
            catch { }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }
        private void txtPhoneNumber_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.SelectAll();
        }

        //Checkbox Show Password
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        //RadioButton Gender Selection
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblInvalidGender.Visible = false;
        }

        //Create Button
        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.ForeColor = Color.Black;
        }
        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.ForeColor = Color.Cyan;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username, password, gender, phonenumber;
            int result;
            Dictionary<int, string> errorCodes = CredentialValidation.errorCodes;

            // Validate the input fields before proceeding
            result = CredentialValidation.usernameValidation(txtUsername.Text);
            if (txtUsername.Text == "Enter username" || result != 0)
            {
                if (txtUsername.Text == "Enter username")
                    lblInvalidUN.Visible = true;
                else
                    MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            else username = txtUsername.Text;

            result = CredentialValidation.passwordValidation(txtPassword.Text);
            if (txtPassword.Text == "Password" || result != 0)
            {
                if (txtPassword.Text == "Password")
                    lblInvalidPW.Visible = true;
                else
                    MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            else password = txtPassword.Text;

            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                lblInvalidGender.Visible = true;
                return;
            }
            else gender = rbMale.Checked ? "Male" : "Female";

            result = CredentialValidation.phoneNumberValidation(txtPhoneNumber.Text);
            if (txtPhoneNumber.Text == "" || txtPhoneNumber.Text == "011-XXXXXXX" || result != 0)
            {
                if (txtPhoneNumber.Text == "011-XXXXXXX")
                    lblInvalidPhone.Visible = true;
                else
                    MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
                return;
            }
            else phonenumber = txtPhoneNumber.Text;

            // Proceed with the sign-up logic
            btnCreate.ForeColor = Color.Cyan;
            btnCreate.Enabled = false;
            try
            {
                LoginQuery.addAccountQuery(username, password, gender, phonenumber, true); 
            }
            finally
            {
                btnCreate.Enabled = true;
            }
        }
    }
}
