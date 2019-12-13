using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_PO
{
    class Pacjent : Osoba, IPacjent
    {
        public Pacjent(string imie, string nazwisko, int wiek, int ID, int nr_telefonu): base(imie, nazwisko, wiek, ID, nr_telefonu)
        {
            
        }
       
    }
}
