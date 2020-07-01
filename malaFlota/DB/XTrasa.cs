using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class XTrasa : DBSQL
    {

        public readonly string NameSQL = "TRASA";
        public int Id_Trasa { get; set; }
        public int Id_Kierowca_Trasa { get; set; }
        public int Id_Pojazd_Trasa { get; set; }
        public DateTime Data_Wyjazd { get; set; }
        public DateTime Data_Przyjazd { get; set; }
        public Decimal Stan_Licz_Pocz { get; set; }
        public Decimal Stan_Licz_Koniec { get; set; }
        public int Id_Tank_Trasa { get; set; }
        public bool Koniec_Trasa { get; set; }
        

        public XTrasa(int t)
        {
            string sQuery = string.Format("select * from {0} where ID_TRASA={1}", NameSQL, t);
            GetRecord(sQuery);



        }

        public XTrasa()
        { }


        protected override void FillListRows(System.Data.SqlClient.SqlDataReader rdrListRows)
        {
            if (rdrListRows.Read())
            {
                Id_Trasa = int.Parse(rdrListRows["ID_TRASA"].ToString());
                Id_Kierowca_Trasa = int.Parse(rdrListRows["ID_KIEROWCA_TRASA"].ToString());
                Id_Pojazd_Trasa = int.Parse(rdrListRows["ID_POJAZD_TRASA"].ToString());
                Data_Wyjazd = (DateTime)rdrListRows["DATA_WYJAZD"];
                Data_Przyjazd = (DateTime)rdrListRows["DATA_PRZYJAZD"];
                Stan_Licz_Pocz = Decimal.Parse(rdrListRows["STAN_LICZ_POCZ"].ToString());
                Stan_Licz_Pocz = Decimal.Parse(rdrListRows["STAN_LICZ_KONIEC"].ToString());
                Id_Tank_Trasa = int.Parse(rdrListRows["ID_TANK_TRASA"].ToString());


            }
        }

        public void Dopisz()
        {
            string sQuery = string.Format("Insert Into {0} (ID_KIEROWCA_TRASA,ID_POJAZD_TRASA,DATA_WYJAZD,DATA_PRZYJAZD,STAN_LICZ_POCZ,STAN_LICZ_KONIEC" +
            ",ID_TANK_TRASA,KONIEC_TRASA)" +
            "Values('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
            NameSQL, Id_Kierowca_Trasa,Id_Pojazd_Trasa,Data_Wyjazd,Data_Przyjazd,Stan_Licz_Pocz,Stan_Licz_Koniec,Id_Tank_Trasa,Koniec_Trasa ? 1 : 0);
            Id_Trasa = ExecuteSQLIDENTITY(sQuery);
           
        
        
        
        
        
        }

        public void Popraw()
        {

           

        }
        public void Usun()
        {


        }




    }

}
