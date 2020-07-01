using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XTrasy : DBSQL
    {
        public List<XTrasa> Lista = new List<XTrasa>();

        public int DajListe()
        {
            Lista.Clear();

            int ile_tras = GetRecords("select * from trasa");

            return ile_tras;
        }

        protected override void FillListRows(SqlDataReader rdrListRows)
        {
            XTrasa t = new XTrasa();
            t.Id_Trasa = int.Parse(rdrListRows["ID_TRASA"].ToString());
            t.Id_Kierowca_Trasa = int.Parse(rdrListRows["ID_KIEROWCA_TRASA"].ToString());
            t.Id_Pojazd_Trasa = int.Parse(rdrListRows["ID_POJAZD_TRASA"].ToString());
            t.Data_Wyjazd = (DateTime)rdrListRows["DATA_WYJAZD"];
            t.Data_Przyjazd = (DateTime)rdrListRows["DATA_PRZYJAZD"];
            t.Stan_Licz_Pocz = Decimal.Parse(rdrListRows["STAN_LICZ_POCZ"].ToString());
            t.Stan_Licz_Pocz = Decimal.Parse(rdrListRows["STAN_LICZ_KONIEC"].ToString());
            t.Id_Tank_Trasa = int.Parse(rdrListRows["ID_TANK_TRASA"].ToString());
            t.Koniec_Trasa = Narzedzia.IsNullBool(rdrListRows["KONIEC_TRASA"]);
            Lista.Add(t);

        }

    }







}


