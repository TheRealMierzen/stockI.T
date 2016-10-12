namespace _213
{
    partial class StockMainFormCLN
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
            this.cmbSelectStockAction = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbStockTakeReport = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblStockTakeItemID = new System.Windows.Forms.Label();
            this.txtStockTakeItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompleteStockTake = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActionSelect = new System.Windows.Forms.Label();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbStockTake = new System.Windows.Forms.TextBox();
            this.btnAdminShow = new GaryPerkin.UserControls.Buttons.RoundButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bgWDetails = new System.ComponentModel.BackgroundWorker();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnAdminHide = new GaryPerkin.UserControls.Buttons.RoundButton();
            this.btnMPromo = new System.Windows.Forms.Button();
            this.btnAdmLogout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVLogs = new System.Windows.Forms.Button();
            this.btnEoM = new System.Windows.Forms.Button();
            this.btnREmp = new System.Windows.Forms.Button();
            this.btnUEmp = new System.Windows.Forms.Button();
            this.btnRUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMiscT = new System.Windows.Forms.Label();
            this.lblMiscB = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSelectStockAction
            // 
            this.cmbSelectStockAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSelectStockAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectStockAction.FormattingEnabled = true;
            this.cmbSelectStockAction.Items.AddRange(new object[] {
            "Add Stock",
            "Find Stock",
            "Update Stock",
            "Transfer Stock",
            "Remove Stock"});
            this.cmbSelectStockAction.Location = new System.Drawing.Point(83, 3);
            this.cmbSelectStockAction.Name = "cmbSelectStockAction";
            this.cmbSelectStockAction.Size = new System.Drawing.Size(276, 24);
            this.cmbSelectStockAction.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbSelectStockAction, "Select an action to visit that window");
            this.cmbSelectStockAction.SelectedIndexChanged += new System.EventHandler(this.cmbSelectStockAction_SelectedIndexChanged);
            this.cmbSelectStockAction.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectStockAction_SelectionChangeCommitted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.250631F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58312F));
            this.tableLayoutPanel1.Controls.Add(this.txbStockTakeReport, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbStockTake, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1524, 734);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txbStockTakeReport
            // 
            this.txbStockTakeReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbStockTakeReport.Location = new System.Drawing.Point(564, 185);
            this.txbStockTakeReport.Multiline = true;
            this.txbStockTakeReport.Name = "txbStockTakeReport";
            this.txbStockTakeReport.ReadOnly = true;
            this.txbStockTakeReport.Size = new System.Drawing.Size(475, 546);
            this.txbStockTakeReport.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txbStockTakeReport, "Here is a report on what happend to the stock today");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.52809F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.Controls.Add(this.btnCompare, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStockTakeItemID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtStockTakeItemID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCompleteStockTake, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 67);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // btnCompare
            // 
            this.btnCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompare.Location = new System.Drawing.Point(367, 3);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(105, 27);
            this.btnCompare.TabIndex = 16;
            this.btnCompare.Text = "Compare/Add";
            this.toolTip1.SetToolTip(this.btnCompare, "Click to add item to check list");
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click_1);
            // 
            // lblStockTakeItemID
            // 
            this.lblStockTakeItemID.AutoSize = true;
            this.lblStockTakeItemID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockTakeItemID.Location = new System.Drawing.Point(3, 0);
            this.lblStockTakeItemID.Name = "lblStockTakeItemID";
            this.lblStockTakeItemID.Size = new System.Drawing.Size(76, 33);
            this.lblStockTakeItemID.TabIndex = 14;
            this.lblStockTakeItemID.Text = "Item ID";
            // 
            // txtStockTakeItemID
            // 
            this.txtStockTakeItemID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStockTakeItemID.Location = new System.Drawing.Point(85, 3);
            this.txtStockTakeItemID.MaxLength = 25;
            this.txtStockTakeItemID.Name = "txtStockTakeItemID";
            this.txtStockTakeItemID.ShortcutsEnabled = false;
            this.txtStockTakeItemID.Size = new System.Drawing.Size(276, 22);
            this.txtStockTakeItemID.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtStockTakeItemID, "Scan in the ID you have to let the system know you have that item");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Stock Items Recorded";
            // 
            // btnCompleteStockTake
            // 
            this.btnCompleteStockTake.Location = new System.Drawing.Point(367, 36);
            this.btnCompleteStockTake.Name = "btnCompleteStockTake";
            this.btnCompleteStockTake.Size = new System.Drawing.Size(99, 28);
            this.btnCompleteStockTake.TabIndex = 20;
            this.btnCompleteStockTake.Text = "Complete";
            this.toolTip1.SetToolTip(this.btnCompleteStockTake, "Click to complete stock take");
            this.btnCompleteStockTake.UseVisualStyleBackColor = true;
            this.btnCompleteStockTake.Click += new System.EventHandler(this.btnCompleteStockTake_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.26415F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.73585F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel3.Controls.Add(this.lblActionSelect, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBackMain, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbSelectStockAction, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(83, 39);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 67);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // lblActionSelect
            // 
            this.lblActionSelect.AutoSize = true;
            this.lblActionSelect.Location = new System.Drawing.Point(3, 0);
            this.lblActionSelect.Name = "lblActionSelect";
            this.lblActionSelect.Size = new System.Drawing.Size(51, 34);
            this.lblActionSelect.TabIndex = 0;
            this.lblActionSelect.Text = "Select Action";
            // 
            // btnBackMain
            // 
            this.btnBackMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackMain.Location = new System.Drawing.Point(365, 3);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(107, 47);
            this.btnBackMain.TabIndex = 4;
            this.btnBackMain.Text = "Back";
            this.toolTip1.SetToolTip(this.btnBackMain, "Click to close this form and go back to main form");
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(564, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Stock Status from Today";
            // 
            // txbStockTake
            // 
            this.txbStockTake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbStockTake.Location = new System.Drawing.Point(83, 185);
            this.txbStockTake.Multiline = true;
            this.txbStockTake.Name = "txbStockTake";
            this.txbStockTake.ReadOnly = true;
            this.txbStockTake.Size = new System.Drawing.Size(475, 546);
            this.txbStockTake.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txbStockTake, "Here are a list of all the items that are missing from the stock take");
            // 
            // btnAdminShow
            // 
            this.btnAdminShow.BackColor = System.Drawing.Color.White;
            this.btnAdminShow.Location = new System.Drawing.Point(3, 148);
            this.btnAdminShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminShow.Name = "btnAdminShow";
            this.btnAdminShow.RecessDepth = 0;
            this.btnAdminShow.Size = new System.Drawing.Size(35, 34);
            this.btnAdminShow.TabIndex = 25;
            this.btnAdminShow.Text = ">>";
            this.btnAdminShow.UseVisualStyleBackColor = false;
            this.btnAdminShow.Click += new System.EventHandler(this.btnAdminShow_Click);
            // 
            // bgWDetails
            // 
            this.bgWDetails.WorkerSupportsCancellation = true;
            this.bgWDetails.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWDetails_DoWork);
            this.bgWDetails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWDetails_RunWorkerCompleted);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlAdmin.Controls.Add(this.btnAdminHide);
            this.pnlAdmin.Controls.Add(this.btnMPromo);
            this.pnlAdmin.Controls.Add(this.btnAdmLogout);
            this.pnlAdmin.Controls.Add(this.label9);
            this.pnlAdmin.Controls.Add(this.label7);
            this.pnlAdmin.Controls.Add(this.label8);
            this.pnlAdmin.Controls.Add(this.label5);
            this.pnlAdmin.Controls.Add(this.label6);
            this.pnlAdmin.Controls.Add(this.btnVLogs);
            this.pnlAdmin.Controls.Add(this.btnEoM);
            this.pnlAdmin.Controls.Add(this.btnREmp);
            this.pnlAdmin.Controls.Add(this.btnUEmp);
            this.pnlAdmin.Controls.Add(this.btnRUser);
            this.pnlAdmin.Controls.Add(this.label3);
            this.pnlAdmin.Controls.Add(this.label4);
            this.pnlAdmin.Controls.Add(this.label10);
            this.pnlAdmin.Controls.Add(this.btnUUser);
            this.pnlAdmin.Controls.Add(this.btnAddUser);
            this.pnlAdmin.Controls.Add(this.btnExit);
            this.pnlAdmin.Controls.Add(this.lblMiscT);
            this.pnlAdmin.Controls.Add(this.lblMiscB);
            this.pnlAdmin.Controls.Add(this.btnAddEmp);
            this.pnlAdmin.Location = new System.Drawing.Point(-214, -1);
            this.pnlAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(213, 1401);
            this.pnlAdmin.TabIndex = 17;
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
            this.btnAdmLogout.UseVisualStyleBackColor = true;
            this.btnAdmLogout.Click += new System.EventHandler(this.btnAdmLogout_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(-13, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "_____________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(-13, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "_____________________________";
            // 
            // btnVLogs
            // 
            this.btnVLogs.Location = new System.Drawing.Point(12, 582);
            this.btnVLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVLogs.Name = "btnVLogs";
            this.btnVLogs.Size = new System.Drawing.Size(77, 78);
            this.btnVLogs.TabIndex = 9;
            this.btnVLogs.Text = "View activity log";
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
            this.btnRUser.UseVisualStyleBackColor = true;
            this.btnRUser.Click += new System.EventHandler(this.btnRUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(-13, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "_____________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Administrative";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(-3, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "_____________________________";
            // 
            // btnUUser
            // 
            this.btnUUser.Location = new System.Drawing.Point(96, 75);
            this.btnUUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUUser.Name = "btnUUser";
            this.btnUUser.Size = new System.Drawing.Size(77, 78);
            this.btnUUser.TabIndex = 2;
            this.btnUUser.Text = "Update User";
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
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(12, 290);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(77, 78);
            this.btnAddEmp.TabIndex = 4;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // StockMainFormCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 734);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockMainFormCLN";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockMainForm_Load);
            this.Shown += new System.EventHandler(this.StockMainForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectStockAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblActionSelect;
        private System.Windows.Forms.Label lblStockTakeItemID;
        private System.Windows.Forms.TextBox txtStockTakeItemID;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txbStockTake;
        private System.Windows.Forms.Button btnCompleteStockTake;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbStockTakeReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker bgWDetails;
        private System.Windows.Forms.Panel pnlAdmin;
        private GaryPerkin.UserControls.Buttons.RoundButton btnAdminHide;
        private System.Windows.Forms.Button btnMPromo;
        private System.Windows.Forms.Button btnAdmLogout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVLogs;
        private System.Windows.Forms.Button btnEoM;
        private System.Windows.Forms.Button btnREmp;
        private System.Windows.Forms.Button btnUEmp;
        private System.Windows.Forms.Button btnRUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMiscT;
        private System.Windows.Forms.Label lblMiscB;
        private System.Windows.Forms.Button btnAddEmp;
        private GaryPerkin.UserControls.Buttons.RoundButton btnAdminShow;
        private System.Windows.Forms.Button btnBackMain;
    }
}