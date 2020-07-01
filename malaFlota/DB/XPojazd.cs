using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XPojazd : DBSQL
    {
        public readonly string NameSQL = "Pojazd";
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


        public XPojazd(int i)
        {
            string sQuery = string.Format("select * from {0} where ID_POJAZD={1}", NameSQL, i);
            GetRecord(sQuery);



        }

        public XPojazd()
        {

        }

        protected override void FillListRows(System.Data.SqlClient.SqlDataReader rdrListRows)
        {
            if (rdrListRows.Read())
            {
                Nr_Rej = rdrListRows["NR_REJ"].ToString();
                Marka = rdrListRows["MARKA"].ToString();
                Model = rdrListRows["MODEL"].ToString();
                Pojemnosc = Decimal.Parse(rdrListRows["POJEMNOSC"].ToString());
                Rok_Prod = rdrListRows["ROK_PROD"].ToString();
                Id_Rodzaj_Pojazd = int.Parse(rdrListRows["ID_RODZAJ_POJAZD"].ToString());
                Nr_Silnik = rdrListRows["NR_SILNIK"].ToString();
                Nr_Nadwozie = rdrListRows["NR_NADWOZIE"].ToString();
                Id_Paliwo_Pojazd = int.Parse(rdrListRows["ID_PALIWO_POJAZD"].ToString());
                Zbiornik = Decimal.Parse(rdrListRows["ZBIORNIK"].ToString());
                Stan_Licz_Pocz = Decimal.Parse(rdrListRows["STAN_LICZ_POCZ"].ToString());
                Numer_Oc = rdrListRows["NUMER_OC"].ToString();
                Data_Oc = (DateTime)rdrListRows["DATA_OC"];
                Polisa_Ac = Narzedzia.IsNullBool(rdrListRows["POLISA_AC"]);
                Numer_Ac = rdrListRows["NUMER_AC"].ToString();
                Data_Ac = (DateTime)rdrListRows["DATA_AC"];
                Data_Bad_Tech = (DateTime)rdrListRows["DATA_BAD_TECH"];
                Licz_Bad_Tech = Decimal.Parse(rdrListRows["LICZ_BAD_TECH"].ToString());
                Gwarancja = Narzedzia.IsNullBool(rdrListRows["GWARANCJA"]);
                Data_Gwarancja = (DateTime)rdrListRows["DATA_GWARANCJA"];
                Stan_Licz_Gwar = Narzedzia.IsNullDecimal(rdrListRows["STAN_LICZ_GWAR"]);
                Id_Pojazd = int.Parse(rdrListRows["ID_POJAZD"].ToString());


            }
        }

        public void Dopisz()
        {
            string sQuery = string.Format("INSERT INTO [db_malaFlota].[dbo].[POJAZD](NR_REJ,MARKA,MODEL,POJEMNOSC," +
            "ROK_PROD,ID_RODZAJ_POJAZD,NR_SILNIK,NR_NADWOZIE,ID_PALIWO_POJAZD," +
            "ZBIORNIK,STAN_LICZ_POCZ,NUMER_OC,DATA_OC,POLISA_AC,NUMER_AC,DATA_AC," +
            "DATA_BAD_TECH,LICZ_BAD_TECH,GWARANCJA,DATA_GWARANCJA,STAN_LICZ_GWAR)" +
            "VALUES ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'," +
            "'{13}',{14},'{15}','{16}','{17}','{18}',{19},'{20}','{21}')",
            NameSQL, Nr_Rej, Marka, Model, Pojemnosc, Rok_Prod, Id_Rodzaj_Pojazd, Nr_Silnik, Nr_Nadwozie, Id_Paliwo_Pojazd,
            Zbiornik.ToString().Replace(",", "."), Stan_Licz_Pocz.ToString().Replace(",", "."), Numer_Oc, Data_Oc, Polisa_Ac ? 1 : 0, Numer_Ac, Data_Ac,
            Data_Bad_Tech, Licz_Bad_Tech.ToString().Replace(",", "."), Gwarancja ? 1 : 0,
            Data_Gwarancja, Stan_Licz_Gwar.ToString().Replace(",", "."));
            Id_Pojazd = ExecuteSQLIDENTITY(sQuery);

        }

        public void Popraw()
        {

            string sQuery = string.Format("UPDATE {0} SET NR_REJ = '{1}',MARKA = '{2}',MODEL = '{3}',POJEMNOSC = {4}," +
            "ROK_PROD = '{5}', ID_RODZAJ_POJAZD ={6} ,NR_SILNIK ='{7}', NR_NADWOZIE = '{8}',ID_PALIWO_POJAZD = {9}," +
            "ZBIORNIK = {10},STAN_LICZ_POCZ = {11},NUMER_OC ='{12}',DATA_OC = '{13}',POLISA_AC = '{14}',NUMER_AC = '{15}'," +
            "DATA_AC = '{16}',DATA_BAD_TECH = '{17}',LICZ_BAD_TECH = {18},GWARANCJA = {19},DATA_GWARANCJA = '{20}'," +
            "STAN_LICZ_GWAR = {21} where ID_Pojazd={22}",
            NameSQL, Nr_Rej, Marka, Model, Pojemnosc.ToString().Replace(",", "."), Rok_Prod, Id_Rodzaj_Pojazd, Nr_Silnik,
            Nr_Nadwozie, Id_Paliwo_Pojazd, Zbiornik.ToString().Replace(",", "."), Stan_Licz_Pocz.ToString().Replace(",", "."),
            Numer_Oc, Data_Oc, Polisa_Ac ? 1 : 0, Numer_Ac, Data_Ac, Data_Bad_Tech, Licz_Bad_Tech.ToString().Replace(",", "."), Gwarancja ? 1 : 0,
            Data_Gwarancja, Stan_Licz_Gwar.ToString().Replace(",", "."), Id_Pojazd);
            ExecuteSQL(sQuery);

        }
        public void Usun()
        {


        }




    }

}
