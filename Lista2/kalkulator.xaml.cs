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
using System.Windows.Shapes;

namespace Lista2
{
    /// <summary>
    /// Logika interakcji dla klasy kalkulator.xaml
    /// </summary>
    public partial class kalkulator : Window
    {
        string znak = "";
        float liczbaDoObliczenia;
        bool moznaObliczac = false, czyJestJuzJakasLiczba = false;
        public kalkulator()
        {
            InitializeComponent();
        }
        private void Liczba(object sender, RoutedEventArgs e)
        {
            string x = obliczenia.Text.ToString() + "";
            Button Btn = (Button)sender;
            if (Btn.Content.ToString() == "," && obliczenia.Text.Contains(','))
                return;
            x = x + Btn.Content.ToString();
            obliczenia.Text = x;
        }
        private void Dzialanie(object sender, RoutedEventArgs e)
        {
            if (obliczenia.Text == "")
                return;
            if (czyJestJuzJakasLiczba && znak != "")
            {
                Obliczanie();
            }
            Button Btn = (Button)sender;
            znak = "" + Btn.Content.ToString();
            moznaObliczac = true;
            liczbaDoObliczenia = float.Parse(obliczenia.Text);
            czyJestJuzJakasLiczba = true;
            obliczenia.Text = "";
        }
        private void Usun(object sender, RoutedEventArgs e)
        {
            moznaObliczac = false;
            czyJestJuzJakasLiczba = false;
            znak = "";
            obliczenia.Text = "";
        }
        private void Oblicz(object sender, RoutedEventArgs e)
        {
            if (!moznaObliczac || obliczenia.Text.ToString() == "")
                return;
            Obliczanie();
            obliczenia.Text = liczbaDoObliczenia.ToString();
            czyJestJuzJakasLiczba = false;
        }
        void Obliczanie()
        {
            switch (znak)
            {
                case "+":
                    obliczenia.Text = (liczbaDoObliczenia + float.Parse(obliczenia.Text)).ToString();
                    liczbaDoObliczenia = float.Parse(obliczenia.Text);
                    break;
                case "-":
                    obliczenia.Text = (liczbaDoObliczenia - float.Parse(obliczenia.Text)).ToString();
                    liczbaDoObliczenia = float.Parse(obliczenia.Text);
                    break;
                case "/":
                    if (obliczenia.Text == "0")
                    {
                        MessageBox.Show("NIE OBLICZĘ");
                        return;
                    }
                    obliczenia.Text = (liczbaDoObliczenia / float.Parse(obliczenia.Text)).ToString();
                    liczbaDoObliczenia = float.Parse(obliczenia.Text);
                    break;
                case "*":
                    obliczenia.Text = (liczbaDoObliczenia * float.Parse(obliczenia.Text)).ToString();
                    liczbaDoObliczenia = float.Parse(obliczenia.Text);
                    break;
            }
        }
    }
}
