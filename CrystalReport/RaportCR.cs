using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;

namespace CrystalReport {


   /// <summary>
   /// Klasa do wywołania raportów napisanych w CR
   /// </summary>
   public class RaportCR {

      public string plikRaportuRPT = string.Empty;
      public string server = string.Empty;
      public string db = string.Empty;
      public string user = string.Empty;
      public string pass = string.Empty;
      public List<RaportCRParametr> parametryRaportu = null;

      public string GenerujRaportPDF() {
         string ret = string.Empty;
         string portableDocFormatFile = string.Empty;

         //-- kontrola formalna 
         if ( !File.Exists( plikRaportuRPT ) ) {
            string aktualny_folder = System.IO.Directory.GetCurrentDirectory(); // 
            return ret;
         }

         //-- wołamy raport 
          try {
            _report = new ReportDocument();
             _report.Load( plikRaportuRPT);
             if (_report.IsLoaded) {

                //-- ustawiamy parametry raportu 
                foreach ( ParameterFieldDefinition pfd in _report.DataDefinition.ParameterFields ) 
                   if ( parametryRaportu.Where( p => p.Name == pfd.Name ).Count() != 0) 
                      _report.SetParameterValue( pfd.Name, parametryRaportu.Find( p => p.Name == pfd.Name).Value);

                //-- ustawiamy formuły raportu 
                foreach ( FormulaFieldDefinition ffd in _report.DataDefinition.FormulaFields )
                   if ( parametryRaportu.Where( p => p.Name == ffd.Name ).Count() != 0 )
                      ffd.Text = parametryRaportu.Find( p => p.Name == ffd.Name).Value;

                //-- ustawiamy _report.RecordSelectionFormula
                ApplyLogonInfo();

                portableDocFormatFile = Path.GetTempPath() + Guid.NewGuid().ToString() + ".pdf";
                _report.ExportToDisk( ExportFormatType.PortableDocFormat, portableDocFormatFile );
                //-- wywołaj proces windows 
                System.Diagnostics.Process.Start( portableDocFormatFile );
             }

             ret = portableDocFormatFile; // wygląda że jest dobrze 
          }
         catch {
            throw;
         }
         finally {
            if ( _report != null ) {
               _report.Close();
               _report.Dispose();
               _report = null;
            }
          }
         return ret;
      }

      //-----------------------------------------------------------------------------------------------
      // Private 


      /// <summary>
      /// Ustawia połączenie w wydruku CR
      /// </summary>
      private void ApplyLogonInfo() {
         ConnectionInfo ci = new ConnectionInfo();
         ci.AllowCustomConnection = true;

         if ( !String.IsNullOrEmpty( server ) && !String.IsNullOrEmpty( db ) && !String.IsNullOrEmpty( user ) ) {
            ci.ServerName = "Driver={SQL Server};Server=" + server + ";";
            ci.DatabaseName = db;
            ci.UserID = user;
            ci.Password = pass;
         }
         TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
         tableLogOnInfo.ConnectionInfo = ci;

         if ( !String.IsNullOrEmpty( ci.ServerName ) ) {
            foreach ( IConnectionInfo dsc in _report.DataSourceConnections ) {
               dsc.SetConnection( ci.ServerName, ci.DatabaseName, ci.UserID, ci.Password );
            }
            foreach ( Table t in _report.Database.Tables ) {
               t.ApplyLogOnInfo( tableLogOnInfo );
            }
            foreach ( ReportDocument r in _report.Subreports ) {
               foreach ( Table t in r.Database.Tables ) {
                  t.ApplyLogOnInfo( tableLogOnInfo );
               }
            }

         }

      }

      private ReportDocument _report;
   }
}
