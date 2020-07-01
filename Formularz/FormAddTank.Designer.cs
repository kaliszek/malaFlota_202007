namespace Formularz
{
    partial class FormAddTank
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPorzuc = new System.Windows.Forms.Button();
            this.btDopisz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStanLicznika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPaliwo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWartosc = new System.Windows.Forms.TextBox();
            this.tbIlosc = new System.Windows.Forms.TextBox();
            this.tbDataTank = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btPorzuc);
            this.panel2.Controls.Add(this.btDopisz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 50);
            this.panel2.TabIndex = 1;
            // 
            // btPorzuc
            // 
            this.btPorzuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btPorzuc.Location = new System.Drawing.Point(249, 6);
            this.btPorzuc.Name = "btPorzuc";
            this.btPorzuc.Size = new System.Drawing.Size(80, 37);
            this.btPorzuc.TabIndex = 1;
            this.btPorzuc.Text = "&Porzuć";
            this.btPorzuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPorzuc.UseVisualStyleBackColor = true;
            // 
            // btDopisz
            // 
            this.btDopisz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btDopisz.Location = new System.Drawing.Point(163, 6);
            this.btDopisz.Name = "btDopisz";
            this.btDopisz.Size = new System.Drawing.Size(80, 37);
            this.btDopisz.TabIndex = 0;
            this.btDopisz.Text = "&Ok";
            this.btDopisz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDopisz.UseVisualStyleBackColor = true;
            this.btDopisz.Click += new System.EventHandler(this.btDopisz_Click);
            this.btDopisz.Validating += new System.ComponentModel.CancelEventHandler(this.btDopisz_Validating);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 32);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbStanLicznika);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPaliwo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbWartosc);
            this.groupBox1.Controls.Add(this.tbIlosc);
            this.groupBox1.Controls.Add(this.tbDataTank);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tankowanie pojazdu";
            // 
            // tbStanLicznika
            // 
            this.tbStanLicznika.Location = new System.Drawing.Point(173, 96);
            this.tbStanLicznika.Name = "tbStanLicznika";
            this.tbStanLicznika.Size = new System.Drawing.Size(100, 20);
            this.tbStanLicznika.TabIndex = 9;
            this.tbStanLicznika.Validating += new System.ComponentModel.CancelEventHandler(this.tbStanLicznika_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stan licznika";
            // 
            // cbPaliwo
            // 
            this.cbPaliwo.FormattingEnabled = true;
            this.cbPaliwo.Location = new System.Drawing.Point(173, 122);
            this.cbPaliwo.Name = "cbPaliwo";
            this.cbPaliwo.Size = new System.Drawing.Size(100, 21);
            this.cbPaliwo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rodzaj paliwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wartość brutto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ilość zatankowana";
            // 
            // tbWartosc
            // 
            this.tbWartosc.Location = new System.Drawing.Point(173, 157);
            this.tbWartosc.Name = "tbWartosc";
            this.tbWartosc.Size = new System.Drawing.Size(100, 20);
            this.tbWartosc.TabIndex = 3;
            this.tbWartosc.Validating += new System.ComponentModel.CancelEventHandler(this.tbWartosc_Validating);
            // 
            // tbIlosc
            // 
            this.tbIlosc.Location = new System.Drawing.Point(173, 67);
            this.tbIlosc.Name = "tbIlosc";
            this.tbIlosc.Size = new System.Drawing.Size(100, 20);
            this.tbIlosc.TabIndex = 2;
            this.tbIlosc.Validating += new System.ComponentModel.CancelEventHandler(this.tbIlosc_Validating);
            // 
            // tbDataTank
            // 
            this.tbDataTank.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDataTank.Location = new System.Drawing.Point(173, 41);
            this.tbDataTank.Name = "tbDataTank";
            this.tbDataTank.Size = new System.Drawing.Size(100, 20);
            this.tbDataTank.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data tankowania";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddTank
            // 
            this.AcceptButton = this.btDopisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btPorzuc;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(332, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormAddTank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tankowanie pojazdu";
            this.Load += new System.EventHandler(this.FormAddTank_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btPorzuc;
        private System.Windows.Forms.Button btDopisz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWartosc;
        private System.Windows.Forms.TextBox tbIlosc;
        private System.Windows.Forms.DateTimePicker tbDataTank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPaliwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStanLicznika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}