namespace RezervacijeSportskihTerena
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.lblNaslovRubrike = new System.Windows.Forms.Label();
            this.txtPrihod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRez = new System.Windows.Forms.Label();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chartMjesecniPrihodi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKorisnik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTeren = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMjesecniPrihodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKorisnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeren)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNajcesciSport);
            this.panel1.Controls.Add(this.btnNajviseKoristenTeren);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 103);
            this.panel1.TabIndex = 1;
            // 
            // btnNajcesciSport
            // 
            this.btnNajcesciSport.Location = new System.Drawing.Point(3, 64);
            this.btnNajcesciSport.Name = "btnNajcesciSport";
            this.btnNajcesciSport.Size = new System.Drawing.Size(244, 35);
            this.btnNajcesciSport.TabIndex = 1;
            this.btnNajcesciSport.Text = "Najviše rezerviran sport";
            this.btnNajcesciSport.UseVisualStyleBackColor = true;
            this.btnNajcesciSport.Click += new System.EventHandler(this.btnNajcesciSport_Click);
            // 
            // btnNajviseKoristenTeren
            // 
            this.btnNajviseKoristenTeren.Location = new System.Drawing.Point(3, 23);
            this.btnNajviseKoristenTeren.Name = "btnNajviseKoristenTeren";
            this.btnNajviseKoristenTeren.Size = new System.Drawing.Size(244, 35);
            this.btnNajviseKoristenTeren.TabIndex = 0;
            this.btnNajviseKoristenTeren.Text = "Najviše korišten teren";
            this.btnNajviseKoristenTeren.UseVisualStyleBackColor = true;
            this.btnNajviseKoristenTeren.Click += new System.EventHandler(this.btnNajviseKoristenTeren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tereni";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNajviseRezervacija);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 57);
            this.panel2.TabIndex = 2;
            // 
            // btnNajviseRezervacija
            // 
            this.btnNajviseRezervacija.Location = new System.Drawing.Point(3, 19);
            this.btnNajviseRezervacija.Name = "btnNajviseRezervacija";
            this.btnNajviseRezervacija.Size = new System.Drawing.Size(244, 35);
            this.btnNajviseRezervacija.TabIndex = 0;
            this.btnNajviseRezervacija.Text = "Korisnik sa najvećim brojem rezervacija";
            this.btnNajviseRezervacija.UseVisualStyleBackColor = true;
            this.btnNajviseRezervacija.Click += new System.EventHandler(this.btnNajviseRezervacija_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisnici";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMjesecniPrihod);
            this.panel3.Controls.Add(this.btnUkupanPrihod);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 99);
            this.panel3.TabIndex = 4;
            // 
            // btnMjesecniPrihod
            // 
            this.btnMjesecniPrihod.Location = new System.Drawing.Point(3, 62);
            this.btnMjesecniPrihod.Name = "btnMjesecniPrihod";
            this.btnMjesecniPrihod.Size = new System.Drawing.Size(244, 35);
            this.btnMjesecniPrihod.TabIndex = 1;
            this.btnMjesecniPrihod.Text = "Mjesečni prihod";
            this.btnMjesecniPrihod.UseVisualStyleBackColor = true;
            this.btnMjesecniPrihod.Click += new System.EventHandler(this.btnMjesecniPrihod_Click);
            // 
            // btnUkupanPrihod
            // 
            this.btnUkupanPrihod.Location = new System.Drawing.Point(3, 21);
            this.btnUkupanPrihod.Name = "btnUkupanPrihod";
            this.btnUkupanPrihod.Size = new System.Drawing.Size(244, 35);
            this.btnUkupanPrihod.TabIndex = 0;
            this.btnUkupanPrihod.Text = "Ukupan prihod";
            this.btnUkupanPrihod.UseVisualStyleBackColor = true;
            this.btnUkupanPrihod.Click += new System.EventHandler(this.btnUkupanPrihod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prihodi";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNajkoristenijiTermin);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 56);
            this.panel4.TabIndex = 3;
            // 
            // btnNajkoristenijiTermin
            // 
            this.btnNajkoristenijiTermin.Location = new System.Drawing.Point(3, 18);
            this.btnNajkoristenijiTermin.Name = "btnNajkoristenijiTermin";
            this.btnNajkoristenijiTermin.Size = new System.Drawing.Size(244, 35);
            this.btnNajkoristenijiTermin.TabIndex = 0;
            this.btnNajkoristenijiTermin.Text = "Najviše korišten termin";
            this.btnNajkoristenijiTermin.UseVisualStyleBackColor = true;
            this.btnNajkoristenijiTermin.Click += new System.EventHandler(this.btnNajkoristenijiTermin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(4, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Termini";
            // 
            // prikaz
            // 
            this.prikaz.FormattingEnabled = true;
            this.prikaz.Location = new System.Drawing.Point(278, 44);
            this.prikaz.Name = "prikaz";
            this.prikaz.Size = new System.Drawing.Size(310, 134);
            this.prikaz.TabIndex = 5;
            // 
            // lblNaslovRubrike
            // 
            this.lblNaslovRubrike.AutoSize = true;
            this.lblNaslovRubrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovRubrike.Location = new System.Drawing.Point(281, 22);
            this.lblNaslovRubrike.Name = "lblNaslovRubrike";
            this.lblNaslovRubrike.Size = new System.Drawing.Size(0, 13);
            this.lblNaslovRubrike.TabIndex = 8;
            // 
            // txtPrihod
            // 
            this.txtPrihod.Location = new System.Drawing.Point(213, 90);
            this.txtPrihod.Name = "txtPrihod";
            this.txtPrihod.ReadOnly = true;
            this.txtPrihod.Size = new System.Drawing.Size(75, 20);
            this.txtPrihod.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prihod od korisnika";
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(6, 37);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(185, 20);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(213, 35);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 1;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pretraživanje korisnika";
            // 
            // lblRez
            // 
            this.lblRez.AutoSize = true;
            this.lblRez.Location = new System.Drawing.Point(9, 67);
            this.lblRez.Name = "lblRez";
            this.lblRez.Size = new System.Drawing.Size(182, 13);
            this.lblRez.TabIndex = 6;
            this.lblRez.Text = "Broj rezervacija za traženog korisnika";
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(213, 64);
            this.txtRez.Name = "txtRez";
            this.txtRez.ReadOnly = true;
            this.txtRez.Size = new System.Drawing.Size(75, 20);
            this.txtRez.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtPrihod);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtRez);
            this.panel5.Controls.Add(this.lblRez);
            this.panel5.Controls.Add(this.btnTrazi);
            this.panel5.Controls.Add(this.txtTrazi);
            this.panel5.Location = new System.Drawing.Point(605, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 156);
            this.panel5.TabIndex = 0;
            // 
            // chartMjesecniPrihodi
            // 
            this.chartMjesecniPrihodi.BackColor = System.Drawing.Color.Transparent;
            this.chartMjesecniPrihodi.BorderlineColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chartMjesecniPrihodi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chartMjesecniPrihodi.Legends.Add(legend1);
            this.chartMjesecniPrihodi.Location = new System.Drawing.Point(278, 189);
            this.chartMjesecniPrihodi.Name = "chartMjesecniPrihodi";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Prihod (kn)";
            this.chartMjesecniPrihodi.Series.Add(series1);
            this.chartMjesecniPrihodi.Size = new System.Drawing.Size(637, 300);
            this.chartMjesecniPrihodi.TabIndex = 6;
            this.chartMjesecniPrihodi.Text = "chartMjesecniPrihodi";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            title1.Text = "Mjesečni prihodi po terenu";
            this.chartMjesecniPrihodi.Titles.Add(title1);
            this.chartMjesecniPrihodi.Visible = false;
            // 
            // chartSport
            // 
            this.chartSport.BackColor = System.Drawing.Color.Transparent;
            this.chartSport.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartSport.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartSport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSport.Legends.Add(legend2);
            this.chartSport.Location = new System.Drawing.Point(278, 189);
            this.chartSport.Name = "chartSport";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Sport";
            this.chartSport.Series.Add(series2);
            this.chartSport.Size = new System.Drawing.Size(637, 300);
            this.chartSport.TabIndex = 9;
            this.chartSport.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Title1";
            title2.Text = "Najčešće rezerviran sport (%)";
            this.chartSport.Titles.Add(title2);
            this.chartSport.Visible = false;
            // 
            // chartKorisnik
            // 
            this.chartKorisnik.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartKorisnik.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartKorisnik.Legends.Add(legend3);
            this.chartKorisnik.Location = new System.Drawing.Point(278, 189);
            this.chartKorisnik.Name = "chartKorisnik";
            series3.ChartArea = "ChartArea1";
            series3.EmptyPointStyle.IsValueShownAsLabel = true;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Broj rezervacija";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Prihod po korisniku (kn)";
            this.chartKorisnik.Series.Add(series3);
            this.chartKorisnik.Series.Add(series4);
            this.chartKorisnik.Size = new System.Drawing.Size(637, 300);
            this.chartKorisnik.TabIndex = 10;
            this.chartKorisnik.Text = "chartKorisnik";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title3.Name = "Title1";
            title3.Text = "Broj rezervacija po korisniku";
            this.chartKorisnik.Titles.Add(title3);
            this.chartKorisnik.Visible = false;
            // 
            // chartTeren
            // 
            this.chartTeren.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartTeren.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTeren.Legends.Add(legend4);
            this.chartTeren.Location = new System.Drawing.Point(278, 189);
            this.chartTeren.Name = "chartTeren";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Tereni";
            this.chartTeren.Series.Add(series5);
            this.chartTeren.Size = new System.Drawing.Size(637, 300);
            this.chartTeren.TabIndex = 11;
            this.chartTeren.Text = "chartTeren";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title4.Name = "Title1";
            title4.Text = "Najčešće rezervirani tereni (%)";
            this.chartTeren.Titles.Add(title4);
            this.chartTeren.Visible = false;
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblNaslovRubrike);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartSport);
            this.Controls.Add(this.chartMjesecniPrihodi);
            this.Controls.Add(this.chartTeren);
            this.Controls.Add(this.chartKorisnik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatistika_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMjesecniPrihodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKorisnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeren)).EndInit();
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
        private System.Windows.Forms.Label lblNaslovRubrike;
        private System.Windows.Forms.TextBox txtPrihod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRez;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMjesecniPrihodi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKorisnik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTeren;
    }
}