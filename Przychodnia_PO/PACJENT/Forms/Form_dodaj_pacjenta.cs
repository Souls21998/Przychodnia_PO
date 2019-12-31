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
    public partial class Form_dodaj_pacjenta : Forms
    {

        public Form_dodaj_pacjenta()
        {
            InitializeComponent();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            bool CzyWypelniony = String.IsNullOrEmpty(tB_id.Text) || String.IsNullOrEmpty(tB_imie.Text) || String.IsNullOrEmpty(tB_nazwisko.Text) || String.IsNullOrEmpty(tB_wiek.Text) || String.IsNullOrEmpty(tB_nr_telefonu.Text);

            if(CzyWypelniony)
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
            }
            else
            {
                pacjenci.DodajPacjenta(tB_imie.Text, tB_nazwisko.Text, int.Parse(tB_wiek.Text), int.Parse(tB_id.Text), int.Parse(tB_nr_telefonu.Text));
                MessageBox.Show("Dodano pacjenta");
                
                tB_id.Clear();
                tB_imie.Clear();
                tB_nazwisko.Clear();
                tB_wiek.Clear();
                tB_nr_telefonu.Clear();
            }  
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
