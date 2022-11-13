using BuseinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FrmSetting : Form
    {
        public tblUserAccessRole _AccessRole = new tblUserAccessRole();
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                guna2TextBox1.Text = folderBrowser.SelectedPath;
                guna2Button1.Enabled = true;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQL SERVER DATABASE backup file|*.mdf| SQL SERVER DATABASE backup file |*.bak";

            openFileDialog.Title = "Database Restore";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                guna2TextBox2.Text = openFileDialog.FileName;
                guna2Button3.Enabled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == string.Empty)
            {
                MessageBox.Show("لطفا آدرس فایل بکاپ را وارد کنید");
            }
            else
            {
                BLL_Product bLL_Product = new BLL_Product();
                bLL_Product.backup(guna2TextBox1.Text);
                guna2Button1.Enabled = false;
                MessageBox.Show("از پایگاه داده با موفقیت بکاپ گرفته شد ");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == string.Empty)
            {
                MessageBox.Show("لطفا فایل بکاپ را انتخاب کنید");
            }
            else
            {
                BLL_Product bLL_Product = new BLL_Product();
                bLL_Product.restore(guna2TextBox2.Text);
                MessageBox.Show("پایگاه داده با موفقیت بازگردانی شد");
                guna2Button3.Enabled = false;
                Application.Exit();
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("آیا مطمین هستید که کل پایگاه داده رو میخواهید حذف کنید ", "حذف داده", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d.ToString() == "Yes")
            {
                BLL_Product bLL_Product = new BLL_Product();
                bLL_Product.deleteall();
                bLL_Product.deleteall();
                Application.Exit();

            }

        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            if (_AccessRole.IsEdit == true || _AccessRole.IsDelete == true)
            {
                guna2GroupBox1.Enabled = true;

            }
            else
            {
                guna2GroupBox1.Enabled = true;
            }

        }


    }
}
