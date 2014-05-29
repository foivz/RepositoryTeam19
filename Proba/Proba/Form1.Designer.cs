namespace Proba
{
    partial class Form1
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
            this.broj1 = new System.Windows.Forms.TextBox();
            this.broj2 = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNoviTekst = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // broj1
            // 
            this.broj1.Location = new System.Drawing.Point(24, 37);
            this.broj1.Name = "broj1";
            this.broj1.Size = new System.Drawing.Size(100, 20);
            this.broj1.TabIndex = 0;
            // 
            // broj2
            // 
            this.broj2.Location = new System.Drawing.Point(158, 37);
            this.broj2.Name = "broj2";
            this.broj2.Size = new System.Drawing.Size(100, 20);
            this.broj2.TabIndex = 1;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(92, 121);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(100, 20);
            this.txtRezultat.TabIndex = 2;
            this.txtRezultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRezultat.TextChanged += new System.EventHandler(this.rezultat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prvi broj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Drugi broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zbroj";
            // 
            // btnIzracun
            // 
            this.btnIzracun.Location = new System.Drawing.Point(34, 65);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(75, 23);
            this.btnIzracun.TabIndex = 8;
            this.btnIzracun.Text = "Izračunaj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Očisti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNoviTekst
            // 
            this.txtNoviTekst.Location = new System.Drawing.Point(118, 179);
            this.txtNoviTekst.Name = "txtNoviTekst";
            this.txtNoviTekst.ReadOnly = true;
            this.txtNoviTekst.Size = new System.Drawing.Size(140, 20);
            this.txtNoviTekst.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Daj tekst";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Daj MSG box";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNoviTekst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.broj2);
            this.Controls.Add(this.broj1);
            this.Name = "Form1";
            this.Text = "Zbrajanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox broj1;
        private System.Windows.Forms.TextBox broj2;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIzracun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNoviTekst;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

