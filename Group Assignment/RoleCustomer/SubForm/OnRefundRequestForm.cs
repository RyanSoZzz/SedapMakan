using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.RoleCustomer.SubForm
{
    public partial class OnRefundRequestForm : Form
    {
        public RefundRequest theRefundRequest;
        public OnRefundRequestForm(RefundRequest TheRefundRequest)
        {
            try
            {
                InitializeComponent();
                theRefundRequest = TheRefundRequest;
                if (theRefundRequest != null)
                {
                    switch (theRefundRequest.Status)
                    {
                        case ("Accepted"):
                            lblStatus.Text = "Status: " + theRefundRequest.Status;
                            lblStatus.ForeColor = Color.Green;
                            break;
                        case ("Pending"):
                            lblStatus.Text = "Status: " + theRefundRequest.Status;
                            lblStatus.ForeColor = Color.Teal;
                            break;
                        default:
                            lblStatus.Text = "Status: error";
                            lblStatus.ForeColor = Color.Gray;
                            break;
                    }

                    lblTotalRefund.Text = "Total Refund - MYR" + theRefundRequest.Amount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
