using System;
using System.Windows.Forms;

namespace Przychodnia_PO
{
    public  partial class Form_menu : Form
    {
        
        internal static ListaPacjentow PacjenciPrzychodni = new ListaPacjentow();
        internal static ListaLekarzy LekarzePrzychodni = new ListaLekarzy();


        public Form_menu()
        {
            InitializeComponent();
            CzyZaladowanoDane();
        }

        #region DANE TESTOWE

        //LEKARZE
        Lekarz lekarz1 = new Lekarz("Alojzy", "Kowalski", 35, 0001, 724044449, Specjalizacja.psychiatra);
        Lekarz lekarz2 = new Lekarz("Paweł", "Gawel", 30, 0002, 721449160, Specjalizacja.kardiolog);
        Lekarz lekarz3 = new Lekarz("Adam", "Woźniak", 47, 0003, 781081453, Specjalizacja.lekarz_rodziny);
        Lekarz lekarz4 = new Lekarz("Klaudia", "Zając", 27, 0004, 696334854, Specjalizacja.neurolog);
        Lekarz lekarz5 = new Lekarz("Ania", "Michalska", 44, 0005, 609797116, Specjalizacja.ortopeda);
        Lekarz lekarz6 = new Lekarz("Magda", "Stępień", 34, 0006, 793734086, Specjalizacja.ginekolog);

        //PACJENCI
        Pacjent pacjent1 = new Pacjent("Wiktor", "Nowicki", 12, 00001, 722076790);
        Pacjent pacjent2 = new Pacjent("Cezary", "Nagórny", 23, 00002, 699142008);
        Pacjent pacjent3 = new Pacjent("Samuel", "Lewandowski", 21, 00003, 723070265);
        Pacjent pacjent4 = new Pacjent("Beniamin", "Jankowski", 14, 00004, 694560394);
        Pacjent pacjent5 = new Pacjent("Jakub", "Piątek", 54, 00005, 796764534);
        Pacjent pacjent6 = new Pacjent("Radosław", "Morawski", 63, 00006, 667089326);
        Pacjent pacjent7 = new Pacjent("Maciej", "Tomczyk", 32, 00007, 790577556);
        Pacjent pacjent8 = new Pacjent("Hubert", "Wierzbicki", 87, 00008, 601798016);
        Pacjent pacjent9 = new Pacjent("Szymon", "Nowak", 33, 00009, 883009475);
        Pacjent pacjent10 = new Pacjent("Natalia", "Pawłowska", 15, 00010, 787210832);
        Pacjent pacjent11 = new Pacjent("Alicja", "Wesołowska", 56, 00011, 608099994);
        Pacjent pacjent12 = new Pacjent("Krystyna", "Kozłowska", 44, 00012, 600285199);
        Pacjent pacjent13 = new Pacjent("Maria", "Przybylska", 11, 00013, 605625953);
        Pacjent pacjent14 = new Pacjent("Wiktoria", "Górska", 57, 00014, 691182483);
        Pacjent pacjent15 = new Pacjent("Anna", "Piasecka", 19, 00015, 665277251);
        Pacjent pacjent16 = new Pacjent("Zofia", "Głowacka", 20, 00016, 507145879);
        Pacjent pacjent17 = new Pacjent("Natalia", "Janicka", 23, 00017, 692753789);
        Pacjent pacjent18 = new Pacjent("Łucja", "Baranowska", 21, 00018, 572842660);

        //WIZYTY
        Wizyta pacjent1_wiz1 = new Wizyta(DateTime.Parse("5 / 1 / 2008 8:30:52 AM"),"konsultacja", "zalamanie nerwowowe", "depresja", "nie ma juz ratunku");
        Wizyta pacjent1_wiz2 = new Wizyta(DateTime.Parse("15 / 1 / 2008 8:30:00 AM"), "terapia", "zalamanie nerwowowe", "depresja", "antydepresanty i Xanax");
        Wizyta pacjent2_wiz1 = new Wizyta(DateTime.Parse("14 / 5 / 2012 10:30:52 AM"), "konsultacja", "zaburzenia osobowości", "osobować mnoga", "elektrowstrząsy");
        Wizyta pacjent3_wiz1 = new Wizyta(DateTime.Parse("22 / 11 / 2015 11:30:52 AM"), "konsultacja", "próba samobójcza", "depresja", "zamkniecie w ośrodku psychiatrycznym");

        Wizyta pacjent4_wiz1 = new Wizyta(DateTime.Parse("12 / 4 / 2009 11:30:52 AM"), "konsultacja", "nadciśnienie", "nadciśnienie tętnicze", "leki");
        Wizyta pacjent5_wiz1 = new Wizyta(DateTime.Parse("13 / 5 / 2018 11:30:52 AM"), "konsultacja", "zawał", "ostry zespół wieńcowy", "by-pass");
        Wizyta pacjent6_wiz1 = new Wizyta(DateTime.Parse("14 / 6 / 2014 12:30:52 AM"), "konsultacja", "nadciśnienie", "nadciśnienie tętnicze", "leki");

        Wizyta pacjent7_wiz1 = new Wizyta(DateTime.Parse("18 / 4 / 2014 12:30:52 AM"), "konsultacja", "kaszel,katar, osłabienie", "grypa", "leki");
        Wizyta pacjent8_wiz1 = new Wizyta(DateTime.Parse("19 / 2 / 2014 12:30:52 AM"), "konsultacja", "ból gardła, gorączka", "zapalenie gardła", "krzesło elektryczne");
        Wizyta pacjent9_wiz1 = new Wizyta(DateTime.Parse("20 / 1 / 2015 12:30:52 AM"), "konsultacja", "ból brzucha, wymioty, gorączka", "zapalenie wyrostka", "skierowanie do szpitala");

        Wizyta pacjent10_wiz1 = new Wizyta(DateTime.Parse("13 / 4 / 2014 12:30:52 AM"), "konsultacja", "uraz głowy", "krwiak", "operacja");
        Wizyta pacjent11_wiz1 = new Wizyta(DateTime.Parse("2 / 3 / 2013 9:30:52 AM"), "konsultacja", "uraz głowy", "krwiak", "operacja");
        Wizyta pacjent12_wiz1 = new Wizyta(DateTime.Parse("5 / 11 / 2019 11:30:52 AM"), "konsultacja", "uraz głowy", "krwiak", "operacja");

        Wizyta pacjent13_wiz1 = new Wizyta(DateTime.Parse("6 / 8 / 2019 12:30:52 AM"), "konsultacja", "ból nadgarstka", "złamanie", "gips");
        Wizyta pacjent14_wiz1 = new Wizyta(DateTime.Parse("7 / 1 / 2012 7:30:52 AM"), "konsultacja", "ból nogi", "złamanie", "czteropak Harnasia");
        Wizyta pacjent15_wiz1 = new Wizyta(DateTime.Parse("11 / 9 / 2011 8:30:52 AM"), "konsultacja", "otwarte złamanie nogi", "złamanie kości piszczelowej z przemieszczeniem", "operacja");

        Wizyta pacjent16_wiz1 = new Wizyta(DateTime.Parse("10 / 12 / 2009 12:30:52 AM"), "badanie kontrolne", "badanie kontrolne", "ok", "brak");
        Wizyta pacjent17_wiz1 = new Wizyta(DateTime.Parse("15 / 11 / 2009 9:30:52 AM"), "badanie kontrolne", "badanie kontrolne", "ok", "brak");
        Wizyta pacjent18_wiz1 = new Wizyta(DateTime.Parse("21 / 1 / 2010 11:30:52 AM"), "badanie kontrolne", "badanie kontrolne", "ok", "brak");

        private void btn_run_test_Click(object sender, EventArgs e)
        {
            //Dodawanie lekarzy
            LekarzePrzychodni.lista_lekarzy.Add(lekarz1);
            LekarzePrzychodni.lista_lekarzy.Add(lekarz2);
            LekarzePrzychodni.lista_lekarzy.Add(lekarz3);
            LekarzePrzychodni.lista_lekarzy.Add(lekarz4);
            LekarzePrzychodni.lista_lekarzy.Add(lekarz5);
            LekarzePrzychodni.lista_lekarzy.Add(lekarz6);

            //Dodawnia pacjentów
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent1);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent2);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent3);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent4);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent5);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent6);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent7);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent8);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent9);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent10);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent11);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent12);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent13);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent14);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent15);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent16);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent17);
            PacjenciPrzychodni.lista_pacjentow.Add(pacjent18);

            //Dodawanie pacjentów do kolejki
            lekarz1.KolejkaDoLekarza.Enqueue(pacjent1);
            lekarz1.KolejkaDoLekarza.Enqueue(pacjent2);
            lekarz1.KolejkaDoLekarza.Enqueue(pacjent3);

            lekarz2.KolejkaDoLekarza.Enqueue(pacjent4);
            lekarz2.KolejkaDoLekarza.Enqueue(pacjent5);
            lekarz2.KolejkaDoLekarza.Enqueue(pacjent6);

            lekarz3.KolejkaDoLekarza.Enqueue(pacjent7);
            lekarz3.KolejkaDoLekarza.Enqueue(pacjent8);
            lekarz3.KolejkaDoLekarza.Enqueue(pacjent9);

            lekarz4.KolejkaDoLekarza.Enqueue(pacjent10);
            lekarz4.KolejkaDoLekarza.Enqueue(pacjent11);
            lekarz4.KolejkaDoLekarza.Enqueue(pacjent12);

            lekarz5.KolejkaDoLekarza.Enqueue(pacjent13);
            lekarz5.KolejkaDoLekarza.Enqueue(pacjent14);
            lekarz5.KolejkaDoLekarza.Enqueue(pacjent15);

            lekarz6.KolejkaDoLekarza.Enqueue(pacjent16);
            lekarz6.KolejkaDoLekarza.Enqueue(pacjent17);
            lekarz6.KolejkaDoLekarza.Enqueue(pacjent18);

            //Dodawanie histori wizyt pacjentów
            pacjent1.HistoriaWizytPacjenta.Add(pacjent1_wiz1);
            pacjent1.HistoriaWizytPacjenta.Add(pacjent1_wiz2);
            pacjent2.HistoriaWizytPacjenta.Add(pacjent2_wiz1);
            pacjent3.HistoriaWizytPacjenta.Add(pacjent3_wiz1);
            pacjent4.HistoriaWizytPacjenta.Add(pacjent4_wiz1);
            pacjent5.HistoriaWizytPacjenta.Add(pacjent5_wiz1);
            pacjent6.HistoriaWizytPacjenta.Add(pacjent6_wiz1);
            pacjent7.HistoriaWizytPacjenta.Add(pacjent7_wiz1);
            pacjent8.HistoriaWizytPacjenta.Add(pacjent8_wiz1);
            pacjent9.HistoriaWizytPacjenta.Add(pacjent9_wiz1);
            pacjent10.HistoriaWizytPacjenta.Add(pacjent10_wiz1);
            pacjent11.HistoriaWizytPacjenta.Add(pacjent11_wiz1);
            pacjent12.HistoriaWizytPacjenta.Add(pacjent12_wiz1);
            pacjent13.HistoriaWizytPacjenta.Add(pacjent13_wiz1);
            pacjent14.HistoriaWizytPacjenta.Add(pacjent14_wiz1);
            pacjent15.HistoriaWizytPacjenta.Add(pacjent15_wiz1);
            pacjent16.HistoriaWizytPacjenta.Add(pacjent16_wiz1);
            pacjent17.HistoriaWizytPacjenta.Add(pacjent17_wiz1);
            pacjent18.HistoriaWizytPacjenta.Add(pacjent18_wiz1);

            btn_run_test.Enabled = false;
        }

        private void CzyZaladowanoDane()
        {
            bool czyZaladowano = PacjenciPrzychodni.lista_pacjentow.Count > 0 && LekarzePrzychodni.lista_lekarzy.Count > 0;
            if (czyZaladowano)
                btn_run_test.Enabled = false;     
        }
        #endregion

        #region PRZYCISKI

        private void btn_przejdz_zarzadzaj_przychodnia_Click(object sender, EventArgs e)
        {
            Form_zarzadzaj_przychodnia f_zarzadzaj_przychodnia = new Form_zarzadzaj_przychodnia();
            f_zarzadzaj_przychodnia.Show();
            this.Hide();

        }
        private void btn_karta_pacjenta_Click(object sender, EventArgs e)
        {
            Form_karta_pacjenta f_karta_pacjenta = new Form_karta_pacjenta();
            f_karta_pacjenta.Show();
            this.Hide();
        }
        private void btn_przejdz_autorzy_Click(object sender, EventArgs e)
        {
            Form_autorzy f_autorzy = new Form_autorzy();
            f_autorzy.Show();
            this.Hide();
        }

        
        private void btn_dane_pacjentow_Click(object sender, EventArgs e)
        {
            Form_karta_pacjenta f_dane_pacjent = new Form_karta_pacjenta();
            f_dane_pacjent.Show();
            this.Hide();
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region ZDARZENIA
        private void Form_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        #endregion

       
    }
}
