using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XTankowanie : DBSQL
    {
        public static readonly string NameSQL = "TANK";
        public int Id_Tank { get; set; }
        public int Id_Trasa_Tank { get; set; }
        public int Id_Pojazd_Tank { get; set; }
        public DateTime Data_Tank { get; set; }
        public Decimal Ilosc_Tank { get; set; }
        public Decimal Wartosc_Tank { get; set; }
        public Decimal Licznik_Tank { get; set; }
        public int Id_Rodzaj_Paliwa_Tank { get; set; }


        public void Dopisz()
        {
            string sQuery = string.Format("Insert Into {0} (ID_TRASA_TANK,ID_POJAZD_TANK,DATA_TANK,ILOSC_TANK" +
            ",WARTOSC_TANK,LICZNIK_TANK,ID_RODZAJ_PALIWA_TANK)" +
            "Values('{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
            NameSQL, Id_Trasa_Tank, Id_Pojazd_Tank, Data_Tank, Ilosc_Tank, Wartosc_Tank, Licznik_Tank, Id_Rodzaj_Paliwa_Tank);
            Id_Tank = ExecuteSQLIDENTITY(sQuery);






        }

    }
}
