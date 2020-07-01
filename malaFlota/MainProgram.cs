using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace Formularz {

   static class MainProgram {

      [STAThread]
      static void Main() {
         KonfiguracjaGlobalna.ConnectingString = @"Data Source=LENOVO;Initial Catalog=db_malaFlota;Integrated Security=False;User ID=sa;Password=Optima19!;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;";
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );

         Application.Run( (Form)new FormLogin() );
         if ( KonfiguracjaGlobalna.AutoryzacjaPoprawna )
            Application.Run( (Form)new Mainfrm() );

      }
   }
}
