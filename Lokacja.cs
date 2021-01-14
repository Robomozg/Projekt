using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt_Alfa
{
    public partial class Lokacja : Form
    {
        private static string path;
        List<Obiekt> obiekty;
        public static Protagonista PredatorMasturbator;

        public static string Path { get => path;}

        public Lokacja(string nazwa)
        {
            InitializeComponent();
            this.Name = nazwa;
            path = "data/" + nazwa + "/";
            PredatorMasturbator = new Protagonista();
        }
        private void Lokacja_Load(object sender, EventArgs e)
        {
            WczytajObiekty();
        }
        private void WczytajObiekty()
        {
            this.BackgroundImage = Image.FromFile(path + "background.png");
            obiekty = new List<Obiekt>();
            string[] dane = File.ReadAllLines(path + "obiekty.txt");
            int i = 0;
            foreach (string linia in dane)
            {
                string[] dane_obiektu = linia.Split(';');
                switch (dane_obiektu[0])
                {
                    case "poj":
                        obiekty.Add(new Pojemnik(dane_obiektu));
                        break;
                    case "npc":
                        obiekty.Add(new NPC(dane_obiektu));
                        break;
                    case "hand":
                        obiekty.Add(new Handlarz(dane_obiektu));
                        break;
                }
                this.Controls.Add(obiekty[i].Panel);
                i++;
                //obiekty nie mogą się nakładać bo wtedy przezroczystość się pierdoli
            }
        }
    }
}
