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
}
