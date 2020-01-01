using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_lekarz : Form
    {

        public Form_lekarz()
        {
            InitializeComponent();
            AktualizacjaListView();
        }

        #region PRZYCISKI
        private void btn_dodaj_lekarza_Click(object sender, EventArgs e)
        {
            Form_dodaj_lekarza f_dodaj_lekarza = new Form_dodaj_lekarza();
            f_dodaj_lekarza.ShowDialog();
            AktualizacjaListView();
        }
        private void btn_usun_lekarza_Click(object sender, EventArgs e)
        {
            Form_usun_lekarza f_usun_lekarza = new Form_usun_lekarza();
            f_usun_lekarza.ShowDialog();
            AktualizacjaListView();
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_zarzadzaj_przychodnia f_zarzadzaj_przychodnia = new Form_zarzadzaj_przychodnia();
            f_zarzadzaj_przychodnia.Show();
            this.Hide();
        }
        #endregion

        #region ZDARZENIA
        private void Form_lekarz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        
        #region FUNKCJE
        private void AktualizacjaListView()
        {
            listView_lista_lekarzy.Items.Clear();
            foreach (var item in Form_menu.LekarzePrzychodni.WyswietlLekarza())
            {
                listView_lista_lekarzy.Items.Add(item);
            }
        }


        #endregion
    }
}
