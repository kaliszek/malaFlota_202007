using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XPojazdy : DBSQL

    {

        public List<XPojazd> ListaPojazdow = new List<XPojazd>();
 
        public int DajListePojazdow()


        {
            ListaPojazdow.Clear();

            int ile_pojazdow =  GetRecords("select * from dbo.POJAZD");
            return ile_pojazdow;
        
        }


        protected override void FillListRows(SqlDataReader rdrListRows)
        {
            XPojazd p = new XPojazd();
            p.Nr_Rej = rdrListRows["NR_REJ"].ToString();
            p.Marka = rdrListRows["MARKA"].ToString();
            p.Model = rdrListRows["MODEL"].ToString();
            p.Pojemnosc = Decimal.Parse(rdrListRows["POJEMNOSC"].ToString());
            p.Rok_Prod = rdrListRows["ROK_PROD"].ToString();
            p.Id_Rodzaj_Pojazd = int.Parse(rdrListRows["ID_RODZAJ_POJAZD"].ToString());
            p.Nr_Silnik = rdrListRows["NR_SILNIK"].ToString();
            p.Nr_Nadwozie = rdrListRows["NR_NADWOZIE"].ToString();
            p.Id_Paliwo_Pojazd = int.Parse(rdrListRows["ID_PALIWO_POJAZD"].ToString());
            p.Zbiornik = Decimal.Parse(rdrListRows["ZBIORNIK"].ToString());
            p.Stan_Licz_Pocz = Decimal.Parse(rdrListRows["STAN_LICZ_POCZ"].ToString());
            p.Numer_Oc = rdrListRows["NUMER_OC"].ToString();
            p.Data_Oc = (DateTime)rdrListRows["DATA_OC"];
            p.Polisa_Ac = Narzedzia.IsNullBool(rdrListRows["POLISA_AC"]);
            p.Numer_Ac = rdrListRows["NUMER_AC"].ToString();
            p.Data_Ac = (DateTime)rdrListRows["DATA_AC"];
            p.Data_Bad_Tech = (DateTime)rdrListRows["DATA_BAD_TECH"];
            p.Licz_Bad_Tech = Decimal.Parse(rdrListRows["LICZ_BAD_TECH"].ToString());
            p.Gwarancja = Narzedzia.IsNullBool(rdrListRows["GWARANCJA"]);
            p.Data_Gwarancja = (DateTime)rdrListRows["DATA_GWARANCJA"];
            p.Stan_Licz_Gwar = Decimal.Parse(rdrListRows["STAN_LICZ_GWAR"].ToString());
            p.Id_Pojazd = int.Parse(rdrListRows["ID_POJAZD"].ToString());
            ListaPojazdow.Add(p);
     
    
        }
 
    }
}


