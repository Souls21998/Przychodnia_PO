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
    public partial class Form_dodaj_pacjenta : Form
    {
        
        public Form_dodaj_pacjenta()
        {
            InitializeComponent();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            Form_pacjent.pacjenci.DodajPacjenta(tB_imie.Text, tB_nazwisko.Text, int.Parse(tB_wiek.Text), int.Parse(tB_id.Text), int.Parse(tB_nr_telefonu.Text));
            MessageBox.Show("Dodano pacjenta");
            tB_id.Text = "";
            tB_imie.Text = "";
            tB_nazwisko.Text = "";
            tB_wiek.Text = "";
            tB_nr_telefonu.Text = "";
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
