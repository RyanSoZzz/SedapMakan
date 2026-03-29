namespace Group_Assignment
{
    partial class TitleBarUtilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBarUtilities));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butExit = new System.Windows.Forms.Button();
            this.butMaximize = new System.Windows.Forms.Button();
            this.butMinimize = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.butExit);
            this.flowLayoutPanel1.Controls.Add(this.butMaximize);
            this.flowLayoutPanel1.Controls.Add(this.butMinimize);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // butExit
            // 
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Image = ((System.Drawing.Image)(resources.GetObject("butExit.Image")));
            this.butExit.Location = new System.Drawing.Point(140, 0);
            this.butExit.Margin = new System.Windows.Forms.Padding(0);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(70, 32);
            this.butExit.TabIndex = 8;
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butMaximize
            // 
            this.butMaximize.FlatAppearance.BorderSize = 0;
            this.butMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMaximize.Image = ((System.Drawing.Image)(resources.GetObject("butMaximize.Image")));
            this.butMaximize.Location = new System.Drawing.Point(70, 0);
            this.butMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.butMaximize.Name = "butMaximize";
            this.butMaximize.Size = new System.Drawing.Size(70, 32);
            this.butMaximize.TabIndex = 8;
            this.butMaximize.UseVisualStyleBackColor = true;
            this.butMaximize.Click += new System.EventHandler(this.butMaximize_Click);
            // 
            // butMinimize
            // 
            this.butMinimize.FlatAppearance.BorderSize = 0;
            this.butMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMinimize.Image = ((System.Drawing.Image)(resources.GetObject("butMinimize.Image")));
            this.butMinimize.Location = new System.Drawing.Point(0, 0);
            this.butMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.butMinimize.Name = "butMinimize";
            this.butMinimize.Size = new System.Drawing.Size(70, 32);
            this.butMinimize.TabIndex = 7;
            this.butMinimize.UseVisualStyleBackColor = true;
            this.butMinimize.Click += new System.EventHandler(this.butMinimize_Click);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(210, 32);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butMaximize;
        private System.Windows.Forms.Button butMinimize;
    }
}
