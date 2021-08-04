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
using first_try.classes;

namespace first_try
{
    /// <summary>
    /// Логика взаимодействия для Workday.xaml
    /// </summary>
    /// 
    public partial class Workday : Window
    {
        public Workday()
        {
            InitializeComponent();
            
        }
       
            private void Monday_Click(object sender, RoutedEventArgs e)
        {
            Monday monday = new Monday();
            monday.Show();
            Close();
        }
        private void Tuesday_Click(object sender, RoutedEventArgs e)
        {
            Tuesday tuesday = new Tuesday();
            tuesday.Show();
            Close();
        }
        private void Wednesday_Click(object sender, RoutedEventArgs e)
        {
            Wednesday wednesday = new Wednesday();
            wednesday.Show();
            Close();
        }
        private void Thursday_Click(object sender, RoutedEventArgs e)
        {
            Thursday thursday = new Thursday();
            thursday.Show();
            Close();
        }

        private void Friday_Click(object sender, RoutedEventArgs e)
        {
            Friday friday = new Friday();
            friday.Show();
            Close();
        }

        private void Saturday_Click(object sender, RoutedEventArgs e)
        {
            Saturday saturday = new Saturday();
            saturday.Show();
            Close();
        }

        private void Sunday_Click(object sender, RoutedEventArgs e)
        {
            Sunday sunday = new Sunday();
            sunday.Show();
            Close();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // DbClass.openConnection();
        }

       
        
        
    }
}
