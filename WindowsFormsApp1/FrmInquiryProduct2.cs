using BuseinessEntityLayer;
using BusinessLogicLayer;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmInquiryProduct2 : Form
    {
        public FrmInquiryProduct2()
        {
            InitializeComponent();
        }
        public int id;
        void writeoncontrlos(tblProduct tblProduct)
        {
            textBoxReceiptNumber.Text = tblProduct.ReceiptNumber.ToString();
            textBoxCustomerName.Text = tblProduct.CustomerName;
            textBoxAddress.Text = tblProduct.Address;
            maskedTextBoxPhoneNumber.Text = tblProduct.PhoneNumber;
            textBoxCompanyName.Text = tblProduct.CompanyName;
            textBoxDeviceModel.Text = tblProduct.DeviceModel;
            textBoxColor.Text = tblProduct.Color;
            textBoxSerialNumber.Text = tblProduct.SerialNumber;
            textBoxEntryDate.Text = tblProduct.EntryDate;
            textBoxDeliveryDate.Text = tblProduct.DeliveryDate;
            textBoxProblems.Text = tblProduct.Problems;
            textBoxMinimumCost.Text = tblProduct.MinimumCost;
            textBoxEarnestMoney.Text = tblProduct.EarnestMoney;
            textBoxAttachments.Text = tblProduct.Attachments;
            comboBoxRepairMan.Text = tblProduct.RepairMan;
            textBoxParts.Text = tblProduct.Parts;
            textBoxPartsCost.Text = tblProduct.PartsCost;
            textBoxFinalCost.Text = tblProduct.FinalCost;
            comboBoxSituation.Text = tblProduct.Situation;
            richTextBoxDescription.Text = tblProduct.Description;
            textBoxKeepingPlace.Text = tblProduct.KeepingPlace;
            if (tblProduct.Warranty == true)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
        }
        tblProduct readcontolrs()
        {
            tblProduct tblProduct = new tblProduct()
            {
                ReceiptNumber = Convert.ToInt32(textBoxReceiptNumber.Text),
                CustomerName = textBoxCustomerName.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = maskedTextBoxPhoneNumber.Text,
                CompanyName = textBoxCompanyName.Text,
                DeviceModel = textBoxDeviceModel.Text,
                Color = textBoxColor.Text,
                SerialNumber = textBoxSerialNumber.Text,
                EntryDate = textBoxEntryDate.Text,
                DeliveryDate = textBoxDeliveryDate.Text,
                Problems = textBoxProblems.Text,
                MinimumCost = textBoxMinimumCost.Text,
                EarnestMoney = textBoxEarnestMoney.Text,
                Attachments = textBoxAttachments.Text,
                RepairMan = comboBoxRepairMan.Text,
                Parts = textBoxParts.Text,
                PartsCost = textBoxPartsCost.Text,
                FinalCost = textBoxFinalCost.Text,
                Situation = comboBoxSituation.Text,
                Description = richTextBoxDescription.Text,
                KeepingPlace = textBoxKeepingPlace.Text
            };
            if (radioButton1.Checked == true)
                tblProduct.Warranty = true;
            else
                tblProduct.Warranty = false;
            return tblProduct;
        }
        private void FrmInquiryProduct2_Load(object sender, EventArgs e)
        {
            BLL_User bLL_User = new BLL_User();
            List<tblUser> tblUser = new List<tblUser>();
            tblUser = bLL_User.read1("تعمیرکار");
            comboBoxRepairMan.DataSource = null;
            comboBoxRepairMan.DataSource = tblUser;
            comboBoxRepairMan.DisplayMember = "Family";
            BLL_Product bLL_Product = new BLL_Product();
            var q = bLL_Product.read(id);
            writeoncontrlos(q);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Clear();

            FrmPrudact frm = new FrmPrudact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            ((FrmMain)Application.OpenForms["FrmMain"]).guna2Panel4.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            tblProduct tblProduct = new tblProduct();
            tblProduct = readcontolrs();
            bLL_Product.update(id, tblProduct);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            var q = bLL_Product.read(id);
            var report = new StiReport();
            string path1 = Application.StartupPath + "\\Report\\Report.mrt";
            report.Load(path1);
            report.Compile();
            report.RegBusinessObject("a", q);
            report.Show();
        }
    }
}
