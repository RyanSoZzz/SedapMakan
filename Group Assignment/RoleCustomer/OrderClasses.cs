using Group_Assignment.LoginPage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.RoleCustomer
{
    public class OrderItem : DatabaseHelper
    {
        public string OrderItemID { get; set; }
        public string OrderID { get; set; }
        public string MenuID { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string MenuName { get; set; }
        public float PricePerItem { get; set; }

        public OrderItem(string orderId, DataRow orderItem)
        {
            try
            {
                //Get last OrderItemID from the database
                string query = "SELECT TOP 1 OrderItemID FROM [OrderItem] ORDER BY OrderItemID DESC";
                DataTable dt = ExecuteQuery(query);
                string LastOrderItemID = "oitmyyyymmdd000";
                string LastDate;

                if (dt != null && dt.Rows.Count > 0)
                {
                    LastDate = dt.Rows[0]["OrderItemID"].ToString().Substring(4, 8); // Extract date part from OrderItemID

                    if (LastDate == DateTime.Now.ToString("yyyyMMdd"))
                    {
                        LastOrderItemID = dt.Rows[0]["OrderItemID"].ToString();
                    }
                }

                // Generate a new OrderID based on the current date and time
                OrderItemID = "oitm" + DateTime.Now.ToString("yyyyMMdd") + (Convert.ToInt32(LastOrderItemID.Substring(LastOrderItemID.Length - 3)) + 1).ToString("D3");
                //Insert a new OrderItem into the database
                query = @"INSERT INTO OrderItem VALUES
                    (@orderitemid, @orderid, @menuid, @quantity, @status)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@orderitemid", OrderItemID),
                new SqlParameter("@orderid", orderId),
                new SqlParameter("@menuid", orderItem["MenuID"].ToString()),
                new SqlParameter("@quantity", Convert.ToInt32(orderItem["Quantity"])),
                new SqlParameter("@status", "In Progress")
                };
                
                int result = ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    // If insertion is successful, retrieve the newly created OrderItemID
                    query = @"SELECT oi.*, m.Name AS MenuName, m.Price
                        FROM OrderItem oi
                        JOIN Menus m ON oi.MenuID = m.MenuID
                        WHERE oi.OrderItemID = @OrderItemID";
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@OrderItemID", OrderItemID)
                    };
                    DataTable resultTable = ExecuteQuery(query, param);
                    if (resultTable != null)
                    {
                        DataRow dr = resultTable.Rows[0];
                        OrderItemID = dr["OrderItemID"].ToString();
                        OrderID = dr["OrderID"].ToString();
                        MenuID = dr["MenuID"].ToString();
                        Quantity = Convert.ToInt32(dr["Quantity"]);
                        Status = dr["Status"].ToString();
                        MenuName = dr["MenuName"].ToString();
                        PricePerItem = Convert.ToSingle(dr["Price"]);

                        query = @"UPDATE [Order] SET TotalOrderFee = COALESCE(TotalOrderFee, 0) + @singleprice * @quantity WHERE OrderID = @orderid";
                        param = new SqlParameter[]
                        {
                            new SqlParameter("@quantity", Quantity),
                            new SqlParameter("@singleprice", Convert.ToDecimal(PricePerItem)),
                            new SqlParameter("@orderid", OrderID)
                        };
                        ExecuteQuery(query, param);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create Order Item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error creating Order Item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }

        public OrderItem(string orderItemId)
        {
            try
            {
                // Query OrderItem + join Menu to get MenuName
                string query = @"SELECT oi.*, m.Name AS MenuName, m.Price
                        FROM OrderItem oi
                        JOIN Menus m ON oi.MenuID = m.MenuID
                        WHERE oi.OrderItemID = @OrderItemID";

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@OrderItemID", orderItemId)
                };
                DataTable result = ExecuteQuery(query, param);

                if (result != null && result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    OrderItemID = row["OrderItemID"].ToString();
                    OrderID = row["OrderID"].ToString();
                    MenuID = row["MenuID"].ToString();
                    Quantity = Convert.ToInt32(row["Quantity"]);
                    Status = row["Status"].ToString();
                    MenuName = row["MenuName"].ToString();
                    PricePerItem = Convert.ToSingle(row["Price"]);
                }
                else
                {
                    MessageBox.Show($"OrderItem ID '{orderItemId}' not found.", "OrderItem Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[OrderItem Constructor Error]\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool UpdateStatus(string newStatus)
        {
            try
            {
                string query = "UPDATE OrderItem SET Status = @Status WHERE OrderItemID = @OrderItemID";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Status", newStatus),
            new SqlParameter("@OrderItemID", this.OrderItemID)
                };

                int rowsAffected = ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    this.Status = newStatus; // Update object state
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to update OrderItem status.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[OrderItem.UpdateStatus Error]\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
    public class Order : DatabaseHelper
    {
        public string OrderID { get; set; }
        public string ChefID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalOrderFee { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public static DataTable getAllOrderIdFromCustomerID(string custid)
        {
            try
            {
                // Query to get the in-progress order ID for the given customer ID
                string query = @"SELECT * FROM [Order]
                        WHERE CustomerID = @CustomerID";
                SqlParameter param = new SqlParameter("@CustomerID", custid);
                DataTable result = ExecuteQuery(query, param);
                if (result != null && result.Rows.Count > 0)
                {
                    return result;
                }
                else
                {
                    return null; // No in-progress order found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Get In-Progress Order Error]\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string getInProgressOrderIDFromCustID(string custid)
        {
            try
            {
                // Query to get the in-progress order ID for the given customer ID
                string query = @"SELECT TOP 1 OrderID FROM [Order]
                        WHERE CustomerID = @CustomerID AND Status = 'In Progress'";
                SqlParameter param = new SqlParameter("@CustomerID", custid);
                DataTable result = ExecuteQuery(query, param);
                if (result != null && result.Rows.Count > 0)
                {
                    return result.Rows[0]["OrderID"].ToString();
                }
                else
                {
                    return null; // No in-progress order found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Get In-Progress Order Error]\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void EvaluateAndSetStatus()
        {
            if (OrderItems == null || OrderItems.Count == 0)
            {
                UpdateStatus("In Progress"); // No items yet = still in progress
                return;
            }

            bool allCompleted = OrderItems.All(item => item.Status == "Completed");
            bool anyFailed = OrderItems.Any(item => item.Status == "Failed");

            if (allCompleted)
            {
                UpdateStatus("Completed");
            }
            else if (anyFailed)
            {
                UpdateStatus("Failed");
            }
            else
            {
                UpdateStatus("In Progress");
            }
        }

        public void AdjustOrderTotalOnStatusChange(string orderItemId, string oldStatus, string newStatus)
        {
            if (oldStatus == newStatus) return;

            string getItemQuery = @"
        SELECT oi.OrderID, oi.Quantity, m.Price
        FROM OrderItem oi
        JOIN Menus m ON oi.MenuID = m.MenuID
        WHERE oi.OrderItemID = @OrderItemID;
    ";

            SqlParameter param = new SqlParameter("@OrderItemID", orderItemId);
            DataTable result = DatabaseHelper.ExecuteQuery(getItemQuery, param);

            if (result == null || result.Rows.Count == 0) return;

            string orderId = result.Rows[0]["OrderID"].ToString();
            int quantity = Convert.ToInt32(result.Rows[0]["Quantity"]);
            decimal price = Convert.ToDecimal(result.Rows[0]["Price"]);
            decimal itemTotal = quantity * price;

            decimal adjustment = 0;
            if (oldStatus == "Failed" && newStatus != "Failed")
                adjustment = itemTotal; // Add back
            else if (oldStatus != "Failed" && newStatus == "Failed")
                adjustment = -itemTotal; // Subtract

            if (adjustment != 0)
            {
                string updateQuery = @"
            UPDATE [Order]
            SET TotalOrderFee = 
                CASE 
                    WHEN TotalOrderFee + @Adjustment < 0 THEN 0
                    ELSE TotalOrderFee + @Adjustment
                END
            WHERE OrderID = @OrderID;
        ";

                SqlParameter[] updateParams = {
            new SqlParameter("@Adjustment", adjustment),
            new SqlParameter("@OrderID", orderId)
        };

                DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);
            }
        }
        public bool UpdateStatus(string newStatus)
        {
            try
            {
                string query = "UPDATE [Order] SET Status = @Status WHERE OrderID = @OrderID";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Status", newStatus),
            new SqlParameter("@OrderID", this.OrderID)
                };

                int rowsAffected = ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    this.Status = newStatus; // Update object state
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to update Order status.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Order.UpdateStatus Error]\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private int createNewOrder(string custid)
        {
            try
            {
                //Get last OrderID from the database
                string query = "SELECT TOP 1 OrderID FROM [Order] ORDER BY OrderID DESC";
                string LastOrderID;
                if (ExecuteQuery(query).Rows[0]["OrderID"].ToString().Substring(3, 8) == DateTime.Now.ToString("yyyyMMdd"))
                {
                    LastOrderID = ExecuteQuery(query).Rows[0]["OrderID"].ToString();
                }
                else
                {
                    LastOrderID = "ordyyyymmdd000"; // Default value if no orders exist
                }

                // Generate a new OrderID based on the current date and time
                string orderId = "ord" + DateTime.Now.ToString("yyyyMMdd") + (Convert.ToInt32(LastOrderID.Substring(LastOrderID.Length - 3)) + 1).ToString("D3");
                query = @"INSERT INTO [Order] (OrderID, CustomerID, Date, Status)
                                 VALUES (@OrderID, @CustomerID, @Date, 'In Progress')";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", orderId),
                    new SqlParameter("@CustomerID", custid),
                    new SqlParameter("@Date", DateTime.Now)
                };

                int result = ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    OrderID = orderId;
                    CustomerID = custid;
                    Status = "In Progress";
                    Date = DateTime.Now;
                    return 0; // Indicate success
                }
                else
                {
                    MessageBox.Show("Failed to create a new order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // Indicate failure
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Create New Order Error]\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public void createNewOrderItem(string orderid, DataTable orderItems)
        {
            if (orderItems != null)
            {
                foreach (DataRow itemRow in orderItems.Rows)
                {
                    OrderItem item = new OrderItem(orderid, itemRow);

                    OrderItems.Add(item);
                }
            }
        }

        public Order(string custid, DataTable orderItems)
        {
            try
            {
                //Check whether last order is in progress
                string orderQuery = @"SELECT o.OrderID, o.ChefID, o.CustomerID, o.TotalOrderFee, o.Date, o.Status
                        , a.Name AS CustomerName FROM [Order] o
                        JOIN Customer c ON o.CustomerID = c.CustomerID
                        JOIN Account a ON c.AccountID = a.AccountID
                        WHERE o.CustomerID = @custid AND o.Status = 'In Progress'";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@custid", custid)
                };

                //If there is any in-progress order, load the details
                DataTable result = ExecuteQuery(orderQuery, parameters);

                if (result != null && result.Rows.Count > 0) 
                {
                    DataRow row = result.Rows[0];
                    OrderID = row["OrderID"].ToString();
                    ChefID = row["ChefID"] != DBNull.Value ? row["ChefID"].ToString() : null;
                    CustomerID = row["CustomerID"].ToString();
                    CustomerName = row["CustomerName"].ToString();
                    TotalOrderFee = row["TotalOrderFee"] != DBNull.Value ? Convert.ToDecimal(row["TotalOrderFee"]) : 0;
                    Date = Convert.ToDateTime(row["Date"]);
                    Status = row["Status"].ToString();

                    //Load order items
                    string itemQuery = "SELECT * FROM OrderItem WHERE OrderID = @OrderID";
                    DataTable itemResult = ExecuteQuery(itemQuery, new SqlParameter("@OrderID", OrderID));
                    if (itemResult != null)
                    {
                        foreach (DataRow itemRow in itemResult.Rows)
                        {
                            OrderItem item = new OrderItem(itemRow["OrderItemID"].ToString())
                            {
                                OrderItemID = itemRow["OrderItemID"].ToString(),
                                OrderID = itemRow["OrderID"].ToString(),
                                MenuID = itemRow["MenuID"].ToString(),
                                Quantity = Convert.ToInt32(itemRow["Quantity"]),
                                Status = itemRow["Status"].ToString()
                            };
                            OrderItems.Add(item);
                        }
                    }

                    createNewOrderItem(getInProgressOrderIDFromCustID(custid), orderItems);
                }
                else
                {
                    if (createNewOrder(custid) == 0 )
                    {
                        createNewOrderItem(getInProgressOrderIDFromCustID(custid), orderItems);
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Order Constructor Error]\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Indicate failure
            }
        }

        public Order(string orderId)
        {
            try
            {
                // Load order details from [Order] + join Customer → Account
                string orderQuery = @"SELECT o.OrderID, o.ChefID, o.CustomerID, o.TotalOrderFee, o.Date, o.Status,
                        a.Name AS CustomerName FROM [Order] o
                        JOIN Customer c ON o.CustomerID = c.CustomerID
                        JOIN Account a ON c.AccountID = a.AccountID
                        WHERE o.OrderID = @OrderID";

                DataTable orderResult = ExecuteQuery(orderQuery, new SqlParameter("@OrderID", orderId));

                if (orderResult != null && orderResult.Rows.Count > 0)
                {
                    DataRow row = orderResult.Rows[0];
                    OrderID = row["OrderID"].ToString();
                    ChefID = row["ChefID"] != DBNull.Value ? row["ChefID"].ToString() : null;
                    CustomerID = row["CustomerID"].ToString();
                    CustomerName = row["CustomerName"].ToString();
                    TotalOrderFee = row["TotalOrderFee"] != DBNull.Value ? Convert.ToDecimal(row["TotalOrderFee"]) : 0;
                    Date = Convert.ToDateTime(row["Date"]);
                    Status = row["Status"].ToString();
                }
                else
                {
                    MessageBox.Show($"Order ID '{orderId}' not found in the database.", "Order Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Load order items
                string itemQuery = "SELECT * FROM OrderItem WHERE OrderID = @OrderID";
                DataTable itemResult = ExecuteQuery(itemQuery, new SqlParameter("@OrderID", orderId));

                if (itemResult != null)
                {
                    foreach (DataRow itemRow in itemResult.Rows)
                    {
                        OrderItem item = new OrderItem(itemRow["OrderItemID"].ToString())
                        {
                            OrderItemID = itemRow["OrderItemID"].ToString(),
                            OrderID = itemRow["OrderID"].ToString(),
                            MenuID = itemRow["MenuID"].ToString(),
                            Quantity = Convert.ToInt32(itemRow["Quantity"]),
                            Status = itemRow["Status"].ToString()
                        };

                        OrderItems.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Order Constructor Error]\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
