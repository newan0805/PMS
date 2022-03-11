
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class order
    {

        public String code { get; set; }

        public String cname { get; set; }

        public String address { get; set; }

        public int qty { get; set; }
        

        public double total { get; set; }

        public int ordid { get; set; }

        public int insert()
        {
            try
            {
                string sql = "INSERT INTO Order_tbl VALUES ('" + code + "','" + cname + "','" + address + "','" + qty + "','" + total + "')";
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
                string sql = "SELECT * FROM Order_tbl";
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

                string sql = "SELECT * FROM Order_tbl WHERE Order_ID = " + ordid ;
                DBOperations db = new DBOperations();
                DataSet ds = db.Execsearch(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    code = ds.Tables[0].Rows[0][1].ToString();
                    cname = ds.Tables[0].Rows[0][1].ToString();
                    address = ds.Tables[0].Rows[0][1].ToString();
                    qty = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                    total = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                   


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
                string sql = "UPDATE Order_tbl SET Flower_code = '" + code + "', Customer_name= '" + cname + "', Address = '" + address + "', Quantity = '" + qty + "', Total = '" + total + "' WHERE Order_ID = '" + ordid ;
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
                string sql = "DELETE FROM Order_tbl where Oder_ID=" + ordid;
                return new DBOperations().Execquery(sql);

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}