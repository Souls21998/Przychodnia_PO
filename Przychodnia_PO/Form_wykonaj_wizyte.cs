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
    public partial class Form_wykonaj_wizyte : Form
    {
        public Form_wykonaj_wizyte()
        {
            InitializeComponent();
            ComboBoxWybierzLekarza();
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_wykonaj_Click(object sender, EventArgs e)
        {
            if (comboBox_wybierz_lekarza != null)
            {
                var id = long.Parse(comboBox_wybierz_lekarza.Text);
                Form_wizyta f_wizyta = new Form_wizyta(id);
                f_wizyta.ShowDialog();
            }
        }

        private void ComboBoxWybierzLekarza()
        {
            foreach (var item in Form_menu.LekarzePrzychodni.lista_lekarzy)
            {
                comboBox_wybierz_lekarza.Items.Add(item.ID);
            }
        }
    }
}
