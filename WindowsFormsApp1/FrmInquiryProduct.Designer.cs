
namespace WindowsFormsApp1
{
    partial class FrmInquiryProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxSituation = new System.Windows.Forms.ComboBox();
            this.comboBoxRepairMan = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxAttachments = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxEarnestMoney = new System.Windows.Forms.TextBox();
            this.textBoxDeviceModel = new System.Windows.Forms.TextBox();
            this.textBoxKeepingPlace = new System.Windows.Forms.TextBox();
            this.textBoxMinimumCost = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxFinalCost = new System.Windows.Forms.TextBox();
            this.textBoxProblems = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPartsCost = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.textBoxReceiptNumber = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.textBoxDeliveryDate = new Atf.UI.DateTimeSelector();
            this.textBoxEntryDate = new Atf.UI.DateTimeSelector();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(41, 387);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBoxDescription.Size = new System.Drawing.Size(655, 55);
            this.richTextBoxDescription.TabIndex = 21;
            this.richTextBoxDescription.Text = "";
            // 
            // comboBoxSituation
            // 
            this.comboBoxSituation.FormattingEnabled = true;
            this.comboBoxSituation.Items.AddRange(new object[] {
            "تعمیر نشده",
            "درحال تعمیر ",
            "تعمیر شده"});
            this.comboBoxSituation.Location = new System.Drawing.Point(41, 314);
            this.comboBoxSituation.Name = "comboBoxSituation";
            this.comboBoxSituation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSituation.Size = new System.Drawing.Size(271, 21);
            this.comboBoxSituation.TabIndex = 18;
            this.comboBoxSituation.Text = "تعمیر نشده";
            // 
            // comboBoxRepairMan
            // 
            this.comboBoxRepairMan.FormattingEnabled = true;
            this.comboBoxRepairMan.Location = new System.Drawing.Point(41, 210);
            this.comboBoxRepairMan.Name = "comboBoxRepairMan";
            this.comboBoxRepairMan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxRepairMan.Size = new System.Drawing.Size(270, 21);
            this.comboBoxRepairMan.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(425, 208);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(271, 20);
            this.panel1.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "گارانتی ندارد";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(150, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "گارانتی دارد";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(41, 8);
            this.maskedTextBoxPhoneNumber.Mask = "(9999) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(169, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 2;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(41, 105);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSerialNumber.Size = new System.Drawing.Size(271, 20);
            this.textBoxSerialNumber.TabIndex = 7;
            // 
            // textBoxAttachments
            // 
            this.textBoxAttachments.Location = new System.Drawing.Point(41, 350);
            this.textBoxAttachments.Name = "textBoxAttachments";
            this.textBoxAttachments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAttachments.Size = new System.Drawing.Size(271, 20);
            this.textBoxAttachments.TabIndex = 20;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(425, 108);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxColor.Size = new System.Drawing.Size(271, 20);
            this.textBoxColor.TabIndex = 6;
            // 
            // textBoxEarnestMoney
            // 
            this.textBoxEarnestMoney.Location = new System.Drawing.Point(41, 243);
            this.textBoxEarnestMoney.Name = "textBoxEarnestMoney";
            this.textBoxEarnestMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxEarnestMoney.Size = new System.Drawing.Size(271, 20);
            this.textBoxEarnestMoney.TabIndex = 14;
            // 
            // textBoxDeviceModel
            // 
            this.textBoxDeviceModel.Location = new System.Drawing.Point(41, 73);
            this.textBoxDeviceModel.Name = "textBoxDeviceModel";
            this.textBoxDeviceModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDeviceModel.Size = new System.Drawing.Size(271, 20);
            this.textBoxDeviceModel.TabIndex = 5;
            // 
            // textBoxKeepingPlace
            // 
            this.textBoxKeepingPlace.Location = new System.Drawing.Point(425, 346);
            this.textBoxKeepingPlace.Name = "textBoxKeepingPlace";
            this.textBoxKeepingPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxKeepingPlace.Size = new System.Drawing.Size(271, 20);
            this.textBoxKeepingPlace.TabIndex = 19;
            // 
            // textBoxMinimumCost
            // 
            this.textBoxMinimumCost.Location = new System.Drawing.Point(425, 246);
            this.textBoxMinimumCost.Name = "textBoxMinimumCost";
            this.textBoxMinimumCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMinimumCost.Size = new System.Drawing.Size(271, 20);
            this.textBoxMinimumCost.TabIndex = 13;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(425, 76);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCompanyName.Size = new System.Drawing.Size(271, 20);
            this.textBoxCompanyName.TabIndex = 4;
            // 
            // textBoxFinalCost
            // 
            this.textBoxFinalCost.Location = new System.Drawing.Point(425, 314);
            this.textBoxFinalCost.Name = "textBoxFinalCost";
            this.textBoxFinalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxFinalCost.Size = new System.Drawing.Size(271, 20);
            this.textBoxFinalCost.TabIndex = 17;
            // 
            // textBoxProblems
            // 
            this.textBoxProblems.Location = new System.Drawing.Point(41, 176);
            this.textBoxProblems.Name = "textBoxProblems";
            this.textBoxProblems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxProblems.Size = new System.Drawing.Size(655, 20);
            this.textBoxProblems.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(41, 46);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAddress.Size = new System.Drawing.Size(655, 20);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxPartsCost
            // 
            this.textBoxPartsCost.Location = new System.Drawing.Point(41, 279);
            this.textBoxPartsCost.Name = "textBoxPartsCost";
            this.textBoxPartsCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPartsCost.Size = new System.Drawing.Size(271, 20);
            this.textBoxPartsCost.TabIndex = 16;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(311, 11);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCustomerName.Size = new System.Drawing.Size(180, 20);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(425, 282);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxParts.Size = new System.Drawing.Size(271, 20);
            this.textBoxParts.TabIndex = 15;
            // 
            // textBoxReceiptNumber
            // 
            this.textBoxReceiptNumber.Location = new System.Drawing.Point(570, 11);
            this.textBoxReceiptNumber.Name = "textBoxReceiptNumber";
            this.textBoxReceiptNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxReceiptNumber.Size = new System.Drawing.Size(126, 20);
            this.textBoxReceiptNumber.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(317, 282);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(85, 13);
            this.label26.TabIndex = 42;
            this.label26.Text = "هزینه ی قطعات :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(722, 279);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "قطعات مصرفی :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(346, 211);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label25.Size = new System.Drawing.Size(56, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "تعمیر کار :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 353);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ملحقات :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(718, 213);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "وضعیت گارانتی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 180);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "ایراد از نظر مشتری :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(333, 147);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(69, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "تاریخ تحویل :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 147);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "تاریخ ورود :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(351, 246);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "پرداختی :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 246);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "حداقل هزینه :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(324, 76);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "مدل و مشخصات :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 81);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "شرکت سازنده :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(729, 387);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "توضیحات :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(729, 345);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "محل نگهداری :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(360, 108);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "سریال :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 114);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "رنگ دستگاه :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(329, 314);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "وضعیت تعمیر :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(722, 312);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "هزینه ی نهایی :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 15);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "شماره تماس :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "آدرس :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(497, 15);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "نام مشتری : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "شماره رسید :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "اولین";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(361, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "آخرین";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(240, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "بعدی";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(119, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "قبلی";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.Location = new System.Drawing.Point(724, 0);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(121, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "بروزرسانی";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button6.Location = new System.Drawing.Point(603, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 50);
            this.button6.TabIndex = 1;
            this.button6.Text = "حذف";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button7.Location = new System.Drawing.Point(482, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 50);
            this.button7.TabIndex = 2;
            this.button7.Text = "چاپ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 50);
            this.panel2.TabIndex = 22;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // textBoxDeliveryDate
            // 
            this.textBoxDeliveryDate.Location = new System.Drawing.Point(40, 143);
            this.textBoxDeliveryDate.Name = "textBoxDeliveryDate";
            this.textBoxDeliveryDate.Size = new System.Drawing.Size(271, 21);
            this.textBoxDeliveryDate.TabIndex = 9;
            this.textBoxDeliveryDate.UsePersianFormat = true;
            // 
            // textBoxEntryDate
            // 
            this.textBoxEntryDate.Location = new System.Drawing.Point(425, 143);
            this.textBoxEntryDate.Name = "textBoxEntryDate";
            this.textBoxEntryDate.Size = new System.Drawing.Size(271, 21);
            this.textBoxEntryDate.TabIndex = 8;
            this.textBoxEntryDate.UsePersianFormat = true;
            // 
            // FrmInquiryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.textBoxDeliveryDate);
            this.Controls.Add(this.textBoxEntryDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.comboBoxSituation);
            this.Controls.Add(this.comboBoxRepairMan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.textBoxAttachments);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxEarnestMoney);
            this.Controls.Add(this.textBoxDeviceModel);
            this.Controls.Add(this.textBoxKeepingPlace);
            this.Controls.Add(this.textBoxMinimumCost);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxFinalCost);
            this.Controls.Add(this.textBoxProblems);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPartsCost);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxParts);
            this.Controls.Add(this.textBoxReceiptNumber);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInquiryProduct";
            this.Tag = "frip1";
            this.Text = "InquiryProduct";
            this.Load += new System.EventHandler(this.FrmInquiryProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxSituation;
        private System.Windows.Forms.ComboBox comboBoxRepairMan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxAttachments;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxEarnestMoney;
        private System.Windows.Forms.TextBox textBoxDeviceModel;
        private System.Windows.Forms.TextBox textBoxKeepingPlace;
        private System.Windows.Forms.TextBox textBoxMinimumCost;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxFinalCost;
        private System.Windows.Forms.TextBox textBoxProblems;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPartsCost;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.TextBox textBoxReceiptNumber;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Atf.UI.DateTimeSelector textBoxDeliveryDate;
        private Atf.UI.DateTimeSelector textBoxEntryDate;
    }
}