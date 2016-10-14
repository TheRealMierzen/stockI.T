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
    public partial class FrmTechnical : Form
    {
        string allBuilditems;
        string orderedItems;
        string allBuilditemsID;//set item status na cms id
        string orderNumber;
        string items;
        string textBoxitems;
        int last;
        int count;
        bool order = false;
        private string user;
        private int countInternet = 0;
 
        public FrmTechnical()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public FrmTechnical(string usert)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            user = usert;
        }

        public FrmTechnical(string items,string ordernumber, string usert)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            user = usert;           

        }

        public void setItems(string items)
        {
            orderedItems = orderedItems + items + ",";
        }

        public void setOrderId(string id)
        {

            orderNumber = id + ",";

        }

        private void getItem(string itemID)
        {
            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                string cmdstring = "SELECT item_name, item_type FROM Stock WHERE item_id = @id";


                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    con.Open();
                    comm.Parameters.AddWithValue("@id", itemID);
                    if (comm.ExecuteScalar() != null)
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(1).Equals("Mobo"))
                                {
                                    txtmobo.SelectedItem = (reader.GetString(0));
                                }
                                else   if (reader.GetString(1).Equals("RAM"))
                                {
                                    txtRam.SelectedItem = (reader.GetString(0));
                                }
                                else   if (reader.GetString(1).Equals("GPU"))
                                {
                                    txtGpu.SelectedItem = (reader.GetString(0));
                                }
                                else if (reader.GetString(1).Equals("PSU"))
                                {
                                    txtPsu.SelectedItem = (reader.GetString(0));
                                }
                                else   if (reader.GetString(1).Equals("CPU"))
                                {
                                    txtCpu.SelectedItem = (reader.GetString(0));
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID is not recognized by the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void fillCombo()
        {

            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string cmdstring = "SELECT item_name, item_type FROM Stock WHERE branch = @branch AND Status = @status";


                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        con.Open();
                        comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        comm.Parameters.AddWithValue("@status", "In Stock");
                        using (var reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(1).Equals("Mobo"))
                                {
                                    txtmobo.Items.Add(reader.GetString(0));
                                }
                                else if (reader.GetString(1).Equals("RAM"))
                                {
                                    txtRam.Items.Add(reader.GetString(0));
                                }
                                else if (reader.GetString(1).Equals("GPU"))
                                {
                                    txtGpu.Items.Add(reader.GetString(0));
                                }
                                else if (reader.GetString(1).Equals("PSU"))
                                {
                                    txtPsu.Items.Add(reader.GetString(0));
                                }
                                else if (reader.GetString(1).Equals("CPU"))
                                {
                                    txtCpu.Items.Add(reader.GetString(0));
                                }

                            }
                        }
                        con.Close();

                    }
                }
            }catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && countInternet < 4)
                    {
                        countInternet++;
                        fillCombo();
                    }
                    else
                        MessageBox.Show("It appears there is a problem with your internet connection", "Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmTechnical_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            label19.Hide();
            label20.Hide();

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

            gpbClient.Hide();
            gpxtech.Hide();

            cbxLayout.SelectedIndex = 0;
            fillCombo();
        }


        private void custombuilds()//Om die layout van die form te verander na die custombuilds
        {
            gpbClient.Show();
            gpxtech.Show();
            gpxtech.Text = "Custom builds";
            groupBox2.Text = "Custom build";

            txtCost.Hide();
            label2.Hide();
           
        }

        private void repairs()//Om die layout van die from te verander na die repairs
        {
            gpbClient.Show();
          //  gpxtech.Text = "Repairs";
           // gpxtech.Show();
            groupBox2.Text = "Repairs";
            txtCost.Show();
            label2.Show();
        }

        private void repairs(string itemfromOrder)//Om die layout van die from te verander na die repairs
        {
            
        }

        private void cbxLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLayout.SelectedIndex == 0)
            {
                gpxtech.Show();
                textBox1.Hide();
                textBox2.Hide();
                label20.Hide();
                label19.Hide();
                rbtnWarranty.Hide();
                btnConfirmRep.Hide();
                txtRepairID.Hide();
                label21.Hide();
                cbxCollected.Hide();
                cbxCompleted.Hide();
                button1.Hide();
                custombuilds();
            }
                
            
            if (cbxLayout.SelectedIndex == 1)
            {
                gpxtech.Hide();
                rbtnWarranty.Show();
                btnConfirmRep.Show();
                textBox1.Show();
                label20.Show();
                label19.Show();
                label21.Hide();
                textBox2.Show();
                btnPlaceorder.Hide();
                txtRepairID.Hide();
                button1.Hide();
                cbxCollected.Hide();
                cbxCompleted.Hide();
                repairs();

            }
            if(cbxLayout.SelectedIndex == 2)
            {

                gpbClient.Text = "Review Repairs";
                textBox1.Hide();
                textBox2.Hide();
                label20.Hide();
                btnPlaceorder.Hide();
                label19.Hide();
                rbtnWarranty.Hide();
                btnConfirmRep.Hide();
                button1.Show();
                txtEmail.Hide();
                label21.Show();
                textBox1.Hide();
                textBox2.Hide();
                txtRepairID.Show();
                cbxCollected.Show();
                cbxCompleted.Show();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {


           if(cbxLayout.SelectedIndex == 0)
           {
                if(txtEmail.Text == "")
                {
                    SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                    con.Open();
                    if (txtCpu.SelectedItem == null || txtGpu.SelectedItem == null || txtmobo.SelectedItem == null || txtPsu.SelectedItem == null || txtMics.Text == null || txtRam.SelectedItem == null)
                    {
                        if (MessageBox.Show("Are you sure you entered all the fields correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Send to order form
                            int count = 0;
                            string ids = "";
                            string names = "";

                            if (txtCpu.SelectedItem == null)
                                count++;
                            else
                            {
                                ids = ids + txtCpu.Text + ",";
                                SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                                getID.Parameters.AddWithValue("@name", txtCpu.Text);
                                names = names + getID.ExecuteScalar().ToString() + ",";
                            }
                            if (txtGpu.SelectedItem == null)
                                count++;
                            else
                            {
                                ids = ids + txtGpu.Text + ",";
                                SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                                getID.Parameters.AddWithValue("@name", txtGpu.Text);
                                names = names + getID.ExecuteScalar().ToString() + ",";
                            }
                            if (txtmobo.SelectedItem == null)
                                count++;
                            else
                            {
                                ids = ids + txtmobo.Text + ",";
                                SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                                getID.Parameters.AddWithValue("@name", txtmobo.Text);
                                names = names + getID.ExecuteScalar().ToString() + ",";
                            }
                            if (txtPsu.SelectedItem == null)
                                count++;
                            else
                            {
                                ids = ids + txtPsu.Text;
                                SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                                getID.Parameters.AddWithValue("@name", txtPsu.Text);
                                names = names + getID.ExecuteScalar().ToString() + ",";
                            }
                            if (txtMics.Text == "")
                                count++;
                            else
                            {
                                ids = ids + txtMics.Text + ",";
                                SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                                getID.Parameters.AddWithValue("@name", txtMics.Text);
                                names = names + getID.ExecuteScalar().ToString() + ",";
                            }
                            if (txtRam.SelectedItem == null)
                                count++;
                            else
                            {
                                ids = ids + txtRam.Text + ",";
                                SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                                getID.Parameters.AddWithValue("@name", txtRam.Text);
                                names = names + getID.ExecuteScalar().ToString() + ",";
                            }

                            gebruik util = new gebruik();
                            last = util.getLastIdentity("Cms", "cms_id", "int");
                            if (last == -1)
                                last = 1;


                            AddCustomBuild(Properties.Settings.Default.Branch, last.ToString(), names, ids, "", "", txtEmail.Text, "", 0);
                            OrderForm Of = new OrderForm(user, count, txtEmail.Text);
                            Of.Show();
                            this.Hide();

                        }
                        else
                        {
                            //Close message
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you entered all the fields correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            string itemIDS = "";
                            gebruik util = new gebruik();
                            last = util.getLastIdentity("Cms", "cms_id", "int");
                            string itemNames = txtCpu.Text + "," + txtGpu.Text + "," + txtMics.Text + "," + txtmobo.Text + "," + txtPsu.Text + "," + txtRam.Text + ",";
                            SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                            getID.Parameters.AddWithValue("@name", txtCpu.Text);
                            itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                            SqlCommand getID2 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                            getID2.Parameters.AddWithValue("@name", txtGpu.Text);
                            itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                            SqlCommand getID3 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                            getID3.Parameters.AddWithValue("@name", txtMics.Text);
                            itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                            SqlCommand getID4 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                            getID4.Parameters.AddWithValue("@name", txtmobo.Text);
                            itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                            SqlCommand getID5 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                            getID5.Parameters.AddWithValue("@name", txtPsu.Text);
                            itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                            SqlCommand getID6 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                            getID6.Parameters.AddWithValue("@name", txtRam.Text);
                            itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                            AddCustomBuild(Properties.Settings.Default.Branch, last.ToString(), itemNames, itemIDS, "", "", txtEmail.Text, DateTime.Now.ToString(), 1);
                            MessageBox.Show("All items are accounted for the custom build, refferance number: " + last.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure the email field is entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
               
            else
            {

            }
        }

        private void FrmTechnical_Activated(object sender, EventArgs e)
        {

        }

        public void orderItems(string message)
        {
            if (count == 0 && message != "0")
                if (MessageBox.Show("Item " + message +" not in stock. Do you want to order? ", "Order item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    OrderForm OF = new OrderForm(true, this);
                    
                    OF.ShowDialog();
                    
                }
        }
        
      
        public bool AddCustomBuild(string branch, string cms_id,string cms_Items,string cms_itemIDs,string cms_order,string cms_OrderID,string cms_email,string date_complete,int complete)
        {
            try
            {

                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    string cmdstring = "INSERT INTO Cms (cms_id, cms_items, cms_itemsIDs, cms_order,cms_orderID,cms_email,complete_date,completed, branch) VALUES (@cms_id, @cms_items, @cms_itemIDs, @cms_order,@cms_orderID,@cms_email,@date_complete,@completed,@branch)";
                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {

                        comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                       comm.Parameters.AddWithValue("@cms_id", last + 1);
                        comm.Parameters.AddWithValue("@cms_items", cms_Items);
                        comm.Parameters.AddWithValue("@cms_itemIDs", cms_itemIDs);
                        comm.Parameters.AddWithValue("@cms_order", cms_order);
                        comm.Parameters.AddWithValue("@cms_orderID", cms_OrderID);
                        comm.Parameters.AddWithValue("@cms_email", cms_email);
                        comm.Parameters.AddWithValue("@date_complete", date_complete);
                        comm.Parameters.AddWithValue("@completed", complete);

                        con.Open();
                        comm.ExecuteNonQuery();

                    }
                         
                }
               return true;

            }
            catch(IndexOutOfRangeException ior)
            {
                
                MessageBox.Show("An error occurred during the " + ior.TargetSite + " process. Please verify the entered information and try again. If the problem persists, please contact our support team: codedCoffeeTest@gmail.comsuppot \r\n" + ior.Message,"Error");
                return true;

            }
            catch(Exception e)
            {

                MessageBox.Show("An error occurred during the " + e.TargetSite  + " process. Please verify the entered information and try again. If the problem persists, please contact our support team: codedCoffeeTest@gmail.comsuppot \r\n" + e.Message + " addOrder - line 256", "Error");
                return false;

            }
        }

        private void btnPlaceorder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
            con.Open();
            if (txtCpu.SelectedItem == null || txtGpu.SelectedItem == null || txtmobo.SelectedItem == null || txtPsu.SelectedItem == null || txtMics.Text == null || txtRam.SelectedItem == null)
            {
                if (MessageBox.Show("Are you sure you entered all the fields correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Send to order form
                    int count = 0;
                    string ids = "";
                    string names = "";

                    if (txtCpu.SelectedItem == null)
                        count++;
                    else
                    {
                        ids = ids + txtCpu.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                        getID.Parameters.AddWithValue("@name", txtCpu.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtGpu.SelectedItem == null)
                        count++;
                    else
                    {
                        ids = ids + txtGpu.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                        getID.Parameters.AddWithValue("@name", txtGpu.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtmobo.SelectedItem == null)
                        count++;
                    else
                    {
                        ids = ids + txtmobo.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                        getID.Parameters.AddWithValue("@name", txtmobo.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtPsu.SelectedItem == null)
                        count++;
                    else
                    {
                        ids = ids + txtPsu.Text;
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                        getID.Parameters.AddWithValue("@name", txtPsu.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtMics.Text == "")
                        count++;
                    else
                    {
                        ids = ids + txtMics.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                        getID.Parameters.AddWithValue("@name", txtMics.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtRam.SelectedItem == null)
                        count++;
                    else
                    {
                        ids = ids + txtRam.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                        getID.Parameters.AddWithValue("@name", txtRam.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }

                    gebruik util = new gebruik();
                    last = util.getLastIdentity("Cms", "cms_id", "int");
                    if (last == -1)
                        last = 1;


                    AddCustomBuild(Properties.Settings.Default.Branch, last.ToString(), names, ids, "", "", txtEmail.Text, "", 0);
                    OrderForm Of = new OrderForm(user, count, txtEmail.Text);
                    Of.Show();
                    this.Hide();

                }
                else
                {
                    con.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you entered all the fields correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string itemIDS = "";
                    gebruik util = new gebruik();
                    last = util.getLastIdentity("Cms", "cms_id", "int");
                    string itemNames = txtCpu.Text + "," + txtGpu.Text + "," + txtMics.Text + "," + txtmobo.Text + "," + txtPsu.Text + "," + txtRam.Text + ",";
                    SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                    getID.Parameters.AddWithValue("@name", txtCpu.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                    SqlCommand getID2 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                    getID2.Parameters.AddWithValue("@name", txtGpu.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                    SqlCommand getID3 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                    getID3.Parameters.AddWithValue("@name", txtMics.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                    SqlCommand getID4 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                    getID4.Parameters.AddWithValue("@name", txtmobo.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                    SqlCommand getID5 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                    getID5.Parameters.AddWithValue("@name", txtPsu.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                    SqlCommand getID6 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name", con);
                    getID6.Parameters.AddWithValue("@name", txtRam.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                    AddCustomBuild(Properties.Settings.Default.Branch, last.ToString(), itemNames, itemIDS, "", "", txtEmail.Text, DateTime.Now.ToString(), 1);
                    gebruik.log(DateTime.Now, user, "custom build added: " + last.ToString());
                    gebruik.addAction(user);
                    MessageBox.Show("All items are accounted for the custom build, refferance number: " + last.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            
            
            if (MessageBox.Show("Are you sure you want to add this order ", "Place order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
             {
                 if(AddCustomBuild(Properties.Settings.Default.Branch,last.ToString(), allBuilditems, allBuilditemsID, orderedItems, orderNumber, txtEmail.Text,"", 0))
                 {
                     MessageBox.Show("Order added");
                 }
             }
        }


        private void txtmobo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtGpu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtPsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtCpu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtMics_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txbID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {
            if (e.KeyData == Keys.Tab)
            {
                getItem(txbID.Text);
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

        private void btnExit_Click(object sender, EventArgs e)
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

        private void rbtnWarranty_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmRep_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" || textBox2.Text != "" || txtEmail.Text != "")
            {
                if (!rbtnWarranty.Checked)
                {
                    MessageBox.Show("There is no warranty. \r\nA special order will have to be placed for the replacement part.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OrderForm frmOrder = new OrderForm(user);
                    frmOrder.ShowDialog();
                    this.Close();

                }
                else
                {

                    SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                    con.Open();
                    SqlCommand count = new SqlCommand("SELECT COUNT(repair_id) FROM Repairs", con);
                    int countID = (Int32)count.ExecuteScalar();
                    countID = countID + 1;
                    SqlCommand addRep = new SqlCommand("INSERT INTO Repairs VALUES(@branch, @repair_id, @warranty, @dateBr, @dateFi, @col, @tCost, @paid, @cusN, @cusE, @cusC)", con);
                    addRep.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                    addRep.Parameters.AddWithValue("@repair_id", countID);
                    addRep.Parameters.AddWithValue("@warranty", 1);
                    addRep.Parameters.AddWithValue("@dateBr", DateTime.Today);
                    addRep.Parameters.AddWithValue("@dateFi", DateTime.Now.AddYears(-100));
                    addRep.Parameters.AddWithValue("@col", 0);
                    addRep.Parameters.AddWithValue("@tCost", txtCost.Text);
                    addRep.Parameters.AddWithValue("@paid", 0);
                    addRep.Parameters.AddWithValue("@cusN", textBox1.Text);
                    addRep.Parameters.AddWithValue("@cusE", txtEmail.Text);
                    addRep.Parameters.AddWithValue("@cusC", textBox2.Text);
                    addRep.ExecuteNonQuery();
                    gebruik.log(DateTime.Now, user, "Added Repair: " + countID);
                    gebruik.addAction(user);
                    con.Close();
                    MessageBox.Show("Repair statement complete");
                }
            }
            else
            {
                MessageBox.Show("Error: Make sure customer details are entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void FrmTechnical_Shown(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rco(object sender, EventArgs e)
        {

        }

        private void txtRepairID_TextChanged(object sender, EventArgs e)
        {
            if (txtRepairID.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void cbxCollected_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbxCompleted.Checked) || (cbxCollected.Checked))
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
            con.Open();
            SqlCommand check = new SqlCommand("SELECT repair_id FROM Repairs WHERE repair_id = @id AND branch = @branch", con);
            check.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            check.Parameters.AddWithValue("@id", txtRepairID.Text);
            if (check.ExecuteScalar() == null)
            {
                MessageBox.Show("Error: Repair ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                    if (cbxCollected.Checked)
                    {
                        SqlCommand updateCol = new SqlCommand("UPDATE Repairs SET collected = @col WHERE branch = @branch AND repair_id = @id", con);
                        updateCol.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        updateCol.Parameters.AddWithValue("@col", 1);
                        updateCol.Parameters.AddWithValue("id", txtRepairID.Text);

                        updateCol.ExecuteNonQuery();
                        con.Close();
                        gebruik.log(DateTime.Now, user, "Updated Repair: " + txtRepairID.Text + " Collected");
                        gebruik.addAction(user);
                        MessageBox.Show("Repair successfully updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                    if (cbxCompleted.Checked)
                    {
                        SqlCommand updateCol = new SqlCommand("UPDATE Repairs SET date_finished = @col WHERE branch = @branch AND repair_id = @id", con);
                        SqlCommand selectEmail = new SqlCommand("SELECT customer_email FROM Repairs where branch = @branch2 AND repair_id = @id2", con);
                        SqlCommand selectName = new SqlCommand("SELECT customer_name FROM Repairs where branch = @branch3 AND repair_id = @id3", con);
                        selectName.Parameters.AddWithValue("@branch3", Properties.Settings.Default.Branch);
                        selectName.Parameters.AddWithValue("@id3", txtRepairID.Text);
                        string toName = selectName.ExecuteScalar().ToString();
                        selectEmail.Parameters.AddWithValue("@branch2", Properties.Settings.Default.Branch);
                        selectEmail.Parameters.AddWithValue("id2", txtRepairID.Text);
                        string toEmail = selectEmail.ExecuteScalar().ToString();
                        updateCol.Parameters.AddWithValue("@col", DateTime.Today);
                        updateCol.Parameters.AddWithValue("@id", txtRepairID.Text);
                        updateCol.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        updateCol.ExecuteNonQuery();
                        con.Close();

                        gebruik.log(DateTime.Now, user, "Updated Repair: " + txtRepairID.Text + " Completed");
                        gebruik.addAction(user);
                        gebruik meh = new gebruik();

                        string file = "                                           Tutorial"
+ "                                       13 Codedcoffee address"
+ ""
+ ""
+ "                                                                       (011)5554888"
+ "                                                                       (011)555 - 8889"
+ "                                                                       123456789"
+ "                                                                       987654321"
+ "                     REPAIR SERVICE RECEIVED"
+ "Repair number: " + txtRepairID.Text + "                                 Date: " + DateTime.Today.ToShortDateString()
+ "Name: " + toName
+ "Email address: " + toEmail
+ "____________________________________________________________________________"
+ "Repair id  " + txtRepairID.Text + "                                                                                  Labour cost"
+ "____________________________________________________________________________"
+ "Repair " + txtRepairID.Text















+ "____________________________________________________________________________"
+ "Contact person:"
+ "Telephone number: (011) 543 - 5764";

                if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Repairstatement"))
                {

                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Repairstatement", file);

                }
                else
                {

                    File.CreateText(AppDomain.CurrentDomain.BaseDirectory + @"\Repairstatement");
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Repairstatement", file);

                }

                gebruik other = new gebruik();
                other.print(AppDomain.CurrentDomain.BaseDirectory + @"\Repairstatement");
                other.print(AppDomain.CurrentDomain.BaseDirectory + @"\Repairstatement");

                if (meh.Mail(toEmail, "Repair Completed", "Hi there " + toName + "\r\n\r\nWe would like to inform you that you that\r\n\r\nyour repair is ready for collection.\r\n\r\nPlease keep this refferance number for collection: " + txtRepairID.Text))
                        {
                            MessageBox.Show("The customer was notified for collection.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error occured and user was not notified for collection.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        MessageBox.Show("Repair successfully updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                
                    

                
            


        }

        private void cbxCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if((cbxCompleted.Checked) || (cbxCollected.Checked))
            {
                button1.Enabled = true;
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
