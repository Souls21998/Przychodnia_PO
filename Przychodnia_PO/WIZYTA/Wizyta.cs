using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    class Wizyta
    {
        public DateTime DataWizyty;
        public string TypPorady;
        public string Dolegliwości;
        public string Choroba;
        public string Zalecenia;

        public Wizyta(DateTime dataWizyty, string typPorady, string dolegliwości, string choroba, string zalecenia)
        {
            DataWizyty = dataWizyty;
            TypPorady = typPorady;
            Dolegliwości = dolegliwości;
            Choroba = choroba;
            Zalecenia = zalecenia;
        }
    }
}
