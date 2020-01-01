using System.Collections.Generic;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public interface ILekarz
    {
        void DodajLekarza(string imie, string nazwisko, int wiek, long ID, int nr_telefonu, Specjalizacja specjalizacja);
        List<ListViewItem> WyswietlLekarza();
        void UsunLekarza(long indeks);
    }
}
