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

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

             ///KonfiguracjaGlobalna.ConnectingString = "Data Source=LENOVO;Initial Catalog=db_malaFlota;Integrated Security=False;User ID=sa;Password=;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //XKierowca w = new XKierowca();
            //w.Imie = "jacek";
            //w.Nazwisko = "kowalski";
           
            //w.Dopisz();
            //w.Nazwisko = "kalisz_''";
            //w.Popraw();



            List<XKierowca> l = new List<XKierowca>();
            l.Add(new XKierowca(123));
          
        }
    }
}
