namespace Formularz
{
    partial class FormTrasy
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
            this.btUsunTrase = new System.Windows.Forms.Button();
            this.btPoprawTrase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gvTrasy = new System.Windows.Forms.DataGridView();
            this.gvTankowania = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btDopiszTrase = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDopiszTank = new System.Windows.Forms.Button();
            this.btUsunTank = new System.Windows.Forms.Button();
            this.btPoprawTank = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lRazemOdlegloscW = new System.Windows.Forms.Label();
            this.lRazemOdleglosc = new System.Windows.Forms.Label();
            this.lSrednia100W = new System.Windows.Forms.Label();
            this.lSrednia100 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lRazemIloscW = new System.Windows.Forms.Label();
            this.lRazemWartosc = new System.Windows.Forms.Label();
            this.lRazemWartoscW = new System.Windows.Forms.Label();
            this.lRazemIlosc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTankowania)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btUsunTrase
            // 
            this.btUsunTrase.Location = new System.Drawing.Point(172, 0);
            this.btUsunTrase.Name = "btUsunTrase";
            this.btUsunTrase.Size = new System.Drawing.Size(80, 37);
            this.btUsunTrase.TabIndex = 5;
            this.btUsunTrase.Text = "&Usuń";
            this.btUsunTrase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUsunTrase.UseVisualStyleBackColor = true;
            this.btUsunTrase.Click += new System.EventHandler(this.btUsunTrase_Click);
            // 
            // btPoprawTrase
            // 
            this.btPoprawTrase.Location = new System.Drawing.Point(86, 0);
            this.btPoprawTrase.Name = "btPoprawTrase";
            this.btPoprawTrase.Size = new System.Drawing.Size(80, 37);
            this.btPoprawTrase.TabIndex = 6;
            this.btPoprawTrase.Text = "&Popraw";
            this.btPoprawTrase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPoprawTrase.UseVisualStyleBackColor = true;
            this.btPoprawTrase.Click += new System.EventHandler(this.btPoprawTrase_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 32);
            this.panel1.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gvTrasy
            // 
            this.gvTrasy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTrasy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTrasy.Location = new System.Drawing.Point(3, 3);
            this.gvTrasy.Name = "gvTrasy";
            this.gvTrasy.Size = new System.Drawing.Size(554, 294);
            this.gvTrasy.TabIndex = 0;
            this.gvTrasy.SelectionChanged += new System.EventHandler(this.gvTrasy_SelectionChanged);
            // 
            // gvTankowania
            // 
            this.gvTankowania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTankowania.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvTankowania.Location = new System.Drawing.Point(571, 3);
            this.gvTankowania.Name = "gvTankowania";
            this.gvTankowania.Size = new System.Drawing.Size(319, 294);
            this.gvTankowania.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 426);
            this.panel2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.59353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.40647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Controls.Add(this.gvTrasy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvTankowania, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.10059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.89941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 426);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btDopiszTrase);
            this.panel4.Controls.Add(this.btUsunTrase);
            this.panel4.Controls.Add(this.btPoprawTrase);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(554, 42);
            this.panel4.TabIndex = 3;
            // 
            // btDopiszTrase
            // 
            this.btDopiszTrase.Location = new System.Drawing.Point(0, 0);
            this.btDopiszTrase.Name = "btDopiszTrase";
            this.btDopiszTrase.Size = new System.Drawing.Size(80, 37);
            this.btDopiszTrase.TabIndex = 7;
            this.btDopiszTrase.Text = "&Dopisz";
            this.btDopiszTrase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDopiszTrase.UseVisualStyleBackColor = true;
            this.btDopiszTrase.Click += new System.EventHandler(this.btDopiszTrase_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btDopiszTank);
            this.panel3.Controls.Add(this.btUsunTank);
            this.panel3.Controls.Add(this.btPoprawTank);
            this.panel3.Location = new System.Drawing.Point(896, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 159);
            this.panel3.TabIndex = 2;
            // 
            // btDopiszTank
            // 
            this.btDopiszTank.AutoSize = true;
            this.btDopiszTank.Location = new System.Drawing.Point(3, 3);
            this.btDopiszTank.Name = "btDopiszTank";
            this.btDopiszTank.Size = new System.Drawing.Size(80, 37);
            this.btDopiszTank.TabIndex = 8;
            this.btDopiszTank.Text = "&Dopisz";
            this.btDopiszTank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDopiszTank.UseVisualStyleBackColor = true;
            this.btDopiszTank.Click += new System.EventHandler(this.btDopiszTank_Click);
            // 
            // btUsunTank
            // 
            this.btUsunTank.Location = new System.Drawing.Point(3, 89);
            this.btUsunTank.Name = "btUsunTank";
            this.btUsunTank.Size = new System.Drawing.Size(80, 37);
            this.btUsunTank.TabIndex = 10;
            this.btUsunTank.Text = "&Usuń";
            this.btUsunTank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUsunTank.UseVisualStyleBackColor = true;
            this.btUsunTank.Click += new System.EventHandler(this.btUsunTank_Click);
            // 
            // btPoprawTank
            // 
            this.btPoprawTank.Location = new System.Drawing.Point(3, 46);
            this.btPoprawTank.Name = "btPoprawTank";
            this.btPoprawTank.Size = new System.Drawing.Size(80, 37);
            this.btPoprawTank.TabIndex = 9;
            this.btPoprawTank.Text = "&Popraw";
            this.btPoprawTank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPoprawTank.UseVisualStyleBackColor = true;
            this.btPoprawTank.Click += new System.EventHandler(this.btPoprawTank_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lRazemOdlegloscW);
            this.panel5.Controls.Add(this.lRazemOdleglosc);
            this.panel5.Controls.Add(this.lSrednia100W);
            this.panel5.Controls.Add(this.lSrednia100);
            this.panel5.Location = new System.Drawing.Point(571, 368);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 45);
            this.panel5.TabIndex = 8;
            // 
            // lRazemOdlegloscW
            // 
            this.lRazemOdlegloscW.AutoSize = true;
            this.lRazemOdlegloscW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRazemOdlegloscW.Location = new System.Drawing.Point(98, 11);
            this.lRazemOdlegloscW.Name = "lRazemOdlegloscW";
            this.lRazemOdlegloscW.Size = new System.Drawing.Size(46, 13);
            this.lRazemOdlegloscW.TabIndex = 9;
            this.lRazemOdlegloscW.Text = "000.00";
            // 
            // lRazemOdleglosc
            // 
            this.lRazemOdleglosc.AutoSize = true;
            this.lRazemOdleglosc.Location = new System.Drawing.Point(10, 11);
            this.lRazemOdleglosc.Name = "lRazemOdleglosc";
            this.lRazemOdleglosc.Size = new System.Drawing.Size(76, 13);
            this.lRazemOdleglosc.TabIndex = 8;
            this.lRazemOdleglosc.Text = "Przebieg w km";
            // 
            // lSrednia100W
            // 
            this.lSrednia100W.AutoSize = true;
            this.lSrednia100W.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSrednia100W.Location = new System.Drawing.Point(150, 31);
            this.lSrednia100W.Name = "lSrednia100W";
            this.lSrednia100W.Size = new System.Drawing.Size(46, 13);
            this.lSrednia100W.TabIndex = 7;
            this.lSrednia100W.Text = "000.00";
            // 
            // lSrednia100
            // 
            this.lSrednia100.AutoSize = true;
            this.lSrednia100.Location = new System.Drawing.Point(10, 31);
            this.lSrednia100.Name = "lSrednia100";
            this.lSrednia100.Size = new System.Drawing.Size(134, 13);
            this.lSrednia100.TabIndex = 6;
            this.lSrednia100.Text = "Średnie zużycie na 100 km";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lRazemIloscW);
            this.panel6.Controls.Add(this.lRazemWartosc);
            this.panel6.Controls.Add(this.lRazemWartoscW);
            this.panel6.Controls.Add(this.lRazemIlosc);
            this.panel6.Location = new System.Drawing.Point(571, 303);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(319, 31);
            this.panel6.TabIndex = 9;
            // 
            // lRazemIloscW
            // 
            this.lRazemIloscW.AutoSize = true;
            this.lRazemIloscW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRazemIloscW.Location = new System.Drawing.Point(45, 7);
            this.lRazemIloscW.Name = "lRazemIloscW";
            this.lRazemIloscW.Size = new System.Drawing.Size(63, 13);
            this.lRazemIloscW.TabIndex = 5;
            this.lRazemIloscW.Text = "00000000";
            // 
            // lRazemWartosc
            // 
            this.lRazemWartosc.AutoSize = true;
            this.lRazemWartosc.Location = new System.Drawing.Point(184, 7);
            this.lRazemWartosc.Name = "lRazemWartosc";
            this.lRazemWartosc.Size = new System.Drawing.Size(47, 13);
            this.lRazemWartosc.TabIndex = 7;
            this.lRazemWartosc.Text = "Wartość";
            // 
            // lRazemWartoscW
            // 
            this.lRazemWartoscW.AutoSize = true;
            this.lRazemWartoscW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRazemWartoscW.Location = new System.Drawing.Point(237, 7);
            this.lRazemWartoscW.Name = "lRazemWartoscW";
            this.lRazemWartoscW.Size = new System.Drawing.Size(81, 13);
            this.lRazemWartoscW.TabIndex = 6;
            this.lRazemWartoscW.Text = "00000000.00";
            // 
            // lRazemIlosc
            // 
            this.lRazemIlosc.AutoSize = true;
            this.lRazemIlosc.Location = new System.Drawing.Point(10, 7);
            this.lRazemIlosc.Name = "lRazemIlosc";
            this.lRazemIlosc.Size = new System.Drawing.Size(29, 13);
            this.lRazemIlosc.TabIndex = 4;
            this.lRazemIlosc.Text = "Ilość";
            // 
            // FormTrasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1016, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTrasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Wyjazdow";
            this.Load += new System.EventHandler(this.FormTrasy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTrasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTankowania)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUsunTrase;
        private System.Windows.Forms.Button btPoprawTrase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView gvTrasy;
        private System.Windows.Forms.DataGridView gvTankowania;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btUsunTank;
        private System.Windows.Forms.Button btPoprawTank;
        private System.Windows.Forms.Button btDopiszTank;
        private System.Windows.Forms.Button btDopiszTrase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lRazemWartoscW;
        private System.Windows.Forms.Label lRazemIloscW;
        private System.Windows.Forms.Label lRazemIlosc;
        private System.Windows.Forms.Label lRazemWartosc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lSrednia100W;
        private System.Windows.Forms.Label lSrednia100;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lRazemOdlegloscW;
        private System.Windows.Forms.Label lRazemOdleglosc;
    }
}