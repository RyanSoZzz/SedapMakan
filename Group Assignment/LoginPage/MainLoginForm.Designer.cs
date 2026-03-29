namespace Group_Assignment.LoginPage
{
    partial class MainLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginForm));
            this.TitleBar_Panel = new System.Windows.Forms.Panel();
            this.butExit = new System.Windows.Forms.Button();
            this.gradient_Panel1 = new Group_Assignment.Gradient_Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.TitleBar_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar_Panel
            // 
            this.TitleBar_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TitleBar_Panel.Controls.Add(this.butExit);
            this.TitleBar_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar_Panel.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_Panel.Name = "TitleBar_Panel";
            this.TitleBar_Panel.Size = new System.Drawing.Size(800, 32);
            this.TitleBar_Panel.TabIndex = 100;
            this.TitleBar_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Mouse_Down);
            this.TitleBar_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Mouse_Move);
            // 
            // butExit
            // 
            this.butExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Image = ((System.Drawing.Image)(resources.GetObject("butExit.Image")));
            this.butExit.Location = new System.Drawing.Point(730, 0);
            this.butExit.Margin = new System.Windows.Forms.Padding(0);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(70, 32);
            this.butExit.TabIndex = 1;
            this.butExit.TabStop = false;
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // gradient_Panel1
            // 
            this.gradient_Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradient_Panel1.gradientAngle = 90F;
            this.gradient_Panel1.gradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.gradient_Panel1.gradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gradient_Panel1.Location = new System.Drawing.Point(0, 32);
            this.gradient_Panel1.Name = "gradient_Panel1";
            this.gradient_Panel1.Size = new System.Drawing.Size(300, 418);
            this.gradient_Panel1.TabIndex = 8;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.formPanel.Location = new System.Drawing.Point(300, 32);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(500, 418);
            this.formPanel.TabIndex = 102;
            this.formPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formPanel_Paint);
            // 
            // MainLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.gradient_Panel1);
            this.Controls.Add(this.TitleBar_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TitleBar_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_Panel;
        private System.Windows.Forms.Button butExit;
        private Gradient_Panel gradient_Panel1;
        private System.Windows.Forms.Panel formPanel;
    }
}