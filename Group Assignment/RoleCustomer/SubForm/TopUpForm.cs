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
    public partial class TopUpForm : Form
    {
        private string ewalletID, custid;
        private float balance;
        private Point mouseLocation;

        public TopUpForm(string CustomerID , string EWalletID, float Balance)
        {
            InitializeComponent();
            ewalletID = EWalletID;
            balance = Balance;
            custid = CustomerID;
        }

        //Moving the Form
        private void Form_Mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Form_Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        //Main Logic for Top Up
        private void btnTopUp_Click(object sender, EventArgs e)
        {
            //Validation Input
            if (txtAmount == null || txtAmount.Text == "" || !float.TryParse(txtAmount.Text, out float amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount to top up.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (EWalletTopUp.topupEWalletByEWalletID(custid ,ewalletID, amount) == 0)
                {
                    MessageBox.Show("Top-up successful! Your new balance is: " + (balance + amount).ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("ms-MY")), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after successful top-up
                }
                else
                {
                    MessageBox.Show("Top-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form when exit button is clicked
        }
    }
}
