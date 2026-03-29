using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;
using Group_Assignment.RoleCustomer;

namespace Group_Assignment.RoleChef
{
    public partial class formorder : Form
    {
        public formorder()
        {
            InitializeComponent();
        }

        private void formorder_Load(object sender, EventArgs e)
        {
            LoadTopSellingItems();
            // Display all orderids from the database to the listbox
            string query = "SELECT OrderID FROM [Order]";
            DataTable menuTable = DatabaseHelper.ExecuteQuery(query);

            if (menuTable != null)
            {
                listboxorder.Items.Clear();

                foreach (DataRow row in menuTable.Rows)
                {
                    listboxorder.Items.Add(row["OrderID"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Failed to load data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Controls settings
            this.ControlBox = false;
            btnorderedit.Enabled = false; // accessible once btnsearch is clicked
            btnorderfinish.Enabled = false; // accessible once btnedit is clicked
            btnorderitemindividual.Enabled = false; //accessible once btnedit is clicked
            btnorderitemoverall.Enabled = false; // accessible once btnedit is clicked
            txtboxquantity.Enabled = false; 
            cmborderstatus.Enabled = false; // accessible once btnorderitemindividual is triggered with conditions
            txtboxordername.Enabled = false;
            txtboxorderprice.Enabled = false;
            btnnofilter.Visible = false; // btn to undo filter, overlaps with btnfilter
            txtboxquantity.Visible = false; // accessible once btnorderitemindividual is triggered with conditions
            lblquantity.Visible = false; // same as txtboxquantity
            lblorderidinvisible.Visible = false; // as a variable that tracks the current orderid chosen
            lblcurrentmenu.Visible = false; // as a variable that tracks the current menu chosen
        }

        // Method for retrieving and displaying top ordered items in menu
        private void LoadTopSellingItems()
        {
            string queryToday = @"
        SELECT m.Name, SUM(oi.Quantity) AS TotalQuantity
        FROM OrderItem oi
        JOIN [Order] o ON oi.OrderID = o.OrderID
        JOIN Menus m ON oi.MenuID = m.MenuID
        WHERE CAST(o.[Date] AS DATE) = CAST(GETDATE() AS DATE)
        GROUP BY m.Name
        ORDER BY TotalQuantity DESC
        OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY;
    ";

            string queryOverall = @"
        SELECT m.Name, SUM(oi.Quantity) AS TotalQuantity
        FROM OrderItem oi
        JOIN [Order] o ON oi.OrderID = o.OrderID
        JOIN Menus m ON oi.MenuID = m.MenuID
        GROUP BY m.Name
        ORDER BY TotalQuantity DESC
        OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY;
    ";

            // Fetch data
            DataTable dtToday = DatabaseHelper.ExecuteQuery(queryToday);
            DataTable dtOverall = DatabaseHelper.ExecuteQuery(queryOverall);

            // Set today's top-selling labels
            Label[] todayLabels = { lbltoday1, lbltoday2, lbltoday3 };
            for (int i = 0; i < todayLabels.Length; i++)
            {
                if (dtToday != null && i < dtToday.Rows.Count)
                {
                    string name = dtToday.Rows[i]["Name"].ToString();
                    int qty = Convert.ToInt32(dtToday.Rows[i]["TotalQuantity"]);
                    todayLabels[i].Text = $"{name} ({qty})";
                }
                else
                {
                    todayLabels[i].Text = "-";
                }
            }

            // Set overall top-selling labels
            Label[] overallLabels = { lbloverall1, lbloverall2, lbloverall3 };
            for (int i = 0; i < overallLabels.Length; i++)
            {
                if (dtOverall != null && i < dtOverall.Rows.Count)
                {
                    string name = dtOverall.Rows[i]["Name"].ToString();
                    int qty = Convert.ToInt32(dtOverall.Rows[i]["TotalQuantity"]);
                    overallLabels[i].Text = $"{name} ({qty})";
                }
                else
                {
                    overallLabels[i].Text = "-";
                }
            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            // controls settings
            btnnofilter.Visible = true;
            btnfilter.Visible = false; // when btnfilter is pressed, btnfilter is invisible and btnnofilter is visible
            lblorderlist.Text = "List of orders (Today)"; // order list description

            // Filter the orderids in the listbox so that only today orders are displayed in the listbox
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "SELECT OrderID FROM [Order] where [Date] = @currentDate";
            SqlParameter param = new SqlParameter("@currentDate", currentDate);
            DataTable menuTable = DatabaseHelper.ExecuteQuery(query, param);
            

            if (menuTable != null)
            {
                listboxorder.Items.Clear();

                foreach (DataRow row in menuTable.Rows)
                {
                    listboxorder.Items.Add(row["OrderID"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Failed to load data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnofilter_Click(object sender, EventArgs e)
        {
            // undo btnfilter

            // controls settings
            btnnofilter.Visible = false;
            btnfilter.Visible = true; // same concept as btnfilter
            lblorderlist.Text = "List of orders (All)"; // order list description

            string query = "SELECT OrderID FROM [Order]";
            DataTable menuTable = DatabaseHelper.ExecuteQuery(query);

            if (menuTable != null)
            {
                listboxorder.Items.Clear(); // optional: clear existing items

                foreach (DataRow row in menuTable.Rows)
                {
                    listboxorder.Items.Add(row["OrderID"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Failed to load data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnordersearch_Click(object sender, EventArgs e)
        {
            // displaying order details based on the orderid
            string selected_order = listboxorder.SelectedItem?.ToString();
            listboxorderitem.Items.Clear();

            if (selected_order == null)
            {
                MessageBox.Show("Choose an orderid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // controls settings
                lblorderidinvisible.Text = selected_order; // changing the current orderid to what the user chose
                btnorderedit.Enabled = true;

                // instantiating an order class object based on the orderid
                Order currentorderid = new Order(selected_order);
                txtboxordername.Text = currentorderid.CustomerName;
                txtboxorderprice.Text = Convert.ToDecimal(currentorderid.TotalOrderFee).ToString();
                cmborderstatus.SelectedItem = currentorderid.Status;

                // Adding every orderitem's menuname of the current orderid to the listbox
                foreach (OrderItem item in currentorderid.OrderItems)
                {
                    listboxorderitem.Items.Add(item.MenuName);
                }
            }
        }

        private void btnorderitemoverall_Click(object sender, EventArgs e)
        {
            // Undo btnorderitemindividual
            lblcurrentmenu.Text = "..."; // as a variable that keeps track current menu

            // instantiating an order class object based on the orderid
            Order currentorderid = new Order(lblorderidinvisible.Text); 
            txtboxordername.Text = currentorderid.CustomerName;
            txtboxorderprice.Text = currentorderid.TotalOrderFee.ToString();
            cmborderstatus.SelectedItem = currentorderid.Status;

            // controls settings
            lblquantity.Visible = false;
            txtboxquantity.Visible = false; // making quantity invisible again
            cmborderstatus.Enabled = false; // disabling edit, as the overall status of the order is dynamically coded
        }

        private void btnorderitemindividual_Click(object sender, EventArgs e)
        {
            // based on what menuname the user selects in the listbox display quantity, price, and status
            string selected_orderitem = listboxorderitem.SelectedItem?.ToString();
 
            if (selected_orderitem == null)
            {
                MessageBox.Show("Choose an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // checks if the current mode is edit mode
                if (lblordermode.Text == "(Edit mode)")
                {
                    cmborderstatus.Enabled = true; // if edit mode, allow editing status

                }
                
                // controls settings
                lblcurrentmenu.Text = selected_orderitem; // changing the lbl text to what menu the user chose
                lblquantity.Visible = true; // allowing the user to see quantity label and txtbox
                txtboxquantity.Visible = true;

                // instantiating an order class object based on the orderid
                Order currentorderid = new Order(lblorderidinvisible.Text);
                decimal totalprice = 0;


                // loops through every orderitem in current order
                foreach (OrderItem item in currentorderid.OrderItems)
                {
                    if (selected_orderitem == item.MenuName)
                    {
                        // displays status of chosen menu
                        Menus selected_menu_price = new Menus(selected_orderitem);
                        txtboxquantity.Text = item.Quantity.ToString();
                        cmborderstatus.SelectedItem = item.Status;
                        totalprice = Convert.ToDecimal(selected_menu_price.Price) * Convert.ToDecimal(item.Quantity);
                        txtboxorderprice.Text = totalprice.ToString();
                    }
                }

            }
        }

        private void btnorderedit_Click(object sender, EventArgs e)
        {
            // controls settings
            btnorderitemindividual.Enabled = true;
            btnorderitemoverall.Enabled = true;
            btnorderfinish.Enabled = true;
            btnordersearch.Enabled = false;
            lblordermode.Text = "(Edit mode)"; // changing mode to edit mode
            btnorderedit.Enabled = false;

        }

        private void cmborderstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // updating status of orderitem when user changes the combobox selecteditem
            string currentmenuitem = lblcurrentmenu.Text;

            // instantiating an order class object based on the orderid
            Order currentorderid = new Order(lblorderidinvisible.Text);

            // looping through all orderitem in current orderid
            foreach (OrderItem item in currentorderid.OrderItems)
            {
                // checks if current orderitem's menu name is equivalent to the menu name tracker
                if (currentmenuitem == item.MenuName)
                {
                    // checks if the combobox is null, if not updates the status
                    if (!(cmborderstatus.SelectedItem == null))
                    {
                        string oldStatus = item.Status; // store status before changed
                        item.UpdateStatus(cmborderstatus.SelectedItem.ToString()); // update status in database
                        currentorderid.EvaluateAndSetStatus(); // algorithm that checks if any orderitem status failed/ in progress then order status is failed/ in progress
                        currentorderid.AdjustOrderTotalOnStatusChange(item.OrderItemID, oldStatus, cmborderstatus.SelectedItem.ToString()); // if from any status to failed, deduct totalorderfee, if from failed to any status, restore totalorderfee
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }

        private void btnorderfinish_Click(object sender, EventArgs e)
        {
            // controls settings
            listboxorderitem.Items.Clear();
            txtboxordername.Text = string.Empty;
            txtboxorderprice.Text = string.Empty;
            txtboxquantity.Text = string.Empty; // clearing the displays
            txtboxquantity.Visible = false;
            lblquantity.Visible = false;
            lblordermode.Text = "(Observation mode)"; // reverting back to observation mode
            btnorderitemindividual.Enabled = false;
            btnorderitemoverall.Enabled = false;    
            btnordersearch.Enabled = true;
            btnorderfinish.Enabled = false;
            cmborderstatus.SelectedItem = null;
            cmborderstatus.Enabled = false; // disabling combobox after finish
        }
    }
}
