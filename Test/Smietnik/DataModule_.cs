using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{

    public abstract class DataModule_ : IDisposable
    {
        SqlConnection conn;
        SqlCommand cmd;

        protected DataModule_ (string cmdStr, CommandType cmdType)
        {
            conn = new SqlConnection("Data Source=LENOVO;Initial Catalog=db_malaFlota;Integrated Security=False;User ID=sa;Password=;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;");
            cmd =  new SqlCommand(cmdStr, conn);
            cmd.CommandType = cmdType;
        }
        public DataModule_(string spStr)
        {
            conn = new SqlConnection("Data Source=LENOVO;Initial Catalog=db_malaFlota;Integrated Security=False;User ID=sa;Password=;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;");
            cmd = new SqlCommand(spStr, conn);
            cmd.CommandType = CommandType.StoredProcedure;
        }
        
        public void Exec()
        {
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        
        public object ExecS()
        {
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            finally
            {
                conn.Close();
            }
        }
        
        public DataSet GetDS()
        {
            try
            {
                conn.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds);
                return ds;
            }
            finally
            {
                conn.Close();
            }
        }
        
        public DataRow GetRow()
        {
            DataRow res = null;
            DataSet ds = GetDS();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                res = ds.Tables[0].Rows[0];
            return res;
        }
        public SqlParameterCollection Parameters
        {
            get
            {
                return cmd.Parameters;
            }
        }

        public void Dispose()
        {
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }
    }

    public class DBText : DataModule_
    {
        public DBText(string cmdStr)
            : base(cmdStr, CommandType.Text)
        {
        }
    }

    public class DBSp : DataModule_
    {
        public DBSp(string cmdStr)
            : base(cmdStr, CommandType.StoredProcedure)
        {
        }
    }

}
