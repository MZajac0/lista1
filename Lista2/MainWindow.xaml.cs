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

namespace Lista2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //kalkulator----------------------------------------------------------------------------------------------------------------------------
        public int x; //1-dodawanie, 2-odejmowanie, 3-mnozenie, 4-dzielenie
        public float y, z; //y-1, x-2
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button Btn = (Button)sender;
            Kalkulacje.Text += Btn.Tag;
            Kalkulacje.Focus();
        }
        private void Funkcja(object sender, RoutedEventArgs e)
        {
            Button Btn = (Button)sender;
            if (y.ToString() != null)
            {
                y = float.Parse(Kalkulacje.Text);
                string w = "";
                w += Btn.Tag;
                if (w == "+")
                    x = 1;
                else if (w == "-")
                    x = 2;
                else if (w == "*")
                    x = 3;
                else if (w == "/")
                    x = 4;
                y = float.Parse(Kalkulacje.Text);
                Kalkulacje.Text = "";
            }
            else MessageBox.Show("podaj liczbe");
            Kalkulacje.Focus();
        }
        private void Wyczysc(object sender, RoutedEventArgs e)
        {
            Button Btn = (Button)sender;
            Kalkulacje.Text = "";
            y = 0;
            x = 0;
            z = 0;
            Kalkulacje.Focus();
        }
        private void Oblicz(object sender, RoutedEventArgs e)
        {
            z = float.Parse(Kalkulacje.Text);
            if (x == 1)
                Kalkulacje.Text = (y + z).ToString();
            else if (x == 2)
                Kalkulacje.Text = (y - z).ToString();
            else if (x == 4)
            {
                if (z != 0)
                    Kalkulacje.Text = (y / z).ToString();
                else
                {
                    MessageBox.Show("nie mozna dzielic przez zero bo to niemozliwe i jest tu za duzo tekstu");
                    return;
                };
            }
            else if (x == 3)
                Kalkulacje.Text = (y * z).ToString();
            Kalkulacje.Focus();
        }
        private void Checkif0(object sender, RoutedEventArgs e)
        {
            Kalkulacje.Focus();
            Button Btn = (Button)sender;
            if (Kalkulacje.Text != "")
            {
                Kalkulacje.Text += Btn.Tag;
            }
            else return;
        }
        //kalkulator----------------------------------------------------------------------------------------------------------------------------

        
    }
}


