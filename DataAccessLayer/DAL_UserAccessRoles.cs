using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuseinessEntityLayer;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class DAL_UserAccessRoles
    {
        public void create(tblUserAccessRole ent)
        {
            DREntities db1 = new DREntities();
            db1.tblUserAccessRoles.Add(ent);
            db1.SaveChanges();
        }
        public List<tblUserAccessRole> read(int GroupId)
        {
            DREntities dREntities = new DREntities();
            var q = dREntities.tblUserAccessRoles.Where(i => i.UserGroupID == GroupId).ToList();
            return q;
        }
        public List<tblUserAccessRole> read()
        {
            DREntities dREntities = new DREntities();
            var q = dREntities.tblUserAccessRoles.ToList();
            return q;
        }
        public void update(int id1, tblUserAccessRole tblUserAccessRole)
        {
            DREntities db1 = new DREntities();
            tblUserAccessRole tbl = new tblUserAccessRole();

            var q = db1.tblUserAccessRoles.Where(i => i.ID == id1);
            if (q.Count() == 1)
            {
                tbl = q.Single();
                tbl.Section = tblUserAccessRole.Section;
                tbl.UserGroupID = tblUserAccessRole.UserGroupID;
                tbl.IsDelete = tblUserAccessRole.IsDelete;
                tbl.IsEdit = tblUserAccessRole.IsEdit;
                tbl.IsSave= tblUserAccessRole.IsSave;
                tbl.IsSearch = tblUserAccessRole.IsSearch;
                

                db1.SaveChanges();


            }


        }
    }
}
