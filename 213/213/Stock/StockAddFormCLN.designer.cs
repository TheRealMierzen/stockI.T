namespace _213
{
    partial class StockAddFormCLN
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
            this.lblDescAddCLN = new System.Windows.Forms.Label();
            this.lblBrandAddCLN = new System.Windows.Forms.Label();
            this.lblPriceRetailAddCLN = new System.Windows.Forms.Label();
            this.btnConfirmAddCLN = new System.Windows.Forms.Button();
            this.btnCancelAddCLN = new System.Windows.Forms.Button();
            this.txbDescAddCLN = new System.Windows.Forms.TextBox();
            this.txbBrandAddCLN = new System.Windows.Forms.TextBox();
            this.txbPriceRetailAddCLN = new System.Windows.Forms.TextBox();
            this.txtManfacturerPriceCLN = new System.Windows.Forms.TextBox();
            this.lblManufacturerPriceCLN = new System.Windows.Forms.Label();
            this.lblTypeAddCLN = new System.Windows.Forms.Label();
            this.cmbTypeAddCLN = new System.Windows.Forms.ComboBox();
            this.lblWarrantyAddCLN = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txbItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbWarrantyADD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDescAddCLN
            // 
            this.lblDescAddCLN.AutoSize = true;
            this.lblDescAddCLN.Location = new System.Drawing.Point(16, 68);
            this.lblDescAddCLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescAddCLN.Name = "lblDescAddCLN";
            this.lblDescAddCLN.Size = new System.Drawing.Size(113, 17);
            this.lblDescAddCLN.TabIndex = 0;
            this.lblDescAddCLN.Text = "Item Description:";
            // 
            // lblBrandAddCLN
            // 
            this.lblBrandAddCLN.AutoSize = true;
            this.lblBrandAddCLN.Location = new System.Drawing.Point(17, 128);
            this.lblBrandAddCLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrandAddCLN.Name = "lblBrandAddCLN";
            this.lblBrandAddCLN.Size = new System.Drawing.Size(126, 17);
            this.lblBrandAddCLN.TabIndex = 1;
            this.lblBrandAddCLN.Text = "Item Manufacturer:";
            // 
            // lblPriceRetailAddCLN
            // 
            this.lblPriceRetailAddCLN.AutoSize = true;
            this.lblPriceRetailAddCLN.Location = new System.Drawing.Point(16, 98);
            this.lblPriceRetailAddCLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceRetailAddCLN.Name = "lblPriceRetailAddCLN";
            this.lblPriceRetailAddCLN.Size = new System.Drawing.Size(114, 17);
            this.lblPriceRetailAddCLN.TabIndex = 2;
            this.lblPriceRetailAddCLN.Text = "Item Retail Price:";
            this.lblPriceRetailAddCLN.Click += new System.EventHandler(this.lblPriceRetailAddCLN_Click);
            // 
            // btnConfirmAddCLN
            // 
            this.btnConfirmAddCLN.Enabled = false;
            this.btnConfirmAddCLN.Location = new System.Drawing.Point(13, 266);
            this.btnConfirmAddCLN.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmAddCLN.Name = "btnConfirmAddCLN";
            this.btnConfirmAddCLN.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmAddCLN.TabIndex = 8;
            this.btnConfirmAddCLN.Text = "OK";
            this.btnConfirmAddCLN.UseVisualStyleBackColor = true;
            this.btnConfirmAddCLN.Click += new System.EventHandler(this.btnConfirmAddCLN_Click);
            // 
            // btnCancelAddCLN
            // 
            this.btnCancelAddCLN.Location = new System.Drawing.Point(121, 266);
            this.btnCancelAddCLN.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAddCLN.Name = "btnCancelAddCLN";
            this.btnCancelAddCLN.Size = new System.Drawing.Size(100, 28);
            this.btnCancelAddCLN.TabIndex = 9;
            this.btnCancelAddCLN.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnCancelAddCLN, "Click if you want to clear \r\nthe information you entered\r\n");
            this.btnCancelAddCLN.UseVisualStyleBackColor = true;
            this.btnCancelAddCLN.Click += new System.EventHandler(this.btnCancelAddCLN_Click);
            // 
            // txbDescAddCLN
            // 
            this.txbDescAddCLN.Location = new System.Drawing.Point(196, 64);
            this.txbDescAddCLN.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescAddCLN.Name = "txbDescAddCLN";
            this.txbDescAddCLN.ShortcutsEnabled = false;
            this.txbDescAddCLN.Size = new System.Drawing.Size(132, 22);
            this.txbDescAddCLN.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txbDescAddCLN, "Enter the item name eg: GTX 1080");
            this.txbDescAddCLN.TextChanged += new System.EventHandler(this.txbDescAddCLN_TextChanged);
            // 
            // txbBrandAddCLN
            // 
            this.txbBrandAddCLN.Location = new System.Drawing.Point(197, 124);
            this.txbBrandAddCLN.Margin = new System.Windows.Forms.Padding(4);
            this.txbBrandAddCLN.Name = "txbBrandAddCLN";
            this.txbBrandAddCLN.ShortcutsEnabled = false;
            this.txbBrandAddCLN.Size = new System.Drawing.Size(132, 22);
            this.txbBrandAddCLN.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txbBrandAddCLN, "Enter the manufacturer of the item");
            this.txbBrandAddCLN.TextChanged += new System.EventHandler(this.txbBrandAddCLN_TextChanged);
            // 
            // txbPriceRetailAddCLN
            // 
            this.txbPriceRetailAddCLN.Location = new System.Drawing.Point(196, 94);
            this.txbPriceRetailAddCLN.Margin = new System.Windows.Forms.Padding(4);
            this.txbPriceRetailAddCLN.MaxLength = 10;
            this.txbPriceRetailAddCLN.Name = "txbPriceRetailAddCLN";
            this.txbPriceRetailAddCLN.ShortcutsEnabled = false;
            this.txbPriceRetailAddCLN.Size = new System.Drawing.Size(132, 22);
            this.txbPriceRetailAddCLN.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txbPriceRetailAddCLN, "Enter the retail price of the item (Only 0..9 allowed)");
            this.txbPriceRetailAddCLN.TextChanged += new System.EventHandler(this.txbPriceRetailAddCLN_TextChanged);
            this.txbPriceRetailAddCLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPriceRetailAddCLN_KeyPress);
            // 
            // txtManfacturerPriceCLN
            // 
            this.txtManfacturerPriceCLN.Location = new System.Drawing.Point(196, 160);
            this.txtManfacturerPriceCLN.Margin = new System.Windows.Forms.Padding(4);
            this.txtManfacturerPriceCLN.MaxLength = 10;
            this.txtManfacturerPriceCLN.Name = "txtManfacturerPriceCLN";
            this.txtManfacturerPriceCLN.ShortcutsEnabled = false;
            this.txtManfacturerPriceCLN.Size = new System.Drawing.Size(132, 22);
            this.txtManfacturerPriceCLN.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtManfacturerPriceCLN, "Enter the manufacturer price of the item (Only 0..9 allowed)");
            this.txtManfacturerPriceCLN.TextChanged += new System.EventHandler(this.txtManfacturerPriceCLN_TextChanged);
            this.txtManfacturerPriceCLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManfacturerPriceCLN_KeyPress);
            // 
            // lblManufacturerPriceCLN
            // 
            this.lblManufacturerPriceCLN.AutoSize = true;
            this.lblManufacturerPriceCLN.Location = new System.Drawing.Point(16, 164);
            this.lblManufacturerPriceCLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturerPriceCLN.Name = "lblManufacturerPriceCLN";
            this.lblManufacturerPriceCLN.Size = new System.Drawing.Size(162, 17);
            this.lblManufacturerPriceCLN.TabIndex = 10;
            this.lblManufacturerPriceCLN.Text = "Item Manufacturer Price:";
            // 
            // lblTypeAddCLN
            // 
            this.lblTypeAddCLN.AutoSize = true;
            this.lblTypeAddCLN.Location = new System.Drawing.Point(17, 228);
            this.lblTypeAddCLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeAddCLN.Name = "lblTypeAddCLN";
            this.lblTypeAddCLN.Size = new System.Drawing.Size(74, 17);
            this.lblTypeAddCLN.TabIndex = 12;
            this.lblTypeAddCLN.Text = "Item Type:";
            this.lblTypeAddCLN.UseMnemonic = false;
            // 
            // cmbTypeAddCLN
            // 
            this.cmbTypeAddCLN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAddCLN.FormattingEnabled = true;
            this.cmbTypeAddCLN.Items.AddRange(new object[] {
            "RAM",
            "CPU",
            "PSU",
            "GPU",
            "HDD",
            "Mobo",
            "Peripherals",
            "Misc"});
            this.cmbTypeAddCLN.Location = new System.Drawing.Point(196, 224);
            this.cmbTypeAddCLN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTypeAddCLN.Name = "cmbTypeAddCLN";
            this.cmbTypeAddCLN.Size = new System.Drawing.Size(132, 24);
            this.cmbTypeAddCLN.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cmbTypeAddCLN, "Select the item type of the item");
            this.cmbTypeAddCLN.TextChanged += new System.EventHandler(this.cmbTypeAddCLN_TextChanged);
            // 
            // lblWarrantyAddCLN
            // 
            this.lblWarrantyAddCLN.AutoSize = true;
            this.lblWarrantyAddCLN.Location = new System.Drawing.Point(17, 196);
            this.lblWarrantyAddCLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarrantyAddCLN.Name = "lblWarrantyAddCLN";
            this.lblWarrantyAddCLN.Size = new System.Drawing.Size(100, 17);
            this.lblWarrantyAddCLN.TabIndex = 14;
            this.lblWarrantyAddCLN.Text = "Item Warranty:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(229, 266);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.toolTip1.SetToolTip(this.btnBack, "Click to close this window");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbItemID
            // 
            this.txbItemID.Location = new System.Drawing.Point(197, 31);
            this.txbItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txbItemID.MaxLength = 25;
            this.txbItemID.Name = "txbItemID";
            this.txbItemID.ShortcutsEnabled = false;
            this.txbItemID.Size = new System.Drawing.Size(132, 22);
            this.txbItemID.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbItemID, "Scan in ID with barcode scanner");
            this.txbItemID.TextChanged += new System.EventHandler(this.txbItemID_TextChanged);
            this.txbItemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbItemID_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Item ID:";
            // 
            // cmbWarrantyADD
            // 
            this.cmbWarrantyADD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarrantyADD.FormattingEnabled = true;
            this.cmbWarrantyADD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbWarrantyADD.Location = new System.Drawing.Point(197, 192);
            this.cmbWarrantyADD.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWarrantyADD.Name = "cmbWarrantyADD";
            this.cmbWarrantyADD.Size = new System.Drawing.Size(132, 24);
            this.cmbWarrantyADD.TabIndex = 6;
            // 
            // StockAddFormCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 340);
            this.Controls.Add(this.cmbWarrantyADD);
            this.Controls.Add(this.txbItemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblWarrantyAddCLN);
            this.Controls.Add(this.cmbTypeAddCLN);
            this.Controls.Add(this.lblTypeAddCLN);
            this.Controls.Add(this.txtManfacturerPriceCLN);
            this.Controls.Add(this.lblManufacturerPriceCLN);
            this.Controls.Add(this.txbPriceRetailAddCLN);
            this.Controls.Add(this.txbBrandAddCLN);
            this.Controls.Add(this.txbDescAddCLN);
            this.Controls.Add(this.btnCancelAddCLN);
            this.Controls.Add(this.btnConfirmAddCLN);
            this.Controls.Add(this.lblPriceRetailAddCLN);
            this.Controls.Add(this.lblBrandAddCLN);
            this.Controls.Add(this.lblDescAddCLN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockAddFormCLN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Item Entry";
            this.toolTip1.SetToolTip(this, "Click if you are ready to add the item");
            this.Load += new System.EventHandler(this.StockAddFormCLN_Load);
            this.Shown += new System.EventHandler(this.StockAddFormCLN_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescAddCLN;
        private System.Windows.Forms.Label lblBrandAddCLN;
        private System.Windows.Forms.Label lblPriceRetailAddCLN;
        private System.Windows.Forms.Button btnConfirmAddCLN;
        private System.Windows.Forms.Button btnCancelAddCLN;
        private System.Windows.Forms.TextBox txbDescAddCLN;
        private System.Windows.Forms.TextBox txbBrandAddCLN;
        private System.Windows.Forms.TextBox txbPriceRetailAddCLN;
        private System.Windows.Forms.TextBox txtManfacturerPriceCLN;
        private System.Windows.Forms.Label lblManufacturerPriceCLN;
        private System.Windows.Forms.Label lblTypeAddCLN;
        private System.Windows.Forms.ComboBox cmbTypeAddCLN;
        private System.Windows.Forms.Label lblWarrantyAddCLN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbWarrantyADD;
    }
}