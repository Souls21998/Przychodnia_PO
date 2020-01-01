using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_dodaj_pacjenta : Form
    {

        public Form_dodaj_pacjenta()
        {
            InitializeComponent();
        }

        #region PRZYCISKI
        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            bool CzyWypelniony = String.IsNullOrEmpty(tB_id.Text) || String.IsNullOrEmpty(tB_imie.Text) || String.IsNullOrEmpty(tB_nazwisko.Text) || String.IsNullOrEmpty(tB_wiek.Text) || String.IsNullOrEmpty(tB_nr_telefonu.Text);

            if (CzyJuzIstnieje(long.Parse(tB_id.Text)))
            {
                MessageBox.Show("Pacjent z takim PESELEM już istnieje. Wprowadź poprawne dane.");
                return;
            }
            else
            {
                if (CzyWypelniony)
                {
                    MessageBox.Show("Wypełnij wszystkie pola!");
                    return;
                }
                Form_menu.PacjenciPrzychodni.DodajPacjenta(tB_imie.Text, tB_nazwisko.Text, int.Parse(tB_wiek.Text), long.Parse(tB_id.Text), int.Parse(tB_nr_telefonu.Text));
                MessageBox.Show("Dodano pacjenta");
            }
            this.Hide();
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region ZDARZENIA
        private void Form_dodaj_pacjenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region FUNKCJE
        //sprawdza czy pacjent z takim peselem (ID) juz istnieje
        private bool CzyJuzIstnieje(long ID)
        {  
            foreach (var item in Form_menu.PacjenciPrzychodni.lista_pacjentow)
            {
                if (item.ID == ID) return true;
            }
            return false;
        }
        #endregion

        
    }
}
