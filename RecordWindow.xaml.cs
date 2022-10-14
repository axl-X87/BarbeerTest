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
    /// Логика взаимодействия для RecordWindow.xaml
    /// </summary>
    public partial class RecordWindow : Window
    {
        public RecordWindow()
        {
            InitializeComponent();
            CheckRecLV.ItemsSource = ConBD.beerEN.Record.ToList();
            ServiceCmbx.ItemsSource = ConBD.beerEN.Service.ToList();
            BarberCmbx.ItemsSource = ConBD.beerEN.Barber.ToList();
            ClinetCmbx.ItemsSource = ConBD.beerEN.Client.ToList();
        }

        private void AddRecordtoBDBtn_Click(object sender, RoutedEventArgs e)
        {
            Record rec = new Record();

            rec.ServiceId = ((Service)ServiceCmbx.SelectedItem).Id;
            rec.BarberId = ((Barber)BarberCmbx.SelectedItem).Id;
            rec.ClientId = ((Client)ClinetCmbx.SelectedItem).Id;
            rec.DateAndTime = (DateTime)DateForDB.SelectedDate;
            rec.Comment = CommentTbx.Text;


            ConBD.beerEN.Record.Add(rec);
            ConBD.beerEN.SaveChanges();

            ViewEmployeeWindow vw = new ViewEmployeeWindow();
            vw.Show();
            this.Close();
        }
    }
}
