namespace Group_Assignment.RoleCustomer
{
    partial class GiveFeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveFeedbackForm));
            this.lblGiveFeedback = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.numudRating = new System.Windows.Forms.NumericUpDown();
            this.lblStar = new System.Windows.Forms.Label();
            this.pnlFeedbackDetails = new System.Windows.Forms.Panel();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numudRating)).BeginInit();
            this.pnlFeedbackDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGiveFeedback
            // 
            this.lblGiveFeedback.AutoSize = true;
            this.lblGiveFeedback.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiveFeedback.ForeColor = System.Drawing.Color.Yellow;
            this.lblGiveFeedback.Location = new System.Drawing.Point(12, 47);
            this.lblGiveFeedback.Name = "lblGiveFeedback";
            this.lblGiveFeedback.Size = new System.Drawing.Size(206, 38);
            this.lblGiveFeedback.TabIndex = 0;
            this.lblGiveFeedback.Text = "Give Feedback";
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.BackColor = System.Drawing.Color.IndianRed;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Image = ((System.Drawing.Image)(resources.GetObject("butExit.Image")));
            this.butExit.Location = new System.Drawing.Point(461, -1);
            this.butExit.Margin = new System.Windows.Forms.Padding(0);
            this.butExit.MaximumSize = new System.Drawing.Size(70, 32);
            this.butExit.MinimumSize = new System.Drawing.Size(70, 32);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(70, 32);
            this.butExit.TabIndex = 10;
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblFeedback.Location = new System.Drawing.Point(14, 160);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(98, 28);
            this.lblFeedback.TabIndex = 11;
            this.lblFeedback.Text = "Feedback";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFeedback.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(0, 0);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(368, 30);
            this.txtFeedback.TabIndex = 12;
            this.txtFeedback.Click += new System.EventHandler(this.txtFeedback_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRating.Location = new System.Drawing.Point(14, 106);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(70, 28);
            this.lblRating.TabIndex = 13;
            this.lblRating.Text = "Rating";
            // 
            // numudRating
            // 
            this.numudRating.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudRating.Location = new System.Drawing.Point(150, 109);
            this.numudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numudRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudRating.Name = "numudRating";
            this.numudRating.ReadOnly = true;
            this.numudRating.Size = new System.Drawing.Size(41, 30);
            this.numudRating.TabIndex = 15;
            this.numudRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numudRating.ValueChanged += new System.EventHandler(this.numudRating_ValueChanged);
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStar.ForeColor = System.Drawing.Color.Yellow;
            this.lblStar.Location = new System.Drawing.Point(197, 109);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(102, 28);
            this.lblStar.TabIndex = 16;
            this.lblStar.Text = "⭐⭐⭐⭐⭐";
            // 
            // pnlFeedbackDetails
            // 
            this.pnlFeedbackDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFeedbackDetails.Controls.Add(this.lblInvalid);
            this.pnlFeedbackDetails.Controls.Add(this.txtFeedback);
            this.pnlFeedbackDetails.Location = new System.Drawing.Point(150, 162);
            this.pnlFeedbackDetails.Name = "pnlFeedbackDetails";
            this.pnlFeedbackDetails.Size = new System.Drawing.Size(368, 54);
            this.pnlFeedbackDetails.TabIndex = 17;
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
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmit.Location = new System.Drawing.Point(381, 249);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 41);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseEnter += new System.EventHandler(this.btnSubmit_MouseEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            // 
            // GiveFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(530, 302);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlFeedbackDetails);
            this.Controls.Add(this.lblStar);
            this.Controls.Add(this.numudRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.lblGiveFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiveFeedbackForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GiveFeedbackForm";
            ((System.ComponentModel.ISupportInitialize)(this.numudRating)).EndInit();
            this.pnlFeedbackDetails.ResumeLayout(false);
            this.pnlFeedbackDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiveFeedback;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown numudRating;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Panel pnlFeedbackDetails;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Button btnSubmit;
    }
}