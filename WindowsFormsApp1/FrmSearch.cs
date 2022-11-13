using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }
        int id = 1;
        int id11 = 1;

        private void FrmSearch_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(DGV2.Rows[e.RowIndex].Cells["ID"].Value);
            }
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Clear();

            FrmInquiryProduct2 frm = new FrmInquiryProduct2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.id = this.id;
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Add(frm);
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2PictureBox3.Image = ((FrmMain)Application.OpenForms["FrmMain"]).imageList1.Images[1];
            ((FrmMain)Application.OpenForms["FrmMain"]).labelX1.Text = "محصولات";
            frm.Show();
        }


        private void DGV1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                id11 = 1;
            }
            else
            {
                id11 = Convert.ToInt32(DGV1.Rows[e.RowIndex].Cells["ID1"].Value);
            }
        }

        private void DGV1_DoubleClick_1(object sender, EventArgs e)
        {
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Clear();

            FrmInquiryUser frm = new FrmInquiryUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.id = this.id11;
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Add(frm);
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2PictureBox3.Image = ((FrmMain)Application.OpenForms["FrmMain"]).imageList1.Images[2];
            ((FrmMain)Application.OpenForms["FrmMain"]).labelX1.Text = "مدیریت کاربران";
            frm.Show();

        }
    }
}
