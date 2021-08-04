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
    /// Логика взаимодействия для Saturday.xaml
    /// </summary>
    public partial class Saturday : Window
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
                SqlCommandBuilder comandbuilderSaturday1400 = new SqlCommandBuilder(DbClass.daSaturday1400);
                DbClass.cmdSaturday1400.CommandText = "ALTER TABLE Saturday1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSaturday1400.ExecuteNonQuery();
                DbClass.cmdSaturday1400.CommandText = "UPDATE Saturday1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSaturday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1400;";
                DbClass.cmdSaturday1400.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1400 = new DataTable();
                DbClass.daSaturday1400.Fill(DbClass.dtSaturday1400);
                myDataGridSaturday1400.ItemsSource = DbClass.dtSaturday1400.DefaultView;
                DbClass.daSaturday1400.Update(DbClass.dtSaturday1400);

                SqlCommandBuilder comandbuilderOplSaturday1400 = new SqlCommandBuilder(DbClass.daOplSaturday1400);
                DbClass.cmdOplSaturday1400.CommandText = "ALTER TABLE SaturdayOplata1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSaturday1400.ExecuteNonQuery();
                DbClass.cmdOplSaturday1400.CommandText = "UPDATE SaturdayOplata1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSaturday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1400;";
                DbClass.cmdOplSaturday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1400 = new DataTable();
                DbClass.daOplSaturday1400.Fill(DbClass.dtOplSaturday1400);
                myDataGridOplataSaturday1400.ItemsSource = DbClass.dtOplSaturday1400.DefaultView;
                DbClass.daOplSaturday1400.Update(DbClass.dtOplSaturday1400);


                //15:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSaturday1500 = new SqlCommandBuilder(DbClass.daSaturday1500);
                DbClass.cmdSaturday1500.CommandText = "ALTER TABLE Saturday1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSaturday1500.ExecuteNonQuery();
                DbClass.cmdSaturday1500.CommandText = "UPDATE Saturday1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSaturday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1500;";
                DbClass.cmdSaturday1500.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1500 = new DataTable();
                DbClass.daSaturday1500.Fill(DbClass.dtSaturday1500);
                myDataGridSaturday1500.ItemsSource = DbClass.dtSaturday1500.DefaultView;
                DbClass.daSaturday1500.Update(DbClass.dtSaturday1500);

                SqlCommandBuilder comandbuilderOplSaturday1500 = new SqlCommandBuilder(DbClass.daOplSaturday1500);
                DbClass.cmdOplSaturday1500.CommandText = "ALTER TABLE SaturdayOplata1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSaturday1500.ExecuteNonQuery();
                DbClass.cmdOplSaturday1500.CommandText = "UPDATE SaturdayOplata1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSaturday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1500;";
                DbClass.cmdOplSaturday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1500 = new DataTable();
                DbClass.daOplSaturday1500.Fill(DbClass.dtOplSaturday1500);
                myDataGridOplataSaturday1500.ItemsSource = DbClass.dtOplSaturday1500.DefaultView;
                DbClass.daOplSaturday1500.Update(DbClass.dtOplSaturday1500);

                //16:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSaturday1600 = new SqlCommandBuilder(DbClass.daSaturday1600);
                DbClass.cmdSaturday1600.CommandText = "ALTER TABLE Saturday1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSaturday1600.ExecuteNonQuery();
                DbClass.cmdSaturday1600.CommandText = "UPDATE Saturday1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSaturday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1600;";
                DbClass.cmdSaturday1600.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1600 = new DataTable();
                DbClass.daSaturday1600.Fill(DbClass.dtSaturday1600);
                myDataGridSaturday1600.ItemsSource = DbClass.dtSaturday1600.DefaultView;
                DbClass.daSaturday1600.Update(DbClass.dtSaturday1600);

                SqlCommandBuilder comandbuilderOplSaturday1600 = new SqlCommandBuilder(DbClass.daOplSaturday1600);
                DbClass.cmdOplSaturday1600.CommandText = "ALTER TABLE SaturdayOplata1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSaturday1600.ExecuteNonQuery();
                DbClass.cmdOplSaturday1600.CommandText = "UPDATE SaturdayOplata1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSaturday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1600;";
                DbClass.cmdOplSaturday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1600 = new DataTable();
                DbClass.daOplSaturday1600.Fill(DbClass.dtOplSaturday1600);
                myDataGridOplataSaturday1600.ItemsSource = DbClass.dtOplSaturday1600.DefaultView;
                DbClass.daOplSaturday1600.Update(DbClass.dtOplSaturday1600);

                //17:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSaturday1700 = new SqlCommandBuilder(DbClass.daSaturday1700);
                DbClass.cmdSaturday1700.CommandText = "ALTER TABLE Saturday1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSaturday1700.ExecuteNonQuery();
                DbClass.cmdSaturday1700.CommandText = "UPDATE Saturday1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSaturday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1700;";
                DbClass.cmdSaturday1700.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1700 = new DataTable();
                DbClass.daSaturday1700.Fill(DbClass.dtSaturday1700);
                myDataGridSaturday1700.ItemsSource = DbClass.dtSaturday1700.DefaultView;
                DbClass.daSaturday1700.Update(DbClass.dtSaturday1700);

                SqlCommandBuilder comandbuilderOplSaturday1700 = new SqlCommandBuilder(DbClass.daOplSaturday1700);
                DbClass.cmdOplSaturday1700.CommandText = "ALTER TABLE SaturdayOplata1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSaturday1700.ExecuteNonQuery();
                DbClass.cmdOplSaturday1700.CommandText = "UPDATE SaturdayOplata1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSaturday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1700;";
                DbClass.cmdOplSaturday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1700 = new DataTable();
                DbClass.daOplSaturday1700.Fill(DbClass.dtOplSaturday1700);
                myDataGridOplataSaturday1700.ItemsSource = DbClass.dtOplSaturday1700.DefaultView;
                DbClass.daOplSaturday1700.Update(DbClass.dtOplSaturday1700);

                //18:10--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSaturday1810 = new SqlCommandBuilder(DbClass.daSaturday1810);
                DbClass.cmdSaturday1810.CommandText = "ALTER TABLE Saturday1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdSaturday1810.ExecuteNonQuery();
                DbClass.cmdSaturday1810.CommandText = "UPDATE Saturday1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdSaturday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1810;";
                DbClass.cmdSaturday1810.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1810 = new DataTable();
                DbClass.daSaturday1810.Fill(DbClass.dtSaturday1810);
                myDataGridSaturday1810.ItemsSource = DbClass.dtSaturday1810.DefaultView;
                DbClass.daSaturday1810.Update(DbClass.dtSaturday1810);

                SqlCommandBuilder comandbuilderOplSaturday1810 = new SqlCommandBuilder(DbClass.daOplSaturday1810);
                DbClass.cmdOplSaturday1810.CommandText = "ALTER TABLE SaturdayOplata1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplSaturday1810.ExecuteNonQuery();
                DbClass.cmdOplSaturday1810.CommandText = "UPDATE SaturdayOplata1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplSaturday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1810;";
                DbClass.cmdOplSaturday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1810 = new DataTable();
                DbClass.daOplSaturday1810.Fill(DbClass.dtOplSaturday1810);
                myDataGridOplataSaturday1810.ItemsSource = DbClass.dtOplSaturday1810.DefaultView;
                DbClass.daOplSaturday1810.Update(DbClass.dtOplSaturday1810);

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
                SqlCommandBuilder comandbuilderSaturday1400 = new SqlCommandBuilder(DbClass.daSaturday1400);
                DbClass.cmdSaturday1400.CommandText = "ALTER TABLE Saturday1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSaturday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1400;";
                DbClass.cmdSaturday1400.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1400 = new DataTable();
                DbClass.daSaturday1400.Fill(DbClass.dtSaturday1400);
                myDataGridSaturday1400.ItemsSource = DbClass.dtSaturday1400.DefaultView;
                DbClass.daSaturday1400.Update(DbClass.dtSaturday1400);

                SqlCommandBuilder comandbuilderOplSaturday1400 = new SqlCommandBuilder(DbClass.daOplSaturday1400);
                DbClass.cmdOplSaturday1400.CommandText = "ALTER TABLE SaturdayOplata1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSaturday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1400;";
                DbClass.cmdOplSaturday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1400 = new DataTable();
                DbClass.daOplSaturday1400.Fill(DbClass.dtOplSaturday1400);
                myDataGridOplataSaturday1400.ItemsSource = DbClass.dtOplSaturday1400.DefaultView;
                DbClass.daOplSaturday1400.Update(DbClass.dtOplSaturday1400);


                //15:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSaturday1500 = new SqlCommandBuilder(DbClass.daSaturday1500);
                DbClass.cmdSaturday1500.CommandText = "ALTER TABLE Saturday1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSaturday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1500;";
                DbClass.cmdSaturday1500.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1500 = new DataTable();
                DbClass.daSaturday1500.Fill(DbClass.dtSaturday1500);
                myDataGridSaturday1500.ItemsSource = DbClass.dtSaturday1500.DefaultView;
                DbClass.daSaturday1500.Update(DbClass.dtSaturday1500);

                SqlCommandBuilder comandbuilderOplSaturday1500 = new SqlCommandBuilder(DbClass.daOplSaturday1500);
                DbClass.cmdOplSaturday1500.CommandText = "ALTER TABLE SaturdayOplata1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSaturday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1500;";
                DbClass.cmdOplSaturday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1500 = new DataTable();
                DbClass.daOplSaturday1500.Fill(DbClass.dtOplSaturday1500);
                myDataGridOplataSaturday1500.ItemsSource = DbClass.dtOplSaturday1500.DefaultView;
                DbClass.daOplSaturday1500.Update(DbClass.dtOplSaturday1500);


                //16:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSaturday1600 = new SqlCommandBuilder(DbClass.daSaturday1600);
                DbClass.cmdSaturday1600.CommandText = "ALTER TABLE Saturday1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSaturday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1600;";
                DbClass.cmdSaturday1600.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1600 = new DataTable();
                DbClass.daSaturday1600.Fill(DbClass.dtSaturday1600);
                myDataGridSaturday1600.ItemsSource = DbClass.dtSaturday1600.DefaultView;
                DbClass.daSaturday1600.Update(DbClass.dtSaturday1600);

                SqlCommandBuilder comandbuilderOplSaturday1600 = new SqlCommandBuilder(DbClass.daOplSaturday1600);
                DbClass.cmdOplSaturday1600.CommandText = "ALTER TABLE SaturdayOplata1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSaturday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1600;";
                DbClass.cmdOplSaturday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1600 = new DataTable();
                DbClass.daOplSaturday1600.Fill(DbClass.dtOplSaturday1600);
                myDataGridOplataSaturday1600.ItemsSource = DbClass.dtOplSaturday1600.DefaultView;
                DbClass.daOplSaturday1600.Update(DbClass.dtOplSaturday1600);


                //17:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSaturday1700 = new SqlCommandBuilder(DbClass.daSaturday1700);
                DbClass.cmdSaturday1700.CommandText = "ALTER TABLE Saturday1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSaturday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1700;";
                DbClass.cmdSaturday1700.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1700 = new DataTable();
                DbClass.daSaturday1700.Fill(DbClass.dtSaturday1700);
                myDataGridSaturday1700.ItemsSource = DbClass.dtSaturday1700.DefaultView;
                DbClass.daSaturday1700.Update(DbClass.dtSaturday1700);

                SqlCommandBuilder comandbuilderOplSaturday1700 = new SqlCommandBuilder(DbClass.daOplSaturday1700);
                DbClass.cmdOplSaturday1700.CommandText = "ALTER TABLE SaturdayOplata1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSaturday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1700;";
                DbClass.cmdOplSaturday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1700 = new DataTable();
                DbClass.daOplSaturday1700.Fill(DbClass.dtOplSaturday1700);
                myDataGridOplataSaturday1700.ItemsSource = DbClass.dtOplSaturday1700.DefaultView;
                DbClass.daOplSaturday1700.Update(DbClass.dtOplSaturday1700);


                //18:10-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderSaturday1810 = new SqlCommandBuilder(DbClass.daSaturday1810);
                DbClass.cmdSaturday1810.CommandText = "ALTER TABLE Saturday1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdSaturday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Saturday1810;";
                DbClass.cmdSaturday1810.CommandText = DbClass.sqlusers;
                DbClass.dtSaturday1810 = new DataTable();
                DbClass.daSaturday1810.Fill(DbClass.dtSaturday1810);
                myDataGridSaturday1810.ItemsSource = DbClass.dtSaturday1810.DefaultView;
                DbClass.daSaturday1810.Update(DbClass.dtSaturday1810);

                SqlCommandBuilder comandbuilderOplSaturday1810 = new SqlCommandBuilder(DbClass.daOplSaturday1810);
                DbClass.cmdOplSaturday1810.CommandText = "ALTER TABLE SaturdayOplata1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplSaturday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM SaturdayOplata1810;";
                DbClass.cmdOplSaturday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplSaturday1810 = new DataTable();
                DbClass.daOplSaturday1810.Fill(DbClass.dtOplSaturday1810);
                myDataGridOplataSaturday1810.ItemsSource = DbClass.dtOplSaturday1810.DefaultView;
                DbClass.daOplSaturday1810.Update(DbClass.dtOplSaturday1810);

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

                myDataGridSaturday1400.Columns[0].Header = "Залишок";
                myDataGridSaturday1400.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSaturday1400.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSaturday1400.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSaturday1400.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSaturday1400.Columns[i].Header = column_header;
                }


            }
            catch (Exception)
            {

                //
            }
            //оплата-------------------------------------------------------------------
            try
            {
                myDataGridOplataSaturday1400.Columns[0].Header = "Оплачено";
                myDataGridOplataSaturday1400.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSaturday1400.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSaturday1400.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSaturday1400.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSaturday1400.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                //
            }
            //15:00--------------------------------------------------------------------
            try
            {

                myDataGridSaturday1500.Columns[0].Header = "Залишок";
                myDataGridSaturday1500.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSaturday1500.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSaturday1500.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSaturday1500.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSaturday1500.Columns[i].Header = column_header;
                }

                myDataGridOplataSaturday1500.Columns[0].Header = "Оплачено";
                myDataGridOplataSaturday1500.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSaturday1500.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSaturday1500.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSaturday1500.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSaturday1500.Columns[j].Header = column_header;

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
                myDataGridSaturday1600.Columns[0].Header = "Залишок";
                myDataGridSaturday1600.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSaturday1600.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSaturday1600.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSaturday1600.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSaturday1600.Columns[i].Header = column_header;
                }

                myDataGridOplataSaturday1600.Columns[0].Header = "Оплачено";
                myDataGridOplataSaturday1600.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSaturday1600.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSaturday1600.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSaturday1600.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSaturday1600.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename16");

            }

            //17:00--------------------------------------------------------------------
            try
            {
                myDataGridSaturday1700.Columns[0].Header = "Залишок";
                myDataGridSaturday1700.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSaturday1700.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSaturday1700.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSaturday1700.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSaturday1700.Columns[i].Header = column_header;
                }


                myDataGridOplataSaturday1700.Columns[0].Header = "Оплачено";
                myDataGridOplataSaturday1700.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSaturday1700.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSaturday1700.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSaturday1700.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSaturday1700.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename17");

            }

            //18:10--------------------------------------------------------------------
            try
            {
                myDataGridSaturday1810.Columns[0].Header = "Залишок";
                myDataGridSaturday1810.Columns[1].Header = "ПІБ";
                for (int i = myDataGridSaturday1810.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridSaturday1810.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridSaturday1810.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridSaturday1810.Columns[i].Header = column_header;
                }


                myDataGridOplataSaturday1810.Columns[0].Header = "Оплачено";
                myDataGridOplataSaturday1810.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataSaturday1810.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataSaturday1810.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataSaturday1810.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataSaturday1810.Columns[j].Header = column_header;

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
                for (int i = 0; i < myDataGridOplataSaturday1400.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSaturday1400.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSaturday1400.Rows[i][j].ToString());
                        DbClass.dtOplSaturday1400.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSaturday1400.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSaturday1400.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSaturday1400.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSaturday1400.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSaturday1400.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }
            //15:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataSaturday1500.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSaturday1500.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSaturday1500.Rows[i][j].ToString());
                        DbClass.dtOplSaturday1500.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSaturday1500.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSaturday1500.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSaturday1500.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSaturday1500.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSaturday1500.Rows[i][0] = temp.ToString().Trim();


                }


            }
            catch (Exception)
            {
                //
            }

            //16:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataSaturday1600.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSaturday1600.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSaturday1600.Rows[i][j].ToString());
                        DbClass.dtOplSaturday1600.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSaturday1600.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSaturday1600.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSaturday1600.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSaturday1600.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSaturday1600.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }

            //17:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataSaturday1700.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSaturday1700.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSaturday1700.Rows[i][j].ToString());
                        DbClass.dtOplSaturday1700.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSaturday1700.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSaturday1700.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSaturday1700.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSaturday1700.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSaturday1700.Rows[i][0] = temp.ToString().Trim();


                }
            }
            catch (Exception)
            {
                //
            }

            //18:10-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataSaturday1810.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataSaturday1810.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplSaturday1810.Rows[i][j].ToString());
                        DbClass.dtOplSaturday1810.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridSaturday1810.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridSaturday1810.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtSaturday1810.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplSaturday1810.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtSaturday1810.Rows[i][0] = temp.ToString().Trim();


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

        public Saturday()
        {
            InitializeComponent();

            //вівторок-----------------------------------------------------------------------------------
            //14:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM saturday1400;";
            DbClass.cmdSaturday1400.CommandType = CommandType.Text;
            DbClass.cmdSaturday1400.CommandText = DbClass.sqlusers;
            DbClass.daSaturday1400 = new SqlDataAdapter(DbClass.cmdSaturday1400);
            DbClass.dtSaturday1400 = new DataTable();
            DbClass.daSaturday1400.Fill(DbClass.dtSaturday1400);
            SqlCommandBuilder comandbuilderSaturday1400 = new SqlCommandBuilder(DbClass.daSaturday1400);

            //оплата
            DbClass.sqlusers = "SELECT * FROM saturdayOplata1400;";
            DbClass.cmdOplSaturday1400.CommandType = CommandType.Text;
            DbClass.cmdOplSaturday1400.CommandText = DbClass.sqlusers;
            DbClass.daOplSaturday1400 = new SqlDataAdapter(DbClass.cmdOplSaturday1400);
            DbClass.dtOplSaturday1400 = new DataTable();
            DbClass.daOplSaturday1400.Fill(DbClass.dtOplSaturday1400);
            SqlCommandBuilder comandbuilderOplSaturday1400 = new SqlCommandBuilder(DbClass.daOplSaturday1400);

            //15:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM saturday1500;";
            DbClass.cmdSaturday1500.CommandType = CommandType.Text;
            DbClass.cmdSaturday1500.CommandText = DbClass.sqlusers;
            DbClass.daSaturday1500 = new SqlDataAdapter(DbClass.cmdSaturday1500);
            DbClass.dtSaturday1500 = new DataTable();
            DbClass.daSaturday1500.Fill(DbClass.dtSaturday1500);
            SqlCommandBuilder comandbuilderSaturday1500 = new SqlCommandBuilder(DbClass.daSaturday1500);

            //оплата
            DbClass.sqlusers = "SELECT * FROM saturdayOplata1500;";
            DbClass.cmdOplSaturday1500.CommandType = CommandType.Text;
            DbClass.cmdOplSaturday1500.CommandText = DbClass.sqlusers;
            DbClass.daOplSaturday1500 = new SqlDataAdapter(DbClass.cmdOplSaturday1500);
            DbClass.dtOplSaturday1500 = new DataTable();
            DbClass.daOplSaturday1500.Fill(DbClass.dtOplSaturday1500);
            SqlCommandBuilder comandbuilderOplSaturday1500 = new SqlCommandBuilder(DbClass.daOplSaturday1500);


            //16:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM saturday1600;";
            DbClass.cmdSaturday1600.CommandType = CommandType.Text;
            DbClass.cmdSaturday1600.CommandText = DbClass.sqlusers;
            DbClass.daSaturday1600 = new SqlDataAdapter(DbClass.cmdSaturday1600);
            DbClass.dtSaturday1600 = new DataTable();
            DbClass.daSaturday1600.Fill(DbClass.dtSaturday1600);
            SqlCommandBuilder comandbuilderSaturday1600 = new SqlCommandBuilder(DbClass.daSaturday1600);


            //оплата
            DbClass.sqlusers = "SELECT * FROM saturdayOplata1600;";
            DbClass.cmdOplSaturday1600.CommandType = CommandType.Text;
            DbClass.cmdOplSaturday1600.CommandText = DbClass.sqlusers;
            DbClass.daOplSaturday1600 = new SqlDataAdapter(DbClass.cmdOplSaturday1600);
            DbClass.dtOplSaturday1600 = new DataTable();
            DbClass.daOplSaturday1600.Fill(DbClass.dtOplSaturday1600);
            SqlCommandBuilder comandbuilderOplSaturday1600 = new SqlCommandBuilder(DbClass.daOplSaturday1600);



            //17:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM saturday1700;";
            DbClass.cmdSaturday1700.CommandType = CommandType.Text;
            DbClass.cmdSaturday1700.CommandText = DbClass.sqlusers;
            DbClass.daSaturday1700 = new SqlDataAdapter(DbClass.cmdSaturday1700);
            DbClass.dtSaturday1700 = new DataTable();
            DbClass.daSaturday1700.Fill(DbClass.dtSaturday1700);
            SqlCommandBuilder comandbuilderSaturday1700 = new SqlCommandBuilder(DbClass.daSaturday1700);

            //оплата
            DbClass.sqlusers = "SELECT * FROM saturdayOplata1700;";
            DbClass.cmdOplSaturday1700.CommandType = CommandType.Text;
            DbClass.cmdOplSaturday1700.CommandText = DbClass.sqlusers;
            DbClass.daOplSaturday1700 = new SqlDataAdapter(DbClass.cmdOplSaturday1700);
            DbClass.dtOplSaturday1700 = new DataTable();
            DbClass.daOplSaturday1700.Fill(DbClass.dtOplSaturday1700);
            SqlCommandBuilder comandbuilderOplSaturday1700 = new SqlCommandBuilder(DbClass.daOplSaturday1700);

            //18:10----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM saturday1810;";
            DbClass.cmdSaturday1810.CommandType = CommandType.Text;
            DbClass.cmdSaturday1810.CommandText = DbClass.sqlusers;
            DbClass.daSaturday1810 = new SqlDataAdapter(DbClass.cmdSaturday1810);
            DbClass.dtSaturday1810 = new DataTable();
            DbClass.daSaturday1810.Fill(DbClass.dtSaturday1810);
            SqlCommandBuilder comandbuilderSaturday1810 = new SqlCommandBuilder(DbClass.daSaturday1810);

            //оплата
            DbClass.sqlusers = "SELECT * FROM saturdayOplata1810;";
            DbClass.cmdOplSaturday1810.CommandType = CommandType.Text;
            DbClass.cmdOplSaturday1810.CommandText = DbClass.sqlusers;
            DbClass.daOplSaturday1810 = new SqlDataAdapter(DbClass.cmdOplSaturday1810);
            DbClass.dtOplSaturday1810 = new DataTable();
            DbClass.daOplSaturday1810.Fill(DbClass.dtOplSaturday1810);
            SqlCommandBuilder comandbuilderOplSaturday1810 = new SqlCommandBuilder(DbClass.daOplSaturday1810);

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



        private void TabItemOplataSaturday1400_Selected(object sender, RoutedEventArgs e)
        {
            //14:00----------------------------------------------------------------------------------

            rename_Columns();

        }



        private void myDataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            myDataGridSaturday1400.ItemsSource = DbClass.dtSaturday1400.DefaultView;
            myDataGridOplataSaturday1400.ItemsSource = DbClass.dtOplSaturday1400.DefaultView;

            myDataGridSaturday1500.ItemsSource = DbClass.dtSaturday1500.DefaultView;
            myDataGridOplataSaturday1500.ItemsSource = DbClass.dtOplSaturday1500.DefaultView;

            myDataGridSaturday1600.ItemsSource = DbClass.dtSaturday1600.DefaultView;
            myDataGridOplataSaturday1600.ItemsSource = DbClass.dtOplSaturday1600.DefaultView;

            myDataGridSaturday1700.ItemsSource = DbClass.dtSaturday1700.DefaultView;
            myDataGridOplataSaturday1700.ItemsSource = DbClass.dtOplSaturday1700.DefaultView;

            myDataGridSaturday1810.ItemsSource = DbClass.dtSaturday1810.DefaultView;
            myDataGridOplataSaturday1810.ItemsSource = DbClass.dtOplSaturday1810.DefaultView;

            count_Plus();
            rename_Columns();
        }

        private void myDataGridSaturday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSaturday1400.Update(DbClass.dtSaturday1400);

        }

        private void myDataGridSaturday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSaturday1500.Update(DbClass.dtSaturday1500);
        }

        private void myDataGridSaturday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSaturday1600.Update(DbClass.dtSaturday1600);
        }

        private void myDataGridSaturday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSaturday1700.Update(DbClass.dtSaturday1700);
        }

        private void myDataGridSaturday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daSaturday1810.Update(DbClass.dtSaturday1810);
        }

        private void myDataGridOplataSaturday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSaturday1400.Update(DbClass.dtOplSaturday1400);
        }

        private void myDataGridOplataSaturday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSaturday1500.Update(DbClass.dtOplSaturday1500);
        }

        private void myDataGridOplataSaturday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSaturday1600.Update(DbClass.dtOplSaturday1600);
        }

        private void myDataGridOplataSaturday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSaturday1700.Update(DbClass.dtOplSaturday1700);
        }

        private void myDataGridOplataSaturday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplSaturday1810.Update(DbClass.dtOplSaturday1810);
        }
    }
}