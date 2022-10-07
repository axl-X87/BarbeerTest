using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Barbeer.BD;

namespace Barbeer
{
    /// <summary>
    /// Логика взаимодействия для ChangeBarberWindow.xaml
    /// </summary>
    public partial class ChangeBarberWindow : Window
    {
        Barber bar = null;
        public ChangeBarberWindow(Barber barber)
        {
            InitializeComponent();
            DataContext = barber;
            bar = ConBD.beerEN.Barber.Single(x => x.Id == barber.Id);
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewEmployeeWindow viewEmployeeWindow = new ViewEmployeeWindow();
            viewEmployeeWindow.Show();
            this.Close();
        }

        private void ChangePhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var photo in file.FileNames)
                {
                    //barber2.Photo = System.IO.File.ReadAllBytes(photo);
                }
            }
        }

        private void SaveCHangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (bar != null)
            {
                bar.Name = NameTbx.Text;
            }
            ConBD.beerEN.SaveChanges();
        }
    }
}
