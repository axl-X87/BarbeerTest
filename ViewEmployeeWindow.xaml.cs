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
using Barbeer.BD;

namespace Barbeer
{
    /// <summary>
    /// Логика взаимодействия для ViewEmployeeWindow.xaml
    /// </summary>
    public partial class ViewEmployeeWindow : Window
    {
        Barber br = new Barber();
        public ViewEmployeeWindow()
        {
            InitializeComponent();

            EmployeeLV.ItemsSource = ConBD.beerEN.Barber.ToList();
            

        }

        private void BTMMbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void AddBarberBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNewBarberWindow bw = new AddNewBarberWindow();
            bw.Show();
            this.Close();
        }

        private void ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            ChangeBarberWindow cw = new ChangeBarberWindow((Barber)EmployeeLV.SelectedItem);
            cw.Show();
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            EmployeeLV.SelectedItem = ConBD.beerEN.Barber.Remove((Barber)EmployeeLV.SelectedItem);
            ConBD.beerEN.SaveChanges();
            
        }

        private void AddRecBtn_Click(object sender, RoutedEventArgs e)
        {
            RecordWindow rcrd = new RecordWindow();
            rcrd.Show();
            this.Hide();
        }
    }
}
