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
            ime = new TextBox();
            oib = new TextBox();
            prezime = new TextBox();
            nazad = new Button();
            Dodaj = new Button();
            SuspendLayout();
            // 
            // ime
            // 
            ime.Location = new Point(91, 69);
            ime.Margin = new Padding(3, 4, 3, 4);
            ime.Name = "ime";
            ime.Size = new Size(373, 27);
            ime.TabIndex = 0;
            ime.Text = "Unesi ime";
            ime.TextChanged += ime_TextChanged;
            // 
            // oib
            // 
            oib.Location = new Point(91, 280);
            oib.Margin = new Padding(3, 4, 3, 4);
            oib.Name = "oib";
            oib.Size = new Size(373, 27);
            oib.TabIndex = 1;
            oib.Text = "Unesi OIB";
            oib.TextChanged += oib_TextChanged;
            // 
            // prezime
            // 
            prezime.Location = new Point(91, 172);
            prezime.Margin = new Padding(3, 4, 3, 4);
            prezime.Name = "prezime";
            prezime.Size = new Size(373, 27);
            prezime.TabIndex = 2;
            prezime.Text = "Unesi prezime";
            prezime.TextChanged += prezime_TextChanged;
            // 
            // nazad
            // 
            nazad.Location = new Point(106, 399);
            nazad.Margin = new Padding(3, 4, 3, 4);
            nazad.Name = "nazad";
            nazad.Size = new Size(218, 125);
            nazad.TabIndex = 3;
            nazad.Text = "Nazad";
            nazad.UseVisualStyleBackColor = true;
            nazad.Click += nazad_Click;
            // 
            // Dodaj
            // 
            Dodaj.Location = new Point(562, 399);
            Dodaj.Margin = new Padding(3, 4, 3, 4);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(218, 125);
            Dodaj.TabIndex = 4;
            Dodaj.Text = "Dodaj";
            Dodaj.UseVisualStyleBackColor = true;
            Dodaj.Click += Dodaj_Click;
            // 
            // dodajKupca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Dodaj);
            Controls.Add(nazad);
            Controls.Add(prezime);
            Controls.Add(oib);
            Controls.Add(ime);
            Margin = new Padding(3, 4, 3, 4);
            Name = "dodajKupca";
            Text = "dodajKupca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ime;
        private TextBox oib;
        private TextBox prezime;
        private Button nazad;
        private Button Dodaj;
    }
}