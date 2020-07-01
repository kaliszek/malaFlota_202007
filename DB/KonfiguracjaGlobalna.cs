using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace DB {

   public static class KonfiguracjaGlobalna {

      public static string ConnectingString = string.Empty;
      public static bool AutoryzacjaPoprawna = false;

      public static string Operator = string.Empty;
      public static string Haslo = string.Empty;
      public static string BazaDanych = string.Empty;
      public static string SerwerSQL = string.Empty;


      public static void ReadKonfig() {
         Operator = ConfigurationManager.AppSettings.Get( "user" );
         Haslo = ConfigurationManager.AppSettings.Get( "password" );
         SerwerSQL = ConfigurationManager.AppSettings.Get( "server" );
         BazaDanych = ConfigurationManager.AppSettings.Get( "database" );
      }

      public static void SaveKonfig() {
         
         Configuration config = ConfigurationManager.OpenExeConfiguration( ConfigurationUserLevel.None );
         config.AppSettings.Settings["user"].Value = Operator;
         config.AppSettings.Settings["password"].Value = Haslo;
         config.AppSettings.Settings["server"].Value = SerwerSQL;
         config.AppSettings.Settings["database"].Value = BazaDanych;
         config.Save( ConfigurationSaveMode.Modified );

      }

      public static void SetConnectingString() {
         ConnectingString = string.Format( "Server = {0}; Database = {1}; User Id = {2}; Password = {3}; app=MalaFlota", SerwerSQL, BazaDanych, Operator, Haslo );
      }
   }
}

