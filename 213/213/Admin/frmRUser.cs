﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _213
{
    public partial class frmRUser : Form
    {
        public frmRUser()
        {
            InitializeComponent();
        }

        public frmRUser(string usert)
        {
            InitializeComponent();
            user = usert;
        }

        public frmRUser(string usert, string rrUser)
        {
            InitializeComponent();
            user = usert;
            txtRUser.Text = rrUser;
            
        }

        private string user;
        private int count;

        private void frmRUser_Load(object sender, EventArgs e)
        {
            txtAuthUser.Text = user;
            txtAuthUser.Enabled = false;

            txtRUser.Focus();
        }

        private void btnRAcc_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtRUser.Text == txtCRUser.Text && txtAuthPass.Text != "")
                {

                    loginForm lf = new loginForm();
                    gebruik other = new gebruik();

                    if (lf.validateUser(txtAuthUser.Text, txtAuthPass.Text) && other.checkAuthor(txtAuthUser.Text))
                    {
                        if (!lf.checkUser(txtCRUser.Text))
                        {
                            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                            {
                                string cmdstring = "DELETE FROM Users WHERE username = @user";
                                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                                {

                                    con.Open();
                                    count = 0;

                                    comm.Parameters.AddWithValue("@user", txtCRUser.Text);
                                    comm.ExecuteNonQuery();

                                    gebruik.addAction(user);
                                    DateTime local = DateTime.Now;
                                    gebruik.log(local, user, "removed user");

                                    DialogResult choice;
                                    choice = MessageBox.Show("The account has been removed.\r\nWould you like to remove another user?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                    if (choice == DialogResult.Yes)
                                    {

                                        txtAuthPass.Clear();
                                        txtCRUser.Clear();
                                        txtRUser.Clear();

                                    }
                                    else
                                        this.Close();

                                }
                            }
                        }
                        else
                            MessageBox.Show("The user you want to remove does not exist. Please verify the entered information and try again.");

                    }
                    else
                        MessageBox.Show("The authorization account's password is incorrect. Please try again.");
                }
                else
                    MessageBox.Show("Please verify the account you wanted to delete's information and try again.");
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnRAcc.PerformClick();
                    }
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception)
            { }

        }

        private void txtRUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRUser.Text == txtCRUser.Text && txtAuthPass.Text != "" && txtRUser.Text != "")
                {
                    txtCRUser.ForeColor = DefaultForeColor;
                    btnRAcc.Enabled = true;
                }
                else if (txtRUser.Text != txtCRUser.Text)
                {
                    txtCRUser.ForeColor = Color.Red;
                    btnRAcc.Enabled = false;
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void txtCRUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRUser.Text == txtCRUser.Text && txtAuthPass.Text != "" && txtRUser.Text != "")
                {
                    txtCRUser.ForeColor = DefaultForeColor;
                    btnRAcc.Enabled = true;
                }
                else if (txtRUser.Text != txtCRUser.Text)
                {
                    txtCRUser.ForeColor = Color.Red;
                    btnRAcc.Enabled = false;
                }
                else if (txtRUser.Text == txtCRUser.Text)
                    txtCRUser.ForeColor = DefaultForeColor;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void txtAuthPass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAuthPass.Text != "" && txtRUser.Text == txtCRUser.Text && txtRUser.Text != "")
                    btnRAcc.Enabled = true;
                else
                    btnRAcc.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void btnRUCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
