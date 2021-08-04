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
    /// Логика взаимодействия для Tuesday.xaml
    /// </summary>
    public partial class Tuesday : Window
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
                SqlCommandBuilder comandbuilderTuesday1400 = new SqlCommandBuilder(DbClass.daTuesday1400);
                DbClass.cmdTuesday1400.CommandText = "ALTER TABLE Tuesday1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdTuesday1400.ExecuteNonQuery();
                DbClass.cmdTuesday1400.CommandText = "UPDATE Tuesday1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdTuesday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1400;";
                DbClass.cmdTuesday1400.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1400 = new DataTable();
                DbClass.daTuesday1400.Fill(DbClass.dtTuesday1400);
                myDataGridTuesday1400.ItemsSource = DbClass.dtTuesday1400.DefaultView;
                DbClass.daTuesday1400.Update(DbClass.dtTuesday1400);

                SqlCommandBuilder comandbuilderOplTuesday1400 = new SqlCommandBuilder(DbClass.daOplTuesday1400);
                DbClass.cmdOplTuesday1400.CommandText = "ALTER TABLE TuesdayOplata1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplTuesday1400.ExecuteNonQuery();
                DbClass.cmdOplTuesday1400.CommandText = "UPDATE TuesdayOplata1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplTuesday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1400;";
                DbClass.cmdOplTuesday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1400 = new DataTable();
                DbClass.daOplTuesday1400.Fill(DbClass.dtOplTuesday1400);
                myDataGridOplataTuesday1400.ItemsSource = DbClass.dtOplTuesday1400.DefaultView;
                DbClass.daOplTuesday1400.Update(DbClass.dtOplTuesday1400);


                //15:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderTuesday1500 = new SqlCommandBuilder(DbClass.daTuesday1500);
                DbClass.cmdTuesday1500.CommandText = "ALTER TABLE Tuesday1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdTuesday1500.ExecuteNonQuery();
                DbClass.cmdTuesday1500.CommandText = "UPDATE Tuesday1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdTuesday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1500;";
                DbClass.cmdTuesday1500.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1500 = new DataTable();
                DbClass.daTuesday1500.Fill(DbClass.dtTuesday1500);
                myDataGridTuesday1500.ItemsSource = DbClass.dtTuesday1500.DefaultView;
                DbClass.daTuesday1500.Update(DbClass.dtTuesday1500);

                SqlCommandBuilder comandbuilderOplTuesday1500 = new SqlCommandBuilder(DbClass.daOplTuesday1500);
                DbClass.cmdOplTuesday1500.CommandText = "ALTER TABLE TuesdayOplata1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplTuesday1500.ExecuteNonQuery();
                DbClass.cmdOplTuesday1500.CommandText = "UPDATE TuesdayOplata1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplTuesday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1500;";
                DbClass.cmdOplTuesday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1500 = new DataTable();
                DbClass.daOplTuesday1500.Fill(DbClass.dtOplTuesday1500);
                myDataGridOplataTuesday1500.ItemsSource = DbClass.dtOplTuesday1500.DefaultView;
                DbClass.daOplTuesday1500.Update(DbClass.dtOplTuesday1500);

                //16:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderTuesday1600 = new SqlCommandBuilder(DbClass.daTuesday1600);
                DbClass.cmdTuesday1600.CommandText = "ALTER TABLE Tuesday1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdTuesday1600.ExecuteNonQuery();
                DbClass.cmdTuesday1600.CommandText = "UPDATE Tuesday1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdTuesday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1600;";
                DbClass.cmdTuesday1600.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1600 = new DataTable();
                DbClass.daTuesday1600.Fill(DbClass.dtTuesday1600);
                myDataGridTuesday1600.ItemsSource = DbClass.dtTuesday1600.DefaultView;
                DbClass.daTuesday1600.Update(DbClass.dtTuesday1600);

                SqlCommandBuilder comandbuilderOplTuesday1600 = new SqlCommandBuilder(DbClass.daOplTuesday1600);
                DbClass.cmdOplTuesday1600.CommandText = "ALTER TABLE TuesdayOplata1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplTuesday1600.ExecuteNonQuery();
                DbClass.cmdOplTuesday1600.CommandText = "UPDATE TuesdayOplata1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplTuesday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1600;";
                DbClass.cmdOplTuesday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1600 = new DataTable();
                DbClass.daOplTuesday1600.Fill(DbClass.dtOplTuesday1600);
                myDataGridOplataTuesday1600.ItemsSource = DbClass.dtOplTuesday1600.DefaultView;
                DbClass.daOplTuesday1600.Update(DbClass.dtOplTuesday1600);

                //17:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderTuesday1700 = new SqlCommandBuilder(DbClass.daTuesday1700);
                DbClass.cmdTuesday1700.CommandText = "ALTER TABLE Tuesday1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdTuesday1700.ExecuteNonQuery();
                DbClass.cmdTuesday1700.CommandText = "UPDATE Tuesday1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdTuesday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1700;";
                DbClass.cmdTuesday1700.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1700 = new DataTable();
                DbClass.daTuesday1700.Fill(DbClass.dtTuesday1700);
                myDataGridTuesday1700.ItemsSource = DbClass.dtTuesday1700.DefaultView;
                DbClass.daTuesday1700.Update(DbClass.dtTuesday1700);

                SqlCommandBuilder comandbuilderOplTuesday1700 = new SqlCommandBuilder(DbClass.daOplTuesday1700);
                DbClass.cmdOplTuesday1700.CommandText = "ALTER TABLE TuesdayOplata1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplTuesday1700.ExecuteNonQuery();
                DbClass.cmdOplTuesday1700.CommandText = "UPDATE TuesdayOplata1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplTuesday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1700;";
                DbClass.cmdOplTuesday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1700 = new DataTable();
                DbClass.daOplTuesday1700.Fill(DbClass.dtOplTuesday1700);
                myDataGridOplataTuesday1700.ItemsSource = DbClass.dtOplTuesday1700.DefaultView;
                DbClass.daOplTuesday1700.Update(DbClass.dtOplTuesday1700);

                //18:10--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderTuesday1810 = new SqlCommandBuilder(DbClass.daTuesday1810);
                DbClass.cmdTuesday1810.CommandText = "ALTER TABLE Tuesday1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdTuesday1810.ExecuteNonQuery();
                DbClass.cmdTuesday1810.CommandText = "UPDATE Tuesday1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdTuesday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1810;";
                DbClass.cmdTuesday1810.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1810 = new DataTable();
                DbClass.daTuesday1810.Fill(DbClass.dtTuesday1810);
                myDataGridTuesday1810.ItemsSource = DbClass.dtTuesday1810.DefaultView;
                DbClass.daTuesday1810.Update(DbClass.dtTuesday1810);

                SqlCommandBuilder comandbuilderOplTuesday1810 = new SqlCommandBuilder(DbClass.daOplTuesday1810);
                DbClass.cmdOplTuesday1810.CommandText = "ALTER TABLE TuesdayOplata1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplTuesday1810.ExecuteNonQuery();
                DbClass.cmdOplTuesday1810.CommandText = "UPDATE TuesdayOplata1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplTuesday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1810;";
                DbClass.cmdOplTuesday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1810 = new DataTable();
                DbClass.daOplTuesday1810.Fill(DbClass.dtOplTuesday1810);
                myDataGridOplataTuesday1810.ItemsSource = DbClass.dtOplTuesday1810.DefaultView;
                DbClass.daOplTuesday1810.Update(DbClass.dtOplTuesday1810);

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
                SqlCommandBuilder comandbuilderTuesday1400 = new SqlCommandBuilder(DbClass.daTuesday1400);
                DbClass.cmdTuesday1400.CommandText = "ALTER TABLE Tuesday1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdTuesday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1400;";
                DbClass.cmdTuesday1400.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1400 = new DataTable();
                DbClass.daTuesday1400.Fill(DbClass.dtTuesday1400);
                myDataGridTuesday1400.ItemsSource = DbClass.dtTuesday1400.DefaultView;
                DbClass.daTuesday1400.Update(DbClass.dtTuesday1400);

                SqlCommandBuilder comandbuilderOplTuesday1400 = new SqlCommandBuilder(DbClass.daOplTuesday1400);
                DbClass.cmdOplTuesday1400.CommandText = "ALTER TABLE TuesdayOplata1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplTuesday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1400;";
                DbClass.cmdOplTuesday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1400 = new DataTable();
                DbClass.daOplTuesday1400.Fill(DbClass.dtOplTuesday1400);
                myDataGridOplataTuesday1400.ItemsSource = DbClass.dtOplTuesday1400.DefaultView;
                DbClass.daOplTuesday1400.Update(DbClass.dtOplTuesday1400);


                //15:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderTuesday1500 = new SqlCommandBuilder(DbClass.daTuesday1500);
                DbClass.cmdTuesday1500.CommandText = "ALTER TABLE Tuesday1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdTuesday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1500;";
                DbClass.cmdTuesday1500.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1500 = new DataTable();
                DbClass.daTuesday1500.Fill(DbClass.dtTuesday1500);
                myDataGridTuesday1500.ItemsSource = DbClass.dtTuesday1500.DefaultView;
                DbClass.daTuesday1500.Update(DbClass.dtTuesday1500);

                SqlCommandBuilder comandbuilderOplTuesday1500 = new SqlCommandBuilder(DbClass.daOplTuesday1500);
                DbClass.cmdOplTuesday1500.CommandText = "ALTER TABLE TuesdayOplata1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplTuesday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1500;";
                DbClass.cmdOplTuesday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1500 = new DataTable();
                DbClass.daOplTuesday1500.Fill(DbClass.dtOplTuesday1500);
                myDataGridOplataTuesday1500.ItemsSource = DbClass.dtOplTuesday1500.DefaultView;
                DbClass.daOplTuesday1500.Update(DbClass.dtOplTuesday1500);


                //16:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderTuesday1600 = new SqlCommandBuilder(DbClass.daTuesday1600);
                DbClass.cmdTuesday1600.CommandText = "ALTER TABLE Tuesday1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdTuesday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1600;";
                DbClass.cmdTuesday1600.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1600 = new DataTable();
                DbClass.daTuesday1600.Fill(DbClass.dtTuesday1600);
                myDataGridTuesday1600.ItemsSource = DbClass.dtTuesday1600.DefaultView;
                DbClass.daTuesday1600.Update(DbClass.dtTuesday1600);

                SqlCommandBuilder comandbuilderOplTuesday1600 = new SqlCommandBuilder(DbClass.daOplTuesday1600);
                DbClass.cmdOplTuesday1600.CommandText = "ALTER TABLE TuesdayOplata1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplTuesday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1600;";
                DbClass.cmdOplTuesday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1600 = new DataTable();
                DbClass.daOplTuesday1600.Fill(DbClass.dtOplTuesday1600);
                myDataGridOplataTuesday1600.ItemsSource = DbClass.dtOplTuesday1600.DefaultView;
                DbClass.daOplTuesday1600.Update(DbClass.dtOplTuesday1600);


                //17:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderTuesday1700 = new SqlCommandBuilder(DbClass.daTuesday1700);
                DbClass.cmdTuesday1700.CommandText = "ALTER TABLE Tuesday1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdTuesday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1700;";
                DbClass.cmdTuesday1700.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1700 = new DataTable();
                DbClass.daTuesday1700.Fill(DbClass.dtTuesday1700);
                myDataGridTuesday1700.ItemsSource = DbClass.dtTuesday1700.DefaultView;
                DbClass.daTuesday1700.Update(DbClass.dtTuesday1700);

                SqlCommandBuilder comandbuilderOplTuesday1700 = new SqlCommandBuilder(DbClass.daOplTuesday1700);
                DbClass.cmdOplTuesday1700.CommandText = "ALTER TABLE TuesdayOplata1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplTuesday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1700;";
                DbClass.cmdOplTuesday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1700 = new DataTable();
                DbClass.daOplTuesday1700.Fill(DbClass.dtOplTuesday1700);
                myDataGridOplataTuesday1700.ItemsSource = DbClass.dtOplTuesday1700.DefaultView;
                DbClass.daOplTuesday1700.Update(DbClass.dtOplTuesday1700);


                //18:10-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderTuesday1810 = new SqlCommandBuilder(DbClass.daTuesday1810);
                DbClass.cmdTuesday1810.CommandText = "ALTER TABLE Tuesday1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdTuesday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Tuesday1810;";
                DbClass.cmdTuesday1810.CommandText = DbClass.sqlusers;
                DbClass.dtTuesday1810 = new DataTable();
                DbClass.daTuesday1810.Fill(DbClass.dtTuesday1810);
                myDataGridTuesday1810.ItemsSource = DbClass.dtTuesday1810.DefaultView;
                DbClass.daTuesday1810.Update(DbClass.dtTuesday1810);

                SqlCommandBuilder comandbuilderOplTuesday1810 = new SqlCommandBuilder(DbClass.daOplTuesday1810);
                DbClass.cmdOplTuesday1810.CommandText = "ALTER TABLE TuesdayOplata1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplTuesday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM TuesdayOplata1810;";
                DbClass.cmdOplTuesday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplTuesday1810 = new DataTable();
                DbClass.daOplTuesday1810.Fill(DbClass.dtOplTuesday1810);
                myDataGridOplataTuesday1810.ItemsSource = DbClass.dtOplTuesday1810.DefaultView;
                DbClass.daOplTuesday1810.Update(DbClass.dtOplTuesday1810);

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

                myDataGridTuesday1400.Columns[0].Header = "Залишок";
                myDataGridTuesday1400.Columns[1].Header = "ПІБ";
                for (int i = myDataGridTuesday1400.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridTuesday1400.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridTuesday1400.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridTuesday1400.Columns[i].Header = column_header;
                }


            }
            catch (Exception)
            {

                //
            }
            //оплата-------------------------------------------------------------------
            try
            {
                myDataGridOplataTuesday1400.Columns[0].Header = "Оплачено";
                myDataGridOplataTuesday1400.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataTuesday1400.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataTuesday1400.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataTuesday1400.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataTuesday1400.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                //
            }
            //15:00--------------------------------------------------------------------
            try
            {

                myDataGridTuesday1500.Columns[0].Header = "Залишок";
                myDataGridTuesday1500.Columns[1].Header = "ПІБ";
                for (int i = myDataGridTuesday1500.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridTuesday1500.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridTuesday1500.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridTuesday1500.Columns[i].Header = column_header;
                }

                myDataGridOplataTuesday1500.Columns[0].Header = "Оплачено";
                myDataGridOplataTuesday1500.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataTuesday1500.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataTuesday1500.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataTuesday1500.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataTuesday1500.Columns[j].Header = column_header;

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
                myDataGridTuesday1600.Columns[0].Header = "Залишок";
                myDataGridTuesday1600.Columns[1].Header = "ПІБ";
                for (int i = myDataGridTuesday1600.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridTuesday1600.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridTuesday1600.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridTuesday1600.Columns[i].Header = column_header;
                }

                myDataGridOplataTuesday1600.Columns[0].Header = "Оплачено";
                myDataGridOplataTuesday1600.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataTuesday1600.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataTuesday1600.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataTuesday1600.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataTuesday1600.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename16");

            }

            //17:00--------------------------------------------------------------------
            try
            {
                myDataGridTuesday1700.Columns[0].Header = "Залишок";
                myDataGridTuesday1700.Columns[1].Header = "ПІБ";
                for (int i = myDataGridTuesday1700.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridTuesday1700.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridTuesday1700.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridTuesday1700.Columns[i].Header = column_header;
                }


                myDataGridOplataTuesday1700.Columns[0].Header = "Оплачено";
                myDataGridOplataTuesday1700.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataTuesday1700.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataTuesday1700.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataTuesday1700.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataTuesday1700.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename17");

            }

            //18:10--------------------------------------------------------------------
            try
            {
                myDataGridTuesday1810.Columns[0].Header = "Залишок";
                myDataGridTuesday1810.Columns[1].Header = "ПІБ";
                for (int i = myDataGridTuesday1810.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridTuesday1810.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridTuesday1810.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridTuesday1810.Columns[i].Header = column_header;
                }


                myDataGridOplataTuesday1810.Columns[0].Header = "Оплачено";
                myDataGridOplataTuesday1810.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataTuesday1810.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataTuesday1810.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataTuesday1810.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataTuesday1810.Columns[j].Header = column_header;

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
                for (int i = 0; i < myDataGridOplataTuesday1400.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataTuesday1400.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplTuesday1400.Rows[i][j].ToString());
                        DbClass.dtOplTuesday1400.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridTuesday1400.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridTuesday1400.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtTuesday1400.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplTuesday1400.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtTuesday1400.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }
            //15:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataTuesday1500.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataTuesday1500.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplTuesday1500.Rows[i][j].ToString());
                        DbClass.dtOplTuesday1500.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridTuesday1500.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridTuesday1500.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtTuesday1500.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplTuesday1500.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtTuesday1500.Rows[i][0] = temp.ToString().Trim();


                }


            }
            catch (Exception)
            {
                //
            }

            //16:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataTuesday1600.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataTuesday1600.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplTuesday1600.Rows[i][j].ToString());
                        DbClass.dtOplTuesday1600.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridTuesday1600.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridTuesday1600.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtTuesday1600.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplTuesday1600.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtTuesday1600.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }

            //17:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataTuesday1700.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataTuesday1700.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplTuesday1700.Rows[i][j].ToString());
                        DbClass.dtOplTuesday1700.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridTuesday1700.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridTuesday1700.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtTuesday1700.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplTuesday1700.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtTuesday1700.Rows[i][0] = temp.ToString().Trim();


                }
            }
            catch (Exception)
            {
                //
            }

            //18:10-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataTuesday1810.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataTuesday1810.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplTuesday1810.Rows[i][j].ToString());
                        DbClass.dtOplTuesday1810.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridTuesday1810.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridTuesday1810.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtTuesday1810.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplTuesday1810.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtTuesday1810.Rows[i][0] = temp.ToString().Trim();


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

        public Tuesday()
        {
            InitializeComponent();

            //вівторок-----------------------------------------------------------------------------------
            //14:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM tuesday1400;";
            DbClass.cmdTuesday1400.CommandType = CommandType.Text;
            DbClass.cmdTuesday1400.CommandText = DbClass.sqlusers;
            DbClass.daTuesday1400 = new SqlDataAdapter(DbClass.cmdTuesday1400);
            DbClass.dtTuesday1400 = new DataTable();
            DbClass.daTuesday1400.Fill(DbClass.dtTuesday1400);
            SqlCommandBuilder comandbuilderTuesday1400 = new SqlCommandBuilder(DbClass.daTuesday1400);

            //оплата
            DbClass.sqlusers = "SELECT * FROM tuesdayOplata1400;";
            DbClass.cmdOplTuesday1400.CommandType = CommandType.Text;
            DbClass.cmdOplTuesday1400.CommandText = DbClass.sqlusers;
            DbClass.daOplTuesday1400 = new SqlDataAdapter(DbClass.cmdOplTuesday1400);
            DbClass.dtOplTuesday1400 = new DataTable();
            DbClass.daOplTuesday1400.Fill(DbClass.dtOplTuesday1400);
            SqlCommandBuilder comandbuilderOplTuesday1400 = new SqlCommandBuilder(DbClass.daOplTuesday1400);

            //15:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM tuesday1500;";
            DbClass.cmdTuesday1500.CommandType = CommandType.Text;
            DbClass.cmdTuesday1500.CommandText = DbClass.sqlusers;
            DbClass.daTuesday1500 = new SqlDataAdapter(DbClass.cmdTuesday1500);
            DbClass.dtTuesday1500 = new DataTable();
            DbClass.daTuesday1500.Fill(DbClass.dtTuesday1500);
            SqlCommandBuilder comandbuilderTuesday1500 = new SqlCommandBuilder(DbClass.daTuesday1500);

            //оплата
            DbClass.sqlusers = "SELECT * FROM tuesdayOplata1500;";
            DbClass.cmdOplTuesday1500.CommandType = CommandType.Text;
            DbClass.cmdOplTuesday1500.CommandText = DbClass.sqlusers;
            DbClass.daOplTuesday1500 = new SqlDataAdapter(DbClass.cmdOplTuesday1500);
            DbClass.dtOplTuesday1500 = new DataTable();
            DbClass.daOplTuesday1500.Fill(DbClass.dtOplTuesday1500);
            SqlCommandBuilder comandbuilderOplTuesday1500 = new SqlCommandBuilder(DbClass.daOplTuesday1500);


            //16:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM tuesday1600;";
            DbClass.cmdTuesday1600.CommandType = CommandType.Text;
            DbClass.cmdTuesday1600.CommandText = DbClass.sqlusers;
            DbClass.daTuesday1600 = new SqlDataAdapter(DbClass.cmdTuesday1600);
            DbClass.dtTuesday1600 = new DataTable();
            DbClass.daTuesday1600.Fill(DbClass.dtTuesday1600);
            SqlCommandBuilder comandbuilderTuesday1600 = new SqlCommandBuilder(DbClass.daTuesday1600);


            //оплата
            DbClass.sqlusers = "SELECT * FROM tuesdayOplata1600;";
            DbClass.cmdOplTuesday1600.CommandType = CommandType.Text;
            DbClass.cmdOplTuesday1600.CommandText = DbClass.sqlusers;
            DbClass.daOplTuesday1600 = new SqlDataAdapter(DbClass.cmdOplTuesday1600);
            DbClass.dtOplTuesday1600 = new DataTable();
            DbClass.daOplTuesday1600.Fill(DbClass.dtOplTuesday1600);
            SqlCommandBuilder comandbuilderOplTuesday1600 = new SqlCommandBuilder(DbClass.daOplTuesday1600);



            //17:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM tuesday1700;";
            DbClass.cmdTuesday1700.CommandType = CommandType.Text;
            DbClass.cmdTuesday1700.CommandText = DbClass.sqlusers;
            DbClass.daTuesday1700 = new SqlDataAdapter(DbClass.cmdTuesday1700);
            DbClass.dtTuesday1700 = new DataTable();
            DbClass.daTuesday1700.Fill(DbClass.dtTuesday1700);
            SqlCommandBuilder comandbuilderTuesday1700 = new SqlCommandBuilder(DbClass.daTuesday1700);

            //оплата
            DbClass.sqlusers = "SELECT * FROM tuesdayOplata1700;";
            DbClass.cmdOplTuesday1700.CommandType = CommandType.Text;
            DbClass.cmdOplTuesday1700.CommandText = DbClass.sqlusers;
            DbClass.daOplTuesday1700 = new SqlDataAdapter(DbClass.cmdOplTuesday1700);
            DbClass.dtOplTuesday1700 = new DataTable();
            DbClass.daOplTuesday1700.Fill(DbClass.dtOplTuesday1700);
            SqlCommandBuilder comandbuilderOplTuesday1700 = new SqlCommandBuilder(DbClass.daOplTuesday1700);

            //18:10----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM tuesday1810;";
            DbClass.cmdTuesday1810.CommandType = CommandType.Text;
            DbClass.cmdTuesday1810.CommandText = DbClass.sqlusers;
            DbClass.daTuesday1810 = new SqlDataAdapter(DbClass.cmdTuesday1810);
            DbClass.dtTuesday1810 = new DataTable();
            DbClass.daTuesday1810.Fill(DbClass.dtTuesday1810);
            SqlCommandBuilder comandbuilderTuesday1810 = new SqlCommandBuilder(DbClass.daTuesday1810);

            //оплата
            DbClass.sqlusers = "SELECT * FROM tuesdayOplata1810;";
            DbClass.cmdOplTuesday1810.CommandType = CommandType.Text;
            DbClass.cmdOplTuesday1810.CommandText = DbClass.sqlusers;
            DbClass.daOplTuesday1810 = new SqlDataAdapter(DbClass.cmdOplTuesday1810);
            DbClass.dtOplTuesday1810 = new DataTable();
            DbClass.daOplTuesday1810.Fill(DbClass.dtOplTuesday1810);
            SqlCommandBuilder comandbuilderOplTuesday1810 = new SqlCommandBuilder(DbClass.daOplTuesday1810);

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



        private void TabItemOplataTuesday1400_Selected(object sender, RoutedEventArgs e)
        {
            //14:00----------------------------------------------------------------------------------

            rename_Columns();

        }



        private void myDataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            myDataGridTuesday1400.ItemsSource = DbClass.dtTuesday1400.DefaultView;
            myDataGridOplataTuesday1400.ItemsSource = DbClass.dtOplTuesday1400.DefaultView;

            myDataGridTuesday1500.ItemsSource = DbClass.dtTuesday1500.DefaultView;
            myDataGridOplataTuesday1500.ItemsSource = DbClass.dtOplTuesday1500.DefaultView;

            myDataGridTuesday1600.ItemsSource = DbClass.dtTuesday1600.DefaultView;
            myDataGridOplataTuesday1600.ItemsSource = DbClass.dtOplTuesday1600.DefaultView;

            myDataGridTuesday1700.ItemsSource = DbClass.dtTuesday1700.DefaultView;
            myDataGridOplataTuesday1700.ItemsSource = DbClass.dtOplTuesday1700.DefaultView;

            myDataGridTuesday1810.ItemsSource = DbClass.dtTuesday1810.DefaultView;
            myDataGridOplataTuesday1810.ItemsSource = DbClass.dtOplTuesday1810.DefaultView;

            count_Plus();
            rename_Columns();
        }

        private void myDataGridTuesday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daTuesday1400.Update(DbClass.dtTuesday1400);

        }

        private void myDataGridTuesday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daTuesday1500.Update(DbClass.dtTuesday1500);
        }

        private void myDataGridTuesday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daTuesday1600.Update(DbClass.dtTuesday1600);
        }

        private void myDataGridTuesday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daTuesday1700.Update(DbClass.dtTuesday1700);
        }

        private void myDataGridTuesday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daTuesday1810.Update(DbClass.dtTuesday1810);
        }

        private void myDataGridOplataTuesday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplTuesday1400.Update(DbClass.dtOplTuesday1400);
        }

        private void myDataGridOplataTuesday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplTuesday1500.Update(DbClass.dtOplTuesday1500);
        }

        private void myDataGridOplataTuesday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplTuesday1600.Update(DbClass.dtOplTuesday1600);
        }

        private void myDataGridOplataTuesday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplTuesday1700.Update(DbClass.dtOplTuesday1700);
        }

        private void myDataGridOplataTuesday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplTuesday1810.Update(DbClass.dtOplTuesday1810);
        }
    }
}