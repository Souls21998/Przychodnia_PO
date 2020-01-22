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
}
    
