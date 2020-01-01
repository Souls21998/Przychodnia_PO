using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_PO
{
    public abstract class Osoba
    {
        public string imie;
        public string nazwisko;
        public int wiek;
        public long  ID;
        public int nr_telefonu;

        protected Osoba(string imie, string nazwisko, int wiek, long ID, int nr_telefonu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.ID = ID;
            this.nr_telefonu = nr_telefonu;
        }

        //public abstract void PrzedstawSie()
    }
}
