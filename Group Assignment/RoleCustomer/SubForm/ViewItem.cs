using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.RoleCustomer
{
    public partial class ViewItem : UserControl
    {
        private List<OrderItemBlock> orderItemBlocks = new List<OrderItemBlock>();
        Order theOrder;
        public ViewItem(Order TheOrder)
        {
            InitializeComponent();
            theOrder = TheOrder;
            refreshYourOrderForm();
        }

        // Add the order items displayed in the panel
        private void refreshYourOrderForm()
        {
            if (theOrder.OrderID == null)
                return; // No order ID provided, nothing to refresh
            lblOrderID.Text = "OrderID: " + theOrder.OrderID;

            if (theOrder != null)
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

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.White;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor= Color.FromArgb(25,25,25);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
