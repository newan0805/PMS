using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;



namespace BusinessLayer
{
    public class users
    {
        public int id { get; set; }

        public String username { get; set; }

        public string password { get; set; }

        public String type { get; set; }

        public int insert()
        {
            try {
                string sql = "INSERT INTO userr_tbl VALUES ('" +username+ "'," +password+ ",'"+type+"')";
                DBOperations db = new DBOperations();

                return db.Execquery(sql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
         
        public bool login()
        {
            try
            {
                string sql = "SELECT * FROM user_table WHERE  username = '" + username + "' AND password = '" + password + "' AND userType = '" + type + "' ";

                DBOperations db = new DBOperations();
                DataTable dt = new DataTable();
                dt = db.Execlogin(sql);
                if (dt.Rows.Count > 0)
                {
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

        public DataSet viewAll()
        {
            try
            {
                string sql = "SELECT * FROM userr_tbl";
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

                string sql = "SELECT * FROM user_table WHERE id = " + id;
                DBOperations db = new DBOperations();
                DataSet ds = db.Execsearch(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    username = ds.Tables[0].Rows[0][1].ToString();
                    password = ds.Tables[0].Rows[0][2].ToString();
                    type = ds.Tables[0].Rows[0][3].ToString();

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
                string sql = "UPDATE userr_tbl SET username='" + username + "',password=" + password + ",profession='" + type + "' WHERE id=" + id;
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
                string sql = "DELETE FROM userr_tbl where id=" + id;
                return new DBOperations().Execquery(sql);

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}



