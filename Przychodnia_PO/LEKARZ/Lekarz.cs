using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_PO
{
    
    public enum Specjalizacja
    {
        lekarz_rodziny, kardiolog, psychiatra, ginekolog, neurolog, ortopeda
    };

    public  class Lekarz : Osoba
    {
        public Specjalizacja specjalizacja;
      
        public Lekarz(string imie, string nazwisko, int wiek, long ID, int nr_telefonu, Specjalizacja specjalizacja) : base(imie, nazwisko, wiek, ID, nr_telefonu)
        {
            this.specjalizacja = specjalizacja;
        }

    }
}
