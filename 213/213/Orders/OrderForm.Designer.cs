namespace _213
{
    partial class OrderForm
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
            this.POBackBtn9 = new System.Windows.Forms.Button();
            this.AddOrderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPricofeachitem = new System.Windows.Forms.TextBox();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdditem = new System.Windows.Forms.Button();
            this.btnremovePrevouis = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuatity = new System.Windows.Forms.TextBox();
            this.cbxSpecialorder = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCust_email = new System.Windows.Forms.TextBox();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.gpxOrders = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gpxSearch = new System.Windows.Forms.GroupBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lbxsearchordelete = new System.Windows.Forms.ListBox();
            this.cbxOrder = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdminHide = new GaryPerkin.UserControls.Buttons.RoundButton();
            this.btnMPromo = new System.Windows.Forms.Button();
            this.btnAdmLogout = new System.Windows.Forms.Button();
            this.btnVLogs = new System.Windows.Forms.Button();
            this.btnEoM = new System.Windows.Forms.Button();
            this.btnREmp = new System.Windows.Forms.Button();
            this.btnUEmp = new System.Windows.Forms.Button();
            this.btnRUser = new System.Windows.Forms.Button();
            this.btnUUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnAdminShow = new GaryPerkin.UserControls.Buttons.RoundButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxOrders = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMiscT = new System.Windows.Forms.Label();
            this.lblMiscB = new System.Windows.Forms.Label();
            this.gbxPayment.SuspendLayout();
            this.gpxOrders.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gpxSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // POBackBtn9
            // 
            this.POBackBtn9.Location = new System.Drawing.Point(1653, 854);
            this.POBackBtn9.Margin = new System.Windows.Forms.Padding(4);
            this.POBackBtn9.Name = "POBackBtn9";
            this.POBackBtn9.Size = new System.Drawing.Size(129, 54);
            this.POBackBtn9.TabIndex = 9;
            this.POBackBtn9.Text = "Back";
            this.POBackBtn9.UseVisualStyleBackColor = true;
            // 
            // AddOrderBtn
            // 
            this.AddOrderBtn.Location = new System.Drawing.Point(724, 380);
            this.AddOrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddOrderBtn.Name = "AddOrderBtn";
            this.AddOrderBtn.Size = new System.Drawing.Size(148, 43);
            this.AddOrderBtn.TabIndex = 8;
            this.AddOrderBtn.Text = "place order";
            this.passTT.SetToolTip(this.AddOrderBtn, "Place the order");
            this.AddOrderBtn.UseVisualStyleBackColor = true;
            this.AddOrderBtn.Click += new System.EventHandler(this.AddOrderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Item name";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(12, 112);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(325, 22);
            this.txtItem.TabIndex = 1;
            this.passTT.SetToolTip(this.txtItem, "Please enter the name of the product.\r\nExample Insperion 3000.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "prices of each item";
            // 
            // txtPricofeachitem
            // 
            this.txtPricofeachitem.Location = new System.Drawing.Point(12, 172);
            this.txtPricofeachitem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPricofeachitem.Name = "txtPricofeachitem";
            this.txtPricofeachitem.Size = new System.Drawing.Size(325, 22);
            this.txtPricofeachitem.TabIndex = 2;
            this.passTT.SetToolTip(this.txtPricofeachitem, "Please enter the price of the product. \r\nExample 5000.");
            // 
            // txtMaker
            // 
            this.txtMaker.Location = new System.Drawing.Point(8, 52);
            this.txtMaker.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(325, 22);
            this.txtMaker.TabIndex = 0;
            this.passTT.SetToolTip(this.txtMaker, "Please enter the manufacturer of the product. \r\nExample Dell.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Make of the hardware";
            // 
            // btnAdditem
            // 
            this.btnAdditem.Location = new System.Drawing.Point(379, 64);
            this.btnAdditem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(148, 43);
            this.btnAdditem.TabIndex = 5;
            this.btnAdditem.Text = "Add item";
            this.passTT.SetToolTip(this.btnAdditem, "Add item to order.");
            this.btnAdditem.UseVisualStyleBackColor = true;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // btnremovePrevouis
            // 
            this.btnremovePrevouis.Location = new System.Drawing.Point(379, 132);
            this.btnremovePrevouis.Margin = new System.Windows.Forms.Padding(4);
            this.btnremovePrevouis.Name = "btnremovePrevouis";
            this.btnremovePrevouis.Size = new System.Drawing.Size(148, 43);
            this.btnremovePrevouis.TabIndex = 6;
            this.btnremovePrevouis.Text = "Remove item";
            this.passTT.SetToolTip(this.btnremovePrevouis, "Remove previous item form order.");
            this.btnremovePrevouis.UseVisualStyleBackColor = true;
            this.btnremovePrevouis.Click += new System.EventHandler(this.btnremovePrevouis_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(379, 191);
            this.btnClearOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(148, 43);
            this.btnClearOrder.TabIndex = 7;
            this.btnClearOrder.Text = "Cancel";
            this.passTT.SetToolTip(this.btnClearOrder, "Cancel current order.");
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Number of this item";
            // 
            // txtQuatity
            // 
            this.txtQuatity.Location = new System.Drawing.Point(12, 239);
            this.txtQuatity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuatity.Name = "txtQuatity";
            this.txtQuatity.Size = new System.Drawing.Size(325, 22);
            this.txtQuatity.TabIndex = 3;
            this.passTT.SetToolTip(this.txtQuatity, "Please enter the quantity of the same product.");
            // 
            // cbxSpecialorder
            // 
            this.cbxSpecialorder.AutoSize = true;
            this.cbxSpecialorder.Location = new System.Drawing.Point(24, 270);
            this.cbxSpecialorder.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSpecialorder.Name = "cbxSpecialorder";
            this.cbxSpecialorder.Size = new System.Drawing.Size(114, 21);
            this.cbxSpecialorder.TabIndex = 4;
            this.cbxSpecialorder.Text = "Special order";
            this.passTT.SetToolTip(this.cbxSpecialorder, "This is for when you order something for a client. \r\nYou need to enter a valid em" +
        "ail address inorder to email the customer when the ordered product is in stock.");
            this.cbxSpecialorder.UseVisualStyleBackColor = true;
            this.cbxSpecialorder.CheckedChanged += new System.EventHandler(this.cbxSpecialorder_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer Email";
            // 
            // txtCust_email
            // 
            this.txtCust_email.Location = new System.Drawing.Point(12, 39);
            this.txtCust_email.Margin = new System.Windows.Forms.Padding(4);
            this.txtCust_email.Name = "txtCust_email";
            this.txtCust_email.Size = new System.Drawing.Size(228, 22);
            this.txtCust_email.TabIndex = 4;
            // 
            // gbxPayment
            // 
            this.gbxPayment.Controls.Add(this.label5);
            this.gbxPayment.Controls.Add(this.txtCust_email);
            this.gbxPayment.Location = new System.Drawing.Point(12, 308);
            this.gbxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPayment.Size = new System.Drawing.Size(261, 82);
            this.gbxPayment.TabIndex = 74;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Special orders for customers";
            // 
            // gpxOrders
            // 
            this.gpxOrders.Controls.Add(this.tableLayoutPanel3);
            this.gpxOrders.Controls.Add(this.lbxOutput);
            this.gpxOrders.Controls.Add(this.label1);
            this.gpxOrders.Controls.Add(this.gbxPayment);
            this.gpxOrders.Controls.Add(this.txtItem);
            this.gpxOrders.Controls.Add(this.btnClearOrder);
            this.gpxOrders.Controls.Add(this.cbxSpecialorder);
            this.gpxOrders.Controls.Add(this.btnremovePrevouis);
            this.gpxOrders.Controls.Add(this.label3);
            this.gpxOrders.Controls.Add(this.AddOrderBtn);
            this.gpxOrders.Controls.Add(this.btnAdditem);
            this.gpxOrders.Controls.Add(this.label2);
            this.gpxOrders.Controls.Add(this.txtPricofeachitem);
            this.gpxOrders.Controls.Add(this.txtQuatity);
            this.gpxOrders.Controls.Add(this.txtMaker);
            this.gpxOrders.Controls.Add(this.label4);
            this.gpxOrders.Location = new System.Drawing.Point(4, 4);
            this.gpxOrders.Margin = new System.Windows.Forms.Padding(4);
            this.gpxOrders.Name = "gpxOrders";
            this.gpxOrders.Padding = new System.Windows.Forms.Padding(4);
            this.gpxOrders.Size = new System.Drawing.Size(1016, 444);
            this.gpxOrders.TabIndex = 75;
            this.gpxOrders.TabStop = false;
            this.gpxOrders.Text = "Orders";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1037F));
            this.tableLayoutPanel3.Controls.Add(this.gpxSearch, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(953, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1037, 516);
            this.tableLayoutPanel3.TabIndex = 79;
            // 
            // gpxSearch
            // 
            this.gpxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gpxSearch.Controls.Add(this.lblOrder);
            this.gpxSearch.Controls.Add(this.lbxsearchordelete);
            this.gpxSearch.Controls.Add(this.cbxOrder);
            this.gpxSearch.Controls.Add(this.btnCancel);
            this.gpxSearch.Controls.Add(this.label8);
            this.gpxSearch.Location = new System.Drawing.Point(239, 4);
            this.gpxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gpxSearch.Name = "gpxSearch";
            this.gpxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gpxSearch.Size = new System.Drawing.Size(559, 508);
            this.gpxSearch.TabIndex = 76;
            this.gpxSearch.TabStop = false;
            this.gpxSearch.Text = "Search for a order";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(16, 96);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(0, 17);
            this.lblOrder.TabIndex = 74;
            // 
            // lbxsearchordelete
            // 
            this.lbxsearchordelete.FormattingEnabled = true;
            this.lbxsearchordelete.ItemHeight = 16;
            this.lbxsearchordelete.Location = new System.Drawing.Point(20, 116);
            this.lbxsearchordelete.Margin = new System.Windows.Forms.Padding(4);
            this.lbxsearchordelete.Name = "lbxsearchordelete";
            this.lbxsearchordelete.Size = new System.Drawing.Size(479, 244);
            this.lbxsearchordelete.TabIndex = 73;
            // 
            // cbxOrder
            // 
            this.cbxOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxOrder.FormattingEnabled = true;
            this.cbxOrder.Location = new System.Drawing.Point(20, 60);
            this.cbxOrder.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOrder.Name = "cbxOrder";
            this.cbxOrder.Size = new System.Drawing.Size(155, 24);
            this.cbxOrder.TabIndex = 72;
            this.passTT.SetToolTip(this.cbxOrder, "Select the order you are looking for. From the drop down menu.");
            this.cbxOrder.SelectedIndexChanged += new System.EventHandler(this.cbxOrder_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(199, 383);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 28);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancel Order";
            this.passTT.SetToolTip(this.btnCancel, "This cancel\'s the order you selected above in the dropdown menu.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Please enter the order ID";
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 16;
            this.lbxOutput.Items.AddRange(new object[] {
            ""});
            this.lbxOutput.Location = new System.Drawing.Point(569, 32);
            this.lbxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(413, 324);
            this.lbxOutput.TabIndex = 75;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(931, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 25);
            this.btnBack.TabIndex = 77;
            this.btnBack.Text = "Back";
            this.passTT.SetToolTip(this.btnBack, "Go back to the home screen.");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 100;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Order help";
            // 
            // btnAdminHide
            // 
            this.btnAdminHide.BackColor = System.Drawing.Color.White;
            this.btnAdminHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdminHide.Dome = true;
            this.btnAdminHide.Location = new System.Drawing.Point(179, 450);
            this.btnAdminHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminHide.Name = "btnAdminHide";
            this.btnAdminHide.RecessDepth = 0;
            this.btnAdminHide.Size = new System.Drawing.Size(35, 34);
            this.btnAdminHide.TabIndex = 12;
            this.btnAdminHide.Text = "<<";
            this.passTT.SetToolTip(this.btnAdminHide, "Click to hide admin panel");
            this.btnAdminHide.UseVisualStyleBackColor = false;
            this.btnAdminHide.Click += new System.EventHandler(this.btnAdminHide_Click);
            // 
            // btnMPromo
            // 
            this.btnMPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPromo.Location = new System.Drawing.Point(96, 505);
            this.btnMPromo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMPromo.Name = "btnMPromo";
            this.btnMPromo.Size = new System.Drawing.Size(77, 78);
            this.btnMPromo.TabIndex = 8;
            this.btnMPromo.Text = "Promotions";
            this.passTT.SetToolTip(this.btnMPromo, "Click to create/edit promotions");
            this.btnMPromo.UseVisualStyleBackColor = true;
            this.btnMPromo.Click += new System.EventHandler(this.btnMPromo_Click);
            // 
            // btnAdmLogout
            // 
            this.btnAdmLogout.Location = new System.Drawing.Point(12, 661);
            this.btnAdmLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmLogout.Name = "btnAdmLogout";
            this.btnAdmLogout.Size = new System.Drawing.Size(77, 78);
            this.btnAdmLogout.TabIndex = 10;
            this.btnAdmLogout.Text = "Log out";
            this.passTT.SetToolTip(this.btnAdmLogout, "Click to return to the login screen");
            this.btnAdmLogout.UseVisualStyleBackColor = true;
            this.btnAdmLogout.Click += new System.EventHandler(this.btnAdmLogout_Click);
            // 
            // btnVLogs
            // 
            this.btnVLogs.Location = new System.Drawing.Point(12, 582);
            this.btnVLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVLogs.Name = "btnVLogs";
            this.btnVLogs.Size = new System.Drawing.Size(77, 78);
            this.btnVLogs.TabIndex = 9;
            this.btnVLogs.Text = "View activity log";
            this.passTT.SetToolTip(this.btnVLogs, "Click to view users\' activities on stockI.T");
            this.btnVLogs.UseVisualStyleBackColor = true;
            this.btnVLogs.Click += new System.EventHandler(this.btnVLogs_Click);
            // 
            // btnEoM
            // 
            this.btnEoM.Location = new System.Drawing.Point(12, 505);
            this.btnEoM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEoM.Name = "btnEoM";
            this.btnEoM.Size = new System.Drawing.Size(77, 78);
            this.btnEoM.TabIndex = 7;
            this.btnEoM.Text = "Employee of the month";
            this.passTT.SetToolTip(this.btnEoM, "Click to view employee of the month details");
            this.btnEoM.UseVisualStyleBackColor = true;
            this.btnEoM.Click += new System.EventHandler(this.btnEoM_Click);
            // 
            // btnREmp
            // 
            this.btnREmp.Location = new System.Drawing.Point(12, 369);
            this.btnREmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnREmp.Name = "btnREmp";
            this.btnREmp.Size = new System.Drawing.Size(77, 78);
            this.btnREmp.TabIndex = 6;
            this.btnREmp.Text = "Remove Employee";
            this.passTT.SetToolTip(this.btnREmp, "Click to remove existing employees of Matrix Warehouse");
            this.btnREmp.UseVisualStyleBackColor = true;
            this.btnREmp.Click += new System.EventHandler(this.btnREmp_Click);
            // 
            // btnUEmp
            // 
            this.btnUEmp.Location = new System.Drawing.Point(96, 290);
            this.btnUEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUEmp.Name = "btnUEmp";
            this.btnUEmp.Size = new System.Drawing.Size(77, 78);
            this.btnUEmp.TabIndex = 5;
            this.btnUEmp.Text = "Update Employee";
            this.passTT.SetToolTip(this.btnUEmp, "Click to update information of existing Matrix Warehouse employees");
            this.btnUEmp.UseVisualStyleBackColor = true;
            this.btnUEmp.Click += new System.EventHandler(this.btnUEmp_Click);
            // 
            // btnRUser
            // 
            this.btnRUser.Location = new System.Drawing.Point(12, 153);
            this.btnRUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRUser.Name = "btnRUser";
            this.btnRUser.Size = new System.Drawing.Size(77, 78);
            this.btnRUser.TabIndex = 3;
            this.btnRUser.Text = "Remove User";
            this.passTT.SetToolTip(this.btnRUser, "Click to remove existing stockI.T users");
            this.btnRUser.UseVisualStyleBackColor = true;
            this.btnRUser.Click += new System.EventHandler(this.btnRUser_Click);
            // 
            // btnUUser
            // 
            this.btnUUser.Location = new System.Drawing.Point(96, 75);
            this.btnUUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUUser.Name = "btnUUser";
            this.btnUUser.Size = new System.Drawing.Size(77, 78);
            this.btnUUser.TabIndex = 2;
            this.btnUUser.Text = "Update User";
            this.passTT.SetToolTip(this.btnUUser, "Click to update details of existing stockI.T users");
            this.btnUUser.UseVisualStyleBackColor = true;
            this.btnUUser.Click += new System.EventHandler(this.btnUUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(12, 75);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(77, 78);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.passTT.SetToolTip(this.btnAddUser, "Click to create more users for stockI.T");
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(96, 661);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 78);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.passTT.SetToolTip(this.btnExit, "Click to exit stockI.T");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(12, 290);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(77, 78);
            this.btnAddEmp.TabIndex = 4;
            this.btnAddEmp.Text = "Add Employee";
            this.passTT.SetToolTip(this.btnAddEmp, "Click to add employees of Matrix Warehouse");
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnAdminShow
            // 
            this.btnAdminShow.BackColor = System.Drawing.Color.White;
            this.btnAdminShow.Location = new System.Drawing.Point(-3, 351);
            this.btnAdminShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminShow.Name = "btnAdminShow";
            this.btnAdminShow.RecessDepth = 0;
            this.btnAdminShow.Size = new System.Drawing.Size(35, 34);
            this.btnAdminShow.TabIndex = 81;
            this.btnAdminShow.Text = ">>";
            this.passTT.SetToolTip(this.btnAdminShow, "Click to show admin panel");
            this.btnAdminShow.UseVisualStyleBackColor = false;
            this.btnAdminShow.Click += new System.EventHandler(this.btnAdminShow_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 927F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.cbxOrders, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 159);
            this.tableLayoutPanel1.TabIndex = 78;
            // 
            // cbxOrders
            // 
            this.cbxOrders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxOrders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxOrders.FormattingEnabled = true;
            this.cbxOrders.Items.AddRange(new object[] {
            "Order for this Matrix Branch/Special order",
            "Search order/Cancel order"});
            this.cbxOrders.Location = new System.Drawing.Point(4, 4);
            this.cbxOrders.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOrders.Name = "cbxOrders";
            this.cbxOrders.Size = new System.Drawing.Size(432, 24);
            this.cbxOrders.TabIndex = 58;
            this.cbxOrders.Text = "Please choose what you want to do";
            this.cbxOrders.SelectedIndexChanged += new System.EventHandler(this.cbxOrders_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1045F));
            this.tableLayoutPanel2.Controls.Add(this.gpxOrders, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(45, 109);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1045, 638);
            this.tableLayoutPanel2.TabIndex = 79;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlAdmin.Controls.Add(this.btnAdminHide);
            this.pnlAdmin.Controls.Add(this.btnMPromo);
            this.pnlAdmin.Controls.Add(this.btnAdmLogout);
            this.pnlAdmin.Controls.Add(this.label9);
            this.pnlAdmin.Controls.Add(this.label7);
            this.pnlAdmin.Controls.Add(this.label6);
            this.pnlAdmin.Controls.Add(this.label10);
            this.pnlAdmin.Controls.Add(this.label11);
            this.pnlAdmin.Controls.Add(this.btnVLogs);
            this.pnlAdmin.Controls.Add(this.btnEoM);
            this.pnlAdmin.Controls.Add(this.btnREmp);
            this.pnlAdmin.Controls.Add(this.btnUEmp);
            this.pnlAdmin.Controls.Add(this.btnRUser);
            this.pnlAdmin.Controls.Add(this.label12);
            this.pnlAdmin.Controls.Add(this.label13);
            this.pnlAdmin.Controls.Add(this.label14);
            this.pnlAdmin.Controls.Add(this.btnUUser);
            this.pnlAdmin.Controls.Add(this.btnAddUser);
            this.pnlAdmin.Controls.Add(this.btnExit);
            this.pnlAdmin.Controls.Add(this.lblMiscT);
            this.pnlAdmin.Controls.Add(this.lblMiscB);
            this.pnlAdmin.Controls.Add(this.btnAddEmp);
            this.pnlAdmin.Location = new System.Drawing.Point(-216, -1);
            this.pnlAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(213, 1401);
            this.pnlAdmin.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Misc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(-13, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "_____________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Users";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Chocolate;
            this.label11.Location = new System.Drawing.Point(-13, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "_____________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Chocolate;
            this.label12.Location = new System.Drawing.Point(-13, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "_____________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Administrative";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(-3, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "_____________________________";
            // 
            // lblMiscT
            // 
            this.lblMiscT.AutoSize = true;
            this.lblMiscT.BackColor = System.Drawing.Color.Transparent;
            this.lblMiscT.ForeColor = System.Drawing.Color.Chocolate;
            this.lblMiscT.Location = new System.Drawing.Point(-13, 447);
            this.lblMiscT.Name = "lblMiscT";
            this.lblMiscT.Size = new System.Drawing.Size(240, 17);
            this.lblMiscT.TabIndex = 0;
            this.lblMiscT.Text = "_____________________________";
            // 
            // lblMiscB
            // 
            this.lblMiscB.AutoSize = true;
            this.lblMiscB.BackColor = System.Drawing.Color.Transparent;
            this.lblMiscB.ForeColor = System.Drawing.Color.Chocolate;
            this.lblMiscB.Location = new System.Drawing.Point(-5, 479);
            this.lblMiscB.Name = "lblMiscB";
            this.lblMiscB.Size = new System.Drawing.Size(240, 17);
            this.lblMiscB.TabIndex = 0;
            this.lblMiscB.Text = "_____________________________";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 811);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnAdminShow);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.POBackBtn9);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.gpxOrders.ResumeLayout(false);
            this.gpxOrders.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gpxSearch.ResumeLayout(false);
            this.gpxSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button POBackBtn9;
        private System.Windows.Forms.Button AddOrderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPricofeachitem;
        private System.Windows.Forms.TextBox txtMaker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.Button btnremovePrevouis;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuatity;
        private System.Windows.Forms.CheckBox cbxSpecialorder;
        private System.Windows.Forms.TextBox txtCust_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.GroupBox gpxOrders;
        private System.Windows.Forms.GroupBox gpxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.ComboBox cbxOrder;
        private System.Windows.Forms.ListBox lbxsearchordelete;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ToolTip passTT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel pnlAdmin;
        private GaryPerkin.UserControls.Buttons.RoundButton btnAdminHide;
        private System.Windows.Forms.Button btnMPromo;
        private System.Windows.Forms.Button btnAdmLogout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVLogs;
        private System.Windows.Forms.Button btnEoM;
        private System.Windows.Forms.Button btnREmp;
        private System.Windows.Forms.Button btnUEmp;
        private System.Windows.Forms.Button btnRUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMiscT;
        private System.Windows.Forms.Label lblMiscB;
        private System.Windows.Forms.Button btnAddEmp;
        private GaryPerkin.UserControls.Buttons.RoundButton btnAdminShow;
    }
}