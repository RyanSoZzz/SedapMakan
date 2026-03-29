using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.LoginPage;
using Group_Assignment.roleadmin.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group_Assignment.roleadmin.Forms
{
    public partial class UserManagement : Form
    {
        private Users _userInfo = new Users();
        bool addNewUser = true, oriAdmin, oriManager, oriChef, oriCust;

        private void checkboxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            oriAdmin = !oriAdmin;
        }

        private void checkboxManager_CheckedChanged(object sender, EventArgs e)
        {
            oriChef = !oriChef;
        }

        public UserManagement()
        {
            InitializeComponent();
            btnConfirm.Text = "Add User";
        }

        public UserManagement(Users Info)
        {
            InitializeComponent();
            _userInfo = Info;
            addNewUser = false;
            btnConfirm.Text = "Save Changes";

            txtboxName.Text = _userInfo.Username;
            txtboxPassword.Text = _userInfo.Password;
            txtboxPhoneNum.Text = _userInfo.PhoneNum;

            if (_userInfo.Gender == "Male")
            {
                radbtnMale.Checked = true;
            }
            else if (_userInfo.Gender == "Female")
            {
                radbtnFemale.Checked = true;
            }
            else
            {
                MessageBox.Show("User has no gender");
            }
            string[] roles = _userInfo.Roles;
            foreach (string role in roles)
            {
                if (role == "R001")
                {
                    checkboxAdmin.Checked = true;
                    oriAdmin = true;
                }
                else if (role == "R002")
                {
                    checkboxManager.Checked = true;
                    oriManager = true;
                }
                else if (role == "R003")
                {
                    checkboxChef.Checked = true;
                    oriChef = true;
                }
                else if (role == "R004")
                {
                    checkboxCustomer.Checked = true;
                    oriCust = true;
                }
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            lblInvalidPassword.Enabled = false;
            lblInvalidUsername.Enabled = false;
            lblInvalidPhone.Enabled = false;
            lblInvalidGender.Enabled = false;
            lblInvalidRole.Enabled = false;
            if (addNewUser)
            {
                lblTitle.Text = "Add A New User";
            }
            else
            {
                lblTitle.Text = "Edit User Information";
                //load user info
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username, password, gender, phonenumber;
            int result;
            Dictionary<int, string> errorCodes = CredentialValidation.errorCodes;
            if (addNewUser) 
            {
                // Validate the input fields before proceeding
                //Username
                result = CredentialValidation.usernameValidation(txtboxName.Text);
                if (txtboxName.Text == "" || txtboxName.Text == null || result != 0)
                {
                    if (txtboxName.Text == "" || txtboxName.Text == null)
                        lblInvalidUsername.Visible = true;
                    else
                        MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxName.Focus();
                    return;
                }
                else username = txtboxName.Text;

                //Password
                result = CredentialValidation.passwordValidation(txtboxPassword.Text);
                if (txtboxPassword.Text == "" || txtboxPassword.Text == null || result != 0)
                {
                    if (txtboxPassword.Text == "" || txtboxPassword.Text == null)
                        lblInvalidPassword.Visible = true;
                    else
                        MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxPassword.Focus();
                    return;
                }
                else password = txtboxPassword.Text;

                //Phone Number
                result = CredentialValidation.phoneNumberValidation(txtboxPhoneNum.Text);
                if (txtboxPhoneNum.Text == "" || txtboxPhoneNum.Text == null || result != 0)
                {
                    if (txtboxPhoneNum.Text == "" || txtboxPhoneNum.Text == null)
                        lblInvalidPhone.Visible = true;
                    else
                        MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxPhoneNum.Focus();
                    return;
                }
                else phonenumber = txtboxPhoneNum.Text;

                //Gender
                if (radbtnMale.Checked == false && radbtnFemale.Checked == false)
                {
                    lblInvalidGender.Visible = true;
                    return;
                }
                else gender = radbtnMale.Checked ? "Male" : "Female";

                //Add Account once all validated
                try
                {
                    LoginQuery.addAccountQuery(username, password, gender, phonenumber, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Account Creation failed");
                }

                //Adding Roles
                if (checkboxAdmin.Checked == false && checkboxManager.Checked == false &&
                    checkboxChef.Checked == false && checkboxCustomer.Checked == false)
                {
                    LoginQuery.removeAccountQuery(LoginQuery.getAccountIdFromUsername(username), false);
                    MessageBox.Show("<Account Creation Failed> No role has been selected\n", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if (!checkboxCustomer.Checked)
                    {
                        LoginQuery.removeSpecificRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R004");
                    }
                    //Add into Admin
                    if (checkboxAdmin.Checked)
                    {
                        LoginQuery.addRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R001", false);
                        //add user into account roles with role R001
                    }

                    //Add into Manager
                    if (checkboxManager.Checked)
                    {
                        LoginQuery.addRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R002", true);
                        //add user into account roles with role R002
                    }

                    //Add into Chef
                    if (checkboxChef.Checked)
                    {
                        LoginQuery.addRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R003", true);
                        //add user into account roles with role R003
                    }
                    else
                    {
                        MessageBox.Show("Account successfully created!");
                    }
                        this.Close();
                }
            }

            else
            {
                // Validate the input fields before proceeding
                //Username
                result = CredentialValidation.usernameValidation(txtboxName.Text);
                if (txtboxName.Text == "" || txtboxName.Text == null || result == 1001 || result == 1002 || result == 1003)
                {
                    if (txtboxName.Text == "" || txtboxName.Text == null)
                        lblInvalidUsername.Visible = true;
                    else
                        MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxName.Focus();
                    return;
                }
                else username = txtboxName.Text;

                //Password
                result = CredentialValidation.passwordValidation(txtboxPassword.Text);
                if (txtboxPassword.Text == "" || txtboxPassword.Text == null || result != 0)
                {
                    if (txtboxPassword.Text == "" || txtboxPassword.Text == null)
                        lblInvalidPassword.Visible = true;
                    else
                        MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxPassword.Focus();
                    return;
                }
                else password = txtboxPassword.Text;

                //Phone Number
                result = CredentialValidation.phoneNumberValidation(txtboxPhoneNum.Text);
                if (txtboxPhoneNum.Text == "" || txtboxPhoneNum.Text == null || result != 0)
                {
                    if (txtboxPhoneNum.Text == "" || txtboxPhoneNum.Text == null)
                        lblInvalidPhone.Visible = true;
                    else
                        MessageBox.Show(errorCodes[result], "Error: " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxPhoneNum.Focus();
                    return;
                }
                else phonenumber = txtboxPhoneNum.Text;

                //Gender
                if (radbtnMale.Checked == false && radbtnFemale.Checked == false)
                {
                    lblInvalidGender.Visible = true;
                    return;
                }
                else gender = radbtnMale.Checked ? "Male" : "Female";

                try
                {
                    Users.updateInfo(username, password, gender, phonenumber, LoginQuery.getAccountIdFromUsername(username).ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update user details");
                }

                //Editing Roles
                if (checkboxAdmin.Checked == false && checkboxManager.Checked == false &&
                    checkboxChef.Checked == false && checkboxCustomer.Checked == false)
                {
                    LoginQuery.removeAccountQuery(LoginQuery.getAccountIdFromUsername(username), false);
                    MessageBox.Show("<Account Creation Failed> No role has been selected\n", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Add into Admin
                    if (checkboxAdmin.Checked != oriAdmin)
                    {
                        if (checkboxAdmin.Checked)
                        {
                            LoginQuery.addRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R001", false);
                        }
                        else
                            LoginQuery.removeSpecificRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R001");

                        //add user into account roles with role R001
                    }

                    //Add into Manager
                    if (checkboxManager.Checked != oriManager)
                    {
                        if (checkboxManager.Checked)
                        {
                            LoginQuery.addRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R002", false);
                        }
                        else
                            LoginQuery.removeSpecificRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R002");
                        //add user into account roles with role R002
                    }

                    //Add into Chef
                    if (checkboxChef.Checked != oriChef)
                    {
                        if (checkboxChef.Checked)
                        {
                            LoginQuery.addRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R003", false);
                        }
                        else
                            LoginQuery.removeSpecificRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R003");
                        //add user into account roles with role R003
                    }

                    //Add into Customer -- Because the default role is customer, if this is not checked, remove instead
                    if (checkboxCustomer.Checked != oriCust)
                    {
                        if (checkboxCustomer.Checked)
                            LoginQuery.addRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R004", false);
                        else
                            LoginQuery.removeSpecificRoleQuery(LoginQuery.getAccountIdFromUsername(username), "R004");
                        //add user into account roles with role R004
                    }
                }
            }
        }
    }
}
