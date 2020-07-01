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
    public partial class FormAddTank : Form
    {
        FormAkcja _akcja = FormAkcja.Brak;
        private XTankowanie _tank;
        private XTrasa _trasa;
        public FormAddTank(FormAkcja d, XTankowanie ta = null, XTrasa tr = null)
        {
            InitializeComponent();
            _akcja = d;
            _tank = ta;
            _trasa = tr;
            PaliwoLista();
        }

        public FormAddTank()
        {
            InitializeComponent();
        }



        private void FormAddTank_Load(object sender, EventArgs e)
        {
            switch (_akcja)
            {
                case FormAkcja.Dopisz:
                    _tank = new XTankowanie();
                    break;
                case FormAkcja.Popraw:

                    cbPaliwo.SelectedValue = _tank.Id_Rodzaj_Paliwa_Tank;
                    tbIlosc.Text = Convert.ToString(_tank.Ilosc_Tank);
                    tbDataTank.Value = (DateTime)_tank.Data_Tank;

                    break;
            }
        }

        private void btDopisz_Click(object sender, EventArgs e)
        {

            {

                switch (_akcja)
                {
                    case FormAkcja.Dopisz:

                       _tank.Id_Trasa_Tank = Convert.ToInt32(_trasa.Id_Trasa);
                       _tank.Id_Pojazd_Tank = Convert.ToInt32(_trasa.Id_Pojazd_Trasa);
                       _tank.Data_Tank = tbDataTank.Value;
                       _tank.Ilosc_Tank=Convert.ToDecimal(tbIlosc.Text);
                       _tank.Wartosc_Tank = Convert.ToDecimal(tbWartosc.Text);
                       _tank.Licznik_Tank = Convert.ToDecimal(tbStanLicznika.Text);
                       _tank.Id_Rodzaj_Paliwa_Tank = Convert.ToInt32(cbPaliwo.SelectedValue);
                       _tank.Dopisz();
                        break;
                    case FormAkcja.Popraw:
                       
                        break;
                }


            }  
           



        
        
        
        
        
        
        
        
        
        }

        private void PaliwoLista()

        {
            XPaliwa lp = new XPaliwa();
            lp.DajListePaliwa();
            cbPaliwo.DataSource = lp.ListaPaliwa;
            cbPaliwo.DisplayMember = "PALIWO_NAZWA";
            cbPaliwo.ValueMember = "ID_PALIWO";






        }

    
    
    
    }

}

