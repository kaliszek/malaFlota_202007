using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XRodzaj : DBSQL

    {
        public string NameSQL = "Rodzaj";
        public int Id_Rodzaj { get; set; }
        public string Rodzaj_Nazwa { get; set; }

        protected override void FillListRows(System.Data.SqlClient.SqlDataReader rdrListRows)
        {
            if (rdrListRows.Read())
            {
                Id_Rodzaj = Narzedzia.IsNullInt(rdrListRows["ID_RODZAJ"]);
                Rodzaj_Nazwa = Narzedzia.IsNullString(rdrListRows["RODZAJ_NAZWA"]);
            }

        }

        public XRodzaj(int iii)
        {
            string sQuery = string.Format("select * from {0} where ID_Rodzaj={1}", NameSQL, iii);
            GetRecord(sQuery);
        }

        public XRodzaj()
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
