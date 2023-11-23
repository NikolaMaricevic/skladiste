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
            this.artikl = new System.Windows.Forms.Button();
            this.kupac = new System.Windows.Forms.Button();
            this.Narudzbe = new System.Windows.Forms.ListBox();
            this.dodajnarudzbu = new System.Windows.Forms.Button();
            this.urediNarudzbu = new System.Windows.Forms.Button();
            this.izbrisiNarudzbu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // artikl
            // 
            this.artikl.Location = new System.Drawing.Point(50, 27);
            this.artikl.Name = "artikl";
            this.artikl.Size = new System.Drawing.Size(105, 35);
            this.artikl.TabIndex = 0;
            this.artikl.Text = "artikl";
            this.artikl.UseVisualStyleBackColor = true;
            this.artikl.Click += new System.EventHandler(this.button1_Click);
            // 
            // kupac
            // 
            this.kupac.Location = new System.Drawing.Point(183, 27);
            this.kupac.Name = "kupac";
            this.kupac.Size = new System.Drawing.Size(105, 35);
            this.kupac.TabIndex = 1;
            this.kupac.Text = "kupac";
            this.kupac.UseVisualStyleBackColor = true;
            // 
            // Narudzbe
            // 
            this.Narudzbe.FormattingEnabled = true;
            this.Narudzbe.ItemHeight = 15;
            this.Narudzbe.Location = new System.Drawing.Point(50, 94);
            this.Narudzbe.Name = "Narudzbe";
            this.Narudzbe.Size = new System.Drawing.Size(437, 304);
            this.Narudzbe.TabIndex = 2;
            // 
            // dodajnarudzbu
            // 
            this.dodajnarudzbu.Location = new System.Drawing.Point(573, 106);
            this.dodajnarudzbu.Name = "dodajnarudzbu";
            this.dodajnarudzbu.Size = new System.Drawing.Size(123, 46);
            this.dodajnarudzbu.TabIndex = 3;
            this.dodajnarudzbu.Text = "Dodaj";
            this.dodajnarudzbu.UseVisualStyleBackColor = true;
            // 
            // urediNarudzbu
            // 
            this.urediNarudzbu.Location = new System.Drawing.Point(573, 199);
            this.urediNarudzbu.Name = "urediNarudzbu";
            this.urediNarudzbu.Size = new System.Drawing.Size(123, 46);
            this.urediNarudzbu.TabIndex = 4;
            this.urediNarudzbu.Text = "Uredi";
            this.urediNarudzbu.UseVisualStyleBackColor = true;
            // 
            // izbrisiNarudzbu
            // 
            this.izbrisiNarudzbu.Location = new System.Drawing.Point(573, 284);
            this.izbrisiNarudzbu.Name = "izbrisiNarudzbu";
            this.izbrisiNarudzbu.Size = new System.Drawing.Size(123, 46);
            this.izbrisiNarudzbu.TabIndex = 5;
            this.izbrisiNarudzbu.Text = "Izbriši";
            this.izbrisiNarudzbu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izbrisiNarudzbu);
            this.Controls.Add(this.urediNarudzbu);
            this.Controls.Add(this.dodajnarudzbu);
            this.Controls.Add(this.Narudzbe);
            this.Controls.Add(this.kupac);
            this.Controls.Add(this.artikl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button artikl;
        private Button kupac;
        private ListBox Narudzbe;
        private Button dodajnarudzbu;
        private Button urediNarudzbu;
        private Button izbrisiNarudzbu;
    }
}