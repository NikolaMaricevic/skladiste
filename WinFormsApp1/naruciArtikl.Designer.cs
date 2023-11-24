namespace WinFormsApp1
{
    partial class naruciArtikl
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
            naruci = new Button();
            nazad = new Button();
            listaKupaca = new ListBox();
            listaArtikala = new ListBox();
            SuspendLayout();
            // 
            // naruci
            // 
            naruci.Cursor = Cursors.IBeam;
            naruci.Location = new Point(584, 403);
            naruci.Margin = new Padding(3, 4, 3, 4);
            naruci.Name = "naruci";
            naruci.Size = new Size(218, 125);
            naruci.TabIndex = 9;
            naruci.Text = "Naruči";
            naruci.UseVisualStyleBackColor = true;
            naruci.Click += naruci_Click;
            // 
            // nazad
            // 
            nazad.Cursor = Cursors.IBeam;
            nazad.Location = new Point(128, 403);
            nazad.Margin = new Padding(3, 4, 3, 4);
            nazad.Name = "nazad";
            nazad.Size = new Size(218, 125);
            nazad.TabIndex = 8;
            nazad.Text = "Nazad";
            nazad.UseVisualStyleBackColor = true;
            nazad.Click += nazad_Click;
            // 
            // listaKupaca
            // 
            listaKupaca.FormattingEnabled = true;
            listaKupaca.ItemHeight = 20;
            listaKupaca.Location = new Point(67, 26);
            listaKupaca.Name = "listaKupaca";
            listaKupaca.Size = new Size(320, 304);
            listaKupaca.TabIndex = 10;
            listaKupaca.SelectedIndexChanged += listaKupaca_SelectedIndexChanged;
            // 
            // listaArtikala
            // 
            listaArtikala.FormattingEnabled = true;
            listaArtikala.ItemHeight = 20;
            listaArtikala.Location = new Point(549, 26);
            listaArtikala.Name = "listaArtikala";
            listaArtikala.Size = new Size(320, 304);
            listaArtikala.TabIndex = 11;
            listaArtikala.SelectedIndexChanged += listaArtikala_SelectedIndexChanged;
            // 
            // naruciArtikl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listaArtikala);
            Controls.Add(listaKupaca);
            Controls.Add(naruci);
            Controls.Add(nazad);
            Margin = new Padding(3, 4, 3, 4);
            Name = "naruciArtikl";
            Text = "naruciArtikl";
            ResumeLayout(false);
        }

        #endregion

        private Button naruci;
        private Button nazad;
        private ListBox listaKupaca;
        private ListBox listaArtikala;
    }
}