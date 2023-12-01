namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new listaartikala().Show();
        }

        private void kupac_Click(object sender, EventArgs e)
        {
            new kupci().Show();
        }

        private void Narudzbe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajnarudzbu_Click(object sender, EventArgs e)
        {
            new naruciArtikl().Show();
        }

        private void urediNarudzbu_Click(object sender, EventArgs e)
        {

        }

        private void izbrisiNarudzbu_Click(object sender, EventArgs e)
        {

        }
    }
}