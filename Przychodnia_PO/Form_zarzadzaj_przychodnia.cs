using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_zarzadzaj_przychodnia : Form
    {
        public Form_zarzadzaj_przychodnia()
        {
            InitializeComponent();
        }

        #region PRZYCISKI
        private void btn_przejdz_pacjent_Click(object sender, EventArgs e)
        {
            Form_pacjent f_pacjent = new Form_pacjent();
            this.Hide();
            f_pacjent.Show();
        }

        private void btn_przejdz_lekarz_Click(object sender, EventArgs e)
        {
            Form_lekarz f_lekarz = new Form_lekarz();
            this.Hide();
            f_lekarz.Show();
        }
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_menu f_menu = new Form_menu();
            f_menu.Show();
            this.Hide();
        }
        #endregion

        #region ZDARZENIA
        private void Form_zarzadzaj_przychodnia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void btn_harmonogram_wizyt_Click(object sender, EventArgs e)
        {
            Form_harmonogram_wizyt f_harmonogram_wizyt = new Form_harmonogram_wizyt();
            f_harmonogram_wizyt.Show();
            this.Hide();
        }
    }
}
