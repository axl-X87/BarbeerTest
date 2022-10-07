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
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    /// 
   
    public partial class AddUserWindow : Window
    {
        LP lp = new LP();
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void ToMWbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void SaveUserBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNewUser();
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void AddNewUser()
        {
            lp.Login = SaveUserTbx.Text.ToString();
            lp.Password = SaveUserPbx.Password.ToString();
            Context.GetContext().LP.Add(lp);
            Context.GetContext().SaveChanges();
        }
    }
}
