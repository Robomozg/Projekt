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
    public partial class Tworzenie_Postaci : Form
    {
        public Tworzenie_Postaci()
        {
            InitializeComponent();
        }
        Profit[] prof;
        private void Tworzenie_Postaci_Load(object sender, EventArgs e)
        {
            panel_mc.BackgroundImage = Image.FromFile("data/mc_def.png");

            string[] dane = File.ReadAllLines("data/tworzenie_profity.txt");
            prof = new Profit[dane.Length];
            int i = 0;
            foreach (string linia in dane)
            {
                string[] dane_prof = linia.Split(';');
                prof[i] = new Profit(dane_prof[0], Convert.ToInt32(dane_prof[0]), dane_prof[2]);
            }
            past.Items.AddRange(prof);
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.ShowDialog();
            this.Close();
        }
    }
    
}
