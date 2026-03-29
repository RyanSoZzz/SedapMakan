namespace Group_Assignment.RoleChef
{
    partial class formorder
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
            this.btnorderfinish = new System.Windows.Forms.Button();
            this.btnordersearch = new System.Windows.Forms.Button();
            this.btnorderedit = new System.Windows.Forms.Button();
            this.listboxorder = new System.Windows.Forms.ListBox();
            this.groupboxorderinfo = new System.Windows.Forms.GroupBox();
            this.btnorderitemoverall = new System.Windows.Forms.Button();
            this.btnorderitemindividual = new System.Windows.Forms.Button();
            this.txtboxquantity = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.cmborderstatus = new System.Windows.Forms.ComboBox();
            this.listboxorderitem = new System.Windows.Forms.ListBox();
            this.lblordermode = new System.Windows.Forms.Label();
            this.txtboxorderprice = new System.Windows.Forms.TextBox();
            this.txtboxordername = new System.Windows.Forms.TextBox();
            this.lblorderstatus = new System.Windows.Forms.Label();
            this.lblorderprice = new System.Windows.Forms.Label();
            this.lblordercustomername = new System.Windows.Forms.Label();
            this.groupBoxtoday = new System.Windows.Forms.GroupBox();
            this.lbltoday3 = new System.Windows.Forms.Label();
            this.lbltoday2 = new System.Windows.Forms.Label();
            this.lbltoday1 = new System.Windows.Forms.Label();
            this.labeltoday3 = new System.Windows.Forms.Label();
            this.labeltoday2 = new System.Windows.Forms.Label();
            this.labeltoday1 = new System.Windows.Forms.Label();
            this.groupBoxalltime = new System.Windows.Forms.GroupBox();
            this.lbloverall3 = new System.Windows.Forms.Label();
            this.labelalltime3 = new System.Windows.Forms.Label();
            this.lbloverall1 = new System.Windows.Forms.Label();
            this.labelalltime2 = new System.Windows.Forms.Label();
            this.lbloverall2 = new System.Windows.Forms.Label();
            this.labelalltime1 = new System.Windows.Forms.Label();
            this.lblmostordered = new System.Windows.Forms.Label();
            this.lblorderlist = new System.Windows.Forms.Label();
            this.btnfilter = new System.Windows.Forms.Button();
            this.btnnofilter = new System.Windows.Forms.Button();
            this.lblorderidinvisible = new System.Windows.Forms.Label();
            this.lblcurrentmenu = new System.Windows.Forms.Label();
            this.groupboxorderinfo.SuspendLayout();
            this.groupBoxtoday.SuspendLayout();
            this.groupBoxalltime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnorderfinish
            // 
            this.btnorderfinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnorderfinish.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderfinish.Location = new System.Drawing.Point(24, 375);
            this.btnorderfinish.Name = "btnorderfinish";
            this.btnorderfinish.Size = new System.Drawing.Size(131, 44);
            this.btnorderfinish.TabIndex = 18;
            this.btnorderfinish.Text = "Finish";
            this.btnorderfinish.UseVisualStyleBackColor = true;
            this.btnorderfinish.Click += new System.EventHandler(this.btnorderfinish_Click);
            // 
            // btnordersearch
            // 
            this.btnordersearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnordersearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnordersearch.Location = new System.Drawing.Point(24, 319);
            this.btnordersearch.Name = "btnordersearch";
            this.btnordersearch.Size = new System.Drawing.Size(131, 34);
            this.btnordersearch.TabIndex = 16;
            this.btnordersearch.Text = "Search";
            this.btnordersearch.UseVisualStyleBackColor = true;
            this.btnordersearch.Click += new System.EventHandler(this.btnordersearch_Click);
            // 
            // btnorderedit
            // 
            this.btnorderedit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnorderedit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderedit.Location = new System.Drawing.Point(176, 319);
            this.btnorderedit.Name = "btnorderedit";
            this.btnorderedit.Size = new System.Drawing.Size(135, 34);
            this.btnorderedit.TabIndex = 17;
            this.btnorderedit.Text = "Edit";
            this.btnorderedit.UseVisualStyleBackColor = true;
            this.btnorderedit.Click += new System.EventHandler(this.btnorderedit_Click);
            // 
            // listboxorder
            // 
            this.listboxorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.listboxorder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.listboxorder.ForeColor = System.Drawing.Color.White;
            this.listboxorder.FormattingEnabled = true;
            this.listboxorder.ItemHeight = 20;
            this.listboxorder.Location = new System.Drawing.Point(24, 55);
            this.listboxorder.Name = "listboxorder";
            this.listboxorder.Size = new System.Drawing.Size(287, 244);
            this.listboxorder.TabIndex = 15;
            // 
            // groupboxorderinfo
            // 
            this.groupboxorderinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupboxorderinfo.Controls.Add(this.btnorderitemoverall);
            this.groupboxorderinfo.Controls.Add(this.btnorderitemindividual);
            this.groupboxorderinfo.Controls.Add(this.txtboxquantity);
            this.groupboxorderinfo.Controls.Add(this.lblquantity);
            this.groupboxorderinfo.Controls.Add(this.cmborderstatus);
            this.groupboxorderinfo.Controls.Add(this.listboxorderitem);
            this.groupboxorderinfo.Controls.Add(this.lblordermode);
            this.groupboxorderinfo.Controls.Add(this.txtboxorderprice);
            this.groupboxorderinfo.Controls.Add(this.txtboxordername);
            this.groupboxorderinfo.Controls.Add(this.lblorderstatus);
            this.groupboxorderinfo.Controls.Add(this.lblorderprice);
            this.groupboxorderinfo.Controls.Add(this.lblordercustomername);
            this.groupboxorderinfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxorderinfo.Location = new System.Drawing.Point(332, 23);
            this.groupboxorderinfo.Name = "groupboxorderinfo";
            this.groupboxorderinfo.Size = new System.Drawing.Size(449, 245);
            this.groupboxorderinfo.TabIndex = 14;
            this.groupboxorderinfo.TabStop = false;
            this.groupboxorderinfo.Text = "Food Information";
            // 
            // btnorderitemoverall
            // 
            this.btnorderitemoverall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnorderitemoverall.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderitemoverall.Location = new System.Drawing.Point(225, 200);
            this.btnorderitemoverall.Name = "btnorderitemoverall";
            this.btnorderitemoverall.Size = new System.Drawing.Size(96, 30);
            this.btnorderitemoverall.TabIndex = 26;
            this.btnorderitemoverall.Text = "Overall";
            this.btnorderitemoverall.UseVisualStyleBackColor = true;
            this.btnorderitemoverall.Click += new System.EventHandler(this.btnorderitemoverall_Click);
            // 
            // btnorderitemindividual
            // 
            this.btnorderitemindividual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnorderitemindividual.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderitemindividual.Location = new System.Drawing.Point(345, 200);
            this.btnorderitemindividual.Name = "btnorderitemindividual";
            this.btnorderitemindividual.Size = new System.Drawing.Size(98, 30);
            this.btnorderitemindividual.TabIndex = 25;
            this.btnorderitemindividual.Text = "Individual";
            this.btnorderitemindividual.UseVisualStyleBackColor = true;
            this.btnorderitemindividual.Click += new System.EventHandler(this.btnorderitemindividual_Click);
            // 
            // txtboxquantity
            // 
            this.txtboxquantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxquantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxquantity.Location = new System.Drawing.Point(320, 103);
            this.txtboxquantity.Name = "txtboxquantity";
            this.txtboxquantity.Size = new System.Drawing.Size(123, 27);
            this.txtboxquantity.TabIndex = 21;
            // 
            // lblquantity
            // 
            this.lblquantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.Location = new System.Drawing.Point(222, 109);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(68, 20);
            this.lblquantity.TabIndex = 20;
            this.lblquantity.Text = "Quantity";
            // 
            // cmborderstatus
            // 
            this.cmborderstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmborderstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmborderstatus.FormattingEnabled = true;
            this.cmborderstatus.Items.AddRange(new object[] {
            "Completed",
            "In Progress",
            "Failed"});
            this.cmborderstatus.Location = new System.Drawing.Point(320, 65);
            this.cmborderstatus.Name = "cmborderstatus";
            this.cmborderstatus.Size = new System.Drawing.Size(123, 28);
            this.cmborderstatus.TabIndex = 19;
            this.cmborderstatus.SelectedIndexChanged += new System.EventHandler(this.cmborderstatus_SelectedIndexChanged);
            // 
            // listboxorderitem
            // 
            this.listboxorderitem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxorderitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(56)))));
            this.listboxorderitem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.listboxorderitem.ForeColor = System.Drawing.Color.White;
            this.listboxorderitem.FormattingEnabled = true;
            this.listboxorderitem.ItemHeight = 20;
            this.listboxorderitem.Location = new System.Drawing.Point(9, 65);
            this.listboxorderitem.Name = "listboxorderitem";
            this.listboxorderitem.Size = new System.Drawing.Size(207, 124);
            this.listboxorderitem.TabIndex = 13;
            // 
            // lblordermode
            // 
            this.lblordermode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblordermode.AutoSize = true;
            this.lblordermode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordermode.Location = new System.Drawing.Point(317, 16);
            this.lblordermode.Name = "lblordermode";
            this.lblordermode.Size = new System.Drawing.Size(126, 17);
            this.lblordermode.TabIndex = 12;
            this.lblordermode.Text = "(Observation Mode)";
            // 
            // txtboxorderprice
            // 
            this.txtboxorderprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxorderprice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxorderprice.Location = new System.Drawing.Point(320, 143);
            this.txtboxorderprice.Name = "txtboxorderprice";
            this.txtboxorderprice.Size = new System.Drawing.Size(123, 27);
            this.txtboxorderprice.TabIndex = 9;
            // 
            // txtboxordername
            // 
            this.txtboxordername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxordername.Location = new System.Drawing.Point(133, 27);
            this.txtboxordername.Name = "txtboxordername";
            this.txtboxordername.Size = new System.Drawing.Size(118, 27);
            this.txtboxordername.TabIndex = 7;
            // 
            // lblorderstatus
            // 
            this.lblorderstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblorderstatus.AutoSize = true;
            this.lblorderstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderstatus.Location = new System.Drawing.Point(222, 73);
            this.lblorderstatus.Name = "lblorderstatus";
            this.lblorderstatus.Size = new System.Drawing.Size(50, 20);
            this.lblorderstatus.TabIndex = 6;
            this.lblorderstatus.Text = "Status";
            // 
            // lblorderprice
            // 
            this.lblorderprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblorderprice.AutoSize = true;
            this.lblorderprice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderprice.Location = new System.Drawing.Point(222, 149);
            this.lblorderprice.Name = "lblorderprice";
            this.lblorderprice.Size = new System.Drawing.Size(80, 20);
            this.lblorderprice.TabIndex = 5;
            this.lblorderprice.Text = "Total Price";
            // 
            // lblordercustomername
            // 
            this.lblordercustomername.AutoSize = true;
            this.lblordercustomername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordercustomername.Location = new System.Drawing.Point(6, 30);
            this.lblordercustomername.Name = "lblordercustomername";
            this.lblordercustomername.Size = new System.Drawing.Size(119, 20);
            this.lblordercustomername.TabIndex = 3;
            this.lblordercustomername.Text = "Customer Name";
            // 
            // groupBoxtoday
            // 
            this.groupBoxtoday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxtoday.Controls.Add(this.lbltoday3);
            this.groupBoxtoday.Controls.Add(this.lbltoday2);
            this.groupBoxtoday.Controls.Add(this.lbltoday1);
            this.groupBoxtoday.Controls.Add(this.labeltoday3);
            this.groupBoxtoday.Controls.Add(this.labeltoday2);
            this.groupBoxtoday.Controls.Add(this.labeltoday1);
            this.groupBoxtoday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxtoday.Location = new System.Drawing.Point(338, 306);
            this.groupBoxtoday.Name = "groupBoxtoday";
            this.groupBoxtoday.Size = new System.Drawing.Size(200, 116);
            this.groupBoxtoday.TabIndex = 19;
            this.groupBoxtoday.TabStop = false;
            this.groupBoxtoday.Text = "Today";
            // 
            // lbltoday3
            // 
            this.lbltoday3.AutoSize = true;
            this.lbltoday3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Bold);
            this.lbltoday3.Location = new System.Drawing.Point(27, 100);
            this.lbltoday3.Name = "lbltoday3";
            this.lbltoday3.Size = new System.Drawing.Size(14, 13);
            this.lbltoday3.TabIndex = 6;
            this.lbltoday3.Text = "1";
            // 
            // lbltoday2
            // 
            this.lbltoday2.AutoSize = true;
            this.lbltoday2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Bold);
            this.lbltoday2.Location = new System.Drawing.Point(27, 65);
            this.lbltoday2.Name = "lbltoday2";
            this.lbltoday2.Size = new System.Drawing.Size(14, 13);
            this.lbltoday2.TabIndex = 5;
            this.lbltoday2.Text = "1";
            // 
            // lbltoday1
            // 
            this.lbltoday1.AutoSize = true;
            this.lbltoday1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Bold);
            this.lbltoday1.Location = new System.Drawing.Point(27, 30);
            this.lbltoday1.Name = "lbltoday1";
            this.lbltoday1.Size = new System.Drawing.Size(14, 13);
            this.lbltoday1.TabIndex = 3;
            this.lbltoday1.Text = "1";
            // 
            // labeltoday3
            // 
            this.labeltoday3.AutoSize = true;
            this.labeltoday3.Location = new System.Drawing.Point(6, 96);
            this.labeltoday3.Name = "labeltoday3";
            this.labeltoday3.Size = new System.Drawing.Size(16, 20);
            this.labeltoday3.TabIndex = 2;
            this.labeltoday3.Text = "3";
            // 
            // labeltoday2
            // 
            this.labeltoday2.AutoSize = true;
            this.labeltoday2.Location = new System.Drawing.Point(6, 62);
            this.labeltoday2.Name = "labeltoday2";
            this.labeltoday2.Size = new System.Drawing.Size(17, 20);
            this.labeltoday2.TabIndex = 1;
            this.labeltoday2.Text = "2";
            // 
            // labeltoday1
            // 
            this.labeltoday1.AutoSize = true;
            this.labeltoday1.Location = new System.Drawing.Point(6, 27);
            this.labeltoday1.Name = "labeltoday1";
            this.labeltoday1.Size = new System.Drawing.Size(15, 20);
            this.labeltoday1.TabIndex = 0;
            this.labeltoday1.Text = "1";
            // 
            // groupBoxalltime
            // 
            this.groupBoxalltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxalltime.Controls.Add(this.lbloverall3);
            this.groupBoxalltime.Controls.Add(this.labelalltime3);
            this.groupBoxalltime.Controls.Add(this.lbloverall1);
            this.groupBoxalltime.Controls.Add(this.labelalltime2);
            this.groupBoxalltime.Controls.Add(this.lbloverall2);
            this.groupBoxalltime.Controls.Add(this.labelalltime1);
            this.groupBoxalltime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxalltime.Location = new System.Drawing.Point(581, 306);
            this.groupBoxalltime.Name = "groupBoxalltime";
            this.groupBoxalltime.Size = new System.Drawing.Size(200, 116);
            this.groupBoxalltime.TabIndex = 20;
            this.groupBoxalltime.TabStop = false;
            this.groupBoxalltime.Text = "All-Time";
            // 
            // lbloverall3
            // 
            this.lbloverall3.AutoSize = true;
            this.lbloverall3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Bold);
            this.lbloverall3.Location = new System.Drawing.Point(27, 100);
            this.lbloverall3.Name = "lbloverall3";
            this.lbloverall3.Size = new System.Drawing.Size(14, 13);
            this.lbloverall3.TabIndex = 8;
            this.lbloverall3.Text = "1";
            // 
            // labelalltime3
            // 
            this.labelalltime3.AutoSize = true;
            this.labelalltime3.Location = new System.Drawing.Point(6, 96);
            this.labelalltime3.Name = "labelalltime3";
            this.labelalltime3.Size = new System.Drawing.Size(16, 20);
            this.labelalltime3.TabIndex = 3;
            this.labelalltime3.Text = "3";
            // 
            // lbloverall1
            // 
            this.lbloverall1.AutoSize = true;
            this.lbloverall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Bold);
            this.lbloverall1.Location = new System.Drawing.Point(27, 30);
            this.lbloverall1.Name = "lbloverall1";
            this.lbloverall1.Size = new System.Drawing.Size(14, 13);
            this.lbloverall1.TabIndex = 7;
            this.lbloverall1.Text = "1";
            // 
            // labelalltime2
            // 
            this.labelalltime2.AutoSize = true;
            this.labelalltime2.Location = new System.Drawing.Point(6, 62);
            this.labelalltime2.Name = "labelalltime2";
            this.labelalltime2.Size = new System.Drawing.Size(17, 20);
            this.labelalltime2.TabIndex = 4;
            this.labelalltime2.Text = "2";
            // 
            // lbloverall2
            // 
            this.lbloverall2.AutoSize = true;
            this.lbloverall2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Bold);
            this.lbloverall2.Location = new System.Drawing.Point(27, 65);
            this.lbloverall2.Name = "lbloverall2";
            this.lbloverall2.Size = new System.Drawing.Size(14, 13);
            this.lbloverall2.TabIndex = 4;
            this.lbloverall2.Text = "1";
            // 
            // labelalltime1
            // 
            this.labelalltime1.AutoSize = true;
            this.labelalltime1.Location = new System.Drawing.Point(6, 27);
            this.labelalltime1.Name = "labelalltime1";
            this.labelalltime1.Size = new System.Drawing.Size(15, 20);
            this.labelalltime1.TabIndex = 5;
            this.labelalltime1.Text = "1";
            // 
            // lblmostordered
            // 
            this.lblmostordered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmostordered.AutoSize = true;
            this.lblmostordered.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostordered.Location = new System.Drawing.Point(335, 283);
            this.lblmostordered.Name = "lblmostordered";
            this.lblmostordered.Size = new System.Drawing.Size(139, 20);
            this.lblmostordered.TabIndex = 21;
            this.lblmostordered.Text = "Most ordered items";
            // 
            // lblorderlist
            // 
            this.lblorderlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblorderlist.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderlist.Location = new System.Drawing.Point(24, 23);
            this.lblorderlist.Name = "lblorderlist";
            this.lblorderlist.Size = new System.Drawing.Size(287, 25);
            this.lblorderlist.TabIndex = 22;
            this.lblorderlist.Text = "List of Orders (All)";
            this.lblorderlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnfilter
            // 
            this.btnfilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfilter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.Location = new System.Drawing.Point(176, 375);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(135, 44);
            this.btnfilter.TabIndex = 23;
            this.btnfilter.Text = "Filter today orders only";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // btnnofilter
            // 
            this.btnnofilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnofilter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnofilter.Location = new System.Drawing.Point(176, 375);
            this.btnnofilter.Name = "btnnofilter";
            this.btnnofilter.Size = new System.Drawing.Size(135, 44);
            this.btnnofilter.TabIndex = 24;
            this.btnnofilter.Text = "No filter button";
            this.btnnofilter.UseVisualStyleBackColor = true;
            this.btnnofilter.Click += new System.EventHandler(this.btnnofilter_Click);
            // 
            // lblorderidinvisible
            // 
            this.lblorderidinvisible.AutoSize = true;
            this.lblorderidinvisible.Location = new System.Drawing.Point(610, 9);
            this.lblorderidinvisible.Name = "lblorderidinvisible";
            this.lblorderidinvisible.Size = new System.Drawing.Size(16, 16);
            this.lblorderidinvisible.TabIndex = 25;
            this.lblorderidinvisible.Text = "...";
            // 
            // lblcurrentmenu
            // 
            this.lblcurrentmenu.AutoSize = true;
            this.lblcurrentmenu.Location = new System.Drawing.Point(688, 9);
            this.lblcurrentmenu.Name = "lblcurrentmenu";
            this.lblcurrentmenu.Size = new System.Drawing.Size(16, 16);
            this.lblcurrentmenu.TabIndex = 26;
            this.lblcurrentmenu.Text = "...";
            // 
            // formorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.lblcurrentmenu);
            this.Controls.Add(this.lblorderidinvisible);
            this.Controls.Add(this.btnnofilter);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.lblorderlist);
            this.Controls.Add(this.lblmostordered);
            this.Controls.Add(this.groupBoxalltime);
            this.Controls.Add(this.groupBoxtoday);
            this.Controls.Add(this.btnorderfinish);
            this.Controls.Add(this.btnordersearch);
            this.Controls.Add(this.btnorderedit);
            this.Controls.Add(this.listboxorder);
            this.Controls.Add(this.groupboxorderinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formorder";
            this.Text = "order";
            this.Load += new System.EventHandler(this.formorder_Load);
            this.groupboxorderinfo.ResumeLayout(false);
            this.groupboxorderinfo.PerformLayout();
            this.groupBoxtoday.ResumeLayout(false);
            this.groupBoxtoday.PerformLayout();
            this.groupBoxalltime.ResumeLayout(false);
            this.groupBoxalltime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnorderfinish;
        private System.Windows.Forms.Button btnordersearch;
        private System.Windows.Forms.Button btnorderedit;
        private System.Windows.Forms.ListBox listboxorder;
        private System.Windows.Forms.GroupBox groupboxorderinfo;
        private System.Windows.Forms.Label lblordermode;
        private System.Windows.Forms.TextBox txtboxorderprice;
        private System.Windows.Forms.TextBox txtboxordername;
        private System.Windows.Forms.Label lblorderstatus;
        private System.Windows.Forms.Label lblorderprice;
        private System.Windows.Forms.Label lblordercustomername;
        private System.Windows.Forms.ListBox listboxorderitem;
        private System.Windows.Forms.ComboBox cmborderstatus;
        private System.Windows.Forms.GroupBox groupBoxtoday;
        private System.Windows.Forms.GroupBox groupBoxalltime;
        private System.Windows.Forms.Label labeltoday3;
        private System.Windows.Forms.Label labeltoday2;
        private System.Windows.Forms.Label labeltoday1;
        private System.Windows.Forms.Label labelalltime3;
        private System.Windows.Forms.Label labelalltime2;
        private System.Windows.Forms.Label labelalltime1;
        private System.Windows.Forms.Label lblmostordered;
        private System.Windows.Forms.Label lblorderlist;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Button btnnofilter;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtboxquantity;
        private System.Windows.Forms.Button btnorderitemindividual;
        private System.Windows.Forms.Label lblorderidinvisible;
        private System.Windows.Forms.Button btnorderitemoverall;
        private System.Windows.Forms.Label lblcurrentmenu;
        private System.Windows.Forms.Label lbltoday3;
        private System.Windows.Forms.Label lbltoday2;
        private System.Windows.Forms.Label lbltoday1;
        private System.Windows.Forms.Label lbloverall3;
        private System.Windows.Forms.Label lbloverall1;
        private System.Windows.Forms.Label lbloverall2;
    }
}