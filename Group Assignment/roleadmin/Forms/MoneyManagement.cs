using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.roleadmin.Classes;

namespace Group_Assignment.roleadmin.Forms
{
    public partial class MoneyManagement : Form
    {
        private decimal _money;
        private string _id;
        private string _roleID;
        private string function;
        public MoneyManagement()
        {
            InitializeComponent();
        }
        public MoneyManagement(string id, string role, string func)
        {
            InitializeComponent();
            _id = id;
            if (role == "Admin")
                _roleID = "R001";
            else if (role == "Manager")
                _roleID = "R002";
            else if (role == "Chef")
                _roleID = "R003";
            else if (role == "Customer")
                _roleID = "R004";
            function = func; //"1" = Salary, "2" = EWallet
        }
        private void MoneyManagement_Load(object sender, EventArgs e)
        {
            if (function == "1")
            {
                _money = Users.getSalary(_id, _roleID);
                lblCurrentBal.Text = $"Current Salary: RM {_money}";
                btnUpdate.Text = "Update Salary";
            }
            else if (function == "2")
            {
                _money = Users.getEWallet(_id);
                lblCurrentBal.Text = $"EWallet Balance: RM {_money}";
                btnUpdate.Text = "Update Balance";
            }
            lblID.Text = $"AccountID: {_id}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (function == "1")
                {
                    Users.updateSalary(_id, _roleID, decimal.Parse(txtboxNewBal.Text));
                    _money = Users.getSalary(_id, _roleID);
                    lblCurrentBal.Text = $"Current Salary: RM {_money}";

                }
                else if (function == "2")
                {
                    Users.updateEWallet(_id, decimal.Parse(txtboxNewBal.Text));
                    _money = Users.getEWallet(_id);
                    lblCurrentBal.Text = $"EWallet Balance: RM {_money}";
                }
                txtboxNewBal.Text = "";
                btnUpdate.Enabled = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Invalid Value Inserted", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtboxNewBal_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }
    }
}
