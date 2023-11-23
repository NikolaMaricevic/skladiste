namespace WinFormsApp1
{
    partial class kupci
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
            this.kupciLista = new System.Windows.Forms.ListBox();
            this.izbrisiKupca = new System.Windows.Forms.Button();
            this.urediKupca = new System.Windows.Forms.Button();
            this.dodajkupca = new System.Windows.Forms.Button();
            this.narudzba = new System.Windows.Forms.Button();
            this.artikl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kupciLista
            // 
            this.kupciLista.FormattingEnabled = true;
            this.kupciLista.ItemHeight = 15;
            this.kupciLista.Location = new System.Drawing.Point(51, 104);
            this.kupciLista.Name = "kupciLista";
            this.kupciLista.Size = new System.Drawing.Size(414, 304);
            this.kupciLista.TabIndex = 0;
            // 
            // izbrisiKupca
            // 
            this.izbrisiKupca.Location = new System.Drawing.Point(580, 304);
            this.izbrisiKupca.Name = "izbrisiKupca";
            this.izbrisiKupca.Size = new System.Drawing.Size(123, 46);
            this.izbrisiKupca.TabIndex = 8;
            this.izbrisiKupca.Text = "Izbriši";
            this.izbrisiKupca.UseVisualStyleBackColor = true;
            // 
            // urediKupca
            // 
            this.urediKupca.Location = new System.Drawing.Point(580, 219);
            this.urediKupca.Name = "urediKupca";
            this.urediKupca.Size = new System.Drawing.Size(123, 46);
            this.urediKupca.TabIndex = 7;
            this.urediKupca.Text = "Uredi";
            this.urediKupca.UseVisualStyleBackColor = true;
            // 
            // dodajkupca
            // 
            this.dodajkupca.Location = new System.Drawing.Point(580, 126);
            this.dodajkupca.Name = "dodajkupca";
            this.dodajkupca.Size = new System.Drawing.Size(123, 46);
            this.dodajkupca.TabIndex = 6;
            this.dodajkupca.Text = "Dodaj";
            this.dodajkupca.UseVisualStyleBackColor = true;
            // 
            // narudzba
            // 
            this.narudzba.Location = new System.Drawing.Point(184, 39);
            this.narudzba.Name = "narudzba";
            this.narudzba.Size = new System.Drawing.Size(105, 35);
            this.narudzba.TabIndex = 10;
            this.narudzba.Text = "Narudzba";
            this.narudzba.UseVisualStyleBackColor = true;
            // 
            // artikl
            // 
            this.artikl.Location = new System.Drawing.Point(51, 39);
            this.artikl.Name = "artikl";
            this.artikl.Size = new System.Drawing.Size(105, 35);
            this.artikl.TabIndex = 9;
            this.artikl.Text = "artikl";
            this.artikl.UseVisualStyleBackColor = true;
            // 
            // kupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.narudzba);
            this.Controls.Add(this.artikl);
            this.Controls.Add(this.izbrisiKupca);
            this.Controls.Add(this.urediKupca);
            this.Controls.Add(this.dodajkupca);
            this.Controls.Add(this.kupciLista);
            this.Name = "kupci";
            this.Text = "kupci";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox kupciLista;
        private Button izbrisiKupca;
        private Button urediKupca;
        private Button dodajkupca;
        private Button narudzba;
        private Button artikl;
    }
}