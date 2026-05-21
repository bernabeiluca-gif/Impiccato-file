using System.Windows.Forms;

namespace Impiccato_file
{
    public partial class Form1 : Form
    {
        string categoria = "";
        string parolaScelta = "";
        char[] tratti;
        char[] parola;
        char lettera;
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

        private void button34_Click(object sender, EventArgs e) //Difficoltà difficile
        {
            if (categoria == "Sport")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("sport_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[2];

                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();
                tratti = new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-';
                }
                label4.Text = new string(tratti);
            }
            else if (categoria == "Animali")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("animali_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[2];

                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();
                tratti = new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-'; 
                }
                label4.Text = new string(tratti);
            }
            else if (categoria == "Film")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("film_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[2];


                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();
                tratti = new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-';
                }
                label4.Text = new string(tratti);
            }
        }

        private void button27_Click(object sender, EventArgs e) //Difficoltà facile
        {
            if (categoria == "Sport")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("sport_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[0];

                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();
                tratti = new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-';
                }
                label4.Text = new string(tratti);
            }
            else if (categoria == "Animali")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("animali_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[0];

                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();
                tratti = new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-';
                }
                label4.Text = new string(tratti);
            }
            else if (categoria == "Film")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("film_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[0];

                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();
                tratti = new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-';
                }
                label4.Text = new string(tratti);

            }
        }


        private void button33_Click(object sender, EventArgs e) //Difficoltà media
        {
            if (categoria == "Sport")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("sport_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[1];

                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();
                tratti = new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-';
                }
                label4.Text = new string(tratti);
            }
            else if (categoria == "Animali")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("animali_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[1];

                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();
                tratti = new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-';
                }
                label4.Text = new string(tratti);

            }
            else if (categoria == "Film")
            {
                Random random = new Random();
                int indexScelto = random.Next(1, 6);
                int posizioneriga = 0;

                using (StreamReader sr = new StreamReader("film_classificati.csv"))
                {
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        if (posizioneriga == indexScelto)
                        {
                            string[] pezzi = riga.Split(',');
                            parolaScelta = pezzi[1];

                        }
                        posizioneriga++;
                        riga = sr.ReadLine();
                    }
                }
                parola = parolaScelta.ToCharArray();

                tratti=new char[parola.Length];
                for (int i = 0; i < parola.Length; i++)
                {
                    tratti[i] = '-';
                }
                label4.Text = new string(tratti);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lettera = 'a';
            for(int i = 0; i < parola.Length; i++)
            {
                if(parola[i] == lettera)
                {
                    tratti[i] = lettera;
                }
                
            }
            label4.Text = new string(tratti);
        }
    }
}
