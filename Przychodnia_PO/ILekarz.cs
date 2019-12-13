using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_PO
{
    public interface ILekarz
    {
        void DodajLekarza(string imie, string nazwisko, int wiek, int ID, int nr_telefonu, Specjalizacja specjalizacja);
        //void WyswietlDane();
        //void UsunLekarza();
    }
}
