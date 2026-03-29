using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Group_Assignment.RoleCustomer;
using Group_Assignment.LoginPage;

namespace Group_Assignment.RoleChef
{
    public partial class ChefForm : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private ButtonStyle.Highlight highlight;
        public Point mouseLocation;
        formmenu menu;
        formprofile profile;
        formorder order;
        private Form activeForm = null;
        private CustomMethod customMethod;
        private DataTable userDetails;
        string chefId;

        public ChefForm(DataTable UserDetails)
        {
            InitializeComponent();
            highlight = new ButtonStyle.Highlight(laypanMenu);

            this.Resize += ChefForm_Resize;

            // Initial Page load
            userDetails = UserDetails;
            customMethod = new CustomMethod();
            customMethod.openChildForm(new formmenu(), activeForm, this.formPanel, ChildForm_changeFormEvent);
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

        //Button
        private void btnSetting_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new formprofile(userDetails), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        private void btnMenulist_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
               customMethod.openChildForm(new formmenu(), activeForm, this.formPanel, ChildForm_changeFormEvent);     
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new formorder(), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

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

        private void ChefForm_Resize(object sender, EventArgs e)
        {
            Top_GradientPanel.Invalidate();
            validateMdiSize();
        }

        private void validateMdiSize()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Dock = DockStyle.Fill;
                this.ActiveMdiChild.PerformLayout();
            }
        }

        private void ChildForm_changeFormEvent(object sender, FormEventArgs e)
        {
            // Check which form is active and open the corresponding form
            if (e.FormToShow != null)
            {
                customMethod.openChildForm(e.FormToShow, activeForm, this.formPanel, ChildForm_changeFormEvent);
            }
        }
    }
  
}
