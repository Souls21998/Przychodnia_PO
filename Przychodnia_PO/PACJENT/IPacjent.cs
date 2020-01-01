using System.Collections.Generic;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public interface IPacjent
    {
        void DodajPacjenta(string imie, string nazwisko, int wiek, long ID, int nr_telefonu);
        List<ListViewItem> WyswietlPacjenta();
        void UsunPacjenta(long indeks);
    }
}