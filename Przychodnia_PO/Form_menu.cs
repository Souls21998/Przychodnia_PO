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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void Form_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
