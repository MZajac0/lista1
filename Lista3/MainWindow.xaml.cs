using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
namespace Lista3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Osoba> lista = new List<Osoba>();
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("C:\\abc.xml"))
            {
                lista = Serializacja.Deserializacja<List<Osoba>>("C:\\abc.xml");
            }
            else
            {
                lista.Add(new Osoba("John", "Doe", "12345678901"));
                lista.Add(new Osoba("Imie", "Nazwisko", "123"));
            }
            show.ItemsSource = lista;
            Application.Current.MainWindow.Closing += new CancelEventHandler(MainWindow_Closing);


        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (show.SelectedItem != null)
            {
                DodajO personAdd = new DodajO();
                Osoba osoba = new Osoba((Osoba)show.SelectedItem);

                personAdd.DataContext = osoba;
                personAdd.ShowDialog();

                if (personAdd.IsOkPressed)
                {
                    int index = lista.IndexOf((Osoba)show.SelectedItem);
                    lista[index] = osoba;
                    show.Items.Refresh();
                }
            }
            else
            {
                DodajO personAdd = new DodajO();
                Osoba osoba = new Osoba();

                personAdd.DataContext = osoba;
                personAdd.ShowDialog();

                if (personAdd.IsOkPressed)
                {
                    lista.Add(osoba);
                    show.Items.Refresh();
                }
            }
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            Serializacja.SerializacjaToXML<List<Osoba>>(lista, "C:\\abc.xml");
        }
    }
}

