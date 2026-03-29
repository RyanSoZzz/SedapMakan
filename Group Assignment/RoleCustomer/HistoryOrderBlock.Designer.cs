namespace Group_Assignment.RoleCustomer
{
    partial class HistoryOrderBlock
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.pnlStar = new System.Windows.Forms.Panel();
            this.lblRating = new System.Windows.Forms.Label();
            this.btnGiveFeedback = new System.Windows.Forms.Button();
            this.btnViewItem = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblTotalOrderFee = new System.Windows.Forms.Label();
            this.pnlOrderItemBlock.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlStar.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderItemBlock
            // 
            this.pnlOrderItemBlock.AutoSize = true;
            this.pnlOrderItemBlock.Controls.Add(this.pnlBackground);
            this.pnlOrderItemBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderItemBlock.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderItemBlock.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOrderItemBlock.Name = "pnlOrderItemBlock";
            this.pnlOrderItemBlock.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlOrderItemBlock.Size = new System.Drawing.Size(779, 190);
            this.pnlOrderItemBlock.TabIndex = 6;
            // 
            // pnlBackground
            // 
            this.pnlBackground.AutoSize = true;
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlBackground.Controls.Add(this.panel1);
            this.pnlBackground.Controls.Add(this.btnCancel);
            this.pnlBackground.Controls.Add(this.btnRefund);
            this.pnlBackground.Controls.Add(this.pnlStar);
            this.pnlBackground.Controls.Add(this.btnGiveFeedback);
            this.pnlBackground.Controls.Add(this.btnViewItem);
            this.pnlBackground.Controls.Add(this.lblStatus);
            this.pnlBackground.Controls.Add(this.pnlDetails);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 5);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(779, 180);
            this.pnlBackground.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblOrderID);
            this.panel1.Location = new System.Drawing.Point(21, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 74);
            this.panel1.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDate.Location = new System.Drawing.Point(0, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblDate.Size = new System.Drawing.Size(79, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "2025/07/01";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblOrderID.Location = new System.Drawing.Point(0, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(122, 38);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "OrderID";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(639, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 31);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnRefund
            // 
            this.btnRefund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefund.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefund.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefund.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefund.Location = new System.Drawing.Point(521, 100);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(112, 31);
            this.btnRefund.TabIndex = 11;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Visible = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            this.btnRefund.MouseEnter += new System.EventHandler(this.btnRefund_MouseEnter);
            this.btnRefund.MouseLeave += new System.EventHandler(this.btnRefund_MouseLeave);
            // 
            // pnlStar
            // 
            this.pnlStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStar.BackColor = System.Drawing.Color.Transparent;
            this.pnlStar.Controls.Add(this.lblRating);
            this.pnlStar.Location = new System.Drawing.Point(541, 46);
            this.pnlStar.Name = "pnlStar";
            this.pnlStar.Size = new System.Drawing.Size(210, 31);
            this.pnlStar.TabIndex = 10;
            // 
            // lblRating
            // 
            this.lblRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.Yellow;
            this.lblRating.Location = new System.Drawing.Point(0, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(210, 31);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "⭐⭐⭐⭐⭐";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRating.Visible = false;
            // 
            // btnGiveFeedback
            // 
            this.btnGiveFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiveFeedback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGiveFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGiveFeedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnGiveFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveFeedback.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveFeedback.ForeColor = System.Drawing.Color.Yellow;
            this.btnGiveFeedback.Location = new System.Drawing.Point(455, 137);
            this.btnGiveFeedback.Name = "btnGiveFeedback";
            this.btnGiveFeedback.Size = new System.Drawing.Size(178, 31);
            this.btnGiveFeedback.TabIndex = 8;
            this.btnGiveFeedback.Text = "Give Feedback";
            this.btnGiveFeedback.UseVisualStyleBackColor = true;
            this.btnGiveFeedback.Visible = false;
            this.btnGiveFeedback.Click += new System.EventHandler(this.btnGiveFeedback_Click);
            this.btnGiveFeedback.MouseEnter += new System.EventHandler(this.btnViewFeedback_MouseEnter);
            this.btnGiveFeedback.MouseLeave += new System.EventHandler(this.btnViewFeedback_MouseLeave);
            // 
            // btnViewItem
            // 
            this.btnViewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnViewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnViewItem.Location = new System.Drawing.Point(639, 137);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(112, 31);
            this.btnViewItem.TabIndex = 7;
            this.btnViewItem.Text = "View Item";
            this.btnViewItem.UseVisualStyleBackColor = true;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            this.btnViewItem.MouseEnter += new System.EventHandler(this.btnViewItem_MouseEnter);
            this.btnViewItem.MouseLeave += new System.EventHandler(this.btnViewItem_MouseLeave);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStatus.Location = new System.Drawing.Point(537, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(242, 31);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: In Progress";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetails.AutoSize = true;
            this.pnlDetails.Controls.Add(this.lblResponse);
            this.pnlDetails.Controls.Add(this.lblFeedback);
            this.pnlDetails.Controls.Add(this.lblTotalOrderFee);
            this.pnlDetails.Location = new System.Drawing.Point(18, 87);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(424, 81);
            this.pnlDetails.TabIndex = 9;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResponse.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblResponse.Location = new System.Drawing.Point(0, 22);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.lblResponse.Size = new System.Drawing.Size(67, 22);
            this.lblResponse.TabIndex = 8;
            this.lblResponse.Text = "Response:";
            this.lblResponse.Visible = false;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblFeedback.Location = new System.Drawing.Point(0, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.lblFeedback.Size = new System.Drawing.Size(67, 22);
            this.lblFeedback.TabIndex = 7;
            this.lblFeedback.Text = "Feedback:";
            this.lblFeedback.Visible = false;
            // 
            // lblTotalOrderFee
            // 
            this.lblTotalOrderFee.AutoSize = true;
            this.lblTotalOrderFee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalOrderFee.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrderFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTotalOrderFee.Location = new System.Drawing.Point(0, 59);
            this.lblTotalOrderFee.Name = "lblTotalOrderFee";
            this.lblTotalOrderFee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.lblTotalOrderFee.Size = new System.Drawing.Size(141, 22);
            this.lblTotalOrderFee.TabIndex = 6;
            this.lblTotalOrderFee.Text = "Total Fee = MYR10000";
            // 
            // HistoryOrderBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlOrderItemBlock);
            this.Name = "HistoryOrderBlock";
            this.Size = new System.Drawing.Size(779, 190);
            this.pnlOrderItemBlock.ResumeLayout(false);
            this.pnlOrderItemBlock.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlStar.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlOrderItemBlock;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Panel pnlStar;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnGiveFeedback;
        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblTotalOrderFee;
    }
}
