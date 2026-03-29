namespace Group_Assignment
{
    partial class YourOrderForm
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
            this.pnlYourOrder = new System.Windows.Forms.Panel();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlYourOrder
            // 
            this.pnlYourOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlYourOrder.AutoScroll = true;
            this.pnlYourOrder.Location = new System.Drawing.Point(13, 47);
            this.pnlYourOrder.Name = "pnlYourOrder";
            this.pnlYourOrder.Size = new System.Drawing.Size(791, 409);
            this.pnlYourOrder.TabIndex = 0;
            this.pnlYourOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlYourOrder_Paint);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(13, 13);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(85, 23);
            this.lblOrderID.TabIndex = 1;
            this.lblOrderID.Text = "OrderID: ";
            // 
            // YourOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(804, 468);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.pnlYourOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YourOrderForm";
            this.ShowInTaskbar = false;
            this.Text = "YourOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlYourOrder;
        private System.Windows.Forms.Label lblOrderID;
    }
}