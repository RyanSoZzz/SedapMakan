namespace Group_Assignment.LoginPage
{
    partial class LoginForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblShortDesc = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlPasswordExtra = new System.Windows.Forms.Panel();
            this.lblInvalidPW = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.pnlPasswordDetail = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlStripPassword = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlUsernameExtra = new System.Windows.Forms.Panel();
            this.lblInvalidUN = new System.Windows.Forms.Label();
            this.pnlUsernameDetail = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlStripUsername = new System.Windows.Forms.Panel();
            this.lblSedapMakan = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlPasswordExtra.SuspendLayout();
            this.pnlPasswordDetail.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlUsernameExtra.SuspendLayout();
            this.pnlUsernameDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlMain.Controls.Add(this.lblShortDesc);
            this.pnlMain.Controls.Add(this.pnlPassword);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.pnlUsername);
            this.pnlMain.Controls.Add(this.lblSedapMakan);
            this.pnlMain.Controls.Add(this.btnSignUp);
            this.pnlMain.Controls.Add(this.lblUsername);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 418);
            this.pnlMain.TabIndex = 8;
            // 
            // lblShortDesc
            // 
            this.lblShortDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShortDesc.AutoSize = true;
            this.lblShortDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblShortDesc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortDesc.ForeColor = System.Drawing.Color.White;
            this.lblShortDesc.Location = new System.Drawing.Point(48, 92);
            this.lblShortDesc.Name = "lblShortDesc";
            this.lblShortDesc.Size = new System.Drawing.Size(236, 17);
            this.lblShortDesc.TabIndex = 14;
            this.lblShortDesc.Text = "Taste the Tradition, Savor the Experience.";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Transparent;
            this.pnlPassword.Controls.Add(this.pnlPasswordExtra);
            this.pnlPassword.Controls.Add(this.pnlPasswordDetail);
            this.pnlPassword.Location = new System.Drawing.Point(154, 211);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(297, 63);
            this.pnlPassword.TabIndex = 2;
            // 
            // pnlPasswordExtra
            // 
            this.pnlPasswordExtra.Controls.Add(this.lblInvalidPW);
            this.pnlPasswordExtra.Controls.Add(this.cbShowPassword);
            this.pnlPasswordExtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPasswordExtra.Location = new System.Drawing.Point(0, 33);
            this.pnlPasswordExtra.Name = "pnlPasswordExtra";
            this.pnlPasswordExtra.Size = new System.Drawing.Size(297, 30);
            this.pnlPasswordExtra.TabIndex = 2;
            // 
            // lblInvalidPW
            // 
            this.lblInvalidPW.AutoSize = true;
            this.lblInvalidPW.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidPW.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvalidPW.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidPW.Location = new System.Drawing.Point(0, 0);
            this.lblInvalidPW.Name = "lblInvalidPW";
            this.lblInvalidPW.Size = new System.Drawing.Size(106, 17);
            this.lblInvalidPW.TabIndex = 0;
            this.lblInvalidPW.Text = "Invalid password";
            this.lblInvalidPW.Visible = false;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbShowPassword.Location = new System.Drawing.Point(176, 3);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(121, 21);
            this.cbShowPassword.TabIndex = 3;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = false;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // pnlPasswordDetail
            // 
            this.pnlPasswordDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlPasswordDetail.Controls.Add(this.txtPassword);
            this.pnlPasswordDetail.Controls.Add(this.pnlStripPassword);
            this.pnlPasswordDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPasswordDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlPasswordDetail.Name = "pnlPasswordDetail";
            this.pnlPasswordDetail.Size = new System.Drawing.Size(297, 33);
            this.pnlPasswordDetail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // pnlStripPassword
            // 
            this.pnlStripPassword.BackColor = System.Drawing.Color.White;
            this.pnlStripPassword.Location = new System.Drawing.Point(0, 27);
            this.pnlStripPassword.Name = "pnlStripPassword";
            this.pnlStripPassword.Size = new System.Drawing.Size(300, 1);
            this.pnlStripPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(47, 211);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 23);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "password";
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsername.Controls.Add(this.pnlUsernameExtra);
            this.pnlUsername.Controls.Add(this.pnlUsernameDetail);
            this.pnlUsername.Location = new System.Drawing.Point(154, 155);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(297, 50);
            this.pnlUsername.TabIndex = 1;
            // 
            // pnlUsernameExtra
            // 
            this.pnlUsernameExtra.Controls.Add(this.lblInvalidUN);
            this.pnlUsernameExtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsernameExtra.Location = new System.Drawing.Point(0, 33);
            this.pnlUsernameExtra.Name = "pnlUsernameExtra";
            this.pnlUsernameExtra.Size = new System.Drawing.Size(297, 17);
            this.pnlUsernameExtra.TabIndex = 11;
            // 
            // lblInvalidUN
            // 
            this.lblInvalidUN.AutoSize = true;
            this.lblInvalidUN.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidUN.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvalidUN.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidUN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidUN.Location = new System.Drawing.Point(0, 0);
            this.lblInvalidUN.Name = "lblInvalidUN";
            this.lblInvalidUN.Size = new System.Drawing.Size(111, 17);
            this.lblInvalidUN.TabIndex = 0;
            this.lblInvalidUN.Text = "Invalid username";
            this.lblInvalidUN.Visible = false;
            // 
            // pnlUsernameDetail
            // 
            this.pnlUsernameDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsernameDetail.Controls.Add(this.txtUsername);
            this.pnlUsernameDetail.Controls.Add(this.pnlStripUsername);
            this.pnlUsernameDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsernameDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlUsernameDetail.Name = "pnlUsernameDetail";
            this.pnlUsernameDetail.Size = new System.Drawing.Size(297, 33);
            this.pnlUsernameDetail.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(0, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Enter username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // pnlStripUsername
            // 
            this.pnlStripUsername.BackColor = System.Drawing.Color.White;
            this.pnlStripUsername.Location = new System.Drawing.Point(0, 27);
            this.pnlStripUsername.Name = "pnlStripUsername";
            this.pnlStripUsername.Size = new System.Drawing.Size(300, 1);
            this.pnlStripUsername.TabIndex = 2;
            // 
            // lblSedapMakan
            // 
            this.lblSedapMakan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSedapMakan.AutoSize = true;
            this.lblSedapMakan.BackColor = System.Drawing.Color.Transparent;
            this.lblSedapMakan.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedapMakan.ForeColor = System.Drawing.Color.White;
            this.lblSedapMakan.Location = new System.Drawing.Point(40, 30);
            this.lblSedapMakan.Name = "lblSedapMakan";
            this.lblSedapMakan.Size = new System.Drawing.Size(323, 62);
            this.lblSedapMakan.TabIndex = 3;
            this.lblSedapMakan.Text = "Sedap Makan";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.White;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSignUp.Location = new System.Drawing.Point(51, 320);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(132, 40);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(47, 155);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "username";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Lime;
            this.btnLogin.Location = new System.Drawing.Point(265, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(189, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 418);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPasswordExtra.ResumeLayout(false);
            this.pnlPasswordExtra.PerformLayout();
            this.pnlPasswordDetail.ResumeLayout(false);
            this.pnlPasswordDetail.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsernameExtra.ResumeLayout(false);
            this.pnlUsernameExtra.PerformLayout();
            this.pnlUsernameDetail.ResumeLayout(false);
            this.pnlUsernameDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblShortDesc;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlPasswordExtra;
        private System.Windows.Forms.Label lblInvalidPW;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Panel pnlPasswordDetail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlStripPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlUsernameExtra;
        private System.Windows.Forms.Label lblInvalidUN;
        private System.Windows.Forms.Panel pnlUsernameDetail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlStripUsername;
        private System.Windows.Forms.Label lblSedapMakan;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
    }
}