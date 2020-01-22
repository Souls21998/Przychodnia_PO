using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_dodaj_wizyte : Form
    {
        public Form_dodaj_wizyte()
        {
            InitializeComponent();
            ComboBoxWybierzLekarza();
        }

        #region PRZYCISKI
        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            bool CzyWypelniony = String.IsNullOrEmpty(tB_id_pacjenta.Text) || comboBox_wybierz_lekarza.SelectedItem == null;

            if (CzyWypelniony)
            {
                MessageBox.Show("Wypełnij formularz!");
                return;
            }
            else
            {
               long pesel = 0;
               var lekarzID = long.Parse(comboBox_wybierz_lekarza.SelectedItem.ToString());
               bool czyLiczba = long.TryParse(tB_id_pacjenta.Text, out pesel);

               Pacjent PacjentDoRejestracji = null;

                if (czyLiczba && CzyPacjentIstnieje(pesel))
                {
                    foreach (var item in Form_menu.PacjenciPrzychodni.lista_pacjentow)
                    {
                        if (item.ID == pesel)
                        {
                            PacjentDoRejestracji = item;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pacjent z takim PESELEM nie figuruje w naszej bazie.\n Zarejestruj się w naszej przychodni.");
                    return;

                }
                if (CzyLekarzIstnieje(lekarzID))
                {
                    foreach (var item in Form_menu.LekarzePrzychodni.lista_lekarzy)
                    {
                        if (item.ID == lekarzID)
                        {
                            item.KolejkaDoLekarza.Enqueue(PacjentDoRejestracji);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lekarz z takim ID nie istnieje.");
                    return;
                }  
            }
            MessageBox.Show("Dodano nową wizytę.");
            this.Hide();
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region ZDARZENIA

        #endregion

        #region FUNKCJE
        private void ComboBoxWybierzLekarza()
        {
            foreach (var item in Form_menu.LekarzePrzychodni.lista_lekarzy)
            {
                comboBox_wybierz_lekarza.Items.Add(item.ID);
            }
        }
        private bool CzyLekarzIstnieje(long _IDlekarza)
        {
            foreach (var item in Form_menu.LekarzePrzychodni.lista_lekarzy)
            {
                if (_IDlekarza == item.ID)
                    return true;
            }
            return false;
        }
        private bool CzyPacjentIstnieje(long _pesel)
        {
            foreach (var item in Form_menu.PacjenciPrzychodni.lista_pacjentow)
            {
                if (_pesel == item.ID)
                    return true;
            }
            return false;
        }
        #endregion


    }
}
