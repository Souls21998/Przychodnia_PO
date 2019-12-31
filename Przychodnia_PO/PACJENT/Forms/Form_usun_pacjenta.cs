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
    public partial class Form_usun_pacjenta : Forms
    {
        public Form_usun_pacjenta()
        {
            InitializeComponent();
        }

        #region PRZYCISKI
        private void btn_usun_Click(object sender, EventArgs e)
        {
            bool CzyWypelniony = string.IsNullOrEmpty(tB_id_pacjent.Text);
            
            if(CzyWypelniony)
            {
                MessageBox.Show("Podaj PESEL!");
            }
            else
            {
                var pesel = int.Parse(tB_id_pacjent.Text);
                pacjenci.UsunPacjenta(pesel);
                this.Hide();
            }
     
        }
        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion


    }
}
