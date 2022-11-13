using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuseinessEntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLL_UserAccessRoles
    {
        public void create(tblUserAccessRole accessRole)
        {
            DAL_UserAccessRoles dAL = new DAL_UserAccessRoles();
            dAL.create(accessRole);
        }
        public List<tblUserAccessRole> read(int GroupId)
        {
            
            return new DAL_UserAccessRoles().read(GroupId);

        }
        public List<tblUserAccessRole> read()
        {

            return new DAL_UserAccessRoles().read();

        }
        public void update(int id1, tblUserAccessRole tblUserAccessRole)
        {
            DAL_UserAccessRoles dAL = new DAL_UserAccessRoles();

            dAL.update(id1,tblUserAccessRole);

        }
    }
}
