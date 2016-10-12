namespace _213
{
    partial class EndOfDay
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnTransfers = new System.Windows.Forms.Button();
            this.btnCompleteReport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOrderReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.btnTransfersReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompleteDay = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMiscT = new System.Windows.Forms.Label();
            this.lblMiscB = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnAdminShow = new GaryPerkin.UserControls.Buttons.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(71, 35);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(161, 49);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders Report";
            this.toolTip1.SetToolTip(this.btnOrders, "Orders Tabel View");
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(281, 35);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(153, 49);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales Report";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(501, 35);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(185, 49);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock Report";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnTransfers
            // 
            this.btnTransfers.Location = new System.Drawing.Point(750, 35);
            this.btnTransfers.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransfers.Name = "btnTransfers";
            this.btnTransfers.Size = new System.Drawing.Size(165, 49);
            this.btnTransfers.TabIndex = 4;
            this.btnTransfers.Text = "Transfer Report";
            this.btnTransfers.UseVisualStyleBackColor = true;
            this.btnTransfers.Click += new System.EventHandler(this.btnTransfers_Click);
            // 
            // btnCompleteReport
            // 
            this.btnCompleteReport.Location = new System.Drawing.Point(1065, 35);
            this.btnCompleteReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleteReport.Name = "btnCompleteReport";
            this.btnCompleteReport.Size = new System.Drawing.Size(172, 49);
            this.btnCompleteReport.TabIndex = 6;
            this.btnCompleteReport.Text = "View Complete Summarized Report";
            this.btnCompleteReport.UseVisualStyleBackColor = true;
            this.btnCompleteReport.Click += new System.EventHandler(this.btnCompleteReport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(941, 175);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(443, 394);
            this.textBox1.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 569);
            this.dataGridView1.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOrderReport
            // 
            this.btnOrderReport.Location = new System.Drawing.Point(941, 139);
            this.btnOrderReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderReport.Name = "btnOrderReport";
            this.btnOrderReport.Size = new System.Drawing.Size(100, 28);
            this.btnOrderReport.TabIndex = 21;
            this.btnOrderReport.Text = "Orders";
            this.btnOrderReport.UseVisualStyleBackColor = true;
            this.btnOrderReport.Click += new System.EventHandler(this.btnOrderReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(1049, 139);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(100, 28);
            this.btnSalesReport.TabIndex = 22;
            this.btnSalesReport.Text = "Sales";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnStockReport
            // 
            this.btnStockReport.Location = new System.Drawing.Point(1157, 139);
            this.btnStockReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(100, 28);
            this.btnStockReport.TabIndex = 23;
            this.btnStockReport.Text = "Stock";
            this.btnStockReport.UseVisualStyleBackColor = true;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // btnTransfersReport
            // 
            this.btnTransfersReport.Location = new System.Drawing.Point(1265, 139);
            this.btnTransfersReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransfersReport.Name = "btnTransfersReport";
            this.btnTransfersReport.Size = new System.Drawing.Size(100, 28);
            this.btnTransfersReport.TabIndex = 24;
            this.btnTransfersReport.Text = "Transfers";
            this.btnTransfersReport.UseVisualStyleBackColor = true;
            this.btnTransfersReport.Click += new System.EventHandler(this.btnTransferReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Use these Buttons below for Individual Summarized Reports";
            // 
            // btnCompleteDay
            // 
            this.btnCompleteDay.Location = new System.Drawing.Point(1557, 107);
            this.btnCompleteDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleteDay.Name = "btnCompleteDay";
            this.btnCompleteDay.Size = new System.Drawing.Size(195, 49);
            this.btnCompleteDay.TabIndex = 26;
            this.btnCompleteDay.Text = "Complete Day";
            this.btnCompleteDay.UseVisualStyleBackColor = true;
            this.btnCompleteDay.Click += new System.EventHandler(this.btnCompleteDay_Click);
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
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.label4);
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
            this.pnlAdmin.TabIndex = 27;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrative";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(-3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "_____________________________";
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
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
            // btnAdminShow
            // 
            this.btnAdminShow.BackColor = System.Drawing.Color.White;
            this.btnAdminShow.Location = new System.Drawing.Point(12, 368);
            this.btnAdminShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminShow.Name = "btnAdminShow";
            this.btnAdminShow.RecessDepth = 0;
            this.btnAdminShow.Size = new System.Drawing.Size(35, 34);
            this.btnAdminShow.TabIndex = 28;
            this.btnAdminShow.Text = ">>";
            this.btnAdminShow.UseVisualStyleBackColor = false;
            this.btnAdminShow.Click += new System.EventHandler(this.btnAdminShow_Click);
            // 
            // EndOfDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 721);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnAdminShow);
            this.Controls.Add(this.btnCompleteDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransfersReport);
            this.Controls.Add(this.btnStockReport);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnOrderReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCompleteReport);
            this.Controls.Add(this.btnTransfers);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnOrders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EndOfDay";
            this.Text = "EndOfDay";
            this.Load += new System.EventHandler(this.EndOfDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnTransfers;
        private System.Windows.Forms.Button btnCompleteReport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOrderReport;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnTransfersReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompleteDay;
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMiscT;
        private System.Windows.Forms.Label lblMiscB;
        private System.Windows.Forms.Button btnAddEmp;
        private GaryPerkin.UserControls.Buttons.RoundButton btnAdminShow;
    }
}