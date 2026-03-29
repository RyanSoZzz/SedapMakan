using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.LoginPage
{
    public partial class ChooseProfileForm : Form, IFormWithAllLoginEvents
    {
        public event EventHandler<DataTableEventArgs> finishedLoginEvent;
        private DataTable userDetails;

        public ChooseProfileForm(DataTable UserDetails)
        {
            InitializeComponent();

            //Initialize the page
            this.AcceptButton = btnChoose; // Set the default button to btnChoose
            userDetails = UserDetails;
            addOptions(userDetails.Rows, userDetails.Rows.Count);
        }

        private void addOptions(DataRowCollection rolenames, int cycle)
        {
            foreach (DataRow rolename in rolenames)
            {
                RadioButton newRB = new RadioButton
                {
                    Text = rolename["RoleName"].ToString(),
                    Name = "rb" + rolename["RoleID"].ToString(),
                    AutoSize = true,
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Dock = DockStyle.Top,
                    Font = new Font("Segoe UI", 7.8f, FontStyle.Regular),
                    Parent = pnlProfile
                };
                newRB.BringToFront();
                newRB.CheckedChanged += Options_CheckedChanged;
            }
        }

        private void Options_CheckedChanged(object sender, EventArgs e)
        {
            lblChooseOne.Visible = false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlProfile.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    if (rb.Name != null && rb.Name.StartsWith("rb"))
                    {
                        DataTable userSpecific = userDetails.Clone();
                        foreach (DataRow row in userDetails.Rows)
                        {
                            if (row["RoleID"].ToString() == rb.Name.Substring(2)) // Extract RoleID from the RadioButton name
                            {
                                userSpecific.ImportRow(row);
                                break; // Assuming RoleID is unique, we can break after finding the match
                            }
                        }
                        finishedLoginEvent?.Invoke(this, new DataTableEventArgs(userSpecific));
                        return;
                    }
                }
            }
            lblChooseOne.Visible = true;
            return;
        }

        //Button Effects
        private void btnChoose_MouseEnter(object sender, EventArgs e)
        {
            btnChoose.ForeColor = Color.Black;
        }

        private void btnChoose_MouseLeave(object sender, EventArgs e)
        {
            btnChoose.ForeColor = Color.Lime;
        }
    }
}
