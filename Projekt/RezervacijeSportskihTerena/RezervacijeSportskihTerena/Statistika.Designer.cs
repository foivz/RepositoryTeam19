﻿namespace RezervacijeSportskihTerena
{
    partial class frmStatistika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistika));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNajcesciSport = new System.Windows.Forms.Button();
            this.btnNajviseKoristenTeren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNajviseRezervacija = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMjesecniPrihod = new System.Windows.Forms.Button();
            this.btnUkupanPrihod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNajkoristenijiTermin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.prikaz = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRez = new System.Windows.Forms.Label();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNajcesciSport);
            this.panel1.Controls.Add(this.btnNajviseKoristenTeren);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnNajcesciSport
            // 
            this.btnNajcesciSport.Location = new System.Drawing.Point(3, 44);
            this.btnNajcesciSport.Name = "btnNajcesciSport";
            this.btnNajcesciSport.Size = new System.Drawing.Size(244, 35);
            this.btnNajcesciSport.TabIndex = 1;
            this.btnNajcesciSport.Text = "Najviše rezerviran sport";
            this.btnNajcesciSport.UseVisualStyleBackColor = true;
            this.btnNajcesciSport.Click += new System.EventHandler(this.btnNajcesciSport_Click);
            // 
            // btnNajviseKoristenTeren
            // 
            this.btnNajviseKoristenTeren.Location = new System.Drawing.Point(3, 3);
            this.btnNajviseKoristenTeren.Name = "btnNajviseKoristenTeren";
            this.btnNajviseKoristenTeren.Size = new System.Drawing.Size(244, 35);
            this.btnNajviseKoristenTeren.TabIndex = 1;
            this.btnNajviseKoristenTeren.Text = "Najviše korišten teren";
            this.btnNajviseKoristenTeren.UseVisualStyleBackColor = true;
            this.btnNajviseKoristenTeren.Click += new System.EventHandler(this.btnNajviseKoristenTeren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tereni";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNajviseRezervacija);
            this.panel2.Location = new System.Drawing.Point(12, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 43);
            this.panel2.TabIndex = 0;
            // 
            // btnNajviseRezervacija
            // 
            this.btnNajviseRezervacija.Location = new System.Drawing.Point(3, 3);
            this.btnNajviseRezervacija.Name = "btnNajviseRezervacija";
            this.btnNajviseRezervacija.Size = new System.Drawing.Size(244, 35);
            this.btnNajviseRezervacija.TabIndex = 1;
            this.btnNajviseRezervacija.Text = "Korisnik sa najvećim brojem rezervacija";
            this.btnNajviseRezervacija.UseVisualStyleBackColor = true;
            this.btnNajviseRezervacija.Click += new System.EventHandler(this.btnNajviseRezervacija_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisnici";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMjesecniPrihod);
            this.panel3.Controls.Add(this.btnUkupanPrihod);
            this.panel3.Location = new System.Drawing.Point(12, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 82);
            this.panel3.TabIndex = 0;
            // 
            // btnMjesecniPrihod
            // 
            this.btnMjesecniPrihod.Location = new System.Drawing.Point(3, 44);
            this.btnMjesecniPrihod.Name = "btnMjesecniPrihod";
            this.btnMjesecniPrihod.Size = new System.Drawing.Size(244, 35);
            this.btnMjesecniPrihod.TabIndex = 1;
            this.btnMjesecniPrihod.Text = "Mjesečni prihod";
            this.btnMjesecniPrihod.UseVisualStyleBackColor = true;
            this.btnMjesecniPrihod.Click += new System.EventHandler(this.btnMjesecniPrihod_Click);
            // 
            // btnUkupanPrihod
            // 
            this.btnUkupanPrihod.Location = new System.Drawing.Point(3, 3);
            this.btnUkupanPrihod.Name = "btnUkupanPrihod";
            this.btnUkupanPrihod.Size = new System.Drawing.Size(244, 35);
            this.btnUkupanPrihod.TabIndex = 1;
            this.btnUkupanPrihod.Text = "Ukupan prihod";
            this.btnUkupanPrihod.UseVisualStyleBackColor = true;
            this.btnUkupanPrihod.Click += new System.EventHandler(this.btnUkupanPrihod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prihodi";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNajkoristenijiTermin);
            this.panel4.Location = new System.Drawing.Point(12, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 43);
            this.panel4.TabIndex = 0;
            // 
            // btnNajkoristenijiTermin
            // 
            this.btnNajkoristenijiTermin.Location = new System.Drawing.Point(3, 3);
            this.btnNajkoristenijiTermin.Name = "btnNajkoristenijiTermin";
            this.btnNajkoristenijiTermin.Size = new System.Drawing.Size(244, 35);
            this.btnNajkoristenijiTermin.TabIndex = 1;
            this.btnNajkoristenijiTermin.Text = "Najviše korišten termin";
            this.btnNajkoristenijiTermin.UseVisualStyleBackColor = true;
            this.btnNajkoristenijiTermin.Click += new System.EventHandler(this.btnNajkoristenijiTermin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Termini";
            // 
            // prikaz
            // 
            this.prikaz.FormattingEnabled = true;
            this.prikaz.Location = new System.Drawing.Point(265, 22);
            this.prikaz.Name = "prikaz";
            this.prikaz.Size = new System.Drawing.Size(266, 134);
            this.prikaz.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Traži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pretraživanje korisnika";
            // 
            // lblRez
            // 
            this.lblRez.AutoSize = true;
            this.lblRez.Location = new System.Drawing.Point(268, 216);
            this.lblRez.Name = "lblRez";
            this.lblRez.Size = new System.Drawing.Size(182, 13);
            this.lblRez.TabIndex = 6;
            this.lblRez.Text = "Broj rezervacija za traženog korisnika";
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(455, 213);
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(75, 20);
            this.txtRez.TabIndex = 7;
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(542, 342);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.lblRez);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatistika_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNajviseKoristenTeren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNajcesciSport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNajviseRezervacija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMjesecniPrihod;
        private System.Windows.Forms.Button btnUkupanPrihod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNajkoristenijiTermin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox prikaz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRez;
        private System.Windows.Forms.TextBox txtRez;
    }
}