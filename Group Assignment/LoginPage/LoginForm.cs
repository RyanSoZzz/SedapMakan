using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.LoginPage
{
    public partial class LoginForm : Form, IFormWithAllLoginEvents, IFormWithAllUniversalEvents
    {
        public event EventHandler<FormEventArgs> changeFormEvent;
        public event EventHandler<DataTableEventArgs> finishedLoginEvent;

        private CustomMethod customMethod;

        public LoginForm()
        {
            InitializeComponent();

            // Initialize
            customMethod = new CustomMethod();
            this.AcceptButton = btnLogin; // Set the default button to btnLogin
        }

        //Change Page Button
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            changeFormEvent?.Invoke(this, new FormEventArgs(new SignUpForm()));
        }

        //Username and Password TextBox
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogin.PerformClick(); // Simulates clicking the button
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

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        //Checkbox Show Password
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        //Login Button
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Lime;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            int result;
            Dictionary<int, string> errorCodes = CredentialValidation.errorCodes;

            // Validate the input fields before proceeding
            if (txtUsername.Text == "Enter username")
            {
                lblInvalidUN.Visible = true;
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

            result = CredentialValidation.usernameValidation(username);
            if (result != 1004)
            {
                MessageBox.Show(errorCodes[1005], "Error: " + 1005, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }

            //Proceed with the login logic
            btnLogin.ForeColor = Color.Lime;
            btnLogin.Enabled = false;
            try
            {
                result = LoginQuery.verifyLoginQuery(username, password, true);
                if (result > 0)
                {
                    DataTable userDetails = LoginQuery.getAccountDetailsFromAccID(result, false);
                    if (userDetails != null && userDetails.Rows.Count > 0)
                    {
                        if (userDetails.Rows.Count > 1)
                        {
                            changeFormEvent?.Invoke(this, new FormEventArgs(new ChooseProfileForm(userDetails)));
                        }
                        else
                        {
                            DataTable userSpecific = userDetails.Clone();
                            foreach (DataRow row in userDetails.Rows)
                            {
                                if (row["RoleID"].ToString() == "R004") // Extract RoleID from the RadioButton name
                                {
                                    userSpecific.ImportRow(row);
                                    break; // Assuming RoleID is unique, we can break after finding the match
                                }
                            }
                            finishedLoginEvent?.Invoke(this, new DataTableEventArgs(userSpecific));
                        }
                    }

                    MessageBox.Show("Login Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    txtUsername.Focus();
                    return;
                }
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
