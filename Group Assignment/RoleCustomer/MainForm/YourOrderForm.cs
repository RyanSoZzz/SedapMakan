using Group_Assignment.LoginPage;
using Group_Assignment.RoleCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    public partial class YourOrderForm : Form
    {
        private List<OrderItemBlock> orderItemBlocks = new List<OrderItemBlock>();
        private string orderId = null;
        Order theOrder;
        public YourOrderForm(string OrderID)
        {
            InitializeComponent();
            orderId = OrderID;
            refreshYourOrderForm();
        }

        // Add the order items displayed in the panel
        private void refreshYourOrderForm() 
        {
            if (orderId == null)
                return; // No order ID provided, nothing to refresh
            lblOrderID.Text = "OrderID: " + orderId;

            if (theOrder != null)
            {
                theOrder = null; // Clear the previous order
            } else
            {
                theOrder = new Order(orderId);
            }

            if (theOrder != null && theOrder.Status == "In Progress")
            {
                foreach (OrderItem orderItem in theOrder.OrderItems)
                {
                    string orderId = orderItem.OrderID;
                    string orderItemId = orderItem.OrderItemID;
                    string itemName = orderItem.MenuName;
                    string status = orderItem.Status;
                    int itemQuantity = orderItem.Quantity;
                    float pricePerItem = orderItem.PricePerItem;

                    OrderItemBlock item = new OrderItemBlock(orderId, orderItemId, itemName, status, itemQuantity, pricePerItem);
                    item.Parent = pnlYourOrder; // Set the parent to the container panel
                    item.Dock = DockStyle.Top; // Set the docking style to fill the panel horizontally
                    orderItemBlocks.Add(item);
                }
            }
        }

        private void pnlYourOrder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
