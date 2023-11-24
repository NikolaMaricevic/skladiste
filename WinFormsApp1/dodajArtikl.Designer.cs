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
            artikldodaj = new Button();
            nazad = new Button();
            kategorija = new TextBox();
            Barcode = new TextBox();
            nazivArtikla = new TextBox();
            SuspendLayout();
            // 
            // artikldodaj
            // 
            artikldodaj.Cursor = Cursors.IBeam;
            artikldodaj.Location = new Point(584, 403);
            artikldodaj.Margin = new Padding(3, 4, 3, 4);
            artikldodaj.Name = "artikldodaj";
            artikldodaj.Size = new Size(218, 125);
            artikldodaj.TabIndex = 14;
            artikldodaj.Text = "Dodaj";
            artikldodaj.UseVisualStyleBackColor = true;
            artikldodaj.Click += artikldodaj_Click;
            // 
            // nazad
            // 
            nazad.Cursor = Cursors.IBeam;
            nazad.Location = new Point(128, 403);
            nazad.Margin = new Padding(3, 4, 3, 4);
            nazad.Name = "nazad";
            nazad.Size = new Size(218, 125);
            nazad.TabIndex = 13;
            nazad.Text = "Nazad";
            nazad.UseVisualStyleBackColor = true;
            nazad.Click += nazad_Click;
            // 
            // kategorija
            // 
            kategorija.Cursor = Cursors.IBeam;
            kategorija.Location = new Point(113, 176);
            kategorija.Margin = new Padding(3, 4, 3, 4);
            kategorija.Name = "kategorija";
            kategorija.Size = new Size(373, 27);
            kategorija.TabIndex = 12;
            kategorija.Text = "Kategorija artikla";
            kategorija.TextChanged += kategorija_TextChanged;
            // 
            // Barcode
            // 
            Barcode.Cursor = Cursors.IBeam;
            Barcode.Location = new Point(113, 284);
            Barcode.Margin = new Padding(3, 4, 3, 4);
            Barcode.Name = "Barcode";
            Barcode.Size = new Size(373, 27);
            Barcode.TabIndex = 11;
            Barcode.Text = "Unesi barcode";
            Barcode.TextChanged += Barcode_TextChanged;
            // 
            // nazivArtikla
            // 
            nazivArtikla.Cursor = Cursors.IBeam;
            nazivArtikla.Location = new Point(113, 73);
            nazivArtikla.Margin = new Padding(3, 4, 3, 4);
            nazivArtikla.Name = "nazivArtikla";
            nazivArtikla.Size = new Size(373, 27);
            nazivArtikla.TabIndex = 10;
            nazivArtikla.Text = "Naziv Artikla";
            nazivArtikla.TextChanged += nazivArtikla_TextChanged;
            // 
            // dodajArtikl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(artikldodaj);
            Controls.Add(nazad);
            Controls.Add(kategorija);
            Controls.Add(Barcode);
            Controls.Add(nazivArtikla);
            Margin = new Padding(3, 4, 3, 4);
            Name = "dodajArtikl";
            Text = "dodajArtikl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button artikldodaj;
        private Button nazad;
        private TextBox kategorija;
        private TextBox Barcode;
        private TextBox nazivArtikla;
    }
}