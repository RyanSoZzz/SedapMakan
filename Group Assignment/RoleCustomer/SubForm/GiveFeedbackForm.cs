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
    public partial class GiveFeedbackForm : Form
    {
        public FeedbackObj returningItem = null;
        string orderId;
        public GiveFeedbackForm(string OrderID)
        {
            InitializeComponent();
            orderId = OrderID;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numudRating_ValueChanged(object sender, EventArgs e)
        {
            lblStar.Text = string.Concat(Enumerable.Repeat("⭐", Convert.ToInt32(numudRating.Value)));
        }

        private void txtFeedback_Click(object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFeedback.Text.Length < 10)
            {
                lblInvalid.Visible = true;
                lblInvalid.Text = "Please input feedback at least a few words";
                return;
            }

            returningItem = new FeedbackObj(orderId, txtFeedback.Text, lblStar.Text.Length);
            if (returningItem != null && returningItem.isValid == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = Color.Yellow;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = Color.Yellow;
        }
    }
}
