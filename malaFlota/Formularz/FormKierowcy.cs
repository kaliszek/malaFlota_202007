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

            //this.gvKierowcy.ColumnHeadersDefaultCellStyle.Font = new Font("Nina", 12);
            //this.gvKierowcy.AutoGenerateColumns = false;
            //this.gvKierowcy.DefaultCellStyle.Font = new Font("Nina", 10);
            //this.gvKierowcy.DefaultCellStyle.ForeColor = Color.Blue;
            //this.gvKierowcy.DefaultCellStyle.BackColor = Color.Beige;
            //this.gvKierowcy.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            //this.gvKierowcy.DefaultCellStyle.SelectionBackColor = Color.Black;
            /*
         gvKierowcy.ColumnCount =8;
          
    
            
         ///  gvKierowcy.Columns[0].DisplayIndex = 0;

            
            
         gvKierowcy.Columns[0].Name = "ID";
         gvKierowcy.Columns[0].HeaderText = "ID";
         gvKierowcy.Columns[0].DataPropertyName = "ID";
         gvKierowcy.Columns[0].Visible = false;
            
            
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

         gvKierowcy.Columns[5].Name = "Nr_Domu";
         gvKierowcy.Columns[5].HeaderText = "Numer domu";
         gvKierowcy.Columns[5].DataPropertyName = "Nr_domu";
            
         gvKierowcy.Columns[6].Name = "Nr_Lokalu";
         gvKierowcy.Columns[6].HeaderText = "Numer lokalu";
         gvKierowcy.Columns[6].DataPropertyName = "Nr_Lokalu";

         gvKierowcy.Columns[6].Name = "Data_Ur";
         gvKierowcy.Columns[6].HeaderText = "Data urodzenia";
         gvKierowcy.Columns[6].DataPropertyName = "Data_Ur";

         gvKierowcy.Columns[7].Name = "DATA_BAD_LEK";
         gvKierowcy.Columns[7].HeaderText = "Data badań lekarskich";
         gvKierowcy.Columns[7].DataPropertyName = "DATA_BAD_LEK";
         */
            
        
        }
        
        private void OdswierzListe()

        {
            XKierowcy lk = new XKierowcy();
            lk.DajListe();

            gvKierowcy.DataSource = lk.Lista;
        }

        private void FormKierowcy_Load(object sender, EventArgs e)
        {
          ///  this.gvKierowcy.AutoGenerateColumns = false;
          //  FormatujListe();
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

           Object id =  gvKierowcy.CurrentRow.Cells["ID"].Value;
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

        }

        private void gvKierowcy_SelectionChanged(object sender, EventArgs e)
        {


            lNazwa.Text = Narzedzia.ObjectToString(gvKierowcy.CurrentRow.Cells["Nazwisko"].Value);

          // Object

        }



    }
}







