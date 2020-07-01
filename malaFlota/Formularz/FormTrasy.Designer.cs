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
            ((System.ComponentModel.ISupportInitialize)(this.gvTrasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTankowania)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btUsunTrase
            // 
            this.btUsunTrase.Dock = System.Windows.Forms.DockStyle.Left;
            this.btUsunTrase.Location = new System.Drawing.Point(75, 0);
            this.btUsunTrase.Name = "btUsunTrase";
            this.btUsunTrase.Size = new System.Drawing.Size(75, 25);
            this.btUsunTrase.TabIndex = 5;
            this.btUsunTrase.Text = "&Usuń";
            this.btUsunTrase.UseVisualStyleBackColor = true;
            this.btUsunTrase.Click += new System.EventHandler(this.btUsunTrase_Click);
            // 
            // btPoprawTrase
            // 
            this.btPoprawTrase.Dock = System.Windows.Forms.DockStyle.Left;
            this.btPoprawTrase.Location = new System.Drawing.Point(0, 0);
            this.btPoprawTrase.Name = "btPoprawTrase";
            this.btPoprawTrase.Size = new System.Drawing.Size(75, 25);
            this.btPoprawTrase.TabIndex = 6;
            this.btPoprawTrase.Text = "&Popraw";
            this.btPoprawTrase.UseVisualStyleBackColor = true;
            this.btPoprawTrase.Click += new System.EventHandler(this.btPoprawTrase_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 32);
            this.panel1.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1099, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gvTrasy
            // 
            this.gvTrasy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTrasy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTrasy.Location = new System.Drawing.Point(3, 3);
            this.gvTrasy.Name = "gvTrasy";
            this.gvTrasy.Size = new System.Drawing.Size(619, 454);
            this.gvTrasy.TabIndex = 0;
            this.gvTrasy.SelectionChanged += new System.EventHandler(this.gvTrasy_SelectionChanged);
            // 
            // gvTankowania
            // 
            this.gvTankowania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTankowania.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvTankowania.Location = new System.Drawing.Point(637, 3);
            this.gvTankowania.Name = "gvTankowania";
            this.gvTankowania.Size = new System.Drawing.Size(338, 289);
            this.gvTankowania.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 561);
            this.panel2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.54281F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.457195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.gvTrasy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvTankowania, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.55533F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.444668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1099, 561);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btDopiszTrase);
            this.panel4.Controls.Add(this.btUsunTrase);
            this.panel4.Controls.Add(this.btPoprawTrase);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 463);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 25);
            this.panel4.TabIndex = 3;
            // 
            // btDopiszTrase
            // 
            this.btDopiszTrase.Dock = System.Windows.Forms.DockStyle.Left;
            this.btDopiszTrase.Location = new System.Drawing.Point(150, 0);
            this.btDopiszTrase.Name = "btDopiszTrase";
            this.btDopiszTrase.Size = new System.Drawing.Size(75, 25);
            this.btDopiszTrase.TabIndex = 7;
            this.btDopiszTrase.Text = "&Dopisz";
            this.btDopiszTrase.UseVisualStyleBackColor = true;
            this.btDopiszTrase.Click += new System.EventHandler(this.btDopiszTrase_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btDopiszTank);
            this.panel3.Controls.Add(this.btUsunTank);
            this.panel3.Controls.Add(this.btPoprawTank);
            this.panel3.Location = new System.Drawing.Point(981, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 159);
            this.panel3.TabIndex = 2;
            // 
            // btDopiszTank
            // 
            this.btDopiszTank.AutoSize = true;
            this.btDopiszTank.Location = new System.Drawing.Point(3, 3);
            this.btDopiszTank.Name = "btDopiszTank";
            this.btDopiszTank.Size = new System.Drawing.Size(75, 25);
            this.btDopiszTank.TabIndex = 8;
            this.btDopiszTank.Text = "&Dopisz";
            this.btDopiszTank.UseVisualStyleBackColor = true;
            this.btDopiszTank.Click += new System.EventHandler(this.btDopiszTank_Click);
            // 
            // btUsunTank
            // 
            this.btUsunTank.Location = new System.Drawing.Point(3, 65);
            this.btUsunTank.Name = "btUsunTank";
            this.btUsunTank.Size = new System.Drawing.Size(75, 25);
            this.btUsunTank.TabIndex = 10;
            this.btUsunTank.Text = "&Usuń";
            this.btUsunTank.UseVisualStyleBackColor = true;
            // 
            // btPoprawTank
            // 
            this.btPoprawTank.Location = new System.Drawing.Point(3, 34);
            this.btPoprawTank.Name = "btPoprawTank";
            this.btPoprawTank.Size = new System.Drawing.Size(75, 25);
            this.btPoprawTank.TabIndex = 9;
            this.btPoprawTank.Text = "&Popraw";
            this.btPoprawTank.UseVisualStyleBackColor = true;
            // 
            // FormTrasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1099, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTrasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTrasy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTrasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTankowania)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
    }
}