using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.RoleCustomer
{
    public partial class HistoryForm : Form
    {
        string customerID = string.Empty;
        List<HistoryOrderBlock> historyOrders = new List<HistoryOrderBlock>();
        Order theOrder = null;
        FeedbackObj theFeedback = null;
        RefundRequest theRefundRequest = null;
        public HistoryForm(string custId)
        {
            InitializeComponent();
            customerID = custId;
            refreshHistoryForm();
        }


        private void refreshHistoryForm()
        {
            DataTable result = Order.getAllOrderIdFromCustomerID(customerID);
            if (result != null && result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    theOrder = null;
                    theOrder = new Order(row["OrderID"].ToString());

                    theFeedback = new FeedbackObj(row["OrderID"].ToString());
                    if (theFeedback.isValid == false)
                    {
                        theFeedback = null;
                    }

                    theRefundRequest = new RefundRequest(theOrder, null);
                    if (theRefundRequest.isValid == false)
                    {
                        theRefundRequest = null;
                    }

                    if (theOrder != null)
                    {
                        HistoryOrderBlock item = new HistoryOrderBlock(theOrder, theFeedback, theRefundRequest);
                        if (item != null)
                        {
                            pnlHistory.Controls.Add(item);
                            item.Dock = DockStyle.Top;

                            historyOrders.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Faied to add block of {row["OrderID"].ToString()}", "Refresh History Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pnlHistory_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
