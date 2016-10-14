using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace _213
{
    public partial class frmEndOfDay : Form
    {

        private int count;


        public frmEndOfDay()
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public frmEndOfDay(string userName)
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            user = userName;
        }


        private string stock, sales, repairs, orders;
        private int stockC, salesC, repairsC, ordersC;
        private string user;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompleteDay_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdStr = "Delete from Stock where branch = @branch AND status = @stats";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        deleteStock.Parameters.AddWithValue("@stats", "Removed");

                        conn.Open();
                        count = 0;
                        deleteStock.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnCompleteDay.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error connecting to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbStock_CheckedChanged(object sender, EventArgs e)
        {
            fill(chbStock.Checked, chbSales.Checked, chbRepairs.Checked, chbOrders.Checked);
        }

        private void chbSales_CheckedChanged(object sender, EventArgs e)
        {
            fill(chbStock.Checked, chbSales.Checked, chbRepairs.Checked, chbOrders.Checked);
        }

        private void chbRepairs_CheckedChanged(object sender, EventArgs e)
        {
            fill(chbStock.Checked, chbSales.Checked, chbRepairs.Checked, chbOrders.Checked);
        }

        private void chbOrders_CheckedChanged(object sender, EventArgs e)
        {
            fill(chbStock.Checked, chbSales.Checked, chbRepairs.Checked, chbOrders.Checked);
        }

        private void fill(bool stockb, bool salesb, bool repairsb, bool ordersb)
        {

            txtOutput.Clear();            

            if(salesb)
            {

                txtOutput.AppendText(sales);

            }

            if(repairsb)
            {

                txtOutput.AppendText(repairs);

            }

            if(ordersb)
            {

               txtOutput.AppendText(orders);

            }

            if (stockb)
            {

                txtOutput.AppendText(stock);

            }



        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser adU = new frmAddUser(user);
            this.TopMost = false;
            adU.ShowDialog();
        }

        private void btnUUser_Click(object sender, EventArgs e)
        {
            frmUpdateUser uUser = new frmUpdateUser(user);
            uUser.ShowDialog();
        }

        private void btnRUser_Click(object sender, EventArgs e)
        {
            frmRUser rUser = new frmRUser(user);
            rUser.ShowDialog();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            frmAddEmp aEmp = new frmAddEmp(user);
            aEmp.ShowDialog();
        }

        private void btnUEmp_Click(object sender, EventArgs e)
        {
            frmUEmp uEmp = new frmUEmp(user);
            uEmp.ShowDialog();
        }

        private void btnREmp_Click(object sender, EventArgs e)
        {
            frmREmp rEmp = new frmREmp(user);
            rEmp.ShowDialog();
        }

        private void btnEoM_Click(object sender, EventArgs e)
        {
            frmEOM f1 = new frmEOM();
            f1.ShowDialog();
        }

        private void btnMPromo_Click(object sender, EventArgs e)
        {
            frmAdminPromos f1 = new frmAdminPromos(user);
            f1.ShowDialog();
        }

        private void btnVLogs_Click(object sender, EventArgs e)
        {
            frmLogs fl = new frmLogs(AppDomain.CurrentDomain.BaseDirectory + @"\Activity log.txt");
            fl.ShowDialog();
        }

        private void btnAdmLogout_Click(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;

            gebruik.log(local, user, "logout");
            loginForm login = new loginForm();

            login.Show();
            this.Close();
            login.TopMost = true;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;

            gebruik.log(local, user, "logout");
            gebruik.log(local, user, "closed application");

            Application.Exit();
        }

        private void btnAdminHide_Click(object sender, EventArgs e)
        {
            for (int pos = 0; pos > -233; pos--)
                pnlAdmin.Location = new Point(pos, 0);
        }

        private void btnAdminShow_Click(object sender, EventArgs e)
        {
            for (int pos = -233; pos < 0; pos++)
                pnlAdmin.Location = new Point(pos, 0);
        }

        private void frmEndOfDay_Load(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

                stock = "";
                sales = "";
                orders = "";
                repairs = "";

                int n = 1;
                int ins = 0;
                int re = 0;
                int tra = 0;
                string cmdStr = "SELECT item_id, item_name, status from Stock where branch = @branch AND last_updated = @last ORDER BY status ASC";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        conn.Open();

                        deleteStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        deleteStock.Parameters.AddWithValue("@last", (DateTime.Today).ToString().Substring(0,10) + " 00:00:00");

                        using (var reader = deleteStock.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                stockC++;
                                if (reader.GetString(2) == "In Stock")
                                {
                                    stock += reader.GetString(0);
                                    stock += reader.GetString(1);
                                    stock += "\r\n";
                                    
                                }
                                if (reader.GetString(2) == "In Transit")
                                {
                                    if (n == 1)
                                    {
                                        ins = stockC;
                                        stock += stockC.ToString() + " items in stock";
                                        n++;
                                    }
                                    stock += reader.GetString(0);
                                    stock += reader.GetString(1);
                                    stock += "\r\n";

                                }
                                if (reader.GetString(2) == "Removed")
                                {
                                    if (n == 2)
                                    {
                                        tra = (stockC - ins);
                                        stock += tra.ToString() + " transferred from this branch";
                                        n++;
                                    }
                                    stock += reader.GetString(0);
                                    stock += reader.GetString(1);
                                    stock += "\r\n";

                                }
                                if (reader.GetString(2) == "Sold")
                                {
                                    if (n == 3)
                                    {
                                        re = stockC - tra;   
                                        stock += re.ToString() + " removed from this branch";
                                        n++;
                                    }
                                    stock += reader.GetString(0);
                                    stock += reader.GetString(1);
                                    stock += "\r\n";

                                }

                                

                            }

                            stock += (stockC - re).ToString() + " sold";

                        }
                    }
                }

                setCheck();
                getSold();
                getReps();
                getOrders();
                getReceived();
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnCompleteDay.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error connecting to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setCheck()
        {

            try
            {
                string cmdStr = "UPDATE Stock set checked = 0 where branch = @branch";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);

                        conn.Open();
                        count = 0;
                        deleteStock.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnCompleteDay.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error connecting to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getSold()
        {
            txtOutput.AppendText("______________________________");
            try
            {
                string cmdStr = "SELECT sale_id, item_ids FROM Sales where sale_branch = @branch AND sale_date LIKE @date";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        deleteStock.Parameters.AddWithValue("@date", DateTime.Today + "%");

                        conn.Open();
                        count = 0;

                        using (var reader = deleteStock.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                sales += reader.GetString(0) + " " + reader.GetString(1);
                            }
                        }

 

                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnCompleteDay.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error connecting to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getReps()
        {
            txtOutput.AppendText("______________________________");
            txtOutput.AppendText("Repairs collected");
            try
            {
                string cmdStr = "SELECT repair_id FROM Repairs where branch = @branch AND date_finished = @date";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        deleteStock.Parameters.AddWithValue("@date", (DateTime.Today).ToString().Substring(0, 10) + " 00:00:00");

                        conn.Open();
                        count = 0;

                        using (var reader = deleteStock.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                    repairs += reader.GetString(0);
                            }
                        }

                    }

                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnCompleteDay.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error connecting to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void getOrders()
        {
            txtOutput.AppendText("______________________________");
            txtOutput.AppendText("Orders placed");
            try
            {
                string cmdStr = "SELECT order_id FROM Orders where branch = @branch AND order_date = @date";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        deleteStock.Parameters.AddWithValue("@date", (DateTime.Today).ToString().Substring(0, 10) + " 00:00:00");

                        conn.Open();
                        count = 0;

                        using (var reader = deleteStock.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                orders += reader.GetString(0);
                            }
                        }
 
                    }

                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnCompleteDay.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error connecting to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getReceived()
        {
            txtOutput.AppendText("______________________________");
            txtOutput.AppendText("Orders received");
            try
            {
                string cmdStr = "SELECT order_id FROM Orders where branch = @branch AND received_date = @date";

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    using (SqlCommand deleteStock = new SqlCommand(cmdStr, conn))
                    {
                        deleteStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        deleteStock.Parameters.AddWithValue("@date", (DateTime.Today).ToString() + " 00:00:00");

                        conn.Open();
                        count = 0;

                        using (var reader = deleteStock.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                orders += reader.GetString(0);
                            }
                        }



                    }

                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count++;
                        btnCompleteDay.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure that all required fields have been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error connecting to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
