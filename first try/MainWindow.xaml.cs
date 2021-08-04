using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using first_try.classes;

namespace first_try
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            DbClass.openConnection();
            //

            DbClass.sqlusers = "SELECT * FROM users;";
            DbClass.cmdusers.CommandType = CommandType.Text;
            DbClass.cmdusers.CommandText = DbClass.sqlusers;
            DbClass.dausers = new SqlDataAdapter(DbClass.cmdusers);
            DbClass.dtusers = new DataTable();
            DbClass.dausers.Fill(DbClass.dtusers);
            SqlCommandBuilder comandbuilderusers = new SqlCommandBuilder(DbClass.dausers);

        }

        

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            
              string login = LoginBox.Text.Trim();
              string pass = PasswordBox.Password.Trim();

            //Console.WriteLine("login  " + DbClass.dtusers.Rows[0][0].ToString() + "  pass  " + DbClass.dtusers.Rows[0][1].ToString());
            int count = DbClass.dtusers.Rows.Count;
            while (count > 0) {
                count--;
                if (login == DbClass.dtusers.Rows[count][0].ToString().Trim() && pass == DbClass.dtusers.Rows[count][1].ToString().Trim())
              {
                  Workday workday = new Workday();
                  workday.Show();
                  Close();
              }
              else if (login != DbClass.dtusers.Rows[count][0].ToString())
              {
                    
                  LoginBox.Background = Brushes.LightPink;
                  LoginBox.BorderBrush = Brushes.DarkRed;
                  
                  PasswordBox.Clear();
              }
              else if (login == DbClass.dtusers.Rows[count][0].ToString() && pass != DbClass.dtusers.Rows[count][1].ToString()) 
              {
                  LoginBox.Background = Brushes.Transparent;
                  LoginBox.BorderBrush = Brushes.DarkRed;
               
                  PasswordBox.Clear(); 
              }
                
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Login_Click(login_button, null);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           //
        }
    }
}
