using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class product
    {
        public int pid { get; set; }

        public String ftype { get; set; }

        public String pname { get; set; }

        public String pcode { get; set; }



        public int qty { get; set; }

        public double price { get; set; }

        public String supplier { get; set; }

        public int insert()
        {
            try
            {
                string sql = "INSERT INTO productt_tbl VALUES (" + pid + ",'" + ftype + "','" + pname + "','" + pcode + "'," + qty + "," + price + ",'" + supplier + "')";
                DBOperations db = new DBOperations();

                return db.Execquery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataSet select()
        {
            try
            {
                string sql = "SELECT * FROM productt_tbl";
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

                string sql = "SELECT * FROM productt_tbl WHERE product_ID = " + pid;
                DBOperations db = new DBOperations();
                DataSet ds = db.Execsearch(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ftype = ds.Tables[0].Rows[0][1].ToString();
                    pname = ds.Tables[0].Rows[0][1].ToString();
                    pcode = ds.Tables[0].Rows[0][1].ToString();

                    qty = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                    price = Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString());
                    supplier = ds.Tables[0].Rows[0][4].ToString();


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
                string sql = "UPDATE productt_tbl SET Flower_type='" + ftype + "',product_name='" + pname + "',product_code='" + pcode + "',Qunatity=" + qty + ",Price=" + pcode + ",Supplier='" + supplier + "' WHERE product_ID=" + pid;
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
                string sql = "DELETE FROM productt_tbl where product_ID=" + pid;
                return new DBOperations().Execquery(sql);

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet stock()
        {

            try{
                string sql = "SELECT Flower_type,product_code,Quantity FROM productt_tbl ";
                return DBOperations.ExecSelectQuery(sql);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool searchstock()
        {
            try
            {

                string sql = "SELECT Flower_type,Quantity FROM productt_tbl WHERE product_code = " + pcode;
                DBOperations db = new DBOperations();
                DataSet ds = db.Execsearch(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ftype = ds.Tables[0].Rows[0][1].ToString();
                    qty = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                   


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


    }
}



