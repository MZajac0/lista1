using projekt1.Entities;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace projekt1
{
    public partial class RentEQ : Window
    {
        public RentEQ()
        {
            InitializeComponent();
            var c = new EQDatabase();
            comboCSTMR.ItemsSource = c.Customers.ToList();
            comboEQ.ItemsSource = c.Equipment.ToList();
        }
        private void Rent_Click(object sender, RoutedEventArgs e)
        {
            Renting renting = new Renting();

            renting.CustomerId = ((Customer)comboCSTMR.SelectedValue).Id;
            renting.EQID = ((Equipment)comboEQ.SelectedValue).Id;

            var c = new EQDatabase();

            var EQ = c.Equipment.FirstOrDefault(b => b.Id == renting.EQID);

            if (EQ != null && !EQ.IsRented)
            {
                EQ.IsRented = true;
                c.Renting.Add(renting);
                c.SaveChanges();
            }
            else
            {
                MessageBox.Show("nie ma tego sprzętu");
            }
        }
    }
}
