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
    public partial class FormKierowcy : Form
    {
        public FormKierowcy()
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



        private void FormatujListe()
        {




            gvKierowcy.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            gvKierowcy.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            gvKierowcy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gvKierowcy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvKierowcy.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            gvKierowcy.DefaultCellStyle.BackColor = Color.Empty;
            gvKierowcy.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            gvKierowcy.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gvKierowcy.GridColor = SystemColors.ControlDarkDark;
            gvKierowcy.ColumnCount = 19;

            gvKierowcy.Columns[0].Name = "ID";
            gvKierowcy.Columns[0].HeaderText = "ID";
            gvKierowcy.Columns[0].DataPropertyName = "ID";
            gvKierowcy.Columns[0].Visible = true;


            gvKierowcy.Columns[1].Name = "Imie";
            gvKierowcy.Columns[1].HeaderText = "Imię";
            gvKierowcy.Columns[1].HeaderText = "Imię";
            gvKierowcy.Columns[1].DataPropertyName = "Imie";

            gvKierowcy.Columns[2].Name = "Nazwisko";
            gvKierowcy.Columns[2].HeaderText = "Nazwisko";
            gvKierowcy.Columns[2].DataPropertyName = "Nazwisko";

            gvKierowcy.Columns[3].Name = "Pesel";
            gvKierowcy.Columns[3].HeaderText = "Pesel";
            gvKierowcy.Columns[3].DataPropertyName = "Pesel";

            gvKierowcy.Columns[4].Name = "Miasto";
            gvKierowcy.Columns[4].HeaderText = "Miasto";
            gvKierowcy.Columns[4].DataPropertyName = "Miasto";

            gvKierowcy.Columns[5].Name = "Ulica";
            gvKierowcy.Columns[5].HeaderText = "Ulica";
            gvKierowcy.Columns[5].DataPropertyName = "Ulica";

            gvKierowcy.Columns[6].Name = "KodP";
            gvKierowcy.Columns[6].HeaderText = "Kod pocztowy";
            gvKierowcy.Columns[6].DataPropertyName = "KodP";

            gvKierowcy.Columns[7].Name = "Poczta";
            gvKierowcy.Columns[7].HeaderText = "Poczta";
            gvKierowcy.Columns[7].DataPropertyName = "Poczta";

            gvKierowcy.Columns[8].Name = "Nr_Domu";
            gvKierowcy.Columns[8].HeaderText = "Numer domu";
            gvKierowcy.Columns[8].DataPropertyName = "Nr_domu";

            gvKierowcy.Columns[9].Name = "Nr_Lokalu";
            gvKierowcy.Columns[9].HeaderText = "Numer lokalu";
            gvKierowcy.Columns[9].DataPropertyName = "Nr_Lokalu";

            gvKierowcy.Columns[10].Name = "Data_Ur";
            gvKierowcy.Columns[10].HeaderText = "Data urodzenia";
            gvKierowcy.Columns[10].DataPropertyName = "Data_Ur";

            gvKierowcy.Columns[11].Name = "DATA_BAD_LEK";
            gvKierowcy.Columns[11].HeaderText = "Data badań lekarskich";
            gvKierowcy.Columns[11].DataPropertyName = "DATA_BAD_LEK";

            gvKierowcy.Columns[12].Name = "TEL1";
            gvKierowcy.Columns[12].HeaderText = "Telefon 1";
            gvKierowcy.Columns[12].DataPropertyName = "TEL1";

            gvKierowcy.Columns[13].Name = "TEL2";
            gvKierowcy.Columns[13].HeaderText = "Telefon 2";
            gvKierowcy.Columns[13].DataPropertyName = "TEL2";


            gvKierowcy.Columns[14].Name = "KATA";
            gvKierowcy.Columns[14].HeaderText = "KAT A";
            gvKierowcy.Columns[14].DataPropertyName = "KATA";


            gvKierowcy.Columns[15].Name = "KATB";
            gvKierowcy.Columns[15].HeaderText = "KAT B";
            gvKierowcy.Columns[15].DataPropertyName = "KATB";


            gvKierowcy.Columns[16].Name = "KATC";
            gvKierowcy.Columns[16].HeaderText = "KAT C";
            gvKierowcy.Columns[16].DataPropertyName = "KATC";


            gvKierowcy.Columns[17].Name = "KATD";
            gvKierowcy.Columns[17].HeaderText = "KAT D";
            gvKierowcy.Columns[17].DataPropertyName = "KATD";


            gvKierowcy.Columns[18].Name = "UPRAWNIENIA";
            gvKierowcy.Columns[18].HeaderText = "Uprawnienia";
            gvKierowcy.Columns[18].DataPropertyName = "UPRAWNIENIA";

        }

        private void OdswierzListe()
        {
            XKierowcy lk = new XKierowcy();
            lk.DajListe();

            gvKierowcy.DataSource = lk.Lista;
        }

        private void FormKierowcy_Load(object sender, EventArgs e)
        {

            FormatujListe();
            OdswierzListe();



        }

        private void btDopisz_Click(object sender, EventArgs e)
        {
            {


                FormAddKierowcy dopiszPoprawKierowca = new FormAddKierowcy(FormAkcja.Dopisz, null);
                switch (dopiszPoprawKierowca.ShowDialog())
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

            Object id = gvKierowcy.CurrentRow.Cells["ID"].Value;
            if (id != null)
            {
                int id_kierowca = Narzedzia.ObjectToInt(id);

                XKierowca k = new XKierowca(id_kierowca);
                FormAddKierowcy dopiszPoprawKierowca = new FormAddKierowcy(FormAkcja.Popraw, k);
                switch (dopiszPoprawKierowca.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        OdswierzListe();
                        break;
                    default:

                        break;
                }
            }
        }


        private void btUsun_Click(object sender, EventArgs e)
        {
            Object id = gvKierowcy.CurrentRow.Cells["ID"].Value;
            if (id != null)
            {
                int id_kierowca = Narzedzia.ObjectToInt(id);
                XKierowca k = new XKierowca(id_kierowca);
                FormAddKierowcy dopiszPoprawKierowca = new FormAddKierowcy(FormAkcja.Usun, k);
                switch (dopiszPoprawKierowca.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        OdswierzListe();
                        break;
                    default:
                        break;
                }

            }
        }





    }
}







