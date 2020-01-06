using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_harmonogram_wizyt : Form
    {
        public Form_harmonogram_wizyt()
        {
            InitializeComponent();
            ComboBoxWybierzLekarza();
        }

        #region PRZYCISKI
        private void btn_dodaj_wizytę_Click(object sender, EventArgs e)
        {           
            Form_dodaj_wizyte f_dodaj_wizyte = new Form_dodaj_wizyte();
            f_dodaj_wizyte.ShowDialog();
            try
            {
                var lekarzID = long.Parse(comboBox_wybierz_lekarza.SelectedItem.ToString());
                AktualizacjaListView(lekarzID);
            }
            catch
            {
                return;
            }
        }
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_zarzadzaj_przychodnia f_zarzadzaj_przychodnia = new Form_zarzadzaj_przychodnia();
            f_zarzadzaj_przychodnia.Show();
            this.Hide();
        }
        private void btn_wykonaj_wizyte_Click(object sender, EventArgs e)
        {
            Form_wykonaj_wizyte f_wykonaj_wizyte = new Form_wykonaj_wizyte();
            f_wykonaj_wizyte.ShowDialog();
            try
            {
                var lekarzID = long.Parse(comboBox_wybierz_lekarza.SelectedItem.ToString());
                AktualizacjaListView(lekarzID);
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region ZDARZENIA
        private void comboBox_wybierz_lekarza_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lekarzID = long.Parse(comboBox_wybierz_lekarza.SelectedItem.ToString());
            foreach (var item in Form_menu.LekarzePrzychodni.lista_lekarzy)
            {
                if (item.ID == lekarzID)
                    label_dane_lekarza.Text = string.Join(" ", item.ToString());
            }

            AktualizacjaListView(lekarzID);
        }

        private void Form_umów_wizytę_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
        private void AktualizacjaListView(long IDlekarz)
        {
            listView_kolejka_do_lekarza.Items.Clear();

            foreach (var lekarz in Form_menu.LekarzePrzychodni.lista_lekarzy)
            {
                if (lekarz.ID == IDlekarz)
                {
                    foreach (var item in lekarz.KolejkaDoLekarza)
                    {
                        listView_kolejka_do_lekarza.Items.Add(item.WyswieltDanePacjenta());
                    }
                }
            }
        }




        #endregion

        
    }
}