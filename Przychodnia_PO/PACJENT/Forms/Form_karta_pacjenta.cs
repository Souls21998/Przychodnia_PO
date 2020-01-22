using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_karta_pacjenta : Form
    {
        public Form_karta_pacjenta()
        {
            InitializeComponent();
        }

        #region PRZYCISKI
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_menu f_menu = new Form_menu();
            f_menu.Show();
            this.Hide();
        }

        private void btn_wyswietl_Click(object sender, EventArgs e)
        {
            listView_lista_wizyt.Items.Clear();

            bool CzyWypelniony = string.IsNullOrEmpty(tB_id_pacjent.Text);
            
            if (CzyWypelniony)
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
                return;
            }
            else
            {
                long pesel = 0;
                bool czyLiczba = long.TryParse(tB_id_pacjent.Text, out pesel);
                if (!czyLiczba || !CzyIstnieje(pesel))
                {
                    MessageBox.Show("Pacjent z takim PESELEM nie istnieje. Wprowadź poprawne dane.");
                    return;
                }
                foreach (var item in Form_menu.PacjenciPrzychodni.lista_pacjentow)
                {
                    if (item.ID == pesel)
                    {
                        label_pacjent.Text = string.Join(" ", item.ToString());
                        listView_lista_wizyt.Items.Clear();
                        foreach (var k in item.WyswietlListeHistoriaPacjenta())
                        {
                            listView_lista_wizyt.Items.Add(k);
                        }
                        if (listView_lista_wizyt.Items.Count == 0)
                            MessageBox.Show("Brak wizyt do wyświetlenia.");
                    }
                }
            }
            
        }
        #endregion

        #region ZDARZENIA
        private void Form_karta_pacjenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region FUNKCJE
        //sprawdza czy pacjent z takim peselem (ID)  istnieje
        private bool CzyIstnieje(long ID)
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
