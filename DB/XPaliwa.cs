using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{ 



    public class XPaliwa : DBSQL
    {
        public string namesql = "paliwo";
        public int id_paliwo { get; set; }
        public string paliwo_nazwa { get; set; }
        protected override void FillListRows(System.Data.SqlClient.SqlDataReader rdrListRows)
        {
            XPaliwa paliwa = new XPaliwa();
            paliwa.id_paliwo = int.Parse(rdrListRows["id_paliwo"].ToString());
            paliwa.paliwo_nazwa = rdrListRows["paliwo_nazwa"].ToString();
            ListaPaliwa.Add(paliwa);
        }
        public List<XPaliwa> ListaPaliwa = new List<XPaliwa>();
        public int DajListePaliwa()
        {
            ListaPaliwa.Clear();
            int ile_paliwa = GetRecords("select * from paliwo");
            return ile_paliwa;
        }

        
        public XPaliwa (int ii)
        {
        string sQuery = string.Format("select * from {0} where id_paliwo={1}", namesql, ii);
        GetRecord(sQuery);

       

        
        }

        public XPaliwa()
        {
    
    
        }


        

        
    }
}




