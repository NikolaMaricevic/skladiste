namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            kupac = new Button();
            Narudzbe = new ListBox();
            dodajnarudzbu = new Button();
            urediNarudzbu = new Button();
            izbrisiNarudzbu = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(57, 36);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 47);
            button1.TabIndex = 0;
            button1.Text = "artikl";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kupac
            // 
            kupac.Location = new Point(209, 36);
            kupac.Margin = new Padding(3, 4, 3, 4);
            kupac.Name = "kupac";
            kupac.Size = new Size(120, 47);
            kupac.TabIndex = 1;
            kupac.Text = "kupac";
            kupac.UseVisualStyleBackColor = true;
            kupac.Click += kupac_Click;
            // 
            // Narudzbe
            // 
            Narudzbe.FormattingEnabled = true;
            Narudzbe.ItemHeight = 20;
            Narudzbe.Location = new Point(57, 125);
            Narudzbe.Margin = new Padding(3, 4, 3, 4);
            Narudzbe.Name = "Narudzbe";
            Narudzbe.Size = new Size(499, 404);
            Narudzbe.TabIndex = 2;
            Narudzbe.SelectedIndexChanged += Narudzbe_SelectedIndexChanged;
            // 
            // dodajnarudzbu
            // 
            dodajnarudzbu.Location = new Point(655, 141);
            dodajnarudzbu.Margin = new Padding(3, 4, 3, 4);
            dodajnarudzbu.Name = "dodajnarudzbu";
            dodajnarudzbu.Size = new Size(141, 61);
            dodajnarudzbu.TabIndex = 3;
            dodajnarudzbu.Text = "Dodaj";
            dodajnarudzbu.UseVisualStyleBackColor = true;
            dodajnarudzbu.Click += dodajnarudzbu_Click;
            // 
            // urediNarudzbu
            // 
            urediNarudzbu.Location = new Point(655, 265);
            urediNarudzbu.Margin = new Padding(3, 4, 3, 4);
            urediNarudzbu.Name = "urediNarudzbu";
            urediNarudzbu.Size = new Size(141, 61);
            urediNarudzbu.TabIndex = 4;
            urediNarudzbu.Text = "Uredi";
            urediNarudzbu.UseVisualStyleBackColor = true;
            urediNarudzbu.Click += urediNarudzbu_Click;
            // 
            // izbrisiNarudzbu
            // 
            izbrisiNarudzbu.Location = new Point(655, 379);
            izbrisiNarudzbu.Margin = new Padding(3, 4, 3, 4);
            izbrisiNarudzbu.Name = "izbrisiNarudzbu";
            izbrisiNarudzbu.Size = new Size(141, 61);
            izbrisiNarudzbu.TabIndex = 5;
            izbrisiNarudzbu.Text = "Izbriši";
            izbrisiNarudzbu.UseVisualStyleBackColor = true;
            izbrisiNarudzbu.Click += izbrisiNarudzbu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(izbrisiNarudzbu);
            Controls.Add(urediNarudzbu);
            Controls.Add(dodajnarudzbu);
            Controls.Add(Narudzbe);
            Controls.Add(kupac);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button kupac;
        private ListBox Narudzbe;
        private Button dodajnarudzbu;
        private Button urediNarudzbu;
        private Button izbrisiNarudzbu;
    }
}