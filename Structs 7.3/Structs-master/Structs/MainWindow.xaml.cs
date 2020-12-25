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

namespace Structs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///
    public struct Person
    {
        public string NameFilms;
        public DateTime? DataSeans;
        public string Seans;
        public string TimeSeans;
        public string Janr;
    }
    public partial class MainWindow : Window
    {
        Person[] persons;
        int i = 0;
        int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(i==0)
            {
                try
                {
                    count = int.Parse(Count.Text);
                    persons = new Person[count];
                    AddPerson();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                AddPerson();
            }
            if(i==count)
            {
                Add.IsEnabled = false;
            }
        }
        public void AddPerson()
        {
            if (i < count)
            {
                WindowPerson window = new WindowPerson();
                if (window.ShowDialog() == true)
                {
                    Person p = new Person();
                    p.NameFilms = window.getNameFilms();
                    p.DataSeans = window.getDataSeans();
                    p.Seans = window.getSeans();
                    p.TimeSeans = window.getTimeSeans();
                    p.Janr = window.getJanr();
                    persons[i] = p;
                    Persons.Items.Add(p.NameFilms);
                }
                i++;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Add.IsEnabled = false;
        }

        private void Count_TextChanged(object sender, TextChangedEventArgs e)
        {
            Add.IsEnabled = true;
        }

        private void Persons_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string f = Persons.SelectedItems[0].ToString();
            Person p;
            for(int i=0;i<count;i++)
            {
                if(persons[i].NameFilms.Equals(f))
                {
                    p = persons[i];
                    WindowPerson w = new WindowPerson(p);
                    w.Show();
                    break;
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for(int i=0;i<count-1;i++)
            {
                for(int j=i+1;j<count;j++)
                {
                    if(persons[i].DataSeans>persons[j].DataSeans)
                    {
                        Person p = new Person();
                        p = persons[i];
                        persons[i] = persons[j];
                        persons[j] = p;
                    }
                }
            }
            Persons.Items.Clear();
            for (int i = 0; i < count; i++) Persons.Items.Add(persons[i].NameFilms);

        }

        private void Persons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
