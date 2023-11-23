namespace WinFormsApp1
{
    partial class dodajArtikl
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
            this.artikldodaj = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.kategorija = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.nazivArtikla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // artikldodaj
            // 
            this.artikldodaj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.artikldodaj.Location = new System.Drawing.Point(511, 302);
            this.artikldodaj.Name = "artikldodaj";
            this.artikldodaj.Size = new System.Drawing.Size(191, 94);
            this.artikldodaj.TabIndex = 14;
            this.artikldodaj.Text = "Dodaj";
            this.artikldodaj.UseVisualStyleBackColor = true;
            // 
            // nazad
            // 
            this.nazad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazad.Location = new System.Drawing.Point(112, 302);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(191, 94);
            this.nazad.TabIndex = 13;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            // 
            // kategorija
            // 
            this.kategorija.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kategorija.Location = new System.Drawing.Point(99, 132);
            this.kategorija.Name = "kategorija";
            this.kategorija.Size = new System.Drawing.Size(327, 23);
            this.kategorija.TabIndex = 12;
            this.kategorija.Text = "Kategorija artikla";
            // 
            // ISBN
            // 
            this.ISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ISBN.Location = new System.Drawing.Point(99, 213);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(327, 23);
            this.ISBN.TabIndex = 11;
            this.ISBN.Text = "Unesi ISBN";
            // 
            // nazivArtikla
            // 
            this.nazivArtikla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazivArtikla.Location = new System.Drawing.Point(99, 55);
            this.nazivArtikla.Name = "nazivArtikla";
            this.nazivArtikla.Size = new System.Drawing.Size(327, 23);
            this.nazivArtikla.TabIndex = 10;
            this.nazivArtikla.Text = "Naziv Artikla";
            // 
            // dodajArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.artikldodaj);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.kategorija);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.nazivArtikla);
            this.Name = "dodajArtikl";
            this.Text = "dodajArtikl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button artikldodaj;
        private Button nazad;
        private TextBox kategorija;
        private TextBox ISBN;
        private TextBox nazivArtikla;
    }
}