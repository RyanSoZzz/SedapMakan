using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.roleadmin.Classes;

namespace Group_Assignment.roleadmin.Forms
{
    public partial class ChefReport : Form
    {
        private ChefSales _chefInfo = null;
        public ChefReport(ChefSales Info)
        {
            InitializeComponent();
            _chefInfo = Info;
        }

        private void ChefReport_Load(object sender, EventArgs e)
        {
            txtboxID.Text = _chefInfo.ChefID;
            txtboxName.Text = _chefInfo.ChefName;
            txtboxNumOfSales.Text = _chefInfo.NumOfSales;
            txtboxTotalSales.Text = "RM " + _chefInfo.TotalSales;
            txtboxYearlySales.Text = "RM " + _chefInfo.YearlySales;
            txtboxMonthlySales.Text = "RM " + _chefInfo.MonthlySales;
            txtboxSalary.Text = "RM " + _chefInfo.Salary;
        }
    }
}
