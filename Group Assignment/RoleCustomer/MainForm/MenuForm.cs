using Group_Assignment.LoginPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Group_Assignment.RoleCustomer
{
    public partial class MenuForm : Form
    {
        DataTable userDetails, orderItems;
        Order theOrder;
        DataRow currentSelectedItem;

        string customerId;
        string[] sortbyQueries = 
        {
            "SELECT * FROM Menus WHERE Availability = 'Available' ORDER BY [Name] ASC;",
            "SELECT * FROM Menus WHERE Availability = 'Available' ORDER BY [Name] DESC;",
            "SELECT * FROM Menus WHERE Availability = 'Available' ORDER BY Price ASC;",
            "SELECT * FROM Menus WHERE Availability = 'Available' ORDER BY Price DESC;",
            "SELECT * FROM Menus WHERE Availability = 'Available' ORDER BY Category ASC;",
            "SELECT * FROM Menus WHERE Availability = 'Available' ORDER BY Category DESC;",
            "SELECT * FROM Menus WHERE Availability = 'Available' ORDER BY Duration ASC;",
            "SELECT * FROM Menus WHERE Availability = 'Available' ORDER BY Duration DESC;"
        };

        List<MenuItemCard> menuItemCards = new List<MenuItemCard>();

        public MenuForm(DataTable UserDetails)
        {
            InitializeComponent();
            userDetails = UserDetails;

            //Hide Scrollbar
            pnlItemDetails.VerticalScroll.Visible = false;
            pnlItemDetails.HorizontalScroll.Visible = false;
            laypanMenu.VerticalScroll.Visible = false;
            laypanMenu.HorizontalScroll.Visible = false;

            //Load menu items from the database and display them in the layout panel
            customerId = EWalletTopUp.getCustomerIDFromAccID(Convert.ToInt32(userDetails.Rows[0]["AccountID"]));
            orderItems = new DataTable();
            orderItems.Columns.Add("MenuID");
            orderItems.Columns.Add("Quantity", typeof(int));
            loadPage();
        }

        private int loadPage()
        {
            int sortbyIndex = cbSortBy.SelectedIndex;
            if (sortbyIndex < 0)
                sortbyIndex = 0; // Default to ascending order if no selection is made
            DataTable result = DatabaseHelper.ExecuteQuery(sortbyQueries[sortbyIndex]);
            try
            {
                if (result != null && result.Rows.Count > 0)
                {
                    laypanMenu.Controls.Clear(); // Clear existing controls in the layout panel
                    foreach (DataRow row in result.Rows)
                    {
                        MenuItemCard menuItemCard = new MenuItemCard(row);
                        laypanMenu.Controls.Add(menuItemCard);
                        if (menuItemCard is IFormWithAllOrderEvents formWithAllOrderEvents)
                            formWithAllOrderEvents.statusChangedOrderItem += OrderItem_statusChangedOrderItem; // Subscribe to the event
                        menuItemCards.Add(menuItemCard);
                    }
                    return 0; // Successfully loaded menu items
                }
                else
                {
                    MessageBox.Show("No menu items available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Error occurred while loading menu items
            }
        }

        private void loadViewItem(DataRow itemDetails)
        {
            lblInsufficientBalance.Visible = false;
            if (itemDetails == null || itemDetails.Table.Columns.Count == 0)
            {
                MessageBox.Show("Item details cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.lblNameFood.Text = itemDetails["Name"].ToString();
                this.lblDescription.Text = itemDetails["Description"].ToString();
                this.lblPrice.Text = "Price: " + itemDetails["Price"].ToString();
                this.lblCategory.Text = "Category: " + itemDetails["Category"].ToString();
                this.lblDuration.Text = "Duration: " + itemDetails["Duration"].ToString() + "mins";
                this.lblAvailability.Text = itemDetails["Availability"].ToString();

                string imagePath = Path.Combine(Application.StartupPath, "Images", itemDetails["Image_url"].ToString());
                if (File.Exists(imagePath))
                {
                    pbItemImage.Image = Image.FromFile(imagePath);
                    pbItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbItemImage.Image = null;
                }
            }
        }

        private bool checkIfBalanceIsEnough(bool sendWarning = false)
        {
            if (currentSelectedItem == null || currentSelectedItem.Table.Columns.Count == 0)
                {
                    MessageBox.Show("No item selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            float price = Convert.ToInt32(currentSelectedItem["Price"]);
            int quantity = int.TryParse(txtQuantity.Text, out quantity) ? quantity : 1; // Default to 1 if parsing fails
            float totalCost = price * quantity;
            float customerBalance = EWalletTopUp.getBalanceFromCustomerID(customerId);
            if ((customerBalance - totalCost) < 0)
            {
                if (sendWarning)
                    MessageBox.Show("Insufficient balance to place this order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (sendWarning)
                MessageBox.Show("Balance is sufficient for this order.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblInsufficientBalance.Visible = false;
            try
            {
                if (currentSelectedItem != null)
                {
                    if (btnOrder.Text == "Place Order")
                    {
                        btnOrder.Text = "Confirm ✅";
                        return;
                    } else
                    {
                        btnOrder.Text = "Place Order";
                    }

                    if (txtQuantity.Text == string.Empty) { btnOrder.Text = "Place Order"; return; }

                    if (!(int.TryParse(txtQuantity.Text, out int quantity)) && quantity < 0)
                    {
                        MessageBox.Show("Order failed: Quantity must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQuantity.Text = "1"; // Reset to default value
                        return; // Valid quantity, proceed with order
                    }

                    if (!checkIfBalanceIsEnough())
                    {
                        txtQuantity.Text = "1"; // Reset to default value
                        lblInsufficientBalance.Visible = true;
                        return; // Insufficient balance, do not proceed with order
                    }

                    //Deduct the customer balance
                    float price = Convert.ToSingle(currentSelectedItem["Price"]);
                    float totalCost = price * quantity;
                    if (EWalletTopUp.updateBalanceByEWAlletID
                        (
                        EWalletTopUp.getEWalletIDfromCustomerID(customerId),
                        EWalletTopUp.getBalanceFromCustomerID(customerId) - totalCost
                        ) != 0)
                    {
                        MessageBox.Show("Failed to update the balance, the order is cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    orderItems.Rows.Add(currentSelectedItem["MenuID"].ToString(), quantity);
                    if (orderItems.Rows.Count > 0)
                    {
                        if (theOrder == null)
                        {
                            theOrder = new Order(
                            customerId,
                            orderItems);
                        }
                        else
                        {
                            theOrder.createNewOrderItem(
                                theOrder.getInProgressOrderIDFromCustID(customerId),
                                orderItems);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            lblInsufficientBalance.Visible = false;
            int cursorPosition;
            try
            {

                if (txtQuantity.Text.Contains(" ") && txtQuantity.Text != "1")
                {
                    cursorPosition = txtQuantity.SelectionStart;

                    //Remove spaces from the username
                    txtQuantity.Text = txtQuantity.Text.Replace(" ", "");

                    //Restore the cursor position
                    txtQuantity.SelectionStart = (Math.Max(0, cursorPosition - 1));
                }

                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                    if (quantity < 1)
                    {
                        txtQuantity.Text = "1"; // Reset to 1 if out of range
                    }
                    else if (quantity > 999)
                    {
                        txtQuantity.Text = "999"; // Limit to 3 digits
                        txtQuantity.SelectionStart = txtQuantity.Text.Length; // Move cursor to end
                    }
                    txtQuantity.ForeColor = Color.Black; // Set text color to black if valid number
                }
                else
                {
                    if (txtQuantity.Text.Length == 1)
                    {
                        txtQuantity.Text = "1";
                    }
                    else if (txtQuantity.Text.Length > 1)
                    {
                        cursorPosition = txtQuantity.SelectionStart;
                        txtQuantity.Text = txtQuantity.Text.Substring(0, txtQuantity.Text.Length - 1); // Remove last character if not a valid number
                        txtQuantity.SelectionStart = (Math.Max(0, cursorPosition - 1));
                    }

                    if (txtQuantity.Text.Length > 3)
                    {
                        txtQuantity.Text = txtQuantity.Text.Substring(0, 3); // Limit to 3 digits
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing quantity: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Text = "1"; // Reset to default value
            }
        }

        private void btnOrder_MouseEnter(object sender, EventArgs e)
        {
            btnOrder.ForeColor = Color.FromArgb(25,25,25); // Change text color to light green on mouse enter
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.ForeColor = Color.White; // Reset text color to white on mouse leave
        }

        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPage();
        }

        private void OrderItem_statusChangedOrderItem(object sender, DataRowEventArgs e)
        {
            DataRow data = e.DataRowToShow;
            btnOrder.Text = "Place Order";

            if (data == null || data.Table.Columns.Count == 0)
            {
                MessageBox.Show("Selected item details cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentSelectedItem = data;
            loadViewItem(data);
        }
    }
}
