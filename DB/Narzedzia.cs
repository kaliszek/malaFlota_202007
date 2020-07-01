using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB {
   public static class Narzedzia {

      private static string[,] _znakiHtml = new string[7, 2] { { "&", "&amp" }, { "<", "&alt" }, { ">", "&gt" }, { "\"", "&quot" }, { "\r\n", "<br>" }, { "+chr(10)+", "<br>" }, { "'", "&#39" } };

      /// <summary>
      /// Konwertuje DateTime do postacji SQL
      /// </summary>
      /// <param name="d">Konwertowana data</param>
      /// <returns>zwraca poprawny SQL kod</returns>
      public static string DateTimeToSQL( DateTime d ) {
         return string.Format( "Convert( DateTime, '{0:yyyy-MM-ddThh:mm:ss.fff}' , 126)", d ); // select convert( DateTime, '2014-08-14T13:59:32.020', 126)
      }
      /// <summary>
      /// Konwertuje decimal do postaci SQL
      /// </summary>
      /// <param name="d">Konwertowana wartość</param>
      /// <returns>zwraca poprawny SQL kod</returns>
      public static string DecimalToSQL( decimal d ) {
         return d.ToString().Replace( ",", "." );
      }
      /// <summary>
      /// Funkcja konwertuje null na pusty łańcuch znaków
      /// </summary>
      /// <param name="str">Konwertowany łańcuch znaków</param>
      public static string IsNull( string str ) {
         if ( str != null )
            return str;
         else
            return string.Empty;
      }
      /// <summary>
      /// Funkcja konwertuje null na pusty łańcuch znaków
      /// </summary>
      /// <param name="str">Konwertowany łancuch znaków</param>
      /// <param name="is_null">Wartość domyślna, jeśli konwertowany łańcuch znaków jest null</param>
      public static string IsNull( string str, string is_null ) {
         if ( str != null )
            return str;
         else
            return is_null;
      }
      //------------------------------------------------------------------------------------
      // funkcje do konwersji z klasy SqlDataReader

      /// <summary>
      /// IsNull na obiekcie SqlDataReader rzutowanym na string
      /// </summary>
      /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
      public static string IsNullString( object rdr ) {
         if ( rdr == null || rdr == DBNull.Value )
            return string.Empty;
         else
            return rdr.ToString().Trim();
      }
      /// <summary>
      /// IsNull na obiekcie SqlDataReader rzutowanym na int
      /// </summary>
      /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
      public static int IsNullInt( object rdr ) {
         if ( rdr == null || rdr == DBNull.Value )
            return 0;
         else
            return (int)rdr;
      }
      /// <summary>
      /// IsNull na obiekcie SqlDataReader rzutowanym na byte (sql to tinyint)
      /// </summary>
      /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
      public static byte IsNullByte( object rdr ) {
         if ( rdr == null || rdr == DBNull.Value )
            return 0;
         else
            return (byte)rdr;
      }
      /// <summary>
      /// IsNull na obiekcie SqlDataReader rzutowanym na decimal (sql to numeric lub decimal)
      /// </summary>
      /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
      public static decimal IsNullDecimal( object rdr ) {
         if ( rdr == null || rdr == DBNull.Value )
            return 0;
         else
            return (Decimal)rdr;
      }
      /// <summary>
      /// IsNull na obiekcie SqlDataReader rzutowanym na bool (sql to tinyint)
      /// </summary>
      /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
      public static bool IsNullBool( object rdr ) {
         if ( rdr == null || rdr == DBNull.Value )
            return false;
         else {
            if ( (byte)rdr == 0 )
               return false;
            else
               return true;
         };
      }
      /// <summary>
      /// IsNull na obiekcie SqlDataReader rzutowanym na DateTime (sql to DateTime), jeśli jest null to ustawiam YEmptyDateTime();
      /// </summary>
      /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
      public static DateTime IsNullDateTime( object rdr ) {
         if ( rdr == null || rdr == DBNull.Value )
            return DateTime.MinValue;
         else
            return (DateTime)rdr;
      }
      /// <summary>
      /// IsNull na obiekcie SqlDataReader rzutowanym na Guid (sql to uniqueidentifier), jeśli jest null to ustawiam Empty
      /// </summary>
      /// <param name="rdr">Rzutowany obiekt SqlDtaReader</param>
      public static Guid IsNullGuid( object rdr ) {
         if ( rdr == null || rdr == DBNull.Value )
            return Guid.Empty;
         else
            return (Guid)rdr;
      }
      //------------------------------------------------------------------------------------
      // z bool

      /// <summary>
      /// Konwertuje bool na byte
      /// </summary>
      /// <param name="b">Konwertowana wartość logiczna, gdzie true = 1, false = 0</param>
      public static byte BoolToByte( bool b ) {
         if ( b )
            return 1;
         else
            return 0;
      }
      //------------------------------------------------------------------------------------
      // z object

      /// <summary>
      /// Konwertuje object na string
      /// </summary>
      /// <param name="obj">Konwertowana wartość, jeśli błąd to zwraca pusty string</param>
      public static string ObjectToString( object obj ) {
         if ( obj == null )
            return string.Empty;
         try {
            return Convert.ToString( obj );
         }
         catch {
            return string.Empty;
         }
      }
      /// <summary>
      /// Konwertuje object na int
      /// </summary>
      /// <param name="obj">Konwertowana wartość, jeśli błąd to zwraca zero </param>
      public static int ObjectToInt( object obj ) {
         if ( obj == null )
            return 0;
         try {
            return Convert.ToInt32( obj );
         }
         catch {
            return 0;
         }
      }
      /// <summary>
      /// Konwertuje object na decimal
      /// </summary>
      /// <param name="obj">Konwertowana wartość, jeśli błąd to zwraca zero </param>
      public static decimal ObjectToDecimal( object obj ) {
         if ( obj == null )
            return 0;
         try {
            return Convert.ToDecimal( obj );
         }
         catch {
            return 0;
         }
      }

      //------------------------------------------------------------------------------------
      // z string

      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby całkowitej (int), jeśli błąd konwersji zwraca 0
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      public static int StringToInt( string n ) {
         try {
            return int.Parse( n );
         }
         catch {
            return 0;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby całkowitej (int), jeśli błąd konwersji zwraca wartość domyślną
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
      public static int StringToInt( string n, int d ) {
         try {
            return int.Parse( n );
         }
         catch {
            return d;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby całkowitej (Int16), jeśli błąd konwersji zwraca 0
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      public static Int16 StringToInt16( string n ) {
         try {
            return Int16.Parse( n );
         }
         catch {
            return 0;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby całkowitej (Int16), jeśli błąd konwersji zwraca wartość domyślną
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
      public static Int16 StringToInt16( string n, Int16 d ) {
         try {
            return Int16.Parse( n );
         }
         catch {
            return d;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby całkowitej (UInt16), jeśli błąd konwersji zwraca 0
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      public static UInt16 StringToUInt16( string n ) {
         try {
            return UInt16.Parse( n );
         }
         catch {
            return 0;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby całkowitej (UInt16), jeśli błąd konwersji zwraca wartość domyślną
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
      public static UInt16 StringToUInt16( string n, UInt16 d ) {
         try {
            return UInt16.Parse( n );
         }
         catch {
            return d;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby całkowitej (byte), jeśli błąd konwersji zwraca 0
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      public static byte StringToByte( string n ) {
         try {
            return byte.Parse( n );
         }
         catch {
            return 0;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby całkowitej (byte), jeśli błąd konwersji zwraca wartość domyślną
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
      public static byte StringToByte( string n, byte d ) {
         try {
            return byte.Parse( n );
         }
         catch {
            return d;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby (decimal), jeśli błąd konwersji zwraca 0
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      public static decimal StringToDecimal( string n ) {
         try {
            return decimal.Parse( n.Replace( ",", "." ), new CultureInfo( "en-US" ) );
         }
         catch {
            return 0;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby (decimal), jeśli błąd konwersji zwraca wartość domyślną
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
      public static decimal StringToDecimal( string n, decimal d ) {
         try {
            return decimal.Parse( n.Replace( ",", "." ), new CultureInfo( "en-US" ) );
         }
         catch {
            return d;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby (double), jeśli błąd konwersji zwraca 0
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      public static double StringToDouble( string n ) {
         try {
            return double.Parse( n.Replace( ",", "." ), new CultureInfo( "en-US" ) );
         }
         catch {
            return 0;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do liczby (double), jeśli błąd konwersji zwraca wartość domyślną
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
      public static double StringToDouble( string n, double d ) {
         try {
            return double.Parse( n.Replace( ",", "." ), new CultureInfo( "en-US" ) );
         }
         catch {
            return d;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do daty (DateTime), jeśli błąd konwersji zwraca wartość YEmptyDateTime()
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      public static DateTime StringToDatetime( string n ) {
         try {
            return DateTime.Parse( n ); // zgodnie z bieżącą kulturą
         }
         catch {
            return DateTime.MinValue;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do daty (DateTime), jeśli błąd konwersji zwraca wartość domyślną
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
      public static DateTime StringToDatetime( string n, DateTime d ) {
         try {
            return DateTime.Parse( n ); // zgodnie z bieżącą kulturą 
         }
         catch {
            return d;
         }
      }
      /// <summary>
      /// Konwertuje łańcuch znaków (string) do formatu logicznego (bool)
      /// <para> Konwertuje teksty true/false lub wartości liczbowe 0 - false, każda inna liczba - true </para> 
      /// <para> Jeśli błąd konwersji zwraca wartość domyślną </para>
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      /// <param name="d">Domyślna wartość w przypadku błędu konwersji</param>
      public static bool StringToBool( string n, bool d ) {
         int i;

         try { // próbujmy standard 
            return bool.Parse( n );
         }
         catch {
         }

         try { // może int
            i = int.Parse( n );
         }
         catch {
            return d;
         }
         if ( i != 0 )
            return true;
         else
            return false;
      }
      /// <summary>
      /// Konwertuje liczbę na wartość logiczną, jeśli liczba różna od zera to true
      /// </summary>
      /// <param name="n">Liczba całkowita</param>
      public static bool IntToBool( int n ) {
         if ( n != 0 )
            return true;
         else
            return false;
      }

      /// <summary>
      /// Konwertuje liczbę na wartość logiczną, jeśli liczba różna od zera to true
      /// </summary>
      /// <param name="n">Liczba całkowita</param>
      public static bool ByteToBool( byte n ) {
         if ( n != 0 )
            return true;
         else
            return false;
      }

      /// <summary>
      /// Konwertuje łańcuch znaków (string) do formatu logicznego (bool), próbuje konwertować teksty true/false lub 1/0, jeśli błąd to zwraca false
      /// </summary>
      /// <param name="n">Konwertowany łańcuch znaków</param>
      public static bool IsParseBool( string n ) {
         int i;

         try { // próbujmy standard 
            return bool.Parse( n );
         }
         catch {
         }

         try { // może int
            i = int.Parse( n );
         }
         catch {
            return false;
         }
         if ( i != 0 )
            return true;
         else
            return false;
      }
      //------------------------------------------------------------------------------------
      // funkcje do konwersji integracyjnych
      //

      /// <summary>
      /// Funkcja zwraca datę w formacie Clarion
      /// </summary>
      /// <param name="dt">Konwertowana data</param>
      /// <returns>Data w formacje Clarion</returns>
      public static int DateTimeToClarionDate( DateTime dt ) {
         int ret = 0;

         DateTime start = new DateTime( 1800, 12, 28 );
         long elapsed = dt.Ticks - start.Ticks;
         TimeSpan diff = new TimeSpan( elapsed );
         ret = (int)diff.TotalDays;

         return ret;
      }
      /// <summary>
      /// Funkcja zwraca godzinę w formacie Clarion 
      /// </summary>
      /// <param name="dt">Konwertowany czas</param>
      /// <returns>Godzina w formacje Clarion</returns>
      public static int DateTimeToClarionTime( DateTime dt ) {
         int ret = 0;

         ret = ( dt.TimeOfDay.Seconds * 100 ) + ( dt.TimeOfDay.Minutes * 6000 ) + ( dt.TimeOfDay.Hours * 360000 ) + 1;

         return ret;
      }
      /// <summary>
      /// Konwersja daty i godz Clarion na format DateTime
      /// </summary>
      /// <param name="date">Data w formacie Clarion</param>
      /// <param name="time">Godzina w formacie Clarion</param>
      /// <returns></returns>
      public static DateTime ClarionDateTimeToDateTime( int date, int time ) {
         DateTime ret = new DateTime( 1800, 12, 28 );
         ret = ret.AddDays( (double)date );

         //kalkulacja czasu
         int t = time - 1; // bo w trakcie tworzenia czasu w formacie Clarion dodajemy 1
         int h = t / 360000;
         int m = ( t % 360000 ) / 6000;
         int s = ( ( t % 360000 ) % 6000 ) / 100;

         return ret + new TimeSpan( h, m, s );
         ;
      }
      //------------------------------------------------------------------------------------
      // inne różności 


      /// <summary>
      /// Metoda zwraca true jeśli łańcuch znaków n jest poprawną liczbą -123.44
      /// </summary>
      /// <param name="n">Testowany łańcuch znaków</param>
      /// <returns></returns>
      public static bool IsNumeric( string n ) {
         bool ret = false;

         try {
            decimal d = decimal.Parse( n, new CultureInfo( "en-US" ) );
            ret = true;
         }
         catch { };

         return ret;
      }

      /// <summary>
      /// Funkcja zwraca standardowo jak string.substring, przy czym maskuje wyjątki przekroczenia indeksów i zwraca tylko to co można 
      /// </summary>
      public static string SubString( string sStr, int nOd, int nDlugosc ) {
         //--kontrola
         if ( sStr == null )
            return string.Empty;
         if ( ( nOd < 0 ) || ( nDlugosc <= 0 ) )
            return string.Empty;
         if ( sStr.Length < ( nOd + 1 ) )
            return string.Empty;

         //-- ok da sie coś wyciąć
         if ( sStr.Length > ( nOd + nDlugosc ) ) {
            return sStr.Substring( nOd, nDlugosc );
         }
         else {
            nDlugosc = sStr.Length - nOd; // korekta długości
            return sStr.Substring( nOd, nDlugosc );
         }
      }
      /// <summary>
      /// Zmienia pierwsze litery wyrazów na duże litery
      /// </summary>
      /// <param name="value">zamieniany łańcuch znaków</param>
      public static string CapitalizeWords( string value ) {
         if ( value == null )
            return string.Empty;
         if ( value.Length == 0 )
            return string.Empty;

         StringBuilder result = new StringBuilder( value );
         result[0] = char.ToUpper( result[0] );
         for ( int i = 1; i < result.Length; ++i ) {
            if ( char.IsWhiteSpace( result[i - 1] ) )
               result[i] = char.ToUpper( result[i] );
         }
         return result.ToString();
      }
      /// <summary>
      /// Podmienia wybrany znak w łańcuchu znaków
      /// </summary>
      /// <param name="input">podmieniany łańcuch znaków</param>
      /// <param name="index">indeks podmienianego znaku</param>
      /// <param name="c">znak podmieniający</param>
      public static string ReplaceAtIndex( string input, int index, char c ) {

         if ( string.IsNullOrEmpty( input ) ) {
            throw new ArgumentNullException( "ReplaceAtIndex - input jest pusty bądź null" );
         }
         if ( index >= input.Length ) {
            throw new ArgumentOutOfRangeException( "ReplaceAtIndex - index jest poza zakresem" );
         }

         char[] chars = input.ToCharArray();
         chars[index] = c;
         return new string( chars );
      }
      /// <summary>
      /// Ekwiwalent metody string.format z usuwaniem spacji na argumentach string  
      /// </summary>
      /// <param name="format">łańcuch formatujący</param>
      /// <param name="args">lista parametrów</param>
      /// <returns>zwraca formatowany łańcuch znaków</returns>
      public static string StringFormatTrim( string format, params object[] args ) {

         if ( string.IsNullOrEmpty( format ) )
            return string.Empty;

         for ( int i = 0; i < args.Length; i++ ) {
            object o = args[i];
            string t = o as string;
            if ( t != null ) {
               args[i] = t.Trim() as object;
            }
         }
         return string.Format( format, args );
      }

      //public static string ToSQLDatetimeFormat(DateTime dt) {
      //    if (dt == null)
      //        dt = DateTime.MinValue;  new DateTime().YEmptyDateTime();
      //    return "Convert( datetime, '" + string.Format(new CultureInfo("en-US"), "{0:yyyy-MM-dd HH:mm:ss}", dt) + "',120)"; 
      //}
      //------------------------------------------------------------------------------------
      /// <summary>
      /// Metoda zwracająca tekst w formacie HTML
      /// </summary>
      /// <param name="value">Tekst, ktory ma zostać przekształcony na HTML</param>
      /// <returns></returns>
      public static string StringToHTML( string value ) {
         if ( string.IsNullOrEmpty( value ) ) {
            value = string.Empty;
         }
         else {
            char[] tc = { ' ', '\'' };
            value = value.Trim( tc );
            for ( int i = 0; i <= 6; i++ ) {
               value = value.Replace( _znakiHtml[i, 0], _znakiHtml[i, 1] );
            }
         }
         return value;
      }
      /// <summary>
      /// Zamienia łańcuch znaków na tablice bytes usuwając znak kierunku czytania BOM
      /// </summary>
      /// <param name="value">łańcuch znaków</param>
      /// <param name="codePage">strona kodowa</param>
      /// <returns>zwraca tablicę znaków lib null</returns>
      public static byte[] StringToByteArrayWithoutBOM( string value, int codePage ) {
         byte[] ret = null;
         if ( value != null )
            ret = Encoding.GetEncoding( codePage ).GetBytes( value.Trim().Trim( new char[] { '\uFEFF', '\u200B' } ) );
         return ret;
      }
   }
}

