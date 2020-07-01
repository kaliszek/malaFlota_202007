using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DB
{
    public class XRodzaje : DBSQL
    {
        public string NameSQL = "Rodzaj";
        public int Id_Rodzaj { get; set; }
        public string Rodzaj_Nazwa { get; set; }


        protected override void FillListRows(System.Data.SqlClient.SqlDataReader rdrListRows)
        {
            XRodzaje rodzaj = new XRodzaje();
            rodzaj.Id_Rodzaj = int.Parse(rdrListRows["ID_RODZAJ"].ToString());
            rodzaj.Rodzaj_Nazwa = rdrListRows["RODZAJ_NAZWA"].ToString();
            ListaRodzaje.Add(rodzaj);

        }
        public List<XRodzaje> ListaRodzaje = new List<XRodzaje>();
        public int DajListeRodzaje()
        {
            ListaRodzaje.Clear();
            int ile_rodzaj = GetRecords("select * from rodzaj");
            return ile_rodzaj;

        }









    }




}