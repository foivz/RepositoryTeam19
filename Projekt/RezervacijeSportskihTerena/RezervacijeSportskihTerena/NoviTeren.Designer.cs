namespace RezervacijeSportskihTerena
{
    partial class frmNoviTeren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoviTeren));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDTeren = new System.Windows.Forms.TextBox();
            this.txtNazivTerena = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCijenaSata = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajVrstuTerena = new System.Windows.Forms.Button();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opis : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id terena :";
            // 
            // txtIDTeren
            // 
            this.txtIDTeren.Location = new System.Drawing.Point(280, 40);
            this.txtIDTeren.Name = "txtIDTeren";
            this.txtIDTeren.ReadOnly = true;
            this.txtIDTeren.Size = new System.Drawing.Size(75, 20);
            this.txtIDTeren.TabIndex = 12;
            // 
            // txtNazivTerena
            // 
            this.txtNazivTerena.Location = new System.Drawing.Point(116, 74);
            this.txtNazivTerena.Name = "txtNazivTerena";
            this.txtNazivTerena.Size = new System.Drawing.Size(239, 20);
            this.txtNazivTerena.TabIndex = 1;
            this.txtNazivTerena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNazivTerena_KeyPress);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(116, 229);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(239, 76);
            this.txtOpis.TabIndex = 5;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(280, 321);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(189, 321);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cijena sata :";
            // 
            // txtCijenaSata
            // 
            this.txtCijenaSata.Location = new System.Drawing.Point(116, 192);
            this.txtCijenaSata.Name = "txtCijenaSata";
            this.txtCijenaSata.Size = new System.Drawing.Size(239, 20);
            this.txtCijenaSata.TabIndex = 4;
            this.txtCijenaSata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCijenaSata_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrsta terena  :";
            // 
            // btnDodajVrstuTerena
            // 
            this.btnDodajVrstuTerena.Location = new System.Drawing.Point(280, 145);
            this.btnDodajVrstuTerena.Name = "btnDodajVrstuTerena";
            this.btnDodajVrstuTerena.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVrstuTerena.TabIndex = 14;
            this.btnDodajVrstuTerena.Text = "Dodaj";
            this.btnDodajVrstuTerena.UseVisualStyleBackColor = true;
            this.btnDodajVrstuTerena.Click += new System.EventHandler(this.btnDodajVrstuTerena_Click);
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(116, 148);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(148, 20);
            this.txtVrsta.TabIndex = 15;
            // 
            // frmNoviTeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 357);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.btnDodajVrstuTerena);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtCijenaSata);
            this.Controls.Add(this.txtNazivTerena);
            this.Controls.Add(this.txtIDTeren);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNoviTeren";
            this.Text = "Novi Teren";
            this.Load += new System.EventHandler(this.frmNoviTeren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDTeren;
        private System.Windows.Forms.TextBox txtNazivTerena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCijenaSata;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajVrstuTerena;
        private System.Windows.Forms.TextBox txtVrsta;
    }
}