﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    internal class Pacjent : Osoba
    {
        public List<Wizyta> HistoriaWizytPacjenta = new List<Wizyta>();

        public Pacjent(string imie, string nazwisko, int wiek, long ID, int nr_telefonu) : base(imie, nazwisko, wiek, ID, nr_telefonu)
        {
        }

        public List<ListViewItem> WyswietlListeHistoriaPacjenta()
        {
            var lista = HistoriaWizytPacjenta;
            List<ListViewItem> lista_elementow = new List<ListViewItem>();
            foreach (var item in lista)
            {
                var row = new string[] { item.DataWizyty.ToString(), item.TypPorady.ToString(), item.Dolegliwości.ToString(), item.Choroba.ToString(), item.Zalecenia.ToString() };

                var lvi = new ListViewItem(row);

                lista_elementow.Add(lvi);
            }
            return lista_elementow;
        }

        public ListViewItem WyswieltDanePacjenta()
        {
            var row = new string[] { this.ID.ToString(), this.imie.ToString(), this.nazwisko.ToString(), this.nr_telefonu.ToString() };
            var lvi = new ListViewItem(row);
            return lvi;
        }

        public override string ToString()
        {
            return ($"PESEL: {this.ID}. {this.imie} {this.nazwisko}, {this.wiek} lat. Numer kontaktowy: {this.nr_telefonu}");
        }
    }
}