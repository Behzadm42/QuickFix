using BuseinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace WindowsFormsApp1
{
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }
        int id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
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
            bLL_Product.create(tblProduct);
            button7.Enabled = true;
            id = bLL_Product.getid();
            

        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            button7.Enabled = false;
            BLL_User bLL_User = new BLL_User();
            List<tblUser> tblUser = new List<tblUser>();
            tblUser = bLL_User.read1("تعمیرکار");

            comboBoxRepairMan.DataSource = null;
            comboBoxRepairMan.DataSource = tblUser;
            comboBoxRepairMan.DisplayMember = "Family";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

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
        
        private void button7_Click(object sender, EventArgs e)
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
