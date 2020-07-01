using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrystalReport {
   /// <summary>
   /// Klasa przekazująca parametry i formuły do raportu 
   /// </summary>
   public class RaportCRParametr {
      /// <summary>
      /// Nazwa parametru lub formuły
      /// </summary>
      public string Name { get; set; }
      /// <summary>
      /// Wartość parametru lub formuły
      /// </summary>
      public string Value { get; set; }
      /// <summary>
      /// Ustawia nazwę i wartość
      /// </summary>
      /// <param name="n">Nazwa parametru lub formuły</param>
      /// <param name="v">Wartość parametru lub formuły</param>
      public RaportCRParametr( string n, string v) {
         Name = n;
         Value = v;
      }
   }
}
