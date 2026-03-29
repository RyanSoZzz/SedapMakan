namespace Group_Assignment.RoleCustomer
{
    partial class SettingForm
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
            this.pnlUserProfile = new System.Windows.Forms.Panel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblEwallet = new System.Windows.Forms.Label();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.lblEwalletID = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.lblAccId = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInvalidUsername = new System.Windows.Forms.Label();
            this.lblInvalidPass = new System.Windows.Forms.Label();
            this.lblInvalidPhone = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewPhoneNumber = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblUserProfile = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUserProfile.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserProfile
            // 
            this.pnlUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.pnlUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlUserProfile.Controls.Add(this.lblPhoneNumber);
            this.pnlUserProfile.Controls.Add(this.panel5);
            this.pnlUserProfile.Controls.Add(this.lblAccId);
            this.pnlUserProfile.Controls.Add(this.lblUsername);
            this.pnlUserProfile.Location = new System.Drawing.Point(12, 12);
            this.pnlUserProfile.Name = "pnlUserProfile";
            this.pnlUserProfile.Size = new System.Drawing.Size(780, 138);
            this.pnlUserProfile.TabIndex = 0;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPhoneNumber.Location = new System.Drawing.Point(14, 55);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(173, 17);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "phone number: xxxxxxxxxxxx";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel5.Controls.Add(this.lblEwallet);
            this.panel5.Controls.Add(this.btnTopUp);
            this.panel5.Controls.Add(this.lblEwalletID);
            this.panel5.Controls.Add(this.lblTotalBalance);
            this.panel5.Location = new System.Drawing.Point(245, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 117);
            this.panel5.TabIndex = 2;
            // 
            // lblEwallet
            // 
            this.lblEwallet.AutoSize = true;
            this.lblEwallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.lblEwallet.Location = new System.Drawing.Point(16, 10);
            this.lblEwallet.Name = "lblEwallet";
            this.lblEwallet.Size = new System.Drawing.Size(58, 16);
            this.lblEwallet.TabIndex = 3;
            this.lblEwallet.Text = "E-Wallet";
            // 
            // btnTopUp
            // 
            this.btnTopUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTopUp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopUp.Location = new System.Drawing.Point(407, 25);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(100, 34);
            this.btnTopUp.TabIndex = 2;
            this.btnTopUp.Text = "TopUp";
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // lblEwalletID
            // 
            this.lblEwalletID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEwalletID.AutoSize = true;
            this.lblEwalletID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEwalletID.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblEwalletID.ForeColor = System.Drawing.Color.DimGray;
            this.lblEwalletID.Location = new System.Drawing.Point(16, 86);
            this.lblEwalletID.Name = "lblEwalletID";
            this.lblEwalletID.Size = new System.Drawing.Size(145, 17);
            this.lblEwalletID.TabIndex = 1;
            this.lblEwalletID.Text = "EWalletID: ewalletxxxxxx";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalance.Location = new System.Drawing.Point(13, 25);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(141, 28);
            this.lblTotalBalance.TabIndex = 0;
            this.lblTotalBalance.Text = "Total Balance: ";
            // 
            // lblAccId
            // 
            this.lblAccId.AutoSize = true;
            this.lblAccId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccId.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAccId.Location = new System.Drawing.Point(14, 38);
            this.lblAccId.Name = "lblAccId";
            this.lblAccId.Size = new System.Drawing.Size(130, 17);
            this.lblAccId.TabIndex = 1;
            this.lblAccId.Text = "accountid: custxxxxxx";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "username";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblUserProfile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 300);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblInvalidUsername);
            this.panel3.Controls.Add(this.lblInvalidPass);
            this.panel3.Controls.Add(this.lblInvalidPhone);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.txtNewPhone);
            this.panel3.Controls.Add(this.txtNewPass);
            this.panel3.Controls.Add(this.txtNewUsername);
            this.panel3.Controls.Add(this.lblNewPhoneNumber);
            this.panel3.Controls.Add(this.lblNewPassword);
            this.panel3.Controls.Add(this.lblNewUsername);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 149);
            this.panel3.TabIndex = 3;
            // 
            // lblInvalidUsername
            // 
            this.lblInvalidUsername.AutoSize = true;
            this.lblInvalidUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidUsername.Location = new System.Drawing.Point(499, 8);
            this.lblInvalidUsername.Name = "lblInvalidUsername";
            this.lblInvalidUsername.Size = new System.Drawing.Size(111, 17);
            this.lblInvalidUsername.TabIndex = 10;
            this.lblInvalidUsername.Text = "Invalid username";
            this.lblInvalidUsername.Visible = false;
            // 
            // lblInvalidPass
            // 
            this.lblInvalidPass.AutoSize = true;
            this.lblInvalidPass.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidPass.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidPass.Location = new System.Drawing.Point(499, 34);
            this.lblInvalidPass.Name = "lblInvalidPass";
            this.lblInvalidPass.Size = new System.Drawing.Size(150, 17);
            this.lblInvalidPass.TabIndex = 9;
            this.lblInvalidPass.Text = "Enter a proper password";
            this.lblInvalidPass.Visible = false;
            // 
            // lblInvalidPhone
            // 
            this.lblInvalidPhone.AutoSize = true;
            this.lblInvalidPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidPhone.Location = new System.Drawing.Point(499, 62);
            this.lblInvalidPhone.Name = "lblInvalidPhone";
            this.lblInvalidPhone.Size = new System.Drawing.Size(143, 17);
            this.lblInvalidPhone.TabIndex = 8;
            this.lblInvalidPhone.Text = "Invalid Phone Number";
            this.lblInvalidPhone.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnUpdate.Location = new System.Drawing.Point(393, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtNewPhone.ForeColor = System.Drawing.Color.Gray;
            this.txtNewPhone.Location = new System.Drawing.Point(283, 60);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(210, 25);
            this.txtNewPhone.TabIndex = 5;
            this.txtNewPhone.Text = "011-XXXXXXX";
            this.txtNewPhone.Click += new System.EventHandler(this.txtNewPhone_Click);
            this.txtNewPhone.TextChanged += new System.EventHandler(this.txtNewPhone_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtNewPass.ForeColor = System.Drawing.Color.Gray;
            this.txtNewPass.Location = new System.Drawing.Point(283, 32);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(210, 25);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.Text = "Password";
            this.txtNewPass.Click += new System.EventHandler(this.txtNewPass_Click);
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtNewUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtNewUsername.Location = new System.Drawing.Point(283, 4);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(210, 25);
            this.txtNewUsername.TabIndex = 3;
            this.txtNewUsername.Text = "Enter username";
            this.txtNewUsername.Click += new System.EventHandler(this.txtNewUsername_Click);
            this.txtNewUsername.TextChanged += new System.EventHandler(this.txtNewUsername_TextChanged);
            // 
            // lblNewPhoneNumber
            // 
            this.lblNewPhoneNumber.AutoSize = true;
            this.lblNewPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblNewPhoneNumber.Location = new System.Drawing.Point(60, 60);
            this.lblNewPhoneNumber.Name = "lblNewPhoneNumber";
            this.lblNewPhoneNumber.Size = new System.Drawing.Size(145, 20);
            this.lblNewPhoneNumber.TabIndex = 2;
            this.lblNewPhoneNumber.Text = "New phone number";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblNewPassword.Location = new System.Drawing.Point(60, 32);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(108, 20);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New password";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblNewUsername.Location = new System.Drawing.Point(60, 6);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(112, 20);
            this.lblNewUsername.TabIndex = 0;
            this.lblNewUsername.Text = "New username";
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblUserProfile.Location = new System.Drawing.Point(0, 58);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Padding = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.lblUserProfile.Size = new System.Drawing.Size(148, 35);
            this.lblUserProfile.TabIndex = 2;
            this.lblUserProfile.Text = "     User Profile";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label1.Size = new System.Drawing.Size(168, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(804, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUserProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "Form1";
            this.pnlUserProfile.ResumeLayout(false);
            this.pnlUserProfile.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserProfile;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccId;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblEwalletID;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEwallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNewPhoneNumber;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblUserProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewPhone;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblInvalidPhone;
        private System.Windows.Forms.Label lblInvalidUsername;
        private System.Windows.Forms.Label lblInvalidPass;
    }
}