using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB {

   public class XTrasa : DBSQL {

      public static readonly string NameSQL = "TRASA";

      public int Id_Trasa { get; set; }
      public int Id_Kierowca_Trasa { get; set; }
      public int Id_Pojazd_Trasa { get; set; }
      public DateTime Data_Wyjazd { get; set; }
      public DateTime Data_Przyjazd { get; set; }
      public Decimal Stan_Licz_Pocz { get; set; }
      public Decimal Stan_Licz_Koniec { get; set; }
      public int Id_Tank_Trasa { get; set; }
      public bool Koniec_Trasa { get; set; }

      public XTrasa() {
         Clear();
      }
      /// <summary>
      /// Zwraca rekord trasy dla dane ID_TRASA
      /// </summary>
      /// <param name="idTrasa">identyfikator ID_TRASA</param>
      public XTrasa( int idTrasa ) {
         string sQuery = string.Format( "select * from {0} where ID_TRASA={1}", NameSQL, idTrasa );
         Clear();
         GetRecord( sQuery );
      }
      /// <summary>
      /// Metoda dopisuje do SQL i zwaraca autoinkrement ID_TRASA
      /// </summary>
      public void Dopisz() {
         string sQuery = string.Format( "Insert Into {0} (ID_KIEROWCA_TRASA,ID_POJAZD_TRASA,DATA_WYJAZD,DATA_PRZYJAZD,STAN_LICZ_POCZ,STAN_LICZ_KONIEC,ID_TANK_TRASA,KONIEC_TRASA)" +
                                         "Values({1},{2},{3},{4},{5},{6},{7},{8})",
                                         NameSQL, // 0
                                         Id_Kierowca_Trasa, // 1
                                         Id_Pojazd_Trasa, // 2
                                         Narzedzia.DateTimeToSQL( Data_Wyjazd ), // 3
                                         Narzedzia.DateTimeToSQL( Data_Przyjazd ), // 4
                                         Narzedzia.DecimalToSQL( Stan_Licz_Pocz), // 5
                                         Narzedzia.DecimalToSQL( Stan_Licz_Koniec), // 6
                                         Id_Tank_Trasa, // 7
                                         Koniec_Trasa ? 1 : 0 );

         Id_Trasa = ExecuteSQLIDENTITY( sQuery );

      }
      /// <summary>
      /// Zapisuje dane w SQL na podstawie ID_TRASA
      /// </summary>
      public void Popraw() {

         if ( Id_Trasa == 0 )
            return;

         string sQuery = string.Format( "Update {0} set ID_KIEROWCA_TRASA={2}, ID_POJAZD_TRASA={3}, DATA_WYJAZD={4}, DATA_PRZYJAZD={5}, STAN_LICZ_POCZ={6}, " +
                                                        "STAN_LICZ_KONIEC={7}, ID_TANK_TRASA={8}, KONIEC_TRASA={9}" +
                                        " where ID_TRASA={1}",
                                        NameSQL, // 0
                                        Id_Trasa, // 1
                                        Id_Kierowca_Trasa, // 2
                                        Id_Pojazd_Trasa, // 3
                                        Narzedzia.DateTimeToSQL( Data_Wyjazd ), // 4
                                        Narzedzia.DateTimeToSQL( Data_Przyjazd ), // 5
                                        Stan_Licz_Pocz, // 6
                                        Stan_Licz_Koniec, // 7
                                        Id_Tank_Trasa, // 8
                                        Koniec_Trasa ? 1 : 0 );
         ExecuteSQL( sQuery );

      }
      /// <summary>
      /// Usuwa rekord z SQL na podstawie ID_TRASA
      /// </summary>
      public void Usun() {

         if ( Id_Trasa == 0 )
            return;

         string sQuery = string.Format( "Delete From {0} where ID_TRASA={1}", NameSQL, Id_Trasa );
         ExecuteSQL( sQuery );
         Clear();
      }

      /// <summary>
      /// Metoda wypełnia rekord z SqlDataReader
      /// </summary>
      public void FillFrom( System.Data.SqlClient.SqlDataReader rdrListRows ) {
         Clear();
         Id_Trasa = Narzedzia.IsNullInt( rdrListRows["ID_TRASA"] );
         Id_Kierowca_Trasa = Narzedzia.IsNullInt( rdrListRows["ID_KIEROWCA_TRASA"] );
         Id_Pojazd_Trasa = Narzedzia.IsNullInt( rdrListRows["ID_POJAZD_TRASA"] );
         Data_Wyjazd = Narzedzia.IsNullDateTime( rdrListRows["DATA_WYJAZD"] );
         Data_Przyjazd = Narzedzia.IsNullDateTime( rdrListRows["DATA_PRZYJAZD"] );
         Stan_Licz_Pocz = Narzedzia.IsNullDecimal( rdrListRows["STAN_LICZ_POCZ"] );
         Stan_Licz_Koniec = Narzedzia.IsNullDecimal(rdrListRows["STAN_LICZ_KONIEC"]);
         Id_Tank_Trasa = Narzedzia.IsNullInt( rdrListRows["ID_TANK_TRASA"] );
      }
      /// <summary>
      /// Metoda ustawia domyślne wartości rekordu
      /// </summary>
      public void Clear() {
         Id_Trasa = 0;
         Id_Kierowca_Trasa = 0;
         Id_Pojazd_Trasa = 0;
         Data_Wyjazd = DateTime.MinValue;
         Data_Przyjazd = DateTime.MinValue;
         Stan_Licz_Pocz = 0;
         Stan_Licz_Koniec = 0;
         Id_Tank_Trasa = 0;
         Koniec_Trasa = false;
      }
      protected override void FillListRows( SqlDataReader rdrListRows ) {
         FillFrom( rdrListRows );
      }
   }

}
