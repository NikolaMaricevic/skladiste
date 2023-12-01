namespace WinFormsApp1
{
    partial class listaartikala
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
            izbrisiArtikl = new Button();
            urediArtikl = new Button();
            dodajArtikl = new Button();
            Artikli = new ListBox();
            kupac = new Button();
            narudzba = new Button();
            SuspendLayout();
            // 
            // izbrisiArtikl
            // 
            izbrisiArtikl.Location = new Point(686, 396);
            izbrisiArtikl.Margin = new Padding(3, 4, 3, 4);
            izbrisiArtikl.Name = "izbrisiArtikl";
            izbrisiArtikl.Size = new Size(141, 61);
            izbrisiArtikl.TabIndex = 11;
            izbrisiArtikl.Text = "Izbriši";
            izbrisiArtikl.UseVisualStyleBackColor = true;
            izbrisiArtikl.Click += izbrisiArtikl_Click;
            // 
            // urediArtikl
            // 
            urediArtikl.Location = new Point(686, 283);
            urediArtikl.Margin = new Padding(3, 4, 3, 4);
            urediArtikl.Name = "urediArtikl";
            urediArtikl.Size = new Size(141, 61);
            urediArtikl.TabIndex = 10;
            urediArtikl.Text = "Uredi";
            urediArtikl.UseVisualStyleBackColor = true;
            urediArtikl.Click += urediArtikl_Click;
            // 
            // dodajArtikl
            // 
            dodajArtikl.Location = new Point(686, 159);
            dodajArtikl.Margin = new Padding(3, 4, 3, 4);
            dodajArtikl.Name = "dodajArtikl";
            dodajArtikl.Size = new Size(141, 61);
            dodajArtikl.TabIndex = 9;
            dodajArtikl.Text = "Dodaj";
            dodajArtikl.UseVisualStyleBackColor = true;
            dodajArtikl.Click += dodajArtikl_Click;
            // 
            // Artikli
            // 
            Artikli.FormattingEnabled = true;
            Artikli.ItemHeight = 20;
            Artikli.Location = new Point(88, 143);
            Artikli.Margin = new Padding(3, 4, 3, 4);
            Artikli.Name = "Artikli";
            Artikli.Size = new Size(499, 404);
            Artikli.TabIndex = 8;
            Artikli.SelectedIndexChanged += Artikli_SelectedIndexChanged;
            // 
            // kupac
            // 
            kupac.Location = new Point(240, 53);
            kupac.Margin = new Padding(3, 4, 3, 4);
            kupac.Name = "kupac";
            kupac.Size = new Size(120, 47);
            kupac.TabIndex = 7;
            kupac.Text = "kupac";
            kupac.UseVisualStyleBackColor = true;
            kupac.Click += kupac_Click;
            // 
            // narudzba
            // 
            narudzba.Location = new Point(88, 53);
            narudzba.Margin = new Padding(3, 4, 3, 4);
            narudzba.Name = "narudzba";
            narudzba.Size = new Size(120, 47);
            narudzba.TabIndex = 6;
            narudzba.Text = "Narudžba";
            narudzba.UseVisualStyleBackColor = true;
            narudzba.Click += narudzba_Click;
            // 
            // listaartikala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(izbrisiArtikl);
            Controls.Add(urediArtikl);
            Controls.Add(dodajArtikl);
            Controls.Add(Artikli);
            Controls.Add(kupac);
            Controls.Add(narudzba);
            Margin = new Padding(3, 4, 3, 4);
            Name = "listaartikala";
            Text = "artikl";
            ResumeLayout(false);
        }

        #endregion

        private Button izbrisiArtikl;
        private Button urediArtikl;
        private Button dodajArtikl;
        private ListBox Artikli;
        private Button kupac;
        private Button narudzba;
    }
}