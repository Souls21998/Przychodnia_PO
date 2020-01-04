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
        long id;
        int i;
        public Form_wizyta(long id)
        {
            InitializeComponent();
            this.id = id;
            for(i = 0;i < Form_menu.LekarzePrzychodni.lista_lekarzy.Count;i++)
            {
                if(id == Form_menu.LekarzePrzychodni.lista_lekarzy[i].ID)
                {
                    break;
                }
            }
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_koniec_wizyty_Click(object sender, EventArgs e)
        {
            bool CzyWypelniony = String.IsNullOrEmpty(dateTimePicker_data_wizyty.Text) || String.IsNullOrEmpty(tB_typ_porady.Text) || String.IsNullOrEmpty(tB_dolegliwosci.Text) || String.IsNullOrEmpty(tB_choroba.Text) || String.IsNullOrEmpty(tB_zalecenia.Text);
            if (CzyWypelniony)
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
                return;
            }
            else
            {
                Wizyta wizyta = new Wizyta(DateTime.Parse(dateTimePicker_data_wizyty.Text), tB_typ_porady.Text, tB_dolegliwosci.Text, tB_choroba.Text, tB_zalecenia.Text);
                Form_menu.LekarzePrzychodni.lista_lekarzy[i].KolejkaDoLekarza.Peek().HistoriaWizytPacjenta.Add(wizyta);
                MessageBox.Show("Przeprowadzono wizytę!");
            }
            this.Hide();
            Form_menu.LekarzePrzychodni.lista_lekarzy[i].KolejkaDoLekarza.Dequeue();
        }
    }
}
