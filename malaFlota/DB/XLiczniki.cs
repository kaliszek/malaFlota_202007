using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace DB
{
    public class XLiczniki : DBSQL
    {


        protected override void FillListRows(System.Data.SqlClient.SqlDataReader rdrListRows)
        {
            XLicznik licznik = new XLicznik();
            licznik.Id_Licznik = int.Parse(rdrListRows["ID_LICZNIK"].ToString());
            licznik.id_Pojazd_Licznik = int.Parse(rdrListRows["ID_POJAZD_LICZNIK"].ToString());
            licznik.Wartosc_Licznik = Decimal.Parse(rdrListRows["WARTOSC_LICZNIK"].ToString());
            licznik.Data_Licznik = (DateTime)rdrListRows["DATA_LICZNIK"];
            Lista.Add(licznik);

        }
        public List<XLicznik> Lista = new List<XLicznik>();
        public int DajListe()
        {
            Lista.Clear();
            return GetRecords(String.Format("select * from {0}", XLicznik.NameSQL));

        }
       // public int DajListe(string where)
        //{
         //   Lista.Clear();
        //    return GetRecords(String.Format("select * from {0} where {1}", XTankowanie.NameSQL, where));

        //}

    }







}





