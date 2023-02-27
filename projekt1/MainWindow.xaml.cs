using System;
using System.Data.SqlClient;
using System.Windows;
namespace projekt1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ConnectClick(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=LAPTOP-E0VUJMJ1\\MSSQLSERVER2;Initial Catalog = SkiDB; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
        private void ShowCustomersClick(object sender, RoutedEventArgs e)
        {
            AddCustomer AddC = new AddCustomer();
            AddC.Show();
        }
        private void ShowEQClick(object sender, RoutedEventArgs e)
        {
            ShowEQ showEQ = new ShowEQ();
            showEQ.Show();
        }
        private void ReturnEQClick(object sender, RoutedEventArgs e)
        {
            ReturnEQ returnEQ = new ReturnEQ();
            returnEQ.Show();
        }
        private void RentEQClick(object sender, RoutedEventArgs e)
        {
            RentEQ rentEQ = new RentEQ();
            rentEQ.Show();
        }
    }
}
