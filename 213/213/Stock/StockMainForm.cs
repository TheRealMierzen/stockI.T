﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.Sql;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;

namespace _213
{
   
    public partial class StockMainFormCLN : Form
    {
        private string userNme;
        private string cur;
        private string missID = "";
        private int count;
        public StockMainFormCLN()
        {
            InitializeComponent();
        }
        public StockMainFormCLN(string user)
        {
            InitializeComponent();
            userNme = user;
        }

        private void cmbSelectStockAction_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private string details, details2;
        private void StockMainForm_Shown(object sender, EventArgs e)
        {
            try
            {

                //  this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                bgWDetails.RunWorkerAsync();
                

            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        StockMainForm_Shown(sender, e);
                    }
                    else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSelectStockAction_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Add Stock Selected and Confirmed
            if (cmbSelectStockAction.SelectedIndex == 0)
            {

                //Vra of user nuwe listing will maak of net stock by sit
                if (MessageBox.Show("Do you want to create a new listing?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StockAddFormCLN frmStockAddCLN = new StockAddFormCLN(userNme);
                    frmStockAddCLN.ShowDialog();
                }
                else
                {
                    StockAddFormUPD frmStockAddUPD = new StockAddFormUPD(userNme);
                    frmStockAddUPD.ShowDialog();
                }

            }
            if (cmbSelectStockAction.SelectedIndex == 1)
            {
                StockFindForm frmStockFind = new StockFindForm(userNme);
                frmStockFind.ShowDialog();
            }
            if (cmbSelectStockAction.SelectedIndex == 2)
            { 
                StockAddFormUPD frmStockAddUPD = new StockAddFormUPD(userNme);
                frmStockAddUPD.ShowDialog();
            }
            if (cmbSelectStockAction.SelectedIndex == 3)
            {
                StockTransferSendForm frmSendStock = new StockTransferSendForm(userNme);                
                frmSendStock.ShowDialog();
            }
            if (cmbSelectStockAction.SelectedIndex == 4)
            {
                StockRemoveForm stf = new StockRemoveForm(userNme);
                stf.ShowDialog();
            }
        }

        private void StockMainForm_Load(object sender, EventArgs e)
        {
          
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            btnAdminShow.Location = new Point(13, (this.Height) / 2 - 20);
            btnAdminHide.Location = new Point(133, (this.Height) / 2 - 20);

            btnAddUser.Size = new Size(62, 62);
            btnUUser.Size = new Size(62, 62);
            btnRUser.Size = new Size(62, 62);

            btnAddEmp.Size = new Size(62, 62);
            btnUEmp.Size = new Size(62, 62);
            btnREmp.Size = new Size(62, 62);

            btnEoM.Size = new Size(62, 62);
            btnVLogs.Size = new Size(62, 62);
            btnMPromo.Size = new Size(62, 62);

            btnAdmLogout.Size = new Size(62, 62);
            btnExit.Size = new Size(62, 62);

            if (Properties.Settings.Default.isAdmin)
            {

                pnlAdmin.Visible = true;
                btnAdminShow.Visible = true;

            }
            else
            {

                pnlAdmin.Visible = false;
                btnAdminShow.Visible = false;

            }

        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            bgWDetails.CancelAsync();
            this.Close();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCompleteStockTake_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                count = 0;
                SqlCommand getMiss = new SqlCommand("SELECT item_id, item_name FROM Stock WHERE checked = @check AND branch = @branch", stockConnection);
                getMiss.Parameters.AddWithValue("@check", 0);
                getMiss.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                if (getMiss.ExecuteScalar() == null)
                {

                    txbStockTake.AppendText("All Items are Checked");
                }
                else
                {
                    txbStockTake.AppendText("\r\nThese Items were not Checked:");
                    SqlDataReader reader = getMiss.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txbStockTake.AppendText("\r\n" + reader.GetString(1) + "\t" + reader.GetString(0));
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }
                if (missID == "")
                {
                    txbStockTake.AppendText("\r\nNo items missing");
                }
                else
                {
                    txbStockTake.AppendText("\r\nThese item ID's are not recognized by the system: " + missID);
                }
                txbStockTake.AppendText("\r\n=======================================");
                gebruik.addAction(userNme);
                stockConnection.Close();
                gebruik.addAction(userNme);
                //  gebruik.log(DateTime.Now, userNme, "Completed stock take");
            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        btnCompleteStockTake.PerformClick();
                    }
                else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkOrders()
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                count = 0;
                SqlCommand checkOrders = new SqlCommand("SELECT order_id, order_items FROM Orders WHERE branch = @branch AND eta = @eta", stockConnection);
                checkOrders.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                checkOrders.Parameters.AddWithValue("@eta", DateTime.Today);
                if (checkOrders.ExecuteScalar() != null)
                {
                    SqlDataReader reader = checkOrders.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (MessageBox.Show("Order ID: " + reader.GetString(0) + " Was sent to this branch with items: " + reader.GetString(1), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SqlConnection stockConnection2 = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                                stockConnection2.Open();
                                SqlCommand updateOrder = new SqlCommand("UPDATE Orders SET received = @rec, received_date = @date WHERE order_id = @id",stockConnection2);
                                updateOrder.Parameters.AddWithValue("@rec", 1);
                                updateOrder.Parameters.AddWithValue("date", DateTime.Today);
                                updateOrder.Parameters.AddWithValue("@id", reader.GetString(0));
                                updateOrder.ExecuteNonQuery();
                                stockConnection2.Close();
                                StockAddFormCLN frmAddCLN = new StockAddFormCLN(userNme);
                                frmAddCLN.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("The estimated arrival date will be delayed with one day.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SqlCommand updateETA = new SqlCommand("UPDATE Orders SET eta = @eta WHERE order_id = @id", stockConnection);
                                updateETA.Parameters.AddWithValue("@eta", DateTime.Today.AddDays(1));
                                updateETA.Parameters.AddWithValue("@id", reader.GetString(0));
                                updateETA.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }
            }


            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        checkOrders();
                    }
                else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkTransfers()
        {
            try
            {


                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                count = 0;
                SqlCommand checkTransfers = new SqlCommand("SELECT transfer_id, item_ids, from_branch FROM Transfers WHERE to_branch = @branch AND eta = @eta", stockConnection);

                checkTransfers.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                checkTransfers.Parameters.AddWithValue("@eta", DateTime.Today);

                if (checkTransfers.ExecuteScalar() != null)
                {
                    SqlDataReader reader = checkTransfers.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (MessageBox.Show("Transfer ID: " + reader.GetString(0) + " Was sent to this branch from: " + reader.GetString(2), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                meh(reader.GetString(1), reader.GetString(0));
                                //StockTransferRecieve frmRecieve = new StockTransferRecieve(userNme, reader.GetString(1), reader.GetString(0));
                                //frmRecieve.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("The estimated arrival date will be delayed with one day.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SqlCommand updateETA = new SqlCommand("UPDATE Transfers SET eta = @eta WHERE transfer_id = @id",stockConnection);
                                updateETA.Parameters.AddWithValue("@eta", DateTime.Today.AddDays(1));
                                updateETA.Parameters.AddWithValue("@id", reader.GetString(0));
                                updateETA.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }
            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        checkTransfers();
                    }
                else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompare_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                count = 0;
                SqlCommand getID = new SqlCommand("SELECT item_ID, item_name FROM Stock WHERE item_id = @itemID AND branch = @branch AND status = @status", stockConnection);
                getID.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                getID.Parameters.AddWithValue("@itemID", txtStockTakeItemID.Text);
                getID.Parameters.AddWithValue("@status", "In Stock");
                if (getID.ExecuteScalar() != null)
                {

                    SqlDataReader reader = getID.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SqlConnection stockConnection2 = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                            txbStockTake.AppendText("\r\n" + reader.GetString(1) + "\t" + reader.GetString(0));
                            string id = reader.GetString(0);
                            stockConnection2.Open();
                            count = 0;
                            SqlCommand checkStock = new SqlCommand("UPDATE Stock SET checked = '1' WHERE item_id = @id", stockConnection2);
                            checkStock.Parameters.AddWithValue("@id", id);

                            checkStock.ExecuteNonQuery();
                            stockConnection2.Close();
                        }
                    }
                    else
                    {
                        txbStockTake.AppendText("\r\n");
                    }
                    reader.Close();

                }
                else
                {
                    missID = missID + txtStockTakeItemID.Text + ",";
                    txbStockTake.AppendText("\r\n" + txtStockTakeItemID.Text + ": Unknown ID");
                }
            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        btnCompare.PerformClick();
                    }
                    else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void meh(string id, string tI)
        {
            try
            {
                while (id != "")
                {
                    string gID;
                    int pos = id.IndexOf(',');
                    gID = id.Substring(0, pos);
                    id = id.Remove(0, pos + 1);
                    SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                    stockConnection.Open();
                    count = 0;
                    SqlCommand getDes = new SqlCommand("SELECT item_name, manufacturer, manufacturer_price, retail_price FROM Stock WHERE item_id = @id", stockConnection);
                    getDes.Parameters.AddWithValue("@id", gID);
                    SqlDataReader reader = getDes.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cur = gID;
                            update(cur);
                        }
                    }
                    reader.Close();
                    stockConnection.Close();
                    if (id == "")
                    {
                        MessageBox.Show("All items have been transfered successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gebruik.addAction(userNme);
                        gebruik.log(DateTime.Now, userNme, "Recieved stock");
                        del(tI);
                    }
                }
            }
            catch (SqlException s)
            {
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        meh(id, tI);
                    }
                    else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Error in database" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in valid info" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void del(string gID)
        {

            SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
            stockConnection.Open();
            count = 0;
            SqlCommand delete = new SqlCommand("DELETE FROM transfers WHERE transfer_id = @transfer", stockConnection);
            delete.Parameters.AddWithValue("@transfer", gID);
            delete.ExecuteNonQuery();
            stockConnection.Close();
        }

        private void update(string gID)
        {
            SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
            stockConnection.Open();
            count = 0;
            gebruik.addAction(userNme);
            SqlCommand updates = new SqlCommand("UPDATE Stock SET branch = @branch, status = @stock, last_updated = @last WHERE item_id = @id", stockConnection);
            updates.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            updates.Parameters.AddWithValue("@last", DateTime.Today);
            updates.Parameters.AddWithValue("@stock", "In Stock");
            updates.Parameters.AddWithValue("@id", gID);
            updates.ExecuteNonQuery();
            stockConnection.Close();
        }

        private void getDatails()
        {

            details2 += "\r\n=======================================";
            details2 += "\r\nList of Items Recorded:";
            details2 += "\r\n=======================================";
            SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
            stockConnection.Open();
            count = 0;
            SqlCommand getStockCountCLN = new SqlCommand("SELECT COUNT(item_id) FROM Stock", stockConnection);
            int TotalItems = 0;
            TotalItems = Convert.ToInt16(getStockCountCLN.ExecuteScalar());
            details += "\r\n Items Added Today:";

            SqlCommand getStock = new SqlCommand("SELECT item_id, item_name FROM Stock WHERE initial_add = @add AND branch = @branch AND Status = @status", stockConnection);
            getStock.Parameters.AddWithValue("@add", DateTime.Today);
            getStock.Parameters.AddWithValue("@status", "In Stock");

            getStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            if (getStock.ExecuteScalar() == null)
            {
                details += "\r\nNo Stock Added Today";
            }
            else
            {
                SqlDataReader reader = getStock.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        details += "\r\n" + reader.GetString(1) + "\t" + reader.GetString(0);
                    }
                }
                else
                {
                    details += "\r\n";
                }
                reader.Close();
            }

            details += "\r\n=======================================";
            details += "\r\n Items Sold Today:";

            SqlCommand getSale = new SqlCommand("SELECT item_id, item_name FROM Stock WHERE last_updated = @up AND status = @status AND branch = @branch", stockConnection);
            getSale.Parameters.AddWithValue("@up", DateTime.Today);
            getSale.Parameters.AddWithValue("@status", "Sold");
            getSale.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            if (getSale.ExecuteScalar() == null)
            {
                details += "\r\nNo Stock Sold Today";
            }
            else
            {
                SqlDataReader reader = getSale.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        details += "\r\n" + reader.GetString(1) + "\t" + reader.GetString(0);
                    }
                }
                else
                {
                    details += "\r\n";
                }
                reader.Close();
            }

            details += "\r\n=======================================";
            details += "\r\n Items Removed Today:";
            string date = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + " 00:00:00";
            SqlCommand getStockR = new SqlCommand("SELECT item_id, item_name FROM Stock WHERE last_updated = @upp AND status = @status AND branch = @branch", stockConnection);
            getStockR.Parameters.AddWithValue("@upp", date);



            getStockR.Parameters.AddWithValue("@status", "Removed");
            getStockR.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            if (getStockR.ExecuteScalar() == null)
            {
                details += "\r\nNo Stock Removed Today";
            }
            else
            {
                SqlDataReader reader = getStockR.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        details += "\r\n" + reader.GetString(1) + "\t" + reader.GetString(0);
                    }
                }
                else
                {
                    details += "\r\n";
                }
                reader.Close();
            }

            details += "\r\n=======================================";
            details += "\r\n Items Transfered Today (Sent):";

            SqlCommand getStockT = new SqlCommand("SELECT transfer_id, item_ids FROM Transfers WHERE send_date = @send AND from_branch = @branch", stockConnection);
            getStockT.Parameters.AddWithValue("@send", DateTime.Today);
            getStockT.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);

            if (getStockT.ExecuteScalar() == null)
            {
                details += "\r\nNo Stock Trasfered Today";
            }
            else
            {
                string ids = "";
                SqlDataReader reader = getStockT.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ids = reader.GetString(1);
                        do
                        {
                            SqlConnection stockConnection2 = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                            stockConnection2.Open();

                            int pos = ids.IndexOf(',');
                            string id = ids.Substring(0, pos);
                            ids = ids.Remove(0, pos + 1);
                            SqlCommand getDes = new SqlCommand("SELECT item_name from Stock WHERE item_id = @id", stockConnection2);
                            getDes.Parameters.AddWithValue("@id", id);
                            if (getDes.ExecuteScalar() != null)
                            {
                                string message = ("\r\n Transfer ID: " + reader.GetString(0) + "\t" + getDes.ExecuteScalar().ToString());
                                details += message;
                            }
                            else
                            {
                                ids = "";
                            }

                            stockConnection2.Close();
                        } while (ids != "");

                    }
                }
                else
                {
                    txtStockTakeItemID.AppendText("\r\n");
                }
                reader.Close();
            }
            details += "\r\n=======================================";
            stockConnection.Close();
            checkTransfers();
            checkOrders();

        }

        private void bgWDetails_DoWork(object sender, DoWorkEventArgs e)
        {
            getDatails();
        }

        private void btnAdminHide_Click(object sender, EventArgs e)
        {
            for (int pos = 0; pos > -233; pos--)
                pnlAdmin.Location = new Point(pos, 0);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser adU = new frmAddUser(userNme);
            this.TopMost = false;
            adU.ShowDialog();
        }

        private void btnUUser_Click(object sender, EventArgs e)
        {
            frmUpdateUser uUser = new frmUpdateUser(userNme);
            uUser.ShowDialog();
        }

        private void btnRUser_Click(object sender, EventArgs e)
        {
            frmRUser rUser = new frmRUser(userNme);
            rUser.ShowDialog();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            frmAddEmp aEmp = new frmAddEmp(userNme);
            aEmp.ShowDialog();
        }

        private void btnUEmp_Click(object sender, EventArgs e)
        {
            frmUEmp uEmp = new frmUEmp(userNme);
            uEmp.ShowDialog();
        }

        private void btnREmp_Click(object sender, EventArgs e)
        {
            frmREmp rEmp = new frmREmp(userNme);
            rEmp.ShowDialog();
        }

        private void btnEoM_Click(object sender, EventArgs e)
        {
            frmEOM f1 = new frmEOM();
            f1.ShowDialog();
        }

        private void btnMPromo_Click(object sender, EventArgs e)
        {
            frmAdminPromos f1 = new frmAdminPromos(userNme);
            f1.ShowDialog();
        }

        private void btnVLogs_Click(object sender, EventArgs e)
        {
            frmLogs fl = new frmLogs(AppDomain.CurrentDomain.BaseDirectory + @"\Activity log.txt");
            fl.ShowDialog();
        }

        private void btnAdminShow_Click(object sender, EventArgs e)
        {
            for (int pos = -233; pos < 0; pos++)
                pnlAdmin.Location = new Point(pos, 0);

        }

        private void btnAdmLogout_Click(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;

            gebruik.log(local, userNme, "logout");
            loginForm login = new loginForm();

            login.Show();
            this.Close();
            login.TopMost = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;

            gebruik.log(local, userNme, "logout");
            gebruik.log(local, userNme, "closed application");

            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdminShow_Click_1(object sender, EventArgs e)
        {
            for (int pos = -233; pos < 0; pos++)
                pnlAdmin.Location = new Point(pos, 0);
        }

        private void bgWDetails_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txbStockTakeReport.AppendText(details);
            txbStockTake.AppendText(details2);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                frmManual fm = new frmManual();
                fm.ShowDialog();
                return true;    // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
