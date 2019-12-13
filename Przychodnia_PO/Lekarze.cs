using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_PO
{
    public class Lekarze : ILekarz
    {
        public List<Lekarz> lista_lekarzy;

        public Lekarze()
        {
            this.lista_lekarzy = new List<Lekarz>();
        }
       
        public void DodajLekarza(string imie, string nazwisko, int wiek, int ID, int nr_telefonu, Specjalizacja specjalizacja)
        {
            string _imie = imie;
            string _nazwisko = nazwisko;
            int _wiek = wiek;
            int _ID = ID;
            int _nr_telefonu = nr_telefonu;
            Specjalizacja _specjalizacja = specjalizacja;
            Lekarz lekarz = new Lekarz(_imie, _nazwisko, _wiek, _ID, _nr_telefonu, _specjalizacja);
            lista_lekarzy.Add(lekarz);
        }
    }
}
