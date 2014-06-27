namespace RezervacijeSportskihTerena
{
    partial class frmRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervacije));
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnNovaRezervacija = new System.Windows.Forms.Button();
            this.idRezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivTerena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaSata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeZavrsetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRezervacija,
            this.imePrezimeKorisnik,
            this.emailKorisnik,
            this.telefonKorisnik,
            this.nazivTerena,
            this.cijenaSata,
            this.vrijemePocetka,
            this.vrijemeZavrsetka,
            this.datumRezervacije});
            this.dgvRezervacije.Location = new System.Drawing.Point(12, 12);
            this.dgvRezervacije.MultiSelect = false;
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(991, 418);
            this.dgvRezervacije.TabIndex = 0;
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(903, 436);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(100, 35);
            this.btnObrisiRezervaciju.TabIndex = 1;
            this.btnObrisiRezervaciju.Text = "Obriši";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // btnNovaRezervacija
            // 
            this.btnNovaRezervacija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaRezervacija.Location = new System.Drawing.Point(790, 436);
            this.btnNovaRezervacija.Name = "btnNovaRezervacija";
            this.btnNovaRezervacija.Size = new System.Drawing.Size(100, 35);
            this.btnNovaRezervacija.TabIndex = 1;
            this.btnNovaRezervacija.Text = "Nova rezervacija";
            this.btnNovaRezervacija.UseVisualStyleBackColor = true;
            this.btnNovaRezervacija.Click += new System.EventHandler(this.btnNovaRezervacija_Click);
            // 
            // idRezervacija
            // 
            this.idRezervacija.HeaderText = "ID Rezervacije";
            this.idRezervacija.Name = "idRezervacija";
            this.idRezervacija.ReadOnly = true;
            // 
            // imePrezimeKorisnik
            // 
            this.imePrezimeKorisnik.HeaderText = "Ime i prezime korisnika";
            this.imePrezimeKorisnik.Name = "imePrezimeKorisnik";
            this.imePrezimeKorisnik.ReadOnly = true;
            // 
            // emailKorisnik
            // 
            this.emailKorisnik.HeaderText = "Email korisnika";
            this.emailKorisnik.Name = "emailKorisnik";
            this.emailKorisnik.ReadOnly = true;
            // 
            // telefonKorisnik
            // 
            this.telefonKorisnik.HeaderText = "Kontakt broj";
            this.telefonKorisnik.Name = "telefonKorisnik";
            this.telefonKorisnik.ReadOnly = true;
            // 
            // nazivTerena
            // 
            this.nazivTerena.HeaderText = "Naziv terena";
            this.nazivTerena.Name = "nazivTerena";
            this.nazivTerena.ReadOnly = true;
            // 
            // cijenaSata
            // 
            this.cijenaSata.HeaderText = "Cijena sata";
            this.cijenaSata.Name = "cijenaSata";
            this.cijenaSata.ReadOnly = true;
            // 
            // vrijemePocetka
            // 
            this.vrijemePocetka.HeaderText = "Vrijeme početka";
            this.vrijemePocetka.Name = "vrijemePocetka";
            this.vrijemePocetka.ReadOnly = true;
            // 
            // vrijemeZavrsetka
            // 
            this.vrijemeZavrsetka.HeaderText = "Vrijeme završetka";
            this.vrijemeZavrsetka.Name = "vrijemeZavrsetka";
            this.vrijemeZavrsetka.ReadOnly = true;
            // 
            // datumRezervacije
            // 
            this.datumRezervacije.HeaderText = "Datum rezervacije";
            this.datumRezervacije.Name = "datumRezervacije";
            this.datumRezervacije.ReadOnly = true;
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 483);
            this.Controls.Add(this.btnNovaRezervacija);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.dgvRezervacije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRezervacije";
            this.Text = "Rezervacije";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRezervacije_FormClosing);
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.Button btnNovaRezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivTerena;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaSata;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeZavrsetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRezervacije;
    }
}