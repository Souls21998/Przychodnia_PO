using System.Collections.Generic;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public interface ILekarz
    {
        void DodajLekarza(string imie, string nazwisko, int wiek, int ID, int nr_telefonu, Specjalizacja specjalizacja);
        List<ListViewItem> WyswietlLekarza();
        void UsunLekarza(int indeks);
    }
}
