namespace RezervacijeSportskihTerena
{
    partial class frmGlavniIzbornik
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
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnTereni = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.lblPozdrav = new System.Windows.Forms.Label();
            this.txtTrenutniKorisnik = new System.Windows.Forms.TextBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.Location = new System.Drawing.Point(23, 62);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(108, 41);
            this.btnZaposlenici.TabIndex = 0;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Location = new System.Drawing.Point(149, 62);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(108, 41);
            this.btnRezervacije.TabIndex = 1;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnTereni
            // 
            this.btnTereni.Location = new System.Drawing.Point(23, 126);
            this.btnTereni.Name = "btnTereni";
            this.btnTereni.Size = new System.Drawing.Size(108, 41);
            this.btnTereni.TabIndex = 2;
            this.btnTereni.Text = "Tereni";
            this.btnTereni.UseVisualStyleBackColor = true;
            this.btnTereni.Click += new System.EventHandler(this.btnTereni_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.Location = new System.Drawing.Point(149, 126);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(108, 41);
            this.btnIzvjestaji.TabIndex = 4;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(79, 189);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(108, 41);
            this.btnStatistika.TabIndex = 5;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // lblPozdrav
            // 
            this.lblPozdrav.AutoSize = true;
            this.lblPozdrav.Location = new System.Drawing.Point(20, 19);
            this.lblPozdrav.Name = "lblPozdrav";
            this.lblPozdrav.Size = new System.Drawing.Size(92, 13);
            this.lblPozdrav.TabIndex = 6;
            this.lblPozdrav.Text = "Prijavljeni ste kao:";
            // 
            // txtTrenutniKorisnik
            // 
            this.txtTrenutniKorisnik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrenutniKorisnik.Location = new System.Drawing.Point(111, 19);
            this.txtTrenutniKorisnik.Name = "txtTrenutniKorisnik";
            this.txtTrenutniKorisnik.ReadOnly = true;
            this.txtTrenutniKorisnik.Size = new System.Drawing.Size(100, 13);
            this.txtTrenutniKorisnik.TabIndex = 7;
            this.txtTrenutniKorisnik.Text = "Ime i prezime";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(182, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 8;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // frmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.txtTrenutniKorisnik);
            this.Controls.Add(this.lblPozdrav);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnIzvjestaji);
            this.Controls.Add(this.btnTereni);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnZaposlenici);
            this.Name = "frmGlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnTereni;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Label lblPozdrav;
        private System.Windows.Forms.TextBox txtTrenutniKorisnik;
        private System.Windows.Forms.Button btnOdjava;
    }
}