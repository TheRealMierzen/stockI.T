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
    public partial class frmAdminPromos : Form
    {
        public frmAdminPromos()
        {
            InitializeComponent();
        }

        public frmAdminPromos(string usert)
        {
            InitializeComponent();
            user = usert;
        }

        private string user;
        private int max;
        private int count;

        private void frmAdminPromos_Load(object sender, EventArgs e)
        {
            fillItems();
            fillIds();
            dtPromoStart.MinDate = DateTime.Now;

            gebruik other = new gebruik();

            bgWID.RunWorkerAsync();

            txtPromoId.Enabled = false;
            cbAction.SelectedItem = "New promotion";

            cbItem.Focus();
            

        }

        private void fillItems()
        {
            try
            {
                using (SqlConnection conItem = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {


                    string selection = "SELECT DISTINCT item_name FROM Stock WHERE item_name NOT IN (SELECT item_name FROM Promotions WHERE branch = @branch) AND branch = @thisbranch";
                    using (SqlCommand commItem = new SqlCommand(selection, conItem))
                    {
                        conItem.Open();

                        count = 0;

                        commItem.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        commItem.Parameters.AddWithValue("@thisbranch", Properties.Settings.Default.Branch);

                        using (var reader = commItem.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                string item = reader.GetString(0);
                                cbItem.Items.Add(item);

                            }
                            reader.Close();
                        }

                        conItem.Close();

                    }
                }
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
                        fillItems();
                    }
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception)
            { }

        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbItem.SelectedItem != null)
                {
                    using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                    {
                        con.Open();
                        count = 0;

                        string cmdstring = "SELECT COUNT(*) FROM Stock WHERE item_name = @item AND branch = @branch";

                        using (SqlCommand comm = new SqlCommand(cmdstring, con))
                        {
                            comm.Parameters.AddWithValue("@item", cbItem.SelectedItem.ToString());
                            comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                            int recs = (int)comm.ExecuteScalar();
                            con.Close();

                            lblNMax.Text = "Max: " + recs.ToString();
                            lblMax.Text = "Max: " + recs.ToString();
                            max = recs;

                        }

                        cmdstring = "SELECT retail_price FROM Stock WHERE item_name = @item";
                        con.Open();
                        count = 0;

                        using (SqlCommand comm = new SqlCommand(cmdstring, con))
                        {

                            comm.Parameters.AddWithValue("@item", cbItem.SelectedItem.ToString());

                            using (var reader = comm.ExecuteReader())
                            {
                                while (reader.Read())
                                {


                                    txtOriginalPrice.Text = reader.GetString(0);


                                }
                                reader.Close();
                            }
                            con.Close();

                            txtOriginalPrice.Enabled = false;

                        }
                    }
                }

                if (txtAmount.Text != "" && txtDiscount.Text != "" && cbItem.SelectedItem != null && Convert.ToInt16(txtAmount.Text) <= max && Convert.ToInt16(txtAmount.Text) > 0 && Convert.ToInt16(txtDisPrice.Text) < Convert.ToInt16(txtOriginalPrice.Text) && Convert.ToInt16(txtOriginalPrice.Text) > 0)
                    btnAddPromo.Enabled = true;
                else
                    btnAddPromo.Enabled = false;
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
                        cbItem_SelectedIndexChanged(sender, e);
                    }
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception)
            { }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtAmount.Text != "")
                {
                    if (Convert.ToInt16(txtAmount.Text) > max)
                    {

                        txtAmount.ForeColor = Color.Red;
                        btnAddPromo.Enabled = false;

                    }
                    else if (Convert.ToInt16(txtAmount.Text) < 0)
                    {

                        txtAmount.ForeColor = Color.Red;
                        btnAddPromo.Enabled = false;

                    }
                    else
                        txtAmount.ForeColor = DefaultForeColor;

                    if (txtAmount.Text != "" && txtDiscount.Text != "" && cbItem.SelectedItem != null && Convert.ToInt16(txtAmount.Text) <= max && Convert.ToInt16(txtAmount.Text) > 0 && Convert.ToInt16(txtDisPrice.Text) < Convert.ToInt16(txtOriginalPrice.Text) && Convert.ToInt16(txtOriginalPrice.Text) > 0)
                        btnAddPromo.Enabled = true;
                    else
                        btnAddPromo.Enabled = false;
                }
                else
                {
                    btnAddPromo.Enabled = false;

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void txtDisPrice_TextChanged(object sender, EventArgs e)
        {

            if (txtDisPrice.Text == "")
                txtDiscount.Text = "0%";
            try
            {
                if (txtOriginalPrice.Text != "" && txtDisPrice.Text != "")
                {
                    if (txtDisPrice.Text != "")
                    {
                        if (Convert.ToInt16(txtOriginalPrice.Text) <= Convert.ToInt16(txtDisPrice.Text))
                        {

                            txtDisPrice.ForeColor = Color.Red;

                        }
                        else if (Convert.ToInt16(txtDisPrice.Text) < 0)
                        {

                            txtDisPrice.ForeColor = Color.Red;

                        }

                        else if(Convert.ToInt16(txtDisPrice.Text) < Convert.ToInt16(txtOriginalPrice.Text))
                        {
                            txtDisPrice.ForeColor = DefaultForeColor;
                            double discount = (Convert.ToDouble(txtOriginalPrice.Text) - Convert.ToDouble(txtDisPrice.Text));
                            discount = discount / Convert.ToDouble(txtOriginalPrice.Text);
                            txtDiscount.Text = (Math.Round(discount * 100.00, 2)).ToString() + "%";

                        }
                        else if (Convert.ToInt16(txtDisPrice.Text) > Convert.ToInt16(txtOriginalPrice.Text))
                        {
                            txtDisPrice.ForeColor = DefaultForeColor;
                            double discount = (Convert.ToDouble(txtOriginalPrice.Text) - Convert.ToDouble(txtDisPrice.Text));
                            discount = discount / Convert.ToDouble(txtOriginalPrice.Text);
                            txtDiscount.Text = (Math.Round(discount * 100.00, 2)).ToString() + "%";

                        }

                        if (txtAmount.Text != "" && txtDiscount.Text != "" && cbItem.SelectedItem != null && Convert.ToInt16(txtAmount.Text) <= max && Convert.ToInt16(txtAmount.Text) > 0 && Convert.ToInt16(txtDisPrice.Text) < Convert.ToInt16(txtOriginalPrice.Text) && Convert.ToInt16(txtOriginalPrice.Text) > 0)
                            btnAddPromo.Enabled = true;
                        else
                            btnAddPromo.Enabled = false;

                        if (Convert.ToInt16(txtDisPrice.Text) < 0)
                        {
                            txtDisPrice.ForeColor = Color.Red;
                            btnAddPromo.Enabled = false;
                        }
                    }
                    else
                    {
                        btnAddPromo.Enabled = false;
                        txtDiscount.Text = "0%";
                    }

                }
                else
                {
                    btnAddPromo.Enabled = false;

                }
            }
            catch (FormatException)
            {



            }
            catch (OverflowException)
            {



            }

        }

        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    con.Open();

                    count = 0;

                    string cmdstring = "INSERT INTO Promotions (branch, promo_id, item_name, item_originalprice, item_promoprice, discount, start_date, end_date, quantity, active) VALUES (@branch, @id, @item, @ori, @dp, @discount, @start, @end, @quant, @active)";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        DateTime end = dtPromoEnd.Value;
                        end = end.AddHours(23);
                        end.AddMinutes(59);
                        comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        comm.Parameters.AddWithValue("@id", txtPromoId.Text);
                        comm.Parameters.AddWithValue("@item", cbItem.SelectedItem.ToString());
                        comm.Parameters.AddWithValue("@ori", txtOriginalPrice.Text);
                        comm.Parameters.AddWithValue("@dp", txtDisPrice.Text);
                        comm.Parameters.AddWithValue("@discount", txtDiscount.Text.Remove(txtDiscount.Text.Length - 1, 1));
                        comm.Parameters.AddWithValue("@start", dtPromoStart.Value);
                        comm.Parameters.AddWithValue("@end", end);
                        comm.Parameters.AddWithValue("@quant", txtAmount.Text);

                        if (DateTime.Now > dtPromoStart.Value)
                            comm.Parameters.AddWithValue("@active", 1);
                        else
                            comm.Parameters.AddWithValue("@active", 0);

                        //kan duplicate pk gee
                        comm.ExecuteNonQuery();

                        con.Close();

                        gebruik.addAction(user);
                        gebruik.log(DateTime.Now, user, "added promotion");

                        DialogResult choice;

                        if (DateTime.Now > dtPromoStart.Value)
                            choice = MessageBox.Show(cbItem.SelectedItem.ToString() + " is now on promotion until " + dtPromoEnd.Value.ToShortDateString() + ".\r\nWould you like to place another item on promotion?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        else
                            choice = MessageBox.Show(cbItem.SelectedItem.ToString() + " will be on promotion from " + dtPromoStart.Value.ToShortDateString() + ", until " + dtPromoEnd.Value.ToShortDateString() + ".\r\nWould you like to place another item on promotion?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (choice == DialogResult.No)
                            this.Close();
                        else
                        {

                            gebruik other = new gebruik();

                            while (txtPromoId.Text == "")
                            {
                                txtPromoId.Text = other.generateLuhn();
                            }
                            while (txtPromoId.Text.Length > 10)
                            {

                                txtPromoId.Clear();
                                txtPromoId.Text = other.generateLuhn();

                            }
                            txtPromoId.Enabled = false;

                            cbItem.Focus();
                            cbItem.SelectedItem = null;
                            txtAmount.Text = "";
                            dtPromoStart.Value = DateTime.Now;
                            dtPromoEnd.Value = DateTime.Now;
                            txtOriginalPrice.Text = "";
                            txtDiscount.Text = "";
                            txtDisPrice.Text = "";

                        }
                    }
                }

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
                        btnAddPromo.PerformClick();
                    }
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception)
            { }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAction.SelectedItem.ToString() == "New promotion")
                {

                    gbNItem.Visible = true;
                    gbNPromo.Visible = true;
                    btnAddPromo.Visible = true;

                }
                else
                {
                    btnAddPromo.Visible = false;
                    gbNItem.Visible = false;
                    gbNPromo.Visible = false;

                    txtAmount.Text = "";

                    cbItem.SelectedItem = null;

                    dtPromoEnd.Value = DateTime.Now;
                    dtPromoStart.Value = DateTime.Now;

                    txtOriginalPrice.Text = "";
                    txtDisPrice.Text = "";
                    txtDiscount.Text = "";

                }

                if (cbAction.SelectedItem.ToString() == "Edit promotion")
                {

                    gbEItem.Visible = true;
                    gbEPromo.Visible = true;
                    btnUPromo.Visible = true;

                }
                else
                {

                    btnUPromo.Visible = false;
                    gbEItem.Visible = false;
                    gbEPromo.Visible = false;
                    txtEQ.Text = "";
                    txtEPromoItem.Clear();
                    cbEID.SelectedItem = null;

                    dtEEnd.Value = DateTime.Now;
                    dtEStart.Value = DateTime.Now;

                    txtEOri.Text = "";
                    txtEDP.Text = "";
                    txtEDPP.Text = "";

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void cbEID_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    con.Open();
                    count = 0;

                    string cmdstring;

                    cmdstring = "SELECT item_name, item_originalprice, item_promoprice, discount, start_date, end_date FROM Promotions WHERE promo_id = @id";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {

                        comm.Parameters.AddWithValue("@id", cbEID.SelectedItem.ToString());

                        using (var reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                txtEPromoItem.Text = reader.GetString(0);
                                txtEOri.Text = reader.GetString(1);
                                txtEDP.Text = reader.GetString(2);
                                txtEDPP.Text = (reader.GetFloat(3)).ToString() + "%";
                                dtEStart.Value = reader.GetDateTime(4);
                                dtEEnd.Value = reader.GetDateTime(5);


                            }
                            reader.Close();
                        }
                        con.Close();

                        txtOriginalPrice.Enabled = false;

                    }

                    cmdstring = "SELECT COUNT(*) FROM Stock WHERE item_name = @item AND branch = @branch";
                    con.Open();
                    count = 0;

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        comm.Parameters.AddWithValue("@item", txtEPromoItem.Text);
                        comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        int recs = (int)comm.ExecuteScalar();
                        con.Close();

                        lblNMax.Text = "Max: " + recs.ToString();
                        lblMax.Text = "Max: " + recs.ToString();
                        max = recs;

                    }
                }

                if (txtEQ.Text != "" && txtEDPP.Text != "" && cbEID.SelectedItem != null && Convert.ToInt16(txtEQ.Text) <= max && Convert.ToInt16(txtEQ.Text) > 0 && Convert.ToInt16(txtEDP.Text) < Convert.ToInt16(txtEOri.Text) && Convert.ToInt16(txtEOri.Text) > 0)
                    btnUPromo.Enabled = true;
                else
                    btnUPromo.Enabled = false;
            }
            catch (FormatException)
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
                        cbEID_SelectedIndexChanged(sender, e);
                    }
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }
        private void fillIds()
        {

            try
            {
                using (SqlConnection conItem = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {


                    string selection = "SELECT promo_id FROM Promotions WHERE branch = @branch";
                    using (SqlCommand commItem = new SqlCommand(selection, conItem))
                    {
                        conItem.Open();
                        count = 0;

                        commItem.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);

                        using (var reader = commItem.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                string item = reader.GetString(0);
                                cbEID.Items.Add(item);

                            }
                            reader.Close();
                        }

                        conItem.Close();

                    }
                }
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
                        fillIds();
                    }
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception)
            { }
        }

        private void btnUPromo_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    con.Open();
                    count = 0;

                    string cmdstring = "UPDATE Promotions SET item_promoprice = @dp, discount = @dis, start_date = @sd, end_date = @ed, quantity = @q, active = @active WHERE promo_id = @id";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        comm.Parameters.AddWithValue("@dp", txtEDP.Text);
                        comm.Parameters.AddWithValue("@dis", txtEDPP.Text.Remove(txtEDPP.Text.Length - 1, 1));
                        comm.Parameters.AddWithValue("@sd", dtEStart.Value.ToShortDateString());
                        comm.Parameters.AddWithValue("@ed", dtEEnd.Value.ToShortDateString());
                        comm.Parameters.AddWithValue("@q", txtEQ.Text);
                        comm.Parameters.AddWithValue("@id", cbEID.SelectedItem.ToString());


                        if (DateTime.Now > dtPromoStart.Value)
                            comm.Parameters.AddWithValue("@active", 1);
                        else
                            comm.Parameters.AddWithValue("@active", 0);

                        comm.ExecuteNonQuery();
                        con.Close();

                        gebruik.addAction(user);
                        gebruik.log(DateTime.Now, user, "updated promotion");


                        DialogResult choice;

                        if (DateTime.Now > dtPromoStart.Value)
                            choice = MessageBox.Show(txtEPromoItem.Text + " is now on promotion until " + dtEEnd.Value.ToShortDateString() + ".\r\nWould you like to edit another promotion?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        else
                            choice = MessageBox.Show(txtEPromoItem.Text + " will be on promotion from " + dtEStart.Value.ToShortDateString() + ", until " + dtEEnd.Value.ToShortDateString() + ".\r\nWould you like to edit another promotion?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (choice == DialogResult.No)
                            this.Close();
                        else
                        {

                            gebruik other = new gebruik();

                            cbEID.SelectedItem = null;

                            cbEID.Focus();
                            txtEQ.Text = "";
                            dtEStart.Value = DateTime.Now;
                            dtEEnd.Value = DateTime.Now;
                            txtEOri.Text = "";
                            txtEDP.Text = "";
                            txtEDPP.Text = "";

                        }
                    }
                }
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
                        btnUPromo.PerformClick();
                    }
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }

        private void txtEDP_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtEDP.Text == "")
                {
                    txtEDPP.Text = "0%";
                    btnUPromo.Enabled = false;
                }

                if (txtEOri.Text != "" && txtEDP.Text != "")
                {
                    if (txtEDP.Text != "")
                    {
                        if (Convert.ToInt16(txtEOri.Text) <= Convert.ToInt16(txtEDP.Text))
                        {

                            txtEDP.ForeColor = Color.Red;

                        }
                        else if (Convert.ToInt16(txtEDP.Text) < 0)
                        {

                            txtEDP.ForeColor = Color.Red;

                        }

                        else
                        {
                            txtEDP.ForeColor = DefaultForeColor;
                            double discount = (Convert.ToDouble(txtEOri.Text) - Convert.ToDouble(txtEDP.Text));
                            discount = discount / Convert.ToDouble(txtEOri.Text);
                            txtEDPP.Text = (Math.Round(discount * 100.00, 2)).ToString() + "%";

                        }

                        if (txtEQ.Text != "" && txtEDPP.Text != "" && cbEID.SelectedItem != null && Convert.ToInt16(txtEQ.Text) <= max && Convert.ToInt16(txtEQ.Text) > 0 && Convert.ToInt16(txtEDP.Text) < Convert.ToInt16(txtEOri.Text) && Convert.ToInt16(txtEOri.Text) > 0)
                            btnUPromo.Enabled = true;
                        else
                            btnUPromo.Enabled = false;

                        if (Convert.ToInt16(txtEDP.Text) < 0)
                        {
                            txtEDP.ForeColor = Color.Red;
                            btnAddPromo.Enabled = false;
                        }
                    }
                    else
                    {
                        btnUPromo.Enabled = false;
                        txtEDPP.Text = "0%";
                    }

                }

            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void txtEQ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEQ.Text != "")
                {
                    if (Convert.ToInt16(txtEQ.Text) > max)
                    {

                        txtEQ.ForeColor = Color.Red;

                    }
                    else if (Convert.ToInt16(txtEQ.Text) < 0)
                    {

                        txtEQ.ForeColor = Color.Red;

                    }
                    else
                        txtEQ.ForeColor = DefaultForeColor;

                    if (txtEQ.Text != "" && txtEDPP.Text != "" && cbEID.SelectedItem != null && Convert.ToInt16(txtEQ.Text) <= max && Convert.ToInt16(txtEQ.Text) > 0 && Convert.ToInt16(txtEDP.Text) < Convert.ToInt16(txtEOri.Text) && Convert.ToInt16(txtEOri.Text) > 0)
                        btnUPromo.Enabled = true;
                    else
                        btnUPromo.Enabled = false;
                }
                else
                    btnUPromo.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void dtPromoStart_ValueChanged(object sender, EventArgs e)
        {
            dtPromoEnd.MinDate = dtPromoStart.Value;
        }

        private void dtEStart_ValueChanged(object sender, EventArgs e)
        {
            dtEEnd.MinDate = dtEStart.Value;
        }

        private void txtEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtEDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private string id = "";
        private void bgWID_DoWork(object sender, DoWorkEventArgs e)
        {
            gebruik other = new gebruik();
            while (id == "" || id.Length != 10)
            {
                id = other.generateLuhn();
            }
        }

        private void bgWID_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtPromoId.Text = id;
        }
    }
}

