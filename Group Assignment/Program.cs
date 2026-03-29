using Group_Assignment.LoginPage;
using Group_Assignment.roleadmin.Forms;
using Group_Assignment.RoleChef;
using Group_Assignment.RoleManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool userNotMatched = true;

            while (userNotMatched)
            {
                MainLoginForm loginForm = new MainLoginForm();

                if (loginForm.ShowDialog() == DialogResult.OK) // modal, waits for result
                {
                    DataTable userDetails = loginForm.UserDetails;
                    if (userDetails != null && userDetails.Rows.Count > 0)
                    {
                        switch (userDetails.Rows[0]["RoleID"].ToString())
                        {
                            case "R001":
                                MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Run(new adminForm(userDetails));
                                break;
                            case "R002":
                                MessageBox.Show("Welcome, Manager!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Run(new ManagerForm(userDetails));
                                break;
                            case "R003":
                                MessageBox.Show("Welcome, Chef!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Run(new ChefForm(userDetails));
                                break;
                            case "R004":
                                MessageBox.Show("Welcome, Customer!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Run(new CustomerForm(userDetails));
                                break;
                            default:
                                MessageBox.Show("Login failed or no user details found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                userNotMatched = true;
                                break;
                        }
                    }
                    if (userNotMatched)
                        return;
                    userNotMatched = false; // Set to true if a valid user is matched
                }
                else
                {
                    // If the user clicks Cancel or closes the login form
                    break;
                }
            }
        }
    }
}
