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
    public partial class FormTrasy : Form
    {
        public FormTrasy()
        {
            InitializeComponent();
        }



        private void FormatujListe()
        {

        }

        private void OdswierzListe()
        {

            XTrasy lT = new XTrasy();
            lT.DajListe();
            gvTrasy.DataSource = lT.Lista;

        }



        private void btDopiszTrase_Click(object sender, EventArgs e)
        {
            {


                FormAddTrase dopiszPoprawTrasa = new FormAddTrase(FormAkcja.Dopisz, null);
                switch (dopiszPoprawTrasa.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        OdswierzListe();
                        break;
                    default:

                        break;
                }



            }
        }

        private void btPopraw_Click(object sender, EventArgs e)
        {


        }


        private void btUsun_Click(object sender, EventArgs e)
        {

        }

        private void FormTrasy_Load(object sender, EventArgs e)
        {
            OdswierzListe();
        }

        private void btPoprawTrase_Click(object sender, EventArgs e)
        {



            Object id = gvTrasy.CurrentRow.Cells["ID_TRASA"].Value;
            if (id != null)
            {
                int id_trasa = Narzedzia.ObjectToInt(id);

                XTrasa t = new XTrasa(id_trasa);
                FormAddTrase dopiszPoprawTrasa = new FormAddTrase(FormAkcja.Popraw, t);
                switch (dopiszPoprawTrasa.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        OdswierzListe();
                        break;
                    default:

                        break;
                }
            }

        }

        private void btDopiszTank_Click(object sender, EventArgs e)
        {
            if (trasaUstawiona != null) 
            {


                FormAddTank dopiszPoprawTank = new FormAddTank(FormAkcja.Dopisz, null, trasaUstawiona);
                switch (dopiszPoprawTank.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        OdswiezTankowania(trasaUstawiona);
                        break;
                    default:

                        break;
                }



            }



        }

        private void gvTrasy_SelectionChanged(object sender, EventArgs e)
        {
            Object id = gvTrasy.CurrentRow.Cells["ID_TRASA"].Value;
            if (id != null)
            {
                int id_trasa = Narzedzia.ObjectToInt(id);

                XTrasa t = new XTrasa(id_trasa);
                OdswiezTankowania(t);
                trasaUstawiona = t;
            }
            else
            {
                trasaUstawiona = null;
            }
        }

        private void OdswiezTankowania(XTrasa t)
        {
            XTankowania lTank = new XTankowania();
            lTank.DajListe( string.Format( "{0}={1}", t.Id_Trasa, "ID_TRASA_TANK"));

            gvTankowania.DataSource = lTank.ListaTank;

        }


        private XTrasa trasaUstawiona = null;

        private void btUsunTrase_Click(object sender, EventArgs e)
        {

        }

    }
}




