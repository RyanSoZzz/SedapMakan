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
using Group_Assignment.RoleCustomer;

namespace Group_Assignment.roleadmin.Forms
{
    public partial class formCustomerReportAdmin : Form
    {

        public formCustomerReportAdmin()
        {
            InitializeComponent();
        }

        private void formCustomerReportAdmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            //Load Table Values
            comboxFilterCust.SelectedIndex = 0;
            comboxFilterCust.DropDownStyle = ComboBoxStyle.DropDownList;
            loadTable(comboxFilterCust.SelectedItem.ToString(), txtboxCustIDFilter.Text);
        }

        private void formCustomerReportAdmin_Activated(object sender, EventArgs e)
        {
            //Load Stats
            lblTotalCustomerResult.Text = Users.getTotalUser("customer", "all");

            //Load Table Values and Amount
            loadTable(comboxFilterCust.SelectedItem.ToString(), txtboxCustIDFilter.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCustReport_Click(object sender, EventArgs e)
        {
            //Get string from Search box, and then query with search name/id, then pass the values into custreport and show
            Customer cust = new Customer();
            cust = Customer.getCust(txtboxSearchCustomer.Text);
            if (cust != null)
            {
                CustomerReport custReport = new CustomerReport(cust);
                custReport.ShowDialog();
            }
        }

        private void btnFilterCust_Click(object sender, EventArgs e)
        {
             //Load Table Values
            loadTable(comboxFilterCust.SelectedItem.ToString(), txtboxCustIDFilter.Text);
        }

        private void loadTable(string selectedFilter, string searchFilter)
        {
            dataGridOrder.DataSource = Group_Assignment.roleadmin.Classes.Order.getOrders(selectedFilter, searchFilter);
            int numOfOrders = Group_Assignment.roleadmin.Classes.Order.getOrders(selectedFilter, searchFilter).Rows.Count;
            if (numOfOrders <= 0)
                MessageBox.Show("No Orders Found in the Time Range");
            lblOrderedResult.Text = numOfOrders.ToString();

            dataGridTopUp.DataSource = EWalletTopUp.getTopUp(selectedFilter, searchFilter);
            int numOfTopUp = EWalletTopUp.getTopUp(selectedFilter, searchFilter).Rows.Count;
            if (numOfTopUp <= 0)
                MessageBox.Show("No Top Ups Found in the Time Range");
            lblTopUpResult.Text = numOfTopUp.ToString();
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            txtboxCustIDFilter.Text = "";
            comboxFilterCust.SelectedIndex = 0;
            loadTable(comboxFilterCust.SelectedItem.ToString(), txtboxCustIDFilter.Text);
        }
    }
}
