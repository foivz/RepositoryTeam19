namespace RezervacijeSportskihTerena
{
    partial class frmNovaRezervacija
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTereni = new System.Windows.Forms.DataGridView();
            this.kalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.listaVremena = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnNoviKorisnik = new System.Windows.Forms.Button();
            this.btnIzmjeniKorisnika = new System.Windows.Forms.Button();
            this.btnObrisiKorisnika = new System.Windows.Forms.Button();
            this.numBrSati = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.idKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivTeren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaSata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTereni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrSati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odabirite korisnika :";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKorisnik,
            this.imePrezimeKorisnik,
            this.emailKorisnik,
            this.telefonKorisnik});
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 25);
            this.dgvKorisnici.MultiSelect = false;
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(750, 215);
            this.dgvKorisnici.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Odabirite Teren :";
            // 
            // dgvTereni
            // 
            this.dgvTereni.AllowUserToAddRows = false;
            this.dgvTereni.AllowUserToDeleteRows = false;
            this.dgvTereni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTereni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTereni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTereni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTeren,
            this.nazivTeren,
            this.sport,
            this.opis,
            this.cijenaSata});
            this.dgvTereni.Location = new System.Drawing.Point(12, 287);
            this.dgvTereni.MultiSelect = false;
            this.dgvTereni.Name = "dgvTereni";
            this.dgvTereni.ReadOnly = true;
            this.dgvTereni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTereni.Size = new System.Drawing.Size(750, 215);
            this.dgvTereni.TabIndex = 1;
            // 
            // kalendar
            // 
            this.kalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.kalendar.Location = new System.Drawing.Point(12, 537);
            this.kalendar.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.kalendar.MaxSelectionCount = 1;
            this.kalendar.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.kalendar.Name = "kalendar";
            this.kalendar.ScrollChange = 1;
            this.kalendar.ShowTodayCircle = false;
            this.kalendar.TabIndex = 2;
            this.kalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kalendar_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Odabirite Datum :";
            // 
            // listaVremena
            // 
            this.listaVremena.FormattingEnabled = true;
            this.listaVremena.Location = new System.Drawing.Point(223, 539);
            this.listaVremena.Name = "listaVremena";
            this.listaVremena.Size = new System.Drawing.Size(199, 160);
            this.listaVremena.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Odabirite pocetno vrijeme :";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Location = new System.Drawing.Point(662, 669);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 35);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Location = new System.Drawing.Point(556, 669);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 35);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviKorisnik.Location = new System.Drawing.Point(450, 246);
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(100, 35);
            this.btnNoviKorisnik.TabIndex = 4;
            this.btnNoviKorisnik.Text = "Novi korisnik";
            this.btnNoviKorisnik.UseVisualStyleBackColor = true;
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // btnIzmjeniKorisnika
            // 
            this.btnIzmjeniKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmjeniKorisnika.Location = new System.Drawing.Point(556, 246);
            this.btnIzmjeniKorisnika.Name = "btnIzmjeniKorisnika";
            this.btnIzmjeniKorisnika.Size = new System.Drawing.Size(100, 35);
            this.btnIzmjeniKorisnika.TabIndex = 5;
            this.btnIzmjeniKorisnika.Text = "Izmjeni";
            this.btnIzmjeniKorisnika.UseVisualStyleBackColor = true;
            this.btnIzmjeniKorisnika.Click += new System.EventHandler(this.btnIzmjeniKorisnika_Click);
            // 
            // btnObrisiKorisnika
            // 
            this.btnObrisiKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiKorisnika.Location = new System.Drawing.Point(662, 246);
            this.btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            this.btnObrisiKorisnika.Size = new System.Drawing.Size(100, 35);
            this.btnObrisiKorisnika.TabIndex = 5;
            this.btnObrisiKorisnika.Text = "Obriši";
            this.btnObrisiKorisnika.UseVisualStyleBackColor = true;
            this.btnObrisiKorisnika.Click += new System.EventHandler(this.btnObrisiKorisnika_Click);
            // 
            // numBrSati
            // 
            this.numBrSati.Location = new System.Drawing.Point(430, 540);
            this.numBrSati.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBrSati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrSati.Name = "numBrSati";
            this.numBrSati.ReadOnly = true;
            this.numBrSati.Size = new System.Drawing.Size(120, 20);
            this.numBrSati.TabIndex = 6;
            this.numBrSati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Odabirite broj sati:";
            // 
            // idKorisnik
            // 
            this.idKorisnik.HeaderText = "ID korisnika";
            this.idKorisnik.Name = "idKorisnik";
            this.idKorisnik.ReadOnly = true;
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
            // idTeren
            // 
            this.idTeren.HeaderText = "ID terena";
            this.idTeren.Name = "idTeren";
            this.idTeren.ReadOnly = true;
            // 
            // nazivTeren
            // 
            this.nazivTeren.HeaderText = "Naziv terena";
            this.nazivTeren.Name = "nazivTeren";
            this.nazivTeren.ReadOnly = true;
            // 
            // sport
            // 
            this.sport.HeaderText = "Sport";
            this.sport.Name = "sport";
            this.sport.ReadOnly = true;
            // 
            // opis
            // 
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.ReadOnly = true;
            // 
            // cijenaSata
            // 
            this.cijenaSata.HeaderText = "Cijena sata";
            this.cijenaSata.Name = "cijenaSata";
            this.cijenaSata.ReadOnly = true;
            // 
            // frmNovaRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 711);
            this.Controls.Add(this.numBrSati);
            this.Controls.Add(this.btnObrisiKorisnika);
            this.Controls.Add(this.btnIzmjeniKorisnika);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnNoviKorisnik);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.listaVremena);
            this.Controls.Add(this.kalendar);
            this.Controls.Add(this.dgvTereni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.label1);
            this.Name = "frmNovaRezervacija";
            this.Text = "Nova Rezervacija";
            this.Load += new System.EventHandler(this.frmNovaRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTereni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrSati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTereni;
        private System.Windows.Forms.MonthCalendar kalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listaVremena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnNoviKorisnik;
        private System.Windows.Forms.Button btnIzmjeniKorisnika;
        private System.Windows.Forms.Button btnObrisiKorisnika;
        private System.Windows.Forms.NumericUpDown numBrSati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeren;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivTeren;
        private System.Windows.Forms.DataGridViewTextBoxColumn sport;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaSata;
    }
}