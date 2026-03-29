namespace Group_Assignment.RoleCustomer.SubForm
{
    partial class OnRefundRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnRefundRequestForm));
            this.butExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTotalRefund = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.BackColor = System.Drawing.Color.IndianRed;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Image = ((System.Drawing.Image)(resources.GetObject("butExit.Image")));
            this.butExit.Location = new System.Drawing.Point(278, 0);
            this.butExit.Margin = new System.Windows.Forms.Padding(0);
            this.butExit.MaximumSize = new System.Drawing.Size(70, 32);
            this.butExit.MinimumSize = new System.Drawing.Size(70, 32);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(70, 32);
            this.butExit.TabIndex = 12;
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(114, 38);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status: ";
            // 
            // lblTotalRefund
            // 
            this.lblTotalRefund.AutoSize = true;
            this.lblTotalRefund.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRefund.ForeColor = System.Drawing.Color.White;
            this.lblTotalRefund.Location = new System.Drawing.Point(19, 98);
            this.lblTotalRefund.Name = "lblTotalRefund";
            this.lblTotalRefund.Size = new System.Drawing.Size(186, 23);
            this.lblTotalRefund.TabIndex = 14;
            this.lblTotalRefund.Text = "Total Refund - MYR150";
            // 
            // OnRefundRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(348, 139);
            this.Controls.Add(this.lblTotalRefund);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.butExit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OnRefundRequestForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OnRefundRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTotalRefund;
    }
}