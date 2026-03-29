namespace Group_Assignment.roleadmin.Forms
{
    partial class formChefReportAdmin
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
            this.btnChefReport = new System.Windows.Forms.Button();
            this.dataGridSales = new System.Windows.Forms.DataGridView();
            this.lblSearchChef = new System.Windows.Forms.Label();
            this.txtboxSearchChef = new System.Windows.Forms.TextBox();
            this.btnFilterChef = new System.Windows.Forms.Button();
            this.lblSalesResult = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblTotalChefResult = new System.Windows.Forms.Label();
            this.lblTotalChef = new System.Windows.Forms.Label();
            this.lblCategoryChef = new System.Windows.Forms.Label();
            this.lblTimeChef = new System.Windows.Forms.Label();
            this.comboxFilterChef = new System.Windows.Forms.ComboBox();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.btnClearChef = new System.Windows.Forms.Button();
            this.txtBoxCategoryFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChefReport
            // 
            this.btnChefReport.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnChefReport.Location = new System.Drawing.Point(292, 26);
            this.btnChefReport.Name = "btnChefReport";
            this.btnChefReport.Size = new System.Drawing.Size(125, 53);
            this.btnChefReport.TabIndex = 45;
            this.btnChefReport.Text = "Generate Chef Report";
            this.btnChefReport.UseVisualStyleBackColor = true;
            this.btnChefReport.Click += new System.EventHandler(this.btnChefReport_Click);
            // 
            // dataGridSales
            // 
            this.dataGridSales.AllowUserToAddRows = false;
            this.dataGridSales.AllowUserToDeleteRows = false;
            this.dataGridSales.AllowUserToOrderColumns = true;
            this.dataGridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSales.Location = new System.Drawing.Point(12, 129);
            this.dataGridSales.Name = "dataGridSales";
            this.dataGridSales.ReadOnly = true;
            this.dataGridSales.RowHeadersWidth = 51;
            this.dataGridSales.RowTemplate.Height = 24;
            this.dataGridSales.Size = new System.Drawing.Size(776, 250);
            this.dataGridSales.TabIndex = 41;
            // 
            // lblSearchChef
            // 
            this.lblSearchChef.AutoSize = true;
            this.lblSearchChef.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.lblSearchChef.Location = new System.Drawing.Point(161, 23);
            this.lblSearchChef.Name = "lblSearchChef";
            this.lblSearchChef.Size = new System.Drawing.Size(125, 23);
            this.lblSearchChef.TabIndex = 40;
            this.lblSearchChef.Text = "Enter ID/Name";
            // 
            // txtboxSearchChef
            // 
            this.txtboxSearchChef.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearchChef.Location = new System.Drawing.Point(165, 49);
            this.txtboxSearchChef.Name = "txtboxSearchChef";
            this.txtboxSearchChef.Size = new System.Drawing.Size(107, 25);
            this.txtboxSearchChef.TabIndex = 39;

            // 
            // btnFilterChef
            // 
            this.btnFilterChef.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnFilterChef.Location = new System.Drawing.Point(668, 29);
            this.btnFilterChef.Name = "btnFilterChef";
            this.btnFilterChef.Size = new System.Drawing.Size(120, 50);
            this.btnFilterChef.TabIndex = 38;
            this.btnFilterChef.Text = "Filter";
            this.btnFilterChef.UseVisualStyleBackColor = true;
            this.btnFilterChef.Click += new System.EventHandler(this.btnFilterChef_Click);
            // 
            // lblSalesResult
            // 
            this.lblSalesResult.AutoSize = true;
            this.lblSalesResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalesResult.Location = new System.Drawing.Point(108, 94);
            this.lblSalesResult.Name = "lblSalesResult";
            this.lblSalesResult.Size = new System.Drawing.Size(2, 25);
            this.lblSalesResult.TabIndex = 37;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSales.Location = new System.Drawing.Point(13, 93);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(67, 23);
            this.lblSales.TabIndex = 36;
            this.lblSales.Text = "# Sales:";
            // 
            // lblTotalChefResult
            // 
            this.lblTotalChefResult.AutoSize = true;
            this.lblTotalChefResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalChefResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalChefResult.Location = new System.Drawing.Point(17, 54);
            this.lblTotalChefResult.Name = "lblTotalChefResult";
            this.lblTotalChefResult.Size = new System.Drawing.Size(2, 25);
            this.lblTotalChefResult.TabIndex = 35;
            // 
            // lblTotalChef
            // 
            this.lblTotalChef.AutoSize = true;
            this.lblTotalChef.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalChef.Location = new System.Drawing.Point(12, 21);
            this.lblTotalChef.Name = "lblTotalChef";
            this.lblTotalChef.Size = new System.Drawing.Size(109, 28);
            this.lblTotalChef.TabIndex = 34;
            this.lblTotalChef.Text = "Total Chef:";
            // 
            // lblCategoryChef
            // 
            this.lblCategoryChef.AutoSize = true;
            this.lblCategoryChef.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoryChef.Location = new System.Drawing.Point(443, 26);
            this.lblCategoryChef.Name = "lblCategoryChef";
            this.lblCategoryChef.Size = new System.Drawing.Size(72, 20);
            this.lblCategoryChef.TabIndex = 47;
            this.lblCategoryChef.Text = "Category";
            // 
            // lblTimeChef
            // 
            this.lblTimeChef.AutoSize = true;
            this.lblTimeChef.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimeChef.Location = new System.Drawing.Point(562, 26);
            this.lblTimeChef.Name = "lblTimeChef";
            this.lblTimeChef.Size = new System.Drawing.Size(42, 20);
            this.lblTimeChef.TabIndex = 49;
            this.lblTimeChef.Text = "Time";
            // 
            // comboxFilterChef
            // 
            this.comboxFilterChef.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.comboxFilterChef.FormattingEnabled = true;
            this.comboxFilterChef.Items.AddRange(new object[] {
            "All-Time",
            "Monthly",
            "Yearly"});
            this.comboxFilterChef.Location = new System.Drawing.Point(553, 49);
            this.comboxFilterChef.Name = "comboxFilterChef";
            this.comboxFilterChef.Size = new System.Drawing.Size(107, 25);
            this.comboxFilterChef.TabIndex = 48;
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnViewMenu.Location = new System.Drawing.Point(12, 385);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(125, 53);
            this.btnViewMenu.TabIndex = 50;
            this.btnViewMenu.Text = "View Menu";
            this.btnViewMenu.UseVisualStyleBackColor = true;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // btnClearChef
            // 
            this.btnClearChef.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnClearChef.Location = new System.Drawing.Point(668, 388);
            this.btnClearChef.Name = "btnClearChef";
            this.btnClearChef.Size = new System.Drawing.Size(120, 50);
            this.btnClearChef.TabIndex = 51;
            this.btnClearChef.Text = "Clear Filters";
            this.btnClearChef.UseVisualStyleBackColor = true;
            this.btnClearChef.Click += new System.EventHandler(this.btnClearChef_Click);
            // 
            // txtBoxCategoryFilter
            // 
            this.txtBoxCategoryFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCategoryFilter.Location = new System.Drawing.Point(440, 49);
            this.txtBoxCategoryFilter.Name = "txtBoxCategoryFilter";
            this.txtBoxCategoryFilter.Size = new System.Drawing.Size(107, 25);
            this.txtBoxCategoryFilter.TabIndex = 52;
            // 
            // formChefReportAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxCategoryFilter);
            this.Controls.Add(this.btnClearChef);
            this.Controls.Add(this.btnViewMenu);
            this.Controls.Add(this.lblTimeChef);
            this.Controls.Add(this.comboxFilterChef);
            this.Controls.Add(this.lblCategoryChef);
            this.Controls.Add(this.btnChefReport);
            this.Controls.Add(this.dataGridSales);
            this.Controls.Add(this.lblSearchChef);
            this.Controls.Add(this.txtboxSearchChef);
            this.Controls.Add(this.btnFilterChef);
            this.Controls.Add(this.lblSalesResult);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblTotalChefResult);
            this.Controls.Add(this.lblTotalChef);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formChefReportAdmin";
            this.Text = "formChefReportAdmin";
            this.Activated += new System.EventHandler(this.formChefReportAdmin_Activated);
            this.Load += new System.EventHandler(this.formChefReportAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChefReport;
        private System.Windows.Forms.DataGridView dataGridSales;
        private System.Windows.Forms.Label lblSearchChef;
        private System.Windows.Forms.TextBox txtboxSearchChef;
        private System.Windows.Forms.Button btnFilterChef;
        private System.Windows.Forms.Label lblSalesResult;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblTotalChefResult;
        private System.Windows.Forms.Label lblTotalChef;
        private System.Windows.Forms.Label lblCategoryChef;
        private System.Windows.Forms.Label lblTimeChef;
        private System.Windows.Forms.ComboBox comboxFilterChef;
        private System.Windows.Forms.Button btnViewMenu;
        private System.Windows.Forms.Button btnClearChef;
        private System.Windows.Forms.TextBox txtBoxCategoryFilter;
    }
}