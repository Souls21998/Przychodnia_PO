using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public class ListaPacjentow : IListaPacjentow
    {
        internal List<Pacjent> lista_pacjentow;

        public ListaPacjentow()
        {
            this.lista_pacjentow = new List<Pacjent>(); 
        }

        public void DodajPacjenta(string imie, string nazwisko, int wiek, long ID, int nr_telefonu)
        {
            Pacjent pacjent = new Pacjent(imie, nazwisko, wiek, ID, nr_telefonu);
            lista_pacjentow.Add(pacjent);
            
        }

        public List<ListViewItem> WyswietlPacjenta()
        {
            var lista = lista_pacjentow;
            List<ListViewItem> lista_elementow = new List<ListViewItem>();
            foreach (var item in lista)
            {
                var row = new string[] { item.ID.ToString(), item.imie.ToString(), item.nazwisko.ToString(), item.wiek.ToString(), item.nr_telefonu.ToString()};

                var lvi = new ListViewItem(row);

                lista_elementow.Add(lvi);
            }
            return lista_elementow;
        }

        public void UsunPacjenta(long indeks)
        {
            foreach (var item in lista_pacjentow.ToList()) 
            {
                if (item.ID == indeks)
                {
                    lista_pacjentow.RemoveAt(lista_pacjentow.IndexOf(item));
                }
            }
        }
    }
}

