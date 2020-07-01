using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace DB {
   public class XTankowania : DBSQL {
      /// <summary>
      /// Lista rekordów wczytana przez metodę DajListe(...
      /// </summary>
      public List<XTankowanie> Lista = new List<XTankowanie>();

      /// <summary>
      /// Wczytuje listę wszystkich tankowań
      /// </summary>
      /// <returns>ilość wczytanych rekordów</returns>
      public int DajListe() {
         Lista.Clear();
         int ile_tank = GetRecords( string.Format( "select * from {0}", XTankowanie.NameSQL ) );
         return ile_tank;
      }
      /// <summary>
      /// Wczytuje listę tankowań ograniczonych do Where
      /// </summary>
      /// <param name="sWhere">poprawne polecenie sql Where</param>
      /// <returns>ilość wczytanych rekordów</returns>
      public int DajListe( string sWhere ) {
         Lista.Clear();
         int ile_tank = GetRecords( string.Format( "select * from {0} where {1}", XTankowanie.NameSQL, sWhere ) );
         return ile_tank;
      }
      protected override void FillListRows( System.Data.SqlClient.SqlDataReader rdrListRows ) {
         XTankowanie tank = new XTankowanie();
         tank.FillFrom( rdrListRows );
         Lista.Add( tank );
      }
   }
}


