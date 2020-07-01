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
    public partial class FormAddPojazdy : Form
    {

        FormAkcja _akcja = FormAkcja.Brak;
        private XPojazd _pojazd;
        private XPaliwo _paliwo;
        private XRodzaj _rodzaj;
        public FormAddPojazdy(FormAkcja b, XPojazd p = null)
        {
            InitializeComponent();
            _akcja = b;
            _pojazd = p;
            PaliwaLista();
            RodzajLista();

            btZatwierdz.Image = Zasoby.Properties.Resources.ok;
            btZatwierdz.ImageAlign = ContentAlignment.MiddleLeft;
            btZatwierdz.TextAlign = ContentAlignment.MiddleRight;

            btPorzuc.Image = Zasoby.Properties.Resources.cancel;
            btPorzuc.ImageAlign = ContentAlignment.MiddleLeft;
            btPorzuc.TextAlign = ContentAlignment.MiddleRight;


        }

        private void FormAddPojazdy_Load(object sender, EventArgs e)
        {
            switch (_akcja)
            {
                case FormAkcja.Dopisz:
                    _pojazd = new XPojazd();
                    break;
                case FormAkcja.Popraw:  
                    tbNrRej.Text = _pojazd.Nr_Rej;
                    tbMarka.Text = _pojazd.Marka;
                    tbModel.Text = _pojazd.Model;
                    tbPojemnosc.Text =Convert.ToString (  _pojazd.Pojemnosc);
                    tbRokPr.Text = _pojazd.Rok_Prod;
                    tbRokPr.Text = _pojazd.Rok_Prod;
                    tbNrSilnika.Text = Convert.ToString(_pojazd.Nr_Silnik);
                    tbNrNadwozia.Text = _pojazd.Nr_Nadwozie;
                    tbPojBak.Text = Convert.ToString(_pojazd.Zbiornik);
                    tbLiczStPocz.Text = Convert.ToString(_pojazd.Stan_Licz_Pocz);
                    tbNumerOC.Text = _pojazd.Numer_Oc;
                    tbDataOC.Value = (DateTime)_pojazd.Data_Oc;
                    chbUbezAC.Checked = _pojazd.Polisa_Ac;
                    tbNumerAC.Text = _pojazd.Numer_Oc;
                    tbDataAC.Value = (DateTime)_pojazd.Data_Ac;
                    tbBadTech.Value = (DateTime)_pojazd.Data_Bad_Tech;
                    tbStLiczPT.Text = Convert.ToString(_pojazd.Licz_Bad_Tech);
                    tbGwarancjaDo.Value = (DateTime)_pojazd.Data_Gwarancja;
                    chbGwarancja.Checked = _pojazd.Gwarancja;
                    tbStLiczG.Text = Convert.ToString(_pojazd.Stan_Licz_Gwar);
                    _paliwo = new XPaliwo(_pojazd.Id_Paliwo_Pojazd);
                    cbPaliwo.SelectedValue = _pojazd.Id_Paliwo_Pojazd;
                    cbRodzaj.SelectedValue = _pojazd.Id_Rodzaj_Pojazd;
                    _rodzaj = new XRodzaj(_pojazd.Id_Rodzaj_Pojazd);
                    break;
                case FormAkcja.Usun:
                    if (MessageBox.Show("Czy usunąć wybrany rekord ?", "Pytanie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        _pojazd.Usun();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    this.Close();
                    break;

            }
        }

        private void btZatwierdz_Click(object sender, EventArgs e)
        {
            switch (_akcja)
            {
                case FormAkcja.Dopisz:
            _pojazd.Nr_Rej = tbNrRej.Text;
            _pojazd.Marka = tbMarka.Text;
            _pojazd.Model = tbModel.Text;
            _pojazd.Pojemnosc = Convert.ToDecimal(tbPojemnosc.Text);
            _pojazd.Rok_Prod = tbRokPr.Text;
            _pojazd.Id_Paliwo_Pojazd = Convert.ToInt32(cbPaliwo.SelectedValue);
            _pojazd.Nr_Silnik = tbNrSilnika.Text;
            _pojazd.Nr_Nadwozie = tbNrNadwozia.Text;
            _pojazd.Id_Rodzaj_Pojazd = Convert.ToInt32(cbRodzaj.SelectedValue);
            _pojazd.Zbiornik = Convert.ToDecimal(tbPojBak.Text);
            _pojazd.Stan_Licz_Pocz = Convert.ToDecimal(tbLiczStPocz.Text);
            _pojazd.Numer_Oc = tbNumerOC.Text;
            _pojazd.Data_Oc = tbDataOC.Value;
            _pojazd.Polisa_Ac = chbUbezAC.Checked;
            _pojazd.Numer_Ac = tbNumerAC.Text;
            _pojazd.Data_Ac = tbDataAC.Value;
            _pojazd.Data_Bad_Tech = tbBadTech.Value;
            _pojazd.Licz_Bad_Tech = Convert.ToDecimal(tbStLiczPT.Text);
            _pojazd.Gwarancja = chbGwarancja.Checked;
            _pojazd.Data_Gwarancja = tbGwarancjaDo.Value;
            _pojazd.Stan_Licz_Gwar = Narzedzia.StringToDecimal(tbStLiczG.Text);
            _pojazd.Id_Paliwo_Pojazd = (int)cbPaliwo.SelectedValue;
            _pojazd.Id_Rodzaj_Pojazd = (int)cbRodzaj.SelectedValue;
            _pojazd.Dopisz();
                    break;
                case FormAkcja.Popraw:
            _pojazd.Nr_Rej = tbNrRej.Text;
            _pojazd.Marka = tbMarka.Text;
            _pojazd.Model = tbModel.Text;
            _pojazd.Pojemnosc = Convert.ToDecimal(tbPojemnosc.Text);
            _pojazd.Rok_Prod = tbRokPr.Text;
            _pojazd.Id_Paliwo_Pojazd = Convert.ToInt32(cbPaliwo.SelectedValue);
            _pojazd.Nr_Silnik = tbNrSilnika.Text;
            _pojazd.Nr_Nadwozie = tbNrNadwozia.Text;
            _pojazd.Id_Rodzaj_Pojazd = Convert.ToInt32(cbRodzaj.SelectedValue);
            _pojazd.Zbiornik = Convert.ToDecimal(tbPojBak.Text);
            _pojazd.Stan_Licz_Pocz = Convert.ToDecimal(tbLiczStPocz.Text);
            _pojazd.Numer_Oc = tbNumerOC.Text;
            _pojazd.Data_Oc = tbDataOC.Value;
            _pojazd.Polisa_Ac = chbUbezAC.Checked;
            _pojazd.Numer_Ac = tbNumerAC.Text;
            _pojazd.Data_Ac = tbDataAC.Value;
            _pojazd.Data_Bad_Tech = tbBadTech.Value;
            _pojazd.Licz_Bad_Tech = Convert.ToDecimal(tbStLiczPT.Text);
            _pojazd.Gwarancja = chbGwarancja.Checked;
            _pojazd.Data_Gwarancja = tbGwarancjaDo.Value;
            _pojazd.Stan_Licz_Gwar = Narzedzia.StringToDecimal(tbStLiczG.Text);
            _pojazd.Id_Paliwo_Pojazd = (int)cbPaliwo.SelectedValue;
            _pojazd.Id_Rodzaj_Pojazd = (int)cbRodzaj.SelectedValue;

                    _pojazd.Popraw();
                    break;

            }


        }

        private void btPorzuc_Click(object sender, EventArgs e)
        {
            //
        }


        private void PaliwaLista()
        {
            XPaliwa lp = new XPaliwa();
            lp.DajListePaliwa();
            cbPaliwo.DataSource = lp.ListaPaliwa;
            cbPaliwo.DisplayMember = "PALIWO_NAZWA";
            cbPaliwo.ValueMember = "ID_PALIWO";
            
        }

        private void RodzajLista()
        {
            XRodzaje lr = new XRodzaje();
            lr.DajListeRodzaje();
            cbRodzaj.DataSource = lr.ListaRodzaje;
            cbRodzaj.DisplayMember = "RODZAJ_NAZWA";
            cbRodzaj.ValueMember = "ID_RODZAJ";

        }

        private void tbNrRej_Validating(object sender, CancelEventArgs e)
        {
            if (tbNrRej.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(sender as TextBox, "Podaj Numer!");
            }
            else
            {
                errorProvider1.SetError(sender as TextBox, "");
            }
        }

        private void tbMarka_Validating(object sender, CancelEventArgs e)
        {
            if (tbMarka.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(sender as TextBox, "Podaj Markę!");
            }
            else
            {
                errorProvider1.SetError(sender as TextBox, "");
            }
        }

        private void tbModel_Validating(object sender, CancelEventArgs e)
        {
            if (tbModel.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(sender as TextBox, "Podaj Model!");
            }
            else
            {
                errorProvider1.SetError(sender as TextBox, "");
            }
        }

        private void tbNrSilnika_Validating(object sender, CancelEventArgs e)
        {
            if (tbNrSilnika.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(sender as TextBox, "Podaj Numer Silnika!");
            }
            else
            {
                errorProvider1.SetError(sender as TextBox, "");
            }
        }

        private void tbNrNadwozia_Validating(object sender, CancelEventArgs e)
        {
            if (tbNrNadwozia.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(sender as TextBox, "Podaj Numer Nadwozia!");
            }
            else
            {
                errorProvider1.SetError(sender as TextBox, "");
            }
        }

       

  

    }

}
