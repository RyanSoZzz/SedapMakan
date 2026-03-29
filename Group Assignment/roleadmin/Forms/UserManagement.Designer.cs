namespace Group_Assignment.roleadmin.Forms
{
    partial class UserManagement
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.radbtnMale = new System.Windows.Forms.RadioButton();
            this.radbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblRoles = new System.Windows.Forms.Label();
            this.checkboxAdmin = new System.Windows.Forms.CheckBox();
            this.checkboxManager = new System.Windows.Forms.CheckBox();
            this.checkboxChef = new System.Windows.Forms.CheckBox();
            this.checkboxCustomer = new System.Windows.Forms.CheckBox();
            this.txtboxPhoneNum = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblInvalidGender = new System.Windows.Forms.Label();
            this.lblInvalidRole = new System.Windows.Forms.Label();
            this.lblInvalidUsername = new System.Windows.Forms.Label();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.lblInvalidPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(42, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 28);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(42, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 28);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(42, 170);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(127, 28);
            this.lblPhoneNum.TabIndex = 3;
            this.lblPhoneNum.Text = "Phone Num.";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(42, 211);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 28);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // radbtnMale
            // 
            this.radbtnMale.AutoSize = true;
            this.radbtnMale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnMale.Location = new System.Drawing.Point(79, 260);
            this.radbtnMale.Name = "radbtnMale";
            this.radbtnMale.Size = new System.Drawing.Size(69, 27);
            this.radbtnMale.TabIndex = 0;
            this.radbtnMale.TabStop = true;
            this.radbtnMale.Text = "Male";
            this.radbtnMale.UseVisualStyleBackColor = true;
            // 
            // radbtnFemale
            // 
            this.radbtnFemale.AutoSize = true;
            this.radbtnFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnFemale.Location = new System.Drawing.Point(205, 260);
            this.radbtnFemale.Name = "radbtnFemale";
            this.radbtnFemale.Size = new System.Drawing.Size(86, 27);
            this.radbtnFemale.TabIndex = 6;
            this.radbtnFemale.TabStop = true;
            this.radbtnFemale.Text = "Female";
            this.radbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.Location = new System.Drawing.Point(40, 293);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(60, 28);
            this.lblRoles.TabIndex = 7;
            this.lblRoles.Text = "Roles";
            // 
            // checkboxAdmin
            // 
            this.checkboxAdmin.AutoSize = true;
            this.checkboxAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAdmin.Location = new System.Drawing.Point(47, 339);
            this.checkboxAdmin.Name = "checkboxAdmin";
            this.checkboxAdmin.Size = new System.Drawing.Size(82, 27);
            this.checkboxAdmin.TabIndex = 8;
            this.checkboxAdmin.Text = "Admin";
            this.checkboxAdmin.UseVisualStyleBackColor = true;
            this.checkboxAdmin.CheckedChanged += new System.EventHandler(this.checkboxAdmin_CheckedChanged);
            // 
            // checkboxManager
            // 
            this.checkboxManager.AutoSize = true;
            this.checkboxManager.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxManager.Location = new System.Drawing.Point(212, 339);
            this.checkboxManager.Name = "checkboxManager";
            this.checkboxManager.Size = new System.Drawing.Size(101, 27);
            this.checkboxManager.TabIndex = 9;
            this.checkboxManager.Text = "Manager";
            this.checkboxManager.UseVisualStyleBackColor = true;
            this.checkboxManager.CheckedChanged += new System.EventHandler(this.checkboxManager_CheckedChanged);
            // 
            // checkboxChef
            // 
            this.checkboxChef.AutoSize = true;
            this.checkboxChef.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxChef.Location = new System.Drawing.Point(47, 372);
            this.checkboxChef.Name = "checkboxChef";
            this.checkboxChef.Size = new System.Drawing.Size(68, 27);
            this.checkboxChef.TabIndex = 10;
            this.checkboxChef.Text = "Chef";
            this.checkboxChef.UseVisualStyleBackColor = true;
            // 
            // checkboxCustomer
            // 
            this.checkboxCustomer.AutoSize = true;
            this.checkboxCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxCustomer.Location = new System.Drawing.Point(212, 372);
            this.checkboxCustomer.Name = "checkboxCustomer";
            this.checkboxCustomer.Size = new System.Drawing.Size(106, 27);
            this.checkboxCustomer.TabIndex = 11;
            this.checkboxCustomer.Text = "Customer";
            this.checkboxCustomer.UseVisualStyleBackColor = true;
            // 
            // txtboxPhoneNum
            // 
            this.txtboxPhoneNum.BackColor = System.Drawing.SystemColors.Menu;
            this.txtboxPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxPhoneNum.Location = new System.Drawing.Point(205, 175);
            this.txtboxPhoneNum.Name = "txtboxPhoneNum";
            this.txtboxPhoneNum.Size = new System.Drawing.Size(195, 23);
            this.txtboxPhoneNum.TabIndex = 14;
            this.txtboxPhoneNum.WordWrap = false;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxPassword.Location = new System.Drawing.Point(205, 125);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(195, 23);
            this.txtboxPassword.TabIndex = 13;
            this.txtboxPassword.WordWrap = false;
            // 
            // txtboxName
            // 
            this.txtboxName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxName.Location = new System.Drawing.Point(205, 75);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(195, 23);
            this.txtboxName.TabIndex = 12;
            this.txtboxName.WordWrap = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(45, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(250, 413);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Save Changes";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblInvalidGender
            // 
            this.lblInvalidGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalidGender.AutoSize = true;
            this.lblInvalidGender.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidGender.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidGender.Location = new System.Drawing.Point(42, 239);
            this.lblInvalidGender.Name = "lblInvalidGender";
            this.lblInvalidGender.Size = new System.Drawing.Size(110, 17);
            this.lblInvalidGender.TabIndex = 17;
            this.lblInvalidGender.Text = "Please select one";
            this.lblInvalidGender.Visible = false;
            // 
            // lblInvalidRole
            // 
            this.lblInvalidRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalidRole.AutoSize = true;
            this.lblInvalidRole.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidRole.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidRole.Location = new System.Drawing.Point(42, 318);
            this.lblInvalidRole.Name = "lblInvalidRole";
            this.lblInvalidRole.Size = new System.Drawing.Size(158, 17);
            this.lblInvalidRole.TabIndex = 18;
            this.lblInvalidRole.Text = "Please select at least one";
            this.lblInvalidRole.Visible = false;
            // 
            // lblInvalidUsername
            // 
            this.lblInvalidUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalidUsername.AutoSize = true;
            this.lblInvalidUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidUsername.Location = new System.Drawing.Point(202, 98);
            this.lblInvalidUsername.Name = "lblInvalidUsername";
            this.lblInvalidUsername.Size = new System.Drawing.Size(111, 17);
            this.lblInvalidUsername.TabIndex = 19;
            this.lblInvalidUsername.Text = "Invalid username";
            this.lblInvalidUsername.Visible = false;
            // 
            // lblInvalidPassword
            // 
            this.lblInvalidPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalidPassword.AutoSize = true;
            this.lblInvalidPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidPassword.Location = new System.Drawing.Point(202, 149);
            this.lblInvalidPassword.Name = "lblInvalidPassword";
            this.lblInvalidPassword.Size = new System.Drawing.Size(100, 17);
            this.lblInvalidPassword.TabIndex = 20;
            this.lblInvalidPassword.Text = "Weak Password";
            this.lblInvalidPassword.Visible = false;
            // 
            // lblInvalidPhone
            // 
            this.lblInvalidPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalidPhone.AutoSize = true;
            this.lblInvalidPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidPhone.Location = new System.Drawing.Point(202, 198);
            this.lblInvalidPhone.Name = "lblInvalidPhone";
            this.lblInvalidPhone.Size = new System.Drawing.Size(143, 17);
            this.lblInvalidPhone.TabIndex = 21;
            this.lblInvalidPhone.Text = "Invalid Phone Number";
            this.lblInvalidPhone.Visible = false;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(450, 475);
            this.Controls.Add(this.lblInvalidPhone);
            this.Controls.Add(this.lblInvalidPassword);
            this.Controls.Add(this.lblInvalidUsername);
            this.Controls.Add(this.lblInvalidRole);
            this.Controls.Add(this.lblInvalidGender);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtboxPhoneNum);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.checkboxCustomer);
            this.Controls.Add(this.checkboxChef);
            this.Controls.Add(this.checkboxManager);
            this.Controls.Add(this.checkboxAdmin);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.radbtnFemale);
            this.Controls.Add(this.radbtnMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(450, 475);
            this.MinimumSize = new System.Drawing.Size(450, 475);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radbtnMale;
        private System.Windows.Forms.RadioButton radbtnFemale;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.CheckBox checkboxAdmin;
        private System.Windows.Forms.CheckBox checkboxManager;
        private System.Windows.Forms.CheckBox checkboxChef;
        private System.Windows.Forms.CheckBox checkboxCustomer;
        private System.Windows.Forms.TextBox txtboxPhoneNum;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblInvalidGender;
        private System.Windows.Forms.Label lblInvalidRole;
        private System.Windows.Forms.Label lblInvalidUsername;
        private System.Windows.Forms.Label lblInvalidPassword;
        private System.Windows.Forms.Label lblInvalidPhone;
    }
}