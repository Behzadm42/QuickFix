using BuseinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmManageGroup : Form
    {
        public FrmManageGroup()
        {
            InitializeComponent();
        }
        int id = 0;
        private void FrmAccounts_Load(object sender, EventArgs e)
        {
            //for combo box
            BLL_UserGroup bLL_UserGroup = new BLL_UserGroup();
            var q1 = bLL_UserGroup.read();
            guna2ComboBox1.DataSource = q1;
            guna2ComboBox1.DisplayMember = "GroupTitle";
            guna2ComboBox1.ValueMember = "ID";
            //for load all forms
            int index = DGV.Rows.Add();
            FrmInquiryProduct fr = new FrmInquiryProduct();
            DGV.Rows[index].Cells["SectionID"].Value = fr.Tag;
            DGV.Rows[index].Cells["SectionName"].Value = fr.Text;
            DGV.Rows[index].Cells["Row"].Value = index + 1;
            index = DGV.Rows.Add();
            FrmSetting fr2 = new FrmSetting();
            DGV.Rows[index].Cells["SectionID"].Value = fr2.Tag;
            DGV.Rows[index].Cells["SectionName"].Value = fr2.Text;
            DGV.Rows[index].Cells["Row"].Value = index + 1;
            //index = DGV.Rows.Add();
            //FrmContact fr3 = new FrmContact();
            //DGV.Rows[index].Cells["SectionID"].Value = fr3.Tag;
            //DGV.Rows[index].Cells["SectionName"].Value = fr3.Text;
            //DGV.Rows[index].Cells["Row"].Value = index + 1;
            //index = DGV.Rows.Add();
            //FrmPrudact fr4 = new FrmPrudact();
            //DGV.Rows[index].Cells["SectionID"].Value = fr4.Tag;
            //DGV.Rows[index].Cells["SectionName"].Value = fr4.Text;
            //DGV.Rows[index].Cells["Row"].Value = index + 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL_UserGroup bLL_UserGroup = new BLL_UserGroup();
            BLL_UserAccessRoles bLL_UserAccessRoles = new BLL_UserAccessRoles();
            tblUserGroup entGrp = new tblUserGroup();
            entGrp.GroupTitle = txtGroupTitle.Text;
            bLL_UserGroup.create(entGrp);
            for (int i = 0; i < DGV.RowCount; i++)
            {
                tblUserAccessRole ent = new tblUserAccessRole();
                ent.UserGroupID = entGrp.ID;
                ent.Section = DGV.Rows[i].Cells["SectionID"].Value.ToString();
                ent.IsSave = (bool?)DGV.Rows[i].Cells["IsSave"].Value;
                ent.IsEdit = (bool?)DGV.Rows[i].Cells["IsEdit"].Value;
                ent.IsDelete = (bool?)DGV.Rows[i].Cells["IsDelete"].Value;
                ent.IsSearch = (bool?)DGV.Rows[i].Cells["IsSearch"].Value;
                bLL_UserAccessRoles.create(ent);
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            BLL_UserGroup bLL_UserGroup = new BLL_UserGroup();
            BLL_UserAccessRoles bLL_UserAccessRoles = new BLL_UserAccessRoles();
            tblUserGroup entGrp = new tblUserGroup();
            var q1 = guna2ComboBox1.SelectedItem;
            string s = (q1 as tblUserGroup).GroupTitle;
            entGrp = bLL_UserGroup.read(s);


            id = entGrp.ID;

            var q = bLL_UserAccessRoles.read(id);
            if (q.Count != 0)
            {
                int i = 0;
                foreach (var item in q)
                {
                    DGV.Rows[i].Cells["ID"].Value = item.ID;
                    DGV.Rows[i].Cells["SectionID"].Value = item.Section;
                    DGV.Rows[i].Cells["IsSave"].Value = item.IsSave;
                    DGV.Rows[i].Cells["IsEdit"].Value = item.IsEdit;
                    DGV.Rows[i].Cells["IsDelete"].Value = item.IsDelete;
                    DGV.Rows[i].Cells["IsSearch"].Value = item.IsSearch;
                    i++;
                }
            }
            else
            {
                MessageBox.Show("برای این گروه دسترسی تعریف نشده");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            BLL_UserAccessRoles bLL_UserAccessRoles = new BLL_UserAccessRoles();

            for (int i = 0; i < DGV.RowCount; i++)
            {
                tblUserAccessRole ent = new tblUserAccessRole();
                ent.UserGroupID = id;
                ent.Section = DGV.Rows[i].Cells["SectionID"].Value.ToString();
                ent.IsSave = (bool?)DGV.Rows[i].Cells["IsSave"].Value;
                ent.IsEdit = (bool?)DGV.Rows[i].Cells["IsEdit"].Value;
                ent.IsDelete = (bool?)DGV.Rows[i].Cells["IsDelete"].Value;
                ent.IsSearch = (bool?)DGV.Rows[i].Cells["IsSearch"].Value;
                int id1 = Convert.ToInt32(DGV.Rows[i].Cells["ID"].Value);
                bLL_UserAccessRoles.update(id1, ent);
            }
        }
    }
}
