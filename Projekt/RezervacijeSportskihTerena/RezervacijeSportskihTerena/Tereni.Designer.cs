namespace RezervacijeSportskihTerena
{
    partial class frmTereni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTereni));
            this.dgvTereni = new System.Windows.Forms.DataGridView();
            this.btnObrisiTeren = new System.Windows.Forms.Button();
            this.btnIzmjeniTeren = new System.Windows.Forms.Button();
            this.btnNoviTeren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTereni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTereni
            // 
            this.dgvTereni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvTereni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTereni.Location = new System.Drawing.Point(12, 12);
            this.dgvTereni.Name = "dgvTereni";
            this.dgvTereni.Size = new System.Drawing.Size(760, 250);
            this.dgvTereni.TabIndex = 0;
            // 
            // btnObrisiTeren
            // 
            this.btnObrisiTeren.Location = new System.Drawing.Point(672, 268);
            this.btnObrisiTeren.Name = "btnObrisiTeren";
            this.btnObrisiTeren.Size = new System.Drawing.Size(100, 35);
            this.btnObrisiTeren.TabIndex = 1;
            this.btnObrisiTeren.Text = "Obriši";
            this.btnObrisiTeren.UseVisualStyleBackColor = true;
            this.btnObrisiTeren.Click += new System.EventHandler(this.btnObrisiTeren_Click);
            // 
            // btnIzmjeniTeren
            // 
            this.btnIzmjeniTeren.Location = new System.Drawing.Point(566, 268);
            this.btnIzmjeniTeren.Name = "btnIzmjeniTeren";
            this.btnIzmjeniTeren.Size = new System.Drawing.Size(100, 35);
            this.btnIzmjeniTeren.TabIndex = 1;
            this.btnIzmjeniTeren.Text = "Izmjeni";
            this.btnIzmjeniTeren.UseVisualStyleBackColor = true;
            this.btnIzmjeniTeren.Click += new System.EventHandler(this.btnIzmjeniTeren_Click);
            // 
            // btnNoviTeren
            // 
            this.btnNoviTeren.Location = new System.Drawing.Point(460, 268);
            this.btnNoviTeren.Name = "btnNoviTeren";
            this.btnNoviTeren.Size = new System.Drawing.Size(100, 35);
            this.btnNoviTeren.TabIndex = 1;
            this.btnNoviTeren.Text = "Dodaj teren";
            this.btnNoviTeren.UseVisualStyleBackColor = true;
            this.btnNoviTeren.Click += new System.EventHandler(this.btnNoviTeren_Click);
            // 
            // frmTereni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 312);
            this.Controls.Add(this.btnNoviTeren);
            this.Controls.Add(this.btnIzmjeniTeren);
            this.Controls.Add(this.btnObrisiTeren);
            this.Controls.Add(this.dgvTereni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTereni";
            this.Text = "Tereni";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTereni_FormClosing);
            this.Load += new System.EventHandler(this.frmTereni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTereni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTereni;
        private System.Windows.Forms.Button btnObrisiTeren;
        private System.Windows.Forms.Button btnIzmjeniTeren;
        private System.Windows.Forms.Button btnNoviTeren;
    }
}