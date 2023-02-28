using projekt1.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
namespace projekt1
{
    public partial class ReturnEQ : Window
    {
        public ReturnEQ()
        {
            InitializeComponent();
            List<RentedEQ> RentedEQ = new List<RentedEQ>();
            using (EQDatabase c = new EQDatabase())
            {
                var rent = c.Renting.ToList();
                var Equipment = c.Equipment.Where(b => b.IsRented == true).ToList();
                foreach (var EQ in Equipment)
                {
                    if (EQ != null)
                    {
                        RentedEQ.Add(new RentedEQ
                        {
                            EQID = EQ.Id,
                            PartName = EQ.PartName
                        });
                    }
                }
            }
            comboEQ.ItemsSource = RentedEQ;
        }
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            var EQID = ((RentedEQ)comboEQ.SelectedItem).EQID;
            using (var c = new EQDatabase())
            {
                var equipment = c.Equipment.FirstOrDefault(b => b.Id == EQID);
                equipment.IsRented = false;
                c.SaveChanges();
            }
            this.Close();
        }
    }
}