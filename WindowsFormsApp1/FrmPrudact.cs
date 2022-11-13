using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPrudact : Form
    {
        public FrmPrudact()
        {
            InitializeComponent();
        }

        int id = 1;
        private void FrmPrudact_Load(object sender, EventArgs e)
        {
            int index;
            BLL_Product bLL_Product = new BLL_Product();
            int i = 0;
            if (textBoxReceiptNumber.Text.Length == 0)
                i = 0;
            else
                i = Convert.ToInt32(textBoxReceiptNumber.Text);
            var q = bLL_Product.read(i, textBoxCustomerName.Text, textBoxCompanyName.Text, textBoxDeviceModel.Text);




            foreach (var item in q)
            {
                index = DGV.Rows.Add();
                DGV.Rows[index].Cells["ID"].Value = item.ID;
                DGV.Rows[index].Cells["ReceiptNumber"].Value = item.ReceiptNumber;
                DGV.Rows[index].Cells["CustomerName"].Value = item.CustomerName;
                DGV.Rows[index].Cells["Address"].Value = item.Address;
                string s = item.PhoneNumber;
                DGV.Rows[index].Cells["PhoneNumber"].Value = s;
                DGV.Rows[index].Cells["CompanyName"].Value = item.CompanyName;
                DGV.Rows[index].Cells["DeviceModel"].Value = item.DeviceModel;
                DGV.Rows[index].Cells["EntryDate"].Value = item.EntryDate;
                //DGV.Rows[index].Cells["Problems"].Value = item.Problems;
                DGV.Rows[index].Cells["Situation"].Value = item.Situation;


            }

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            DGV.DataSource = null;
            int index;
            BLL_Product bLL_Product = new BLL_Product();
            int i = 0;
            if (textBoxReceiptNumber.Text.Length == 0)
                i = 0;
            else
                i = Convert.ToInt32(textBoxReceiptNumber.Text);
            var q = bLL_Product.read(i, textBoxCustomerName.Text, textBoxCompanyName.Text, textBoxDeviceModel.Text);

            DGV.Rows.Clear();

            foreach (var item in q)
            {
                index = DGV.Rows.Add();
                DGV.Rows[index].Cells["ID"].Value = item.ID;
                DGV.Rows[index].Cells["ReceiptNumber"].Value = item.ReceiptNumber;
                DGV.Rows[index].Cells["CustomerName"].Value = item.CustomerName;
                DGV.Rows[index].Cells["Address"].Value = item.Address;
                string s = item.PhoneNumber;
                DGV.Rows[index].Cells["PhoneNumber"].Value = s;
                DGV.Rows[index].Cells["CompanyName"].Value = item.CompanyName;
                DGV.Rows[index].Cells["DeviceModel"].Value = item.DeviceModel;
                DGV.Rows[index].Cells["EntryDate"].Value = item.EntryDate;
                //DGV.Rows[index].Cells["Problems"].Value = item.Problems;
                DGV.Rows[index].Cells["Situation"].Value = item.Situation;


            }

        }


        private void textBoxReceiptNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Clear();

            FrmInquiryProduct2 frm = new FrmInquiryProduct2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.id = this.id;
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Add(frm);
            frm.Show();
            //-----------------------

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
    }
}
