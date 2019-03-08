namespace Kalkulator
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdejmij = new System.Windows.Forms.Button();
            this.btnPomnoz = new System.Windows.Forms.Button();
            this.btnPodziel = new System.Windows.Forms.Button();
            this.txtLiczba1 = new System.Windows.Forms.TextBox();
            this.txtLiczba2 = new System.Windows.Forms.TextBox();
            this.lblEtykieta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(76, 65);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdejmij
            // 
            this.btnOdejmij.Location = new System.Drawing.Point(189, 65);
            this.btnOdejmij.Name = "btnOdejmij";
            this.btnOdejmij.Size = new System.Drawing.Size(75, 23);
            this.btnOdejmij.TabIndex = 1;
            this.btnOdejmij.Text = "Odejmij";
            this.btnOdejmij.UseVisualStyleBackColor = true;
            this.btnOdejmij.Click += new System.EventHandler(this.btnOdejmij_Click);
            // 
            // btnPomnoz
            // 
            this.btnPomnoz.Location = new System.Drawing.Point(316, 65);
            this.btnPomnoz.Name = "btnPomnoz";
            this.btnPomnoz.Size = new System.Drawing.Size(75, 23);
            this.btnPomnoz.TabIndex = 2;
            this.btnPomnoz.Text = "Pomnóż";
            this.btnPomnoz.UseVisualStyleBackColor = true;
            this.btnPomnoz.Click += new System.EventHandler(this.btnPomnoz_Click);
            // 
            // btnPodziel
            // 
            this.btnPodziel.Location = new System.Drawing.Point(451, 65);
            this.btnPodziel.Name = "btnPodziel";
            this.btnPodziel.Size = new System.Drawing.Size(75, 23);
            this.btnPodziel.TabIndex = 3;
            this.btnPodziel.Text = "Podziel";
            this.btnPodziel.UseVisualStyleBackColor = true;
            this.btnPodziel.Click += new System.EventHandler(this.btnPodziel_Click);
            // 
            // txtLiczba1
            // 
            this.txtLiczba1.Location = new System.Drawing.Point(156, 145);
            this.txtLiczba1.Name = "txtLiczba1";
            this.txtLiczba1.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba1.TabIndex = 4;
            // 
            // txtLiczba2
            // 
            this.txtLiczba2.Location = new System.Drawing.Point(363, 144);
            this.txtLiczba2.Name = "txtLiczba2";
            this.txtLiczba2.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba2.TabIndex = 5;
            // 
            // lblEtykieta
            // 
            this.lblEtykieta.AutoSize = true;
            this.lblEtykieta.Location = new System.Drawing.Point(216, 205);
            this.lblEtykieta.Name = "lblEtykieta";
            this.lblEtykieta.Size = new System.Drawing.Size(37, 13);
            this.lblEtykieta.TabIndex = 6;
            this.lblEtykieta.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 519);
            this.Controls.Add(this.lblEtykieta);
            this.Controls.Add(this.txtLiczba2);
            this.Controls.Add(this.txtLiczba1);
            this.Controls.Add(this.btnPodziel);
            this.Controls.Add(this.btnPomnoz);
            this.Controls.Add(this.btnOdejmij);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdejmij;
        private System.Windows.Forms.Button btnPomnoz;
        private System.Windows.Forms.Button btnPodziel;
        private System.Windows.Forms.TextBox txtLiczba1;
        private System.Windows.Forms.TextBox txtLiczba2;
        private System.Windows.Forms.Label lblEtykieta;
    }
}

