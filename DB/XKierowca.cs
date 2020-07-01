using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    
    public class XKierowca : DBSQL
    {

        public readonly string NameSQL = "Kierowca";
        public int ID { get; set; }

        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string Pesel { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string KodP { get; set; }
        public string Poczta { get; set; }
        public string Nr_Domu { get; set; }
        public string Nr_Lokalu { get; set; }
        public DateTime Data_Ur { get; set; }
        public DateTime Data_Bad_Lek { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public bool KatA { get; set; }
        public bool KatB { get; set; }
        public bool KatC { get; set; }
        public bool KatD { get; set; }
        public string Uprawnienia { get; set; }

        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }

        /// <summary>
        /// Kontor czyta z bazy danych po ID
        /// </summary>
        /// <param name="i">id obiektu kierowcy</param>
        public XKierowca(int i)
        {
            string sQuery = string.Format("select * from {0} where ID_KIEROWCA={1}", NameSQL, i);
            GetRecord(sQuery);
        }

        public XKierowca()
        {
            // TODO: Complete member initialization
        }

        protected override void FillListRows(SqlDataReader rdrListRows)
        {
            //if (rdrListRows.Read())
            {
                Nazwisko = rdrListRows["NAZWISKO"].ToString();
                Imie = rdrListRows["IMIE"].ToString();
                Pesel = rdrListRows["PESEL"].ToString();
                Miasto = rdrListRows["MIASTO"].ToString();
                Ulica = rdrListRows["ULICA"].ToString();
                KodP = rdrListRows["KODP"].ToString();
                Poczta = rdrListRows["POCZTA"].ToString();
                Nr_Domu = rdrListRows["NR_DOMU"].ToString();
                Nr_Lokalu = rdrListRows["NR_LOKALU"].ToString();
                Data_Ur = (DateTime)rdrListRows["DATA_UR"];
                Data_Bad_Lek = (DateTime)rdrListRows["DATA_BAD_LEK"];
                Tel1 = rdrListRows["TEL1"].ToString();
                Tel2 = rdrListRows["TEL2"].ToString();
                KatA = Narzedzia.IsNullBool(rdrListRows["KATA"]);
                KatB = Narzedzia.IsNullBool(rdrListRows["KATB"]);
                KatC = Narzedzia.IsNullBool(rdrListRows["KATC"]);
                KatD = Narzedzia.IsNullBool(rdrListRows["KATD"]);
                ID = int.Parse(rdrListRows["ID_KIEROWCA"].ToString());
            }
        }

        public void Dopisz()
        {
            string sQuery = string.Format("Insert Into {0} (NAZWISKO,IMIE,PESEL,MIASTO,ULICA,KODP," +
            "POCZTA,NR_DOMU,NR_LOKALU,DATA_UR,DATA_BAD_LEK,TEL1,TEL2,KATA,KATB,KATC,KATD)" +
            "Values('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'," +
            "'{13}',{14},'{15}','{16}','{17}')",
            NameSQL, Nazwisko.Replace("'", "''"), Imie.Replace("'", "''"), Pesel, Miasto, Ulica, KodP, Poczta, Nr_Domu, Nr_Lokalu,
            Data_Ur, Data_Bad_Lek, Tel1, Tel2, KatA ? 1 : 0, KatB ? 1 : 0, KatC ? 1 : 0, KatD ? 1 : 0);
            ID = ExecuteSQLIDENTITY(sQuery);
        }

        public void Popraw()
        {
            string sQuery = string.Format("update {0} set NAZWISKO='{2}', IMIE='{3}',PESEL='{4}', MIASTO='{5}', ULICA='{6}', KODP='{7}'," +
            "POCZTA='{8}',NR_DOMU='{9}',NR_LOKALU='{10}',DATA_UR='{11}',DATA_BAD_LEK='{12}',TEL1='{13}',TEL2='{14}',KATA='{15}',KATB='{16}'," +
            "KATC='{17}',KATD='{18}'  where ID_KIEROWCA={1}",
            NameSQL, ID, Nazwisko.Replace("'", "''"), Imie.Replace("'", "''"), Pesel, Miasto, Ulica, KodP, Poczta, Nr_Domu, Nr_Lokalu,
            Data_Ur, Data_Bad_Lek, Tel1, Tel2, KatA ? 1 : 0, KatB ? 1 : 0, KatC ? 1 : 0, KatD ? 1 : 0);
            ExecuteSQL(sQuery);
        }

        public void Usun()
        {
             

         if ( ID == 0 ) 
            return;

         string sQuery = string.Format( "Delete From {0} where ID_KIEROWCA={1}", NameSQL, ID );
         ExecuteSQL( sQuery );
         }

     }

}
