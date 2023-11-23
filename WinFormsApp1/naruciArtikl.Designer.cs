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
            this.naruci = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.broj = new System.Windows.Forms.TextBox();
            this.adresa = new System.Windows.Forms.TextBox();
            this.nazivArtikla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // naruci
            // 
            this.naruci.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.naruci.Location = new System.Drawing.Point(511, 302);
            this.naruci.Name = "naruci";
            this.naruci.Size = new System.Drawing.Size(191, 94);
            this.naruci.TabIndex = 9;
            this.naruci.Text = "Naruči";
            this.naruci.UseVisualStyleBackColor = true;
            // 
            // nazad
            // 
            this.nazad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazad.Location = new System.Drawing.Point(112, 302);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(191, 94);
            this.nazad.TabIndex = 8;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            // 
            // broj
            // 
            this.broj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.broj.Location = new System.Drawing.Point(99, 132);
            this.broj.Name = "broj";
            this.broj.Size = new System.Drawing.Size(327, 23);
            this.broj.TabIndex = 7;
            this.broj.Text = "koliko želiš naručiti";
            // 
            // adresa
            // 
            this.adresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresa.Location = new System.Drawing.Point(99, 213);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(327, 23);
            this.adresa.TabIndex = 6;
            this.adresa.Text = "Unesi adresu";
            // 
            // nazivArtikla
            // 
            this.nazivArtikla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazivArtikla.Location = new System.Drawing.Point(99, 55);
            this.nazivArtikla.Name = "nazivArtikla";
            this.nazivArtikla.Size = new System.Drawing.Size(327, 23);
            this.nazivArtikla.TabIndex = 5;
            this.nazivArtikla.Text = "Naziv Artikla";
            // 
            // naruciArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naruci);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.broj);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.nazivArtikla);
            this.Name = "naruciArtikl";
            this.Text = "naruciArtikl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button naruci;
        private Button nazad;
        private TextBox broj;
        private TextBox adresa;
        private TextBox nazivArtikla;
    }
}