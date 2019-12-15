﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public class Lekarze : ILekarz
    {
        List<Lekarz> lista_lekarzy;

        public Lekarze()
        {
            this.lista_lekarzy = new List<Lekarz>();
        }

        public void DodajLekarza(string imie, string nazwisko, int wiek, int ID, int nr_telefonu, Specjalizacja specjalizacja)
        {
            Lekarz lekarz = new Lekarz(imie, nazwisko, wiek, ID, nr_telefonu, specjalizacja);
            lista_lekarzy.Add(lekarz);
        }

        public List<ListViewItem> WyswietlLekarza()
        {
            var lista = lista_lekarzy;
            List<ListViewItem> lista_elementow = new List<ListViewItem>();
            foreach (var item in lista)
            {
                var row = new string[] { item.ID.ToString(), item.imie.ToString(), item.nazwisko.ToString(), item.nr_telefonu.ToString(), item.specjalizacja.ToString() };
                
                var lvi = new ListViewItem(row);

                lista_elementow.Add(lvi);
            }
            return lista_elementow;
        }

      
        public void UsunLekarza(int indeks)
        {
            foreach (var item in lista_lekarzy.ToList()) //ToList() tworzy migawkę ponieważ lista nie nie moze byc modyfikowana w foreach
            {
                if (item.ID == indeks)
                {
                    lista_lekarzy.RemoveAt(lista_lekarzy.IndexOf(item));
                }
            }
        }
    }
}
