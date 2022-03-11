using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;


namespace BusinessLayer
{
    public class Customer
    {
        public String name { get; set; }

            public int contactno { get; set; }

            public String address { get; set; }

            public String email { get; set; }

            public int id { get; set; }

        public int insert()
            {
                try
                {
                string sql = "INSERT INTO Customer_tbl VALUES ('" + name + "','" + contactno + "','" + address + "','" + email + "')";
                DBOperations db = new DBOperations();

                return db.Execquery(sql);
            }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        public DataSet viewAll()
        {
            try
            {
                string sql = "SELECT * FROM Customer_tbl";
                return DBOperations.ExecSelectQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public bool search()
        {
            try
            {
                
                    string sql = "SELECT * FROM Customer_tbl WHERE Customer_ID = " + id;
                    DBOperations db = new DBOperations();
                    DataSet ds = db.Execsearch(sql);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        name = ds.Tables[0].Rows[0][1].ToString();
                        contactno = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                        address = ds.Tables[0].Rows[0][3].ToString();
                        email = ds.Tables[0].Rows[0][4].ToString();
                       

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        public int Update()
        {
            try
            {
                string sql = "UPDATE Customer_tbl SET Customer_name='" + name + "', Contact_no=" + contactno + ", Address='" + address + "', Email='" + email + "' WHERE Customer_ID=" + id;
                return new DBOperations().Execquery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int Delete()
        {
            try
            {
                string sql = "DELETE FROM Customer_tbl where Customer_ID=" + id;
                return new DBOperations().Execquery(sql);

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}



