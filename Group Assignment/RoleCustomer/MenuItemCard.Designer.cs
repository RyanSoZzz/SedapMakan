namespace Group_Assignment.RoleCustomer
{
    partial class MenuItemCard
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
            this.pnlItemCard = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.pnlItemCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlItemCard
            // 
            this.pnlItemCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlItemCard.Controls.Add(this.lblName);
            this.pnlItemCard.Controls.Add(this.pbItemImage);
            this.pnlItemCard.Location = new System.Drawing.Point(0, 0);
            this.pnlItemCard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlItemCard.Name = "pnlItemCard";
            this.pnlItemCard.Size = new System.Drawing.Size(210, 250);
            this.pnlItemCard.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(10, 207);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(190, 34);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "The Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // pbItemImage
            // 
            this.pbItemImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbItemImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbItemImage.Location = new System.Drawing.Point(10, 10);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(190, 190);
            this.pbItemImage.TabIndex = 2;
            this.pbItemImage.TabStop = false;
            // 
            // MenuItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlItemCard);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MenuItemCard";
            this.Size = new System.Drawing.Size(210, 250);
            this.pnlItemCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlItemCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbItemImage;
    }
}
