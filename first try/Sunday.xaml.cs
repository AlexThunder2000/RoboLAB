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
    /// Логика взаимодействия для Sunday.xaml
    /// </summary>
    public partial class Sunday : Window
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
                SqlCommandBuilder comandbuilderSunday1400 = new SqlCommandBuilder(DbClass.daSunday1400);
                DbClass.cmdSunday1400.CommandText = "ALTER TABLE Sunday1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSunday1400.ExecuteNonQuery();
                DbClass.cmdSunday1400.CommandText = "UPDATE Sunday1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSunday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1400;";
                DbClass.cmdSunday1400.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1400 = new DataTable();
                DbClass.daSunday1400.Fill(DbClass.dtSunday1400);
                myDataGridSunday1400.ItemsSource = DbClass.dtSunday1400.DefaultView;
                DbClass.daSunday1400.Update(DbClass.dtSunday1400);

                SqlCommandBuilder comandbuilderOplSunday1400 = new SqlCommandBuilder(DbClass.daOplSunday1400);
                DbClass.cmdOplSunday1400.CommandText = "ALTER TABLE SundayOplata1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSunday1400.ExecuteNonQuery();
                DbClass.cmdOplSunday1400.CommandText = "UPDATE SundayOplata1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSunday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1400;";
                DbClass.cmdOplSunday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1400 = new DataTable();
                DbClass.daOplSunday1400.Fill(DbClass.dtOplSunday1400);
                myDataGridOplataSunday1400.ItemsSource = DbClass.dtOplSunday1400.DefaultView;
                DbClass.daOplSunday1400.Update(DbClass.dtOplSunday1400);


                //15:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSunday1500 = new SqlCommandBuilder(DbClass.daSunday1500);
                DbClass.cmdSunday1500.CommandText = "ALTER TABLE Sunday1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSunday1500.ExecuteNonQuery();
                DbClass.cmdSunday1500.CommandText = "UPDATE Sunday1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSunday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1500;";
                DbClass.cmdSunday1500.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1500 = new DataTable();
                DbClass.daSunday1500.Fill(DbClass.dtSunday1500);
                myDataGridSunday1500.ItemsSource = DbClass.dtSunday1500.DefaultView;
                DbClass.daSunday1500.Update(DbClass.dtSunday1500);

                SqlCommandBuilder comandbuilderOplSunday1500 = new SqlCommandBuilder(DbClass.daOplSunday1500);
                DbClass.cmdOplSunday1500.CommandText = "ALTER TABLE SundayOplata1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSunday1500.ExecuteNonQuery();
                DbClass.cmdOplSunday1500.CommandText = "UPDATE SundayOplata1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSunday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1500;";
                DbClass.cmdOplSunday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1500 = new DataTable();
                DbClass.daOplSunday1500.Fill(DbClass.dtOplSunday1500);
                myDataGridOplataSunday1500.ItemsSource = DbClass.dtOplSunday1500.DefaultView;
                DbClass.daOplSunday1500.Update(DbClass.dtOplSunday1500);

                //16:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSunday1600 = new SqlCommandBuilder(DbClass.daSunday1600);
                DbClass.cmdSunday1600.CommandText = "ALTER TABLE Sunday1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSunday1600.ExecuteNonQuery();
                DbClass.cmdSunday1600.CommandText = "UPDATE Sunday1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSunday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1600;";
                DbClass.cmdSunday1600.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1600 = new DataTable();
                DbClass.daSunday1600.Fill(DbClass.dtSunday1600);
                myDataGridSunday1600.ItemsSource = DbClass.dtSunday1600.DefaultView;
                DbClass.daSunday1600.Update(DbClass.dtSunday1600);

                SqlCommandBuilder comandbuilderOplSunday1600 = new SqlCommandBuilder(DbClass.daOplSunday1600);
                DbClass.cmdOplSunday1600.CommandText = "ALTER TABLE SundayOplata1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSunday1600.ExecuteNonQuery();
                DbClass.cmdOplSunday1600.CommandText = "UPDATE SundayOplata1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSunday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1600;";
                DbClass.cmdOplSunday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1600 = new DataTable();
                DbClass.daOplSunday1600.Fill(DbClass.dtOplSunday1600);
                myDataGridOplataSunday1600.ItemsSource = DbClass.dtOplSunday1600.DefaultView;
                DbClass.daOplSunday1600.Update(DbClass.dtOplSunday1600);

                //17:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSunday1700 = new SqlCommandBuilder(DbClass.daSunday1700);
                DbClass.cmdSunday1700.CommandText = "ALTER TABLE Sunday1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSunday1700.ExecuteNonQuery();
                DbClass.cmdSunday1700.CommandText = "UPDATE Sunday1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSunday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1700;";
                DbClass.cmdSunday1700.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1700 = new DataTable();
                DbClass.daSunday1700.Fill(DbClass.dtSunday1700);
                myDataGridSunday1700.ItemsSource = DbClass.dtSunday1700.DefaultView;
                DbClass.daSunday1700.Update(DbClass.dtSunday1700);

                SqlCommandBuilder comandbuilderOplSunday1700 = new SqlCommandBuilder(DbClass.daOplSunday1700);
                DbClass.cmdOplSunday1700.CommandText = "ALTER TABLE SundayOplata1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSunday1700.ExecuteNonQuery();
                DbClass.cmdOplSunday1700.CommandText = "UPDATE SundayOplata1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSunday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1700;";
                DbClass.cmdOplSunday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1700 = new DataTable();
                DbClass.daOplSunday1700.Fill(DbClass.dtOplSunday1700);
                myDataGridOplataSunday1700.ItemsSource = DbClass.dtOplSunday1700.DefaultView;
                DbClass.daOplSunday1700.Update(DbClass.dtOplSunday1700);

                //18:10--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSunday1810 = new SqlCommandBuilder(DbClass.daSunday1810);
                DbClass.cmdSunday1810.CommandText = "ALTER TABLE Sunday1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSunday1810.ExecuteNonQuery();
                DbClass.cmdSunday1810.CommandText = "UPDATE Sunday1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSunday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1810;";
                DbClass.cmdSunday1810.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1810 = new DataTable();
                DbClass.daSunday1810.Fill(DbClass.dtSunday1810);
                myDataGridSunday1810.ItemsSource = DbClass.dtSunday1810.DefaultView;
                DbClass.daSunday1810.Update(DbClass.dtSunday1810);

                SqlCommandBuilder comandbuilderOplSunday1810 = new SqlCommandBuilder(DbClass.daOplSunday1810);
                DbClass.cmdOplSunday1810.CommandText = "ALTER TABLE SundayOplata1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSunday1810.ExecuteNonQuery();
                DbClass.cmdOplSunday1810.CommandText = "UPDATE SundayOplata1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSunday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1810;";
                DbClass.cmdOplSunday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1810 = new DataTable();
                DbClass.daOplSunday1810.Fill(DbClass.dtOplSunday1810);
                myDataGridOplataSunday1810.ItemsSource = DbClass.dtOplSunday1810.DefaultView;
                DbClass.daOplSunday1810.Update(DbClass.dtOplSunday1810);

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
                SqlCommandBuilder comandbuilderSunday1400 = new SqlCommandBuilder(DbClass.daSunday1400);
                DbClass.cmdSunday1400.CommandText = "ALTER TABLE Sunday1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSunday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1400;";
                DbClass.cmdSunday1400.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1400 = new DataTable();
                DbClass.daSunday1400.Fill(DbClass.dtSunday1400);
                myDataGridSunday1400.ItemsSource = DbClass.dtSunday1400.DefaultView;
                DbClass.daSunday1400.Update(DbClass.dtSunday1400);

                SqlCommandBuilder comandbuilderOplSunday1400 = new SqlCommandBuilder(DbClass.daOplSunday1400);
                DbClass.cmdOplSunday1400.CommandText = "ALTER TABLE SundayOplata1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSunday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1400;";
                DbClass.cmdOplSunday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1400 = new DataTable();
                DbClass.daOplSunday1400.Fill(DbClass.dtOplSunday1400);
                myDataGridOplataSunday1400.ItemsSource = DbClass.dtOplSunday1400.DefaultView;
                DbClass.daOplSunday1400.Update(DbClass.dtOplSunday1400);


                //15:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSunday1500 = new SqlCommandBuilder(DbClass.daSunday1500);
                DbClass.cmdSunday1500.CommandText = "ALTER TABLE Sunday1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSunday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1500;";
                DbClass.cmdSunday1500.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1500 = new DataTable();
                DbClass.daSunday1500.Fill(DbClass.dtSunday1500);
                myDataGridSunday1500.ItemsSource = DbClass.dtSunday1500.DefaultView;
                DbClass.daSunday1500.Update(DbClass.dtSunday1500);

                SqlCommandBuilder comandbuilderOplSunday1500 = new SqlCommandBuilder(DbClass.daOplSunday1500);
                DbClass.cmdOplSunday1500.CommandText = "ALTER TABLE SundayOplata1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSunday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1500;";
                DbClass.cmdOplSunday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1500 = new DataTable();
                DbClass.daOplSunday1500.Fill(DbClass.dtOplSunday1500);
                myDataGridOplataSunday1500.ItemsSource = DbClass.dtOplSunday1500.DefaultView;
                DbClass.daOplSunday1500.Update(DbClass.dtOplSunday1500);


                //16:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSunday1600 = new SqlCommandBuilder(DbClass.daSunday1600);
                DbClass.cmdSunday1600.CommandText = "ALTER TABLE Sunday1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSunday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1600;";
                DbClass.cmdSunday1600.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1600 = new DataTable();
                DbClass.daSunday1600.Fill(DbClass.dtSunday1600);
                myDataGridSunday1600.ItemsSource = DbClass.dtSunday1600.DefaultView;
                DbClass.daSunday1600.Update(DbClass.dtSunday1600);

                SqlCommandBuilder comandbuilderOplSunday1600 = new SqlCommandBuilder(DbClass.daOplSunday1600);
                DbClass.cmdOplSunday1600.CommandText = "ALTER TABLE SundayOplata1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSunday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1600;";
                DbClass.cmdOplSunday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1600 = new DataTable();
                DbClass.daOplSunday1600.Fill(DbClass.dtOplSunday1600);
                myDataGridOplataSunday1600.ItemsSource = DbClass.dtOplSunday1600.DefaultView;
                DbClass.daOplSunday1600.Update(DbClass.dtOplSunday1600);


                //17:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSunday1700 = new SqlCommandBuilder(DbClass.daSunday1700);
                DbClass.cmdSunday1700.CommandText = "ALTER TABLE Sunday1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSunday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1700;";
                DbClass.cmdSunday1700.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1700 = new DataTable();
                DbClass.daSunday1700.Fill(DbClass.dtSunday1700);
                myDataGridSunday1700.ItemsSource = DbClass.dtSunday1700.DefaultView;
                DbClass.daSunday1700.Update(DbClass.dtSunday1700);

                SqlCommandBuilder comandbuilderOplSunday1700 = new SqlCommandBuilder(DbClass.daOplSunday1700);
                DbClass.cmdOplSunday1700.CommandText = "ALTER TABLE SundayOplata1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSunday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1700;";
                DbClass.cmdOplSunday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1700 = new DataTable();
                DbClass.daOplSunday1700.Fill(DbClass.dtOplSunday1700);
                myDataGridOplataSunday1700.ItemsSource = DbClass.dtOplSunday1700.DefaultView;
                DbClass.daOplSunday1700.Update(DbClass.dtOplSunday1700);


                //18:10-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSunday1810 = new SqlCommandBuilder(DbClass.daSunday1810);
                DbClass.cmdSunday1810.CommandText = "ALTER TABLE Sunday1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSunday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Sunday1810;";
                DbClass.cmdSunday1810.CommandText = DbClass.sqlusers;
                DbClass.dtSunday1810 = new DataTable();
                DbClass.daSunday1810.Fill(DbClass.dtSunday1810);
                myDataGridSunday1810.ItemsSource = DbClass.dtSunday1810.DefaultView;
                DbClass.daSunday1810.Update(DbClass.dtSunday1810);

                SqlCommandBuilder comandbuilderOplSunday1810 = new SqlCommandBuilder(DbClass.daOplSunday1810);
                DbClass.cmdOplSunday1810.CommandText = "ALTER TABLE SundayOplata1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSunday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SundayOplata1810;";
                DbClass.cmdOplSunday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplSunday1810 = new DataTable();
                DbClass.daOplSunday1810.Fill(DbClass.dtOplSunday1810);
                myDataGridOplataSunday1810.ItemsSource = DbClass.dtOplSunday1810.DefaultView;
                DbClass.daOplSunday1810.Update(DbClass.dtOplSunday1810);

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

                myDataGridSunday1400.Columns[0].Header = "Залишок";
                myDataGridSunday1400.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSunday1400.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSunday1400.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSunday1400.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSunday1400.Columns[i].Header = column_header;
                }


            }
            catch (Exception)
            {

                //
            }
            //оплата-------------------------------------------------------------------
            try
            {
                myDataGridOplataSunday1400.Columns[0].Header = "Оплачено";
                myDataGridOplataSunday1400.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSunday1400.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSunday1400.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSunday1400.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSunday1400.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                //
            }
            //15:00--------------------------------------------------------------------
            try
            {

                myDataGridSunday1500.Columns[0].Header = "Залишок";
                myDataGridSunday1500.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSunday1500.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSunday1500.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSunday1500.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSunday1500.Columns[i].Header = column_header;
                }

                myDataGridOplataSunday1500.Columns[0].Header = "Оплачено";
                myDataGridOplataSunday1500.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSunday1500.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSunday1500.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSunday1500.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSunday1500.Columns[j].Header = column_header;

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
                myDataGridSunday1600.Columns[0].Header = "Залишок";
                myDataGridSunday1600.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSunday1600.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSunday1600.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSunday1600.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSunday1600.Columns[i].Header = column_header;
                }

                myDataGridOplataSunday1600.Columns[0].Header = "Оплачено";
                myDataGridOplataSunday1600.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSunday1600.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSunday1600.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSunday1600.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSunday1600.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename16");

            }

            //17:00--------------------------------------------------------------------
            try
            {
                myDataGridSunday1700.Columns[0].Header = "Залишок";
                myDataGridSunday1700.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSunday1700.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSunday1700.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSunday1700.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSunday1700.Columns[i].Header = column_header;
                }


                myDataGridOplataSunday1700.Columns[0].Header = "Оплачено";
                myDataGridOplataSunday1700.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSunday1700.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSunday1700.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSunday1700.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSunday1700.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename17");

            }

            //18:10--------------------------------------------------------------------
            try
            {
                myDataGridSunday1810.Columns[0].Header = "Залишок";
                myDataGridSunday1810.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSunday1810.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSunday1810.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSunday1810.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSunday1810.Columns[i].Header = column_header;
                }


                myDataGridOplataSunday1810.Columns[0].Header = "Оплачено";
                myDataGridOplataSunday1810.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSunday1810.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSunday1810.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSunday1810.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSunday1810.Columns[j].Header = column_header;

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
                for (int i = 0; i < myDataGridOplataSunday1400.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSunday1400.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSunday1400.Rows[i][j].ToString());
                        DbClass.dtOplSunday1400.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSunday1400.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSunday1400.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSunday1400.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSunday1400.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSunday1400.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }
            //15:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataSunday1500.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSunday1500.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSunday1500.Rows[i][j].ToString());
                        DbClass.dtOplSunday1500.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSunday1500.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSunday1500.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSunday1500.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSunday1500.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSunday1500.Rows[i][0] = temp.ToString().Trim();


                }


            }
            catch (Exception)
            {
                //
            }

            //16:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataSunday1600.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSunday1600.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSunday1600.Rows[i][j].ToString());
                        DbClass.dtOplSunday1600.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSunday1600.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSunday1600.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSunday1600.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSunday1600.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSunday1600.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }

            //17:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataSunday1700.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSunday1700.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSunday1700.Rows[i][j].ToString());
                        DbClass.dtOplSunday1700.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSunday1700.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSunday1700.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSunday1700.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSunday1700.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSunday1700.Rows[i][0] = temp.ToString().Trim();


                }
            }
            catch (Exception)
            {
                //
            }

            //18:10-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataSunday1810.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSunday1810.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSunday1810.Rows[i][j].ToString());
                        DbClass.dtOplSunday1810.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSunday1810.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSunday1810.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSunday1810.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSunday1810.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSunday1810.Rows[i][0] = temp.ToString().Trim();


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

        public Sunday()
        {
            InitializeComponent();

            //вівторок-----------------------------------------------------------------------------------
            //14:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM sunday1400;";
            DbClass.cmdSunday1400.CommandType = CommandType.Text;
            DbClass.cmdSunday1400.CommandText = DbClass.sqlusers;
            DbClass.daSunday1400 = new SqlDataAdapter(DbClass.cmdSunday1400);
            DbClass.dtSunday1400 = new DataTable();
            DbClass.daSunday1400.Fill(DbClass.dtSunday1400);
            SqlCommandBuilder comandbuilderSunday1400 = new SqlCommandBuilder(DbClass.daSunday1400);

            //оплата
            DbClass.sqlusers = "SELECT * FROM sundayOplata1400;";
            DbClass.cmdOplSunday1400.CommandType = CommandType.Text;
            DbClass.cmdOplSunday1400.CommandText = DbClass.sqlusers;
            DbClass.daOplSunday1400 = new SqlDataAdapter(DbClass.cmdOplSunday1400);
            DbClass.dtOplSunday1400 = new DataTable();
            DbClass.daOplSunday1400.Fill(DbClass.dtOplSunday1400);
            SqlCommandBuilder comandbuilderOplSunday1400 = new SqlCommandBuilder(DbClass.daOplSunday1400);

            //15:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM sunday1500;";
            DbClass.cmdSunday1500.CommandType = CommandType.Text;
            DbClass.cmdSunday1500.CommandText = DbClass.sqlusers;
            DbClass.daSunday1500 = new SqlDataAdapter(DbClass.cmdSunday1500);
            DbClass.dtSunday1500 = new DataTable();
            DbClass.daSunday1500.Fill(DbClass.dtSunday1500);
            SqlCommandBuilder comandbuilderSunday1500 = new SqlCommandBuilder(DbClass.daSunday1500);

            //оплата
            DbClass.sqlusers = "SELECT * FROM sundayOplata1500;";
            DbClass.cmdOplSunday1500.CommandType = CommandType.Text;
            DbClass.cmdOplSunday1500.CommandText = DbClass.sqlusers;
            DbClass.daOplSunday1500 = new SqlDataAdapter(DbClass.cmdOplSunday1500);
            DbClass.dtOplSunday1500 = new DataTable();
            DbClass.daOplSunday1500.Fill(DbClass.dtOplSunday1500);
            SqlCommandBuilder comandbuilderOplSunday1500 = new SqlCommandBuilder(DbClass.daOplSunday1500);


            //16:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM sunday1600;";
            DbClass.cmdSunday1600.CommandType = CommandType.Text;
            DbClass.cmdSunday1600.CommandText = DbClass.sqlusers;
            DbClass.daSunday1600 = new SqlDataAdapter(DbClass.cmdSunday1600);
            DbClass.dtSunday1600 = new DataTable();
            DbClass.daSunday1600.Fill(DbClass.dtSunday1600);
            SqlCommandBuilder comandbuilderSunday1600 = new SqlCommandBuilder(DbClass.daSunday1600);


            //оплата
            DbClass.sqlusers = "SELECT * FROM sundayOplata1600;";
            DbClass.cmdOplSunday1600.CommandType = CommandType.Text;
            DbClass.cmdOplSunday1600.CommandText = DbClass.sqlusers;
            DbClass.daOplSunday1600 = new SqlDataAdapter(DbClass.cmdOplSunday1600);
            DbClass.dtOplSunday1600 = new DataTable();
            DbClass.daOplSunday1600.Fill(DbClass.dtOplSunday1600);
            SqlCommandBuilder comandbuilderOplSunday1600 = new SqlCommandBuilder(DbClass.daOplSunday1600);



            //17:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM sunday1700;";
            DbClass.cmdSunday1700.CommandType = CommandType.Text;
            DbClass.cmdSunday1700.CommandText = DbClass.sqlusers;
            DbClass.daSunday1700 = new SqlDataAdapter(DbClass.cmdSunday1700);
            DbClass.dtSunday1700 = new DataTable();
            DbClass.daSunday1700.Fill(DbClass.dtSunday1700);
            SqlCommandBuilder comandbuilderSunday1700 = new SqlCommandBuilder(DbClass.daSunday1700);

            //оплата
            DbClass.sqlusers = "SELECT * FROM sundayOplata1700;";
            DbClass.cmdOplSunday1700.CommandType = CommandType.Text;
            DbClass.cmdOplSunday1700.CommandText = DbClass.sqlusers;
            DbClass.daOplSunday1700 = new SqlDataAdapter(DbClass.cmdOplSunday1700);
            DbClass.dtOplSunday1700 = new DataTable();
            DbClass.daOplSunday1700.Fill(DbClass.dtOplSunday1700);
            SqlCommandBuilder comandbuilderOplSunday1700 = new SqlCommandBuilder(DbClass.daOplSunday1700);

            //18:10----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM sunday1810;";
            DbClass.cmdSunday1810.CommandType = CommandType.Text;
            DbClass.cmdSunday1810.CommandText = DbClass.sqlusers;
            DbClass.daSunday1810 = new SqlDataAdapter(DbClass.cmdSunday1810);
            DbClass.dtSunday1810 = new DataTable();
            DbClass.daSunday1810.Fill(DbClass.dtSunday1810);
            SqlCommandBuilder comandbuilderSunday1810 = new SqlCommandBuilder(DbClass.daSunday1810);

            //оплата
            DbClass.sqlusers = "SELECT * FROM sundayOplata1810;";
            DbClass.cmdOplSunday1810.CommandType = CommandType.Text;
            DbClass.cmdOplSunday1810.CommandText = DbClass.sqlusers;
            DbClass.daOplSunday1810 = new SqlDataAdapter(DbClass.cmdOplSunday1810);
            DbClass.dtOplSunday1810 = new DataTable();
            DbClass.daOplSunday1810.Fill(DbClass.dtOplSunday1810);
            SqlCommandBuilder comandbuilderOplSunday1810 = new SqlCommandBuilder(DbClass.daOplSunday1810);

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



        private void TabItemOplataSunday1400_Selected(object sender, RoutedEventArgs e)
        {
            //14:00----------------------------------------------------------------------------------

            rename_Columns();

        }



        private void myDataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            myDataGridSunday1400.ItemsSource = DbClass.dtSunday1400.DefaultView;
            myDataGridOplataSunday1400.ItemsSource = DbClass.dtOplSunday1400.DefaultView;

            myDataGridSunday1500.ItemsSource = DbClass.dtSunday1500.DefaultView;
            myDataGridOplataSunday1500.ItemsSource = DbClass.dtOplSunday1500.DefaultView;

            myDataGridSunday1600.ItemsSource = DbClass.dtSunday1600.DefaultView;
            myDataGridOplataSunday1600.ItemsSource = DbClass.dtOplSunday1600.DefaultView;

            myDataGridSunday1700.ItemsSource = DbClass.dtSunday1700.DefaultView;
            myDataGridOplataSunday1700.ItemsSource = DbClass.dtOplSunday1700.DefaultView;

            myDataGridSunday1810.ItemsSource = DbClass.dtSunday1810.DefaultView;
            myDataGridOplataSunday1810.ItemsSource = DbClass.dtOplSunday1810.DefaultView;

            count_Plus();
            rename_Columns();
        }

        private void myDataGridSunday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSunday1400.Update(DbClass.dtSunday1400);

        }

        private void myDataGridSunday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSunday1500.Update(DbClass.dtSunday1500);
        }

        private void myDataGridSunday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSunday1600.Update(DbClass.dtSunday1600);
        }

        private void myDataGridSunday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSunday1700.Update(DbClass.dtSunday1700);
        }

        private void myDataGridSunday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSunday1810.Update(DbClass.dtSunday1810);
        }

        private void myDataGridOplataSunday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSunday1400.Update(DbClass.dtOplSunday1400);
        }

        private void myDataGridOplataSunday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSunday1500.Update(DbClass.dtOplSunday1500);
        }

        private void myDataGridOplataSunday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSunday1600.Update(DbClass.dtOplSunday1600);
        }

        private void myDataGridOplataSunday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSunday1700.Update(DbClass.dtOplSunday1700);
        }

        private void myDataGridOplataSunday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSunday1810.Update(DbClass.dtOplSunday1810);
        }
    }
}