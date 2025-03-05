namespace Színözön
{
    //színözön társasjáték programja, egyénileg kitalált módon
    public partial class Form1 : Form
    {
        //Listák létrehozása, név árulkodó
        List<Véletlengomb> véletlenszínűgombok = new List<Véletlengomb> ();
        List<Tippgomb> tippgombok = new List<Tippgomb> ();

        List<Color> színek = new List<Color> ();
        List<Color> véletlenszínek = new List<Color>();
        List<Color> aktuáltippszínek = new List<Color> ();

        List<ComboBox> kombóboxok = new List<ComboBox> ();

        int tippszám = 0;

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        //kombóbox választott indexe alapján a hozzá tartozó gomb kiszínezése
        void Gombátszínezés(int hányadik)
        {
            int melyikszín = kombóboxok[hányadik].SelectedIndex;
            tippgombok[hányadik].BackColor = színek[melyikszín];
        }

        //találatok ellenőrzése
        void Ellenőrzés()
        {
            int pontos = 0;
            int jószín = 0;

            //változtatható lokális lista a véletlenszínekről
            List<Color> változtathatóvéletlenszínek = new List<Color> ();

            foreach (Color item in véletlenszínek)
            {
                változtathatóvéletlenszínek.Add(item);
            }


            //pontos tippek megszámlálása, egymás melletti gombok azonos színűek -e
            for (int i = 0; i < tippgombok.Count; i++)
            {
                if (tippgombok[i].BackColor == véletlenszínűgombok[i].BackColor)
                {
                    pontos++;
                }
            }

            int j = 0;
            int k = 0;

            //jó színek megszámlálása (jó szín jó vagy rossz helyen)

            //amíg végig nem értünk az aktuális tippek színein
            while (j<5)
            {
                if (aktuáltippszínek[j] == változtathatóvéletlenszínek[k])
                {
                    //favágó módszer, de működik, azért szükséges, hogy a véletlenszíneknél a megfelelő színeket csak egyszer számolja
                    //fuchsia szín nem lehet a tippeknél
                    változtathatóvéletlenszínek[k] = Color.Fuchsia;
                    //ha talált jó színek száma növekedjen
                    jószín++;
                    //véletlenszíneknél induljon újra
                    k = 0;
                    //a tippszíneknél lépjen egyet előre
                    j++;                   
                }
                else
                {
                    //ugorjon a következő véletlenszínre
                    k++;
                }

                //Ha nem talált menjen a következő "tippgomb" színére
                if (k>4)
                {
                    k = 0;
                    j++;
                }
            }

            //Jó színek jó helyen kiírása
            jjszám.Text = pontos.ToString();
            //Jó színek rossz helyen kiírása
            jrszám.Text = (jószín-pontos).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jjszöveg.Text = "Jó szín jó helyen";
            jrszöveg.Text = "Jó szín rossz helyen";

            //kombóbox lista fültöltése mnauálisan kirakott kombóboxokból, fontos a sorrend, az indexek beállítása miatt nezéhkes lett volna kód
            kombóboxok.Add(comboBox1);
            kombóboxok.Add(comboBox2);
            kombóboxok.Add(comboBox3);
            kombóboxok.Add(comboBox4);
            kombóboxok.Add(comboBox5);

            //színek lista feltöltése, a sorrend szükséges, hogy egyezzen a kombóboxoknál az indexekkbe írt színek sorrendjével
            színek.Add(Color.Red);
            színek.Add(Color.Yellow);
            színek.Add(Color.Blue);
            színek.Add(Color.Green);
            színek.Add(Color.Purple);

            for (int i = 1; i < 6; i++)
            {
                //tipp- és véletlenszínűgombok hozzáadása a megfelelő listába és űrlaphoz
                Tippgomb tg = new Tippgomb();
                tg.Left = 200;
                tg.Top = i * 100;
                Controls.Add(tg);
                tippgombok.Add(tg);
                Véletlengomb vg = new Véletlengomb();
                vg.Left = 300;
                vg.Top = i * 100;
                Controls.Add(vg);
                véletlenszínűgombok.Add(vg);
                //véletlenszínű gomb elrejtése
                vg.Visible = false;

                //véletlenszínű gomb kiszínezése
                int színszám = rnd.Next(színek.Count());
                vg.BackColor = színek[színszám];
                véletlenszínek.Add(színek[színszám]);
            }
            
        }

        //tippgombok színezése a mellettük lévő kombóbox alapján, paraméter a tippgomb száma a tippgombok listában
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gombátszínezés(0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gombátszínezés(1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gombátszínezés(2);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gombátszínezés(3);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gombátszínezés(4);
        }

        private void tippelek_Click(object sender, EventArgs e)
        {
            //Ellenőrzés, hogy minden gomb ki van -e színezve
            int betippeltszám = 0;

            foreach (ComboBox cb in kombóboxok)
            {
                if (cb.SelectedIndex>=0)
                {
                    betippeltszám++;
                }
            }

            if (betippeltszám<5)
            {
                return;
            }
            //Ha ki vannak színezve tippszám növelése, kiírása a helyére
            else
            {
                tippszám++;
            }


            tippek.Text = tippszám.ToString();

            //aktuális tippszínek feltöltése
            aktuáltippszínek.Clear();
            foreach (Tippgomb tg in tippgombok)
            {
                aktuáltippszínek.Add(tg.BackColor);
            }

            //ellenőrzés meghívása
            Ellenőrzés();

            //győzelem/vereség vizsgálata
            if (double.Parse(jjszám.Text) == véletlenszínűgombok.Count() && tippszám <= 10)
            {
                foreach (Véletlengomb vg in véletlenszínűgombok) vg.Visible = true;
                MessageBox.Show("Szép munka");
            }

            if (tippszám>10)
            {
                foreach (Véletlengomb vg in véletlenszínűgombok) vg.Visible = true;
                MessageBox.Show("Vesztettél");
            }
        }

    }
}