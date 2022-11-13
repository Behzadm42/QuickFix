using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using BuseinessEntityLayer;

namespace BusinessLogicLayer
{
    public class BLL_Product
    {
        public void create(tblProduct ent)
        {
            DAL_Product dAL = new DAL_Product();
            dAL.create(ent);
        }
        public List<tblProduct> read(int n1, string s1, string s2, string s3)
        {
            DAL_Product dAL = new DAL_Product();
            return dAL.read(n1, s1, s2, s3);

        }
        public List<tblProduct> read()
        {
            DAL_Product dAL = new DAL_Product();
            return dAL.read();

        }
        public List<tblProduct> read(string s)
        {
            DAL_Product dAL = new DAL_Product();
            return dAL.read(s);

        }
        public tblProduct read(int id)
        {
            DAL_Product dAL = new DAL_Product();
            return dAL.read(id);
        }
        public int getid()
        {
            DAL_Product dAL = new DAL_Product();
            return dAL.getid();
        }
        public void update(int id1, tblProduct tblProduct)
        {
            DAL_Product dAL = new DAL_Product();
            dAL.update(id1, tblProduct);

        }
        public void delete(int id1)
        {
            DAL_Product dAL = new DAL_Product();
            dAL.delete(id1);
        }
        /// <summary>
        /// for backup and restore database
        /// </summary>
        /// <param name="s"></param>
        public void backup(string s)
        {
            DAL_Product dAL_Product = new DAL_Product();
            dAL_Product.backup(s);
        }
        public void restore(string s)
        {
            DAL_Product dAL_Product = new DAL_Product();
            dAL_Product.restore(s);
        }
        public bool CheckDatabase(string databaseName)
        {
            DAL_Product dAL_Product = new DAL_Product();
            return dAL_Product.CheckDatabase(databaseName);

        }
        public void createdatabase()
        {
            DAL_Product dAL_Product = new DAL_Product();
            dAL_Product.createdatabase();
        }
        public void deleteall()
        {
            DAL_Product dAL_Product = new DAL_Product();
            dAL_Product.deleteall();
        }
    }
}
