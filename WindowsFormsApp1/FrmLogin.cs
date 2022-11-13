using BuseinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        void Login()
        {
            BLL_User bLL_User = new BLL_User();
            cls_SecurityMethod cls = new cls_SecurityMethod();
            string Password = cls.Encript(guna2TextBox2.Text);
            var q = bLL_User.checkpass(guna2TextBox1.Text.ToLower(), Password);
            if (q.Count() == 1)
            {
                BLL_UserAccessRoles bLL_UserAccessRoles = new BLL_UserAccessRoles();
                cls_UserData.UserID = q.Single().ID;
                int GroupId = q.Single().UserGroupID;
                cls_UserData.AccessRole = bLL_UserAccessRoles.read(GroupId);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("یوزر یا پسورد اشتباه است");
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2TextBox2.Focus();
            }
        }

        private void guna2TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            guna2TextBox2.PasswordChar = guna2CheckBox1.Checked ? '\0' : '*';
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            BLL_Product bLL_Product = new BLL_Product();
            if (bLL_Product.CheckDatabase("Device_Repair")==false)
            {
                bLL_Product.createdatabase();
                string path1 = Application.StartupPath + "\\database-2022-11-12--15-38-03.mdf";
                bLL_Product.restore(path1);
                
            }
            else
            {

                BLL_User bLL_User = new BLL_User();
                var q = bLL_User.read();
                if (q.Count == 0)
                {
                    string path1 = Application.StartupPath + "\\database-2022-11-12--15-38-03.mdf";
                    bLL_Product.restore(path1);
                }
            }
        }
    }
}
