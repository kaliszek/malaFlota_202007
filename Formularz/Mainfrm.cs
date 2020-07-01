using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalReport;

namespace Formularz {
   public partial class Mainfrm : Form {
      //private int childFormNumber = 0;

      public Mainfrm() {
         InitializeComponent();
         this.Icon = Zasoby.Properties.Resources.MalaFlota;
      }

      private FormKierowcy girdFormKierowcy;
      private FormPojazdy girdFormPojazdy;
      private FormTrasy girdFormWyjazdy;


      private void buttonKierowcy_Click(object sender, EventArgs e)
      {

         if ( girdFormKierowcy == null ) {
            girdFormKierowcy = new FormKierowcy();
            girdFormKierowcy.MdiParent = this;
            girdFormKierowcy.FormClosed += girdFormKierowcy_FormClosed;
            girdFormKierowcy.Show();

         }
         else girdFormKierowcy.Activate();

      }
      private void girdFormKierowcy_FormClosed( object sender, FormClosedEventArgs e ) {
         girdFormKierowcy = null;
      }

      private void buttonPojazdy_Click( object sender, EventArgs e ) {
         if ( girdFormPojazdy == null ) {
            girdFormPojazdy = new FormPojazdy();
            girdFormPojazdy.MdiParent = this;
            girdFormPojazdy.FormClosed += girdFormPojazdy_FormClosed;
            girdFormPojazdy.Show();
         }
         else girdFormPojazdy.Activate();
      }

      private void girdFormPojazdy_FormClosed( object sender, FormClosedEventArgs e ) {
         girdFormPojazdy = null;
      }

      private void btWyjazdy_Click( object sender, EventArgs e ) {
         if ( girdFormWyjazdy == null ) {
            girdFormWyjazdy = new FormTrasy();
            girdFormWyjazdy.MdiParent = this;
            girdFormWyjazdy.FormClosed += girdFormPojazdy_FormClosed;
            girdFormWyjazdy.Show();
         }
         else girdFormWyjazdy.Activate();
      }

      private void girdFormWyjazdy_FormClosed( object sender, FormClosedEventArgs e ) {
         girdFormWyjazdy = null;
      }
      //-- Raporty 
      private void RaportyKierowcowMenu_Click( object sender, EventArgs e ) {
         RaportWbudowany r = new RaportWbudowany();
         r.Wykonaj( RaportWbudowany.RaportWbudowanyEnum.ListaKierowcow,"" );
      }

      private void RaportyPojazdowMenu_Click( object sender, EventArgs e ) {
         RaportWbudowany r = new RaportWbudowany();
         r.Wykonaj( RaportWbudowany.RaportWbudowanyEnum.ListaPojazdow,"" );
      }

      private void RaportyWyjazdyMenu_Click( object sender, EventArgs e ) {
         RaportWbudowany r = new RaportWbudowany();
         r.Wykonaj( RaportWbudowany.RaportWbudowanyEnum.ListaWyjazdow,"" );
      }


      //-- Systemowe 
      private void ExitToolsStripMenuItem_Click( object sender, EventArgs e ) {
         this.Close();
      }

      private void CutToolStripMenuItem_Click( object sender, EventArgs e ) {
      }

      private void CopyToolStripMenuItem_Click( object sender, EventArgs e ) {
      }

      private void PasteToolStripMenuItem_Click( object sender, EventArgs e ) {
      }

      private void printSetupToolStripMenuItem_Click( object sender, EventArgs e ) {

         var printDialog = new PrintDialog();
         if ( printDialog.ShowDialog() != DialogResult.OK )
            return;
         var printerSettings = printDialog.PrinterSettings;
      }

      

      //private void ShowNewForm(object sender, EventArgs e)
      //{
      //    Form childForm = new Form();
      //    childForm.MdiParent = this;
      //    childForm.Text = "Window " + childFormNumber++;
      //    childForm.Show();
      //}

      //private void OpenFile(object sender, EventArgs e)
      //{
      //    OpenFileDialog openFileDialog = new OpenFileDialog();
      //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      //    openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
      //    {
      //        string FileName = openFileDialog.FileName;
      //    }
      //}

      //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    SaveFileDialog saveFileDialog = new SaveFileDialog();
      //    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      //    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      //    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
      //    {
      //        string FileName = saveFileDialog.FileName;
      //    }
      //}


      //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
      //}

      //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
      //}

      //private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    LayoutMdi(MdiLayout.Cascade);
      //}

      //private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    LayoutMdi(MdiLayout.TileVertical);
      //}

      //private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    LayoutMdi(MdiLayout.TileHorizontal);
      //}

      //private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    LayoutMdi(MdiLayout.ArrangeIcons);
      //}

      //private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //    foreach (Form childForm in MdiChildren)
      //    {
      //        childForm.Close();
      //    }
      //}
   }
}

