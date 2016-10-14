namespace _213
{
    partial class FrmTechnical
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
            this.cbxLayout = new System.Windows.Forms.ComboBox();
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxCollected = new System.Windows.Forms.CheckBox();
            this.cbxCompleted = new System.Windows.Forms.CheckBox();
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnConfirmRep = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.rbtnWarranty = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpxtech = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrim = new System.Windows.Forms.ComboBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMics = new System.Windows.Forms.TextBox();
            this.txtCpu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPsu = new System.Windows.Forms.ComboBox();
            this.txtGpu = new System.Windows.Forms.ComboBox();
            this.txtRam = new System.Windows.Forms.ComboBox();
            this.txtmobo = new System.Windows.Forms.ComboBox();
            this.Cpu = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMiscT = new System.Windows.Forms.Label();
            this.lblMiscB = new System.Windows.Forms.Label();
            this.gpbClient.SuspendLayout();
            this.gpxtech.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxLayout
            // 
            this.cbxLayout.FormattingEnabled = true;
            this.cbxLayout.Items.AddRange(new object[] {
            "Custom build",
            "Repairs",
            "Review Repairs"});
            this.cbxLayout.Location = new System.Drawing.Point(4, 4);
            this.cbxLayout.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLayout.Name = "cbxLayout";
            this.cbxLayout.Size = new System.Drawing.Size(372, 24);
            this.cbxLayout.TabIndex = 0;
            this.cbxLayout.SelectedIndexChanged += new System.EventHandler(this.cbxLayout_SelectedIndexChanged);
            // 
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.button1);
            this.gpbClient.Controls.Add(this.cbxCollected);
            this.gpbClient.Controls.Add(this.cbxCompleted);
            this.gpbClient.Controls.Add(this.txtRepairID);
            this.gpbClient.Controls.Add(this.label21);
            this.gpbClient.Controls.Add(this.btnConfirmRep);
            this.gpbClient.Controls.Add(this.textBox2);
            this.gpbClient.Controls.Add(this.label20);
            this.gpbClient.Controls.Add(this.rbtnWarranty);
            this.gpbClient.Controls.Add(this.textBox1);
            this.gpbClient.Controls.Add(this.label19);
            this.gpbClient.Controls.Add(this.txtEmail);
            this.gpbClient.Controls.Add(this.label6);
            this.gpbClient.Location = new System.Drawing.Point(4, 4);
            this.gpbClient.Margin = new System.Windows.Forms.Padding(4);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Padding = new System.Windows.Forms.Padding(4);
            this.gpbClient.Size = new System.Drawing.Size(389, 184);
            this.gpbClient.TabIndex = 2;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Client info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxCollected
            // 
            this.cbxCollected.AutoSize = true;
            this.cbxCollected.Location = new System.Drawing.Point(22, 89);
            this.cbxCollected.Name = "cbxCollected";
            this.cbxCollected.Size = new System.Drawing.Size(88, 21);
            this.cbxCollected.TabIndex = 17;
            this.cbxCollected.Text = "Collected";
            this.cbxCollected.UseVisualStyleBackColor = true;
            this.cbxCollected.CheckedChanged += new System.EventHandler(this.cbxCollected_CheckedChanged);
            // 
            // cbxCompleted
            // 
            this.cbxCompleted.AutoSize = true;
            this.cbxCompleted.Location = new System.Drawing.Point(22, 55);
            this.cbxCompleted.Name = "cbxCompleted";
            this.cbxCompleted.Size = new System.Drawing.Size(97, 21);
            this.cbxCompleted.TabIndex = 16;
            this.cbxCompleted.Text = "Completed";
            this.cbxCompleted.UseVisualStyleBackColor = true;
            this.cbxCompleted.CheckedChanged += new System.EventHandler(this.cbxCompleted_CheckedChanged);
            // 
            // txtRepairID
            // 
            this.txtRepairID.Location = new System.Drawing.Point(94, 26);
            this.txtRepairID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(229, 22);
            this.txtRepairID.TabIndex = 15;
            this.passTT.SetToolTip(this.txtRepairID, "Please enter the Client\'s E-Mail.");
            this.txtRepairID.TextChanged += new System.EventHandler(this.txtRepairID_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 26);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 17);
            this.label21.TabIndex = 14;
            this.label21.Text = "Repair ID";
            // 
            // btnConfirmRep
            // 
            this.btnConfirmRep.Location = new System.Drawing.Point(204, 128);
            this.btnConfirmRep.Name = "btnConfirmRep";
            this.btnConfirmRep.Size = new System.Drawing.Size(98, 31);
            this.btnConfirmRep.TabIndex = 2;
            this.btnConfirmRep.Text = "Complete";
            this.btnConfirmRep.UseVisualStyleBackColor = true;
            this.btnConfirmRep.Click += new System.EventHandler(this.btnConfirmRep_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 89);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 22);
            this.textBox2.TabIndex = 13;
            this.passTT.SetToolTip(this.textBox2, "Please enter the Client\'s E-Mail.");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 92);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 17);
            this.label20.TabIndex = 12;
            this.label20.Text = "Cell";
            // 
            // rbtnWarranty
            // 
            this.rbtnWarranty.AutoSize = true;
            this.rbtnWarranty.Location = new System.Drawing.Point(84, 118);
            this.rbtnWarranty.Name = "rbtnWarranty";
            this.rbtnWarranty.Size = new System.Drawing.Size(87, 21);
            this.rbtnWarranty.TabIndex = 0;
            this.rbtnWarranty.TabStop = true;
            this.rbtnWarranty.Text = "Warranty";
            this.rbtnWarranty.UseVisualStyleBackColor = true;
            this.rbtnWarranty.CheckedChanged += new System.EventHandler(this.rbtnWarranty_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 22);
            this.textBox1.TabIndex = 11;
            this.passTT.SetToolTip(this.textBox1, "Please enter the Client\'s E-Mail.");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 17);
            this.label19.TabIndex = 10;
            this.label19.Text = "Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 59);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 9;
            this.passTT.SetToolTip(this.txtEmail, "Please enter the Client\'s E-Mail.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-Mail";
            // 
            // gpxtech
            // 
            this.gpxtech.Controls.Add(this.label3);
            this.gpxtech.Controls.Add(this.txtPrim);
            this.gpxtech.Controls.Add(this.txbID);
            this.gpxtech.Controls.Add(this.btnPlaceorder);
            this.gpxtech.Controls.Add(this.label15);
            this.gpxtech.Controls.Add(this.label1);
            this.gpxtech.Controls.Add(this.txtMics);
            this.gpxtech.Controls.Add(this.txtCpu);
            this.gpxtech.Controls.Add(this.label9);
            this.gpxtech.Controls.Add(this.txtPsu);
            this.gpxtech.Controls.Add(this.txtGpu);
            this.gpxtech.Controls.Add(this.txtRam);
            this.gpxtech.Controls.Add(this.txtmobo);
            this.gpxtech.Controls.Add(this.Cpu);
            this.gpxtech.Controls.Add(this.label13);
            this.gpxtech.Controls.Add(this.label12);
            this.gpxtech.Controls.Add(this.label11);
            this.gpxtech.Controls.Add(this.label10);
            this.gpxtech.Location = new System.Drawing.Point(4, 196);
            this.gpxtech.Margin = new System.Windows.Forms.Padding(4);
            this.gpxtech.Name = "gpxtech";
            this.gpxtech.Padding = new System.Windows.Forms.Padding(4);
            this.gpxtech.Size = new System.Drawing.Size(389, 540);
            this.gpxtech.TabIndex = 4;
            this.gpxtech.TabStop = false;
            this.gpxtech.Text = "Custom build";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product ID/Barcode";
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(12, 278);
            this.txtPrim.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(355, 24);
            this.txtPrim.TabIndex = 15;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(12, 42);
            this.txbID.Margin = new System.Windows.Forms.Padding(4);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(360, 22);
            this.txbID.TabIndex = 20;
            this.txbID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            this.txbID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbID_PreviewKeyDown);
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlaceorder.Location = new System.Drawing.Point(139, 504);
            this.btnPlaceorder.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(100, 28);
            this.btnPlaceorder.TabIndex = 8;
            this.btnPlaceorder.Text = "Complete";
            this.btnPlaceorder.UseVisualStyleBackColor = true;
            this.btnPlaceorder.Click += new System.EventHandler(this.btnPlaceorder_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 258);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Primary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ram";
            // 
            // txtMics
            // 
            this.txtMics.Location = new System.Drawing.Point(12, 463);
            this.txtMics.Margin = new System.Windows.Forms.Padding(4);
            this.txtMics.Name = "txtMics";
            this.txtMics.Size = new System.Drawing.Size(355, 22);
            this.txtMics.TabIndex = 17;
            this.passTT.SetToolTip(this.txtMics, "Please enter the product id for Miscellaneous items like a computer case . If you" +
        " dont want this item the the custom build.");
            this.txtMics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMics_KeyPress);
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(8, 394);
            this.txtCpu.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(355, 24);
            this.txtCpu.TabIndex = 18;
            this.passTT.SetToolTip(this.txtCpu, "Please enter the product id for the Central prsessing unit . If you dont want thi" +
        "s item the the custom build.");
            this.txtCpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpu_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 443);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Miscellaneous ";
            // 
            // txtPsu
            // 
            this.txtPsu.Location = new System.Drawing.Point(7, 331);
            this.txtPsu.Margin = new System.Windows.Forms.Padding(4);
            this.txtPsu.Name = "txtPsu";
            this.txtPsu.Size = new System.Drawing.Size(355, 24);
            this.txtPsu.TabIndex = 17;
            this.passTT.SetToolTip(this.txtPsu, "Please enter the product id for the power Supply . If you dont want this item the" +
        " the custom build.");
            this.txtPsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPsu_KeyPress);
            // 
            // txtGpu
            // 
            this.txtGpu.Location = new System.Drawing.Point(8, 214);
            this.txtGpu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGpu.Name = "txtGpu";
            this.txtGpu.Size = new System.Drawing.Size(355, 24);
            this.txtGpu.TabIndex = 16;
            this.passTT.SetToolTip(this.txtGpu, "Please enter the product id for the Graphics card. If you dont want this item the" +
        " the custom build.\r\nEnter a zero (0).");
            this.txtGpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGpu_KeyPress);
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(12, 150);
            this.txtRam.Margin = new System.Windows.Forms.Padding(4);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(355, 24);
            this.txtRam.TabIndex = 15;
            this.passTT.SetToolTip(this.txtRam, "Please enter the product id for the Ram . If you dont want this item the the cust" +
        "om build.\r\nEnter a zero (0).");
            this.txtRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRam_KeyPress);
            // 
            // txtmobo
            // 
            this.txtmobo.Location = new System.Drawing.Point(12, 98);
            this.txtmobo.Margin = new System.Windows.Forms.Padding(4);
            this.txtmobo.Name = "txtmobo";
            this.txtmobo.Size = new System.Drawing.Size(355, 24);
            this.txtmobo.TabIndex = 14;
            this.passTT.SetToolTip(this.txtmobo, "Please enter the product id for the . If you dont want this item the the custom b" +
        "uild.\r\nEnter a zero (0).");
            this.txtmobo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobo_KeyPress);
            // 
            // Cpu
            // 
            this.Cpu.AutoSize = true;
            this.Cpu.Location = new System.Drawing.Point(8, 374);
            this.Cpu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(153, 17);
            this.Cpu.TabIndex = 13;
            this.Cpu.Text = "Central prosessing unit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 311);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Power Supply";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Graphics card";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ram";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Motherboard";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(573, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 26);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Location = new System.Drawing.Point(401, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(259, 175);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost of labour";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(37, 59);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(132, 22);
            this.txtCost.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 516F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbxLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(182, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 42);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gpbClient, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gpxtech, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(182, 67);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.96567F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.03433F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(677, 741);
            this.tableLayoutPanel2.TabIndex = 15;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 100;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Custombuild help";
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
            this.btnAdminShow.Location = new System.Drawing.Point(12, 354);
            this.btnAdminShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminShow.Name = "btnAdminShow";
            this.btnAdminShow.RecessDepth = 0;
            this.btnAdminShow.Size = new System.Drawing.Size(35, 34);
            this.btnAdminShow.TabIndex = 17;
            this.btnAdminShow.Text = ">>";
            this.passTT.SetToolTip(this.btnAdminShow, "Click to show admin panel");
            this.btnAdminShow.UseVisualStyleBackColor = false;
            this.btnAdminShow.Click += new System.EventHandler(this.btnAdminShow_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlAdmin.Controls.Add(this.btnAdminHide);
            this.pnlAdmin.Controls.Add(this.btnMPromo);
            this.pnlAdmin.Controls.Add(this.btnAdmLogout);
            this.pnlAdmin.Controls.Add(this.label4);
            this.pnlAdmin.Controls.Add(this.label7);
            this.pnlAdmin.Controls.Add(this.label8);
            this.pnlAdmin.Controls.Add(this.label5);
            this.pnlAdmin.Controls.Add(this.label14);
            this.pnlAdmin.Controls.Add(this.btnVLogs);
            this.pnlAdmin.Controls.Add(this.btnEoM);
            this.pnlAdmin.Controls.Add(this.btnREmp);
            this.pnlAdmin.Controls.Add(this.btnUEmp);
            this.pnlAdmin.Controls.Add(this.btnRUser);
            this.pnlAdmin.Controls.Add(this.label16);
            this.pnlAdmin.Controls.Add(this.label17);
            this.pnlAdmin.Controls.Add(this.label18);
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
            this.pnlAdmin.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Misc";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Chocolate;
            this.label14.Location = new System.Drawing.Point(-13, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "_____________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Chocolate;
            this.label16.Location = new System.Drawing.Point(-13, 234);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(240, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "_____________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Administrative";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(-3, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(240, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "_____________________________";
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
            // FrmTechnical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 847);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnAdminShow);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTechnical";
            this.Text = "FrmTechnical";
            this.Load += new System.EventHandler(this.FrmTechnical_Load);
            this.Shown += new System.EventHandler(this.FrmTechnical_Shown);
            this.gpbClient.ResumeLayout(false);
            this.gpbClient.PerformLayout();
            this.gpxtech.ResumeLayout(false);
            this.gpxtech.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLayout;
        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpxtech;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.Label Cpu;
        private System.Windows.Forms.ComboBox txtCpu;
        private System.Windows.Forms.ComboBox txtPsu;
        private System.Windows.Forms.ComboBox txtGpu;
        private System.Windows.Forms.ComboBox txtRam;
        private System.Windows.Forms.ComboBox txtmobo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txtPrim;
        private System.Windows.Forms.TextBox txtMics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip passTT;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Panel pnlAdmin;
        private GaryPerkin.UserControls.Buttons.RoundButton btnAdminHide;
        private System.Windows.Forms.Button btnMPromo;
        private System.Windows.Forms.Button btnAdmLogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnVLogs;
        private System.Windows.Forms.Button btnEoM;
        private System.Windows.Forms.Button btnREmp;
        private System.Windows.Forms.Button btnUEmp;
        private System.Windows.Forms.Button btnRUser;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnUUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMiscT;
        private System.Windows.Forms.Label lblMiscB;
        private System.Windows.Forms.Button btnAddEmp;
        private GaryPerkin.UserControls.Buttons.RoundButton btnAdminShow;
        private System.Windows.Forms.RadioButton rbtnWarranty;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnConfirmRep;
        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbxCollected;
        private System.Windows.Forms.CheckBox cbxCompleted;
        private System.Windows.Forms.Button button1;
    }
}