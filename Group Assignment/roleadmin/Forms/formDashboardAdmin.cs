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
    public partial class formDashboardAdmin : Form
    {
        public formDashboardAdmin()
        {
            InitializeComponent();
        }

        private void formDashboardAdmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void formDashboardAdmin_Activated(object sender, EventArgs e)
        {
            updateStats();
        }   

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateStats();
        }

        private void updateStats()
        {
            string[] tempStr = new string[3];
            DataTable tempDT = new DataTable();
            //To update the whole analytics everytime you go to the dashboard
            //Code
            lblTotalUsersResult.Text = Users.getTotalUser("all", "all");
            lblTotalAdminResult.Text = Users.getTotalUser("admin", "all");
            lblTotalManagerResult.Text = Users.getTotalUser("manager", "all");
            lblTotalChefResult.Text = Users.getTotalUser("chef", "all");
            lblTotalCustomerResult.Text = Users.getTotalUser("customer", "all");

            lblTotalSalesResult.Text = ChefSales.getTotSales(null, "all");
            lblMonthlySalesResult.Text = ChefSales.getTotSales(null, "monthly");
            dataGridCOTM.DataSource = ChefSales.COTM();
            dataGridCOTM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            tempStr = Customer.topCustomer("amount");
            lblTopCustAmountResult.Text = tempStr[0] + "  |  RM " + tempStr[1];
            tempStr = Customer.topCustomer("order");
            lblTopCustOrderResult.Text = tempStr[0] + "  |  " + tempStr[1] + " Orders";


            lblWeeklyUserResult.Text = Users.getTotalUser("none", "weekly");
            tempStr = Group_Assignment.roleadmin.Classes.Order.recentOrder();
            lblLatestOrderResult.Text = tempStr[0] + "  | RM  " + tempStr[1] + "  |  " + tempStr[2];
            tempStr = EWalletTopUp.recentTopUp();
            lblLatestTopUpResult.Text = tempStr[0] + "  | RM  " + tempStr[1] + "  |  " + tempStr[2];
            
            //Clears old data as we're adding new items
            listboxFeedbackAdmin.Items.Clear();
            tempDT = FeedbackObj.recentFeedback();
            int tempNum = 0;
            foreach (DataRow row in tempDT.Rows)
            {
                tempNum++;
                listboxFeedbackAdmin.Items.Add($"{tempNum}. {row["Customer_Feedback"]}");
            }
        }
    }
}
