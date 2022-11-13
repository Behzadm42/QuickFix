using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuseinessEntityLayer;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class DAL_UserGroup
    {
        public void create(tblUserGroup ent)
        {
            DREntities db1 = new DREntities();
            db1.tblUserGroups.Add(ent);
            db1.SaveChanges();
        }
        public List<tblUserGroup> read()
        {
            DREntities dREntities = new DREntities();
            var q = dREntities.tblUserGroups.ToList();
            return q;
        }
        public tblUserGroup read(int id)
        {
            DREntities dREntities = new DREntities();
            var q = dREntities.tblUserGroups.Where(i=>i.ID==id).ToList();
            return q.FirstOrDefault();
        }
        public tblUserGroup read(string s)
        {
            DREntities dREntities = new DREntities();
            var q = dREntities.tblUserGroups.Where(i => i.GroupTitle.ToString() == s).ToList();
            return q.FirstOrDefault();
        }
    }
}
