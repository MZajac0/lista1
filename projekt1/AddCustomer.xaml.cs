using projekt1.Entities;
using System.Windows;
namespace projekt1
{
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private void AddThem(object sender, RoutedEventArgs e)
        {
            Customer cstmr = new Customer();
            cstmr.Name = NameBox.Text;
            cstmr.Surname = SurnameBox.Text;
            cstmr.PhoneNumber = PhoneBox.Text;
            var dbContext = new EQDatabase();
            dbContext.Customers.Add(cstmr);
            dbContext.SaveChanges();
        }
    }
}