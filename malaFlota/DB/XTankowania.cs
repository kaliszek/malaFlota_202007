using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace DB
{
    public class XTankowania : DBSQL
    {
        
        protected override void FillListRows(System.Data.SqlClient.SqlDataReader rdrListRows)
        {
            XTankowanie tank = new XTankowanie();
            tank.Id_Tank = int.Parse(rdrListRows["ID_TANK"].ToString());
            tank.Id_Trasa_Tank = int.Parse(rdrListRows["ID_TRASA_TANK"].ToString());
            tank.Id_Pojazd_Tank = int.Parse(rdrListRows["ID_POJAZD_TANK"].ToString());
            tank.Data_Tank = (DateTime)rdrListRows["DATA_TANK"];
            tank.Ilosc_Tank = Decimal.Parse(rdrListRows["ILOSC_TANK"].ToString());
            tank.Wartosc_Tank = Decimal.Parse(rdrListRows["WARTOSC_TANK"].ToString());
            tank.Licznik_Tank = Decimal.Parse(rdrListRows["LICZNIK_TANK"].ToString());
            tank.Id_Rodzaj_Paliwa_Tank = int.Parse(rdrListRows["ID_RODZAJ_PALIWA_TANK"].ToString());

            ListaTank.Add(tank);

        }
        public List<XTankowanie> ListaTank = new List<XTankowanie>();
        public int DajListe()
        {
            ListaTank.Clear();
            return GetRecords(String.Format("select * from {0}", XTankowanie.NameSQL));

        }
        public int DajListe(string where)
        {
            ListaTank.Clear();
            return GetRecords(String.Format("select * from {0} where {1}", XTankowanie.NameSQL, where));

        }

    }







}


