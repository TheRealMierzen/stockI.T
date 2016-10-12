namespace _213
{
    partial class frmForgotPass
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
            this.txtFPAdminU = new System.Windows.Forms.TextBox();
            this.txtFPAdminP = new System.Windows.Forms.TextBox();
            this.txtBlocked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFPRecover = new System.Windows.Forms.Button();
            this.btnFPCancel = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtFPAdminU
            // 
            this.txtFPAdminU.Location = new System.Drawing.Point(89, 104);
            this.txtFPAdminU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFPAdminU.MaxLength = 50;
            this.txtFPAdminU.Name = "txtFPAdminU";
            this.txtFPAdminU.Size = new System.Drawing.Size(91, 20);
            this.txtFPAdminU.TabIndex = 2;
            this.passTT.SetToolTip(this.txtFPAdminU, "Enter this branch\'s adminstrator\'s username");
            this.txtFPAdminU.TextChanged += new System.EventHandler(this.txtFPAdminU_TextChanged);
            // 
            // txtFPAdminP
            // 
            this.txtFPAdminP.Location = new System.Drawing.Point(89, 130);
            this.txtFPAdminP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFPAdminP.MaxLength = 8;
            this.txtFPAdminP.Name = "txtFPAdminP";
            this.txtFPAdminP.PasswordChar = '*';
            this.txtFPAdminP.Size = new System.Drawing.Size(91, 20);
            this.txtFPAdminP.TabIndex = 3;
            this.passTT.SetToolTip(this.txtFPAdminP, "Enter this branch\'s administrator\'s password");
            this.txtFPAdminP.TextChanged += new System.EventHandler(this.txtFPAdminP_TextChanged);
            // 
            // txtBlocked
            // 
            this.txtBlocked.Location = new System.Drawing.Point(89, 38);
            this.txtBlocked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBlocked.MaxLength = 50;
            this.txtBlocked.Name = "txtBlocked";
            this.txtBlocked.Size = new System.Drawing.Size(91, 20);
            this.txtBlocked.TabIndex = 1;
            this.passTT.SetToolTip(this.txtBlocked, "Enter the username for which you wish to generate a new password.");
            this.txtBlocked.TextChanged += new System.EventHandler(this.txtBlocked_TextChanged);
            this.txtBlocked.Leave += new System.EventHandler(this.txtBlocked_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details of blocked account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administrative account\'s details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password:";
            // 
            // btnFPRecover
            // 
            this.btnFPRecover.Location = new System.Drawing.Point(21, 167);
            this.btnFPRecover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFPRecover.Name = "btnFPRecover";
            this.btnFPRecover.Size = new System.Drawing.Size(64, 29);
            this.btnFPRecover.TabIndex = 4;
            this.btnFPRecover.Text = "Recover";
            this.passTT.SetToolTip(this.btnFPRecover, "Click to generate new password for the blocked account.\r\n\r\nThe new password will " +
        "be sent to their email address.");
            this.btnFPRecover.UseVisualStyleBackColor = true;
            this.btnFPRecover.Click += new System.EventHandler(this.btnFPRecover_Click);
            // 
            // btnFPCancel
            // 
            this.btnFPCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFPCancel.Location = new System.Drawing.Point(115, 167);
            this.btnFPCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFPCancel.Name = "btnFPCancel";
            this.btnFPCancel.Size = new System.Drawing.Size(64, 29);
            this.btnFPCancel.TabIndex = 5;
            this.btnFPCancel.Text = "Cancel";
            this.passTT.SetToolTip(this.btnFPCancel, "Click this button to return to the login form.");
            this.btnFPCancel.UseVisualStyleBackColor = true;
            this.btnFPCancel.Click += new System.EventHandler(this.btnFPCancel_Click);
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 750;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Password Help";
            // 
            // frmForgotPass
            // 
            this.AcceptButton = this.btnFPRecover;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFPCancel;
            this.ClientSize = new System.Drawing.Size(203, 206);
            this.Controls.Add(this.btnFPCancel);
            this.Controls.Add(this.btnFPRecover);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlocked);
            this.Controls.Add(this.txtFPAdminP);
            this.Controls.Add(this.txtFPAdminU);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmForgotPass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password recovery";
            this.Load += new System.EventHandler(this.frmForgotPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFPAdminU;
        private System.Windows.Forms.TextBox txtFPAdminP;
        private System.Windows.Forms.TextBox txtBlocked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFPRecover;
        private System.Windows.Forms.Button btnFPCancel;
        private System.Windows.Forms.ToolTip passTT;
    }
}