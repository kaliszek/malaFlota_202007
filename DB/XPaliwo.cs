using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XPaliwo : DBSQL
    {
        public string NameSQL = "Paliwo";
        public int Id_Paliwo { get; set; }
        public string Paliwo_Nazwa { get; set; }

        protected override void FillListRows(System.Data.SqlClient.SqlDataReader rdrListRows)
        {
            if (rdrListRows.Read())
            {
                Id_Paliwo = Narzedzia.IsNullInt(rdrListRows["ID_PALIWO"]);
                Paliwo_Nazwa = Narzedzia.IsNullString(rdrListRows["PALIWO_NAZWA"]);
            }
            
        }
        
        public XPaliwo(int ii)
        {
            string sQuery = string.Format("select * from {0} where ID_PALIWO={1}", NameSQL, ii);
            GetRecord(sQuery);
        }

        public XPaliwo()
        {


        }
        public void Dopisz()
        {

        }
        public void Popraw()
        {

        }
        public void Usun()
        {
        }

    }
}




