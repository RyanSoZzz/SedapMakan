namespace Group_Assignment.RoleCustomer
{
    partial class OrderItemBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOrderItemBlock = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblOrderItemID = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemQuantitiy = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlOrderItemBlock.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderItemBlock
            // 
            this.pnlOrderItemBlock.Controls.Add(this.panel3);
            this.pnlOrderItemBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderItemBlock.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderItemBlock.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOrderItemBlock.Name = "pnlOrderItemBlock";
            this.pnlOrderItemBlock.Size = new System.Drawing.Size(779, 127);
            this.pnlOrderItemBlock.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.lblOrderItemID);
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.lblItemQuantitiy);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Location = new System.Drawing.Point(0, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 113);
            this.panel3.TabIndex = 3;
            // 
            // lblOrderItemID
            // 
            this.lblOrderItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrderItemID.AutoSize = true;
            this.lblOrderItemID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItemID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblOrderItemID.Location = new System.Drawing.Point(15, 86);
            this.lblOrderItemID.Name = "lblOrderItemID";
            this.lblOrderItemID.Size = new System.Drawing.Size(13, 17);
            this.lblOrderItemID.TabIndex = 6;
            this.lblOrderItemID.Text = "-";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblPrice.Location = new System.Drawing.Point(295, 86);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(176, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price = 17.98 (MYR8.99/Each)";
            // 
            // lblItemQuantitiy
            // 
            this.lblItemQuantitiy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItemQuantitiy.AutoSize = true;
            this.lblItemQuantitiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantitiy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblItemQuantitiy.Location = new System.Drawing.Point(295, 68);
            this.lblItemQuantitiy.Name = "lblItemQuantitiy";
            this.lblItemQuantitiy.Size = new System.Drawing.Size(83, 17);
            this.lblItemQuantitiy.TabIndex = 4;
            this.lblItemQuantitiy.Text = "Quantitiy = 2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblName.Location = new System.Drawing.Point(11, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(252, 38);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name of the food";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStatus.Location = new System.Drawing.Point(549, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(239, 31);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: In Progress";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderItemBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlOrderItemBlock);
            this.Name = "OrderItemBlock";
            this.Size = new System.Drawing.Size(779, 127);
            this.pnlOrderItemBlock.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderItemBlock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemQuantitiy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOrderItemID;
    }
}
