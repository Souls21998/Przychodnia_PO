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
    public partial class Form_wizyta : Form
    {
        int i;
        public Form_wizyta(long id)
        {
            InitializeComponent();
            ZaladujDane(id);
            
        }
        #region PRZYCISKI
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_koniec_wizyty_Click(object sender, EventArgs e)
        {
            bool CzyWypelniony = String.IsNullOrEmpty(tB_typ_porady.Text) || String.IsNullOrEmpty(tB_dolegliwosci.Text) || String.IsNullOrEmpty(tB_choroba.Text) || String.IsNullOrEmpty(tB_zalecenia.Text);
            if (CzyWypelniony)
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
                return;
            }
            else
            {
                DateTime now = DateTime.Now;
                Wizyta wizyta = new Wizyta(now, tB_typ_porady.Text, tB_dolegliwosci.Text, tB_choroba.Text, tB_zalecenia.Text);
                Form_menu.LekarzePrzychodni.lista_lekarzy[i].KolejkaDoLekarza.Peek().HistoriaWizytPacjenta.Add(wizyta); //dodanie wizyty do karty pacjenta
                MessageBox.Show("Przeprowadzono wizytę!");
            }
            this.Hide();
            Form_menu.LekarzePrzychodni.lista_lekarzy[i].KolejkaDoLekarza.Dequeue(); //usunięcie pierwszej osoby z kolejki
        }
        #endregion

        #region FUNKCJE
        void ZaladujDane(long id)
        {
            for (i = 0; i < Form_menu.LekarzePrzychodni.lista_lekarzy.Count; i++) //szukanie lekarza z danym ID
            {
                if (id == Form_menu.LekarzePrzychodni.lista_lekarzy[i].ID)
                {
                    break;
                }
            }
            label_pacjent.Text = Form_menu.LekarzePrzychodni.lista_lekarzy[i].KolejkaDoLekarza.Peek().ToString(); //podstawowe dane o pacjencie
            listView_lista_wizyt.Items.Clear();
            foreach (var k in Form_menu.LekarzePrzychodni.lista_lekarzy[i].KolejkaDoLekarza.Peek().WyswietlListeHistoriaPacjenta()) //karta pacjenta
            {
                listView_lista_wizyt.Items.Add(k);
            }
        }
        #endregion

    }
}
