using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public partial class Form_autorzy : Form
    {
        public Form_autorzy()
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
        #endregion

        #region ZDARZENIA
        private void Form_autorzy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
