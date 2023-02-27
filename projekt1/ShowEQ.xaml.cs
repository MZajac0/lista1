using projekt1.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
namespace projekt1
{
    public partial class ShowEQ : Window
    {
        public ShowEQ()
        {
            InitializeComponent();
            List<Equipment> equipment = new List<Equipment>();
            using (EQDatabase context = new EQDatabase())
            {
                equipment = context.Equipment.ToList();
            }
            EQList.ItemsSource = equipment;
        }
    }
}
