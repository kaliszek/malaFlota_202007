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
   public partial class FormAddTrase : Form {

      public FormAddTrase( FormAkcja c, XTrasa t = null ) {
         InitializeComponent();
         this.Icon = Zasoby.Properties.Resources.MalaFlota;
         _akcja = c;
         _trasa = t;
         KierowcyLista();
         PojazdyLista();


         btZatwierdz.Image = Zasoby.Properties.Resources.ok;
         btZatwierdz.ImageAlign = ContentAlignment.MiddleLeft;
         btZatwierdz.TextAlign = ContentAlignment.MiddleRight;

         btPorzuc.Image = Zasoby.Properties.Resources.cancel;
         btPorzuc.ImageAlign = ContentAlignment.MiddleLeft;
         btPorzuc.TextAlign = ContentAlignment.MiddleRight;




   

      }

      private void FormAddTrase_Load_1( object sender, EventArgs e ) {

         switch ( _akcja ) {
            case FormAkcja.Dopisz:
               this.Text = "Nowa trasa";
               _trasa = new XTrasa();
               break;
            case FormAkcja.Popraw:
               this.Text = "Popraw trasę";
               cbPojazd.SelectedValue = _trasa.Id_Pojazd_Trasa;
               cbKierowca.SelectedValue = _trasa.Id_Kierowca_Trasa;
               tbLicznikP.Text = _trasa.Stan_Licz_Pocz.ToString();
               tbLicznikK.Text = _trasa.Stan_Licz_Koniec.ToString();
               cbZakoncz.Checked = _trasa.Koniec_Trasa;
               break;
            case FormAkcja.Usun:
               if ( MessageBox.Show( "Czy usunąć wybrany rekord ?", "Pytanie", MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.Yes ) {
                  _trasa.Usun();
                  DialogResult = DialogResult.OK;
               }
               else {
                  DialogResult = DialogResult.Cancel;
               }
               this.Close();
               break;
         }
      }

      private void btZatwierdz_Click_1( object sender, EventArgs e ) {

         _trasa.Id_Pojazd_Trasa = Narzedzia.IsNullInt( cbPojazd.SelectedValue );
         _trasa.Id_Kierowca_Trasa = Narzedzia.IsNullInt( cbKierowca.SelectedValue );
         _trasa.Stan_Licz_Pocz = Narzedzia.StringToDecimal( tbLicznikP.Text );
         _trasa.Stan_Licz_Koniec = Narzedzia.StringToDecimal( tbLicznikK.Text );
         _trasa.Data_Wyjazd = dtDataW.Value;
         _trasa.Data_Przyjazd = dtDataP.Value;
         _trasa.Koniec_Trasa = cbZakoncz.Checked;

         switch ( _akcja ) {
            case FormAkcja.Dopisz:
               _trasa.Dopisz();
               break;
            case FormAkcja.Popraw:
               _trasa.Popraw();
               break;
         }
      }

      private void btPorzuc_Click( object sender, EventArgs e ) {
         this.Close();
      }

      private void KierowcyLista() {
         XKierowcy lk = new XKierowcy();
         lk.DajListe();
         cbKierowca.DataSource = lk.Lista;
         cbKierowca.DisplayMember = "NAZWISKO";
         cbKierowca.ValueMember = "ID";

      }

      private void PojazdyLista() {
         XPojazdy lp = new XPojazdy();
         lp.DajListePojazdow();
         cbPojazd.DataSource = lp.ListaPojazdow;
         cbPojazd.DisplayMember = "NR_REJ";
         cbPojazd.ValueMember = "ID_POJAZD";
         

      }

     
         
         
      private FormAkcja _akcja = FormAkcja.Brak;
      private XTrasa _trasa;

      private void tbLicznikP_Validating(object sender, CancelEventArgs e)
      {
          TextBox tbLicznikP = sender as TextBox;
          float value;
          if (float.TryParse(tbLicznikP.Text.Trim(), out value))
          {
              //informujesz że wpisana wartość jest poprawna
              tbLicznikP.ForeColor = Color.Green;
          }
          else
          {
              //informujesz że wpisana wartość nie jest poprawna
              e.Cancel = true;
              tbLicznikP.BackColor = Color.Red;
              errorProvider1.SetError(sender as TextBox, "Podaj Stan Licznika!");
              
          }
      }

      private void tbLicznikK_Validating(object sender, CancelEventArgs e)
      {
          TextBox tbLicznikK = sender as TextBox;
          float value;
          if (float.TryParse(tbLicznikK.Text.Trim(), out value))
          {
             
              tbLicznikK.ForeColor = Color.Green;
          }
          else
          {
              
              e.Cancel = true;
              tbLicznikK.BackColor = Color.Red;
              errorProvider1.SetError(sender as TextBox, "Podaj Stan Licznika!");

          }
      }
   }

}











