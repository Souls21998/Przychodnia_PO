using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_pacjent : Form
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
            Form_zarzadzaj_przychodnia f_zarzadzaj_przychodnia = new Form_zarzadzaj_przychodnia();
            this.Hide();
            f_zarzadzaj_przychodnia.Show();
        }

        #endregion



        #region ZDARZENIA
        private void Form_pacjent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion


        #region FUNKCJE
        private void AktualizacjaListView()
        {
            listView_lista_pacjentow.Items.Clear();
            foreach (var item in Form_menu.PacjenciPrzychodni.WyswietlPacjenta())
            {
                listView_lista_pacjentow.Items.Add(item);
            }
        }


        #endregion

       
    }
}
