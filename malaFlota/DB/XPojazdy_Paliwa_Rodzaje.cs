using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XPojazdy_Paliwa_Rodzaje
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
 // Paliwo

        public int Id_Paliwo { get; set; }
     
        public string Paliwo_Nazwa { get; set; }

        public int Id_Rodzaj { get; set; }
        public string Rodzaj_Nazwa { get; set; }

        public void Ustaw(XPojazd p)
        {
            Id_Pojazd = p.Id_Pojazd;
            Nr_Rej = p.Nr_Rej; 
            Marka =p.Marka;
            Model=p.Model;
            Pojemnosc =p.Pojemnosc;
            Rok_Prod = p.Rok_Prod;
            Id_Rodzaj_Pojazd = p.Id_Rodzaj_Pojazd;
            Nr_Silnik = p.Nr_Silnik;
            Nr_Nadwozie = p.Nr_Nadwozie;
            Id_Paliwo_Pojazd = p.Id_Paliwo_Pojazd;
            Zbiornik = p.Zbiornik; 
            Stan_Licz_Pocz = p.Stan_Licz_Pocz;
            Numer_Oc = p.Numer_Oc;
            Data_Oc = p.Data_Oc;
            Polisa_Ac = p.Polisa_Ac;
            Numer_Ac = p.Numer_Ac;
            Data_Ac = p.Data_Ac;
            Data_Bad_Tech = p.Data_Bad_Tech;
            Licz_Bad_Tech = p.Licz_Bad_Tech;
            Gwarancja = p.Gwarancja;
            Data_Gwarancja = p.Data_Gwarancja;
            Stan_Licz_Gwar = p.Stan_Licz_Gwar;

        }
        public void Ustaw(XPaliwo p)
        {
            Id_Paliwo = p.Id_Paliwo;
            Paliwo_Nazwa = p.Paliwo_Nazwa;

        }
        public void Ustaw(XRodzaj r)
        {
            Id_Rodzaj = r.Id_Rodzaj;
            Rodzaj_Nazwa = r.Rodzaj_Nazwa;
        }
    }
}
