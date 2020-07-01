using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XTrasa_Kierowca
    {

        public int Id_Kierowca_Trasa { get; set; }
        public int Id_Pojazd_Trasa { get; set; }
        public DateTime Data_Wyjazd { get; set; }
        public DateTime Data_Przyjazd { get; set; }
        public Decimal Stan_Licz_Pocz { get; set; }
        public Decimal Stan_Licz_Koniec { get; set; }
        public int Id_Tank_Trasa { get; set; }
        public bool Koniec_Trasa { get; set; }
        public int Id_Kierowca { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public void UstawKierowce(XKierowca k)
        {
            Id_Kierowca_Trasa = k.ID;
            Imie = k.Imie;
            Nazwisko = k.Nazwisko;

        }


        public void UstawKierowce(XTrasa t)
        {
            Id_Kierowca_Trasa = t.Id_Kierowca_Trasa;
            Id_Pojazd_Trasa = t.Id_Pojazd_Trasa;
            Data_Wyjazd = t.Data_Wyjazd;
            Data_Przyjazd = t.Data_Przyjazd;
            Stan_Licz_Pocz = t.Stan_Licz_Pocz;
            Stan_Licz_Koniec = t.Stan_Licz_Koniec;
            Id_Tank_Trasa = t.Id_Tank_Trasa;
            Koniec_Trasa = t.Koniec_Trasa;

        }

    }
}
