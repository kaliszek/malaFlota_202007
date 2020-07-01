namespace Formularz
{
    partial class FormKierowcy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKierowcy));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btDopisz = new System.Windows.Forms.Button();
            this.btPopraw = new System.Windows.Forms.Button();
            this.btUsun = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gvKierowcy = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKierowcy)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1159, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 20);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 671);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 60);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btDopisz);
            this.panel5.Controls.Add(this.btPopraw);
            this.panel5.Controls.Add(this.btUsun);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(838, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 60);
            this.panel5.TabIndex = 1;
            // 
            // btDopisz
            // 
            this.btDopisz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDopisz.Location = new System.Drawing.Point(32, 6);
            this.btDopisz.Name = "btDopisz";
            this.btDopisz.Size = new System.Drawing.Size(80, 37);
            this.btDopisz.TabIndex = 1;
            this.btDopisz.Text = "&Dodaj";
            this.btDopisz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDopisz.UseVisualStyleBackColor = true;
            this.btDopisz.Click += new System.EventHandler(this.btDopisz_Click);
            // 
            // btPopraw
            // 
            this.btPopraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPopraw.Location = new System.Drawing.Point(127, 6);
            this.btPopraw.Name = "btPopraw";
            this.btPopraw.Size = new System.Drawing.Size(80, 37);
            this.btPopraw.TabIndex = 2;
            this.btPopraw.Text = "&Popraw";
            this.btPopraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPopraw.UseVisualStyleBackColor = true;
            this.btPopraw.Click += new System.EventHandler(this.btPopraw_Click);
            // 
            // btUsun
            // 
            this.btUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsun.Location = new System.Drawing.Point(222, 6);
            this.btUsun.Name = "btUsun";
            this.btUsun.Size = new System.Drawing.Size(80, 37);
            this.btUsun.TabIndex = 3;
            this.btUsun.Text = "&Usuń";
            this.btUsun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUsun.UseVisualStyleBackColor = true;
            this.btUsun.Click += new System.EventHandler(this.btUsun_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1149, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 60);
            this.panel4.TabIndex = 0;
            // 
            // gvKierowcy
            // 
            this.gvKierowcy.AllowUserToOrderColumns = true;
            this.gvKierowcy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKierowcy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvKierowcy.Location = new System.Drawing.Point(0, 20);
            this.gvKierowcy.MultiSelect = false;
            this.gvKierowcy.Name = "gvKierowcy";
            this.gvKierowcy.Size = new System.Drawing.Size(1159, 651);
            this.gvKierowcy.TabIndex = 4;
            // 
            // FormKierowcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 753);
            this.Controls.Add(this.gvKierowcy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKierowcy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kierowcy";
            this.Load += new System.EventHandler(this.FormKierowcy_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvKierowcy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btUsun;
        private System.Windows.Forms.Button btPopraw;
        private System.Windows.Forms.Button btDopisz;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gvKierowcy;
    }
}