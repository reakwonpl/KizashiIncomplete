using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kizashi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Subject
        {
            public string NazwaPrzedmiotu { get; set; }
            public int PunktyECTS { get; set; }
            public int IlośćMiejsc { get; set; }
            public int WolneMiejsca { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboKierunek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboKierunek.SelectedIndex == 0)
            {
                ComboSpecjalizacja.Items.Clear();
                ComboSpecjalizacja.Items.Add("Programowanie Gier");
                ComboSpecjalizacja.Items.Add("Bazy Danych");
                ComboSpecjalizacja.Items.Add("Zintegrowane Systemy Informatyczne");

            }
            else if (ComboKierunek.SelectedIndex == 1)
            {
                ComboSpecjalizacja.Items.Clear();
                ComboSpecjalizacja.Items.Add("Inżynieria wiedzy");
                ComboSpecjalizacja.Items.Add("Metody i systemy wspomagania decyzji");

            }
            else if (ComboKierunek.SelectedIndex == 2)
            {
                ComboSpecjalizacja.Items.Clear();
                ComboSpecjalizacja.Items.Add("Dziennikarstwo ekonomiczne i Public Relations");
                ComboSpecjalizacja.Items.Add("Projektowanie komunikacji wizualnej i narracji");


            }

        }

        private void btn_wybierz_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in PW.SelectedItems)
            {
                PZ.Items.Add(item);
                Etykieta.Content = "Pomyślnie Dodano Przedmiot :)";

            }
        }

        private void btn_usun_Click(object sender, RoutedEventArgs e)
        {
            PZ.Items.Remove(PZ.SelectedItem);
            Etykieta.Content = "Pomyślnie Usunięto Przedmiot :)";

        }

        private void btn_zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            if (PZ.SelectedIndex >= 0)
            {
                Etykieta.Content = "Pomyślnie Zatwierdzono Przedmiot :)";

            }
            else
            {
                Etykieta.Content = string.Empty;
            }
        }

        private void btn_przedmioty_Click(object sender, RoutedEventArgs e)
        {
            if (ComboKierunek.SelectedIndex == 0 && ComboSpecjalizacja.SelectedIndex == 0 && ComboSemestr.SelectedIndex == 0)
            {
                InitializeComponent();
                List<Subject> subject = new List<Subject>();
                subject.Add(new Subject() { NazwaPrzedmiotu = "ADMINISTRACJA BAZĄ DANYCH", PunktyECTS = 3, IlośćMiejsc = 100, WolneMiejsca = 100 });
                subject.Add(new Subject() { NazwaPrzedmiotu = "PROGRAMOWANIE APLIKACJI INTERNETOWYCH", PunktyECTS = 6, IlośćMiejsc = 100, WolneMiejsca = 100 });
                subject.Add(new Subject() { NazwaPrzedmiotu = "PROGRAMOWANIE APLIKACJI MOBILNYCH", PunktyECTS = 6, IlośćMiejsc = 100, WolneMiejsca = 100 });
                subject.Add(new Subject() { NazwaPrzedmiotu = "REPORTAŻ PODRÓŻNICZY", PunktyECTS = 3, IlośćMiejsc = 100, WolneMiejsca = 100 });
                PW.ItemsSource = subject;
                PW.SelectionMode = SelectionMode.Multiple;
                PZ.SelectionMode = SelectionMode.Single;
            }
            if (ComboKierunek.SelectedIndex == 0 && ComboSpecjalizacja.SelectedIndex == 1 && ComboSemestr.SelectedIndex == 0)
            {
                InitializeComponent();
                List<Subject> subject = new List<Subject>();
                subject.Add(new Subject() { NazwaPrzedmiotu = "SAP - LOGISTYKA I ZARZĄDZANIE PERSONELEM", PunktyECTS = 3, IlośćMiejsc = 100, WolneMiejsca = 100 });
                subject.Add(new Subject() { NazwaPrzedmiotu = "KSZTAŁTOWANIE RELACJI W KANAŁACH DYSTRYBUCJI", PunktyECTS = 6, IlośćMiejsc = 100, WolneMiejsca = 100 });
                subject.Add(new Subject() { NazwaPrzedmiotu = "SAP - KONFIGURACJA I FINANSE	", PunktyECTS = 6, IlośćMiejsc = 100, WolneMiejsca = 100 });
                subject.Add(new Subject() { NazwaPrzedmiotu = "REPORTAŻ PODRÓŻNICZY", PunktyECTS = 3, IlośćMiejsc = 100, WolneMiejsca = 100 });
                PW.ItemsSource = subject;
                PW.SelectionMode = SelectionMode.Multiple;
                PZ.SelectionMode = SelectionMode.Single;

            }
            if (ComboKierunek.SelectedIndex == 0 && ComboSpecjalizacja.SelectedIndex == 2 && ComboSemestr.SelectedIndex == 0)
            {
                InitializeComponent();
                List<Subject> subject = new List<Subject>();
                subject.Add(new Subject() { NazwaPrzedmiotu = "PROGRAMOWANIE APLIKACJI MOBILNYCH", PunktyECTS = 6, IlośćMiejsc = 100, WolneMiejsca = 100 });
                subject.Add(new Subject() { NazwaPrzedmiotu = "KSZTAŁTOWANIE RELACJI W KANAŁACH DYSTRYBUCJI", PunktyECTS = 6, IlośćMiejsc = 100, WolneMiejsca = 100 });
                subject.Add(new Subject() { NazwaPrzedmiotu = "SAP - KONFIGURACJA I FINANSE	", PunktyECTS = 6, IlośćMiejsc = 100, WolneMiejsca = 100 });
                PW.ItemsSource = subject;
                PW.SelectionMode = SelectionMode.Multiple;
                PZ.SelectionMode = SelectionMode.Single;

            }
        }
    }
}