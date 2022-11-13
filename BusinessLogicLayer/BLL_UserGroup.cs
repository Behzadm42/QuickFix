using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuseinessEntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class BLL_UserGroup
    {
        public void create(tblUserGroup Grp)
        {
            DAL_UserGroup dAL = new DAL_UserGroup();
            dAL.create(Grp);
        }
        public List<tblUserGroup> read()
        {
            return new DAL_UserGroup().read();
        }
        public tblUserGroup read(int id)
        {
            return new DAL_UserGroup().read(id);
        }
        public tblUserGroup read(string s)
        {
            return new DAL_UserGroup().read(s);
        }
    }
}
