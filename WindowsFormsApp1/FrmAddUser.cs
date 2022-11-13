using BuseinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL_User bll = new BLL_User();
            cls_SecurityMethod cls = new cls_SecurityMethod();
            tblUser ent = new tblUser
            {
                Name = textBox1.Text,
                Family = textBox2.Text,
                Password = cls.Encript(textBox5.Text),
                Post = textBox3.Text,
                Status = checkBox1.Checked,
                UserGroupID = int.Parse(comboBox1.SelectedValue.ToString()),
                UserName = textBox4.Text.ToLower()
            };
            bll.create(ent);
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            BLL_UserGroup bLL_UserGroup = new BLL_UserGroup();
            var q1 = bLL_UserGroup.read();

            comboBox1.DataSource = q1;
            comboBox1.DisplayMember = "GroupTitle";
            comboBox1.ValueMember = "ID";
        }



        private void btnDelete_Click(object sender, EventArgs e)
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
