using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_PO
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int wiek;
        protected int ID;
        protected int nr_telefonu;

        public Osoba(string imie, string nazwisko, int wiek, int ID, int nr_telefonu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.ID = ID;
            this.nr_telefonu = nr_telefonu;
        }
    }
}
