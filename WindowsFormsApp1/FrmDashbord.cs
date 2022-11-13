using BuseinessEntityLayer;
using System;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WindowsFormsApp1
{
    public partial class FrmDashbord : Form
    {

        public FrmDashbord()
        {
            InitializeComponent();
        }

        private void FrmDashbord_Load(object sender, EventArgs e)
        {
            BLL_Product bLL_Product = new BLL_Product();
            var q1 = bLL_Product.read();
            int s1 = 0, s2 = 0, s3 = 0;
            if (q1.Count != 0)
            {
                foreach (var item in q1)
                {
                    if (item.Situation == "تعمیر شده")
                        s1++;
                    else if (item.Situation == "تعمیر نشده")
                        s2++;
                    else
                        s3++;
                }
                // s = s2 + s3; 
                guna2CircleProgressBar1.Value = s1 * 100 / q1.Count;
                guna2CircleProgressBar2.Value = s3 * 100 / q1.Count;
                guna2CircleProgressBar3.Value = s2 * 100 / q1.Count;
            }
            else
            {
                guna2CircleProgressBar1.Value = 0;
                guna2CircleProgressBar2.Value = 0;
                guna2CircleProgressBar3.Value = 0;

            }

            #region last product
            int lastid = bLL_Product.getid();
            if (lastid != -1)
            {
                var q = bLL_Product.read(lastid);
                textBoxReceiptNumber.Text = q.ReceiptNumber.ToString();
                textBoxCustomerName.Text = q.CustomerName;
                maskedTextBoxPhoneNumber.Text = q.PhoneNumber;
                textBoxCompanyName.Text = q.CompanyName;
                textBoxDeviceModel.Text = q.DeviceModel;
                textBoxColor.Text = q.Color;
                textBoxSerialNumber.Text = q.SerialNumber;
                textBoxEntryDate.Text = q.EntryDate;
                textBoxProblems.Text = q.Problems;
            }
            #endregion

        }


    }
}
