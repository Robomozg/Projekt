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
            panel.BackColor = Color.FromArgb(0, Color.Black);
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
        protected string talkPath;
        protected Rozmowa form;
        public NPC(string[] dane, string path) : base(dane, path)
        {
            talkPath = dane[6];
            panel.Click += this.Rozmawiaj;
        }
        public virtual void Rozmawiaj(object sender, EventArgs e)
        {
            form = new Rozmowa(talkPath, obraz);
            form.Show();
        }
    }
    class Handlarz : NPC
    {
        public Handlarz(string[] dane, string path) : base(dane, path)
        {

        }
        public override void Rozmawiaj(object sender, EventArgs e)
        {
            base.Rozmawiaj(sender,e);
            Button handel = new Button();
            handel.Height = 50;
            handel.Width = 50;
            handel.Location = new Point(50, 50);
            handel.Click += this.Handluj;
            form.Controls.Add(handel);
            form.Show();
        }
        protected void Handluj(object sender, EventArgs e)
        {
            Wymiana wym = new Wymiana(ekwipunek);
            wym.Show();
        }
    }
}
