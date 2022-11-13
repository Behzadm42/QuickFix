using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }
        int id = 1;
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            int index;
            BLL_User bLL_User = new BLL_User();
            BLL_UserGroup bLL_UserGroup = new BLL_UserGroup();
            var q = bLL_User.read();




            foreach (var item in q)
            {
                index = DGV.Rows.Add();
                DGV.Rows[index].Cells["ID1"].Value = item.ID;
                DGV.Rows[index].Cells["name"].Value = item.Name;
                DGV.Rows[index].Cells["family"].Value = item.Family;
                DGV.Rows[index].Cells["username"].Value = item.UserName;
                DGV.Rows[index].Cells["post"].Value = item.Post;
                DGV.Rows[index].Cells["group"].Value = (bLL_UserGroup.read(item.UserGroupID)).GroupTitle;

            }

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["ID1"].Value);
            }
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Clear();

            FrmInquiryUser frm = new FrmInquiryUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.id = this.id;
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Add(frm);
            frm.Show();
            //-----------------------
        }
    }
}
