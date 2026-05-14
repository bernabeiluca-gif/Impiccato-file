using System.Windows.Forms;

namespace Impiccato_file
{
    public partial class Form1 : Form
    {
        string categoria = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            label2.Text = "Scegli la difficoltà:";

            categoria = "Sport";


            sport.Visible = false;
            animali.Visible = false;
            film.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            label2.Text = "Scegli la difficoltà:";

            categoria = "Animali";

            animali.Visible = false;
            sport.Visible = false;
            film.Visible = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            label2.Text = "Scegli la difficoltà:";

            categoria = "Film";

            film.Visible = false;
            animali.Visible = false;
            sport.Visible = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (categoria == "Sport")
            {

                using(StreamReader sr = new StreamReader("sport_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        string[] pezzi = riga.Split(";");
                    }
                }
            }
        }
    }
}
