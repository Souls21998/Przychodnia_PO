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
    public partial class Form_usun_lekarza : Form
    {
        public Form_usun_lekarza()
        {
            InitializeComponent();
        }

        #region PRZYCISKI
        private void btn_usun_Click(object sender, EventArgs e)
        {
            bool CzyWypelniony = string.IsNullOrEmpty(tB_id_lekarz.Text);

            if (CzyWypelniony)
            {
                MessageBox.Show("Podaj ID!");
                return;
            }
            else
            {
                long id;
                bool czyLiczba = long.TryParse(tB_id_lekarz.Text, out id);
                if (!czyLiczba || CzyIstnieje(id))
                {
                    MessageBox.Show("Lekarz z takim ID nie istnieje. Wprowadź poprawne dane.");
                    return;
                }
                Form_menu.LekarzePrzychodni.UsunLekarza(id);
                MessageBox.Show("Usunięto lekarza!");
            }
            this.Hide();
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region ZDARZENIA
        private void Form_usun_lekarza_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        #endregion
        #region FUNKCJE
        //sprawdza czy pacjent z takim peselem (ID) juz istnieje
        private bool CzyIstnieje(long ID)
        {
            foreach (var item in Form_menu.LekarzePrzychodni.lista_lekarzy)
            {
                if (item.ID == ID) return false;
            }
            return true;
        }
        #endregion
    }
}
