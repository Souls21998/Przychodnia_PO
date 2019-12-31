using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_pacjent : Forms
    {
        
        public Form_pacjent()
        {
            InitializeComponent();
            AktualizacjaListView();
        }

        #region PRZYCISKI
        private void btn_dodaj_pacjenta_Click(object sender, EventArgs e)
        {
            Form_dodaj_pacjenta f_dodaj_pacjenta = new Form_dodaj_pacjenta();
            f_dodaj_pacjenta.ShowDialog();
            AktualizacjaListView();
        }
        private void btn_usun_pacjenta_Click(object sender, EventArgs e)
        {
            Form_usun_pacjenta f_usun_pacjenta = new Form_usun_pacjenta();
            f_usun_pacjenta.ShowDialog();
            AktualizacjaListView();
        }
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_menu f_menu = new Form_menu();
            this.Hide();
            f_menu.Show();
        }

        #endregion



        #region ZDARZENIA
        private void Form_pacjent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion



        #region METODY -- FUNKCJE
        public void AktualizacjaListView()
        {
            listView_lista_pacjentow.Items.Clear();
            foreach (var item in pacjenci.WyswietlPacjenta())
            {

                listView_lista_pacjentow.Items.Add(item);
            }
        }

        #endregion

        
    }
}
