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
    public partial class CustomerReport : Form
    {
        private Customer _custInfo = null;
        public CustomerReport(Customer Info)
        {
            InitializeComponent();
            _custInfo = Info;
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            txtboxName.Text = _custInfo.CustName;
            txtboxCustID.Text = _custInfo.CustID;
            txtboxEWalletBal.Text = "RM " + _custInfo.EWalletBal;
            txtboxEWalletID.Text = _custInfo.EwalletID;
            txtboxNumOfOrders.Text = _custInfo.NumOfOrder;
            txtboxNumOfFeedbacks.Text = _custInfo.NumOfFeedback;
        }
    }
}
