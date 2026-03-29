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
using Group_Assignment.RoleChef;

namespace Group_Assignment.roleadmin.Forms
{
    public partial class formChefReportAdmin : Form
    {
        public formChefReportAdmin()
        {
            InitializeComponent();
        }

        private void formChefReportAdmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            comboxFilterChef.SelectedIndex = 0;
            comboxFilterChef.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridSales.DataSource = ChefSales.getSales(comboxFilterChef.SelectedItem.ToString(), "All");
        }
        private void formChefReportAdmin_Activated(object sender, EventArgs e)
        {
            //Load Stats
            lblTotalChefResult.Text = Users.getTotalUser("chef", "all");
            txtBoxCategoryFilter.Text = "";
            loadTable(comboxFilterChef.SelectedItem.ToString(), txtBoxCategoryFilter.Text);

        }

        private void btnFilterChef_Click(object sender, EventArgs e)
        {

            loadTable(comboxFilterChef.SelectedItem.ToString(), txtBoxCategoryFilter.Text);
        }

        private void btnClearChef_Click(object sender, EventArgs e)
        {
            txtBoxCategoryFilter.Text = "";
            comboxFilterChef.SelectedIndex = 0;
            loadTable(comboxFilterChef.SelectedItem.ToString(), txtBoxCategoryFilter.Text);
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            //Open Menu
            formmenu formmenu = new formmenu();
            formmenu.titlebarformmenu.Visible = true;
            formmenu.titlebarformmenu.Enabled = true;
            formmenu.ShowDialog();
            formmenu.titlebarformmenu.Enabled = false;
            formmenu.titlebarformmenu.Visible = false;
        }

        private void btnChefReport_Click(object sender, EventArgs e)
        {
            //Generates Report based on Inputted id
            ChefSales chef = new ChefSales();
            chef = ChefSales.getChef(txtboxSearchChef.Text);
            if (chef != null)
            {
                ChefReport chefReport = new ChefReport(chef);
                chefReport.ShowDialog();
            }
        }

        private void loadTable(string timeFilter, string catFilter)
        {
            int numOfOrders = 0;
            if (catFilter == null || catFilter == "All" || catFilter == "Any" || catFilter == "")
            {
                dataGridSales.DataSource = ChefSales.getSales(timeFilter, "All");
                numOfOrders = ChefSales.getSales(timeFilter, catFilter).Rows.Count;
            }
            else if (catFilter != null)
            {
                dataGridSales.DataSource = ChefSales.getSales(timeFilter, catFilter);
                numOfOrders = ChefSales.getSales(timeFilter, catFilter).Rows.Count;
            }
            if (numOfOrders <= 0)
                MessageBox.Show("No Orders Found in the Selected Filter");
            lblSalesResult.Text = numOfOrders.ToString();
        }
    }
}
