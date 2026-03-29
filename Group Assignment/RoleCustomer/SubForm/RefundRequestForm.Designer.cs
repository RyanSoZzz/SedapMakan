namespace Group_Assignment.RoleCustomer.SubForm
{
    partial class RefundRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundRequestForm));
            this.butExit = new System.Windows.Forms.Button();
            this.lblRefund = new System.Windows.Forms.Label();
            this.pnlRefundRequestDetail = new System.Windows.Forms.Panel();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.pnlConfirm = new System.Windows.Forms.Panel();
            this.pnlRefundRequestDetail.SuspendLayout();
            this.pnlConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.BackColor = System.Drawing.Color.IndianRed;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Image = ((System.Drawing.Image)(resources.GetObject("butExit.Image")));
            this.butExit.Location = new System.Drawing.Point(522, -1);
            this.butExit.Margin = new System.Windows.Forms.Padding(0);
            this.butExit.MaximumSize = new System.Drawing.Size(70, 32);
            this.butExit.MinimumSize = new System.Drawing.Size(70, 32);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(70, 32);
            this.butExit.TabIndex = 11;
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefund.ForeColor = System.Drawing.Color.White;
            this.lblRefund.Location = new System.Drawing.Point(12, 47);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(223, 38);
            this.lblRefund.TabIndex = 12;
            this.lblRefund.Text = "Refund Request";
            // 
            // pnlRefundRequestDetail
            // 
            this.pnlRefundRequestDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRefundRequestDetail.Controls.Add(this.lblInvalid);
            this.pnlRefundRequestDetail.Controls.Add(this.txtReason);
            this.pnlRefundRequestDetail.Location = new System.Drawing.Point(150, 112);
            this.pnlRefundRequestDetail.Name = "pnlRefundRequestDetail";
            this.pnlRefundRequestDetail.Size = new System.Drawing.Size(361, 54);
            this.pnlRefundRequestDetail.TabIndex = 19;
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvalid.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalid.Location = new System.Drawing.Point(0, 30);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(13, 17);
            this.lblInvalid.TabIndex = 13;
            this.lblInvalid.Text = "-";
            this.lblInvalid.Visible = false;
            // 
            // txtReason
            // 
            this.txtReason.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(0, 0);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(361, 30);
            this.txtReason.TabIndex = 12;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblReason.Location = new System.Drawing.Point(14, 110);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(77, 28);
            this.lblReason.TabIndex = 18;
            this.lblReason.Text = "Reason";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(374, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 41);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseEnter += new System.EventHandler(this.btnSubmit_MouseEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.AutoSize = true;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Red;
            this.btnNo.Location = new System.Drawing.Point(143, 32);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(125, 41);
            this.btnNo.TabIndex = 21;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            this.btnNo.MouseEnter += new System.EventHandler(this.btnNo_MouseEnter);
            this.btnNo.MouseLeave += new System.EventHandler(this.btnNo_MouseLeave);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblConfirm.Location = new System.Drawing.Point(0, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(115, 23);
            this.lblConfirm.TabIndex = 22;
            this.lblConfirm.Text = "Are you sure?";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.AutoSize = true;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.Lime;
            this.btnYes.Location = new System.Drawing.Point(0, 32);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(127, 41);
            this.btnYes.TabIndex = 23;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            this.btnYes.MouseEnter += new System.EventHandler(this.btnYes_MouseEnter);
            this.btnYes.MouseLeave += new System.EventHandler(this.btnYes_MouseLeave);
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConfirm.BackColor = System.Drawing.Color.Transparent;
            this.pnlConfirm.Controls.Add(this.lblConfirm);
            this.pnlConfirm.Controls.Add(this.btnNo);
            this.pnlConfirm.Controls.Add(this.btnYes);
            this.pnlConfirm.Enabled = false;
            this.pnlConfirm.Location = new System.Drawing.Point(243, 189);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Size = new System.Drawing.Size(268, 73);
            this.pnlConfirm.TabIndex = 20;
            this.pnlConfirm.Visible = false;
            // 
            // RefundRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(590, 279);
            this.Controls.Add(this.pnlConfirm);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlRefundRequestDetail);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblRefund);
            this.Controls.Add(this.butExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RefundRequestForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RefundRequestForm";
            this.pnlRefundRequestDetail.ResumeLayout(false);
            this.pnlRefundRequestDetail.PerformLayout();
            this.pnlConfirm.ResumeLayout(false);
            this.pnlConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label lblRefund;
        private System.Windows.Forms.Panel pnlRefundRequestDetail;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Panel pnlConfirm;
    }
}