using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DB
{
    public class DBSQL
    {
        public DBSQL()
        {

        }
        protected virtual void FillListRows(SqlDataReader rdrListRows)
        {

        }


        public void GetRecord(string sQuery)
        {
            SqlDataReader ret = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(KonfiguracjaGlobalna.ConnectingString);
                conn.Open();
                cmd = new SqlCommand(sQuery, conn);
                ret = cmd.ExecuteReader();
                FillListRows(ret);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (ret != null)
                    ret.Dispose();
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null)
                    conn.Dispose();
            };
        }
        public int GetRecords(string sQuery)
        {
            SqlDataReader reader = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            int ret = 0;
            try
            {
                conn = new SqlConnection(KonfiguracjaGlobalna.ConnectingString);
                conn.Open();
                cmd = new SqlCommand(sQuery, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FillListRows(reader);
                    ret++;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null)
                    conn.Dispose();
            };
            return ret;
        }

        public int ExecuteSQLIDENTITY(string sQuery)
        {
            SqlDataReader rdr = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            int ret = 0;
            string s = string.Format("{0}; select  @@IDENTITY", sQuery);

            try
            {
                conn = new SqlConnection(KonfiguracjaGlobalna.ConnectingString);
                conn.Open();
                cmd = new SqlCommand(s, conn);
                object r = cmd.ExecuteScalar();
                if (r != null)
                    ret = Convert.ToInt32(r);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (rdr != null)
                    rdr.Dispose();
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null)
                    conn.Dispose();
            };
            return ret;
        }

        public void ExecuteSQL(string sQuery)
        {
            SqlDataReader rdr = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(KonfiguracjaGlobalna.ConnectingString);
                conn.Open();
                cmd = new SqlCommand(sQuery, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (rdr != null)
                    rdr.Dispose();
                if (cmd != null)
                    cmd.Dispose();
                if (conn != null)
                    conn.Dispose();
            };
        }

    }
}
