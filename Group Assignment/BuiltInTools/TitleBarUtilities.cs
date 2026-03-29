using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Group_Assignment
{
    public partial class TitleBarUtilities : UserControl
    {
        private Form mainForm;
        public TitleBarUtilities()
        {
            InitializeComponent();
        }

        private void butMinimize_Click(object sender, EventArgs e)
        {
            mainForm = this.FindForm();
            mainForm.WindowState = FormWindowState.Minimized;
        }

        private void butMaximize_Click(object sender, EventArgs e)
        {
            mainForm = this.FindForm();
            if (mainForm.WindowState == FormWindowState.Normal)
            {
                mainForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                mainForm.WindowState = FormWindowState.Normal;
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
