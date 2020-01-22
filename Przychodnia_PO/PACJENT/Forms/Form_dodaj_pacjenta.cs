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
       
            if (CzyWypelniony)
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
                return;
            }
            else
            {
                int wiek = 0, nr_telefonu = 0;
                long id;
                bool czyLiczba = long.TryParse(tB_id.Text, out id) && int.TryParse(tB_wiek.Text, out wiek) && int.TryParse(tB_nr_telefonu.Text, out nr_telefonu);
                if (czyLiczba)
                {
                    if (CzyJuzIstnieje(long.Parse(tB_id.Text)))
                    {
                        MessageBox.Show("Pacjent z takim PESELEM już istnieje. Wprowadź poprawne dane.");
                        return;
                    }
                    Form_menu.PacjenciPrzychodni.DodajPacjenta(tB_imie.Text, tB_nazwisko.Text, wiek, id, nr_telefonu);
                    MessageBox.Show("Dodano pacjenta");
                }
                else
                {
                    MessageBox.Show("Zły format danych!");
                    return;
                }
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
