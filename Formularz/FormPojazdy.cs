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
using CrystalReport;

namespace Formularz
{
    public partial class FormPojazdy : Form
    {
        public FormPojazdy()
        {
            InitializeComponent();

            btDopisz.Image = Zasoby.Properties.Resources.INSERT;
            btDopisz.ImageAlign = ContentAlignment.MiddleLeft;
            btDopisz.TextAlign = ContentAlignment.MiddleRight;

            btPopraw.Image = Zasoby.Properties.Resources.EDIT;
            btPopraw.ImageAlign = ContentAlignment.MiddleLeft;
            btPopraw.TextAlign = ContentAlignment.MiddleRight;

            btUsun.Image = Zasoby.Properties.Resources.DELETE;
            btUsun.ImageAlign = ContentAlignment.MiddleLeft;
            btUsun.TextAlign = ContentAlignment.MiddleRight;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void FormatujListe()
        {


            gvPojazdy.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            gvPojazdy.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            gvPojazdy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gvPojazdy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvPojazdy.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            gvPojazdy.DefaultCellStyle.BackColor = Color.Empty;
            gvPojazdy.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            gvPojazdy.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gvPojazdy.GridColor = SystemColors.ControlDarkDark;

            gvPojazdy.ColumnCount = 26;

            gvPojazdy.Columns[0].Name = "ID_POJAZD";
            gvPojazdy.Columns[0].HeaderText = "ID_POJAZD";
            gvPojazdy.Columns[0].DataPropertyName = "ID_POJAZD";
            gvPojazdy.Columns[0].Visible = false;

            gvPojazdy.Columns[1].Name = "Nr_Rej";
            gvPojazdy.Columns[1].HeaderText = "Nr rejestracyjny";
            gvPojazdy.Columns[1].DataPropertyName = "Nr_Rej";

            gvPojazdy.Columns[2].Name = "Marka";
            gvPojazdy.Columns[2].HeaderText = "Marka";
            gvPojazdy.Columns[2].DataPropertyName = "Marka";

            gvPojazdy.Columns[3].Name = "Model";
            gvPojazdy.Columns[3].HeaderText = "Model";
            gvPojazdy.Columns[3].DataPropertyName = "Model";

            gvPojazdy.Columns[4].Name = "Pojemnosc";
            gvPojazdy.Columns[4].HeaderText = "Pojemnosc";
            gvPojazdy.Columns[4].DataPropertyName = "Pojemnosc";

            gvPojazdy.Columns[5].Name = "Rok_Prod";
            gvPojazdy.Columns[5].HeaderText = "Rok produkcji";
            gvPojazdy.Columns[5].DataPropertyName = "Rok_Prod";

            gvPojazdy.Columns[6].Name = "ID_RODZAJ_POJAZD";
            gvPojazdy.Columns[6].HeaderText = "ID_RODZAJ_POJAZD";
            gvPojazdy.Columns[6].DataPropertyName = "ID_RODZAJ_POJAZD";
            gvPojazdy.Columns[6].Visible = false;

            gvPojazdy.Columns[7].Name = "NR_SILNIK";
            gvPojazdy.Columns[7].HeaderText = "Nr silnika";
            gvPojazdy.Columns[7].DataPropertyName = "NR_SILNIK";

            gvPojazdy.Columns[8].Name = "NR_NADWOZIE";
            gvPojazdy.Columns[8].HeaderText = "Nr nadwozia";
            gvPojazdy.Columns[8].DataPropertyName = "NR_NADWOZIE";

            gvPojazdy.Columns[9].Name = "ID_PALIWO_POJAZD";
            gvPojazdy.Columns[9].HeaderText = "ID_PALIWO_POJAZD";
            gvPojazdy.Columns[9].DataPropertyName = "ID_PALIWO_POJAZD";
            gvPojazdy.Columns[9].Visible = false;

            gvPojazdy.Columns[10].Name = "ZBIORNIK";
            gvPojazdy.Columns[10].HeaderText = "Zbiornik paliwa";
            gvPojazdy.Columns[10].DataPropertyName = "ZBIORNIK";

            gvPojazdy.Columns[11].Name = "STAN_LICZ_POCZ";
            gvPojazdy.Columns[11].HeaderText = "STAN_LICZ_POCZ";
            gvPojazdy.Columns[11].DataPropertyName = "STAN_LICZ_POCZ";
            gvPojazdy.Columns[11].Visible = false;

            gvPojazdy.Columns[12].Name = "NUMER_OC";
            gvPojazdy.Columns[12].HeaderText = "Numer polisy OC";
            gvPojazdy.Columns[12].DataPropertyName = "NUMER_OC";

            gvPojazdy.Columns[13].Name = "DATA_OC";
            gvPojazdy.Columns[13].HeaderText = "Data ważności polisy OC";
            gvPojazdy.Columns[13].DataPropertyName = "DATA_OC";

            gvPojazdy.Columns[14].Name = "POLISA_AC";
            gvPojazdy.Columns[14].HeaderText = "Polisa AC";
            gvPojazdy.Columns[14].DataPropertyName = "POLISA_AC";


            gvPojazdy.Columns[15].Name = "NUMER_AC";
            gvPojazdy.Columns[15].HeaderText = "Numer polisy AC";
            gvPojazdy.Columns[15].DataPropertyName = "NUMER_AC";

            gvPojazdy.Columns[16].Name = "DATA_AC";
            gvPojazdy.Columns[16].HeaderText = "Data polisy AC";
            gvPojazdy.Columns[16].DataPropertyName = "DATA_AC";

            gvPojazdy.Columns[17].Name = "DATA_BAD_TECH";
            gvPojazdy.Columns[17].HeaderText = "Data badań technicznych";
            gvPojazdy.Columns[17].DataPropertyName = "DATA_BAD_TECH";

            gvPojazdy.Columns[18].Name = "LICZ_BAD_TECH";
            gvPojazdy.Columns[18].HeaderText = "Stan licznika badań technicznych ";
            gvPojazdy.Columns[18].DataPropertyName = "LICZ_BAD_TECH";
            gvPojazdy.Columns[18].Visible = false;

            gvPojazdy.Columns[19].Name = "GWARANCJA";
            gvPojazdy.Columns[19].HeaderText = "Gwarancja";
            gvPojazdy.Columns[19].DataPropertyName = "GWARANCJA";
            gvPojazdy.Columns[19].Visible = false;

            gvPojazdy.Columns[20].Name = "DATA_GWARANCJA";
            gvPojazdy.Columns[20].HeaderText = "DATA_GWARANCJA";
            gvPojazdy.Columns[20].DataPropertyName = "DATA_GWARANCJA";
            gvPojazdy.Columns[20].Visible = false;

            gvPojazdy.Columns[21].Name = "STAN_LICZ_GWAR";
            gvPojazdy.Columns[21].HeaderText = "STAN_LICZ_GWAR";
            gvPojazdy.Columns[21].DataPropertyName = "STAN_LICZ_GWAR";
            gvPojazdy.Columns[21].Visible = false;

            gvPojazdy.Columns[22].Name = "Id_Paliwo";
            gvPojazdy.Columns[22].HeaderText = "Id_Paliwo";
            gvPojazdy.Columns[22].DataPropertyName = "Id_Paliwo";
            gvPojazdy.Columns[22].Visible = false;

            gvPojazdy.Columns[23].Name = "Id_Rodzaj";
            gvPojazdy.Columns[23].HeaderText = "Id_Rodzaj";
            gvPojazdy.Columns[23].DataPropertyName = "Id_Rodzaj";
            gvPojazdy.Columns[23].Visible = false;

            gvPojazdy.Columns[24].Name = "Paliwo_Nazwa";
            gvPojazdy.Columns[24].HeaderText = "Paliwo_Nazwa";
            gvPojazdy.Columns[24].DataPropertyName = "Paliwo_Nazwa";
            gvPojazdy.Columns[24].Visible = false;

            gvPojazdy.Columns[25].Name = "Rodzaj_Nazwa";
            gvPojazdy.Columns[25].HeaderText = "Rodzaj_Nazwa";
            gvPojazdy.Columns[25].DataPropertyName = "Rodzaj_Nazwa";
            gvPojazdy.Columns[25].Visible = false;

        }

        private void FormPojazdy_Load(object sender, EventArgs e)
        {

            FormatujListe();
            OdswierzListePojazdow();



        }

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
                pp.Ustaw(new XRodzaj(p.Id_Rodzaj_Pojazd));

                lPP.Add(pp);
            }
            gvPojazdy.DataSource = lPP;







        }

        private void btDopisz_Click(object sender, EventArgs e)
        {
            {


                FormAddPojazdy dopiszPoprawPojazd = new FormAddPojazdy(FormAkcja.Dopisz, null);
                switch (dopiszPoprawPojazd.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        OdswierzListePojazdow();
                        break;
                    default:

                        break;
                }



            }

        }

        private void btPopraw_Click(object sender, EventArgs e)
        {


            object id = gvPojazdy.CurrentRow.Cells["ID_POJAZD"].Value;
            object idPaliwo = gvPojazdy.CurrentRow.Cells["ID_PALIWO_POJAZD"].Value;
            object idRodzaj = gvPojazdy.CurrentRow.Cells["ID_RODZAJ_POJAZD"].Value;



            if (id != null)
            {
                int id_pojazd = Narzedzia.ObjectToInt(id);


                XPojazd p = new XPojazd(id_pojazd);
                FormAddPojazdy dopiszPoprawPojazd = new FormAddPojazdy(FormAkcja.Popraw, p);
                switch (dopiszPoprawPojazd.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        OdswierzListePojazdow();
                        break;
                    default:

                        break;
                }
            }
        }

        public void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            object id = gvPojazdy.CurrentRow.Cells["ID_POJAZD"].Value;
            int id_pojazd = Narzedzia.ObjectToInt(id);
            XPojazd p = new XPojazd(id_pojazd);

            RaportWbudowany r = new RaportWbudowany();
            r.Wykonaj(RaportWbudowany.RaportWbudowanyEnum.Pojazd, id_pojazd.ToString());





        }

        private void btUsun_Click(object sender, EventArgs e)
        {
            object id = gvPojazdy.CurrentRow.Cells["ID_POJAZD"].Value;
            if (id != null)
            {
                int id_pojazd = Narzedzia.ObjectToInt(id);
                XPojazd p = new XPojazd(id_pojazd);
                FormAddPojazdy dopiszPoprawPojazd = new FormAddPojazdy(FormAkcja.Usun, p);
                switch (dopiszPoprawPojazd.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        OdswierzListePojazdow();
                        break;
                    default:
                        break;
                }

            }
        }





    }

}

