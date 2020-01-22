using System.Collections.Generic;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public enum Specjalizacja
    {
        lekarz_rodziny, kardiolog, psychiatra, ginekolog, neurolog, ortopeda
    };

    class Lekarz : Osoba
    {
        public Queue<Pacjent> KolejkaDoLekarza = new Queue<Pacjent>();
        public Specjalizacja specjalizacja;
      
        public Lekarz(string imie, string nazwisko, int wiek, long ID, int nr_telefonu, Specjalizacja specjalizacja) : base(imie, nazwisko, wiek, ID, nr_telefonu)
        {
            this.specjalizacja = specjalizacja;
        }

        public override string ToString()
        {
            return $"ID: {this.ID} {this.imie} {this.nazwisko} {this.wiek} lat. Numer telefonu: {this.nr_telefonu}\n Specjalizacja: {this.specjalizacja}";
        }
       

    }
}
