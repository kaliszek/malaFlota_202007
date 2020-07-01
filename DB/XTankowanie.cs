using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB {
   public class XTankowanie : DBSQL {

      public static readonly string NameSQL = "TANK";

      public int Id_Tank { get; set; }
      public int Id_Trasa_Tank { get; set; }
      public int Id_Pojazd_Tank { get; set; }
      public DateTime Data_Tank { get; set; }
      public Decimal Ilosc_Tank { get; set; }
      public Decimal Wartosc_Tank { get; set; }
      public Decimal Licznik_Tank { get; set; }
      public int Id_Rodzaj_Paliwa_Tank { get; set; }

      public XTankowanie() {
         Clear();
      }
      /// <summary>
      /// Zwraca rekord trasy dla dane ID_TANK
      /// </summary>
      /// <param name="idTank">identyfikator ID_TANK</param>
      public XTankowanie( int idTank ) {
         string sQuery = string.Format( "select * from {0} where ID_TANK={1}", NameSQL, idTank );
         Clear();
         GetRecord( sQuery );
      }

      public void Dopisz() {
         string sQuery = string.Format( "Insert Into {0} (ID_TRASA_TANK,ID_POJAZD_TANK,DATA_TANK,ILOSC_TANK,WARTOSC_TANK,LICZNIK_TANK,ID_RODZAJ_PALIWA_TANK)" +
                                        "Values({1},{2},{3},{4},{5},{6},{7})",
                                        NameSQL, // 0 
                                        Id_Trasa_Tank,
                                        Id_Pojazd_Tank,
                                        Narzedzia.DateTimeToSQL( Data_Tank ),
                                        Narzedzia.DecimalToSQL( Ilosc_Tank ),
                                        Narzedzia.DecimalToSQL( Wartosc_Tank ),
                                        Narzedzia.DecimalToSQL( Licznik_Tank ), // 6
                                        Id_Rodzaj_Paliwa_Tank ); // 7

         Id_Tank = ExecuteSQLIDENTITY( sQuery );
      }
      /// <summary>
      /// Zapisuje dane w SQL na podstawie ID_TANK
      /// </summary>
      public void Popraw() {

         if ( Id_Tank == 0 )
            return;

         string sQuery = string.Format( "Update {0} set ID_TRASA_TANK={2}, ID_POJAZD_TANK={3}, DATA_TANK={4}, ILOSC_TANK={5}, WARTOSC_TANK={6}, LICZNIK_TANK={7}, ID_RODZAJ_PALIWA_TANK={8}" +
                                        " where ID_TANK={1}",
                                        NameSQL, // 0
                                        Id_Tank, // 1
                                        Id_Trasa_Tank, // 2
                                        Id_Pojazd_Tank, // 3
                                        Narzedzia.DateTimeToSQL( Data_Tank ),
                                        Narzedzia.DecimalToSQL( Ilosc_Tank ),
                                        Narzedzia.DecimalToSQL( Wartosc_Tank ),
                                        Narzedzia.DecimalToSQL( Licznik_Tank ), // 7
                                        Id_Rodzaj_Paliwa_Tank ); // 8
         ExecuteSQL( sQuery );

      }
      /// <summary>
      /// Usuwa rekord z SQL na podstawie ID_TANK
      /// </summary>
      public void Usun() {

         if ( Id_Tank == 0 )
            return;

         string sQuery = string.Format( "Delete From {0} where ID_TANK={1}", NameSQL, Id_Tank );
         ExecuteSQL( sQuery );
         Clear();
      }
      /// <summary>
      /// Metoda wypełnia rekord z SqlDataReader
      /// </summary>
      public void FillFrom( System.Data.SqlClient.SqlDataReader rdrListRows ) {
         Clear();
         Id_Tank = Narzedzia.IsNullInt( rdrListRows["ID_TANK"] );
         Id_Trasa_Tank = Narzedzia.IsNullInt( rdrListRows["ID_TRASA_TANK"] );
         Id_Pojazd_Tank = Narzedzia.IsNullInt( rdrListRows["ID_POJAZD_TANK"] );
         Data_Tank = Narzedzia.IsNullDateTime( rdrListRows["DATA_TANK"]);
         Ilosc_Tank = Narzedzia.IsNullDecimal( rdrListRows["ILOSC_TANK"] );
         Wartosc_Tank = Narzedzia.IsNullDecimal( rdrListRows["WARTOSC_TANK"] );
         Licznik_Tank = Narzedzia.IsNullDecimal( rdrListRows["LICZNIK_TANK"] );
         Id_Rodzaj_Paliwa_Tank = Narzedzia.IsNullInt( rdrListRows["ID_RODZAJ_PALIWA_TANK"] );
      }
      /// <summary>
      /// Metoda ustawia domyślne wartości rekordu
      /// </summary>
      public void Clear() {
         Id_Tank = 0;
         Id_Trasa_Tank = 0;
         Id_Pojazd_Tank = 0;
         Data_Tank = DateTime.MinValue;
         Ilosc_Tank = 0;
         Wartosc_Tank = 0;
         Licznik_Tank = 0;
         Id_Rodzaj_Paliwa_Tank = 0;
      }
      protected override void FillListRows( SqlDataReader rdrListRows ) {
         FillFrom( rdrListRows );
      }
   }
}
