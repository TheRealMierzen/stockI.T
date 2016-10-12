namespace _213
{
    partial class frmEOM
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
            this.dgEOM = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblCEOM = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgEOM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEOM
            // 
            this.dgEOM.AllowUserToAddRows = false;
            this.dgEOM.AllowUserToDeleteRows = false;
            this.dgEOM.AllowUserToOrderColumns = true;
            this.dgEOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname});
            this.dgEOM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEOM.Location = new System.Drawing.Point(9, 78);
            this.dgEOM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgEOM.Name = "dgEOM";
            this.dgEOM.ReadOnly = true;
            this.dgEOM.RowTemplate.Height = 24;
            this.dgEOM.Size = new System.Drawing.Size(283, 204);
            this.dgEOM.TabIndex = 0;
            this.passTT.SetToolTip(this.dgEOM, "This is a list of all employees, ordered \r\nby their performance on stockI.T from " +
        "\r\nhighest to lowest");
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 115;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 115;
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Location = new System.Drawing.Point(9, 57);
            this.lblFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(155, 15);
            this.lblFor.TabIndex = 1;
            this.lblFor.Text = "Employee performance for:";
            // 
            // lblCEOM
            // 
            this.lblCEOM.AutoSize = true;
            this.lblCEOM.Location = new System.Drawing.Point(10, 19);
            this.lblCEOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEOM.Name = "lblCEOM";
            this.lblCEOM.Size = new System.Drawing.Size(78, 15);
            this.lblCEOM.TabIndex = 2;
            this.lblCEOM.Text = "Current EOM";
            this.passTT.SetToolTip(this.lblCEOM, "The employee with the highest performance on stockI.T");
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(100, 292);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.passTT.SetToolTip(this.btnClose, "Click to close this window");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 750;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Need help?";
            // 
            // frmEOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 334);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCEOM);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.dgEOM);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEOM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee of the month";
            this.Load += new System.EventHandler(this.frmEOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEOM;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblCEOM;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.ToolTip passTT;
    }
}