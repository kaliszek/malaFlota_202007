using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz {
   public partial class FormLogin : Form {
      public FormLogin() {
         InitializeComponent();

         this.Icon = Zasoby.Properties.Resources.login;
         this.AcceptButton = btOK;
         this.CancelButton = btCancel;

         btOK.Image = Zasoby.Properties.Resources.ok;
         btOK.ImageAlign = ContentAlignment.MiddleLeft;
         btCancel.Image = Zasoby.Properties.Resources.cancel;
         btCancel.ImageAlign = ContentAlignment.MiddleLeft;
         btCancel.TextAlign = ContentAlignment.MiddleRight;

         KonfiguracjaGlobalna.ReadKonfig();
         tbOperator.Text = KonfiguracjaGlobalna.Operator;
         tbHaslo.Text = KonfiguracjaGlobalna.Haslo;
         tbDB.Text = KonfiguracjaGlobalna.BazaDanych;
         tbServer.Text = KonfiguracjaGlobalna.SerwerSQL;

      }
      private void btOK_Click( object sender, EventArgs e ) {


         KonfiguracjaGlobalna.Operator = tbOperator.Text;
         KonfiguracjaGlobalna.Haslo = tbHaslo.Text;
         KonfiguracjaGlobalna.BazaDanych = tbDB.Text;
         KonfiguracjaGlobalna.SerwerSQL = tbServer.Text;

         KonfiguracjaGlobalna.SetConnectingString();
         // str. połączenie prze przykładowe wywołanie 
         try {
            XPojazdy lp = new XPojazdy();
            lp.DajListePojazdow();
           
            KonfiguracjaGlobalna.AutoryzacjaPoprawna = true;
         }
         catch { }

         if ( !KonfiguracjaGlobalna.AutoryzacjaPoprawna )
            MessageBox.Show( "Niepoprawna autoryzacja. Ustal poprawne parametry autoryzacji !", "Ostrzeżenie" );

         this.Close();
      }

      private void btCancel_Click( object sender, EventArgs e ) {
         KonfiguracjaGlobalna.AutoryzacjaPoprawna = false;
         this.Close();
      }
   }
}
