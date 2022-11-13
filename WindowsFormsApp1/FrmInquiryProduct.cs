using BuseinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace WindowsFormsApp1
{
    public partial class FrmInquiryProduct : Form
    {
        public tblUserAccessRole _AccessRole = new tblUserAccessRole();
        public FrmInquiryProduct()
        {
            InitializeComponent();
        }
        public int count;
        public int[] array;
        public int index;
        void writeoncotrlos(tblProduct tblProduct)
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
        private void FrmInquiryProduct_Load(object sender, EventArgs e)
        {
            if (_AccessRole.IsDelete == true)
                button6.Enabled = true;
            else
                button6.Enabled = false;

            BLL_Product bLL_Product = new BLL_Product();
            var q1 = bLL_Product.read();
            count = 0;
            int n = 0;
            array = new int[q1.Count];
            foreach (var item in q1)
            {
                array[n] = item.ID;
                n++;
                count++;
            }
            count--;
            index = 0;
            var q = bLL_Product.read(array[0]);
            tblProduct tblProduct = new tblProduct();
            tblProduct = q;
            writeoncotrlos(tblProduct);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            if (index < count)
            {
                index++;
            }


            var q = bLL_Product.read(array[index]);
            writeoncotrlos(q);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            if (index > 0)
            {
                index--;
            }


            var q = bLL_Product.read(array[index]);
            writeoncotrlos(q);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            index = 0;
            var q = bLL_Product.read(array[index]);
            writeoncotrlos(q);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            index = count;
            var q = bLL_Product.read(array[index]);
            writeoncotrlos(q);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            tblProduct tblProduct = new tblProduct();
            tblProduct = readcontolrs();
            bLL_Product.update(array[index], tblProduct);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("ایا مطمین هستید میخواهید حذف کنید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d.ToString() == "Yes")
            {

                BLL_Product bLL_Product = new BLL_Product();
                tblProduct tblProduct = new tblProduct();
                tblProduct = readcontolrs();
                bLL_Product.delete(array[index]);
                for (int j = index; j < count; j++)
                    array[j] = array[j + 1];
                count--;
                if (count == 0)
                {
                    MessageBox.Show("هیچ داده ای برای نمایش وجود ندارد ");
                    this.Close();
                }
                this.Refresh();
                this.Controls.Clear();
                this.InitializeComponent();

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            var q = bLL_Product.read(array[index]);
            var report = new StiReport();
            string path1 = Application.StartupPath + "\\Report\\Report.mrt";
            report.Load(path1);
            report.Compile();
            report.RegBusinessObject("a", q);
            report.Show();
        }
    }
}
