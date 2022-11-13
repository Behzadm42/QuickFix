using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmSearch2 : Form
    {
        public FrmSearch2()
        {
            InitializeComponent();
        }
        int id = 1;
        private void FrmSearch2_Load(object sender, EventArgs e)
        {

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                id = 1;
            }
            else
            {
                id = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["ID"].Value);
            }
        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Clear();

            FrmInquiryProduct2 frm = new FrmInquiryProduct2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.id = this.id;
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Add(frm);
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2PictureBox3.Image = ((FrmMain)Application.OpenForms["FrmMain"]).imageList1.Images[1];
            ((FrmMain)Application.OpenForms["FrmMain"]).labelX1.Text = "محصولات";
            frm.Show();
            //-----------------------
        }
    }
}
