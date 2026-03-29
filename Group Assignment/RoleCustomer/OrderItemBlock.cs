using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group_Assignment.RoleCustomer
{
    public partial class OrderItemBlock : UserControl
    {

        public string OrderID { get; set; } = "N/A";
        public string OrderItemID { get; set; } = "N/A";
        public string ItemName { get; set; } = "N/A";
        public string Status { get; set; } = "N/A";
        public int ItemQuantity { get; set; } = 0;
        public float PricePerItem { get; set; } = 0.0f;
        public OrderItemBlock(string orderId, string orderItemId, string itemName, string status, int itemQuantity, float pricePerItem)
        {
            InitializeComponent();
            OrderID = orderId;
            OrderItemID = orderItemId;
            ItemName = itemName;
            Status = status;
            ItemQuantity = itemQuantity;
            PricePerItem = pricePerItem;
            updateUI();
        }

        public OrderItemBlock()
        {
            InitializeComponent();
            updateUI();
        }

        public void updateUI()
        {
            lblName.Text = ItemName;
            lblOrderItemID.Text = OrderItemID;
            lblStatus.Text = "Status: " + Status;
            lblItemQuantitiy.Text = "Quantitiy =" + ItemQuantity.ToString();
            lblPrice.Text = "Price = " + (PricePerItem * ItemQuantity).ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("ms-MY"))
                + $"  ({PricePerItem.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("ms-MY"))}/each)";
        }
    }
}
