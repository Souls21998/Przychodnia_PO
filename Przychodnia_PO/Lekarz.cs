using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_PO
{
    class Lekarz : Osoba, ILekarz
    {
        Specjalizacja specjalizacja;
        int nr_gabinetu;

        public Lekarz(string imie, string nazwisko, int wiek, int ID, int nr_telefonu, Specjalizacja specjalizacja, int nr_gabinetu) : base(imie, nazwisko, wiek, ID, nr_telefonu)
        {
         
            this.specjalizacja = specjalizacja;
            this.nr_gabinetu = nr_gabinetu;
        }
    }

    enum Specjalizacja{
        lekarz_rodziny, kardiolog, psychiatra, ginekolog, neurolog, ortopeda
    };
}
