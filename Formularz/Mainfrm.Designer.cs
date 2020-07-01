namespace Formularz
{
    partial class Mainfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
         this.menuStrip = new System.Windows.Forms.MenuStrip();
         this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
         this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
         this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.ListyMenuItemKierowcy = new System.Windows.Forms.ToolStripMenuItem();
         this.ListyMenuItemPojazdy = new System.Windows.Forms.ToolStripMenuItem();
         this.ListyMenuItemWyjazdy = new System.Windows.Forms.ToolStripMenuItem();
         this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStrip = new System.Windows.Forms.ToolStrip();
         this.btKierowcy = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.btPojazdy = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.btWyjazdy = new System.Windows.Forms.ToolStripButton();
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolTip = new System.Windows.Forms.ToolTip(this.components);
         this.RaportMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.RaportyKierowcowMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.RaportyPojazdowMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.RaportyWyjazdyMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip.SuspendLayout();
         this.toolStrip.SuspendLayout();
         this.statusStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip
         // 
         this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.RaportMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
         this.menuStrip.Location = new System.Drawing.Point(0, 0);
         this.menuStrip.MdiWindowListItem = this.windowsMenu;
         this.menuStrip.Name = "menuStrip";
         this.menuStrip.Size = new System.Drawing.Size(887, 24);
         this.menuStrip.TabIndex = 0;
         this.menuStrip.Text = "MenuStrip";
         // 
         // fileMenu
         // 
         this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
         this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
         this.fileMenu.Name = "fileMenu";
         this.fileMenu.Size = new System.Drawing.Size(38, 20);
         this.fileMenu.Text = "&Plik";
         // 
         // toolStripSeparator5
         // 
         this.toolStripSeparator5.Name = "toolStripSeparator5";
         this.toolStripSeparator5.Size = new System.Drawing.Size(174, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
         this.exitToolStripMenuItem.Text = "Wyjście";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
         // 
         // editMenu
         // 
         this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7,
            this.selectAllToolStripMenuItem});
         this.editMenu.Name = "editMenu";
         this.editMenu.Size = new System.Drawing.Size(39, 20);
         this.editMenu.Text = "&Edit";
         // 
         // undoToolStripMenuItem
         // 
         this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
         this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
         this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
         this.undoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
         this.undoToolStripMenuItem.Text = "&Undo";
         this.undoToolStripMenuItem.Visible = false;
         // 
         // redoToolStripMenuItem
         // 
         this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
         this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
         this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
         this.redoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
         this.redoToolStripMenuItem.Text = "&Redo";
         this.redoToolStripMenuItem.Visible = false;
         // 
         // toolStripSeparator6
         // 
         this.toolStripSeparator6.Name = "toolStripSeparator6";
         this.toolStripSeparator6.Size = new System.Drawing.Size(205, 6);
         this.toolStripSeparator6.Visible = false;
         // 
         // cutToolStripMenuItem
         // 
         this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
         this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
         this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.cutToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
         this.cutToolStripMenuItem.Text = "Wytnij";
         this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
         // 
         // copyToolStripMenuItem
         // 
         this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
         this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
         this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
         this.copyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
         this.copyToolStripMenuItem.Text = "Kopiuj";
         this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
         // 
         // pasteToolStripMenuItem
         // 
         this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
         this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
         this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
         this.pasteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
         this.pasteToolStripMenuItem.Text = "Wklej";
         this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
         // 
         // toolStripSeparator7
         // 
         this.toolStripSeparator7.Name = "toolStripSeparator7";
         this.toolStripSeparator7.Size = new System.Drawing.Size(205, 6);
         // 
         // selectAllToolStripMenuItem
         // 
         this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
         this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
         this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
         this.selectAllToolStripMenuItem.Text = "Zaznacz wszystko";
         // 
         // viewMenu
         // 
         this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListyMenuItemKierowcy,
            this.ListyMenuItemPojazdy,
            this.ListyMenuItemWyjazdy});
         this.viewMenu.Name = "viewMenu";
         this.viewMenu.Size = new System.Drawing.Size(43, 20);
         this.viewMenu.Text = "&Listy";
         // 
         // ListyMenuItemKierowcy
         // 
         this.ListyMenuItemKierowcy.Name = "ListyMenuItemKierowcy";
         this.ListyMenuItemKierowcy.Size = new System.Drawing.Size(152, 22);
         this.ListyMenuItemKierowcy.Text = "&1. Kierowcy";
         this.ListyMenuItemKierowcy.Click += new System.EventHandler(this.buttonKierowcy_Click);
         // 
         // ListyMenuItemPojazdy
         // 
         this.ListyMenuItemPojazdy.Name = "ListyMenuItemPojazdy";
         this.ListyMenuItemPojazdy.Size = new System.Drawing.Size(152, 22);
         this.ListyMenuItemPojazdy.Text = "&2. Pojazdy";
         this.ListyMenuItemPojazdy.Click += new System.EventHandler(this.buttonPojazdy_Click);
         // 
         // ListyMenuItemWyjazdy
         // 
         this.ListyMenuItemWyjazdy.Name = "ListyMenuItemWyjazdy";
         this.ListyMenuItemWyjazdy.Size = new System.Drawing.Size(152, 22);
         this.ListyMenuItemWyjazdy.Text = "&3. Wyjazdy";
         this.ListyMenuItemWyjazdy.Click += new System.EventHandler(this.btWyjazdy_Click);
         // 
         // toolsMenu
         // 
         this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
         this.toolsMenu.Name = "toolsMenu";
         this.toolsMenu.Size = new System.Drawing.Size(48, 20);
         this.toolsMenu.Text = "&Tools";
         this.toolsMenu.Visible = false;
         // 
         // optionsToolStripMenuItem
         // 
         this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
         this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
         this.optionsToolStripMenuItem.Text = "&Options";
         // 
         // windowsMenu
         // 
         this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
         this.windowsMenu.Name = "windowsMenu";
         this.windowsMenu.Size = new System.Drawing.Size(68, 20);
         this.windowsMenu.Text = "&Windows";
         this.windowsMenu.Visible = false;
         // 
         // newWindowToolStripMenuItem
         // 
         this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
         this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.newWindowToolStripMenuItem.Text = "&New Window";
         // 
         // cascadeToolStripMenuItem
         // 
         this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
         this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.cascadeToolStripMenuItem.Text = "&Cascade";
         // 
         // tileVerticalToolStripMenuItem
         // 
         this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
         this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
         // 
         // tileHorizontalToolStripMenuItem
         // 
         this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
         this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
         // 
         // closeAllToolStripMenuItem
         // 
         this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
         this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.closeAllToolStripMenuItem.Text = "C&lose All";
         // 
         // arrangeIconsToolStripMenuItem
         // 
         this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
         this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
         this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
         // 
         // helpMenu
         // 
         this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
         this.helpMenu.Name = "helpMenu";
         this.helpMenu.Size = new System.Drawing.Size(44, 20);
         this.helpMenu.Text = "&Help";
         this.helpMenu.Visible = false;
         // 
         // contentsToolStripMenuItem
         // 
         this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
         this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
         this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
         this.contentsToolStripMenuItem.Text = "&Contents";
         // 
         // indexToolStripMenuItem
         // 
         this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
         this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
         this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
         this.indexToolStripMenuItem.Text = "&Index";
         // 
         // searchToolStripMenuItem
         // 
         this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
         this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
         this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
         this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
         this.searchToolStripMenuItem.Text = "&Search";
         // 
         // toolStripSeparator8
         // 
         this.toolStripSeparator8.Name = "toolStripSeparator8";
         this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
         this.aboutToolStripMenuItem.Text = "&About ... ...";
         // 
         // toolStrip
         // 
         this.toolStrip.AutoSize = false;
         this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.toolStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
         this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btKierowcy,
            this.toolStripSeparator1,
            this.btPojazdy,
            this.toolStripSeparator2,
            this.btWyjazdy});
         this.toolStrip.Location = new System.Drawing.Point(0, 574);
         this.toolStrip.Name = "toolStrip";
         this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
         this.toolStrip.Size = new System.Drawing.Size(887, 63);
         this.toolStrip.TabIndex = 1;
         this.toolStrip.Text = "ToolStrip";
         // 
         // btKierowcy
         // 
         this.btKierowcy.Image = ((System.Drawing.Image)(resources.GetObject("btKierowcy.Image")));
         this.btKierowcy.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btKierowcy.Name = "btKierowcy";
         this.btKierowcy.Size = new System.Drawing.Size(84, 60);
         this.btKierowcy.Text = "Kierowcy";
         this.btKierowcy.Click += new System.EventHandler(this.buttonKierowcy_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 63);
         // 
         // btPojazdy
         // 
         this.btPojazdy.Image = ((System.Drawing.Image)(resources.GetObject("btPojazdy.Image")));
         this.btPojazdy.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btPojazdy.Name = "btPojazdy";
         this.btPojazdy.Size = new System.Drawing.Size(77, 60);
         this.btPojazdy.Text = "Pojazdy";
         this.btPojazdy.Click += new System.EventHandler(this.buttonPojazdy_Click);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(6, 63);
         // 
         // btWyjazdy
         // 
         this.btWyjazdy.Image = ((System.Drawing.Image)(resources.GetObject("btWyjazdy.Image")));
         this.btWyjazdy.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btWyjazdy.Name = "btWyjazdy";
         this.btWyjazdy.Size = new System.Drawing.Size(80, 60);
         this.btWyjazdy.Text = "Wyjazdy";
         this.btWyjazdy.Click += new System.EventHandler(this.btWyjazdy_Click);
         // 
         // statusStrip
         // 
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
         this.statusStrip.Location = new System.Drawing.Point(0, 552);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.Size = new System.Drawing.Size(887, 22);
         this.statusStrip.TabIndex = 2;
         this.statusStrip.Text = "StatusStrip";
         // 
         // toolStripStatusLabel
         // 
         this.toolStripStatusLabel.Name = "toolStripStatusLabel";
         this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
         this.toolStripStatusLabel.Text = "Status";
         // 
         // RaportMenu
         // 
         this.RaportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RaportyKierowcowMenu,
            this.RaportyPojazdowMenu,
            this.RaportyWyjazdyMenu});
         this.RaportMenu.Name = "RaportMenu";
         this.RaportMenu.Size = new System.Drawing.Size(60, 20);
         this.RaportMenu.Text = "&Raporty";
         // 
         // RaportyKierowcowMenu
         // 
         this.RaportyKierowcowMenu.Name = "RaportyKierowcowMenu";
         this.RaportyKierowcowMenu.Size = new System.Drawing.Size(170, 22);
         this.RaportyKierowcowMenu.Text = "&1. Lista kierowców";
         this.RaportyKierowcowMenu.Click += new System.EventHandler(this.RaportyKierowcowMenu_Click);
         // 
         // RaportyPojazdowMenu
         // 
         this.RaportyPojazdowMenu.Name = "RaportyPojazdowMenu";
         this.RaportyPojazdowMenu.Size = new System.Drawing.Size(170, 22);
         this.RaportyPojazdowMenu.Text = "&2. Lista pojazdów";
         this.RaportyPojazdowMenu.Click += new System.EventHandler(this.RaportyPojazdowMenu_Click);
         // 
         // RaportyWyjazdyMenu
         // 
         this.RaportyWyjazdyMenu.Name = "RaportyWyjazdyMenu";
         this.RaportyWyjazdyMenu.Size = new System.Drawing.Size(170, 22);
         this.RaportyWyjazdyMenu.Text = "&3. Lista wyjazdów";
         this.RaportyWyjazdyMenu.Click += new System.EventHandler(this.RaportyWyjazdyMenu_Click);
         // 
         // printSetupToolStripMenuItem
         // 
         this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
         this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
         this.printSetupToolStripMenuItem.Text = "Ustawienia drukarki";
         this.printSetupToolStripMenuItem.Click += new System.EventHandler(this.printSetupToolStripMenuItem_Click);
         // 
         // Mainfrm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(887, 637);
         this.Controls.Add(this.statusStrip);
         this.Controls.Add(this.toolStrip);
         this.Controls.Add(this.menuStrip);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuStrip;
         this.Name = "Mainfrm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Mała Flota Samochodowa";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.menuStrip.ResumeLayout(false);
         this.menuStrip.PerformLayout();
         this.toolStrip.ResumeLayout(false);
         this.toolStrip.PerformLayout();
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton btKierowcy;
        private System.Windows.Forms.ToolStripButton btPojazdy;
        private System.Windows.Forms.ToolStripButton btWyjazdy;
        private System.Windows.Forms.ToolStripMenuItem ListyMenuItemKierowcy;
        private System.Windows.Forms.ToolStripMenuItem ListyMenuItemPojazdy;
        private System.Windows.Forms.ToolStripMenuItem ListyMenuItemWyjazdy;
        private System.Windows.Forms.ToolStripMenuItem RaportMenu;
        private System.Windows.Forms.ToolStripMenuItem RaportyKierowcowMenu;
        private System.Windows.Forms.ToolStripMenuItem RaportyPojazdowMenu;
        private System.Windows.Forms.ToolStripMenuItem RaportyWyjazdyMenu;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
    }
}



