using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XPojazdy_Rodzaje

    {
        public int Id_Pojazd { get; set; }
        public string Nr_Rej { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Pojemnosc { get; set; }
        public string Rok_Prod { get; set; }
        public int Id_Rodzaj_Pojazd { get; set; }
        public string Nr_Silnik { get; set; }
        public string Nr_Nadwozie { get; set; }
        public int Id_Paliwo_Pojazd { get; set; }
        public Decimal Zbiornik { get; set; }
        public Decimal Stan_Licz_Pocz { get; set; }
        public string Numer_Oc { get; set; }
        public DateTime Data_Oc { get; set; }
        public bool Polisa_Ac { get; set; }
        public string Numer_Ac { get; set; }
        public DateTime Data_Ac { get; set; }
        public DateTime Data_Bad_Tech { get; set; }
        public Decimal Licz_Bad_Tech { get; set; }
        public bool Gwarancja { get; set; }
        public DateTime Data_Gwarancja { get; set; }
        public Decimal Stan_Licz_Gwar { get; set; }
        // Rodzaje
        public int Id_Rodzaj { get; set; }
        public string Rodzaj_Nazwa { get; set; }

        public void UstawRodzaj(XPojazd r)
        {
            
            Id_Pojazd = r.Id_Pojazd;
            Nr_Rej = r.Nr_Rej;
            Marka = r.Marka;
            Model = r.Model;
            Pojemnosc = r.Pojemnosc;
            Rok_Prod = r.Rok_Prod;
            Id_Rodzaj_Pojazd = r.Id_Rodzaj_Pojazd;
            Nr_Silnik = r.Nr_Silnik;
            Nr_Nadwozie = r.Nr_Nadwozie;
            Id_Paliwo_Pojazd = r.Id_Paliwo_Pojazd;
            Zbiornik = r.Zbiornik;
            Stan_Licz_Pocz = r.Stan_Licz_Pocz;
            Numer_Oc = r.Numer_Oc;
            Data_Oc = r.Data_Oc;
            Polisa_Ac = r.Polisa_Ac;
            Numer_Ac = r.Numer_Ac;
            Data_Ac = r.Data_Ac;
            Data_Bad_Tech = r.Data_Bad_Tech;
            Licz_Bad_Tech = r.Licz_Bad_Tech;
            Gwarancja = r.Gwarancja;
            Data_Gwarancja = r.Data_Gwarancja;
            Stan_Licz_Gwar = r.Stan_Licz_Gwar;

        }
        public void UstawRodzaj(XRodzaj r)
        {
            Id_Rodzaj = r.Id_Rodzaj;
            Rodzaj_Nazwa = r.Rodzaj_Nazwa;

        }

    }
}

