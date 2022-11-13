using BuseinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        private bool iscollapsed = true;
        private bool iscollapsed2 = true;
        int groupid = 0;
        public FrmMain()
        {
            InitializeComponent();
        }
        void Enable_or_Disabele_controls(bool b)
        {
            guna2Panel1.Enabled = b;
            guna2TextBox1.Enabled = b;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Enable_or_Disabele_controls(false);
            FrmLogin fr = new FrmLogin();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Enable_or_Disabele_controls(true);
                BLL_User bLL_User = new BLL_User();
                if (bLL_User.read(cls_UserData.UserID).UserGroupID == 1)//for admins
                    groupid = 1;
                else//for users
                {
                    groupid = 2;
                    panel4.Enabled = false;
                    panel4.Visible = false;
                }
                //for design form
                guna2ShadowForm1.SetShadowForm(this);
                panel2.Top = button1.Top;
                panel2.Height = button1.Height;
                FrmDashbord form1 = new FrmDashbord() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.guna2Panel4.Controls.Clear();
                form1.FormBorderStyle = FormBorderStyle.None;
                this.guna2Panel4.Controls.Add(form1);
                form1.Show();
                //for Tune the buttons in main form
                button2.BringToFront();
                button3.BringToFront();
                panel2.BringToFront();
            }

 
        }

        private void button1_Click(object sender, EventArgs e)//dashbord
        {
            guna2PictureBox3.Image = imageList1.Images[4];
            labelX1.Text = "داشبورد";
            panel2.Top = button1.Top;
            panel2.Height = button1.Height;
            button1.BackColor = Color.FromArgb(58, 58, 58);
            //-------------------------------------------------
            FrmDashbord form1 = new FrmDashbord() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.guna2Panel4.Controls.Clear();
            form1.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel4.Controls.Add(form1);
            form1.Show();
        }
        private void button2_Click(object sender, EventArgs e)//setting
        {
            guna2PictureBox3.Image = imageList1.Images[5];
            labelX1.Text = "تنضیمات";
            panel2.Top = button2.Top;
            panel2.Height = button2.Height;
            button2.BackColor = Color.FromArgb(58, 58, 58);
            //------------------------------------------
            FrmSetting form1 = new FrmSetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tblUserAccessRole q1 = new tblUserAccessRole();
            foreach (var item in cls_UserData.AccessRole)
            {
                if (item.Section == form1.Tag.ToString())
                    q1 = item;
            }
            if (q1 != null &&
              (q1.IsEdit == true || q1.IsSave == true ||
              q1.IsDelete == true || q1.IsSearch == true))
            {
                this.guna2Panel4.Controls.Clear();
                form1._AccessRole = q1;
                form1.FormBorderStyle = FormBorderStyle.None;
                this.guna2Panel4.Controls.Add(form1);
                form1.Show();
            }
            else
            {
                MessageBox.Show("شما دسترسی به این بخش ندارید");
            }

        }
        private void button3_Click(object sender, EventArgs e)//contacts
        {
            guna2PictureBox3.Image = imageList1.Images[3];
            labelX1.Text = "تماس با ما";
            panel2.Top = button3.Top;
            panel2.Height = button3.Height;
            button3.BackColor = Color.FromArgb(58, 58, 58);
            //------------------------------------------
            this.guna2Panel4.Controls.Clear();
            FrmContact form2 = new FrmContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel4.Controls.Add(form2);
            form2.Show();
        }



        #region product
        private void button5_Click(object sender, EventArgs e)
        {
            guna2PictureBox3.Image = imageList1.Images[1];
            labelX1.Text = "محصولات";
            timer1.Start();
            panel2.Top = panel3.Top;
            panel2.Height = button3.Height;
            button5.BackColor = Color.FromArgb(58, 58, 58);
            //------------------------------------------
            this.guna2Panel4.Controls.Clear();
            FrmPrudact form2 = new FrmPrudact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel4.Controls.Add(form2);
            form2.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollapsed)
            {
                panel3.Height += 10;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer1.Stop();
                    iscollapsed = false;
                }

            }
            else
            {
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer1.Stop();
                    iscollapsed = true;
                }

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.guna2Panel4.Controls.Clear();
            FrmAddProduct form2 = new FrmAddProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel4.Controls.Add(form2);
            form2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmInquiryProduct form1 = new FrmInquiryProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tblUserAccessRole q1 = new tblUserAccessRole();
            foreach (var item in cls_UserData.AccessRole)
            {
                if (item.Section == form1.Tag.ToString())
                    q1 = item;
            }
            if (q1 != null &&
              (q1.IsEdit == true || q1.IsSave == true ||
              q1.IsDelete == true || q1.IsSearch == true))
            {
                this.guna2Panel4.Controls.Clear();
                form1._AccessRole = q1;
                form1.FormBorderStyle = FormBorderStyle.None;
                this.guna2Panel4.Controls.Add(form1);
                form1.Show();
            }
            else
            {
                MessageBox.Show("شما دسترسی به این بخش ندارید");
            }
        }
        #endregion


        private void button4_Click(object sender, EventArgs e)//exit
        {
            Application.Exit();
        }
        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)//search
        {
            guna2PictureBox3.Image = imageList1.Images[6];
            labelX1.Text = "جستجو";

            if (groupid == 1)
            {
                BLL_User bLL_User = new BLL_User();
                var q = bLL_User.read(guna2TextBox1.Text);

                this.guna2Panel4.Controls.Clear();
                FrmSearch form1 = new FrmSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                form1.FormBorderStyle = FormBorderStyle.None;
                this.guna2Panel4.Controls.Add(form1);
                form1.Show();
                form1.DGV1.DataSource = null;
                form1.DGV1.Rows.Clear();
                int index1;
                foreach (var item in q)
                {
                    index1 = form1.DGV1.Rows.Add();
                    form1.DGV1.Rows[index1].Cells["ID1"].Value = item.ID;
                    form1.DGV1.Rows[index1].Cells["name"].Value = item.Name;
                    form1.DGV1.Rows[index1].Cells["family"].Value = item.Family;
                    form1.DGV1.Rows[index1].Cells["username"].Value = item.UserName;
                    form1.DGV1.Rows[index1].Cells["post"].Value = item.Post;
                }
                //----------------PRODUCT-----------------------------
                BLL_Product bLL_Product = new BLL_Product();
                var q1 = bLL_Product.read(guna2TextBox1.Text);
                form1.DGV2.DataSource = null;
                form1.DGV2.Rows.Clear();
                int index;
                foreach (var item in q1)
                {
                    index = form1.DGV2.Rows.Add();
                    form1.DGV2.Rows[index].Cells["ID"].Value = item.ID;
                    form1.DGV2.Rows[index].Cells["ReceiptNumber"].Value = item.ReceiptNumber;
                    form1.DGV2.Rows[index].Cells["CustomerName"].Value = item.CustomerName;
                    form1.DGV2.Rows[index].Cells["Address"].Value = item.Address;
                    string s = item.PhoneNumber;
                    form1.DGV2.Rows[index].Cells["PhoneNumber"].Value = s;
                    form1.DGV2.Rows[index].Cells["CompanyName"].Value = item.CompanyName;
                    form1.DGV2.Rows[index].Cells["DeviceModel"].Value = item.DeviceModel;
                    form1.DGV2.Rows[index].Cells["EntryDate"].Value = item.EntryDate;
                    //DGV2.Rows[index].Cells["Problems"].Value = item.Problems;
                    form1.DGV2.Rows[index].Cells["Situation"].Value = item.Situation;
                }
                guna2TextBox1.Select();
            }
            else
            {

                BLL_Product bLL_Product = new BLL_Product();
                var q = bLL_Product.read(guna2TextBox1.Text);
                this.guna2Panel4.Controls.Clear();
                FrmSearch2 form1 = new FrmSearch2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                form1.FormBorderStyle = FormBorderStyle.None;
                this.guna2Panel4.Controls.Add(form1);
                form1.Show();
                form1.DGV.DataSource = null;
                form1.DGV.Rows.Clear();
                int index;
                foreach (var item in q)
                {
                    index = form1.DGV.Rows.Add();
                    form1.DGV.Rows[index].Cells["ID"].Value = item.ID;
                    form1.DGV.Rows[index].Cells["ReceiptNumber"].Value = item.ReceiptNumber;
                    form1.DGV.Rows[index].Cells["CustomerName"].Value = item.CustomerName;
                    form1.DGV.Rows[index].Cells["Address"].Value = item.Address;
                    string s = item.PhoneNumber;
                    form1.DGV.Rows[index].Cells["PhoneNumber"].Value = s;
                    form1.DGV.Rows[index].Cells["CompanyName"].Value = item.CompanyName;
                    form1.DGV.Rows[index].Cells["DeviceModel"].Value = item.DeviceModel;
                    form1.DGV.Rows[index].Cells["EntryDate"].Value = item.EntryDate;
                    //DGV.Rows[index].Cells["Problems"].Value = item.Problems;
                    form1.DGV.Rows[index].Cells["Situation"].Value = item.Situation;
                }
                guna2TextBox1.Select();
            }
        }

        #region users

        private void button9_Click(object sender, EventArgs e)
        {
            guna2PictureBox3.Image = imageList1.Images[2];
            labelX1.Text = "مدیریت کاربران";
            timer2.Start();
            panel2.Top = panel4.Top;
            panel2.Height = button9.Height;
            button9.BackColor = Color.FromArgb(58, 58, 58);
            this.guna2Panel4.Controls.Clear();
            FrmUsers form2 = new FrmUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel4.Controls.Add(form2);
            form2.Show();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (iscollapsed2)
            {
                panel4.Height += 10;
                if (panel4.Size == panel4.MaximumSize)
                {
                    timer2.Stop();
                    iscollapsed2 = false;
                }
            }
            else
            {
                panel4.Height -= 10;
                if (panel4.Size == panel4.MinimumSize)
                {
                    timer2.Stop();
                    iscollapsed2 = true;
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.guna2Panel4.Controls.Clear();
            FrmManageGroup form2 = new FrmManageGroup() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel4.Controls.Add(form2);
            form2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.guna2Panel4.Controls.Clear();
            FrmAddUser form2 = new FrmAddUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel4.Controls.Add(form2);
            form2.Show();
        }
        #endregion

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
