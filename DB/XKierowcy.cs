using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XKierowcy :DBSQL
    {
        public List<XKierowca> Lista = new List<XKierowca>();
        /// <summary>
        /// Zwraca liste kierowców
        /// </summary>
        /// <returns>zwrócona ilosc</returns>
        public int DajListe()
        {
            Lista.Clear();

            int ile_kierowcow = GetRecords( "select * from kierowca");

            return ile_kierowcow;
        }

        protected override void FillListRows(SqlDataReader rdrListRows)
        {
            
            
                XKierowca k = new XKierowca();
                k.Nazwisko = rdrListRows["NAZWISKO"].ToString();
                k.Imie = rdrListRows["IMIE"].ToString();
                k.Pesel = rdrListRows["PESEL"].ToString();
                k.Miasto = rdrListRows["MIASTO"].ToString();
                k.Ulica = rdrListRows["ULICA"].ToString();
                k.KodP = rdrListRows["KODP"].ToString();
                k.Poczta = rdrListRows["POCZTA"].ToString();
                k.Nr_Domu = rdrListRows["NR_DOMU"].ToString();
                k.Nr_Lokalu = rdrListRows["NR_LOKALU"].ToString();
                k.Data_Ur = Narzedzia.IsNullDateTime(rdrListRows["DATA_UR"]);
                k.Data_Bad_Lek = Narzedzia.IsNullDateTime(rdrListRows["DATA_BAD_LEK"]);
                k.Tel1 = rdrListRows["TEL1"].ToString();
                k.Tel2 = rdrListRows["TEL2"].ToString();
                k.KatA = Narzedzia.IsNullBool(rdrListRows["KATA"]);
                k.KatB = Narzedzia.IsNullBool(rdrListRows["KATB"]);
                k.KatC = Narzedzia.IsNullBool(rdrListRows["KATC"]);
                k.KatD = Narzedzia.IsNullBool(rdrListRows["KATD"]);
                k.ID = int.Parse(rdrListRows["ID_KIEROWCA"].ToString());

                Lista.Add(k);
            
        }
    
    }







}


