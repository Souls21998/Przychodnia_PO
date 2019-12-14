using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_lekarz : Form
    {
        public Lekarze lekarze = new Lekarze();

        public Form_lekarz()
        {
            InitializeComponent();
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_menu f_menu = new Form_menu();
            this.Hide();
            f_menu.Show();
       
        }

        private void Form_lekarz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            lekarze.DodajLekarza("Paweł", "Bronk", 32, 980909, 997, Specjalizacja.ginekolog);
            lekarze.DodajLekarza("Kamil", "Chomej", 27, 980908, 997112, Specjalizacja.kardiolog);
            lekarze.DodajLekarza("Paweł", "Anton", 21, 980912, 76544321, Specjalizacja.psychiatra);
            lekarze.UsunLekarza(980909);
            lekarze.UsunLekarza(980908);

            foreach (var item in lekarze.WyswietlLekarza())
            {
                listView_lista_lekarzy.Items.Add(item);
            }
     
        }    
    }
}
