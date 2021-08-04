using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Friday.xaml
    /// </summary>
    public partial class Friday : Window
    {

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (DbClass.conusers.State == ConnectionState.Closed)
            {
                DbClass.openConnection();
                Console.WriteLine("open");
            }

            prusytnist_Click(sender, e);

        }



        private void stolbik_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime date1 = DateTime.Today;
                string data = date1.ToString("ddMM");

                //14:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1400 = new SqlCommandBuilder(DbClass.daFriday1400);
                DbClass.cmdFriday1400.CommandText = "ALTER TABLE Friday1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdFriday1400.ExecuteNonQuery();
                DbClass.cmdFriday1400.CommandText = "UPDATE Friday1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdFriday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1400;";
                DbClass.cmdFriday1400.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1400 = new DataTable();
                DbClass.daFriday1400.Fill(DbClass.dtFriday1400);
                myDataGridFriday1400.ItemsSource = DbClass.dtFriday1400.DefaultView;
                DbClass.daFriday1400.Update(DbClass.dtFriday1400);

                SqlCommandBuilder comandbuilderOplFriday1400 = new SqlCommandBuilder(DbClass.daOplFriday1400);
                DbClass.cmdOplFriday1400.CommandText = "ALTER TABLE FridayOplata1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplFriday1400.ExecuteNonQuery();
                DbClass.cmdOplFriday1400.CommandText = "UPDATE FridayOplata1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplFriday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1400;";
                DbClass.cmdOplFriday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1400 = new DataTable();
                DbClass.daOplFriday1400.Fill(DbClass.dtOplFriday1400);
                myDataGridOplataFriday1400.ItemsSource = DbClass.dtOplFriday1400.DefaultView;
                DbClass.daOplFriday1400.Update(DbClass.dtOplFriday1400);


                //15:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1500 = new SqlCommandBuilder(DbClass.daFriday1500);
                DbClass.cmdFriday1500.CommandText = "ALTER TABLE Friday1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdFriday1500.ExecuteNonQuery();
                DbClass.cmdFriday1500.CommandText = "UPDATE Friday1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdFriday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1500;";
                DbClass.cmdFriday1500.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1500 = new DataTable();
                DbClass.daFriday1500.Fill(DbClass.dtFriday1500);
                myDataGridFriday1500.ItemsSource = DbClass.dtFriday1500.DefaultView;
                DbClass.daFriday1500.Update(DbClass.dtFriday1500);

                SqlCommandBuilder comandbuilderOplFriday1500 = new SqlCommandBuilder(DbClass.daOplFriday1500);
                DbClass.cmdOplFriday1500.CommandText = "ALTER TABLE FridayOplata1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplFriday1500.ExecuteNonQuery();
                DbClass.cmdOplFriday1500.CommandText = "UPDATE FridayOplata1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplFriday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1500;";
                DbClass.cmdOplFriday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1500 = new DataTable();
                DbClass.daOplFriday1500.Fill(DbClass.dtOplFriday1500);
                myDataGridOplataFriday1500.ItemsSource = DbClass.dtOplFriday1500.DefaultView;
                DbClass.daOplFriday1500.Update(DbClass.dtOplFriday1500);

                //16:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1600 = new SqlCommandBuilder(DbClass.daFriday1600);
                DbClass.cmdFriday1600.CommandText = "ALTER TABLE Friday1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdFriday1600.ExecuteNonQuery();
                DbClass.cmdFriday1600.CommandText = "UPDATE Friday1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdFriday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1600;";
                DbClass.cmdFriday1600.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1600 = new DataTable();
                DbClass.daFriday1600.Fill(DbClass.dtFriday1600);
                myDataGridFriday1600.ItemsSource = DbClass.dtFriday1600.DefaultView;
                DbClass.daFriday1600.Update(DbClass.dtFriday1600);

                SqlCommandBuilder comandbuilderOplFriday1600 = new SqlCommandBuilder(DbClass.daOplFriday1600);
                DbClass.cmdOplFriday1600.CommandText = "ALTER TABLE FridayOplata1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplFriday1600.ExecuteNonQuery();
                DbClass.cmdOplFriday1600.CommandText = "UPDATE FridayOplata1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplFriday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1600;";
                DbClass.cmdOplFriday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1600 = new DataTable();
                DbClass.daOplFriday1600.Fill(DbClass.dtOplFriday1600);
                myDataGridOplataFriday1600.ItemsSource = DbClass.dtOplFriday1600.DefaultView;
                DbClass.daOplFriday1600.Update(DbClass.dtOplFriday1600);

                //17:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1700 = new SqlCommandBuilder(DbClass.daFriday1700);
                DbClass.cmdFriday1700.CommandText = "ALTER TABLE Friday1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdFriday1700.ExecuteNonQuery();
                DbClass.cmdFriday1700.CommandText = "UPDATE Friday1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdFriday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1700;";
                DbClass.cmdFriday1700.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1700 = new DataTable();
                DbClass.daFriday1700.Fill(DbClass.dtFriday1700);
                myDataGridFriday1700.ItemsSource = DbClass.dtFriday1700.DefaultView;
                DbClass.daFriday1700.Update(DbClass.dtFriday1700);

                SqlCommandBuilder comandbuilderOplFriday1700 = new SqlCommandBuilder(DbClass.daOplFriday1700);
                DbClass.cmdOplFriday1700.CommandText = "ALTER TABLE FridayOplata1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplFriday1700.ExecuteNonQuery();
                DbClass.cmdOplFriday1700.CommandText = "UPDATE FridayOplata1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplFriday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1700;";
                DbClass.cmdOplFriday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1700 = new DataTable();
                DbClass.daOplFriday1700.Fill(DbClass.dtOplFriday1700);
                myDataGridOplataFriday1700.ItemsSource = DbClass.dtOplFriday1700.DefaultView;
                DbClass.daOplFriday1700.Update(DbClass.dtOplFriday1700);

                //18:10--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1810 = new SqlCommandBuilder(DbClass.daFriday1810);
                DbClass.cmdFriday1810.CommandText = "ALTER TABLE Friday1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdFriday1810.ExecuteNonQuery();
                DbClass.cmdFriday1810.CommandText = "UPDATE Friday1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdFriday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1810;";
                DbClass.cmdFriday1810.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1810 = new DataTable();
                DbClass.daFriday1810.Fill(DbClass.dtFriday1810);
                myDataGridFriday1810.ItemsSource = DbClass.dtFriday1810.DefaultView;
                DbClass.daFriday1810.Update(DbClass.dtFriday1810);

                SqlCommandBuilder comandbuilderOplFriday1810 = new SqlCommandBuilder(DbClass.daOplFriday1810);
                DbClass.cmdOplFriday1810.CommandText = "ALTER TABLE FridayOplata1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplFriday1810.ExecuteNonQuery();
                DbClass.cmdOplFriday1810.CommandText = "UPDATE FridayOplata1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplFriday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1810;";
                DbClass.cmdOplFriday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1810 = new DataTable();
                DbClass.daOplFriday1810.Fill(DbClass.dtOplFriday1810);
                myDataGridOplataFriday1810.ItemsSource = DbClass.dtOplFriday1810.DefaultView;
                DbClass.daOplFriday1810.Update(DbClass.dtOplFriday1810);

                rename_Columns();
            }
            catch (Exception)
            {

                //
            }

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime date1 = DateTime.Today;
                string data = date1.ToString("ddMM");

                //14:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1400 = new SqlCommandBuilder(DbClass.daFriday1400);
                DbClass.cmdFriday1400.CommandText = "ALTER TABLE Friday1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdFriday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1400;";
                DbClass.cmdFriday1400.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1400 = new DataTable();
                DbClass.daFriday1400.Fill(DbClass.dtFriday1400);
                myDataGridFriday1400.ItemsSource = DbClass.dtFriday1400.DefaultView;
                DbClass.daFriday1400.Update(DbClass.dtFriday1400);

                SqlCommandBuilder comandbuilderOplFriday1400 = new SqlCommandBuilder(DbClass.daOplFriday1400);
                DbClass.cmdOplFriday1400.CommandText = "ALTER TABLE FridayOplata1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplFriday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1400;";
                DbClass.cmdOplFriday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1400 = new DataTable();
                DbClass.daOplFriday1400.Fill(DbClass.dtOplFriday1400);
                myDataGridOplataFriday1400.ItemsSource = DbClass.dtOplFriday1400.DefaultView;
                DbClass.daOplFriday1400.Update(DbClass.dtOplFriday1400);


                //15:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1500 = new SqlCommandBuilder(DbClass.daFriday1500);
                DbClass.cmdFriday1500.CommandText = "ALTER TABLE Friday1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdFriday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1500;";
                DbClass.cmdFriday1500.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1500 = new DataTable();
                DbClass.daFriday1500.Fill(DbClass.dtFriday1500);
                myDataGridFriday1500.ItemsSource = DbClass.dtFriday1500.DefaultView;
                DbClass.daFriday1500.Update(DbClass.dtFriday1500);

                SqlCommandBuilder comandbuilderOplFriday1500 = new SqlCommandBuilder(DbClass.daOplFriday1500);
                DbClass.cmdOplFriday1500.CommandText = "ALTER TABLE FridayOplata1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplFriday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1500;";
                DbClass.cmdOplFriday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1500 = new DataTable();
                DbClass.daOplFriday1500.Fill(DbClass.dtOplFriday1500);
                myDataGridOplataFriday1500.ItemsSource = DbClass.dtOplFriday1500.DefaultView;
                DbClass.daOplFriday1500.Update(DbClass.dtOplFriday1500);


                //16:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1600 = new SqlCommandBuilder(DbClass.daFriday1600);
                DbClass.cmdFriday1600.CommandText = "ALTER TABLE Friday1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdFriday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1600;";
                DbClass.cmdFriday1600.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1600 = new DataTable();
                DbClass.daFriday1600.Fill(DbClass.dtFriday1600);
                myDataGridFriday1600.ItemsSource = DbClass.dtFriday1600.DefaultView;
                DbClass.daFriday1600.Update(DbClass.dtFriday1600);

                SqlCommandBuilder comandbuilderOplFriday1600 = new SqlCommandBuilder(DbClass.daOplFriday1600);
                DbClass.cmdOplFriday1600.CommandText = "ALTER TABLE FridayOplata1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplFriday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1600;";
                DbClass.cmdOplFriday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1600 = new DataTable();
                DbClass.daOplFriday1600.Fill(DbClass.dtOplFriday1600);
                myDataGridOplataFriday1600.ItemsSource = DbClass.dtOplFriday1600.DefaultView;
                DbClass.daOplFriday1600.Update(DbClass.dtOplFriday1600);


                //17:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1700 = new SqlCommandBuilder(DbClass.daFriday1700);
                DbClass.cmdFriday1700.CommandText = "ALTER TABLE Friday1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdFriday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1700;";
                DbClass.cmdFriday1700.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1700 = new DataTable();
                DbClass.daFriday1700.Fill(DbClass.dtFriday1700);
                myDataGridFriday1700.ItemsSource = DbClass.dtFriday1700.DefaultView;
                DbClass.daFriday1700.Update(DbClass.dtFriday1700);

                SqlCommandBuilder comandbuilderOplFriday1700 = new SqlCommandBuilder(DbClass.daOplFriday1700);
                DbClass.cmdOplFriday1700.CommandText = "ALTER TABLE FridayOplata1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplFriday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1700;";
                DbClass.cmdOplFriday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1700 = new DataTable();
                DbClass.daOplFriday1700.Fill(DbClass.dtOplFriday1700);
                myDataGridOplataFriday1700.ItemsSource = DbClass.dtOplFriday1700.DefaultView;
                DbClass.daOplFriday1700.Update(DbClass.dtOplFriday1700);


                //18:10-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderFriday1810 = new SqlCommandBuilder(DbClass.daFriday1810);
                DbClass.cmdFriday1810.CommandText = "ALTER TABLE Friday1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdFriday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Friday1810;";
                DbClass.cmdFriday1810.CommandText = DbClass.sqlusers;
                DbClass.dtFriday1810 = new DataTable();
                DbClass.daFriday1810.Fill(DbClass.dtFriday1810);
                myDataGridFriday1810.ItemsSource = DbClass.dtFriday1810.DefaultView;
                DbClass.daFriday1810.Update(DbClass.dtFriday1810);

                SqlCommandBuilder comandbuilderOplFriday1810 = new SqlCommandBuilder(DbClass.daOplFriday1810);
                DbClass.cmdOplFriday1810.CommandText = "ALTER TABLE FridayOplata1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplFriday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM FridayOplata1810;";
                DbClass.cmdOplFriday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplFriday1810 = new DataTable();
                DbClass.daOplFriday1810.Fill(DbClass.dtOplFriday1810);
                myDataGridOplataFriday1810.ItemsSource = DbClass.dtOplFriday1810.DefaultView;
                DbClass.daOplFriday1810.Update(DbClass.dtOplFriday1810);

                rename_Columns();
            }
            catch (Exception)
            {

                //
            }

        }

        public void rename_Columns()
        {
            //14:00--------------------------------------------------------------------
            //присутність--------------------------------------------------------------
            try
            {

                myDataGridFriday1400.Columns[0].Header = "Залишок";
                myDataGridFriday1400.Columns[1].Header = "ПІБ";
                for (int i = myDataGridFriday1400.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridFriday1400.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridFriday1400.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridFriday1400.Columns[i].Header = column_header;
                }


            }
            catch (Exception)
            {

                //
            }
            //оплата-------------------------------------------------------------------
            try
            {
                myDataGridOplataFriday1400.Columns[0].Header = "Оплачено";
                myDataGridOplataFriday1400.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataFriday1400.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataFriday1400.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataFriday1400.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataFriday1400.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                //
            }
            //15:00--------------------------------------------------------------------
            try
            {

                myDataGridFriday1500.Columns[0].Header = "Залишок";
                myDataGridFriday1500.Columns[1].Header = "ПІБ";
                for (int i = myDataGridFriday1500.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridFriday1500.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridFriday1500.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridFriday1500.Columns[i].Header = column_header;
                }

                myDataGridOplataFriday1500.Columns[0].Header = "Оплачено";
                myDataGridOplataFriday1500.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataFriday1500.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataFriday1500.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataFriday1500.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataFriday1500.Columns[j].Header = column_header;

                }

            }
            catch (Exception)
            {
                Console.WriteLine("rename15");
                //
            }

            //16:00--------------------------------------------------------------------
            try
            {
                myDataGridFriday1600.Columns[0].Header = "Залишок";
                myDataGridFriday1600.Columns[1].Header = "ПІБ";
                for (int i = myDataGridFriday1600.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridFriday1600.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridFriday1600.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridFriday1600.Columns[i].Header = column_header;
                }

                myDataGridOplataFriday1600.Columns[0].Header = "Оплачено";
                myDataGridOplataFriday1600.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataFriday1600.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataFriday1600.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataFriday1600.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataFriday1600.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename16");

            }

            //17:00--------------------------------------------------------------------
            try
            {
                myDataGridFriday1700.Columns[0].Header = "Залишок";
                myDataGridFriday1700.Columns[1].Header = "ПІБ";
                for (int i = myDataGridFriday1700.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridFriday1700.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridFriday1700.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridFriday1700.Columns[i].Header = column_header;
                }


                myDataGridOplataFriday1700.Columns[0].Header = "Оплачено";
                myDataGridOplataFriday1700.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataFriday1700.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataFriday1700.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataFriday1700.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataFriday1700.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename17");

            }

            //18:10--------------------------------------------------------------------
            try
            {
                myDataGridFriday1810.Columns[0].Header = "Залишок";
                myDataGridFriday1810.Columns[1].Header = "ПІБ";
                for (int i = myDataGridFriday1810.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridFriday1810.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridFriday1810.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridFriday1810.Columns[i].Header = column_header;
                }


                myDataGridOplataFriday1810.Columns[0].Header = "Оплачено";
                myDataGridOplataFriday1810.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataFriday1810.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataFriday1810.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataFriday1810.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataFriday1810.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {

                Console.WriteLine("rename18");
            }

        }

        public void count_Plus()
        {
            //14:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataFriday1400.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataFriday1400.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplFriday1400.Rows[i][j].ToString());
                        DbClass.dtOplFriday1400.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridFriday1400.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridFriday1400.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtFriday1400.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplFriday1400.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtFriday1400.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }
            //15:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataFriday1500.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataFriday1500.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplFriday1500.Rows[i][j].ToString());
                        DbClass.dtOplFriday1500.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridFriday1500.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridFriday1500.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtFriday1500.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplFriday1500.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtFriday1500.Rows[i][0] = temp.ToString().Trim();


                }


            }
            catch (Exception)
            {
                //
            }

            //16:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataFriday1600.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataFriday1600.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplFriday1600.Rows[i][j].ToString());
                        DbClass.dtOplFriday1600.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridFriday1600.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridFriday1600.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtFriday1600.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplFriday1600.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtFriday1600.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }

            //17:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataFriday1700.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataFriday1700.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplFriday1700.Rows[i][j].ToString());
                        DbClass.dtOplFriday1700.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridFriday1700.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridFriday1700.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtFriday1700.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplFriday1700.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtFriday1700.Rows[i][0] = temp.ToString().Trim();


                }
            }
            catch (Exception)
            {
                //
            }

            //18:10-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataFriday1810.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataFriday1810.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplFriday1810.Rows[i][j].ToString());
                        DbClass.dtOplFriday1810.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridFriday1810.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridFriday1810.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtFriday1810.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplFriday1810.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtFriday1810.Rows[i][0] = temp.ToString().Trim();


                }


            }
            catch (Exception)
            {
                //
            }





        }

        private void oplata_Click(object sender, RoutedEventArgs e)
        {
            TabControl.Visibility = Visibility.Collapsed;
            TabControlOplata.Visibility = Visibility.Visible;
            count_Plus();
            rename_Columns();


        }

        public void prusytnist_Click(object sender, RoutedEventArgs e)
        {

            TabControl.Visibility = Visibility.Visible;

            count_Plus();
            rename_Columns();
            TabControlOplata.Visibility = Visibility.Collapsed;

        }

        public Friday()
        {
            InitializeComponent();

            //вівторок-----------------------------------------------------------------------------------
            //14:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM friday1400;";
            DbClass.cmdFriday1400.CommandType = CommandType.Text;
            DbClass.cmdFriday1400.CommandText = DbClass.sqlusers;
            DbClass.daFriday1400 = new SqlDataAdapter(DbClass.cmdFriday1400);
            DbClass.dtFriday1400 = new DataTable();
            DbClass.daFriday1400.Fill(DbClass.dtFriday1400);
            SqlCommandBuilder comandbuilderFriday1400 = new SqlCommandBuilder(DbClass.daFriday1400);

            //оплата
            DbClass.sqlusers = "SELECT * FROM fridayOplata1400;";
            DbClass.cmdOplFriday1400.CommandType = CommandType.Text;
            DbClass.cmdOplFriday1400.CommandText = DbClass.sqlusers;
            DbClass.daOplFriday1400 = new SqlDataAdapter(DbClass.cmdOplFriday1400);
            DbClass.dtOplFriday1400 = new DataTable();
            DbClass.daOplFriday1400.Fill(DbClass.dtOplFriday1400);
            SqlCommandBuilder comandbuilderOplFriday1400 = new SqlCommandBuilder(DbClass.daOplFriday1400);

            //15:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM friday1500;";
            DbClass.cmdFriday1500.CommandType = CommandType.Text;
            DbClass.cmdFriday1500.CommandText = DbClass.sqlusers;
            DbClass.daFriday1500 = new SqlDataAdapter(DbClass.cmdFriday1500);
            DbClass.dtFriday1500 = new DataTable();
            DbClass.daFriday1500.Fill(DbClass.dtFriday1500);
            SqlCommandBuilder comandbuilderFriday1500 = new SqlCommandBuilder(DbClass.daFriday1500);

            //оплата
            DbClass.sqlusers = "SELECT * FROM fridayOplata1500;";
            DbClass.cmdOplFriday1500.CommandType = CommandType.Text;
            DbClass.cmdOplFriday1500.CommandText = DbClass.sqlusers;
            DbClass.daOplFriday1500 = new SqlDataAdapter(DbClass.cmdOplFriday1500);
            DbClass.dtOplFriday1500 = new DataTable();
            DbClass.daOplFriday1500.Fill(DbClass.dtOplFriday1500);
            SqlCommandBuilder comandbuilderOplFriday1500 = new SqlCommandBuilder(DbClass.daOplFriday1500);


            //16:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM friday1600;";
            DbClass.cmdFriday1600.CommandType = CommandType.Text;
            DbClass.cmdFriday1600.CommandText = DbClass.sqlusers;
            DbClass.daFriday1600 = new SqlDataAdapter(DbClass.cmdFriday1600);
            DbClass.dtFriday1600 = new DataTable();
            DbClass.daFriday1600.Fill(DbClass.dtFriday1600);
            SqlCommandBuilder comandbuilderFriday1600 = new SqlCommandBuilder(DbClass.daFriday1600);


            //оплата
            DbClass.sqlusers = "SELECT * FROM fridayOplata1600;";
            DbClass.cmdOplFriday1600.CommandType = CommandType.Text;
            DbClass.cmdOplFriday1600.CommandText = DbClass.sqlusers;
            DbClass.daOplFriday1600 = new SqlDataAdapter(DbClass.cmdOplFriday1600);
            DbClass.dtOplFriday1600 = new DataTable();
            DbClass.daOplFriday1600.Fill(DbClass.dtOplFriday1600);
            SqlCommandBuilder comandbuilderOplFriday1600 = new SqlCommandBuilder(DbClass.daOplFriday1600);



            //17:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM friday1700;";
            DbClass.cmdFriday1700.CommandType = CommandType.Text;
            DbClass.cmdFriday1700.CommandText = DbClass.sqlusers;
            DbClass.daFriday1700 = new SqlDataAdapter(DbClass.cmdFriday1700);
            DbClass.dtFriday1700 = new DataTable();
            DbClass.daFriday1700.Fill(DbClass.dtFriday1700);
            SqlCommandBuilder comandbuilderFriday1700 = new SqlCommandBuilder(DbClass.daFriday1700);

            //оплата
            DbClass.sqlusers = "SELECT * FROM fridayOplata1700;";
            DbClass.cmdOplFriday1700.CommandType = CommandType.Text;
            DbClass.cmdOplFriday1700.CommandText = DbClass.sqlusers;
            DbClass.daOplFriday1700 = new SqlDataAdapter(DbClass.cmdOplFriday1700);
            DbClass.dtOplFriday1700 = new DataTable();
            DbClass.daOplFriday1700.Fill(DbClass.dtOplFriday1700);
            SqlCommandBuilder comandbuilderOplFriday1700 = new SqlCommandBuilder(DbClass.daOplFriday1700);

            //18:10----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM friday1810;";
            DbClass.cmdFriday1810.CommandType = CommandType.Text;
            DbClass.cmdFriday1810.CommandText = DbClass.sqlusers;
            DbClass.daFriday1810 = new SqlDataAdapter(DbClass.cmdFriday1810);
            DbClass.dtFriday1810 = new DataTable();
            DbClass.daFriday1810.Fill(DbClass.dtFriday1810);
            SqlCommandBuilder comandbuilderFriday1810 = new SqlCommandBuilder(DbClass.daFriday1810);

            //оплата
            DbClass.sqlusers = "SELECT * FROM fridayOplata1810;";
            DbClass.cmdOplFriday1810.CommandType = CommandType.Text;
            DbClass.cmdOplFriday1810.CommandText = DbClass.sqlusers;
            DbClass.daOplFriday1810 = new SqlDataAdapter(DbClass.cmdOplFriday1810);
            DbClass.dtOplFriday1810 = new DataTable();
            DbClass.daOplFriday1810.Fill(DbClass.dtOplFriday1810);
            SqlCommandBuilder comandbuilderOplFriday1810 = new SqlCommandBuilder(DbClass.daOplFriday1810);

        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                back_Click(back, null);
            }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Workday workday = new Workday();
            workday.Show();
            Close();
        }



        private void TabItemOplataFriday1400_Selected(object sender, RoutedEventArgs e)
        {
            //14:00----------------------------------------------------------------------------------

            rename_Columns();

        }



        private void myDataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            myDataGridFriday1400.ItemsSource = DbClass.dtFriday1400.DefaultView;
            myDataGridOplataFriday1400.ItemsSource = DbClass.dtOplFriday1400.DefaultView;

            myDataGridFriday1500.ItemsSource = DbClass.dtFriday1500.DefaultView;
            myDataGridOplataFriday1500.ItemsSource = DbClass.dtOplFriday1500.DefaultView;

            myDataGridFriday1600.ItemsSource = DbClass.dtFriday1600.DefaultView;
            myDataGridOplataFriday1600.ItemsSource = DbClass.dtOplFriday1600.DefaultView;

            myDataGridFriday1700.ItemsSource = DbClass.dtFriday1700.DefaultView;
            myDataGridOplataFriday1700.ItemsSource = DbClass.dtOplFriday1700.DefaultView;

            myDataGridFriday1810.ItemsSource = DbClass.dtFriday1810.DefaultView;
            myDataGridOplataFriday1810.ItemsSource = DbClass.dtOplFriday1810.DefaultView;

            count_Plus();
            rename_Columns();
        }

        private void myDataGridFriday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daFriday1400.Update(DbClass.dtFriday1400);

        }

        private void myDataGridFriday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daFriday1500.Update(DbClass.dtFriday1500);
        }

        private void myDataGridFriday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daFriday1600.Update(DbClass.dtFriday1600);
        }

        private void myDataGridFriday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daFriday1700.Update(DbClass.dtFriday1700);
        }

        private void myDataGridFriday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daFriday1810.Update(DbClass.dtFriday1810);
        }

        private void myDataGridOplataFriday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplFriday1400.Update(DbClass.dtOplFriday1400);
        }

        private void myDataGridOplataFriday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplFriday1500.Update(DbClass.dtOplFriday1500);
        }

        private void myDataGridOplataFriday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplFriday1600.Update(DbClass.dtOplFriday1600);
        }

        private void myDataGridOplataFriday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplFriday1700.Update(DbClass.dtOplFriday1700);
        }

        private void myDataGridOplataFriday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplFriday1810.Update(DbClass.dtOplFriday1810);
        }
    }
}