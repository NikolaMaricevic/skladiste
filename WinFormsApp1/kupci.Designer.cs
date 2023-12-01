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
            kupciLista = new ListBox();
            izbrisiKupca = new Button();
            urediKupca = new Button();
            dodajkupca = new Button();
            narudzba = new Button();
            artikl = new Button();
            SuspendLayout();
            // 
            // kupciLista
            // 
            kupciLista.FormattingEnabled = true;
            kupciLista.ItemHeight = 20;
            kupciLista.Location = new Point(58, 139);
            kupciLista.Margin = new Padding(3, 4, 3, 4);
            kupciLista.Name = "kupciLista";
            kupciLista.Size = new Size(473, 404);
            kupciLista.TabIndex = 0;
            kupciLista.SelectedIndexChanged += kupciLista_SelectedIndexChanged;
            // 
            // izbrisiKupca
            // 
            izbrisiKupca.Location = new Point(663, 405);
            izbrisiKupca.Margin = new Padding(3, 4, 3, 4);
            izbrisiKupca.Name = "izbrisiKupca";
            izbrisiKupca.Size = new Size(141, 61);
            izbrisiKupca.TabIndex = 8;
            izbrisiKupca.Text = "Izbriši";
            izbrisiKupca.UseVisualStyleBackColor = true;
            izbrisiKupca.Click += izbrisiKupca_Click;
            // 
            // urediKupca
            // 
            urediKupca.Location = new Point(663, 292);
            urediKupca.Margin = new Padding(3, 4, 3, 4);
            urediKupca.Name = "urediKupca";
            urediKupca.Size = new Size(141, 61);
            urediKupca.TabIndex = 7;
            urediKupca.Text = "Uredi";
            urediKupca.UseVisualStyleBackColor = true;
            urediKupca.Click += urediKupca_Click;
            // 
            // dodajkupca
            // 
            dodajkupca.Location = new Point(663, 168);
            dodajkupca.Margin = new Padding(3, 4, 3, 4);
            dodajkupca.Name = "dodajkupca";
            dodajkupca.Size = new Size(141, 61);
            dodajkupca.TabIndex = 6;
            dodajkupca.Text = "Dodaj";
            dodajkupca.UseVisualStyleBackColor = true;
            dodajkupca.Click += dodajkupca_Click;
            // 
            // narudzba
            // 
            narudzba.Location = new Point(210, 52);
            narudzba.Margin = new Padding(3, 4, 3, 4);
            narudzba.Name = "narudzba";
            narudzba.Size = new Size(120, 47);
            narudzba.TabIndex = 10;
            narudzba.Text = "Narudzba";
            narudzba.UseVisualStyleBackColor = true;
            narudzba.Click += narudzba_Click;
            // 
            // artikl
            // 
            artikl.Location = new Point(58, 52);
            artikl.Margin = new Padding(3, 4, 3, 4);
            artikl.Name = "artikl";
            artikl.Size = new Size(120, 47);
            artikl.TabIndex = 9;
            artikl.Text = "artikl";
            artikl.UseVisualStyleBackColor = true;
            artikl.Click += artikl_Click;
            // 
            // kupci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(narudzba);
            Controls.Add(artikl);
            Controls.Add(izbrisiKupca);
            Controls.Add(urediKupca);
            Controls.Add(dodajkupca);
            Controls.Add(kupciLista);
            Margin = new Padding(3, 4, 3, 4);
            Name = "kupci";
            Text = "kupci";
            ResumeLayout(false);
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