using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;


namespace Formularz {
   public partial class FormTrasy : Form {
      public FormTrasy() {
         InitializeComponent();
          

         btDopiszTrase.Image = Zasoby.Properties.Resources.INSERT;
         btDopiszTrase.ImageAlign = ContentAlignment.MiddleLeft;
         btDopiszTrase.TextAlign = ContentAlignment.MiddleRight;

         btPoprawTrase.Image = Zasoby.Properties.Resources.EDIT;
         btPoprawTrase.ImageAlign = ContentAlignment.MiddleLeft;
         btPoprawTrase.TextAlign = ContentAlignment.MiddleRight;

         btUsunTrase.Image = Zasoby.Properties.Resources.DELETE;
         btUsunTrase.ImageAlign = ContentAlignment.MiddleLeft;
         btUsunTrase.TextAlign = ContentAlignment.MiddleRight;

         btDopiszTank.Image = Zasoby.Properties.Resources.INSERT;
         btDopiszTank.ImageAlign = ContentAlignment.MiddleLeft;
         btDopiszTank.TextAlign = ContentAlignment.MiddleRight;

         btPoprawTank.Image = Zasoby.Properties.Resources.EDIT;
         btPoprawTank.ImageAlign = ContentAlignment.MiddleLeft;
         btPoprawTank.TextAlign = ContentAlignment.MiddleRight;
         
         btUsunTank.Image = Zasoby.Properties.Resources.DELETE;
         btUsunTank.ImageAlign = ContentAlignment.MiddleLeft;
         btUsunTank.TextAlign = ContentAlignment.MiddleRight;


        

         this.Icon = Zasoby.Properties.Resources.MalaFlota;
      }


      private void FormatujListe()
      {

          gvTrasy.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
          gvTrasy.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
          gvTrasy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
          gvTrasy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          gvTrasy.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
          gvTrasy.DefaultCellStyle.BackColor = Color.Empty;
          gvTrasy.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
          gvTrasy.CellBorderStyle = DataGridViewCellBorderStyle.Single;
          gvTrasy.GridColor = SystemColors.ControlDarkDark;

          gvTrasy.ColumnCount = 13;

          gvTrasy.Columns[0].Name = "ID_TRASA";
          gvTrasy.Columns[0].HeaderText = "ID_TRASA";
          gvTrasy.Columns[0].DataPropertyName = "ID_TRASA";
          gvTrasy.Columns[0].Visible = true;

          gvTrasy.Columns[1].Name = "ID_KIEROWCA_TRASA";
          gvTrasy.Columns[1].HeaderText = "ID_KIEROWCA_TRASA";
          gvTrasy.Columns[1].DataPropertyName = "ID_KIEROWCA_TRASA";
          gvTrasy.Columns[1].Visible = false;

          gvTrasy.Columns[2].Name = "ID_POJAZD_TRASA";
          gvTrasy.Columns[2].HeaderText = "ID_POJAZD_TRASA";
          gvTrasy.Columns[2].DataPropertyName = "ID_POJAZD_TRASA";
          gvTrasy.Columns[2].Visible = false;

          gvTrasy.Columns[3].Name = "DATA_WYJAZD";
          gvTrasy.Columns[3].HeaderText = "Data wyjazdu";
          gvTrasy.Columns[3].DataPropertyName = "DATA_WYJAZD";
          gvTrasy.Columns[3].Visible = true;


          gvTrasy.Columns[4].Name = "DATA_PRZYJAZD";
          gvTrasy.Columns[4].HeaderText = "Data powrotu";
          gvTrasy.Columns[4].DataPropertyName = "DATA_PRZYJAZD";
          gvTrasy.Columns[4].Visible = true;

          gvTrasy.Columns[5].Name = "STAN_LICZ_POCZ";
          gvTrasy.Columns[5].HeaderText = "Stan licznika początkowy";
          gvTrasy.Columns[5].DataPropertyName = "STAN_LICZ_POCZ";
          gvTrasy.Columns[5].Visible = true;

          gvTrasy.Columns[6].Name = "STAN_LICZ_KONIEC";
          gvTrasy.Columns[6].HeaderText = "Stan licznika końcowy";
          gvTrasy.Columns[6].DataPropertyName = "STAN_LICZ_KONIEC";
          gvTrasy.Columns[6].Visible = true;

          gvTrasy.Columns[7].Name = "ID_TANK_TRASA";
          gvTrasy.Columns[7].HeaderText = "ID_TANK_TRASA";
          gvTrasy.Columns[7].DataPropertyName = "ID_TANK_TRASA";
          gvTrasy.Columns[7].Visible = false;


          gvTrasy.Columns[8].Name = "KONIEC_TRASA";
          gvTrasy.Columns[8].HeaderText = "KONIEC_TRASA";
          gvTrasy.Columns[8].DataPropertyName = "KONIEC_TRASA";
          gvTrasy.Columns[8].Visible = false;

          gvTrasy.Columns[9].Name = "NAZWISKO";
          gvTrasy.Columns[9].HeaderText = "NAZWISKO";
          gvTrasy.Columns[9].DataPropertyName = "NAZWISKO";
          gvTrasy.Columns[9].Visible = true;

          gvTrasy.Columns[10].Name = "IMIE";
          gvTrasy.Columns[10].HeaderText = "IMIE";
          gvTrasy.Columns[10].DataPropertyName = "IMIE";
          gvTrasy.Columns[10].Visible = false;

          gvTrasy.Columns[11].Name = "ID_KIEROWCA";
          gvTrasy.Columns[11].HeaderText = "ID_KIEROWCA";
          gvTrasy.Columns[11].DataPropertyName = "ID_KIEROWCA";
          gvTrasy.Columns[11].Visible = false;

          gvTrasy.Columns[12].Name = "ID_POJAZD";
          gvTrasy.Columns[12].HeaderText = "ID_POJAZD";
          gvTrasy.Columns[12].DataPropertyName = "ID_POJAZD";
          gvTrasy.Columns[12].Visible = false;


          gvTankowania.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
          gvTankowania.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
          gvTankowania.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
          gvTankowania.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          gvTankowania.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
          gvTankowania.DefaultCellStyle.BackColor = Color.Empty;
          gvTankowania.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
          gvTankowania.CellBorderStyle = DataGridViewCellBorderStyle.Single;
          gvTankowania.GridColor = SystemColors.ControlDarkDark;


          gvTankowania.ColumnCount = 8;

          gvTankowania.Columns[0].Name = "ID_TANK";
          gvTankowania.Columns[0].HeaderText = "ID_TANK";
          gvTankowania.Columns[0].DataPropertyName = "ID_TANK";
          gvTankowania.Columns[0].Visible = false;

          gvTankowania.Columns[1].Name = "ID_TRASA_TANK";
          gvTankowania.Columns[1].HeaderText = "ID_TRASA_TANK";
          gvTankowania.Columns[1].DataPropertyName = "ID_TRASA_TANK";
          gvTankowania.Columns[1].Visible = false;
          

          gvTankowania.Columns[2].Name = "ID_POJAZD_TANK";
          gvTankowania.Columns[2].HeaderText = "ID_POJAZD_TANK";
          gvTankowania.Columns[2].DataPropertyName = "ID_POJAZD_TANK";
          gvTankowania.Columns[2].Visible = false;

          gvTankowania.Columns[3].Name = "DATA_TANK";
          gvTankowania.Columns[3].HeaderText = "Data tankowania";
          gvTankowania.Columns[3].DataPropertyName = "DATA_TANK";
          gvTankowania.Columns[3].Visible = true;
                
          
          gvTankowania.Columns[4].Name = "ILOSC_TANK";
          gvTankowania.Columns[4].HeaderText = "Ilość zatankowano";
          gvTankowania.Columns[4].DataPropertyName = "ILOSC_TANK";
          gvTankowania.Columns[4].Visible = true;

          gvTankowania.Columns[5].Name = "LICZNIK_TANK";
          gvTankowania.Columns[5].HeaderText = "Stan licznika";
          gvTankowania.Columns[5].DataPropertyName = "LICZNIK_TANK";
          gvTankowania.Columns[5].Visible = true;

          gvTankowania.Columns[6].Name = "WARTOSC_TANK";
          gvTankowania.Columns[6].HeaderText = "Kwota brutto";
          gvTankowania.Columns[6].DataPropertyName = "WARTOSC_TANK";
          gvTankowania.Columns[6].Visible = true;

          gvTankowania.Columns[7].Name = "ID_RODZAJ_PALIWA_TANK";
          gvTankowania.Columns[7].HeaderText = "ID_RODZAJ_PALIWA_TANK";
          gvTankowania.Columns[7].DataPropertyName = "ID_RODZAJ_PALIWA_TANK";
          gvTankowania.Columns[7].Visible = false;
      }
       
       
       
       
       
       private void FormTrasy_Load( object sender, EventArgs e ) {
           FormatujListe();
           OdswierzListeTras();
 
      }

      // Obsługa Trasa
      private void OdswierzListeTras() {

         List<XTrasa_Kierowca_Pojazd> tKP = new List<XTrasa_Kierowca_Pojazd>();
         XTrasy lT = new XTrasy();
         lT.DajListe( string.Format( " isnull(KONIEC_TRASA,0)=0 " ) );
         foreach (XTrasa t in lT.Lista)
         {
             XTrasa_Kierowca_Pojazd tkp = new XTrasa_Kierowca_Pojazd();
             tkp.UstawKierowcePojazd(t);
             tkp.UstawKierowce(new XKierowca (t.Id_Kierowca_Trasa));
             tkp.UstawPojazd(new XPojazd(t.Id_Pojazd_Trasa));
             tKP.Add(tkp);
         }


         gvTrasy.DataSource = tKP;
      }

      
  

      
      // Obsługa Button Trasa
      private void btDopiszTrase_Click( object sender, EventArgs e ) {
         FormAddTrase dopiszPoprawTrasa = new FormAddTrase( FormAkcja.Dopisz, null );
         switch ( dopiszPoprawTrasa.ShowDialog() ) {
            case System.Windows.Forms.DialogResult.OK:
               OdswierzListeTras();
               break;
            default:

               break;
         }
      }
      private void btPoprawTrase_Click( object sender, EventArgs e ) {
         Object id = gvTrasy.CurrentRow.Cells["ID_TRASA"].Value;
         if ( id != null ) {
            int id_trasa = Narzedzia.ObjectToInt( id );
            XTrasa t = new XTrasa( id_trasa );
            FormAddTrase dopiszPoprawTrasa = new FormAddTrase( FormAkcja.Popraw, t );
            switch ( dopiszPoprawTrasa.ShowDialog() ) {
               case System.Windows.Forms.DialogResult.OK:
                  OdswierzListeTras();
                  break;
               default:
                  break;
            }

         }

      }
      private void btUsunTrase_Click( object sender, EventArgs e ) {
         Object id = gvTrasy.CurrentRow.Cells["ID_TRASA"].Value;
         if ( id != null ) {
            int id_trasa = Narzedzia.ObjectToInt( id );
            XTrasa t = new XTrasa( id_trasa );
            FormAddTrase dopiszPoprawTrasa = new FormAddTrase( FormAkcja.Usun, t );
            switch ( dopiszPoprawTrasa.ShowDialog() ) {
               case System.Windows.Forms.DialogResult.OK:
                  OdswierzListeTras();
                  break;
               default:
                  break;
            }

         }
      }
      // Obsługa Tank 
      private void OdswiezTankowania( XTrasa t ) {
         XTankowania lTank = new XTankowania();
         lTank.DajListe( string.Format( "{0}={1}", t.Id_Trasa, "ID_TRASA_TANK" ) );
         gvTankowania.DataSource = lTank.Lista;
         // wykonaj kalkulacje i wpisz
         lRazemIloscW.Text = "0";
         lRazemWartoscW.Text = "0.00";
         lRazemOdlegloscW.Text = "0";
         lSrednia100W.Text = "0";
         if ( lTank.Lista.Count > 0 ) {
            decimal razemIlosc = lTank.Lista.Sum( x => x.Ilosc_Tank );
            decimal razemWartosc = lTank.Lista.Sum( x => x.Wartosc_Tank );
            decimal minLicznik = lTank.Lista.Min( x => x.Licznik_Tank );
            decimal maxLicznik = lTank.Lista.Max( x => x.Licznik_Tank );
            decimal razemOdleglosc = maxLicznik - minLicznik;
            lRazemIloscW.Text = string.Format( "{0:0.00}", razemIlosc );
            lRazemWartoscW.Text = string.Format( "{0:0.00}", razemWartosc );
            lRazemOdlegloscW.Text = string.Format( "{0}", razemOdleglosc );
            if ( razemOdleglosc > 0 )
               lSrednia100W.Text = string.Format( "{0:0.0000}", ( razemIlosc/razemOdleglosc ) * 100 );
         }
      }
      // Obsługa Button Tank
      private void btDopiszTank_Click( object sender, EventArgs e ) {
         if ( _trasaUstawiona != null ) {
            FormAddTank dopiszPoprawTank = new FormAddTank( FormAkcja.Dopisz, null, _trasaUstawiona );
            switch ( dopiszPoprawTank.ShowDialog() ) {
               case System.Windows.Forms.DialogResult.OK:
                  OdswiezTankowania( _trasaUstawiona );
                  break;
               default:
                  break;
            }

         }
      }
      private void btPoprawTank_Click( object sender, EventArgs e ) {
         Object id = gvTankowania.CurrentRow.Cells["ID_TANK"].Value;
         if ( id != null ) {
            int id_trasa = Narzedzia.ObjectToInt( id );
            XTankowanie t = new XTankowanie( id_trasa );
            FormAddTank dopiszPoprawTrasa = new FormAddTank( FormAkcja.Popraw, t, _trasaUstawiona );
            switch ( dopiszPoprawTrasa.ShowDialog() ) {
               case System.Windows.Forms.DialogResult.OK:
                  OdswiezTankowania( _trasaUstawiona );
                  break;
               default:
                  break;
            }
         }
      }
      private void btUsunTank_Click( object sender, EventArgs e ) {
         Object id = gvTankowania.CurrentRow.Cells["ID_TANK"].Value;
         if ( id != null ) {
            int id_trasa = Narzedzia.ObjectToInt( id );
            XTankowanie t = new XTankowanie( id_trasa );
            FormAddTank dopiszPoprawTrasa = new FormAddTank( FormAkcja.Usun, t, _trasaUstawiona );
            switch ( dopiszPoprawTrasa.ShowDialog() ) {
               case System.Windows.Forms.DialogResult.OK:
                  OdswiezTankowania( _trasaUstawiona );
                  break;
               default:
                  break;
            }
         }
      }
      private void gvTrasy_SelectionChanged( object sender, EventArgs e ) {
         Object id = gvTrasy.CurrentRow.Cells["ID_TRASA"].Value;
         if ( id != null ) {
            int id_trasa = Narzedzia.ObjectToInt( id );
            XTrasa t = new XTrasa( id_trasa );
            OdswiezTankowania( t );
            _trasaUstawiona = t;
            btDopiszTank.Enabled = true;
            btPoprawTank.Enabled = true;
            btUsunTank.Enabled = true;
         }
         else {
            _trasaUstawiona = null;
            btDopiszTank.Enabled = false;
            btPoprawTank.Enabled = false;
            btUsunTank.Enabled = false;
         }
      }

      private XTrasa _trasaUstawiona = null;

      

   }
}




