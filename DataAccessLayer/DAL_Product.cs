using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuseinessEntityLayer;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DAL_Product
    {
        public void create(tblProduct ent)
        {
            DREntities db1 = new DREntities();
            db1.tblProducts.Add(ent);
            db1.SaveChanges();
        }
        public List<tblProduct> read(int n1, string s1, string s2, string s3)
        {
            DREntities dR = new DREntities();
            var q = dR.spSearch(n1, s1, s2, s3).ToList();
            List<tblProduct> tblProduct = new List<tblProduct>();
            foreach (var item in q)
            {
                tblProduct tblProduct1 = new tblProduct()
                {
                    ReceiptNumber = item.ReceiptNumber,
                    CustomerName = item.CustomerName,
                    Address = item.Address,
                    PhoneNumber = item.PhoneNumber,
                    CompanyName = item.CompanyName,
                    DeviceModel = item.DeviceModel,
                    Color = item.Color,
                    SerialNumber = item.SerialNumber,
                    EntryDate = item.EntryDate,
                    DeliveryDate = item.DeliveryDate,
                    Problems = item.Problems,
                    MinimumCost = item.MinimumCost,
                    EarnestMoney = item.EarnestMoney,
                    Attachments = item.Attachments,
                    RepairMan = item.RepairMan,
                    Parts = item.Parts,
                    PartsCost = item.PartsCost,
                    FinalCost = item.FinalCost,
                    Situation = item.Situation,
                    Description = item.Description,
                    KeepingPlace = item.KeepingPlace,
                    Warranty = item.Warranty,
                    ID = item.ID
                };
                tblProduct.Add(tblProduct1);
            }
            return tblProduct;

        }
        public List<tblProduct> read()
        {
            DREntities dR = new DREntities();
            var q = dR.tblProducts.ToList();
            return q;
        }
        public List<tblProduct> read(string s)
        {
            DREntities dR = new DREntities();
            var q = dR.tblProducts.Where(i => i.CustomerName.Contains(s) || i.CompanyName.Contains(s) || i.DeviceModel.Contains(s)).ToList();
            return q;
        }
        public tblProduct read(int id)
        {
            DREntities dR = new DREntities();
            var q = dR.tblProducts.Where(i => i.ID == id);
            return q.FirstOrDefault();
        }
        public int getid()
        {
            DREntities dR = new DREntities();
            var q = dR.tblProducts.ToList();
            if (q.Count != 0)
                return q.LastOrDefault().ID;
            else
                return -1;
        }
        public void update(int id1, tblProduct tblProduct)
        {
            DREntities db1 = new DREntities();
            tblProduct tbl = new tblProduct();

            var q = db1.tblProducts.Where(i => i.ID == id1);
            if (q.Count() == 1)
            {
                tbl = q.Single();
                tbl.ReceiptNumber = tblProduct.ReceiptNumber;
                tbl.CustomerName = tblProduct.CustomerName;
                tbl.Address = tblProduct.Address;
                tbl.PhoneNumber = tblProduct.PhoneNumber;
                tbl.CompanyName = tblProduct.CompanyName;
                tbl.DeviceModel = tblProduct.DeviceModel;
                tbl.Color = tblProduct.Color;
                tbl.SerialNumber = tblProduct.SerialNumber;
                tbl.EntryDate = tblProduct.EntryDate;
                tbl.DeliveryDate = tblProduct.DeliveryDate;
                tbl.Problems = tblProduct.Problems;
                tbl.MinimumCost = tblProduct.MinimumCost;
                tbl.EarnestMoney = tblProduct.EarnestMoney;
                tbl.Attachments = tblProduct.Attachments;
                tbl.RepairMan = tblProduct.RepairMan;
                tbl.Parts = tblProduct.Parts;
                tbl.PartsCost = tblProduct.PartsCost;
                tbl.FinalCost = tblProduct.FinalCost;
                tbl.Situation = tblProduct.Situation;
                tbl.Description = tblProduct.Description;
                tbl.KeepingPlace = tblProduct.KeepingPlace;
                if (tblProduct.Warranty == true)
                    tbl.Warranty = true;
                else
                    tbl.Warranty = false;
                db1.SaveChanges();
            }


        }
        public void delete(int id1)
        {
            DREntities db1 = new DREntities();

            var q = db1.tblProducts.Where(i => i.ID == id1);
            if (q.Single() != null)//q.count==1
            {
                db1.tblProducts.Remove(q.FirstOrDefault());
            }

            db1.SaveChanges();
        }
        /// <summary>
        /// for backup and restore database
        /// </summary>
        /// <param name="s"></param>
        public void backup(string s)
        {
            SqlConnection SqlConnection = new SqlConnection(@"data source=.;initial catalog=Device_Repair;integrated security=True");
            string database = SqlConnection.Database.ToString();
            string cmd = "BACKUP DATABASE [" + database + "] TO DISK ='" + s + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".mdf'";
            SqlCommand sqlCommand = new SqlCommand(cmd, SqlConnection);
            if (SqlConnection.State == ConnectionState.Closed)
                SqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }
        public bool CheckDatabase(string databaseName)
        {
            // You know it's a string, use var
            var connString = "Data Source=.;Integrated Security=True;database=master";
            // Note: It's better to take the connection string from the config file.

            var cmdText = "select count(*) from master.dbo.sysdatabases where name=@Device_Repair";

            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    // Use parameters to protect against Sql Injection
                    sqlCmd.Parameters.Add("@Device_Repair", System.Data.SqlDbType.NVarChar).Value = databaseName;

                    // Open the connection as late as possible
                    sqlConnection.Open();
                    // count(*) will always return an int, so it's safe to use Convert.ToInt32
                    return Convert.ToInt32(sqlCmd.ExecuteScalar()) == 1;
                }
            }

        }
        public void restore(string s)
        {

            SqlConnection SqlConnection = new SqlConnection(@"Data Source=.;Initial Catalog=Device_Repair;Integrated Security=True");
            string database = SqlConnection.Database.ToString();
            if (SqlConnection.State == ConnectionState.Closed)
                SqlConnection.Open();
            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + s + "' WITH REPLACE ;";
                SqlCommand cmd2 = new SqlCommand(str2, SqlConnection);
                cmd2.ExecuteNonQuery();
                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, SqlConnection);
                cmd3.ExecuteNonQuery();
            }
            catch
            { }


        }
        public void createdatabase()
        {

            //if (CheckDatabase("Device_Repair"))
            //{
            //    String str,str1;
            //    SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
            //    str1 = "DROP DATABASE Device_Repair";
            //    SqlCommand myCommand1 = new SqlCommand(str1, myConn);
            //    try
            //    {
            //        myConn.Open();
            //        myCommand1.ExecuteNonQuery();
            //    }
            //    catch 
            //    {
            //    }
            //    str = "CREATE DATABASE Device_Repair";

            //    SqlCommand myCommand = new SqlCommand(str, myConn);
            //    try
            //    {
            //        myConn.Open();
            //        myCommand.ExecuteNonQuery();
            //    }
            //    catch 
            //    {
            //    }
            //    finally
            //    {
            //        if (myConn.State == ConnectionState.Open)
            //        {
            //            myConn.Close();
            //        }
            //    }
            //}

            String str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            str = "CREATE DATABASE Device_Repair";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }

        }
        public void deleteall()
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source=.;Initial Catalog=Device_Repair;Integrated Security=True");
            string database = SqlConnection.Database.ToString();
            if (SqlConnection.State == ConnectionState.Closed)
                SqlConnection.Open();
            try
            {
                string str1 = ("DELETE FROM tblProduct");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
            }
            catch
            { }
            try
            {
                string str1 = ("DBCC CHECKIDENT(tblProduct, RESEED, 0)");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
            }
            catch
            { }
            try
            {
                string str1 = ("DELETE FROM tblUserAccessRole");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
            }
            catch
            { }
            try
            {
                string str1 = ("DBCC CHECKIDENT(tblUserAccessRole, RESEED, 0)");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
            }
            catch
            { }
            try
            {
                string str1 = ("DELETE FROM tblUserGroup");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
            }
            catch
            { }
            try
            {
                string str1 = ("DBCC CHECKIDENT(tblUserGroup, RESEED, 0)");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
            }
            catch
            { }
            try
            {
                string str1 = ("DELETE FROM tblUsers");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
            }
            catch
            { }
            try
            {
                string str1 = ("DBCC CHECKIDENT(tblUsers, RESEED, 0)");
                SqlCommand cmd1 = new SqlCommand(str1, SqlConnection);
                cmd1.ExecuteNonQuery();
            }
            catch
            { }
            finally
            {
                if (SqlConnection.State == ConnectionState.Open)
                {
                    SqlConnection.Close();
                }
            }
        }
    }

}
