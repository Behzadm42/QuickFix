using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuseinessEntityLayer
{
   public  class cls_UserData
    {
        public static int UserID { get; set; }
        public static List<tblUserAccessRole> AccessRole { get; set; }
    }
}
