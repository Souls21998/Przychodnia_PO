using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_menu());
        }
    }


    // WPROWADZANIE DANYCH TESTOWYCH
    public class Forms : Form
    {
        public Pacjenci pacjenci = new Pacjenci();
        Pacjent pawel = new Pacjent("Paweł", "a", 12, 1222, 111111);
        Wizyta wizytaPawla = new Wizyta(DateTime.MinValue, "kardiologiczna","zalamanie nerwowowe","depresja","nie ma juz ratunku");
        
        public Forms()
        {
              
            pacjenci.DodajPacjenta("Zbigniew", "Stonoga", 49, 1234, 997);
            pacjenci.DodajPacjenta("Tomasz", "Adamek", 13, 2345, 997234);
            pacjenci.UsunPacjenta(2345);
            pacjenci.lista_pacjentow.Add(pawel);

           // pawel.ListaWizyt.Add(wizytaPawla);
        }

    }

}
    
