using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB {
   public class XTrasy : DBSQL {
      /// <summary>
      /// Lista rekordów wczytana przez metodę DajListe(...
      /// </summary>
      public List<XTrasa> Lista = new List<XTrasa>();

      /// <summary>
      /// Wczytuje listę wszystkich tras
      /// </summary>
      /// <returns>ilość wczytanych rekordów</returns>
      public int DajListe() {
         Lista.Clear();
         int ile_tras = GetRecords( string.Format( "select * from {0}", XTrasa.NameSQL ));
         return ile_tras;
      }
      /// <summary>
      /// Wczytuje listę tras ograniczonych do Where
      /// </summary>
      /// <param name="sWhere">poprawne polecenie sql Where</param>
      /// <returns>ilość wczytanych rekordów</returns>
      public int DajListe(string sWhere) {
         Lista.Clear();
         int ile_tras = GetRecords( string.Format( "select * from {0} where {1}", XTrasa.NameSQL, sWhere ) );
         return ile_tras;
      }
      protected override void FillListRows( SqlDataReader rdrListRows ) {
         XTrasa t = new XTrasa();
         t.FillFrom( rdrListRows );
         Lista.Add( t );
      }
   }

}


