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
    /// Логика взаимодействия для Monday.xaml
    /// </summary>
    public partial class Monday : Window
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
                SqlCommandBuilder comandbuilderMonday1400 = new SqlCommandBuilder(DbClass.daMonday1400);
                DbClass.cmdMonday1400.CommandText = "ALTER TABLE Monday1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdMonday1400.ExecuteNonQuery();
                DbClass.cmdMonday1400.CommandText = "UPDATE Monday1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdMonday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1400;";
                DbClass.cmdMonday1400.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1400 = new DataTable();
                DbClass.daMonday1400.Fill(DbClass.dtMonday1400);
                myDataGridMonday1400.ItemsSource = DbClass.dtMonday1400.DefaultView;
                DbClass.daMonday1400.Update(DbClass.dtMonday1400);

                SqlCommandBuilder comandbuilderOplMonday1400 = new SqlCommandBuilder(DbClass.daOplMonday1400);
                DbClass.cmdOplMonday1400.CommandText = "ALTER TABLE MondayOplata1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplMonday1400.ExecuteNonQuery();
                DbClass.cmdOplMonday1400.CommandText = "UPDATE MondayOplata1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplMonday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1400;";
                DbClass.cmdOplMonday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1400 = new DataTable();
                DbClass.daOplMonday1400.Fill(DbClass.dtOplMonday1400);
                myDataGridOplataMonday1400.ItemsSource = DbClass.dtOplMonday1400.DefaultView;
                DbClass.daOplMonday1400.Update(DbClass.dtOplMonday1400);


                //15:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderMonday1500 = new SqlCommandBuilder(DbClass.daMonday1500);
                DbClass.cmdMonday1500.CommandText = "ALTER TABLE Monday1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdMonday1500.ExecuteNonQuery();
                DbClass.cmdMonday1500.CommandText = "UPDATE Monday1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdMonday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1500;";
                DbClass.cmdMonday1500.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1500 = new DataTable();
                DbClass.daMonday1500.Fill(DbClass.dtMonday1500);
                myDataGridMonday1500.ItemsSource = DbClass.dtMonday1500.DefaultView;
                DbClass.daMonday1500.Update(DbClass.dtMonday1500);

                SqlCommandBuilder comandbuilderOplMonday1500 = new SqlCommandBuilder(DbClass.daOplMonday1500);
                DbClass.cmdOplMonday1500.CommandText = "ALTER TABLE MondayOplata1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplMonday1500.ExecuteNonQuery();
                DbClass.cmdOplMonday1500.CommandText = "UPDATE MondayOplata1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplMonday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1500;";
                DbClass.cmdOplMonday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1500 = new DataTable();
                DbClass.daOplMonday1500.Fill(DbClass.dtOplMonday1500);
                myDataGridOplataMonday1500.ItemsSource = DbClass.dtOplMonday1500.DefaultView;
                DbClass.daOplMonday1500.Update(DbClass.dtOplMonday1500);

                //16:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderMonday1600 = new SqlCommandBuilder(DbClass.daMonday1600);
                DbClass.cmdMonday1600.CommandText = "ALTER TABLE Monday1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdMonday1600.ExecuteNonQuery();
                DbClass.cmdMonday1600.CommandText = "UPDATE Monday1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdMonday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1600;";
                DbClass.cmdMonday1600.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1600 = new DataTable();
                DbClass.daMonday1600.Fill(DbClass.dtMonday1600);
                myDataGridMonday1600.ItemsSource = DbClass.dtMonday1600.DefaultView;
                DbClass.daMonday1600.Update(DbClass.dtMonday1600);

                SqlCommandBuilder comandbuilderOplMonday1600 = new SqlCommandBuilder(DbClass.daOplMonday1600);
                DbClass.cmdOplMonday1600.CommandText = "ALTER TABLE MondayOplata1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplMonday1600.ExecuteNonQuery();
                DbClass.cmdOplMonday1600.CommandText = "UPDATE MondayOplata1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplMonday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1600;";
                DbClass.cmdOplMonday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1600 = new DataTable();
                DbClass.daOplMonday1600.Fill(DbClass.dtOplMonday1600);
                myDataGridOplataMonday1600.ItemsSource = DbClass.dtOplMonday1600.DefaultView;
                DbClass.daOplMonday1600.Update(DbClass.dtOplMonday1600);

                //17:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderMonday1700 = new SqlCommandBuilder(DbClass.daMonday1700);
                DbClass.cmdMonday1700.CommandText = "ALTER TABLE Monday1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdMonday1700.ExecuteNonQuery();
                DbClass.cmdMonday1700.CommandText = "UPDATE Monday1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdMonday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1700;";
                DbClass.cmdMonday1700.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1700 = new DataTable();
                DbClass.daMonday1700.Fill(DbClass.dtMonday1700);
                myDataGridMonday1700.ItemsSource = DbClass.dtMonday1700.DefaultView;
                DbClass.daMonday1700.Update(DbClass.dtMonday1700);

                SqlCommandBuilder comandbuilderOplMonday1700 = new SqlCommandBuilder(DbClass.daOplMonday1700);
                DbClass.cmdOplMonday1700.CommandText = "ALTER TABLE MondayOplata1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplMonday1700.ExecuteNonQuery();
                DbClass.cmdOplMonday1700.CommandText = "UPDATE MondayOplata1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplMonday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1700;";
                DbClass.cmdOplMonday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1700 = new DataTable();
                DbClass.daOplMonday1700.Fill(DbClass.dtOplMonday1700);
                myDataGridOplataMonday1700.ItemsSource = DbClass.dtOplMonday1700.DefaultView;
                DbClass.daOplMonday1700.Update(DbClass.dtOplMonday1700);

                //18:10--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderMonday1810 = new SqlCommandBuilder(DbClass.daMonday1810);
                DbClass.cmdMonday1810.CommandText = "ALTER TABLE Monday1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdMonday1810.ExecuteNonQuery();
                DbClass.cmdMonday1810.CommandText = "UPDATE Monday1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdMonday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1810;";
                DbClass.cmdMonday1810.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1810 = new DataTable();
                DbClass.daMonday1810.Fill(DbClass.dtMonday1810);
                myDataGridMonday1810.ItemsSource = DbClass.dtMonday1810.DefaultView;
                DbClass.daMonday1810.Update(DbClass.dtMonday1810);

                SqlCommandBuilder comandbuilderOplMonday1810 = new SqlCommandBuilder(DbClass.daOplMonday1810);
                DbClass.cmdOplMonday1810.CommandText = "ALTER TABLE MondayOplata1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplMonday1810.ExecuteNonQuery();
                DbClass.cmdOplMonday1810.CommandText = "UPDATE MondayOplata1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplMonday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1810;";
                DbClass.cmdOplMonday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1810 = new DataTable();
                DbClass.daOplMonday1810.Fill(DbClass.dtOplMonday1810);
                myDataGridOplataMonday1810.ItemsSource = DbClass.dtOplMonday1810.DefaultView;
                DbClass.daOplMonday1810.Update(DbClass.dtOplMonday1810);

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
                SqlCommandBuilder comandbuilderMonday1400 = new SqlCommandBuilder(DbClass.daMonday1400);
                DbClass.cmdMonday1400.CommandText = "ALTER TABLE Monday1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdMonday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1400;";
                DbClass.cmdMonday1400.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1400 = new DataTable();
                DbClass.daMonday1400.Fill(DbClass.dtMonday1400);
                myDataGridMonday1400.ItemsSource = DbClass.dtMonday1400.DefaultView;
                DbClass.daMonday1400.Update(DbClass.dtMonday1400);

                SqlCommandBuilder comandbuilderOplMonday1400 = new SqlCommandBuilder(DbClass.daOplMonday1400);
                DbClass.cmdOplMonday1400.CommandText = "ALTER TABLE MondayOplata1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplMonday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1400;";
                DbClass.cmdOplMonday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1400 = new DataTable();
                DbClass.daOplMonday1400.Fill(DbClass.dtOplMonday1400);
                myDataGridOplataMonday1400.ItemsSource = DbClass.dtOplMonday1400.DefaultView;
                DbClass.daOplMonday1400.Update(DbClass.dtOplMonday1400);


                //15:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderMonday1500 = new SqlCommandBuilder(DbClass.daMonday1500);
                DbClass.cmdMonday1500.CommandText = "ALTER TABLE Monday1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdMonday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1500;";
                DbClass.cmdMonday1500.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1500 = new DataTable();
                DbClass.daMonday1500.Fill(DbClass.dtMonday1500);
                myDataGridMonday1500.ItemsSource = DbClass.dtMonday1500.DefaultView;
                DbClass.daMonday1500.Update(DbClass.dtMonday1500);

                SqlCommandBuilder comandbuilderOplMonday1500 = new SqlCommandBuilder(DbClass.daOplMonday1500);
                DbClass.cmdOplMonday1500.CommandText = "ALTER TABLE MondayOplata1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplMonday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1500;";
                DbClass.cmdOplMonday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1500 = new DataTable();
                DbClass.daOplMonday1500.Fill(DbClass.dtOplMonday1500);
                myDataGridOplataMonday1500.ItemsSource = DbClass.dtOplMonday1500.DefaultView;
                DbClass.daOplMonday1500.Update(DbClass.dtOplMonday1500);


                //16:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderMonday1600 = new SqlCommandBuilder(DbClass.daMonday1600);
                DbClass.cmdMonday1600.CommandText = "ALTER TABLE Monday1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdMonday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1600;";
                DbClass.cmdMonday1600.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1600 = new DataTable();
                DbClass.daMonday1600.Fill(DbClass.dtMonday1600);
                myDataGridMonday1600.ItemsSource = DbClass.dtMonday1600.DefaultView;
                DbClass.daMonday1600.Update(DbClass.dtMonday1600);

                SqlCommandBuilder comandbuilderOplMonday1600 = new SqlCommandBuilder(DbClass.daOplMonday1600);
                DbClass.cmdOplMonday1600.CommandText = "ALTER TABLE MondayOplata1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplMonday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1600;";
                DbClass.cmdOplMonday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1600 = new DataTable();
                DbClass.daOplMonday1600.Fill(DbClass.dtOplMonday1600);
                myDataGridOplataMonday1600.ItemsSource = DbClass.dtOplMonday1600.DefaultView;
                DbClass.daOplMonday1600.Update(DbClass.dtOplMonday1600);


                //17:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderMonday1700 = new SqlCommandBuilder(DbClass.daMonday1700);
                DbClass.cmdMonday1700.CommandText = "ALTER TABLE Monday1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdMonday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1700;";
                DbClass.cmdMonday1700.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1700 = new DataTable();
                DbClass.daMonday1700.Fill(DbClass.dtMonday1700);
                myDataGridMonday1700.ItemsSource = DbClass.dtMonday1700.DefaultView;
                DbClass.daMonday1700.Update(DbClass.dtMonday1700);

                SqlCommandBuilder comandbuilderOplMonday1700 = new SqlCommandBuilder(DbClass.daOplMonday1700);
                DbClass.cmdOplMonday1700.CommandText = "ALTER TABLE MondayOplata1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplMonday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1700;";
                DbClass.cmdOplMonday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1700 = new DataTable();
                DbClass.daOplMonday1700.Fill(DbClass.dtOplMonday1700);
                myDataGridOplataMonday1700.ItemsSource = DbClass.dtOplMonday1700.DefaultView;
                DbClass.daOplMonday1700.Update(DbClass.dtOplMonday1700);


                //18:10-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderMonday1810 = new SqlCommandBuilder(DbClass.daMonday1810);
                DbClass.cmdMonday1810.CommandText = "ALTER TABLE Monday1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdMonday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Monday1810;";
                DbClass.cmdMonday1810.CommandText = DbClass.sqlusers;
                DbClass.dtMonday1810 = new DataTable();
                DbClass.daMonday1810.Fill(DbClass.dtMonday1810);
                myDataGridMonday1810.ItemsSource = DbClass.dtMonday1810.DefaultView;
                DbClass.daMonday1810.Update(DbClass.dtMonday1810);

                SqlCommandBuilder comandbuilderOplMonday1810 = new SqlCommandBuilder(DbClass.daOplMonday1810);
                DbClass.cmdOplMonday1810.CommandText = "ALTER TABLE MondayOplata1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplMonday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM MondayOplata1810;";
                DbClass.cmdOplMonday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplMonday1810 = new DataTable();
                DbClass.daOplMonday1810.Fill(DbClass.dtOplMonday1810);
                myDataGridOplataMonday1810.ItemsSource = DbClass.dtOplMonday1810.DefaultView;
                DbClass.daOplMonday1810.Update(DbClass.dtOplMonday1810);

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

                myDataGridMonday1400.Columns[0].Header = "Залишок";
                myDataGridMonday1400.Columns[1].Header = "ПІБ";
                for (int i = myDataGridMonday1400.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridMonday1400.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridMonday1400.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridMonday1400.Columns[i].Header = column_header;
                }


            }
            catch (Exception)
            {

                //
            }
            //оплата-------------------------------------------------------------------
            try
            {
                myDataGridOplataMonday1400.Columns[0].Header = "Оплачено";
                myDataGridOplataMonday1400.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataMonday1400.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataMonday1400.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataMonday1400.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataMonday1400.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                //
            }
            //15:00--------------------------------------------------------------------
            try
            {

                myDataGridMonday1500.Columns[0].Header = "Залишок";
                myDataGridMonday1500.Columns[1].Header = "ПІБ";
                for (int i = myDataGridMonday1500.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridMonday1500.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridMonday1500.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridMonday1500.Columns[i].Header = column_header;
                }

                myDataGridOplataMonday1500.Columns[0].Header = "Оплачено";
                myDataGridOplataMonday1500.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataMonday1500.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataMonday1500.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataMonday1500.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataMonday1500.Columns[j].Header = column_header;

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
                myDataGridMonday1600.Columns[0].Header = "Залишок";
                myDataGridMonday1600.Columns[1].Header = "ПІБ";
                for (int i = myDataGridMonday1600.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridMonday1600.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridMonday1600.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridMonday1600.Columns[i].Header = column_header;
                }

                myDataGridOplataMonday1600.Columns[0].Header = "Оплачено";
                myDataGridOplataMonday1600.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataMonday1600.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataMonday1600.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataMonday1600.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataMonday1600.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename16");

            }

            //17:00--------------------------------------------------------------------
            try
            {
                myDataGridMonday1700.Columns[0].Header = "Залишок";
                myDataGridMonday1700.Columns[1].Header = "ПІБ";
                for (int i = myDataGridMonday1700.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridMonday1700.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridMonday1700.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridMonday1700.Columns[i].Header = column_header;
                }


                myDataGridOplataMonday1700.Columns[0].Header = "Оплачено";
                myDataGridOplataMonday1700.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataMonday1700.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataMonday1700.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataMonday1700.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataMonday1700.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename17");

            }

            //18:10--------------------------------------------------------------------
            try
            {
                myDataGridMonday1810.Columns[0].Header = "Залишок";
                myDataGridMonday1810.Columns[1].Header = "ПІБ";
                for (int i = myDataGridMonday1810.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridMonday1810.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridMonday1810.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridMonday1810.Columns[i].Header = column_header;
                }


                myDataGridOplataMonday1810.Columns[0].Header = "Оплачено";
                myDataGridOplataMonday1810.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataMonday1810.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataMonday1810.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataMonday1810.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataMonday1810.Columns[j].Header = column_header;

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
                for (int i = 0; i < myDataGridOplataMonday1400.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataMonday1400.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplMonday1400.Rows[i][j].ToString());
                        DbClass.dtOplMonday1400.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridMonday1400.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridMonday1400.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtMonday1400.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplMonday1400.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtMonday1400.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }
            //15:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataMonday1500.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataMonday1500.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplMonday1500.Rows[i][j].ToString());
                        DbClass.dtOplMonday1500.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridMonday1500.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridMonday1500.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtMonday1500.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplMonday1500.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtMonday1500.Rows[i][0] = temp.ToString().Trim();


                }


            }
            catch (Exception)
            {
                //
            }

            //16:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataMonday1600.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataMonday1600.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplMonday1600.Rows[i][j].ToString());
                        DbClass.dtOplMonday1600.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridMonday1600.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridMonday1600.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtMonday1600.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplMonday1600.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtMonday1600.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }

            //17:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataMonday1700.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataMonday1700.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplMonday1700.Rows[i][j].ToString());
                        DbClass.dtOplMonday1700.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridMonday1700.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridMonday1700.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtMonday1700.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplMonday1700.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtMonday1700.Rows[i][0] = temp.ToString().Trim();


                }
            }
            catch (Exception)
            {
                //
            }

            //18:10-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataMonday1810.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataMonday1810.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplMonday1810.Rows[i][j].ToString());
                        DbClass.dtOplMonday1810.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridMonday1810.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridMonday1810.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtMonday1810.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplMonday1810.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtMonday1810.Rows[i][0] = temp.ToString().Trim();


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

        public Monday()
        {
            InitializeComponent();

            //вівторок-----------------------------------------------------------------------------------
            //14:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM monday1400;";
            DbClass.cmdMonday1400.CommandType = CommandType.Text;
            DbClass.cmdMonday1400.CommandText = DbClass.sqlusers;
            DbClass.daMonday1400 = new SqlDataAdapter(DbClass.cmdMonday1400);
            DbClass.dtMonday1400 = new DataTable();
            DbClass.daMonday1400.Fill(DbClass.dtMonday1400);
            SqlCommandBuilder comandbuilderMonday1400 = new SqlCommandBuilder(DbClass.daMonday1400);

            //оплата
            DbClass.sqlusers = "SELECT * FROM mondayOplata1400;";
            DbClass.cmdOplMonday1400.CommandType = CommandType.Text;
            DbClass.cmdOplMonday1400.CommandText = DbClass.sqlusers;
            DbClass.daOplMonday1400 = new SqlDataAdapter(DbClass.cmdOplMonday1400);
            DbClass.dtOplMonday1400 = new DataTable();
            DbClass.daOplMonday1400.Fill(DbClass.dtOplMonday1400);
            SqlCommandBuilder comandbuilderOplMonday1400 = new SqlCommandBuilder(DbClass.daOplMonday1400);

            //15:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM monday1500;";
            DbClass.cmdMonday1500.CommandType = CommandType.Text;
            DbClass.cmdMonday1500.CommandText = DbClass.sqlusers;
            DbClass.daMonday1500 = new SqlDataAdapter(DbClass.cmdMonday1500);
            DbClass.dtMonday1500 = new DataTable();
            DbClass.daMonday1500.Fill(DbClass.dtMonday1500);
            SqlCommandBuilder comandbuilderMonday1500 = new SqlCommandBuilder(DbClass.daMonday1500);

            //оплата
            DbClass.sqlusers = "SELECT * FROM mondayOplata1500;";
            DbClass.cmdOplMonday1500.CommandType = CommandType.Text;
            DbClass.cmdOplMonday1500.CommandText = DbClass.sqlusers;
            DbClass.daOplMonday1500 = new SqlDataAdapter(DbClass.cmdOplMonday1500);
            DbClass.dtOplMonday1500 = new DataTable();
            DbClass.daOplMonday1500.Fill(DbClass.dtOplMonday1500);
            SqlCommandBuilder comandbuilderOplMonday1500 = new SqlCommandBuilder(DbClass.daOplMonday1500);


            //16:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM monday1600;";
            DbClass.cmdMonday1600.CommandType = CommandType.Text;
            DbClass.cmdMonday1600.CommandText = DbClass.sqlusers;
            DbClass.daMonday1600 = new SqlDataAdapter(DbClass.cmdMonday1600);
            DbClass.dtMonday1600 = new DataTable();
            DbClass.daMonday1600.Fill(DbClass.dtMonday1600);
            SqlCommandBuilder comandbuilderMonday1600 = new SqlCommandBuilder(DbClass.daMonday1600);


            //оплата
            DbClass.sqlusers = "SELECT * FROM mondayOplata1600;";
            DbClass.cmdOplMonday1600.CommandType = CommandType.Text;
            DbClass.cmdOplMonday1600.CommandText = DbClass.sqlusers;
            DbClass.daOplMonday1600 = new SqlDataAdapter(DbClass.cmdOplMonday1600);
            DbClass.dtOplMonday1600 = new DataTable();
            DbClass.daOplMonday1600.Fill(DbClass.dtOplMonday1600);
            SqlCommandBuilder comandbuilderOplMonday1600 = new SqlCommandBuilder(DbClass.daOplMonday1600);



            //17:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM monday1700;";
            DbClass.cmdMonday1700.CommandType = CommandType.Text;
            DbClass.cmdMonday1700.CommandText = DbClass.sqlusers;
            DbClass.daMonday1700 = new SqlDataAdapter(DbClass.cmdMonday1700);
            DbClass.dtMonday1700 = new DataTable();
            DbClass.daMonday1700.Fill(DbClass.dtMonday1700);
            SqlCommandBuilder comandbuilderMonday1700 = new SqlCommandBuilder(DbClass.daMonday1700);

            //оплата
            DbClass.sqlusers = "SELECT * FROM mondayOplata1700;";
            DbClass.cmdOplMonday1700.CommandType = CommandType.Text;
            DbClass.cmdOplMonday1700.CommandText = DbClass.sqlusers;
            DbClass.daOplMonday1700 = new SqlDataAdapter(DbClass.cmdOplMonday1700);
            DbClass.dtOplMonday1700 = new DataTable();
            DbClass.daOplMonday1700.Fill(DbClass.dtOplMonday1700);
            SqlCommandBuilder comandbuilderOplMonday1700 = new SqlCommandBuilder(DbClass.daOplMonday1700);

            //18:10----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM monday1810;";
            DbClass.cmdMonday1810.CommandType = CommandType.Text;
            DbClass.cmdMonday1810.CommandText = DbClass.sqlusers;
            DbClass.daMonday1810 = new SqlDataAdapter(DbClass.cmdMonday1810);
            DbClass.dtMonday1810 = new DataTable();
            DbClass.daMonday1810.Fill(DbClass.dtMonday1810);
            SqlCommandBuilder comandbuilderMonday1810 = new SqlCommandBuilder(DbClass.daMonday1810);

            //оплата
            DbClass.sqlusers = "SELECT * FROM mondayOplata1810;";
            DbClass.cmdOplMonday1810.CommandType = CommandType.Text;
            DbClass.cmdOplMonday1810.CommandText = DbClass.sqlusers;
            DbClass.daOplMonday1810 = new SqlDataAdapter(DbClass.cmdOplMonday1810);
            DbClass.dtOplMonday1810 = new DataTable();
            DbClass.daOplMonday1810.Fill(DbClass.dtOplMonday1810);
            SqlCommandBuilder comandbuilderOplMonday1810 = new SqlCommandBuilder(DbClass.daOplMonday1810);

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



        private void TabItemOplataMonday1400_Selected(object sender, RoutedEventArgs e)
        {
            //14:00----------------------------------------------------------------------------------

            rename_Columns();

        }



        private void myDataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            myDataGridMonday1400.ItemsSource = DbClass.dtMonday1400.DefaultView;
            myDataGridOplataMonday1400.ItemsSource = DbClass.dtOplMonday1400.DefaultView;
            
            myDataGridMonday1500.ItemsSource = DbClass.dtMonday1500.DefaultView;
            myDataGridOplataMonday1500.ItemsSource = DbClass.dtOplMonday1500.DefaultView;

            myDataGridMonday1600.ItemsSource = DbClass.dtMonday1600.DefaultView;
            myDataGridOplataMonday1600.ItemsSource = DbClass.dtOplMonday1600.DefaultView;

            myDataGridMonday1700.ItemsSource = DbClass.dtMonday1700.DefaultView;
            myDataGridOplataMonday1700.ItemsSource = DbClass.dtOplMonday1700.DefaultView;

            myDataGridMonday1810.ItemsSource = DbClass.dtMonday1810.DefaultView;
            myDataGridOplataMonday1810.ItemsSource = DbClass.dtOplMonday1810.DefaultView;

            count_Plus();
            rename_Columns();
        }

        private void myDataGridMonday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daMonday1400.Update(DbClass.dtMonday1400);

        }

        private void myDataGridMonday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daMonday1500.Update(DbClass.dtMonday1500);
        }

        private void myDataGridMonday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daMonday1600.Update(DbClass.dtMonday1600);
        }

        private void myDataGridMonday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daMonday1700.Update(DbClass.dtMonday1700);
        }

        private void myDataGridMonday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daMonday1810.Update(DbClass.dtMonday1810);
        }

        private void myDataGridOplataMonday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplMonday1400.Update(DbClass.dtOplMonday1400);
        }

        private void myDataGridOplataMonday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplMonday1500.Update(DbClass.dtOplMonday1500);
        }

        private void myDataGridOplataMonday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplMonday1600.Update(DbClass.dtOplMonday1600);
        }

        private void myDataGridOplataMonday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplMonday1700.Update(DbClass.dtOplMonday1700);
        }

        private void myDataGridOplataMonday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplMonday1810.Update(DbClass.dtOplMonday1810);
        }
    }
}