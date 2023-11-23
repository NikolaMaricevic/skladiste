namespace WinFormsApp1
{
    partial class dodajKupca
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
            this.ime = new System.Windows.Forms.TextBox();
            this.oib = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.nazad = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(80, 52);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(327, 23);
            this.ime.TabIndex = 0;
            this.ime.Text = "Unesi ime";
            // 
            // oib
            // 
            this.oib.Location = new System.Drawing.Point(80, 210);
            this.oib.Name = "oib";
            this.oib.Size = new System.Drawing.Size(327, 23);
            this.oib.TabIndex = 1;
            this.oib.Text = "Unesi OIB";
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(80, 129);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(327, 23);
            this.prezime.TabIndex = 2;
            this.prezime.Text = "Unesi prezime";
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(93, 299);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(191, 94);
            this.nazad.TabIndex = 3;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(492, 299);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(191, 94);
            this.Dodaj.TabIndex = 4;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            // 
            // dodajKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.oib);
            this.Controls.Add(this.ime);
            this.Name = "dodajKupca";
            this.Text = "dodajKupca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ime;
        private TextBox oib;
        private TextBox prezime;
        private Button nazad;
        private Button Dodaj;
    }
}