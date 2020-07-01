namespace Formularz {
   partial class FormLogin {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing ) {
         if ( disposing && ( components != null ) ) {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.lLogin = new System.Windows.Forms.Label();
         this.tbOperator = new System.Windows.Forms.TextBox();
         this.tcLogin = new System.Windows.Forms.TabControl();
         this.tpOperator = new System.Windows.Forms.TabPage();
         this.lHaslo = new System.Windows.Forms.Label();
         this.tbHaslo = new System.Windows.Forms.TextBox();
         this.tpDB = new System.Windows.Forms.TabPage();
         this.lDB = new System.Windows.Forms.Label();
         this.tbDB = new System.Windows.Forms.TextBox();
         this.lServer = new System.Windows.Forms.Label();
         this.tbServer = new System.Windows.Forms.TextBox();
         this.btCancel = new System.Windows.Forms.Button();
         this.btOK = new System.Windows.Forms.Button();
         this.tcLogin.SuspendLayout();
         this.tpOperator.SuspendLayout();
         this.tpDB.SuspendLayout();
         this.SuspendLayout();
         // 
         // lLogin
         // 
         this.lLogin.AutoSize = true;
         this.lLogin.Location = new System.Drawing.Point(16, 27);
         this.lLogin.Name = "lLogin";
         this.lLogin.Size = new System.Drawing.Size(65, 13);
         this.lLogin.TabIndex = 0;
         this.lLogin.Text = "Identyfikator";
         // 
         // tbOperator
         // 
         this.tbOperator.Location = new System.Drawing.Point(87, 24);
         this.tbOperator.Name = "tbOperator";
         this.tbOperator.Size = new System.Drawing.Size(228, 20);
         this.tbOperator.TabIndex = 1;
         // 
         // tcLogin
         // 
         this.tcLogin.Controls.Add(this.tpOperator);
         this.tcLogin.Controls.Add(this.tpDB);
         this.tcLogin.Location = new System.Drawing.Point(12, 12);
         this.tcLogin.Name = "tcLogin";
         this.tcLogin.SelectedIndex = 0;
         this.tcLogin.Size = new System.Drawing.Size(355, 122);
         this.tcLogin.TabIndex = 3;
         // 
         // tpOperator
         // 
         this.tpOperator.BackColor = System.Drawing.Color.Transparent;
         this.tpOperator.Controls.Add(this.lHaslo);
         this.tpOperator.Controls.Add(this.tbHaslo);
         this.tpOperator.Controls.Add(this.lLogin);
         this.tpOperator.Controls.Add(this.tbOperator);
         this.tpOperator.Location = new System.Drawing.Point(4, 22);
         this.tpOperator.Name = "tpOperator";
         this.tpOperator.Padding = new System.Windows.Forms.Padding(3);
         this.tpOperator.Size = new System.Drawing.Size(347, 96);
         this.tpOperator.TabIndex = 0;
         this.tpOperator.Text = "Operator";
         // 
         // lHaslo
         // 
         this.lHaslo.AutoSize = true;
         this.lHaslo.Location = new System.Drawing.Point(48, 56);
         this.lHaslo.Name = "lHaslo";
         this.lHaslo.Size = new System.Drawing.Size(36, 13);
         this.lHaslo.TabIndex = 2;
         this.lHaslo.Text = "Hasło";
         // 
         // tbHaslo
         // 
         this.tbHaslo.Location = new System.Drawing.Point(87, 53);
         this.tbHaslo.Name = "tbHaslo";
         this.tbHaslo.Size = new System.Drawing.Size(228, 20);
         this.tbHaslo.TabIndex = 3;
         this.tbHaslo.UseSystemPasswordChar = true;
         // 
         // tpDB
         // 
         this.tpDB.BackColor = System.Drawing.Color.Transparent;
         this.tpDB.Controls.Add(this.lDB);
         this.tpDB.Controls.Add(this.tbDB);
         this.tpDB.Controls.Add(this.lServer);
         this.tpDB.Controls.Add(this.tbServer);
         this.tpDB.Location = new System.Drawing.Point(4, 22);
         this.tpDB.Name = "tpDB";
         this.tpDB.Padding = new System.Windows.Forms.Padding(3);
         this.tpDB.Size = new System.Drawing.Size(347, 96);
         this.tpDB.TabIndex = 1;
         this.tpDB.Text = "Baza danych";
         // 
         // lDB
         // 
         this.lDB.AutoSize = true;
         this.lDB.Location = new System.Drawing.Point(17, 53);
         this.lDB.Name = "lDB";
         this.lDB.Size = new System.Drawing.Size(69, 13);
         this.lDB.TabIndex = 8;
         this.lDB.Text = "Baza danych";
         // 
         // tbDB
         // 
         this.tbDB.Location = new System.Drawing.Point(87, 50);
         this.tbDB.Name = "tbDB";
         this.tbDB.Size = new System.Drawing.Size(228, 20);
         this.tbDB.TabIndex = 9;
         // 
         // lServer
         // 
         this.lServer.AutoSize = true;
         this.lServer.Location = new System.Drawing.Point(17, 27);
         this.lServer.Name = "lServer";
         this.lServer.Size = new System.Drawing.Size(64, 13);
         this.lServer.TabIndex = 6;
         this.lServer.Text = "Serwer SQL";
         // 
         // tbServer
         // 
         this.tbServer.Location = new System.Drawing.Point(87, 24);
         this.tbServer.Name = "tbServer";
         this.tbServer.Size = new System.Drawing.Size(228, 20);
         this.tbServer.TabIndex = 7;
         // 
         // btCancel
         // 
         this.btCancel.Location = new System.Drawing.Point(283, 149);
         this.btCancel.Name = "btCancel";
         this.btCancel.Size = new System.Drawing.Size(80, 37);
         this.btCancel.TabIndex = 4;
         this.btCancel.Text = "&Porzuć";
         this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btCancel.UseVisualStyleBackColor = true;
         this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
         // 
         // btOK
         // 
         this.btOK.Location = new System.Drawing.Point(197, 149);
         this.btOK.Name = "btOK";
         this.btOK.Size = new System.Drawing.Size(80, 37);
         this.btOK.TabIndex = 5;
         this.btOK.Text = "O&K";
         this.btOK.UseVisualStyleBackColor = true;
         this.btOK.Click += new System.EventHandler(this.btOK_Click);
         // 
         // FormLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(379, 197);
         this.Controls.Add(this.btOK);
         this.Controls.Add(this.btCancel);
         this.Controls.Add(this.tcLogin);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Identyfikacja Operatora";
         this.tcLogin.ResumeLayout(false);
         this.tpOperator.ResumeLayout(false);
         this.tpOperator.PerformLayout();
         this.tpDB.ResumeLayout(false);
         this.tpDB.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label lLogin;
      private System.Windows.Forms.TextBox tbOperator;
      private System.Windows.Forms.TabControl tcLogin;
      private System.Windows.Forms.TabPage tpOperator;
      private System.Windows.Forms.Label lHaslo;
      private System.Windows.Forms.TextBox tbHaslo;
      private System.Windows.Forms.TabPage tpDB;
      private System.Windows.Forms.Button btCancel;
      private System.Windows.Forms.Button btOK;
      private System.Windows.Forms.Label lDB;
      private System.Windows.Forms.TextBox tbDB;
      private System.Windows.Forms.Label lServer;
      private System.Windows.Forms.TextBox tbServer;
   }
}