using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XLicznik : DBSQL
    {
        public static readonly string NameSQL = "LICZNIK";
        public int Id_Licznik { get; set; }
        public int id_Pojazd_Licznik { get; set; }
        public Decimal Wartosc_Licznik { get; set; }
        public DateTime Data_Licznik { get; set; }

    
    }
}
