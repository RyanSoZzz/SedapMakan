using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.RoleCustomer
{
    public class Menus
    {
        public string MenuID { get; private set; } // example : menu000008
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; } // Italian, Mexican, Vegetarian, Local, Drinks
        public string Availability { get; private set; } // available / unavailable
        public int Duration { get; private set; } // in minutes
        public string ImageUrl { get; private set; } // example : img1.jpg

        // constructor for inserting data to the database
        public Menus(string name, string description, decimal price, string category, string availability, int duration)
        {
            // auto generate both menuid and image_url
            try
            {
                // get latest MenuID from the database
                string query = "SELECT TOP 1 MenuID FROM Menus ORDER BY MenuID DESC";
                DataTable result = DatabaseHelper.ExecuteQuery(query);

                int nextIdNumber = 1;
                if (result != null && result.Rows.Count > 0)
                {
                    string lastMenuId = result.Rows[0]["MenuID"].ToString();

                    if (lastMenuId.StartsWith("menu") && lastMenuId.Length == 10)
                    {
                        string numericPart = lastMenuId.Substring(4); // extract "000008"
                        if (int.TryParse(numericPart, out int number))
                        {
                            nextIdNumber = number + 1;
                        }
                    }
                }

                // format new MenuID
                MenuID = $"menu{nextIdNumber.ToString("D6")}";

                // get the latest img url number
                string imgQuery = "SELECT TOP 1 Image_url FROM Menus WHERE ISNUMERIC(SUBSTRING(Image_url, 4, LEN(Image_url) - 7)) = 1 ORDER BY CAST(SUBSTRING(Image_url, 4, LEN(Image_url) - 7) AS INT) DESC";
                DataTable imgResult = DatabaseHelper.ExecuteQuery(imgQuery);

                int nextImgNumber = 1;
                if (imgResult != null && imgResult.Rows.Count > 0)
                {
                    string lastImg = imgResult.Rows[0]["Image_url"].ToString();

                    if (lastImg.StartsWith("img") && lastImg.EndsWith(".jpg"))
                    {
                        string numberPart = lastImg.Substring(3, lastImg.Length - 7); // between "img" and ".jpg"
                        if (int.TryParse(numberPart, out int imgNum))
                        {
                            nextImgNumber = imgNum + 1;
                        }
                    }
                }

                //Format new Image url
                ImageUrl = $"img{nextImgNumber}.jpg";

                //Assign fields
                Name = name;
                Description = description;
                Price = price;
                Category = category;
                Availability = availability;
                Duration = duration;

                if (!SetAvailability(availability) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Category) || string.IsNullOrEmpty(Availability))
                {
                    return;
                }

                // Insert into database
                string insertQuery = @"
            INSERT INTO Menus (MenuID, Name, Description, Price, Category, Availability, Duration, Image_url)
            VALUES (@MenuID, @Name, @Description, @Price, @Category, @Availability, @Duration, @ImageUrl)";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@MenuID", MenuID),
            new SqlParameter("@Name", Name),
            new SqlParameter("@Description", Description),
            new SqlParameter("@Price", Price),
            new SqlParameter("@Category", Category),
            new SqlParameter("@Availability", Availability),
            new SqlParameter("@Duration", Duration),
            new SqlParameter("@ImageUrl", ImageUrl)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Failed to insert new menu into the database.", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Menu Constructor Error]\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // constructor for loading data of Specific Item from the database
        public Menus(string nameofmenu)
        {
            try
            {
                string query = "SELECT * FROM Menus WHERE Name = @Name";
                SqlParameter param = new SqlParameter("@Name", nameofmenu);
                DataTable result = DatabaseHelper.ExecuteQuery(query, param);

                if (result != null && result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    MenuID = row["MenuID"].ToString();
                    Name = row["Name"].ToString();
                    Description = row["Description"].ToString();
                    Price = Convert.ToDecimal(row["Price"]);
                    Category = row["Category"].ToString();
                    Availability = row["Availability"].ToString();
                    Duration = Convert.ToInt32(row["Duration"]);
                    ImageUrl = row["Image_url"].ToString();
                }
                else
                {
                    MessageBox.Show($"Menu '{nameofmenu}' not found in the database.", "Menu Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Load Menu Error]\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetMenuDetails(string description, decimal price, string category, string availability, int duration)
        {
            Description = description;
            Price = price;
            Category = category;
            Availability = availability;
            Duration = duration;
        }

        public bool UpdateMenu()
        {
            try
            {
                if (SetAvailability(Availability))
                {
                    string updateQuery = @"
                UPDATE Menus
                SET Description = @Description,
                    Price = @Price,
                    Category = @Category,
                    Availability = @Availability,
                    Duration = @Duration
                WHERE MenuID = @MenuID";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@Description", Description),
                new SqlParameter("@Price", Price),
                new SqlParameter("@Category", Category),
                new SqlParameter("@Availability", Availability),
                new SqlParameter("@Duration", Duration),
                new SqlParameter("@Name", Name),
                new SqlParameter("@MenuID", MenuID)
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Menu updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Menu not found.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[UpdateMenu Error]\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteMenu()
        {
            try
            {
                string deleteQuery = "DELETE FROM Menus WHERE MenuID = @MenuID";

                SqlParameter param = new SqlParameter("@MenuID", MenuID);

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(deleteQuery, param);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Menu deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Delete failed. Menu with that id not found.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[DeleteMenuByName Error]\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool SetAvailability(string status)
        {
            // Normalize input to lower case for comparison
            string lowerStatus = status.ToLower();

            if (lowerStatus == "available" || lowerStatus == "unavailable")
            {
                Availability = char.ToUpper(status[0]) + status.Substring(1).ToLower(); // format to "Available" or "Unavailable"
                return true;
            }
            else
            {
                MessageBox.Show("Availability must be either 'Available' or 'Unavailable'.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
