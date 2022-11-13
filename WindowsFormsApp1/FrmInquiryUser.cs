using BuseinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmInquiryUser : Form
    {
        public FrmInquiryUser()
        {
            InitializeComponent();
        }
        public int id;
        void writeoncotrlos(tblUser tblUser)
        {
            BLL_UserGroup bLL_UserGroup = new BLL_UserGroup();
            cls_SecurityMethod cls = new cls_SecurityMethod();
            textBoxName.Text = tblUser.Name;
            textBoxFamily.Text = tblUser.Family;
            textBoxUser.Text = tblUser.UserName;
            textBoxPost.Text = tblUser.Post;
            string Password = cls.Decript(tblUser.Password);
            textBoxPass.Text = Password;
            comboBoxGroup.Text = (bLL_UserGroup.read(tblUser.UserGroupID)).GroupTitle;
            if (tblUser.Status == true)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
        }
        tblUser readcontolrs()
        {
            cls_SecurityMethod cls = new cls_SecurityMethod();
            tblUser tblUser = new tblUser()
            {
                Name = textBoxName.Text,
                Family = textBoxFamily.Text,
                Password = cls.Encript(textBoxPass.Text),
                Post = textBoxPost.Text,
                Status = checkBox1.Checked,
                UserGroupID = Convert.ToInt32(comboBoxGroup.SelectedValue.ToString()),
                UserName = textBoxUser.Text.ToLower()
            };

            return tblUser;
        }
        private void FrmInquiryUser_Load(object sender, EventArgs e)
        {
            BLL_UserGroup bLL_UserGroup = new BLL_UserGroup();
            var q1 = bLL_UserGroup.read();
            comboBoxGroup.DataSource = q1;
            comboBoxGroup.DisplayMember = "GroupTitle";
            comboBoxGroup.ValueMember = "ID";

            BLL_User bLL_User = new BLL_User();
            var q = bLL_User.read(id);
            writeoncotrlos(q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Clear();

            FrmUsers frm = new FrmUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Add(frm);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL_User bLL_User = new BLL_User();
            tblUser tblUser = new tblUser();
            tblUser = readcontolrs();
            bLL_User.update(id, tblUser);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                    (item as TextBox).Clear();
            }
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.RichTextBox")
                    (item as RichTextBox).Clear();
            }
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.MaskedTextBox")
                    (item as MaskedTextBox).Clear();
            }
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    (item as ComboBox).ResetText();
            }
        }
    }
}
