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
    public partial class Form_pacjent : Form
    {
        public Form_pacjent()
        {
            InitializeComponent();
        }

        private void btn_wstecz_Click(object sender, EventArgs e)
        {
            Form_menu f_menu = new Form_menu();
            this.Hide();
            f_menu.Show();
        }

        private void Form_pacjent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
