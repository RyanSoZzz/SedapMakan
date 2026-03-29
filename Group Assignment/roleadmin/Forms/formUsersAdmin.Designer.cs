using Group_Assignment.roleadmin.system;
namespace Group_Assignment.roleadmin.Forms
{ 
    partial class formUsersAdmin
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
            this.btnAddUserAdmin = new System.Windows.Forms.Button();
            this.btnDeleteUserAdmin = new System.Windows.Forms.Button();
            this.btnEditUserAdmin = new System.Windows.Forms.Button();
            this.lblTotalUser = new System.Windows.Forms.Label();
            this.lblTotalUserResult = new System.Windows.Forms.Label();
            this.btnSearchAdmin = new System.Windows.Forms.Button();
            this.txtboxSearchAdmin = new System.Windows.Forms.TextBox();
            this.comboxFilterAdmin = new System.Windows.Forms.ComboBox();
            this.btnSearchFilterAdmin = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.btnClearSearchAdmin = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblRoleFilter = new System.Windows.Forms.Label();
            this.lblNumResult = new System.Windows.Forms.Label();
            this.lblNumOfAccount = new System.Windows.Forms.Label();
            this.btnMoney = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUserAdmin
            // 
            this.btnAddUserAdmin.Location = new System.Drawing.Point(542, 379);
            this.btnAddUserAdmin.Name = "btnAddUserAdmin";
            this.btnAddUserAdmin.Size = new System.Drawing.Size(120, 50);
            this.btnAddUserAdmin.TabIndex = 2;
            this.btnAddUserAdmin.Text = "Add User (+)";
            this.btnAddUserAdmin.UseVisualStyleBackColor = true;
            this.btnAddUserAdmin.Click += new System.EventHandler(this.btnAddUserAdmin_Click);
            // 
            // btnDeleteUserAdmin
            // 
            this.btnDeleteUserAdmin.Location = new System.Drawing.Point(668, 379);
            this.btnDeleteUserAdmin.Name = "btnDeleteUserAdmin";
            this.btnDeleteUserAdmin.Size = new System.Drawing.Size(120, 50);
            this.btnDeleteUserAdmin.TabIndex = 3;
            this.btnDeleteUserAdmin.Text = "Delete User (-)";
            this.btnDeleteUserAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteUserAdmin.Click += new System.EventHandler(this.btnDeleteUserAdmin_Click);
            // 
            // btnEditUserAdmin
            // 
            this.btnEditUserAdmin.Enabled = false;
            this.btnEditUserAdmin.Location = new System.Drawing.Point(16, 379);
            this.btnEditUserAdmin.Name = "btnEditUserAdmin";
            this.btnEditUserAdmin.Size = new System.Drawing.Size(120, 50);
            this.btnEditUserAdmin.TabIndex = 4;
            this.btnEditUserAdmin.Text = "Edit User";
            this.btnEditUserAdmin.UseVisualStyleBackColor = true;
            this.btnEditUserAdmin.Click += new System.EventHandler(this.btnEditUserAdmin_Click);
            // 
            // lblTotalUser
            // 
            this.lblTotalUser.AutoSize = true;
            this.lblTotalUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalUser.Location = new System.Drawing.Point(12, 20);
            this.lblTotalUser.Name = "lblTotalUser";
            this.lblTotalUser.Size = new System.Drawing.Size(126, 20);
            this.lblTotalUser.TabIndex = 5;
            this.lblTotalUser.Text = "Total Accounts:";
            // 
            // lblTotalUserResult
            // 
            this.lblTotalUserResult.AutoSize = true;
            this.lblTotalUserResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalUserResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalUserResult.Location = new System.Drawing.Point(17, 50);
            this.lblTotalUserResult.Name = "lblTotalUserResult";
            this.lblTotalUserResult.Size = new System.Drawing.Size(2, 20);
            this.lblTotalUserResult.TabIndex = 6;
            // 
            // btnSearchAdmin
            // 
            this.btnSearchAdmin.Location = new System.Drawing.Point(316, 40);
            this.btnSearchAdmin.Name = "btnSearchAdmin";
            this.btnSearchAdmin.Size = new System.Drawing.Size(92, 30);
            this.btnSearchAdmin.TabIndex = 7;
            this.btnSearchAdmin.Text = "Search";
            this.btnSearchAdmin.UseVisualStyleBackColor = true;
            this.btnSearchAdmin.Click += new System.EventHandler(this.btnSearchAdmin_Click);
            // 
            // txtboxSearchAdmin
            // 
            this.txtboxSearchAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxSearchAdmin.Location = new System.Drawing.Point(170, 40);
            this.txtboxSearchAdmin.Name = "txtboxSearchAdmin";
            this.txtboxSearchAdmin.Size = new System.Drawing.Size(140, 30);
            this.txtboxSearchAdmin.TabIndex = 8;
            // 
            // comboxFilterAdmin
            // 
            this.comboxFilterAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboxFilterAdmin.FormattingEnabled = true;
            this.comboxFilterAdmin.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Manager",
            "Chef",
            "Customer"});
            this.comboxFilterAdmin.Location = new System.Drawing.Point(427, 40);
            this.comboxFilterAdmin.Name = "comboxFilterAdmin";
            this.comboxFilterAdmin.Size = new System.Drawing.Size(121, 30);
            this.comboxFilterAdmin.TabIndex = 9;
            // 
            // btnSearchFilterAdmin
            // 
            this.btnSearchFilterAdmin.Location = new System.Drawing.Point(554, 40);
            this.btnSearchFilterAdmin.Name = "btnSearchFilterAdmin";
            this.btnSearchFilterAdmin.Size = new System.Drawing.Size(92, 30);
            this.btnSearchFilterAdmin.TabIndex = 10;
            this.btnSearchFilterAdmin.Text = "Filter";
            this.btnSearchFilterAdmin.UseVisualStyleBackColor = true;
            this.btnSearchFilterAdmin.Click += new System.EventHandler(this.btnSearchFilterAdmin_Click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToOrderColumns = true;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(16, 119);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.Size = new System.Drawing.Size(772, 254);
            this.dataGridUsers.TabIndex = 19;
            this.dataGridUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridUsers_CellMouseClick);
            // 
            // btnClearSearchAdmin
            // 
            this.btnClearSearchAdmin.Location = new System.Drawing.Point(668, 17);
            this.btnClearSearchAdmin.Name = "btnClearSearchAdmin";
            this.btnClearSearchAdmin.Size = new System.Drawing.Size(120, 50);
            this.btnClearSearchAdmin.TabIndex = 20;
            this.btnClearSearchAdmin.Text = "Clear";
            this.btnClearSearchAdmin.UseVisualStyleBackColor = true;
            this.btnClearSearchAdmin.Click += new System.EventHandler(this.btnClearSearchAdmin_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearch.Location = new System.Drawing.Point(166, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(153, 20);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Text = "Enter Username/ID";
            // 
            // lblRoleFilter
            // 
            this.lblRoleFilter.AutoSize = true;
            this.lblRoleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRoleFilter.Location = new System.Drawing.Point(435, 17);
            this.lblRoleFilter.Name = "lblRoleFilter";
            this.lblRoleFilter.Size = new System.Drawing.Size(43, 20);
            this.lblRoleFilter.TabIndex = 27;
            this.lblRoleFilter.Text = "Role";
            // 
            // lblNumResult
            // 
            this.lblNumResult.AutoSize = true;
            this.lblNumResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumResult.Location = new System.Drawing.Point(111, 85);
            this.lblNumResult.Name = "lblNumResult";
            this.lblNumResult.Size = new System.Drawing.Size(2, 25);
            this.lblNumResult.TabIndex = 39;
            // 
            // lblNumOfAccount
            // 
            this.lblNumOfAccount.AutoSize = true;
            this.lblNumOfAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumOfAccount.Location = new System.Drawing.Point(13, 84);
            this.lblNumOfAccount.Name = "lblNumOfAccount";
            this.lblNumOfAccount.Size = new System.Drawing.Size(92, 23);
            this.lblNumOfAccount.TabIndex = 38;
            this.lblNumOfAccount.Text = "# Account:";
            // 
            // btnMoney
            // 
            this.btnMoney.Enabled = false;
            this.btnMoney.Location = new System.Drawing.Point(265, 379);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(120, 50);
            this.btnMoney.TabIndex = 40;
            this.btnMoney.Text = "Loading...";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // formUsersAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.lblNumResult);
            this.Controls.Add(this.lblNumOfAccount);
            this.Controls.Add(this.lblRoleFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClearSearchAdmin);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.btnSearchFilterAdmin);
            this.Controls.Add(this.comboxFilterAdmin);
            this.Controls.Add(this.txtboxSearchAdmin);
            this.Controls.Add(this.btnSearchAdmin);
            this.Controls.Add(this.lblTotalUserResult);
            this.Controls.Add(this.lblTotalUser);
            this.Controls.Add(this.btnEditUserAdmin);
            this.Controls.Add(this.btnDeleteUserAdmin);
            this.Controls.Add(this.btnAddUserAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUsersAdmin";
            this.Text = "formUsersAdmin";
            this.Activated += new System.EventHandler(this.formUsersAdmin_Activated);
            this.Load += new System.EventHandler(this.formUsersAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddUserAdmin;
        private System.Windows.Forms.Button btnDeleteUserAdmin;
        private System.Windows.Forms.Button btnEditUserAdmin;
        private System.Windows.Forms.Label lblTotalUser;
        private System.Windows.Forms.Label lblTotalUserResult;
        private System.Windows.Forms.Button btnSearchAdmin;
        private System.Windows.Forms.TextBox txtboxSearchAdmin;
        private System.Windows.Forms.ComboBox comboxFilterAdmin;
        private System.Windows.Forms.Button btnSearchFilterAdmin;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button btnClearSearchAdmin;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRoleFilter;
        private System.Windows.Forms.Label lblNumResult;
        private System.Windows.Forms.Label lblNumOfAccount;
        private System.Windows.Forms.Button btnMoney;
    }
}