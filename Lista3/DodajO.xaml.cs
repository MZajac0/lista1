using System.Windows;

namespace Lista3
{
    /// <summary>
    /// Interaction logic for Dodaj_Osobe.xaml
    /// </summary>
    public partial class DodajO : Window
    {
        public bool IsOkPressed { get; set; }
        public DodajO()
        {
            InitializeComponent();
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            IsOkPressed = true;
            this.Close();
        }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            IsOkPressed = false;
            this.Close();
        }
    }
}
