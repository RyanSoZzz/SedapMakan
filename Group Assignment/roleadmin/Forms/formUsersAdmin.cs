using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment;
using Group_Assignment.LoginPage;
using Group_Assignment.roleadmin.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace Group_Assignment.roleadmin.Forms
{
    public partial class formUsersAdmin : Form
    {
        Users userInfo = new Users();
        string function;
        public formUsersAdmin()
        {
            InitializeComponent();
        }

        private void formUsersAdmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            comboxFilterAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxFilterAdmin.SelectedIndex = 0;
            lblTotalUserResult.Text = Users.getTotalUser("all", "all");
            btnEditUserAdmin.Enabled = false;
            btnDeleteUserAdmin.Enabled = false;
            LoadStats(comboxFilterAdmin.SelectedItem.ToString());
            //Analytics Setting
        }
        private void formUsersAdmin_Activated(object sender, EventArgs e)
        {
            LoadStats(comboxFilterAdmin.SelectedItem.ToString());
        }

        private void btnSearchFilterAdmin_Click(object sender, EventArgs e)
        {
            //Filters
            if (comboxFilterAdmin.SelectedIndex == 4)
            {
                btnMoney.Enabled = true;
                btnMoney.Text = "Edit Ewallet";
                function = "2";
            }
            else if (comboxFilterAdmin.SelectedIndex == 0)
            {
                btnMoney.Enabled = false;
                btnMoney.Text = "Loading...";
            }
            else
            {
                btnMoney.Enabled = true;
                btnMoney.Text = "Edit Salary";
                function = "1";
            }
            LoadStats(comboxFilterAdmin.SelectedItem.ToString());
        }
        private void btnClearSearchAdmin_Click(object sender, EventArgs e)
        {
            btnMoney.Enabled = false;
            btnMoney.Text = "Loading...";
            txtboxSearchAdmin.Text = "";
            comboxFilterAdmin.SelectedIndex = 0;
            LoadStats(comboxFilterAdmin.SelectedItem.ToString());
        }


        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            //Search username
            LoadStats(txtboxSearchAdmin.Text);
        }

        private void dataGridUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Activates Edit & Delete Button
            btnEditUserAdmin.Enabled = true;
            btnDeleteUserAdmin.Enabled = true;
        }
        // --------------- Method ---------------
        private void LoadStats(string Role)
        {
            try
            {
                DataTable dataSource = Users.getUsers(Role);
                if (dataSource.Rows.Count == 0)
                    MessageBox.Show("No Users was Found");
                dataGridUsers.DataSource = dataSource;
                int temp = dataSource.Rows.Count;
                lblNumResult.Text = temp.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during retrieving users data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //edit user
        private void btnEditUserAdmin_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridUsers.CurrentRow.Cells["AccountID"].Value.ToString());
            DataTable data = LoginQuery.getAccountDetailsFromAccID(id); 
            //Inserting data
            if (data != null && data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                userInfo.AccountID = row["AccountID"].ToString();
                userInfo.Username = row["Name"].ToString();
                userInfo.Password = row["Password"].ToString();
                userInfo.Gender = row["Gender"].ToString();
                userInfo.PhoneNum = dataGridUsers.CurrentRow.Cells["PhoneNum"].Value.ToString();
                userInfo.Roles = Users.userRoles(id.ToString());
            }
            else
            {
                MessageBox.Show("No account details found.");
            }
            //Calling UserManagement form with passing userInfo  -- Editing User Details
            UserManagement userManagement = new UserManagement(userInfo);
            userManagement.Location = this.Location;
            userManagement.ShowDialog();
            LoadStats(comboxFilterAdmin.SelectedItem.ToString());
        }

        //add user
        private void btnAddUserAdmin_Click(object sender, EventArgs e)
        {
            //Calling UserManagement form with no parameters -- Adding new user
            UserManagement userManagement = new UserManagement();
            userManagement.ShowDialog();
            LoadStats(comboxFilterAdmin.SelectedItem.ToString());
        }

        //delete user
        private void btnDeleteUserAdmin_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridUsers.CurrentRow.Cells["AccountID"].Value.ToString());
            //Code
            Form confirmForm = new Form();
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?\n",
                                                "Confirm Action",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Users.deleteUser(id);
                LoadStats(comboxFilterAdmin.SelectedItem.ToString());
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridUsers.CurrentRow.Cells["AccountID"].Value.ToString());
            MoneyManagement moneyManagement = new MoneyManagement(id.ToString(), comboxFilterAdmin.SelectedItem.ToString(), function);
            moneyManagement.ShowDialog();
        }
    }
}
