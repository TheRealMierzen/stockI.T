﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public Form1(string user)
        {
            InitializeComponent();

        }

        public Form1(string userName, loginForm lf)
        {
            InitializeComponent();
            user = userName;
            login = lf;
            login.Hide();
            login.ShowInTaskbar = false;
        }

        public Form1(string userName, loginForm lf, bool first, string em)
        {
            InitializeComponent();
            user = userName;
            login = lf;
            login.Hide();
            login.ShowInTaskbar = false;
            FR = first;
            email = em;
        }

        private loginForm login;
        private bool FR;
        private string email;

        private string user;
        private gebruik util = new gebruik();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            /////////////////////////////////////////////////////
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            

            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            /////////////////////////////////////////////////////

            //////VISUALS
            ///ADMIN STUFF
            btnAdminShow.Location = new Point(13,(this.Height)/2 - 20);
            btnAdminHide.Location = new Point(133, (this.Height) / 2 - 20);

            btnAddUser.Size = new Size(62, 62);
            btnUUser.Size = new Size(62, 62);
            btnRUser.Size = new Size(62, 62);

            btnAddEmp.Size = new Size(62, 62);
            btnUEmp.Size = new Size(62, 62);
            btnREmp.Size = new Size(62, 62);

            btnEoM.Size = new Size(62, 62);
            btnVLogs.Size = new Size(62, 62);
            btnMPromo.Size = new Size(62,62);

            btnAdmLogout.Size = new Size(62, 62);
            btnExit.Size = new Size(62, 62);

            /////////Display admin panel

            bgWAuthor.RunWorkerAsync();

            this.ResumeLayout();
            if(FR)
            {

                MessageBox.Show("The system has detected that this is a new branch. Please enter the branch manager's information on the next form.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAddEmp f1 = new frmAddEmp(user, email);
                f1.ShowDialog();

            }

        }

        //exit button
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;

            gebruik.log(local, user, "logout");
            gebruik.log(local, user, "closed application");
  
            Application.Exit();
        }


        //UI Mouse
        //Determines which round button is the nearest to resize the button if close enough 
        private Object detNearest()
        {
            Point T = new Point(750,50);
            Point TL = new Point(500,250);
            Point TR = new Point(1000,250);
            Point BL = new Point(500,550);
            Point BR = new Point(1000,550);
            Point B = new Point(750,750);
            Point mousePoint = Cursor.Position;

            object nearest;
            double smallest;

            double dist1 = Math.Sqrt(Math.Pow(750 - mousePoint.X, 2) + Math.Pow(50 - mousePoint.Y, 2));
            double dist2 = Math.Sqrt(Math.Pow(500 - mousePoint.X, 2) + Math.Pow(250 - mousePoint.Y, 2));
            double dist3 = Math.Sqrt(Math.Pow(1000 - mousePoint.X, 2) + Math.Pow(250 - mousePoint.Y, 2));
            double dist4 = Math.Sqrt(Math.Pow(500 - mousePoint.X, 2) + Math.Pow(550 - mousePoint.Y, 2));
            double dist5 = Math.Sqrt(Math.Pow(1000 - mousePoint.X, 2) + Math.Pow(550 - mousePoint.Y, 2));
            double dist6 = Math.Sqrt(Math.Pow(750 - mousePoint.X, 2) + Math.Pow(750 - mousePoint.Y, 2));


            if (dist1 < dist2 && dist1 < dist3 && dist1 < dist4 && dist1 < dist5 && dist1 < dist6)
            {
                nearest = saleBtn;
                smallest = dist1;
            }
            else if (dist2 < dist1 && dist2 < dist3 && dist2 < dist4 && dist2 < dist5 && dist2 < dist6)
            {
                nearest = btnEOD;
                smallest = dist2;
            }
            else if (dist3 < dist2 && dist3 < dist1 && dist3 < dist4 && dist3 < dist5 && dist3 < dist6)
            {
                nearest = btnOrders;
                smallest = dist3;
            }
            else if (dist4 < dist2 && dist4 < dist1 && dist4 < dist3 && dist4 < dist5 && dist4 < dist6)
            {
                nearest = stockBtn;
                smallest = dist4;
            }
            else if (dist5 < dist2 && dist5 < dist3 && dist5 < dist4 && dist5 < dist1 && dist5 < dist6)
            {
                nearest = TechBtn;
                smallest = dist5;
            }
            else //(dist6 < dist2 && dist6 < dist3 && dist6 < dist4 && dist6 < dist5 && dist6 < dist1)
            {
                nearest = hqBtn;
                smallest = dist6;
            }

            if (smallest < 100)
                return nearest;
            else
                return null;


        }

        /*private void MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path that is drawn onto the Panel.
            int mouseX = e.X;
            int mouseY = e.Y;

            if (detNearest() != null)
                label1.Text = detNearest().ToString();
        }*/

       /* private void roundButton1_MouseEnter(object sender, System.EventArgs e)
        {
            
        }*/

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //Gebruik die vir die visual changes vir wanneer muis oor button gaan
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        private void saleButton_MouseEnter(object sender, EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            saleBtn.BevelDepth = 4;
            saleBtn.BevelHeight = 2;
        }

        private void saleButton_MouseLeave(object sender, EventArgs e)
        {

            saleBtn.BevelDepth = 0;
            saleBtn.BevelHeight = 0;

        }
        //////////////////////////////////////////////////////////////////////////////////////////////

        //end of day button
        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (pnlAdmin.Location.X > -216)
                btnAdminHide.PerformClick();
            frmEndOfDay ef = new frmEndOfDay(user);
            this.TopMost = false;
            ef.ShowDialog();
            this.TopMost = true;
        }

        //sale button
        private void saleButton_Click(object sender, EventArgs e)
        {
            if (pnlAdmin.Location.X > -216)
                btnAdminHide.PerformClick();
            salesForm f1 = new salesForm(user);
            this.TopMost = false;
            f1.ShowDialog();
            this.TopMost = true;
            
        }

        //order button 
        private void roundButton3_Click(object sender, EventArgs e)
        {
            if (pnlAdmin.Location.X > -216)
                btnAdminHide.PerformClick();
            OrderForm OF = new OrderForm(user);
            this.TopMost = false;
            OF.ShowDialog();
            this.TopMost = true;

        }

        //technical button
        private void roundButton5_Click(object sender, EventArgs e)
        {
            if (pnlAdmin.Location.X > -216)
                btnAdminHide.PerformClick();
            FrmTechnical ft = new FrmTechnical(user);
            this.TopMost = false;
            ft.ShowDialog();
            this.TopMost = true;
        }

        //hq button
        private void roundButton6_Click(object sender, EventArgs e)
        {
            if(pnlAdmin.Location.X > -216)
                btnAdminHide.PerformClick();
            frmHQ hq = new frmHQ(user);
            this.TopMost = false;
            hq.ShowDialog();
            this.TopMost = true;
            
        }

        //stock button
        private void roundButton4_Click(object sender, EventArgs e)
        {
            if (pnlAdmin.Location.X > -216)
                btnAdminHide.PerformClick();
            StockMainFormCLN stockMainForm = new StockMainFormCLN(user);
            this.TopMost = false;
            stockMainForm.ShowDialog();
            this.TopMost = true;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {            
            frmAddUser adU = new frmAddUser(user);
            this.TopMost = false;
            adU.ShowDialog();
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            btnAdminShow.Location = new Point(180, (this.Height) / 2 - 20);
            btnAdminHide.Location = new Point(130, (this.Height) / 2 - 20);
        }

        private void btnRUser_Click(object sender, EventArgs e)
        {
            frmRUser rUser = new frmRUser(user);
            rUser.ShowDialog();
        }

        private void btnUUser_Click(object sender, EventArgs e)
        {
            frmUpdateUser uUser = new frmUpdateUser(user);
            uUser.ShowDialog();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            frmAddEmp aEmp = new frmAddEmp(user);
            aEmp.ShowDialog();

        }

        private void btnAdmLogout_Click(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;

            gebruik.log(local, user, "logout");

   
            login.Show();
            this.Close();
            login.TopMost = true;
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

        private void btnEoM_Click(object sender, EventArgs e)
        {
            frmEOM  f1 = new frmEOM();
            f1.ShowDialog();

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////SUPRESS KEYS///////////////////////////////////////////////////////
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        //System level functions to be used for hook and unhook keyboard input  
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        //Declaring Global objects     
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Disabling Windows keys 

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                {
                    return (IntPtr)1; // if 0 is returned then All the above keys will be enabled
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }

        private bool auth;
        private void bgWAuthor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (auth)
            {
                pnlAdmin.Visible = true;
                btnAdminShow.Visible = true;
                Properties.Settings.Default.isAdmin = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                pnlAdmin.Visible = false;
                btnAdminShow.Visible = false;
                Properties.Settings.Default.isAdmin = false;
                Properties.Settings.Default.Save();
            }

            btnAdminHide.BringToFront();
        }

        private void bgWAuthor_DoWork(object sender, DoWorkEventArgs e)
        {
            auth = util.checkAuthor(user);
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
