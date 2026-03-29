using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.LoginPage;
using Group_Assignment.roleadmin.Classes;
using Group_Assignment.RoleChef;

namespace Group_Assignment.roleadmin.Forms
{
    public partial class adminForm : Form
    {
        //forms initialize
        formDashboardAdmin dashboard;
        adminprofile profileAdmin;
        formUsersAdmin usersAdmin;
        formChefReportAdmin chefReportAdmin;
        formCustomerReportAdmin customerReportAdmin;

        private Button currentBtn;
        private Panel leftBorderBtn;
        private ButtonStyle.Highlight highlight;
        //private Users admin = new Users();
        private Form activeForm = null;
        private CustomMethod customMethod;
        private DataTable userDetails;
        string adminId;

        public adminForm(DataTable UserDetails)
        {
            InitializeComponent();
            highlight = new ButtonStyle.Highlight(laypanMenu);

            userDetails = UserDetails;
            customMethod = new CustomMethod();
            customMethod.openChildForm(new adminprofile(userDetails), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }
        private void adminForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Welcome to the system, " + userDetails.Rows[0]["Name"].ToString(); ;
        }

        //Menu Buttons
        private void btnDashboardAdmin_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new formDashboardAdmin(), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        private void ChildForm_changeFormEvent(object sender, FormEventArgs e)
        {
            // Check which form is active and open the corresponding form
            if (e.FormToShow != null)
            {
                customMethod.openChildForm(e.FormToShow, activeForm, this.formPanel, ChildForm_changeFormEvent);
            }
        }

        private void btnAnalyticsAdmin_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new formUsersAdmin(), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        //Report Container & Buttons
        bool menuExpand = false;
            //Panel Transition
        private void menuTransitionAdmin_Tick(object sender, EventArgs e)
        {
            //To expand the button when triggered
            if (!menuExpand)
            {
                flowReportContainerAdmin.Height += 10;
                if (flowReportContainerAdmin.Height >= 150)
                {
                    menuTransitionAdmin.Stop();
                    menuExpand = true;
                }
            }
            //To shrink the button when triggered
            else
            {
                flowReportContainerAdmin.Height -= 10;
                if (flowReportContainerAdmin.Height <= 50)
                {
                    menuTransitionAdmin.Stop();
                    menuExpand = false;
                }
            }
        }
        private void btnReportContainerAdmin_Click(object sender, EventArgs e)
        {
            //trigger submenu transition
            menuTransitionAdmin.Start();
        }

        //Chef Report button
        private void btnChefAdmin_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new formChefReportAdmin(), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        //Customer report button
        private void btnCustomerAdmin_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new formCustomerReportAdmin(), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        //settings/profile button
        private void btnSettingsAdmin_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new adminprofile(userDetails), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        //logout button
        public void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
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
    }
}
