namespace Group_Assignment.RoleCustomer
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPlaceOrder = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblInsufficientBalance = new System.Windows.Forms.Label();
            this.pnlItemDetails = new System.Windows.Forms.Panel();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.pnlStrip = new System.Windows.Forms.Panel();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNameFood = new System.Windows.Forms.Label();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.laypanMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.cbSortBy = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.pnlSortBy = new System.Windows.Forms.Panel();
            this.pnlPlaceOrder.SuspendLayout();
            this.pnlItemDetails.SuspendLayout();
            this.pnlQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.pnlSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaceOrder
            // 
            this.pnlPlaceOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.pnlPlaceOrder.Controls.Add(this.btnOrder);
            this.pnlPlaceOrder.Controls.Add(this.lblInsufficientBalance);
            this.pnlPlaceOrder.Controls.Add(this.pnlItemDetails);
            this.pnlPlaceOrder.Controls.Add(this.pbItemImage);
            this.pnlPlaceOrder.Location = new System.Drawing.Point(491, 8);
            this.pnlPlaceOrder.Name = "pnlPlaceOrder";
            this.pnlPlaceOrder.Size = new System.Drawing.Size(301, 452);
            this.pnlPlaceOrder.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(16, 396);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(270, 47);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseEnter += new System.EventHandler(this.btnOrder_MouseEnter);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            // 
            // lblInsufficientBalance
            // 
            this.lblInsufficientBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblInsufficientBalance.AutoSize = true;
            this.lblInsufficientBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInsufficientBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsufficientBalance.ForeColor = System.Drawing.Color.White;
            this.lblInsufficientBalance.Location = new System.Drawing.Point(86, 376);
            this.lblInsufficientBalance.Name = "lblInsufficientBalance";
            this.lblInsufficientBalance.Size = new System.Drawing.Size(110, 15);
            this.lblInsufficientBalance.TabIndex = 5;
            this.lblInsufficientBalance.Text = "Insufficient Balance";
            this.lblInsufficientBalance.Visible = false;
            // 
            // pnlItemDetails
            // 
            this.pnlItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemDetails.AutoScroll = true;
            this.pnlItemDetails.Controls.Add(this.pnlQuantity);
            this.pnlItemDetails.Controls.Add(this.pnlStrip);
            this.pnlItemDetails.Controls.Add(this.lblAvailability);
            this.pnlItemDetails.Controls.Add(this.lblCategory);
            this.pnlItemDetails.Controls.Add(this.lblDuration);
            this.pnlItemDetails.Controls.Add(this.lblPrice);
            this.pnlItemDetails.Controls.Add(this.lblDescription);
            this.pnlItemDetails.Controls.Add(this.lblNameFood);
            this.pnlItemDetails.Location = new System.Drawing.Point(16, 198);
            this.pnlItemDetails.Name = "pnlItemDetails";
            this.pnlItemDetails.Size = new System.Drawing.Size(270, 175);
            this.pnlItemDetails.TabIndex = 3;
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Controls.Add(this.lblQuantity);
            this.pnlQuantity.Controls.Add(this.txtQuantity);
            this.pnlQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuantity.Location = new System.Drawing.Point(0, 129);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(270, 32);
            this.pnlQuantity.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuantity.Location = new System.Drawing.Point(0, 6);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 17);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtQuantity.Location = new System.Drawing.Point(73, 5);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(59, 23);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // pnlStrip
            // 
            this.pnlStrip.BackColor = System.Drawing.Color.White;
            this.pnlStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStrip.Location = new System.Drawing.Point(0, 128);
            this.pnlStrip.Name = "pnlStrip";
            this.pnlStrip.Size = new System.Drawing.Size(270, 1);
            this.pnlStrip.TabIndex = 10;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.Color.White;
            this.lblAvailability.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAvailability.Location = new System.Drawing.Point(0, 107);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAvailability.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblAvailability.Size = new System.Drawing.Size(270, 21);
            this.lblAvailability.TabIndex = 9;
            this.lblAvailability.Text = "-";
            this.lblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCategory.Location = new System.Drawing.Point(0, 88);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblCategory.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblCategory.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblCategory.Size = new System.Drawing.Size(270, 19);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category: -";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDuration.Location = new System.Drawing.Point(0, 69);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDuration.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblDuration.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblDuration.Size = new System.Drawing.Size(270, 19);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duration: -";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(0, 50);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPrice.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblPrice.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblPrice.Size = new System.Drawing.Size(270, 19);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price: -";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescription.Location = new System.Drawing.Point(0, 28);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDescription.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblDescription.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDescription.Size = new System.Drawing.Size(270, 22);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "-";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.ForeColor = System.Drawing.Color.White;
            this.lblNameFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNameFood.Location = new System.Drawing.Point(0, 0);
            this.lblNameFood.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblNameFood.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(270, 28);
            this.lblNameFood.TabIndex = 4;
            this.lblNameFood.Text = "Please choose one item.";
            this.lblNameFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbItemImage
            // 
            this.pbItemImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbItemImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbItemImage.Location = new System.Drawing.Point(60, 12);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(180, 180);
            this.pbItemImage.TabIndex = 1;
            this.pbItemImage.TabStop = false;
            // 
            // laypanMenu
            // 
            this.laypanMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laypanMenu.AutoScroll = true;
            this.laypanMenu.Location = new System.Drawing.Point(0, 36);
            this.laypanMenu.Name = "laypanMenu";
            this.laypanMenu.Padding = new System.Windows.Forms.Padding(5);
            this.laypanMenu.Size = new System.Drawing.Size(485, 424);
            this.laypanMenu.TabIndex = 0;
            // 
            // cbSortBy
            // 
            this.cbSortBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cbSortBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSortBy.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbSortBy.FormattingEnabled = true;
            this.cbSortBy.Items.AddRange(new object[] {
            "Name (A-Z)",
            "Name (Z-A)",
            "Price (Low to High)",
            "Price (High to Low)",
            "Category (A-Z)",
            "Category (Z-A)",
            "Fastest",
            "Slowest"});
            this.cbSortBy.Location = new System.Drawing.Point(71, 5);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(189, 25);
            this.cbSortBy.TabIndex = 0;
            this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSortBy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblSortBy.Location = new System.Drawing.Point(0, 5);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Padding = new System.Windows.Forms.Padding(10, 2, 5, 0);
            this.lblSortBy.Size = new System.Drawing.Size(71, 19);
            this.lblSortBy.TabIndex = 2;
            this.lblSortBy.Text = "Sort By:";
            // 
            // pnlSortBy
            // 
            this.pnlSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSortBy.BackColor = System.Drawing.Color.Transparent;
            this.pnlSortBy.Controls.Add(this.cbSortBy);
            this.pnlSortBy.Controls.Add(this.lblSortBy);
            this.pnlSortBy.Location = new System.Drawing.Point(0, 0);
            this.pnlSortBy.Name = "pnlSortBy";
            this.pnlSortBy.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlSortBy.Size = new System.Drawing.Size(485, 35);
            this.pnlSortBy.TabIndex = 3;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(804, 468);
            this.Controls.Add(this.pnlSortBy);
            this.Controls.Add(this.pnlPlaceOrder);
            this.Controls.Add(this.laypanMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.pnlPlaceOrder.ResumeLayout(false);
            this.pnlPlaceOrder.PerformLayout();
            this.pnlItemDetails.ResumeLayout(false);
            this.pnlItemDetails.PerformLayout();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.pnlSortBy.ResumeLayout(false);
            this.pnlSortBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPlaceOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Label lblNameFood;
        private System.Windows.Forms.Panel pnlItemDetails;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.FlowLayoutPanel laypanMenu;
        private System.Windows.Forms.Panel pnlStrip;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblInsufficientBalance;
        private System.Windows.Forms.Panel pnlQuantity;
        private System.Windows.Forms.ComboBox cbSortBy;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Panel pnlSortBy;
    }
}