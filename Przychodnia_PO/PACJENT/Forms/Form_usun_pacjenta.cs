using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_usun_pacjenta : Form
    {
        public Form_usun_pacjenta()
        {
            InitializeComponent();
        }

        #region PRZYCISKI
        private void btn_usun_Click(object sender, EventArgs e)
        {
            bool CzyWypelniony = string.IsNullOrEmpty(tB_id_pacjent.Text);

            if (CzyWypelniony)
            {
                MessageBox.Show("Podaj PESEL!");
                return;
            }
            else
            {
                long pesel;
                bool czyLiczba = long.TryParse(tB_id_pacjent.Text, out pesel);
                if (!czyLiczba || CzyIstnieje(pesel) )
                {
                    MessageBox.Show("Pacjent z takim PESELEM nie istnieje. Wprowadź poprawne dane.");
                    return;
                }
                Form_menu.PacjenciPrzychodni.UsunPacjenta(pesel);
                MessageBox.Show("Usunięto pacjenta!");
            }
            this.Hide();
        }
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion
        #region FUNKCJE
        //sprawdza czy pacjent z takim peselem (ID) juz istnieje
        private bool CzyIstnieje(long ID)
        {
            foreach (var item in Form_menu.PacjenciPrzychodni.lista_pacjentow)
            {
                if (item.ID == ID) return false;
            }
            return true;
        }
        #endregion

    }
}
