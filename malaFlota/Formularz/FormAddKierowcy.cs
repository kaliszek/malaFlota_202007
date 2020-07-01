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


namespace Formularz
{
    public partial class FormAddKierowcy : Form
    {

        FormAkcja _akcja = FormAkcja.Brak;
        private XKierowca _kierowca;
        public FormAddKierowcy( FormAkcja a, XKierowca k = null)
        {
            InitializeComponent();
            _akcja = a;
            _kierowca = k;
            tbImie.MaxLength = 20;

         }
       
        private void FormAddKierowcy_Load(object sender, EventArgs e)
        {
            
            switch (_akcja)
            {
                case FormAkcja.Dopisz:
                    _kierowca = new XKierowca();
                    break;
                case FormAkcja.Popraw:
                    tbImie.Text = _kierowca.Imie;
                    tbNazwisko.Text = _kierowca.Nazwisko;
                    tbPesel.Text = _kierowca.Pesel;
                    tbMiasto.Text = _kierowca.Miasto;
                    tbUlica.Text = _kierowca.Ulica;
                    tbKodPoczta.Text = _kierowca.KodP;
                    tbPoczta.Text = _kierowca.Poczta;
                    tbNrDomu.Text = _kierowca.Nr_Domu;
                    tbNrLok.Text = _kierowca.Nr_Lokalu;
                    tbDataUrodzenia.Value = (DateTime)_kierowca.Data_Ur;
                    tbDataBadLek.Value = (DateTime)_kierowca.Data_Bad_Lek;
                    tbTelefon1.Text = _kierowca.Tel1;
                    tbTelefon2.Text = _kierowca.Tel2;
                    chbKatA.Checked = _kierowca.KatA;
                    chbKatB.Checked = _kierowca.KatB;
                    chbKatC.Checked = _kierowca.KatC;
                    chbKatD.Checked = _kierowca.KatD;
                    tbUprawnienia.Text = _kierowca.Uprawnienia;
                    break;
            }
        }


            

        private void btZatwierdz_Click(object sender, EventArgs e)
        {

            switch (_akcja)
            {
                case FormAkcja.Dopisz:
                     _kierowca.Imie = tbImie.Text;
                     _kierowca.Nazwisko = tbNazwisko.Text;
                     _kierowca.Pesel = tbPesel.Text;
                     _kierowca.Miasto = tbMiasto.Text;
                     _kierowca.Ulica = tbUlica.Text;
                     _kierowca.KodP = tbKodPoczta.Text;
                     _kierowca.Poczta = tbPoczta.Text;
                     _kierowca.Nr_Domu = tbNrDomu.Text;
                     _kierowca.Nr_Lokalu = tbNrLok.Text;
                     _kierowca.Data_Ur = tbDataUrodzenia.Value;
                     _kierowca.Data_Bad_Lek = tbDataBadLek.Value;
                     _kierowca.Tel1 = tbTelefon1.Text;
                     _kierowca.Tel2 = tbTelefon2.Text;
                     _kierowca.KatA = chbKatA.Checked;
                     _kierowca.KatB = chbKatB.Checked;
                     _kierowca.KatC = chbKatC.Checked;
                     _kierowca.KatD = chbKatD.Checked;
                     _kierowca.Uprawnienia = tbUprawnienia.Text;
                     _kierowca.Dopisz();
                    break;
                case FormAkcja.Popraw:
                     _kierowca.Imie = tbImie.Text;
                     _kierowca.Nazwisko = tbNazwisko.Text;
                     _kierowca.Pesel = tbPesel.Text;
                     _kierowca.Miasto = tbMiasto.Text;
                     _kierowca.Ulica = tbUlica.Text;
                     _kierowca.KodP = tbKodPoczta.Text;
                     _kierowca.Poczta = tbPoczta.Text;
                     _kierowca.Nr_Domu = tbNrDomu.Text;
                     _kierowca.Nr_Lokalu = tbNrLok.Text;
                     _kierowca.Data_Ur = tbDataUrodzenia.Value;
                     _kierowca.Data_Bad_Lek = tbDataBadLek.Value;
                     _kierowca.Tel1 = tbTelefon1.Text;
                     _kierowca.Tel2 = tbTelefon2.Text;
                     _kierowca.KatA = chbKatA.Checked;
                     _kierowca.KatB = chbKatB.Checked;
                     _kierowca.KatC = chbKatC.Checked;
                     _kierowca.KatD = chbKatD.Checked;
                     _kierowca.Uprawnienia = tbUprawnienia.Text;
                     _kierowca.Popraw();
                    break;
            }

              
        }

        private void btPorzuc_Click(object sender, EventArgs e)
        {

            
        } 

        private void dopisuje(XKierowca A)
        {

        }

        

       
    }

}
          


        





