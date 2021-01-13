using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Projekt_Alfa
{
    class Ekwipunek
    {
        List<Przedmiot> lista = new List<Przedmiot>();
        public Ekwipunek(string path_eq)
        {
            string[] dane = File.ReadAllLines(path_eq);
            string imagePath = path_eq.Remove(path_eq.LastIndexOf('/'));
            imagePath += "/";
            foreach(string linia in dane)
            {
                string[] dane_przed = linia.Split(';');
                switch (dane_przed[0])
                {
                    case "fab":
                        lista.Add(new Fabularny(dane_przed, imagePath));
                        break;
                    case "nfab":
                        lista.Add(new NieFabularny(dane_przed, imagePath));
                        break;
                    case "jedz":
                        lista.Add(new Jadalny(dane_przed, imagePath));
                        break;
                } 
            }
        }
        public void Zapisz(string path_eq)
        {
            File.WriteAllText(path_eq, String.Empty);
            foreach (Przedmiot przed in lista)
            {
                przed.Zapisz(path_eq);
                File.AppendAllText(path_eq, Environment.NewLine);
            }
        }
        public void Wyswietl()
        {
            
        }
    }
}
