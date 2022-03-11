using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class DBOperations
    {
        /*private static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4FFQ2MH\\SQLEXPRESS;Initial Catalog=Black lotus;Integrated Security=True");*/
        private static SqlConnection conn = new SqlConnection("Data Source=RUWAN\\NK;Initial Catalog=Product_Db;Integrated Security=True");

        public int Execquery(string sql)
        {
            int x;
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);


                x = com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return x;
        }

        public static DataSet ExecSelectQuery(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
        public DataTable Execlogin(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataSet Execsearch(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
            catch (Exception  
           )
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

       
    }
}
