using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Projekt_Alfa
{
    abstract class Przedmiot
    {
        protected Image obraz;
        protected string image_path;
        protected string nazwa;
        protected int ilosc;
        protected int iloscMAX;
        protected string opis;
        protected string typ;

        public Image Obraz { get => obraz; }
        public string Image_path { get => image_path; protected set => image_path = value; }
        public string Nazwa { get => nazwa; protected set => nazwa = value; }
        public int Ilosc { get => ilosc; protected set => ilosc = value; }
        public int IloscMAX { get => iloscMAX; }
        public string Opis { get => opis; protected set => opis = value; }

        public Przedmiot(string[] vs, string path)
        {
            typ = vs[0];
            image_path = vs[1];
            nazwa = vs[2];
            ilosc = Convert.ToInt32(vs[3]);
            iloscMAX = Convert.ToInt32(vs[4]);
            opis = vs[5];
            obraz = Image.FromFile(path+Image_path);
        }
        public virtual void Zapisz(string path_eq)
        {
            File.AppendAllText(path_eq, $"{typ};{image_path};{nazwa};{ilosc};{iloscMAX};{opis};");
        }
    }
    class Fabularny : Przedmiot
    {
        protected string wlasciciel;
        public string Wlasciciel { get => wlasciciel; protected set => wlasciciel = value; }

        public Fabularny(string[] vs, string path) : base(vs, path)
        {
            wlasciciel = vs[6];
        }

        public override void Zapisz(string path_eq)
        {
            base.Zapisz(path_eq);
            File.AppendAllText(path_eq, $"{wlasciciel}");
        }
    }
   
    class NieFabularny : Przedmiot
    {
        protected int wartosc;
        private double waga;
        public int Wartosc { get => wartosc; protected set => wartosc = value; }
        public double Waga { get => waga; protected set => waga = value; }

        public NieFabularny(string[] vs, string path) : base(vs, path)
        {
            wartosc = Convert.ToInt32(vs[6]);
            waga = Convert.ToDouble(vs[7]);
        }
        public override void Zapisz(string path_eq)
        {
            base.Zapisz(path_eq);
            File.AppendAllText(path_eq, $"{wartosc};{waga}");
        }
    }
    class Jadalny : NieFabularny
    {
        private int zwrotEnergii;
        private int zwrotH2O;
        private int zwrotJedzenia;

        public int ZwrotEnergii { get => zwrotEnergii; protected set => zwrotEnergii = value; }
        public int ZwrotH2O { get => zwrotH2O; protected set => zwrotH2O = value; }
        public int ZwrotJedzenia { get => zwrotJedzenia; protected set => zwrotJedzenia = value; }

        public Jadalny(string[] vs, string path) : base(vs, path)
        {
            zwrotEnergii = Convert.ToInt32(vs[8]);
            zwrotH2O = Convert.ToInt32(vs[9]);
            zwrotJedzenia = Convert.ToInt32(vs[10]);
        }
        public override void Zapisz(string path_eq)
        {
            base.Zapisz(path_eq);
            File.AppendAllText(path_eq, $";{ZwrotEnergii};{zwrotH2O};{zwrotJedzenia}");
        }
    }
    class Narzedzia : NieFabularny
    {
        private int wymaganaSila;
        private int wykorzystanieEnergii;

        public int WymaganaSila { get => wymaganaSila; protected set => wymaganaSila = value; }
        public int WykorzystanieEnergii { get => wykorzystanieEnergii; protected set => wykorzystanieEnergii = value; }

        public Narzedzia(string[] vs, string path) : base(vs, path)
        {
            wymaganaSila = Convert.ToInt32(vs[8]);
            wykorzystanieEnergii = Convert.ToInt32(vs[9]);
        }

        public override void Zapisz(string path_eq)
        {
            base.Zapisz(path_eq);
            File.AppendAllText(path_eq, $";{wymaganaSila};{wykorzystanieEnergii}");
        }
    }
    class Ubrania : NieFabularny
    {
        private int cieplo;
        private int pojemnosc;

        public int Cieplo { get => cieplo; protected set => cieplo = value; }

        public int Pojemnosc { get => pojemnosc; protected set => pojemnosc = value; }

        public Ubrania(string[] vs, string path) : base(vs, path)
        {
            cieplo = Convert.ToInt32(vs[8]);
            pojemnosc = Convert.ToInt32(vs[9]);
        }
        public override void Zapisz(string path_eq)
        {
            base.Zapisz(path_eq);
            File.AppendAllText(path_eq, $";{cieplo};{pojemnosc}");
        }
    }
    class Bronie : NieFabularny
    {
        private int moc;
        private int pojemnoscMagazynku;

        public int Moc { get => moc; protected set => moc = value; }

        public int PojemnoscMagazynku { get => pojemnoscMagazynku; protected set => pojemnoscMagazynku = value; }

        public Bronie(string[] vs, string path) : base(vs, path)
        {
            moc = Convert.ToInt32(vs[8]);
            pojemnoscMagazynku = Convert.ToInt32(vs[9]);
        }
        public override void Zapisz(string path_eq)
        {
            base.Zapisz(path_eq);
            File.AppendAllText(path_eq, $";{moc};{pojemnoscMagazynku}");
        }
    }
}
