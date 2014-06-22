namespace RezervacijeSportskihTerena
{
    partial class frmNoviKorisnik
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
            this.txtIdKorisnik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImePrezimeKorisnik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailKorisnik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonKorisnik = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Korisnik :";
            // 
            // txtIdKorisnik
            // 
            this.txtIdKorisnik.Location = new System.Drawing.Point(265, 51);
            this.txtIdKorisnik.Name = "txtIdKorisnik";
            this.txtIdKorisnik.ReadOnly = true;
            this.txtIdKorisnik.Size = new System.Drawing.Size(75, 20);
            this.txtIdKorisnik.TabIndex = 1;
            this.txtIdKorisnik.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ime i prezime :";
            // 
            // txtImePrezimeKorisnik
            // 
            this.txtImePrezimeKorisnik.Location = new System.Drawing.Point(104, 93);
            this.txtImePrezimeKorisnik.Name = "txtImePrezimeKorisnik";
            this.txtImePrezimeKorisnik.Size = new System.Drawing.Size(236, 20);
            this.txtImePrezimeKorisnik.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email :";
            // 
            // txtEmailKorisnik
            // 
            this.txtEmailKorisnik.Location = new System.Drawing.Point(104, 135);
            this.txtEmailKorisnik.Name = "txtEmailKorisnik";
            this.txtEmailKorisnik.Size = new System.Drawing.Size(236, 20);
            this.txtEmailKorisnik.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kontakt broj :";
            // 
            // txtTelefonKorisnik
            // 
            this.txtTelefonKorisnik.Location = new System.Drawing.Point(104, 177);
            this.txtTelefonKorisnik.Name = "txtTelefonKorisnik";
            this.txtTelefonKorisnik.Size = new System.Drawing.Size(236, 20);
            this.txtTelefonKorisnik.TabIndex = 2;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(265, 290);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(168, 290);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmNoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 352);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtTelefonKorisnik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailKorisnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImePrezimeKorisnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdKorisnik);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviKorisnik";
            this.Text = "Novi Korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdKorisnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImePrezimeKorisnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailKorisnik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonKorisnik;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
    }
}