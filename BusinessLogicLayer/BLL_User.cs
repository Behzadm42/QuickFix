using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuseinessEntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLL_User
    {
        public void create(tblUser ent)
        {
            DAL_User dAL = new DAL_User();
            dAL.create(ent);
        }
        public List<tblUser> read(string s)
        {
            DAL_User dAL = new DAL_User();
            return dAL.read(s);

        }
        public List<tblUser> read()
        {
            DAL_User dAL = new DAL_User();
            return dAL.read();
        }
        public tblUser read(int id)
        {
            DAL_User dAL = new DAL_User();
            return dAL.read(id);
        }
        public List<tblUser> read1(string s)
        {
            DAL_User dAL = new DAL_User();
            return dAL.read1(s);
        }

        public List<tblUser> checkpass(string user, string pass)
        {
            DAL_User dAL = new DAL_User();
            return dAL.checkpass(user,pass);
        }
        public void update(int id1, tblUser tblUser)
        {
            DAL_User dAL_User = new DAL_User();
            dAL_User.update(id1, tblUser);
        }
    }
}
