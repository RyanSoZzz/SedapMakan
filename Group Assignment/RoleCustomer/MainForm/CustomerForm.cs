using Group_Assignment.LoginPage;
using Group_Assignment.RoleCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    public partial class CustomerForm : Form
    {

        private Button currentBtn;
        private ButtonStyle.Highlight highlight;
        private Form activeForm = null;
        public Point mouseLocation;
        private CustomMethod customMethod;
        private DataTable userDetails;
        string customerId;

        public CustomerForm(DataTable UserDetails)
        {
            InitializeComponent();
            highlight = new ButtonStyle.Highlight(laypanMenu);

            // Initial page load
            userDetails = UserDetails;
            customMethod = new CustomMethod();
            customerId = EWalletTopUp.getCustomerIDFromAccID(Convert.ToInt32(userDetails.Rows[0]["AccountID"]));
            customMethod.openChildForm(new MenuForm(UserDetails), activeForm, this.formPanel, ChildForm_changeFormEvent);
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
        private void btnMenulist_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new MenuForm(userDetails), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            string orderid = EWalletTopUp.getInProgressOrderIDFromAccID(Convert.ToInt32(userDetails.Rows[0]["AccountID"]));
            customMethod.openChildForm(new YourOrderForm(orderid), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new HistoryForm(customerId), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //Code
            customMethod.openChildForm(new SettingForm(userDetails), activeForm, this.formPanel, ChildForm_changeFormEvent);
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            //Animation
            currentBtn = highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen, currentBtn);

            //SQL
            using (SqlConnection com = new SqlConnection(Properties.Settings.Default.IOOP_DataBase))
            {
                try
                {
                    com.Open();
                    string query = "SELECT * FROM Account";
                    SqlCommand cmd = new SqlCommand(query, com);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    //Display data in console (for debugging purposes)
                    foreach (DataRow row in dt.Rows)
                    {
                        for (int i = 0; i < row.ItemArray.Length; i++)
                        {
                            Console.WriteLine(row[i].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }

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
        private void CustomerForm_Resize(object sender, EventArgs e)
        {
            Top_GradientPanel.Invalidate();
        }

        //Changing Form
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
