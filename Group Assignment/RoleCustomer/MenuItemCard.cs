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
using System.Windows.Forms;

namespace Group_Assignment.RoleCustomer
{
    public partial class MenuItemCard : UserControl, IFormWithAllOrderEvents
    {
        public event EventHandler<DataTableEventArgs> addOrderItem;
        public event EventHandler<DataRowEventArgs> statusChangedOrderItem;
        public string MenuID { get; private set; }
        public string NameFood { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }
        public string Availability { get; private set; }
        public string Duration { get; private set; }
        public string ImageUrl { get; private set; }
        DataRow itemDetail;

        public MenuItemCard(DataRow itemDetail)
        {
            //Get specific order item details from the database and display them in the card
            InitializeComponent();
            AttachClickEventToAllControls(this);

            try
            {
                if (itemDetail == null || itemDetail.Table.Columns.Count == 0)
                {
                    throw new ArgumentException("Item details cannot be null or empty.");
                }
                else
                {
                    this.itemDetail = itemDetail;
                    this.MenuID = SafeToString(itemDetail["MenuID"]);
                    this.NameFood = SafeToString(itemDetail["Name"]);
                    this.Description = SafeToString(itemDetail["Description"]);
                    this.Price = SafeToDecimal(itemDetail["Price"]);
                    this.Category = SafeToString(itemDetail["Category"]);
                    this.Availability = SafeToString(itemDetail["Availability"]);
                    this.Duration = SafeToString(itemDetail["Duration"]);
                    this.ImageUrl = SafeToString(itemDetail["Image_url"]);
                    loadUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SafeToString(object value) => value != DBNull.Value ? value.ToString() : null;
        private decimal SafeToDecimal(object value) => value != DBNull.Value ? Convert.ToDecimal(value) : 0m;
        public void loadUI()
        {
            lblName.Text = this.NameFood;
            string imagePath = Path.Combine(Application.StartupPath, "Images", this.ImageUrl);
            pbItemImage.Image = Image.FromFile(imagePath);
            pbItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void AttachClickEventToAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += Control_Click;

                // Recursively attach to child controls
                if (control.HasChildren)
                {
                    AttachClickEventToAllControls(control);
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            //Invoke the event with a sample DataTable (you can modify this as needed)
            statusChangedOrderItem?.Invoke(this, new DataRowEventArgs(itemDetail)); // Example DataTable, replace with actual data
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
