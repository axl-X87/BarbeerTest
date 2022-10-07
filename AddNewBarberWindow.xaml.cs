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
using System.Windows.Forms;

namespace Barbeer
{
    /// <summary>
    /// Логика взаимодействия для AddNewBarberWindow.xaml
    /// </summary>
    public partial class AddNewBarberWindow : Window
    {
        Barber bbb = new Barber();
        public AddNewBarberWindow()
        {
            InitializeComponent();
        }

        private void BTMWbtn_Click(object sender, RoutedEventArgs e)
        {
            ViewEmployeeWindow mw = new ViewEmployeeWindow();
            mw.Show();
            this.Close();
        }

        private void SaveBarberBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNewBarber();
        }

        private void AddNewBarber()
        {
            bbb.Name = NameTbx.Text.ToString();
            bbb.Post = PostTbx.Text.ToString();
            bbb.Information = InfoTbx.Text.ToString();
            bbb.Status = Convert.ToInt32(StatusTbx.Text);
            Context.GetContext().Barber.Add(bbb);
            Context.GetContext().SaveChanges();
        }

        private void AddBarberPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file  = new OpenFileDialog();
            file.ShowDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var photo in file.FileNames)
                {
                    bbb.Photo = System.IO.File.ReadAllBytes(photo);
                }
            }
        }
    }
}
