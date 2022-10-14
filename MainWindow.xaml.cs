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
using Barbeer.BD;

namespace Barbeer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddNEbtn_Click(object sender, RoutedEventArgs e)
        {

            AddUserWindow ad = new AddUserWindow();
            ad.ShowDialog();
            this.Hide();

        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginProcess();
        }


        internal void LoginProcess()
        {
            var user = ConBD.beerEN.LP.ToList().Where(i => i.Login == EntryTbx.Text && i.Password == EntryPbx.Password).FirstOrDefault();

            if (user != null)
            {
                ViewEmployeeWindow ad = new ViewEmployeeWindow();
                ad.ShowDialog();
                this.Hide();
            }
            else if (user == null)
            {
                MessageBox.Show("Попробуй снова");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
