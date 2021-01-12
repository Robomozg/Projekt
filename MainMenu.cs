using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Alfa
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        string[] pliki_data = {"mc.txt", "obiekty.txt" };
        string[] pliki_save = {"mc.txt"};
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (BrakujacePliki("save/", pliki_save)) Kontynuuj.Enabled = false;
            if (BrakujacePliki("data/",pliki_data))NowaGra.Enabled = false;
        }

        private void Wyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NowaGra_Click(object sender, EventArgs e)
        {
            Tworzenie_Postaci tw = new Tworzenie_Postaci();
            this.Hide();
            tw.ShowDialog();
            this.Close();
            //Protagonista mc = new Protagonista();
            //mc.Zapisz();
        }

        private void Kontynuuj_Click(object sender, EventArgs e)
        {
            
        }
        public bool BrakujacePliki(string path, string[] pliki)
        {
            string braki = "";
            bool odp = false;
            foreach (string plik in pliki)
            {
                if (!File.Exists(path + plik))
                {
                    braki += plik + "\n";
                }
            }
            if (braki.Length != 0)
            {
                MessageBox.Show("Wykryto brakujące pliki:\n" + braki);
                odp = true;
            }
            return odp;
        }
    }
}
