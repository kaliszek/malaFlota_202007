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
    public partial class FormAddTrase : Form
    
    {

        FormAkcja _akcja = FormAkcja.Brak;
        private XTrasa _trasa;
        public FormAddTrase( FormAkcja c, XTrasa t = null)
        {
            InitializeComponent();
            _akcja = c;
            _trasa = t;
            KierowcyLista();
            PojazdyLista();
            DajStanLiczKoniec();


         }

        private void FormAddTrase_Load_1(object sender, EventArgs e)
        {
            
            switch (_akcja)
            {
                case FormAkcja.Dopisz:
                    _trasa = new XTrasa();
                    break;
                case FormAkcja.Popraw:
                    cbPojazd.SelectedValue = _trasa.Id_Pojazd_Trasa;
                    cbKierowca.SelectedValue = _trasa.Id_Kierowca_Trasa;
                    tbLicznikP.Text = Convert.ToString(_trasa.Stan_Licz_Pocz);
                    tbLicznikK.Text = Convert.ToString(_trasa.Stan_Licz_Koniec);
                    cbZakoncz.Checked = _trasa.Koniec_Trasa;
                
                
               
                    break;
            }
        }




        private void btZatwierdz_Click_1(object sender, EventArgs e)
        {

            switch (_akcja)
            {
                case FormAkcja.Dopisz:
                  
                    _trasa.Id_Pojazd_Trasa = Convert.ToInt32(cbPojazd.SelectedValue);
                    _trasa.Id_Kierowca_Trasa = Convert.ToInt32(cbKierowca.SelectedValue);
                    _trasa.Stan_Licz_Pocz = Narzedzia.IsNullDecimal(Narzedzia.StringToDecimal(tbLicznikP.Text));
                    _trasa.Stan_Licz_Koniec = Convert.ToDecimal(tbLicznikK.Text);
                    _trasa.Data_Wyjazd = dtDataW.Value;
                    _trasa.Data_Przyjazd = dtDataP.Value;
                    _trasa.Koniec_Trasa = cbZakoncz.Checked;
                    _trasa.Dopisz();
                     
                    break;
                case FormAkcja.Popraw:
                    _trasa.Id_Pojazd_Trasa = (int)cbPojazd.SelectedValue;
                    _trasa.Id_Kierowca_Trasa = (int)cbKierowca.SelectedValue;
                    _trasa.Stan_Licz_Pocz = Convert.ToDecimal(tbLicznikP.Text);
                    _trasa.Stan_Licz_Koniec = Convert.ToDecimal(tbLicznikK.Text);
                    _trasa.Data_Wyjazd = dtDataW.Value;
                    _trasa.Data_Przyjazd = dtDataP.Value;
                    _trasa.Koniec_Trasa = cbZakoncz.Checked;
                    _trasa.Popraw();
                    break;
            }

              
        }

        private void btPorzuc_Click(object sender, EventArgs e)
        {

            
        }



        private void KierowcyLista()
        {
            XKierowcy lk = new XKierowcy();
            lk.DajListe();
            cbKierowca.DataSource = lk.Lista;
            cbKierowca.DisplayMember = "NAZWISKO";
            cbKierowca.ValueMember = "ID";

        }

        private void PojazdyLista()
        {
            XPojazdy lp = new XPojazdy();
            lp.DajListePojazdow();
            cbPojazd.DataSource=lp.ListaPojazdow;
            cbPojazd.DisplayMember="NR_REJ";
            cbPojazd.ValueMember= "ID_POJAZD";
            
        }

        private void cbPojazd_SelectedIndexChanged(object sender, EventArgs e)
        {
           /// DajStanLiczKoniec;
        }



        private void DajStanLiczKoniec()
        /*
         
                 private void OdswierzListePojazdow()
        {
            List<XPojazdy_Paliwa_Rodzaje> lPP = new List<XPojazdy_Paliwa_Rodzaje>();
            
            XPojazdy lp = new XPojazdy();
            lp.DajListePojazdow();
            foreach (XPojazd p in lp.ListaPojazdow)
            {
                XPojazdy_Paliwa_Rodzaje pp = new XPojazdy_Paliwa_Rodzaje();
                pp.Ustaw(p);
                pp.Ustaw(new XPaliwo(p.Id_Paliwo_Pojazd));
                pp.Ustaw( new XRodzaj( p.Id_Rodzaj_Pojazd));
                lPP.Add(pp);
            }
            gvPojazdy.DataSource = lPP;
         
         
         
         
         
         
         */





        
        {
           /// List<XTrasy> lkm = new List<XTrasy>();
        
        }
       
    }

}











