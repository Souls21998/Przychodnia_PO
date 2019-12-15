using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_pacjent : Form
    {
        public static Pacjenci pacjenci = new Pacjenci();
        public Form_pacjent()
        {
            InitializeComponent();
            pacjenci.DodajPacjenta("Zbigniew", "Stonoga", 49, 1234, 997);
            pacjenci.DodajPacjenta("Tomasz", "Adamek", 13, 2345, 997234);
            pacjenci.UsunPacjenta(2345);
            AktualizacjaListView();
        }
        private void AktualizacjaListView()
        {
            foreach (var item in pacjenci.WyswietlPacjenta())
            {
                listView_lista_pacjentow.Items.Add(item);
            }
        }
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_menu f_menu = new Form_menu();
            this.Hide();
            f_menu.Show();
        }

        private void Form_pacjent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_dodaj_pacjenta_Click(object sender, EventArgs e)
        {
            Form_dodaj_pacjenta f_dodaj_pacjenta = new Form_dodaj_pacjenta();
            f_dodaj_pacjenta.Show();
        }

        private void btn_aktualizuj_list_view_Click(object sender, EventArgs e)
        {
            listView_lista_pacjentow.Items.Clear();
            AktualizacjaListView();
        }
    }
}
