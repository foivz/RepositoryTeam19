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
            this.btnTermini = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.Location = new System.Drawing.Point(26, 34);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(108, 41);
            this.btnZaposlenici.TabIndex = 0;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Location = new System.Drawing.Point(152, 34);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(108, 41);
            this.btnRezervacije.TabIndex = 1;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnTereni
            // 
            this.btnTereni.Location = new System.Drawing.Point(26, 98);
            this.btnTereni.Name = "btnTereni";
            this.btnTereni.Size = new System.Drawing.Size(108, 41);
            this.btnTereni.TabIndex = 2;
            this.btnTereni.Text = "Tereni";
            this.btnTereni.UseVisualStyleBackColor = true;
            this.btnTereni.Click += new System.EventHandler(this.btnTereni_Click);
            // 
            // btnTermini
            // 
            this.btnTermini.Location = new System.Drawing.Point(152, 98);
            this.btnTermini.Name = "btnTermini";
            this.btnTermini.Size = new System.Drawing.Size(108, 41);
            this.btnTermini.TabIndex = 3;
            this.btnTermini.Text = "Termini";
            this.btnTermini.UseVisualStyleBackColor = true;
            this.btnTermini.Click += new System.EventHandler(this.btnTermini_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.Location = new System.Drawing.Point(26, 160);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(108, 41);
            this.btnIzvjestaji.TabIndex = 4;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(152, 160);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(108, 41);
            this.btnStatistika.TabIndex = 5;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // frmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnIzvjestaji);
            this.Controls.Add(this.btnTermini);
            this.Controls.Add(this.btnTereni);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnZaposlenici);
            this.Name = "frmGlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnTereni;
        private System.Windows.Forms.Button btnTermini;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Button btnStatistika;
    }
}