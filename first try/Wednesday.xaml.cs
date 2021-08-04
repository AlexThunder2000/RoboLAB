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
    /// Логика взаимодействия для Wednesday.xaml
    /// </summary>
    public partial class Wednesday : Window
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
                SqlCommandBuilder comandbuilderWednesday1400 = new SqlCommandBuilder(DbClass.daWednesday1400);
                DbClass.cmdWednesday1400.CommandText = "ALTER TABLE Wednesday1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdWednesday1400.ExecuteNonQuery();
                DbClass.cmdWednesday1400.CommandText = "UPDATE Wednesday1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdWednesday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1400;";
                DbClass.cmdWednesday1400.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1400 = new DataTable();
                DbClass.daWednesday1400.Fill(DbClass.dtWednesday1400);
                myDataGridWednesday1400.ItemsSource = DbClass.dtWednesday1400.DefaultView;
                DbClass.daWednesday1400.Update(DbClass.dtWednesday1400);

                SqlCommandBuilder comandbuilderOplWednesday1400 = new SqlCommandBuilder(DbClass.daOplWednesday1400);
                DbClass.cmdOplWednesday1400.CommandText = "ALTER TABLE WednesdayOplata1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplWednesday1400.ExecuteNonQuery();
                DbClass.cmdOplWednesday1400.CommandText = "UPDATE WednesdayOplata1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplWednesday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1400;";
                DbClass.cmdOplWednesday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1400 = new DataTable();
                DbClass.daOplWednesday1400.Fill(DbClass.dtOplWednesday1400);
                myDataGridOplataWednesday1400.ItemsSource = DbClass.dtOplWednesday1400.DefaultView;
                DbClass.daOplWednesday1400.Update(DbClass.dtOplWednesday1400);


                //15:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderWednesday1500 = new SqlCommandBuilder(DbClass.daWednesday1500);
                DbClass.cmdWednesday1500.CommandText = "ALTER TABLE Wednesday1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdWednesday1500.ExecuteNonQuery();
                DbClass.cmdWednesday1500.CommandText = "UPDATE Wednesday1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdWednesday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1500;";
                DbClass.cmdWednesday1500.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1500 = new DataTable();
                DbClass.daWednesday1500.Fill(DbClass.dtWednesday1500);
                myDataGridWednesday1500.ItemsSource = DbClass.dtWednesday1500.DefaultView;
                DbClass.daWednesday1500.Update(DbClass.dtWednesday1500);

                SqlCommandBuilder comandbuilderOplWednesday1500 = new SqlCommandBuilder(DbClass.daOplWednesday1500);
                DbClass.cmdOplWednesday1500.CommandText = "ALTER TABLE WednesdayOplata1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplWednesday1500.ExecuteNonQuery();
                DbClass.cmdOplWednesday1500.CommandText = "UPDATE WednesdayOplata1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplWednesday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1500;";
                DbClass.cmdOplWednesday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1500 = new DataTable();
                DbClass.daOplWednesday1500.Fill(DbClass.dtOplWednesday1500);
                myDataGridOplataWednesday1500.ItemsSource = DbClass.dtOplWednesday1500.DefaultView;
                DbClass.daOplWednesday1500.Update(DbClass.dtOplWednesday1500);

                //16:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderWednesday1600 = new SqlCommandBuilder(DbClass.daWednesday1600);
                DbClass.cmdWednesday1600.CommandText = "ALTER TABLE Wednesday1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdWednesday1600.ExecuteNonQuery();
                DbClass.cmdWednesday1600.CommandText = "UPDATE Wednesday1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdWednesday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1600;";
                DbClass.cmdWednesday1600.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1600 = new DataTable();
                DbClass.daWednesday1600.Fill(DbClass.dtWednesday1600);
                myDataGridWednesday1600.ItemsSource = DbClass.dtWednesday1600.DefaultView;
                DbClass.daWednesday1600.Update(DbClass.dtWednesday1600);

                SqlCommandBuilder comandbuilderOplWednesday1600 = new SqlCommandBuilder(DbClass.daOplWednesday1600);
                DbClass.cmdOplWednesday1600.CommandText = "ALTER TABLE WednesdayOplata1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplWednesday1600.ExecuteNonQuery();
                DbClass.cmdOplWednesday1600.CommandText = "UPDATE WednesdayOplata1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplWednesday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1600;";
                DbClass.cmdOplWednesday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1600 = new DataTable();
                DbClass.daOplWednesday1600.Fill(DbClass.dtOplWednesday1600);
                myDataGridOplataWednesday1600.ItemsSource = DbClass.dtOplWednesday1600.DefaultView;
                DbClass.daOplWednesday1600.Update(DbClass.dtOplWednesday1600);

                //17:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderWednesday1700 = new SqlCommandBuilder(DbClass.daWednesday1700);
                DbClass.cmdWednesday1700.CommandText = "ALTER TABLE Wednesday1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdWednesday1700.ExecuteNonQuery();
                DbClass.cmdWednesday1700.CommandText = "UPDATE Wednesday1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdWednesday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1700;";
                DbClass.cmdWednesday1700.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1700 = new DataTable();
                DbClass.daWednesday1700.Fill(DbClass.dtWednesday1700);
                myDataGridWednesday1700.ItemsSource = DbClass.dtWednesday1700.DefaultView;
                DbClass.daWednesday1700.Update(DbClass.dtWednesday1700);

                SqlCommandBuilder comandbuilderOplWednesday1700 = new SqlCommandBuilder(DbClass.daOplWednesday1700);
                DbClass.cmdOplWednesday1700.CommandText = "ALTER TABLE WednesdayOplata1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplWednesday1700.ExecuteNonQuery();
                DbClass.cmdOplWednesday1700.CommandText = "UPDATE WednesdayOplata1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplWednesday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1700;";
                DbClass.cmdOplWednesday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1700 = new DataTable();
                DbClass.daOplWednesday1700.Fill(DbClass.dtOplWednesday1700);
                myDataGridOplataWednesday1700.ItemsSource = DbClass.dtOplWednesday1700.DefaultView;
                DbClass.daOplWednesday1700.Update(DbClass.dtOplWednesday1700);

                //18:10--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderWednesday1810 = new SqlCommandBuilder(DbClass.daWednesday1810);
                DbClass.cmdWednesday1810.CommandText = "ALTER TABLE Wednesday1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdWednesday1810.ExecuteNonQuery();
                DbClass.cmdWednesday1810.CommandText = "UPDATE Wednesday1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdWednesday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1810;";
                DbClass.cmdWednesday1810.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1810 = new DataTable();
                DbClass.daWednesday1810.Fill(DbClass.dtWednesday1810);
                myDataGridWednesday1810.ItemsSource = DbClass.dtWednesday1810.DefaultView;
                DbClass.daWednesday1810.Update(DbClass.dtWednesday1810);

                SqlCommandBuilder comandbuilderOplWednesday1810 = new SqlCommandBuilder(DbClass.daOplWednesday1810);
                DbClass.cmdOplWednesday1810.CommandText = "ALTER TABLE WednesdayOplata1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplWednesday1810.ExecuteNonQuery();
                DbClass.cmdOplWednesday1810.CommandText = "UPDATE WednesdayOplata1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplWednesday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1810;";
                DbClass.cmdOplWednesday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1810 = new DataTable();
                DbClass.daOplWednesday1810.Fill(DbClass.dtOplWednesday1810);
                myDataGridOplataWednesday1810.ItemsSource = DbClass.dtOplWednesday1810.DefaultView;
                DbClass.daOplWednesday1810.Update(DbClass.dtOplWednesday1810);

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
                SqlCommandBuilder comandbuilderWednesday1400 = new SqlCommandBuilder(DbClass.daWednesday1400);
                DbClass.cmdWednesday1400.CommandText = "ALTER TABLE Wednesday1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdWednesday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1400;";
                DbClass.cmdWednesday1400.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1400 = new DataTable();
                DbClass.daWednesday1400.Fill(DbClass.dtWednesday1400);
                myDataGridWednesday1400.ItemsSource = DbClass.dtWednesday1400.DefaultView;
                DbClass.daWednesday1400.Update(DbClass.dtWednesday1400);

                SqlCommandBuilder comandbuilderOplWednesday1400 = new SqlCommandBuilder(DbClass.daOplWednesday1400);
                DbClass.cmdOplWednesday1400.CommandText = "ALTER TABLE WednesdayOplata1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplWednesday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1400;";
                DbClass.cmdOplWednesday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1400 = new DataTable();
                DbClass.daOplWednesday1400.Fill(DbClass.dtOplWednesday1400);
                myDataGridOplataWednesday1400.ItemsSource = DbClass.dtOplWednesday1400.DefaultView;
                DbClass.daOplWednesday1400.Update(DbClass.dtOplWednesday1400);


                //15:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderWednesday1500 = new SqlCommandBuilder(DbClass.daWednesday1500);
                DbClass.cmdWednesday1500.CommandText = "ALTER TABLE Wednesday1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdWednesday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1500;";
                DbClass.cmdWednesday1500.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1500 = new DataTable();
                DbClass.daWednesday1500.Fill(DbClass.dtWednesday1500);
                myDataGridWednesday1500.ItemsSource = DbClass.dtWednesday1500.DefaultView;
                DbClass.daWednesday1500.Update(DbClass.dtWednesday1500);

                SqlCommandBuilder comandbuilderOplWednesday1500 = new SqlCommandBuilder(DbClass.daOplWednesday1500);
                DbClass.cmdOplWednesday1500.CommandText = "ALTER TABLE WednesdayOplata1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplWednesday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1500;";
                DbClass.cmdOplWednesday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1500 = new DataTable();
                DbClass.daOplWednesday1500.Fill(DbClass.dtOplWednesday1500);
                myDataGridOplataWednesday1500.ItemsSource = DbClass.dtOplWednesday1500.DefaultView;
                DbClass.daOplWednesday1500.Update(DbClass.dtOplWednesday1500);


                //16:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderWednesday1600 = new SqlCommandBuilder(DbClass.daWednesday1600);
                DbClass.cmdWednesday1600.CommandText = "ALTER TABLE Wednesday1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdWednesday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1600;";
                DbClass.cmdWednesday1600.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1600 = new DataTable();
                DbClass.daWednesday1600.Fill(DbClass.dtWednesday1600);
                myDataGridWednesday1600.ItemsSource = DbClass.dtWednesday1600.DefaultView;
                DbClass.daWednesday1600.Update(DbClass.dtWednesday1600);

                SqlCommandBuilder comandbuilderOplWednesday1600 = new SqlCommandBuilder(DbClass.daOplWednesday1600);
                DbClass.cmdOplWednesday1600.CommandText = "ALTER TABLE WednesdayOplata1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplWednesday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1600;";
                DbClass.cmdOplWednesday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1600 = new DataTable();
                DbClass.daOplWednesday1600.Fill(DbClass.dtOplWednesday1600);
                myDataGridOplataWednesday1600.ItemsSource = DbClass.dtOplWednesday1600.DefaultView;
                DbClass.daOplWednesday1600.Update(DbClass.dtOplWednesday1600);


                //17:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderWednesday1700 = new SqlCommandBuilder(DbClass.daWednesday1700);
                DbClass.cmdWednesday1700.CommandText = "ALTER TABLE Wednesday1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdWednesday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1700;";
                DbClass.cmdWednesday1700.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1700 = new DataTable();
                DbClass.daWednesday1700.Fill(DbClass.dtWednesday1700);
                myDataGridWednesday1700.ItemsSource = DbClass.dtWednesday1700.DefaultView;
                DbClass.daWednesday1700.Update(DbClass.dtWednesday1700);

                SqlCommandBuilder comandbuilderOplWednesday1700 = new SqlCommandBuilder(DbClass.daOplWednesday1700);
                DbClass.cmdOplWednesday1700.CommandText = "ALTER TABLE WednesdayOplata1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplWednesday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1700;";
                DbClass.cmdOplWednesday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1700 = new DataTable();
                DbClass.daOplWednesday1700.Fill(DbClass.dtOplWednesday1700);
                myDataGridOplataWednesday1700.ItemsSource = DbClass.dtOplWednesday1700.DefaultView;
                DbClass.daOplWednesday1700.Update(DbClass.dtOplWednesday1700);


                //18:10-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderWednesday1810 = new SqlCommandBuilder(DbClass.daWednesday1810);
                DbClass.cmdWednesday1810.CommandText = "ALTER TABLE Wednesday1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdWednesday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Wednesday1810;";
                DbClass.cmdWednesday1810.CommandText = DbClass.sqlusers;
                DbClass.dtWednesday1810 = new DataTable();
                DbClass.daWednesday1810.Fill(DbClass.dtWednesday1810);
                myDataGridWednesday1810.ItemsSource = DbClass.dtWednesday1810.DefaultView;
                DbClass.daWednesday1810.Update(DbClass.dtWednesday1810);

                SqlCommandBuilder comandbuilderOplWednesday1810 = new SqlCommandBuilder(DbClass.daOplWednesday1810);
                DbClass.cmdOplWednesday1810.CommandText = "ALTER TABLE WednesdayOplata1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplWednesday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM WednesdayOplata1810;";
                DbClass.cmdOplWednesday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplWednesday1810 = new DataTable();
                DbClass.daOplWednesday1810.Fill(DbClass.dtOplWednesday1810);
                myDataGridOplataWednesday1810.ItemsSource = DbClass.dtOplWednesday1810.DefaultView;
                DbClass.daOplWednesday1810.Update(DbClass.dtOplWednesday1810);

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

                myDataGridWednesday1400.Columns[0].Header = "Залишок";
                myDataGridWednesday1400.Columns[1].Header = "ПІБ";
                for (int i = myDataGridWednesday1400.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridWednesday1400.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridWednesday1400.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridWednesday1400.Columns[i].Header = column_header;
                }


            }
            catch (Exception)
            {

                //
            }
            //оплата-------------------------------------------------------------------
            try
            {
                myDataGridOplataWednesday1400.Columns[0].Header = "Оплачено";
                myDataGridOplataWednesday1400.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataWednesday1400.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataWednesday1400.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataWednesday1400.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataWednesday1400.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                //
            }
            //15:00--------------------------------------------------------------------
            try
            {

                myDataGridWednesday1500.Columns[0].Header = "Залишок";
                myDataGridWednesday1500.Columns[1].Header = "ПІБ";
                for (int i = myDataGridWednesday1500.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridWednesday1500.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridWednesday1500.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridWednesday1500.Columns[i].Header = column_header;
                }

                myDataGridOplataWednesday1500.Columns[0].Header = "Оплачено";
                myDataGridOplataWednesday1500.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataWednesday1500.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataWednesday1500.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataWednesday1500.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataWednesday1500.Columns[j].Header = column_header;

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
                myDataGridWednesday1600.Columns[0].Header = "Залишок";
                myDataGridWednesday1600.Columns[1].Header = "ПІБ";
                for (int i = myDataGridWednesday1600.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridWednesday1600.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridWednesday1600.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridWednesday1600.Columns[i].Header = column_header;
                }

                myDataGridOplataWednesday1600.Columns[0].Header = "Оплачено";
                myDataGridOplataWednesday1600.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataWednesday1600.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataWednesday1600.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataWednesday1600.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataWednesday1600.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename16");

            }

            //17:00--------------------------------------------------------------------
            try
            {
                myDataGridWednesday1700.Columns[0].Header = "Залишок";
                myDataGridWednesday1700.Columns[1].Header = "ПІБ";
                for (int i = myDataGridWednesday1700.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridWednesday1700.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridWednesday1700.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridWednesday1700.Columns[i].Header = column_header;
                }


                myDataGridOplataWednesday1700.Columns[0].Header = "Оплачено";
                myDataGridOplataWednesday1700.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataWednesday1700.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataWednesday1700.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataWednesday1700.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataWednesday1700.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename17");

            }

            //18:10--------------------------------------------------------------------
            try
            {
                myDataGridWednesday1810.Columns[0].Header = "Залишок";
                myDataGridWednesday1810.Columns[1].Header = "ПІБ";
                for (int i = myDataGridWednesday1810.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridWednesday1810.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridWednesday1810.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridWednesday1810.Columns[i].Header = column_header;
                }


                myDataGridOplataWednesday1810.Columns[0].Header = "Оплачено";
                myDataGridOplataWednesday1810.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataWednesday1810.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataWednesday1810.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataWednesday1810.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataWednesday1810.Columns[j].Header = column_header;

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
                for (int i = 0; i < myDataGridOplataWednesday1400.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataWednesday1400.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplWednesday1400.Rows[i][j].ToString());
                        DbClass.dtOplWednesday1400.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridWednesday1400.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridWednesday1400.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtWednesday1400.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplWednesday1400.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtWednesday1400.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }
            //15:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataWednesday1500.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataWednesday1500.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplWednesday1500.Rows[i][j].ToString());
                        DbClass.dtOplWednesday1500.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridWednesday1500.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridWednesday1500.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtWednesday1500.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplWednesday1500.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtWednesday1500.Rows[i][0] = temp.ToString().Trim();


                }


            }
            catch (Exception)
            {
                //
            }

            //16:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataWednesday1600.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataWednesday1600.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplWednesday1600.Rows[i][j].ToString());
                        DbClass.dtOplWednesday1600.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridWednesday1600.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridWednesday1600.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtWednesday1600.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplWednesday1600.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtWednesday1600.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }

            //17:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataWednesday1700.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataWednesday1700.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplWednesday1700.Rows[i][j].ToString());
                        DbClass.dtOplWednesday1700.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridWednesday1700.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridWednesday1700.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtWednesday1700.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplWednesday1700.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtWednesday1700.Rows[i][0] = temp.ToString().Trim();


                }
            }
            catch (Exception)
            {
                //
            }

            //18:10-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataWednesday1810.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataWednesday1810.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplWednesday1810.Rows[i][j].ToString());
                        DbClass.dtOplWednesday1810.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridWednesday1810.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridWednesday1810.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtWednesday1810.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplWednesday1810.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtWednesday1810.Rows[i][0] = temp.ToString().Trim();


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

        public Wednesday()
        {
            InitializeComponent();

            //вівторок-----------------------------------------------------------------------------------
            //14:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM wednesday1400;";
            DbClass.cmdWednesday1400.CommandType = CommandType.Text;
            DbClass.cmdWednesday1400.CommandText = DbClass.sqlusers;
            DbClass.daWednesday1400 = new SqlDataAdapter(DbClass.cmdWednesday1400);
            DbClass.dtWednesday1400 = new DataTable();
            DbClass.daWednesday1400.Fill(DbClass.dtWednesday1400);
            SqlCommandBuilder comandbuilderWednesday1400 = new SqlCommandBuilder(DbClass.daWednesday1400);

            //оплата
            DbClass.sqlusers = "SELECT * FROM wednesdayOplata1400;";
            DbClass.cmdOplWednesday1400.CommandType = CommandType.Text;
            DbClass.cmdOplWednesday1400.CommandText = DbClass.sqlusers;
            DbClass.daOplWednesday1400 = new SqlDataAdapter(DbClass.cmdOplWednesday1400);
            DbClass.dtOplWednesday1400 = new DataTable();
            DbClass.daOplWednesday1400.Fill(DbClass.dtOplWednesday1400);
            SqlCommandBuilder comandbuilderOplWednesday1400 = new SqlCommandBuilder(DbClass.daOplWednesday1400);

            //15:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM wednesday1500;";
            DbClass.cmdWednesday1500.CommandType = CommandType.Text;
            DbClass.cmdWednesday1500.CommandText = DbClass.sqlusers;
            DbClass.daWednesday1500 = new SqlDataAdapter(DbClass.cmdWednesday1500);
            DbClass.dtWednesday1500 = new DataTable();
            DbClass.daWednesday1500.Fill(DbClass.dtWednesday1500);
            SqlCommandBuilder comandbuilderWednesday1500 = new SqlCommandBuilder(DbClass.daWednesday1500);

            //оплата
            DbClass.sqlusers = "SELECT * FROM wednesdayOplata1500;";
            DbClass.cmdOplWednesday1500.CommandType = CommandType.Text;
            DbClass.cmdOplWednesday1500.CommandText = DbClass.sqlusers;
            DbClass.daOplWednesday1500 = new SqlDataAdapter(DbClass.cmdOplWednesday1500);
            DbClass.dtOplWednesday1500 = new DataTable();
            DbClass.daOplWednesday1500.Fill(DbClass.dtOplWednesday1500);
            SqlCommandBuilder comandbuilderOplWednesday1500 = new SqlCommandBuilder(DbClass.daOplWednesday1500);


            //16:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM wednesday1600;";
            DbClass.cmdWednesday1600.CommandType = CommandType.Text;
            DbClass.cmdWednesday1600.CommandText = DbClass.sqlusers;
            DbClass.daWednesday1600 = new SqlDataAdapter(DbClass.cmdWednesday1600);
            DbClass.dtWednesday1600 = new DataTable();
            DbClass.daWednesday1600.Fill(DbClass.dtWednesday1600);
            SqlCommandBuilder comandbuilderWednesday1600 = new SqlCommandBuilder(DbClass.daWednesday1600);


            //оплата
            DbClass.sqlusers = "SELECT * FROM wednesdayOplata1600;";
            DbClass.cmdOplWednesday1600.CommandType = CommandType.Text;
            DbClass.cmdOplWednesday1600.CommandText = DbClass.sqlusers;
            DbClass.daOplWednesday1600 = new SqlDataAdapter(DbClass.cmdOplWednesday1600);
            DbClass.dtOplWednesday1600 = new DataTable();
            DbClass.daOplWednesday1600.Fill(DbClass.dtOplWednesday1600);
            SqlCommandBuilder comandbuilderOplWednesday1600 = new SqlCommandBuilder(DbClass.daOplWednesday1600);



            //17:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM wednesday1700;";
            DbClass.cmdWednesday1700.CommandType = CommandType.Text;
            DbClass.cmdWednesday1700.CommandText = DbClass.sqlusers;
            DbClass.daWednesday1700 = new SqlDataAdapter(DbClass.cmdWednesday1700);
            DbClass.dtWednesday1700 = new DataTable();
            DbClass.daWednesday1700.Fill(DbClass.dtWednesday1700);
            SqlCommandBuilder comandbuilderWednesday1700 = new SqlCommandBuilder(DbClass.daWednesday1700);

            //оплата
            DbClass.sqlusers = "SELECT * FROM wednesdayOplata1700;";
            DbClass.cmdOplWednesday1700.CommandType = CommandType.Text;
            DbClass.cmdOplWednesday1700.CommandText = DbClass.sqlusers;
            DbClass.daOplWednesday1700 = new SqlDataAdapter(DbClass.cmdOplWednesday1700);
            DbClass.dtOplWednesday1700 = new DataTable();
            DbClass.daOplWednesday1700.Fill(DbClass.dtOplWednesday1700);
            SqlCommandBuilder comandbuilderOplWednesday1700 = new SqlCommandBuilder(DbClass.daOplWednesday1700);

            //18:10----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM wednesday1810;";
            DbClass.cmdWednesday1810.CommandType = CommandType.Text;
            DbClass.cmdWednesday1810.CommandText = DbClass.sqlusers;
            DbClass.daWednesday1810 = new SqlDataAdapter(DbClass.cmdWednesday1810);
            DbClass.dtWednesday1810 = new DataTable();
            DbClass.daWednesday1810.Fill(DbClass.dtWednesday1810);
            SqlCommandBuilder comandbuilderWednesday1810 = new SqlCommandBuilder(DbClass.daWednesday1810);

            //оплата
            DbClass.sqlusers = "SELECT * FROM wednesdayOplata1810;";
            DbClass.cmdOplWednesday1810.CommandType = CommandType.Text;
            DbClass.cmdOplWednesday1810.CommandText = DbClass.sqlusers;
            DbClass.daOplWednesday1810 = new SqlDataAdapter(DbClass.cmdOplWednesday1810);
            DbClass.dtOplWednesday1810 = new DataTable();
            DbClass.daOplWednesday1810.Fill(DbClass.dtOplWednesday1810);
            SqlCommandBuilder comandbuilderOplWednesday1810 = new SqlCommandBuilder(DbClass.daOplWednesday1810);

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



        private void TabItemOplataWednesday1400_Selected(object sender, RoutedEventArgs e)
        {
            //14:00----------------------------------------------------------------------------------

            rename_Columns();

        }



        private void myDataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            myDataGridWednesday1400.ItemsSource = DbClass.dtWednesday1400.DefaultView;
            myDataGridOplataWednesday1400.ItemsSource = DbClass.dtOplWednesday1400.DefaultView;

            myDataGridWednesday1500.ItemsSource = DbClass.dtWednesday1500.DefaultView;
            myDataGridOplataWednesday1500.ItemsSource = DbClass.dtOplWednesday1500.DefaultView;

            myDataGridWednesday1600.ItemsSource = DbClass.dtWednesday1600.DefaultView;
            myDataGridOplataWednesday1600.ItemsSource = DbClass.dtOplWednesday1600.DefaultView;

            myDataGridWednesday1700.ItemsSource = DbClass.dtWednesday1700.DefaultView;
            myDataGridOplataWednesday1700.ItemsSource = DbClass.dtOplWednesday1700.DefaultView;

            myDataGridWednesday1810.ItemsSource = DbClass.dtWednesday1810.DefaultView;
            myDataGridOplataWednesday1810.ItemsSource = DbClass.dtOplWednesday1810.DefaultView;

            count_Plus();
            rename_Columns();
        }

        private void myDataGridWednesday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daWednesday1400.Update(DbClass.dtWednesday1400);

        }

        private void myDataGridWednesday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daWednesday1500.Update(DbClass.dtWednesday1500);
        }

        private void myDataGridWednesday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daWednesday1600.Update(DbClass.dtWednesday1600);
        }

        private void myDataGridWednesday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daWednesday1700.Update(DbClass.dtWednesday1700);
        }

        private void myDataGridWednesday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daWednesday1810.Update(DbClass.dtWednesday1810);
        }

        private void myDataGridOplataWednesday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplWednesday1400.Update(DbClass.dtOplWednesday1400);
        }

        private void myDataGridOplataWednesday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplWednesday1500.Update(DbClass.dtOplWednesday1500);
        }

        private void myDataGridOplataWednesday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplWednesday1600.Update(DbClass.dtOplWednesday1600);
        }

        private void myDataGridOplataWednesday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplWednesday1700.Update(DbClass.dtOplWednesday1700);
        }

        private void myDataGridOplataWednesday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplWednesday1810.Update(DbClass.dtOplWednesday1810);
        }
    }
}