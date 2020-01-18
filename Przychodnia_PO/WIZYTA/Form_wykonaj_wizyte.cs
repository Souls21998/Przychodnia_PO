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

        #region PRZYCISKI
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_wykonaj_Click(object sender, EventArgs e)
        {
            bool czyWybrano = (comboBox_wybierz_lekarza.Text == "");
            if (czyWybrano)
            {
                MessageBox.Show("Wybierz ID lekarza");
                
            }
            else
            {
                var id = long.Parse(comboBox_wybierz_lekarza.Text);
                int i;

                for (i = 0; i < Form_menu.LekarzePrzychodni.lista_lekarzy.Count; i++) //szukanie lekarza z danym ID
                {
                    if (id == Form_menu.LekarzePrzychodni.lista_lekarzy[i].ID)
                    {
                        break;
                    }
                }

                bool czyPusta = (Form_menu.LekarzePrzychodni.lista_lekarzy[i].KolejkaDoLekarza.Count == 0); //sprawdzanie czy kolejka do lekarza jest pusta
                
                if (czyPusta)
                {
                    MessageBox.Show("Kolejka do tego lekarza jest pusta");
                }
                else
                {
                    Form_wizyta f_wizyta = new Form_wizyta(id);
                    f_wizyta.ShowDialog();
                    this.Hide();
                }
            }
        }
        #endregion

        #region FUNKCJE
        private void ComboBoxWybierzLekarza()
        {
            foreach (var item in Form_menu.LekarzePrzychodni.lista_lekarzy)
            {
                comboBox_wybierz_lekarza.Items.Add(item.ID);
            }
        }
        #endregion


    }
}
