﻿namespace Formularz
{
    partial class FormAddTrase
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
            this.btZatwierdz = new System.Windows.Forms.Button();
            this.btPorzuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLicznikK = new System.Windows.Forms.TextBox();
            this.tbLicznikP = new System.Windows.Forms.TextBox();
            this.cbZakoncz = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKierowca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataW = new System.Windows.Forms.DateTimePicker();
            this.dtDataP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPojazd = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btZatwierdz
            // 
            this.btZatwierdz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btZatwierdz.Location = new System.Drawing.Point(244, 390);
            this.btZatwierdz.Name = "btZatwierdz";
            this.btZatwierdz.Size = new System.Drawing.Size(80, 37);
            this.btZatwierdz.TabIndex = 2;
            this.btZatwierdz.Text = "&Ok";
            this.btZatwierdz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btZatwierdz.UseVisualStyleBackColor = true;
            this.btZatwierdz.Click += new System.EventHandler(this.btZatwierdz_Click_1);
            // 
            // btPorzuc
            // 
            this.btPorzuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btPorzuc.Location = new System.Drawing.Point(325, 390);
            this.btPorzuc.Name = "btPorzuc";
            this.btPorzuc.Size = new System.Drawing.Size(80, 37);
            this.btPorzuc.TabIndex = 1;
            this.btPorzuc.Text = "&Porzuć ";
            this.btPorzuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPorzuc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLicznikK);
            this.groupBox1.Controls.Add(this.tbLicznikP);
            this.groupBox1.Controls.Add(this.cbZakoncz);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbKierowca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtDataW);
            this.groupBox1.Controls.Add(this.dtDataP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPojazd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyjazd samochodu";
            // 
            // tbLicznikK
            // 
            this.tbLicznikK.Location = new System.Drawing.Point(149, 261);
            this.tbLicznikK.Name = "tbLicznikK";
            this.tbLicznikK.Size = new System.Drawing.Size(100, 20);
            this.tbLicznikK.TabIndex = 12;
            this.tbLicznikK.Validating += new System.ComponentModel.CancelEventHandler(this.tbLicznikK_Validating);
            // 
            // tbLicznikP
            // 
            this.tbLicznikP.Location = new System.Drawing.Point(149, 222);
            this.tbLicznikP.Name = "tbLicznikP";
            this.tbLicznikP.Size = new System.Drawing.Size(100, 20);
            this.tbLicznikP.TabIndex = 11;
            this.tbLicznikP.Validating += new System.ComponentModel.CancelEventHandler(this.tbLicznikP_Validating);
            // 
            // cbZakoncz
            // 
            this.cbZakoncz.AutoSize = true;
            this.cbZakoncz.Location = new System.Drawing.Point(260, 264);
            this.cbZakoncz.Name = "cbZakoncz";
            this.cbZakoncz.Size = new System.Drawing.Size(66, 17);
            this.cbZakoncz.TabIndex = 10;
            this.cbZakoncz.Text = "zakończ";
            this.cbZakoncz.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "stan licznika końcowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "stan licznika początkowy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "kierowca";
            // 
            // cbKierowca
            // 
            this.cbKierowca.FormattingEnabled = true;
            this.cbKierowca.Location = new System.Drawing.Point(103, 168);
            this.cbKierowca.Name = "cbKierowca";
            this.cbKierowca.Size = new System.Drawing.Size(223, 21);
            this.cbKierowca.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data powrotu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data wyjazdu";
            // 
            // dtDataW
            // 
            this.dtDataW.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataW.Location = new System.Drawing.Point(103, 95);
            this.dtDataW.Name = "dtDataW";
            this.dtDataW.Size = new System.Drawing.Size(124, 20);
            this.dtDataW.TabIndex = 3;
            // 
            // dtDataP
            // 
            this.dtDataP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataP.Location = new System.Drawing.Point(103, 121);
            this.dtDataP.Name = "dtDataP";
            this.dtDataP.Size = new System.Drawing.Size(124, 20);
            this.dtDataP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr rejestracyjny";
            // 
            // cbPojazd
            // 
            this.cbPojazd.FormattingEnabled = true;
            this.cbPojazd.Location = new System.Drawing.Point(103, 26);
            this.cbPojazd.Name = "cbPojazd";
            this.cbPojazd.Size = new System.Drawing.Size(183, 21);
            this.cbPojazd.TabIndex = 0;
          
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddTrase
            // 
            this.AcceptButton = this.btZatwierdz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btPorzuc;
            this.ClientSize = new System.Drawing.Size(424, 438);
            this.Controls.Add(this.btZatwierdz);
            this.Controls.Add(this.btPorzuc);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddTrase";
            this.Text = "FormAddWyjazd";
            this.Load += new System.EventHandler(this.FormAddTrase_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btZatwierdz;
        private System.Windows.Forms.Button btPorzuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLicznikK;
        private System.Windows.Forms.TextBox tbLicznikP;
        private System.Windows.Forms.CheckBox cbZakoncz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKierowca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDataW;
        private System.Windows.Forms.DateTimePicker dtDataP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPojazd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}