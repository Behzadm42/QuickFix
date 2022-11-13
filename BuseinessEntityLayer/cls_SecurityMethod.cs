using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuseinessEntityLayer
{
    public  class cls_SecurityMethod
    {
        public cls_SecurityMethod() { }
        public string Encript(String data)
        {
            String ret = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(data));
            return ret;
        }
        public String Decript(String data)
        {
            string ret = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(data));
            return ret;
        }
    }
}
