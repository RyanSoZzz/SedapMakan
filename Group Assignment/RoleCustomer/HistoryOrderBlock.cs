using Group_Assignment.RoleCustomer.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Group_Assignment.RoleCustomer
{
    public partial class HistoryOrderBlock : UserControl
    {
        public string OrderID { get; set; } //Unique identifier for the order
        public DateTime OrderDate { get; set; } //Date of the order
        public string OrderStatus { get; set; } //Status of the order (e.g., Completed, In Progress, Cancelled)
        public decimal OrderTotalFee { get; set; } //Total amount of the order
        public string OrderFeedback { get; set; } //Feedback from customer
        public int OrderRating { get; set; } //1-5 scale
        public string OrderManagerResponse { get; set; } //Response from the manager regarding the order
        public Order theOrder { get; private set; } //Reference to the Order object
        public FeedbackObj theFeedback { get; private set; } //Reference to the Feedback object
        public RefundRequest theRefundRequest { get; private set; }
        public HistoryOrderBlock(Order order, FeedbackObj feedback, RefundRequest refundrequest)
        {
            InitializeComponent();
            theOrder = order;
            theFeedback = feedback;
            theRefundRequest = refundrequest;

            loadData();
        }

        public int loadData()
        {
            //Load the UI with the order details
            try
            {
                if (theOrder != null)
                {
                    OrderID = theOrder.OrderID;
                    OrderDate = theOrder.Date;
                    OrderStatus = theOrder.Status;
                    OrderTotalFee = theOrder.TotalOrderFee;
                }

                lblOrderID.Text = "Order ID: " + OrderID;
                lblDate.Text = "Order Date: " + OrderDate.ToString("dd/MM/yyyy");
                switch(OrderStatus)
                    {
                    case "Completed":
                        lblStatus.Text = "Status: Completed";
                        lblStatus.BackColor = Color.Green;
                        break;
                    case "In Progress":
                        lblStatus.Text = "Status: In Progress";
                        lblStatus.BackColor = Color.Teal;
                        break;
                    case "Failed":
                        lblStatus.Text = "Status: Cancelled";
                        lblStatus.BackColor = Color.Red;
                        break;
                    default:
                        lblStatus.Text = "Status: Unknown";
                        lblStatus.BackColor = Color.Gray;
                        break;
                }
                lblTotalOrderFee.Text = "Total Order Fee: MYR" + OrderTotalFee.ToString("F2");

                //Just for some allocating system
                Point btnCancelP, btnViewitemP, btnRefundP;
                btnCancelP = new Point(btnCancel.Location.X, btnCancel.Location.Y);
                btnViewitemP = new Point(btnViewItem.Location.X, btnViewItem.Location.Y);
                btnRefundP = new Point(btnRefund.Location.X, btnRefund.Location.Y);

                if (OrderStatus == "Completed")
                {
                    if (theFeedback != null)
                    {
                        //Manager response
                        if (theFeedback.Manager_Response != null)
                        {
                            lblResponse.Visible = true;
                            lblResponse.Text = "Response: "+theFeedback.Manager_Response;
                        }
                        //Customer Feedback
                        if (theFeedback.Customer_Feedback != null && theFeedback.Rating != 0)
                        {
                            lblFeedback.Visible = true;
                            lblRating.Visible = true;

                            lblRating.Text = string.Concat(Enumerable.Repeat("⭐", theFeedback.Rating));
                            lblFeedback.Text = "Feedback: "+theFeedback.Customer_Feedback;
                        }
                    }
                    else
                    {
                        btnGiveFeedback.Visible = true;
                    }
                    btnRefund.Visible = true;
                    btnRefund.Location = btnViewitemP;
                    btnViewItem.Location = btnCancelP;
                }
                else if (OrderStatus == "In Progress")
                {
                    btnViewItem.Location = btnCancelP;
                    btnCancel.Visible = true;
                    btnCancel.Location = btnViewitemP;
                }
                else if (OrderStatus == "Failed")
                {
                    btnViewItem.Visible = true;
                    btnRefund.Visible = true;
                    btnGiveFeedback.Visible = false;
                    btnCancel.Visible = false;

                    btnViewItem.Location = btnCancelP;
                    btnRefund.Location = btnViewitemP;
                }


                return 0; // Indicating success
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading HistoryOrderBlock data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indicating an error
            }
        }

        public int loadDataV2()
        {
            //Load the UI with the order details
            try
            {
                if (theOrder != null)
                {
                    OrderID = theOrder.OrderID;
                    OrderDate = theOrder.Date;
                    OrderStatus = theOrder.Status;
                    OrderTotalFee = theOrder.TotalOrderFee;
                }

                lblOrderID.Text = "Order ID: " + OrderID;
                lblDate.Text = "Order Date: " + OrderDate.ToString("dd/MM/yyyy");
                switch (OrderStatus)
                {
                    case "Completed":
                        lblStatus.Text = "Status: Completed";
                        lblStatus.BackColor = Color.Green;
                        break;
                    case "In Progress":
                        lblStatus.Text = "Status: In Progress";
                        lblStatus.BackColor = Color.Teal;
                        break;
                    case "Failed":
                        lblStatus.Text = "Status: Cancelled";
                        lblStatus.BackColor = Color.Red;
                        break;
                    default:
                        lblStatus.Text = "Status: Unknown";
                        lblStatus.BackColor = Color.Gray;
                        break;
                }
                lblTotalOrderFee.Text = "Total Order Fee: MYR" + OrderTotalFee.ToString("F2");

                if (OrderStatus == "Completed")
                {
                    if (theFeedback != null)
                    {
                        this.btnGiveFeedback.Visible = false;

                        //Manager response
                        if (theFeedback.Manager_Response != null)
                        {
                            lblResponse.Visible = true;
                            lblResponse.Text = "Response: " + theFeedback.Manager_Response;
                        }
                        //Customer Feedback
                        if (theFeedback.Customer_Feedback != null && theFeedback.Rating != 0)
                        {
                            lblFeedback.Visible = true;
                            lblRating.Visible = true;

                            lblRating.Text = string.Concat(Enumerable.Repeat("⭐", theFeedback.Rating));
                            lblFeedback.Text = "Feedback: " + theFeedback.Customer_Feedback;
                        }
                    }
                    else
                    {
                        btnGiveFeedback.Visible = true;
                    }
                    btnRefund.Visible = true;
                }
                else if (OrderStatus == "In Progress")
                {
                    btnCancel.Visible = true;
                }
                else if (OrderStatus == "Failed")
                {
                    btnViewItem.Visible = true;
                    btnRefund.Visible = true;
                    btnGiveFeedback.Visible = false;
                    btnCancel.Visible = false;

                    btnRefund.Location = btnCancel.Location;
                }

                return 0; // Indicating success
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading HistoryOrderBlock data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indicating an error
            }
        }

        private Form createNewBackground()
        {
            Form background = new Form();
            background.StartPosition = FormStartPosition.Manual;
            background.FormBorderStyle = FormBorderStyle.None;
            background.Opacity = .50d;
            background.BackColor = Color.Black;
            background.Size = this.Parent.Parent.Parent.Parent.Size;
            background.Location = this.Parent.Parent.Parent.Parent.Location;
            background.ShowInTaskbar = false;
            background.Show();

            return background;
        }

        private void btnGiveFeedback_Click(object sender, EventArgs e)
        {
            Form background = createNewBackground();

            GiveFeedbackForm theForm = new GiveFeedbackForm(OrderID);
            if (theForm.ShowDialog() == DialogResult.OK)
            {
                if (theForm.returningItem != null)
                {
                    theFeedback = theForm.returningItem;
                }
                loadDataV2(); //Reload after any changes
            }
            background.Dispose();
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            ViewItem theViewItem = new ViewItem(theOrder);
            this.Parent.Parent.Parent.Controls.Add(theViewItem);
            theViewItem.Dock = DockStyle.Fill;
            theViewItem.BringToFront();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (theRefundRequest != null)
            {
                Form background = createNewBackground();

                OnRefundRequestForm statusRefundForm = new OnRefundRequestForm(theRefundRequest);
                statusRefundForm.ShowDialog();
                background.Dispose();
            }
            else
            {
                Form background = createNewBackground();

                RefundRequestForm newRefoundForm = new RefundRequestForm(theOrder);
                if (newRefoundForm.ShowDialog() == DialogResult.OK)
                {
                    if (newRefoundForm.returningItem != null)
                    {
                        theRefundRequest = newRefoundForm.returningItem;
                    }
                    loadDataV2(); //Reload after any changes
                }
                background.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text == "Cancel")
            {
                btnCancel.Text = "Confirm ✅";
            }

            string query = @"UPDATE [Order] SET Status = 'Failed' WHERE OrderID = @orderid";
            int execute = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter("@orderid", theOrder.OrderID));

            if (execute > 0)
            {
                MessageBox.Show("OrderID: " + theOrder.OrderID + ", succesfully cancelled!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                theOrder.Status = "Failed";
                loadDataV2();
            }
        }

        private void btnViewFeedback_MouseEnter(object sender, EventArgs e)
        {
            btnGiveFeedback.ForeColor = Color.Black;
        }
        private void btnViewFeedback_MouseLeave(object sender, EventArgs e)
        {
            btnGiveFeedback.ForeColor = Color.Yellow;
        }

        private void btnViewItem_MouseEnter(object sender, EventArgs e)
        {
            btnViewItem.ForeColor = Color.Black;
        }
        private void btnViewItem_MouseLeave(object sender, EventArgs e)
        {
            btnViewItem.ForeColor = Color.White;
        }

        private void btnRefund_MouseEnter(object sender, EventArgs e)
        {
            btnRefund.ForeColor = Color.Black;
        }
        private void btnRefund_MouseLeave(object sender, EventArgs e)
        {
            btnRefund.ForeColor = Color.White;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Black;
        }
        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Red;
            btnCancel.Text = "Cancel";
        }
    }
}
