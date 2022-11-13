using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuseinessEntityLayer;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class DAL_User
    {
        public void create(tblUser ent)
        {
            DREntities db1 = new DREntities();
            db1.tblUsers.Add(ent);
            db1.SaveChanges();
        }
        public List<tblUser> read(string s)
        {
            DREntities dR = new DREntities();
            var q = dR.tblUsers.Where(i => i.Name.Contains(s) || i.Family.Contains(s)).ToList();
            return q;
        }
        /// <summary>
        /// for select rapairman in addproduct form
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<tblUser> read1(string s)
        {
            DREntities dR = new DREntities();
            var q = dR.tblUsers.Where(i => i.Post.Contains(s) ).ToList();
            return q;
        }
        public List<tblUser> read()
        {
            DREntities dR = new DREntities();
            var q = dR.tblUsers.Where(i=>i.Status==true).ToList();
            return q;
        }
        public tblUser read(int id)
        {
            DREntities dR = new DREntities();
            var q = dR.tblUsers.Where(i=>i.ID==id).ToList();
            return q.FirstOrDefault();
        }
        public List<tblUser> checkpass(string user,string pass)
        {
            var q = new DREntities().tblUsers.Where(i => i.UserName == user && i.Password == pass).ToList();
            return q;
        }
        public void update(int id1, tblUser tblUser)
        {
            DREntities db1 = new DREntities();
            tblUser tbl = new tblUser();
            var q1 = db1.tblUsers.Where(i => i.UserGroupID == 1);
            if (q1.Count() > 1)
            {
                var q = db1.tblUsers.Where(i => i.ID == id1);
                if (q.Count() == 1)
                {
                    tbl = q.Single();
                    tbl.Name = tblUser.Name;
                    tbl.Family = tblUser.Family;
                    tbl.Password = tblUser.Password;
                    tbl.Post = tblUser.Post;
                    tbl.Status = tblUser.Status;
                    tbl.UserGroupID = tblUser.UserGroupID;
                    tbl.UserName = tblUser.UserName;
                    db1.SaveChanges();
                }
            }


        }

    }
}
