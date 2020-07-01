using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB;
using System.IO;
using System.Windows.Forms;


namespace CrystalReport {

   public class RaportWbudowany {
      public enum RaportWbudowanyEnum {
         Brak,
         ListaKierowcow,
         ListaPojazdow,
         ListaWyjazdow,
         Pojazd
   
      }

       public RaportWbudowany() {
         _raport = new RaportCR();
         _raport.server = KonfiguracjaGlobalna.SerwerSQL;
         _raport.db = KonfiguracjaGlobalna.BazaDanych;
         _raport.user = KonfiguracjaGlobalna.Operator;
         _raport.pass = KonfiguracjaGlobalna.Haslo;
        
      }

      public void Wykonaj( RaportWbudowanyEnum r, string s) {
         _raport.parametryRaportu = new List<RaportCRParametr>();
        
         // ustawiamy listę parametrów i formuł z jakimi chcemy wywołać raport
         //_raport.parametryRaportu.Add( new RaportCRParametr( "yu:miasto", "'to jest miasto przekazane'" ) );
        _raport.parametryRaportu.Add(new RaportCRParametr("crId",s));
         
          
          //_raport.parametryRaportu.Add( new RaportCRParametr( "yu:adres2", "'To jest adres użytkownika'+Chr(10)+'drugi wiersz'+Chr(10)+'trzeci'" ) );

         switch ( r ) {
            case RaportWbudowanyEnum.Brak:
               break;
            case RaportWbudowanyEnum.ListaKierowcow:
               _raport.plikRaportuRPT = string.Format( "{0}\\{1}",Path.GetDirectoryName(Application.ExecutablePath),"crListaKierowca.rpt" );
               _raport.GenerujRaportPDF();
               break;
            case RaportWbudowanyEnum.ListaPojazdow:
               _raport.plikRaportuRPT = string.Format( "{0}\\{1}",Path.GetDirectoryName(Application.ExecutablePath),"crListaPojazd.rpt" );
               _raport.GenerujRaportPDF();
               break;
            case RaportWbudowanyEnum.ListaWyjazdow:
               _raport.plikRaportuRPT = string.Format( "{0}\\{1}",Path.GetDirectoryName(Application.ExecutablePath),"crListaWyjazd.rpt" );
               _raport.GenerujRaportPDF();
               break;

            case RaportWbudowanyEnum.Pojazd:
               _raport.plikRaportuRPT = string.Format("{0}\\{1}", Path.GetDirectoryName(Application.ExecutablePath), "crPojazd.rpt");
               _raport.GenerujRaportPDF();
               break;
            default:
               break;
 
         
         }
      }

      private RaportCR _raport = null;
   }
}
