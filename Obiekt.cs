using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Projekt_Alfa
{
    abstract class Obiekt
    {
        protected string typ;
        protected string nazwa;
        protected string imagePath;
        protected Image obraz;
        protected Ekwipunek ekwipunek;
        protected Panel panel;

        public string Typ { get => typ; }
        public string Nazwa { get => nazwa; }
        internal Ekwipunek Ekwipunek { get => ekwipunek; }
        public Panel Panel => panel;

        public Obiekt(string[] dane, string path)
        {
            typ = dane[0];
            nazwa = dane[1];
            imagePath = dane[2];
            obraz = Image.FromFile(path+dane[2]);
            panel = new Panel();
            panel.Location = new Point(Convert.ToInt32(dane[3]), Convert.ToInt32(dane[4]));
            if (dane[5] != "") ekwipunek = new Ekwipunek(path+dane[5]);
            panel.BackgroundImage = obraz;
            panel.Height = obraz.Height;
            panel.Width = obraz.Width;
        }
    }
    class Pojemnik : Obiekt
    {
        public Pojemnik(string[] dane, string path) : base(dane, path)
        {
            panel.Click += this.Wymiana;
        }
        public void Wymiana(object sender, EventArgs e)
        {

        }
    }
    class NPC : Obiekt
    {
        string talkPath;
        public NPC(string[] dane, string path) : base(dane, path)
        {
            panel.Click += this.Rozmowa;
        }
        public void Rozmowa(object sender, EventArgs e)
        {

        }
    }
}
