namespace Group_Assignment.roleadmin.Forms
{
    partial class formCustomerReportAdmin
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
            this.lblTotalCustomerResult = new System.Windows.Forms.Label();
            this.lblTotalCustomer = new System.Windows.Forms.Label();
            this.lblOrderedResult = new System.Windows.Forms.Label();
            this.lblOrdered = new System.Windows.Forms.Label();
            this.btnFilterCust = new System.Windows.Forms.Button();
            this.txtboxSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.dataGridTopUp = new System.Windows.Forms.DataGridView();
            this.lblTopUpResult = new System.Windows.Forms.Label();
            this.lblTopUp = new System.Windows.Forms.Label();
            this.btnCustReport = new System.Windows.Forms.Button();
            this.comboxFilterCust = new System.Windows.Forms.ComboBox();
            this.lblTimeCust = new System.Windows.Forms.Label();
            this.lblCustIDFilter = new System.Windows.Forms.Label();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.txtboxCustIDFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTopUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCustomerResult
            // 
            this.lblTotalCustomerResult.AutoSize = true;
            this.lblTotalCustomerResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCustomerResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTotalCustomerResult.Location = new System.Drawing.Point(17, 52);
            this.lblTotalCustomerResult.Name = "lblTotalCustomerResult";
            this.lblTotalCustomerResult.Size = new System.Drawing.Size(2, 25);
            this.lblTotalCustomerResult.TabIndex = 14;
            // 
            // lblTotalCustomer
            // 
            this.lblTotalCustomer.AutoSize = true;
            this.lblTotalCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblTotalCustomer.Location = new System.Drawing.Point(12, 19);
            this.lblTotalCustomer.Name = "lblTotalCustomer";
            this.lblTotalCustomer.Size = new System.Drawing.Size(147, 25);
            this.lblTotalCustomer.TabIndex = 13;
            this.lblTotalCustomer.Text = "Total Customer:";
            // 
            // lblOrderedResult
            // 
            this.lblOrderedResult.AutoSize = true;
            this.lblOrderedResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderedResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderedResult.Location = new System.Drawing.Point(108, 97);
            this.lblOrderedResult.Name = "lblOrderedResult";
            this.lblOrderedResult.Size = new System.Drawing.Size(2, 22);
            this.lblOrderedResult.TabIndex = 16;
            // 
            // lblOrdered
            // 
            this.lblOrdered.AutoSize = true;
            this.lblOrdered.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrdered.Location = new System.Drawing.Point(13, 96);
            this.lblOrdered.Name = "lblOrdered";
            this.lblOrdered.Size = new System.Drawing.Size(83, 20);
            this.lblOrdered.TabIndex = 15;
            this.lblOrdered.Text = "# Ordered:";
            // 
            // btnFilterCust
            // 
            this.btnFilterCust.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnFilterCust.Location = new System.Drawing.Point(665, 22);
            this.btnFilterCust.Name = "btnFilterCust";
            this.btnFilterCust.Size = new System.Drawing.Size(120, 40);
            this.btnFilterCust.TabIndex = 21;
            this.btnFilterCust.Text = "Filter";
            this.btnFilterCust.UseVisualStyleBackColor = true;
            this.btnFilterCust.Click += new System.EventHandler(this.btnFilterCust_Click);
            // 
            // txtboxSearchCustomer
            // 
            this.txtboxSearchCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.txtboxSearchCustomer.Location = new System.Drawing.Point(179, 44);
            this.txtboxSearchCustomer.Name = "txtboxSearchCustomer";
            this.txtboxSearchCustomer.Size = new System.Drawing.Size(103, 25);
            this.txtboxSearchCustomer.TabIndex = 24;
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSearchCustomer.Location = new System.Drawing.Point(176, 21);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(98, 17);
            this.lblSearchCustomer.TabIndex = 25;
            this.lblSearchCustomer.Text = "Enter ID/Name";
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.AllowUserToOrderColumns = true;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(12, 123);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowHeadersWidth = 51;
            this.dataGridOrder.RowTemplate.Height = 24;
            this.dataGridOrder.Size = new System.Drawing.Size(375, 300);
            this.dataGridOrder.TabIndex = 28;
            // 
            // dataGridTopUp
            // 
            this.dataGridTopUp.AllowUserToAddRows = false;
            this.dataGridTopUp.AllowUserToDeleteRows = false;
            this.dataGridTopUp.AllowUserToOrderColumns = true;
            this.dataGridTopUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTopUp.Location = new System.Drawing.Point(410, 123);
            this.dataGridTopUp.Name = "dataGridTopUp";
            this.dataGridTopUp.ReadOnly = true;
            this.dataGridTopUp.RowHeadersWidth = 51;
            this.dataGridTopUp.RowTemplate.Height = 24;
            this.dataGridTopUp.Size = new System.Drawing.Size(375, 300);
            this.dataGridTopUp.TabIndex = 31;
            // 
            // lblTopUpResult
            // 
            this.lblTopUpResult.AutoSize = true;
            this.lblTopUpResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTopUpResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTopUpResult.Location = new System.Drawing.Point(495, 98);
            this.lblTopUpResult.Name = "lblTopUpResult";
            this.lblTopUpResult.Size = new System.Drawing.Size(2, 22);
            this.lblTopUpResult.TabIndex = 30;
            // 
            // lblTopUp
            // 
            this.lblTopUp.AutoSize = true;
            this.lblTopUp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTopUp.Location = new System.Drawing.Point(406, 97);
            this.lblTopUp.Name = "lblTopUp";
            this.lblTopUp.Size = new System.Drawing.Size(77, 20);
            this.lblTopUp.TabIndex = 29;
            this.lblTopUp.Text = "# Top-Up:";
            // 
            // btnCustReport
            // 
            this.btnCustReport.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnCustReport.Location = new System.Drawing.Point(299, 21);
            this.btnCustReport.Name = "btnCustReport";
            this.btnCustReport.Size = new System.Drawing.Size(125, 53);
            this.btnCustReport.TabIndex = 32;
            this.btnCustReport.Text = "Generate Customer Report";
            this.btnCustReport.UseVisualStyleBackColor = true;
            this.btnCustReport.Click += new System.EventHandler(this.btnCustReport_Click);
            // 
            // comboxFilterCust
            // 
            this.comboxFilterCust.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.comboxFilterCust.FormattingEnabled = true;
            this.comboxFilterCust.Items.AddRange(new object[] {
            "All-Time",
            "Monthly",
            "Yearly"});
            this.comboxFilterCust.Location = new System.Drawing.Point(549, 45);
            this.comboxFilterCust.Name = "comboxFilterCust";
            this.comboxFilterCust.Size = new System.Drawing.Size(99, 25);
            this.comboxFilterCust.TabIndex = 33;
            // 
            // lblTimeCust
            // 
            this.lblTimeCust.AutoSize = true;
            this.lblTimeCust.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.lblTimeCust.Location = new System.Drawing.Point(549, 22);
            this.lblTimeCust.Name = "lblTimeCust";
            this.lblTimeCust.Size = new System.Drawing.Size(47, 23);
            this.lblTimeCust.TabIndex = 34;
            this.lblTimeCust.Text = "Time";
            // 
            // lblCustIDFilter
            // 
            this.lblCustIDFilter.AutoSize = true;
            this.lblCustIDFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustIDFilter.Location = new System.Drawing.Point(437, 22);
            this.lblCustIDFilter.Name = "lblCustIDFilter";
            this.lblCustIDFilter.Size = new System.Drawing.Size(93, 20);
            this.lblCustIDFilter.TabIndex = 36;
            this.lblCustIDFilter.Text = "Customer ID";
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.buttonClearFilter.Location = new System.Drawing.Point(665, 68);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(120, 40);
            this.buttonClearFilter.TabIndex = 37;
            this.buttonClearFilter.Text = "Clear Filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // txtboxCustIDFilter
            // 
            this.txtboxCustIDFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.txtboxCustIDFilter.Location = new System.Drawing.Point(440, 45);
            this.txtboxCustIDFilter.Name = "txtboxCustIDFilter";
            this.txtboxCustIDFilter.Size = new System.Drawing.Size(103, 25);
            this.txtboxCustIDFilter.TabIndex = 38;
            // 
            // formCustomerReportAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxCustIDFilter);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.lblCustIDFilter);
            this.Controls.Add(this.lblTimeCust);
            this.Controls.Add(this.comboxFilterCust);
            this.Controls.Add(this.btnCustReport);
            this.Controls.Add(this.dataGridTopUp);
            this.Controls.Add(this.lblTopUpResult);
            this.Controls.Add(this.lblTopUp);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.txtboxSearchCustomer);
            this.Controls.Add(this.btnFilterCust);
            this.Controls.Add(this.lblOrderedResult);
            this.Controls.Add(this.lblOrdered);
            this.Controls.Add(this.lblTotalCustomerResult);
            this.Controls.Add(this.lblTotalCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCustomerReportAdmin";
            this.Text = "formCustomerReportAdmin";
            this.Activated += new System.EventHandler(this.formCustomerReportAdmin_Activated);
            this.Load += new System.EventHandler(this.formCustomerReportAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTopUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalCustomerResult;
        private System.Windows.Forms.Label lblTotalCustomer;
        private System.Windows.Forms.Label lblOrderedResult;
        private System.Windows.Forms.Label lblOrdered;
        private System.Windows.Forms.Button btnFilterCust;
        private System.Windows.Forms.TextBox txtboxSearchCustomer;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.DataGridView dataGridTopUp;
        private System.Windows.Forms.Label lblTopUpResult;
        private System.Windows.Forms.Label lblTopUp;
        private System.Windows.Forms.Button btnCustReport;
        private System.Windows.Forms.ComboBox comboxFilterCust;
        private System.Windows.Forms.Label lblTimeCust;
        private System.Windows.Forms.Label lblCustIDFilter;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.TextBox txtboxCustIDFilter;
    }
}