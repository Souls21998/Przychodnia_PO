using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public  partial class Form_menu : Form
    {
        
        internal static ListaPacjentow PacjenciPrzychodni = new ListaPacjentow();
        internal static ListaLekarzy LekarzePrzychodni = new ListaLekarzy();


        public Form_menu()
        {
            InitializeComponent();
            CzyZaladowanoDane();
        }

        #region DANE TESTOWE


        Pacjent pawel = new Pacjent("Paweł", "a", 12, 1222, 111111);
        Wizyta wizytaPawla = new Wizyta(DateTime.MinValue, "kardiologiczna", "zalamanie nerwowowe", "depresja", "nie ma juz ratunku");
        Lekarz lekarz1 = new Lekarz("Alojzy", "Kowalski", 29, 22111, 997123321, Specjalizacja.ginekolog);


        private void btn_run_test_Click(object sender, EventArgs e)
        {
            PacjenciPrzychodni.DodajPacjenta("Zbigniew", "Stonoga", 49, 12345678, 997);
            PacjenciPrzychodni.DodajPacjenta("Tomasz", "Adamek", 13, 2345, 997234);
            // pacjenci.UsunPacjenta(2345);
            LekarzePrzychodni.lista_lekarzy.Add(lekarz1);

            PacjenciPrzychodni.lista_pacjentow.Add(pawel);
            pawel.HistoriaWizytPacjenta.Add(wizytaPawla);

            btn_run_test.Enabled = false;
        }

        private void CzyZaladowanoDane()
        {
            bool czyZaladowano = PacjenciPrzychodni.lista_pacjentow.Count > 0 && LekarzePrzychodni.lista_lekarzy.Count > 0;
            if (czyZaladowano)
                btn_run_test.Enabled = false;
        }
        #endregion

        #region PRZYCISKI

        private void btn_przejdz_zarzadzaj_przychodnia_Click(object sender, EventArgs e)
        {
            Form_zarzadzaj_przychodnia f_zarzadzaj_przychodnia = new Form_zarzadzaj_przychodnia();
            f_zarzadzaj_przychodnia.Show();
            this.Hide();

        }
        private void btn_karta_pacjenta_Click(object sender, EventArgs e)
        {
            Form_karta_pacjenta f_karta_pacjenta = new Form_karta_pacjenta();
            f_karta_pacjenta.Show();
            this.Hide();
        }
        private void btn_przejdz_autorzy_Click(object sender, EventArgs e)
        {
            Form_autorzy f_autorzy = new Form_autorzy();
            f_autorzy.Show();
            this.Hide();
        }

        
        private void btn_dane_pacjentow_Click(object sender, EventArgs e)
        {
            Form_karta_pacjenta f_dane_pacjent = new Form_karta_pacjenta();
            f_dane_pacjent.Show();
            this.Hide();
        }
        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region ZDARZENIA
        private void Form_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        #endregion

        
    }
}
