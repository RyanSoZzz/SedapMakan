namespace Group_Assignment.LoginPage
{
    partial class SignUpForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInvalidPhone = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.pnlGenderExtra = new System.Windows.Forms.Panel();
            this.lblInvalidGender = new System.Windows.Forms.Label();
            this.pnlGenderDetail = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
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
            this.pnlStripUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.signUpEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlSignUp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.pnlGenderExtra.SuspendLayout();
            this.pnlGenderDetail.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlPasswordExtra.SuspendLayout();
            this.pnlPasswordDetail.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlUsernameExtra.SuspendLayout();
            this.pnlUsernameDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlSignUp.Controls.Add(this.panel1);
            this.pnlSignUp.Controls.Add(this.lblPhoneNumber);
            this.pnlSignUp.Controls.Add(this.pnlGender);
            this.pnlSignUp.Controls.Add(this.lblGender);
            this.pnlSignUp.Controls.Add(this.pnlPassword);
            this.pnlSignUp.Controls.Add(this.lblPassword);
            this.pnlSignUp.Controls.Add(this.pnlUsername);
            this.pnlSignUp.Controls.Add(this.lblSignUp);
            this.pnlSignUp.Controls.Add(this.btnBack);
            this.pnlSignUp.Controls.Add(this.lblUsername);
            this.pnlSignUp.Controls.Add(this.btnCreate);
            this.pnlSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pnlSignUp.Location = new System.Drawing.Point(0, 0);
            this.pnlSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(500, 418);
            this.pnlSignUp.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(207, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 50);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblInvalidPhone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 17);
            this.panel2.TabIndex = 11;
            // 
            // lblInvalidPhone
            // 
            this.lblInvalidPhone.AutoSize = true;
            this.lblInvalidPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvalidPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidPhone.Location = new System.Drawing.Point(0, 0);
            this.lblInvalidPhone.Name = "lblInvalidPhone";
            this.lblInvalidPhone.Size = new System.Drawing.Size(143, 17);
            this.lblInvalidPhone.TabIndex = 0;
            this.lblInvalidPhone.Text = "Invalid Phone Number";
            this.lblInvalidPhone.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtPhoneNumber);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 33);
            this.panel3.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNumber.Location = new System.Drawing.Point(0, 0);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(247, 23);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.Text = "011-XXXXXXX";
            this.txtPhoneNumber.Click += new System.EventHandler(this.txtPhoneNumber_Click);
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 1);
            this.panel4.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(47, 249);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(124, 23);
            this.lblPhoneNumber.TabIndex = 19;
            this.lblPhoneNumber.Text = "phone number";
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.pnlGenderExtra);
            this.pnlGender.Controls.Add(this.pnlGenderDetail);
            this.pnlGender.Location = new System.Drawing.Point(154, 193);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(297, 53);
            this.pnlGender.TabIndex = 3;
            // 
            // pnlGenderExtra
            // 
            this.pnlGenderExtra.Controls.Add(this.lblInvalidGender);
            this.pnlGenderExtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGenderExtra.Location = new System.Drawing.Point(0, 28);
            this.pnlGenderExtra.Name = "pnlGenderExtra";
            this.pnlGenderExtra.Size = new System.Drawing.Size(297, 17);
            this.pnlGenderExtra.TabIndex = 18;
            // 
            // lblInvalidGender
            // 
            this.lblInvalidGender.AutoSize = true;
            this.lblInvalidGender.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvalidGender.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidGender.Location = new System.Drawing.Point(0, 0);
            this.lblInvalidGender.Name = "lblInvalidGender";
            this.lblInvalidGender.Size = new System.Drawing.Size(110, 17);
            this.lblInvalidGender.TabIndex = 0;
            this.lblInvalidGender.Text = "Please select one";
            this.lblInvalidGender.Visible = false;
            // 
            // pnlGenderDetail
            // 
            this.pnlGenderDetail.Controls.Add(this.rbMale);
            this.pnlGenderDetail.Controls.Add(this.rbFemale);
            this.pnlGenderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGenderDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlGenderDetail.Name = "pnlGenderDetail";
            this.pnlGenderDetail.Size = new System.Drawing.Size(297, 28);
            this.pnlGenderDetail.TabIndex = 1;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(3, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 21);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(76, 3);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(70, 21);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(47, 193);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 23);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "gender";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Transparent;
            this.pnlPassword.Controls.Add(this.pnlPasswordExtra);
            this.pnlPassword.Controls.Add(this.pnlPasswordDetail);
            this.pnlPassword.Location = new System.Drawing.Point(154, 124);
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
            this.pnlPasswordExtra.TabIndex = 11;
            // 
            // lblInvalidPW
            // 
            this.lblInvalidPW.AutoSize = true;
            this.lblInvalidPW.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidPW.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvalidPW.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidPW.Location = new System.Drawing.Point(0, 0);
            this.lblInvalidPW.MaximumSize = new System.Drawing.Size(150, 40);
            this.lblInvalidPW.Name = "lblInvalidPW";
            this.lblInvalidPW.Size = new System.Drawing.Size(110, 17);
            this.lblInvalidPW.TabIndex = 0;
            this.lblInvalidPW.Text = "Password is weak";
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
            this.pnlPasswordDetail.TabIndex = 10;
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
            this.txtPassword.TabIndex = 2;
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
            this.lblPassword.Location = new System.Drawing.Point(47, 124);
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
            this.pnlUsername.Location = new System.Drawing.Point(154, 68);
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
            this.pnlUsernameDetail.Controls.Add(this.pnlStripUsername);
            this.pnlUsernameDetail.Controls.Add(this.txtUsername);
            this.pnlUsernameDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsernameDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlUsernameDetail.Name = "pnlUsernameDetail";
            this.pnlUsernameDetail.Size = new System.Drawing.Size(297, 33);
            this.pnlUsernameDetail.TabIndex = 10;
            // 
            // pnlStripUsername
            // 
            this.pnlStripUsername.BackColor = System.Drawing.Color.White;
            this.pnlStripUsername.Location = new System.Drawing.Point(0, 27);
            this.pnlStripUsername.Name = "pnlStripUsername";
            this.pnlStripUsername.Size = new System.Drawing.Size(300, 1);
            this.pnlStripUsername.TabIndex = 2;
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
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(45, 19);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(99, 31);
            this.lblSignUp.TabIndex = 3;
            this.lblSignUp.Text = "Sign Up";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnBack.Location = new System.Drawing.Point(51, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = " < Login";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(47, 68);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "username";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Cyan;
            this.btnCreate.Location = new System.Drawing.Point(265, 320);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(189, 40);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.MouseEnter += new System.EventHandler(this.btnCreate_MouseEnter);
            this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
            // 
            // signUpEffect_Timer
            // 
            this.signUpEffect_Timer.Enabled = true;
            this.signUpEffect_Timer.Interval = 1;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 418);
            this.Controls.Add(this.pnlSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInForm";
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGenderExtra.ResumeLayout(false);
            this.pnlGenderExtra.PerformLayout();
            this.pnlGenderDetail.ResumeLayout(false);
            this.pnlGenderDetail.PerformLayout();
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

        private System.Windows.Forms.Panel pnlSignUp;
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
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Panel pnlGenderExtra;
        private System.Windows.Forms.Label lblInvalidGender;
        private System.Windows.Forms.Panel pnlGenderDetail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInvalidPhone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer signUpEffect_Timer;
    }
}