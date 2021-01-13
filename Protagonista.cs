using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Alfa
{
    class Protagonista
    {
        Ekwipunek eq;
        List<Profit> profity;
        public Protagonista()
        {
            eq = new Ekwipunek("data/mc_eq.txt");
        }
        public void Zapisz()
        {
            eq.Zapisz("save/mc_eq.txt");
        }
    }
    public class Profit
    {
        string nazwa;
        int wartosc;
        string opis;
        public Profit(string nazwa, int wartosc, string opis)
        {
            this.nazwa = nazwa;
            this.wartosc = wartosc;
            this.opis = opis;
        }
    }
    public class Wiedza
    {
        string nazwa;
        int poziom;
        string opis;
        public Wiedza(string nazwa, int poziom, string opis)
        {
            this.nazwa = nazwa;
            this.poziom = poziom;
            this.opis = opis;
        }
        public string Nazwa { get => nazwa; protected set => nazwa = value; }

        public int Poziom { get => poziom; 
       
            protected set 
            {
                if (value <= 100) poziom = value;
            }
        }
        public string Opis { get => opis; protected set => opis = value; }
    }
}
