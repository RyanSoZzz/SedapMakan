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
    public partial class RefundRequestForm : Form
    {
        public RefundRequest returningItem = null;
        Order theOrder;
        public RefundRequestForm(Order theOrder)
        {
            InitializeComponent();
            this.theOrder = theOrder;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtReason.Text.Length <= 20)
            {
                lblInvalid.Visible = true;
                lblInvalid.Text = "Please input reason in detail";
                return;
            }
            btnSubmit.Visible = false;
            btnSubmit.Enabled = false;
            pnlConfirm.Visible = true;
            pnlConfirm.Enabled = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (txtReason.Text.Length <= 20)
            {
                lblInvalid.Visible = true;
                lblInvalid.Text = "Please input reason in detail";
                return;
            }
            returningItem = new RefundRequest(theOrder, txtReason.Text);

            if (returningItem != null && returningItem.isValid == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = Color.Black;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = Color.White;
        }

        private void btnNo_MouseEnter(object sender, EventArgs e)
        {
            btnNo.ForeColor = Color.Black;
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
            btnNo.ForeColor = Color.Red;
        }

        private void btnYes_MouseEnter(object sender, EventArgs e)
        {
            btnYes.ForeColor = Color.Black;
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.ForeColor= Color.Lime;
        }
    }
}
