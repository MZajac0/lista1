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
    /// Interaction logic for kolko_i_krzyzyk.xaml
    /// </summary>
    public partial class kolko_i_krzyzyk : Window
    {
        public kolko_i_krzyzyk()
        {
            InitializeComponent();
        }
        int Gracz = 0;
        int zaj_pola = 0;
        string gr1 = "x";
        string gr2 = "o";
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button Btn = (Button)sender;
            if (Btn.Content.ToString() == "")
            {
                zaj_pola = zaj_pola + 1;
                if (Gracz == 0)
                    Btn.Content = gr1;
                else if (Gracz == 1)
                    Btn.Content = gr2;
                Gracz = (Gracz + 1) % 2;
                if (B0.Content.ToString() + B1.Content.ToString() + B2.Content.ToString() == "xxx" || B3.Content.ToString() + B4.Content.ToString() + B5.Content.ToString() == "xxx" || B6.Content.ToString() + B7.Content.ToString() + B8.Content.ToString() == "xxx" ||
                B0.Content.ToString() + B3.Content.ToString() + B6.Content.ToString() == "xxx" || B1.Content.ToString() + B4.Content.ToString() + B7.Content.ToString() == "xxx" || B2.Content.ToString() + B5.Content.ToString() + B8.Content.ToString() == "xxx" ||
                B0.Content.ToString() + B4.Content.ToString() + B8.Content.ToString() == "xxx" || B2.Content.ToString() + B4.Content.ToString() + B6.Content.ToString() == "xxx")
                {
                    nazwa_Gracza.Content = "Wygrywa Gracz x";
                    B0.IsEnabled = false;
                    B1.IsEnabled = false;
                    B2.IsEnabled = false;
                    B3.IsEnabled = false;
                    B4.IsEnabled = false;
                    B5.IsEnabled = false;
                    B6.IsEnabled = false;
                    B7.IsEnabled = false;
                    B8.IsEnabled = false;
                }
                else if (B0.Content.ToString() + B1.Content.ToString() + B3.Content.ToString() == "ooo" || B3.Content.ToString() + B4.Content.ToString() + B5.Content.ToString() == "ooo" || B6.Content.ToString() + B7.Content.ToString() + B8.Content.ToString() == "ooo" ||
                B0.Content.ToString() + B3.Content.ToString() + B6.Content.ToString() == "ooo" || B1.Content.ToString() + B4.Content.ToString() + B7.Content.ToString() == "ooo" || B2.Content.ToString() + B5.Content.ToString() + B8.Content.ToString() == "ooo" ||
                B0.Content.ToString() + B4.Content.ToString() + B8.Content.ToString() == "ooo" || B2.Content.ToString() + B4.Content.ToString() + B6.Content.ToString() == "ooo")
                {
                    nazwa_Gracza.Content = "Wygrywa Gracz o";
                    B0.IsEnabled = false;
                    B1.IsEnabled = false;
                    B2.IsEnabled = false;
                    B3.IsEnabled = false;
                    B4.IsEnabled = false;
                    B5.IsEnabled = false;
                    B6.IsEnabled = false;
                    B7.IsEnabled = false;
                    B8.IsEnabled = false;
                }
                else if (zaj_pola == 9)
                {
                    nazwa_Gracza.Content = "Remis";
                    B0.IsEnabled = false;
                    B1.IsEnabled = false;
                    B2.IsEnabled = false;
                    B3.IsEnabled = false;
                    B4.IsEnabled = false;
                    B5.IsEnabled = false;
                    B6.IsEnabled = false;
                    B7.IsEnabled = false;
                    B8.IsEnabled = false;
                }
            }
        }
        private void FunkcjaRestart(object sender, RoutedEventArgs e)
        {
            zaj_pola = 0;
            B0.Content = "";
            B1.Content = "";
            B2.Content = "";
            B3.Content = "";
            B4.Content = "";
            B5.Content = "";
            B6.Content = "";
            B7.Content = "";
            B8.Content = "";
            nazwa_Gracza.Content = "Gracz x";
            Gracz = 0;
            B0.IsEnabled = true;
            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            B4.IsEnabled = true;
            B5.IsEnabled = true;
            B6.IsEnabled = true;
            B7.IsEnabled = true;
            B8.IsEnabled = true;
        }
    }
}