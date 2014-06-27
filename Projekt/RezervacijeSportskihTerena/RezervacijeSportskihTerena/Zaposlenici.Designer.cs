namespace RezervacijeSportskihTerena
{
    partial class frmZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaposlenici));
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnObrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnIzmjeniZaposlenika = new System.Windows.Forms.Button();
            this.btnNoviZaposlenik = new System.Windows.Forms.Button();
            this.idZaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeZaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeZaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZaposlenik,
            this.imeZaposlenik,
            this.prezimeZaposlenik,
            this.korisnickoIme,
            this.lozinka,
            this.email});
            this.dgvZaposlenici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvZaposlenici.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 13);
            this.dgvZaposlenici.MultiSelect = false;
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(810, 250);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnObrisiZaposlenika
            // 
            this.btnObrisiZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiZaposlenika.Location = new System.Drawing.Point(722, 269);
            this.btnObrisiZaposlenika.Name = "btnObrisiZaposlenika";
            this.btnObrisiZaposlenika.Size = new System.Drawing.Size(100, 35);
            this.btnObrisiZaposlenika.TabIndex = 1;
            this.btnObrisiZaposlenika.Text = "Obriši";
            this.btnObrisiZaposlenika.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenika.Click += new System.EventHandler(this.btnObrisiZaposlenika_Click);
            // 
            // btnIzmjeniZaposlenika
            // 
            this.btnIzmjeniZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmjeniZaposlenika.Location = new System.Drawing.Point(616, 269);
            this.btnIzmjeniZaposlenika.Name = "btnIzmjeniZaposlenika";
            this.btnIzmjeniZaposlenika.Size = new System.Drawing.Size(100, 35);
            this.btnIzmjeniZaposlenika.TabIndex = 2;
            this.btnIzmjeniZaposlenika.Text = "Izmjeni";
            this.btnIzmjeniZaposlenika.UseVisualStyleBackColor = true;
            this.btnIzmjeniZaposlenika.Click += new System.EventHandler(this.btnIzmjeniZaposlenika_Click);
            // 
            // btnNoviZaposlenik
            // 
            this.btnNoviZaposlenik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviZaposlenik.Location = new System.Drawing.Point(510, 269);
            this.btnNoviZaposlenik.Name = "btnNoviZaposlenik";
            this.btnNoviZaposlenik.Size = new System.Drawing.Size(100, 35);
            this.btnNoviZaposlenik.TabIndex = 3;
            this.btnNoviZaposlenik.Text = "Dodaj zaposlenika";
            this.btnNoviZaposlenik.UseVisualStyleBackColor = true;
            this.btnNoviZaposlenik.Click += new System.EventHandler(this.btnNoviZaposlenik_Click);
            // 
            // idZaposlenik
            // 
            this.idZaposlenik.HeaderText = "ID zaposlenika";
            this.idZaposlenik.Name = "idZaposlenik";
            this.idZaposlenik.ReadOnly = true;
            // 
            // imeZaposlenik
            // 
            this.imeZaposlenik.HeaderText = "Ime zaposlenika";
            this.imeZaposlenik.Name = "imeZaposlenik";
            this.imeZaposlenik.ReadOnly = true;
            // 
            // prezimeZaposlenik
            // 
            this.prezimeZaposlenik.HeaderText = "Prezime zaposlenika";
            this.prezimeZaposlenik.Name = "prezimeZaposlenik";
            this.prezimeZaposlenik.ReadOnly = true;
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.HeaderText = "Korisničko ime";
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.ReadOnly = true;
            // 
            // lozinka
            // 
            this.lozinka.HeaderText = "Lozinka";
            this.lozinka.Name = "lozinka";
            this.lozinka.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email adresa";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 312);
            this.Controls.Add(this.btnNoviZaposlenik);
            this.Controls.Add(this.btnIzmjeniZaposlenika);
            this.Controls.Add(this.btnObrisiZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmZaposlenici_FormClosing);
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnObrisiZaposlenika;
        private System.Windows.Forms.Button btnIzmjeniZaposlenika;
        private System.Windows.Forms.Button btnNoviZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinka;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}