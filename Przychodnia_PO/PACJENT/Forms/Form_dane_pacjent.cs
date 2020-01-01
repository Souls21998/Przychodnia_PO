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
    public partial class Form_dane_pacjent : Form
    {
        public Form_dane_pacjent()
        {
            InitializeComponent();
        }

        #region PRZYCISKI
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_menu f_menu = new Form_menu();
            f_menu.Show();
            this.Hide();
        }

        private void btn_wyswietl_Click(object sender, EventArgs e)
        {
            listView_lista_wizyt.Items.Clear();
            var id = int.Parse(tB_id_pacjent.Text);
            foreach (var item in Form_menu.PacjenciPrzychodni.lista_pacjentow)
            {
                if(item.ID == id)
                {
                    label_pacjent.Text = string.Join(" ", item.ToString());
                    listView_lista_wizyt.Items.Clear();
                    foreach (var k in item.WyswietlListeWizyt())
                    {
                        
                        listView_lista_wizyt.Items.Add(k);
                    }
                    if (listView_lista_wizyt.Items.Count == 0)
                        MessageBox.Show("Brak wizyt do wyświetlenia.");
                }
            }
        }
        #endregion

        #region ZDARZENIA

        #endregion

        private void btn_test_Click(object sender, EventArgs e)
        {
            
        }
    }
}
