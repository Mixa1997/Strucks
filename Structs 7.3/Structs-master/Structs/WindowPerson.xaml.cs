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

namespace Structs
{
    /// <summary>
    /// Логика взаимодействия для WindowPerson.xaml
    /// </summary>
    public partial class WindowPerson : Window
    {
        public WindowPerson(Person p)
        {
            InitializeComponent();
            if (p.TimeSeans == "18");
        }
        public WindowPerson()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        public string getNameFilms()
        {
            return NameFilms.Text;
        }

        public string getSeans()
        {
            return Seans.Text;
        }

        public DateTime? getDataSeans()
        {
            return DataSeans.SelectedDate;
        }

        public string getTimeSeans()
        {
            return TimeSeans.Text;
        }

        public string getJanr()
        {
            return Janr.Text;
        }
    }
}
