using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Assignment.RoleCustomer;

namespace Group_Assignment.RoleChef
{
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void formmenu_Load(object sender, EventArgs e)
        {
            // displaying all menus in listbox
            this.ControlBox = false;
            string query = "SELECT Name FROM Menus";
            DataTable menuTable = DatabaseHelper.ExecuteQuery(query);

            if (menuTable != null)
            {
                lstboxmenu.Items.Clear(); // optional: clear existing items

                foreach (DataRow row in menuTable.Rows)
                {
                    lstboxmenu.Items.Add(row["Name"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Failed to load menu data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // controls settings
            btnfinishmenu.Enabled = false; // accessible once btneditmenu is clicked
            btneditmenu.Enabled = false; // accessible once btnsearchmenu is clicked
            btnsearchmenu.Focus();
            btnbrowse.Visible = false; // accessible once edit button is pressed 
            btndelete.Visible = false; // same as btnbrowse
            lblmenuid.Visible = false; // tracker of current menu id
        }

        private void btnaddmenu_Click(object sender, EventArgs e)
        {
            // menu adding to the database
            // controls settings
            textboxmenuname.ReadOnly = false;
            txtboxcat.ReadOnly = false;
            txtboxavailable.ReadOnly = false;
            txtboxmenudesc.ReadOnly = false;
            txtboxmenuprice.ReadOnly = false;
            txtboxmenutime.ReadOnly = false; // enabling textbox typing
            textboxmenuname.Text = "";
            txtboxcat.Text = "";
            txtboxavailable.Text = "";
            txtboxmenudesc.Text = "";
            txtboxmenuprice.Text = "";
            txtboxmenutime.Text = ""; // clearing displays
            picboxmenu.Image = null;
            btnfinishmenu.Enabled = true;
            btneditmenu.Enabled = false;
            btnsearchmenu.Enabled = false;
            btnbrowse.Visible = true;
            btnaddmenu.Enabled = false;
            lblmenumode.Text = "(Insert mode)"; // changing mode to insert mode
        }

        private void btnsearchmenu_Click(object sender, EventArgs e)
        {
            // displaying menu details
            string selected_menu = lstboxmenu.SelectedItem?.ToString();

            if (selected_menu == null)
            {
                MessageBox.Show("Choose a food from the menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btneditmenu.Enabled = true;
                // instantiating menu class object and displaying details based on the selected menu
                Menus SearchMenu = new Menus(selected_menu);
                lblmenuid.Text = SearchMenu.MenuID; // tracking current menu id
                textboxmenuname.Text = SearchMenu.Name;
                txtboxmenudesc.Text = SearchMenu.Description;
                txtboxmenuprice.Text = SearchMenu.Price.ToString();
                txtboxmenutime.Text = SearchMenu.Duration.ToString();
                txtboxavailable.Text = SearchMenu.Availability;
                txtboxcat.Text = SearchMenu.Category;

                // taking image from folder Images based on name from database 
                string imagePath = Path.Combine(Application.StartupPath, "Images", SearchMenu.ImageUrl);
                picboxmenu.Image = Image.FromFile(imagePath);
                if (File.Exists(imagePath))
                {
                    picboxmenu.Image = Image.FromFile(imagePath); ;
                }
                else
                {
                    picboxmenu.Image = null;
                }

            }
        }

        private void btnfinishmenu_Click(object sender, EventArgs e)
        {
            // checking if all are null, if null that means cancel addition of new menu
            if (string.IsNullOrWhiteSpace(textboxmenuname.Text) &&
            string.IsNullOrWhiteSpace(txtboxavailable.Text) &&
            string.IsNullOrWhiteSpace(txtboxcat.Text) &&
            string.IsNullOrWhiteSpace(txtboxmenudesc.Text) &&
            string.IsNullOrWhiteSpace(txtboxmenuprice.Text) &&
            string.IsNullOrWhiteSpace(txtboxmenutime.Text) &&
            picboxmenu.Image == null)
            {
                // controls settings
                textboxmenuname.Text = "";
                txtboxcat.Text = "";
                txtboxavailable.Text = "";
                txtboxmenudesc.Text = "";
                txtboxmenuprice.Text = "";
                txtboxmenutime.Text = ""; // clearing displays
                txtboxavailable.ReadOnly = true;
                txtboxcat.ReadOnly = true;
                txtboxmenudesc.ReadOnly = true;
                txtboxmenuprice.ReadOnly = true;
                txtboxmenutime.ReadOnly = true;
                textboxmenuname.ReadOnly = true;
                btnaddmenu.Enabled = true;
                picboxmenu.Image = null;
                btnsearchmenu.Enabled = true;
                formmenu_Load(sender, e); // refreshing listbox and controls settings
                lblmenuid.Text = "-------------------------";
                lblmenumode.Text = "(Observation mode)"; // revert back to observation mode
                return;
            }
            if (picboxmenu.Image == null)
            {
                MessageBox.Show("Input an image");
                return;
            }
            // checking mode
            if (lblmenumode.Text == "(Insert mode)")
            {
                // input checking
                decimal price;
                int duration;
                string name = textboxmenuname.Text, description = txtboxmenudesc.Text, category = txtboxcat.Text, availability = txtboxavailable.Text;

                if (!decimal.TryParse(txtboxmenuprice.Text, out price))
                {
                    MessageBox.Show("Invalid price entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtboxmenutime.Text, out duration))
                {
                    MessageBox.Show("Invalid duration entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // inserting data to the database with menus constructor that accepts 6 parameters
                Menus NewMenu = new Menus(
                    name,
                    description,
                    price,
                    category,
                    availability,
                    duration
                );

                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(description) ||
                    string.IsNullOrEmpty(category) ||
                    string.IsNullOrEmpty(availability) ||
                    !(availability.ToLower() == "available" || availability.ToLower() == "unavailable"))
                {
                    MessageBox.Show("Input appropriate fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Data updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //controls settings
                textboxmenuname.Text = "";
                txtboxcat.Text = "";
                txtboxavailable.Text = "";
                txtboxmenudesc.Text = "";
                txtboxmenuprice.Text = "";
                txtboxmenutime.Text = "";
                txtboxavailable.ReadOnly = true;
                txtboxcat.ReadOnly = true;
                txtboxmenudesc.ReadOnly = true;
                txtboxmenuprice.ReadOnly = true;
                txtboxmenutime.ReadOnly = true;
                textboxmenuname.ReadOnly = true;
                btnaddmenu.Enabled = true;
                picboxmenu.Image = null;
                btnbrowse.Visible = false;
                btnsearchmenu.Enabled = true;
                btnfinishmenu.Enabled = false;
                formmenu_Load(sender, e);
                lblmenuid.Text = "-------------------------";
                lblmenumode.Text = "(Observation mode)";
            }

            else if (lblmenumode.Text == "(Edit mode)")
            {
                decimal price;
                int duration;
                string name = textboxmenuname.Text, description = txtboxmenudesc.Text, category = txtboxcat.Text, availability = txtboxavailable.Text;

                if (!decimal.TryParse(txtboxmenuprice.Text, out price))
                {
                    MessageBox.Show("Invalid price entered.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtboxmenutime.Text, out duration))
                {
                    MessageBox.Show("Invalid duration entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(description) ||
                    string.IsNullOrEmpty(category) ||
                    string.IsNullOrEmpty(availability) ||
                    !(availability.ToLower() == "available" || availability.ToLower() == "unavailable"))
                {
                    MessageBox.Show("Input appropriate fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // instantiating an object of the menu class so it contains all details about current menu
                Menus EditMenu = new Menus(textboxmenuname.Text);
                EditMenu.SetMenuDetails(
                    description: txtboxmenudesc.Text,
                    price: Convert.ToDecimal(txtboxmenuprice.Text),
                    category: txtboxcat.Text,
                    availability: txtboxavailable.Text,
                    duration: Convert.ToInt32(txtboxmenutime.Text)
                    );

                // edit menu details and saving it in database
                EditMenu.UpdateMenu();

                // Controls settings
                textboxmenuname.Text = "";
                txtboxcat.Text = "";
                txtboxavailable.Text = "";
                txtboxmenudesc.Text = "";
                txtboxmenuprice.Text = "";
                txtboxmenutime.Text = "";
                txtboxavailable.ReadOnly = true;
                txtboxcat.ReadOnly = true;
                txtboxmenudesc.ReadOnly = true;
                txtboxmenuprice.ReadOnly = true;
                txtboxmenutime.ReadOnly = true;
                picboxmenu.Image = null;
                btndelete.Visible = false;
                btnaddmenu.Enabled = true;
                btnsearchmenu.Enabled = true;
                lblmenuid.Text = "-------------------------";
                lblmenumode.Text = "(Observation mode)";
            }

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            // allowing user to insert picture
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // accepts only jpg file
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourcePath = openFileDialog.FileName;
                        // getting file extension
                        string fileExtension = Path.GetExtension(sourcePath).ToLower();
                        // getting path of images folder
                        string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                        Directory.CreateDirectory(imagesFolder);
                        // Get the next image number, if img1.jpg, then next is img2.jpg
                        int nextImgNum = 1;
                        string imgQuery = @"
                    SELECT TOP 1 Image_url 
                    FROM Menus 
                    WHERE ISNUMERIC(SUBSTRING(Image_url, 4, LEN(Image_url) - 7)) = 1 
                    ORDER BY CAST(SUBSTRING(Image_url, 4, LEN(Image_url) - 7) AS INT) DESC";

                        DataTable result = DatabaseHelper.ExecuteQuery(imgQuery);
                        if (result != null && result.Rows.Count > 0)
                        {
                            string lastImageName = result.Rows[0]["Image_url"].ToString();
                            if (lastImageName.StartsWith("img") && lastImageName.EndsWith(".jpg"))
                            {
                                string numericPart = lastImageName.Substring(3, lastImageName.Length - 7);
                                if (int.TryParse(numericPart, out int number))
                                {
                                    nextImgNum = number + 1;
                                }
                            }
                        }

                        string newImageName = $"img{nextImgNum}{fileExtension}";
                        string destinationPath = Path.Combine(imagesFolder, newImageName);
                        File.Copy(sourcePath, destinationPath, true);

                        // Show image
                        picboxmenu.ImageLocation = destinationPath;
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show($"Image upload failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btneditmenu_Click(object sender, EventArgs e)
        {
            // controls settings
            btnsearchmenu.Enabled = false;
            btnaddmenu.Enabled = false;
            btnfinishmenu.Enabled = true;
            lblmenumode.Text = "(Edit mode)"; // converting to edit mode
            txtboxavailable.ReadOnly = false;
            txtboxcat.ReadOnly = false; 
            txtboxmenudesc.ReadOnly = false;
            txtboxmenuprice.ReadOnly = false;
            txtboxmenutime.ReadOnly = false;
            btndelete.Visible = true;
            btneditmenu.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // delete menu
            Menus DeleteMenu = new Menus(textboxmenuname.Text);
            DeleteMenu.DeleteMenu();

            textboxmenuname.Text = "";
            txtboxcat.Text = "";
            txtboxavailable.Text = "";
            txtboxmenudesc.Text = "";
            txtboxmenuprice.Text = "";
            txtboxmenutime.Text = "";
            picboxmenu.Image = null;
            btndelete.Visible = false;
            btnsearchmenu.Enabled = true;
            btnaddmenu.Enabled = true;
            btnfinishmenu.Enabled = false;
            lblmenuid.Text = "-------------------------";

            formmenu_Load(sender, e);
        }
    }
}
