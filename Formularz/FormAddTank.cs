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
   public partial class FormAddTank : Form {

      public FormAddTank( FormAkcja d, XTankowanie ta = null, XTrasa tr = null ) {
         InitializeComponent();
         this.Icon = Zasoby.Properties.Resources.MalaFlota;
         _akcja = d;
         _tank = ta;
         _trasa = tr;
         PaliwoLista();

         btDopisz.Image = Zasoby.Properties.Resources.ok;
         btDopisz.ImageAlign = ContentAlignment.MiddleLeft;
         btDopisz.TextAlign = ContentAlignment.MiddleRight;

         btPorzuc.Image = Zasoby.Properties.Resources.cancel;
         btPorzuc.ImageAlign = ContentAlignment.MiddleLeft;
         btPorzuc.TextAlign = ContentAlignment.MiddleRight;
      }
      public FormAddTank() {
         InitializeComponent();
          
       
          

          
      }

      private void FormAddTank_Load( object sender, EventArgs e ) {
         switch ( _akcja ) {
            case FormAkcja.Dopisz:
               _tank = new XTankowanie();
               break;
            case FormAkcja.Popraw:
               cbPaliwo.SelectedValue = _tank.Id_Rodzaj_Paliwa_Tank;
               tbIlosc.Text = _tank.Ilosc_Tank.ToString();
               tbDataTank.Value = _tank.Data_Tank;
               tbStanLicznika.Text = _tank.Licznik_Tank.ToString();
               tbWartosc.Text = _tank.Wartosc_Tank.ToString();

               break;
            case FormAkcja.Usun:
               if ( MessageBox.Show( "Czy usunąć wybrany rekord ?", "Pytanie", MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.Yes ) {
                  _tank.Usun();
                  DialogResult = DialogResult.OK;
               }
               else {
                  DialogResult = DialogResult.Cancel;
               }
               this.Close();
               break;
         }
      }

      private void btDopisz_Click( object sender, EventArgs e ) {

         _tank.Id_Trasa_Tank = Narzedzia.IsNullInt( _trasa.Id_Trasa );
         _tank.Id_Pojazd_Tank = Narzedzia.IsNullInt( _trasa.Id_Pojazd_Trasa );
         _tank.Data_Tank = tbDataTank.Value;
         _tank.Ilosc_Tank = Narzedzia.StringToDecimal( tbIlosc.Text );
         _tank.Wartosc_Tank = Narzedzia.StringToDecimal( tbWartosc.Text );
         _tank.Licznik_Tank = Narzedzia.StringToDecimal( tbStanLicznika.Text );
         _tank.Id_Rodzaj_Paliwa_Tank = Narzedzia.IsNullInt( cbPaliwo.SelectedValue );
         switch ( _akcja ) {
            case FormAkcja.Dopisz:
               _tank.Dopisz();
               break;
            case FormAkcja.Popraw:
               _tank.Popraw();
break;
         }
      }

      private void PaliwoLista() {
         XPaliwa lp = new XPaliwa();
         lp.DajListePaliwa();
         cbPaliwo.DataSource = lp.ListaPaliwa;
         cbPaliwo.DisplayMember = "PALIWO_NAZWA";
         cbPaliwo.ValueMember = "ID_PALIWO";
      }
      //-----------------------------------------------------------------------------------------
      // Private 
      private FormAkcja _akcja = FormAkcja.Brak;
      private XTankowanie _tank;
      private XTrasa _trasa;

      private void btDopisz_Validating(object sender, CancelEventArgs e)
      {

           
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        control.Focus();
                        return;
                    }
                }
            }
        

      }

      private void tbIlosc_Validating(object sender, CancelEventArgs e)
      {
          TextBox tbIlosc = sender as TextBox;
          float value;
          if (float.TryParse(tbIlosc.Text.Trim(), out value))
          {
              
              tbIlosc.ForeColor = Color.Green;
          }
          else
          {
              
              e.Cancel = true;
              tbIlosc.BackColor = Color.Red;
              errorProvider1.SetError(sender as TextBox, "Podaj Ilość!");

          }
      }

      private void tbStanLicznika_Validating(object sender, CancelEventArgs e)
      {
          TextBox tbStanLicznika = sender as TextBox;
          float value;
          if (float.TryParse(tbStanLicznika.Text.Trim(), out value))
          {
              
              tbStanLicznika.ForeColor = Color.Green;
          }
          else
          {
            
              e.Cancel = true;
              tbStanLicznika.BackColor = Color.Red;
              errorProvider1.SetError(sender as TextBox, "Podaj Stan Licznika!");

          }
      }

      private void tbWartosc_Validating(object sender, CancelEventArgs e)
      {
          TextBox tbWartosc = sender as TextBox;
          float value;
          if (float.TryParse(tbWartosc.Text.Trim(), out value))
          {
             
              tbWartosc.ForeColor = Color.Green;
          }
          else
          {
             
              e.Cancel = true;
              tbWartosc.BackColor = Color.Red;
              errorProvider1.SetError(sender as TextBox, "Podaj Wartość!");

          }
      }

   

   }

}

