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
        public Lokacja(string nazwa)
        {
            InitializeComponent();
            this.Name = nazwa;
            PredatorMasturbator = new Protagonista();
        }
        string path;
        List<Obiekt> obiekty;
        public static Protagonista PredatorMasturbator;
        private void Lokacja_Load(object sender, EventArgs e)
        {
            WczytajObiekty();
        }
        private void WczytajObiekty()
        {
            path = "data/" + this.Name + "/";
            this.BackgroundImage = Image.FromFile(path + "background.png");
            obiekty = new List<Obiekt>();
            string[] dane = File.ReadAllLines(path+"obiekty.txt");
            int i = 0;
            foreach (string linia in dane)
            {
                string[] dane_obiektu = linia.Split(';');
                switch (dane_obiektu[0])
                {
                    case "poj":
                        obiekty.Add(new Pojemnik(dane_obiektu, path));
                        break;
                    case "npc":
                        obiekty.Add(new NPC(dane_obiektu, path));
                        break;
                    case "hand":
                        obiekty.Add(new Handlarz(dane_obiektu, path));
                        break;
                }
                this.Controls.Add(obiekty[i].Panel);
                i++;
                //obiekty nie mogą się nakładać bo wtedy przezroczystość się pierdoli
            }
        }
    }
}
