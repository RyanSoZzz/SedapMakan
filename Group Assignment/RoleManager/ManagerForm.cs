using Group_Assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Group_Assignment.RoleCustomer;
using Group_Assignment.LoginPage;
using Group_Assignment.roleadmin.Classes;
using System.Data.SqlClient;

namespace Group_Assignment.RoleManager
{
    public partial class ManagerForm : Form
    {
        
        private Button currentBtn;
        private Panel leftBorderBtn;
        private ButtonStyle.Highlight highlight;
        public Point mouseLocation;
        Feedback feedback;
        Refund refund;
        TopUp topup;
        ManagerStats stats;
        ManagerProfileForm settingform;

        string managerID;
        DataTable userDetails;
        public ManagerForm(DataTable UserDetails)
        {
            InitializeComponent();
            highlight = new ButtonStyle.Highlight(laypanMenu);

            // Initial page load
            userDetails = UserDetails;
            highlight = new ButtonStyle.Highlight(laypanMenu);
            string query = @"select * from Manager where AccountID = @accid";
            DataTable result = DatabaseHelper.ExecuteQuery(query, new SqlParameter("accid", userDetails.Rows[0]["AccountID"].ToString()));
            if (result == null)
            {
                MessageBox.Show("Something went wrong, please inform the developer\nError: ManagerID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.managerID = result.Rows[0]["ManagerID"].ToString();
        }

        //TitleBar
        private void TitleBar_Mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void TitleBar_Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Refund_FormClosed(object sender, FormClosedEventArgs e)
        {
            refund = null;
        }

        private void Feedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            feedback = null;
        }

        private void TopUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            topup = null;
        }

        private void stats_FormClosed(object sender, FormClosedEventArgs e)
        {
            stats = null;
        }
        private void setting_FormClosed(object sender, EventArgs e)
        {
            settingform = null;
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);
            CloseOtherForms.CloseAllFormsExcept(this);

            //Code
            Form confirmForm = new Form();
            using (confirmForm confirm = new confirmForm())
            {
                confirmForm.StartPosition = FormStartPosition.Manual;
                confirmForm.FormBorderStyle = FormBorderStyle.None;
                confirmForm.Opacity = .50d;
                confirmForm.BackColor = Color.Black;
                confirmForm.Size = this.Size;
                confirmForm.Location = this.Location;
                confirmForm.ShowInTaskbar = false;
                confirmForm.Show();
                confirm.Owner = confirmForm;

                confirm.ShowDialog();
                confirmForm.Dispose();
            }
        }

        private void ManagerForm_Resize(object sender, EventArgs e)
        {
            Top_GradientPanel.Invalidate();
       
        }
        

        //button
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);
            CloseOtherForms.CloseAllFormsExcept(this);

            //Code
            if (feedback == null)
            {
                feedback = new Feedback(managerID);
                feedback.FormClosed += Feedback_FormClosed;
                feedback.MdiParent = this;
                feedback.Dock = DockStyle.Fill;
                feedback.Show();
            }
            else
            {
                feedback.Activate();
            }
            
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);
            CloseOtherForms.CloseAllFormsExcept(this);

            //Code
            if (topup == null)
            {
                topup = new TopUp();
                topup.FormClosed += TopUp_FormClosed;
                topup.MdiParent = this;
                topup.Dock = DockStyle.Fill;
                topup.Show();
            }
            else
            {
                topup.Activate();
            }
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);
            CloseOtherForms.CloseAllFormsExcept(this);

            //Code
            if (settingform == null)
            {
                settingform = new ManagerProfileForm(userDetails);
                settingform.FormClosed += setting_FormClosed;
                settingform.MdiParent = this;
                settingform.Dock = DockStyle.Fill;
                settingform.Show();

            }
            else
            {
                settingform.Activate();
            }

        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);
            CloseOtherForms.CloseAllFormsExcept(this);

            //Code
            if (refund == null)
            {
                refund = new Refund(managerID);
                refund.FormClosed += Refund_FormClosed;
                refund.MdiParent = this;
                refund.Dock = DockStyle.Fill;
                refund.Show();
            }
            else
            {
                refund.Activate();
            }
            
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);
            CloseOtherForms.CloseAllFormsExcept(this);

            //Code
            if (stats == null)
            {
                stats = new ManagerStats(managerID);
                stats.FormClosed += stats_FormClosed;
                stats.MdiParent = this;
                stats.Dock = DockStyle.Fill;
                stats.Show();
            }
            else
            {
                stats.Activate();
            }
        }
    }
}
