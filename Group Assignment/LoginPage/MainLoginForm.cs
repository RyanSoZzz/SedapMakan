using Group_Assignment.RoleCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.LoginPage
{
    public partial class MainLoginForm : Form
    {
        public Point mouseLocation;
        private Form activeForm = null;
        CustomMethod customMethod; //Inside events.cs
        public DataTable UserDetails { get; private set; }

        public MainLoginForm()
        {
            InitializeComponent();

            // Initial page load
            customMethod = new CustomMethod();
            customMethod.openChildForm(new LoginForm(), activeForm, this.formPanel, ChildForm_changeFormEvent, ChildForm_finishedLoginEvent);
        }


        public void setUserDetails(DataTable userData)
        {
            UserDetails = userData;
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
        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Child event handler
        private void ChildForm_changeFormEvent(object sender, FormEventArgs e)
        {
            // Check which form is active and open the corresponding form
            if (e.FormToShow != null)
            {
                customMethod.openChildForm(e.FormToShow, activeForm, this.formPanel, ChildForm_changeFormEvent, ChildForm_finishedLoginEvent);
            }
        }

        private void ChildForm_finishedLoginEvent(object sender, DataTableEventArgs e)
        {
            // Handle the finished login event and pass the user details to the next form
            UserDetails = e.DataTableToShow;
            this.DialogResult = DialogResult.OK; // Set the dialog result to OK to indicate successful login
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
