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
            this.izbrisiArtikl = new System.Windows.Forms.Button();
            this.urediArtikl = new System.Windows.Forms.Button();
            this.dodajArtikl = new System.Windows.Forms.Button();
            this.Artikli = new System.Windows.Forms.ListBox();
            this.kupac = new System.Windows.Forms.Button();
            this.narudzba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // izbrisiArtikl
            // 
            this.izbrisiArtikl.Location = new System.Drawing.Point(600, 297);
            this.izbrisiArtikl.Name = "izbrisiArtikl";
            this.izbrisiArtikl.Size = new System.Drawing.Size(123, 46);
            this.izbrisiArtikl.TabIndex = 11;
            this.izbrisiArtikl.Text = "Izbriši";
            this.izbrisiArtikl.UseVisualStyleBackColor = true;
            // 
            // urediArtikl
            // 
            this.urediArtikl.Location = new System.Drawing.Point(600, 212);
            this.urediArtikl.Name = "urediArtikl";
            this.urediArtikl.Size = new System.Drawing.Size(123, 46);
            this.urediArtikl.TabIndex = 10;
            this.urediArtikl.Text = "Uredi";
            this.urediArtikl.UseVisualStyleBackColor = true;
            // 
            // dodajArtikl
            // 
            this.dodajArtikl.Location = new System.Drawing.Point(600, 119);
            this.dodajArtikl.Name = "dodajArtikl";
            this.dodajArtikl.Size = new System.Drawing.Size(123, 46);
            this.dodajArtikl.TabIndex = 9;
            this.dodajArtikl.Text = "Dodaj";
            this.dodajArtikl.UseVisualStyleBackColor = true;
            // 
            // Artikli
            // 
            this.Artikli.FormattingEnabled = true;
            this.Artikli.ItemHeight = 15;
            this.Artikli.Location = new System.Drawing.Point(77, 107);
            this.Artikli.Name = "Artikli";
            this.Artikli.Size = new System.Drawing.Size(437, 304);
            this.Artikli.TabIndex = 8;
            // 
            // kupac
            // 
            this.kupac.Location = new System.Drawing.Point(210, 40);
            this.kupac.Name = "kupac";
            this.kupac.Size = new System.Drawing.Size(105, 35);
            this.kupac.TabIndex = 7;
            this.kupac.Text = "kupac";
            this.kupac.UseVisualStyleBackColor = true;
            // 
            // narudzba
            // 
            this.narudzba.Location = new System.Drawing.Point(77, 40);
            this.narudzba.Name = "narudzba";
            this.narudzba.Size = new System.Drawing.Size(105, 35);
            this.narudzba.TabIndex = 6;
            this.narudzba.Text = "Narudžba";
            this.narudzba.UseVisualStyleBackColor = true;
            // 
            // artikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izbrisiArtikl);
            this.Controls.Add(this.urediArtikl);
            this.Controls.Add(this.dodajArtikl);
            this.Controls.Add(this.Artikli);
            this.Controls.Add(this.kupac);
            this.Controls.Add(this.narudzba);
            this.Name = "artikl";
            this.Text = "artikl";
            this.ResumeLayout(false);

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