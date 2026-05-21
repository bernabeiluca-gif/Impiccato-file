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
        int tentativi = 6;
        bool letteratrovata = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void cambio()
        {
            label2.Text = "Scegli la difficoltà:";




            sport.Visible = false;
            animali.Visible = false;
            film.Visible = false;
        }
        private void inserimento()
        {
            letteratrovata = false;
            for (int i = 0; i < parola.Length; i++)
            {
                if (parola[i] == lettera)
                {
                    tratti[i] = lettera;
                    letteratrovata = true;
                }

            }
            label4.Text = new string(tratti);

            if (letteratrovata == false)
            {
                tentativi--;
                label6.Text="Tentativi:" + tentativi;
                if (tentativi <= 0)
                {
                    label3.Text = "HAI PERSO!";
                    label5.Text = "La parola era: " + parolaScelta;
                    return;
                }
                
            }
            else if (!label4.Text.Contains('-'))
            {
                label3.Text = "COMPLIMENTI HAI VINTO!";
            }

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
            categoria = "Sport";
            cambio();
            tentativi = 6;
        }

        private void button29_Click(object sender, EventArgs e)
        {


            categoria = "Animali";
            cambio();
            tentativi = 6;
        }

        private void button30_Click(object sender, EventArgs e)
        {


            categoria = "Film";
            cambio();
            tentativi=6;
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

                tratti = new char[parola.Length];
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


        //Lettere

        private void button1_Click(object sender, EventArgs e)
        {
            lettera = 'a';
            inserimento();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lettera = 'b';
            inserimento();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lettera = 'c';
            inserimento();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lettera = 'd';
            inserimento();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lettera = 'e';
            inserimento();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lettera = 'f';
            inserimento();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lettera = 'g';
            inserimento();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lettera = 'h';
            inserimento();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lettera = 'i';
            inserimento();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lettera = 'j';
            inserimento();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lettera = 'k';
            inserimento();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lettera = 'l';
            inserimento();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lettera = 'm';
            inserimento();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lettera = 'n';
            inserimento();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lettera = 'o';
            inserimento();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lettera = 'p';
            inserimento();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lettera = 'q';
            inserimento();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lettera = 'r';
            inserimento();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lettera = 's';
            inserimento();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            lettera = 't';
            inserimento();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lettera = 'u';
            inserimento();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            lettera = 'v';
            inserimento();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            lettera = 'w';
            inserimento();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            lettera = 'x';
            inserimento();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lettera = 'y';
            inserimento();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            lettera = 'z';
            inserimento();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
