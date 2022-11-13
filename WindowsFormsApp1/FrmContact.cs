using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FrmContact : Form
    {
        public FrmContact()
        {
            InitializeComponent();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
       
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("behzadmovaseghbn1@gmail.com");
                msg.To.Add("behzadmovasegh@ymail.com");
                msg.Body = guna2TextBox1.Text+"\n"+ guna2TextBox2.Text + "\n" + guna2TextBox3.Text + "\n\n" + guna2TextBox4.Text ;
                msg.Subject = "suggestion";
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "behzadmovaseghbn1@gmail.com";
                ntcd.Password = "gvoxwqmejosxyqpt";
                smtp.Credentials = ntcd;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(msg);
                
                MessageBox.Show("پیام شما با موفقیت ارسال شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
