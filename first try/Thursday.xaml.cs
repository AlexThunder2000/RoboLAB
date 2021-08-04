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
    /// Логика взаимодействия для Thursday.xaml
    /// </summary>
    public partial class Thursday : Window
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
                SqlCommandBuilder comandbuilderThursday1400 = new SqlCommandBuilder(DbClass.daThursday1400);
                DbClass.cmdThursday1400.CommandText = "ALTER TABLE Thursday1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdThursday1400.ExecuteNonQuery();
                DbClass.cmdThursday1400.CommandText = "UPDATE Thursday1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdThursday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1400;";
                DbClass.cmdThursday1400.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1400 = new DataTable();
                DbClass.daThursday1400.Fill(DbClass.dtThursday1400);
                myDataGridThursday1400.ItemsSource = DbClass.dtThursday1400.DefaultView;
                DbClass.daThursday1400.Update(DbClass.dtThursday1400);

                SqlCommandBuilder comandbuilderOplThursday1400 = new SqlCommandBuilder(DbClass.daOplThursday1400);
                DbClass.cmdOplThursday1400.CommandText = "ALTER TABLE ThursdayOplata1400 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplThursday1400.ExecuteNonQuery();
                DbClass.cmdOplThursday1400.CommandText = "UPDATE ThursdayOplata1400 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplThursday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1400;";
                DbClass.cmdOplThursday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1400 = new DataTable();
                DbClass.daOplThursday1400.Fill(DbClass.dtOplThursday1400);
                myDataGridOplataThursday1400.ItemsSource = DbClass.dtOplThursday1400.DefaultView;
                DbClass.daOplThursday1400.Update(DbClass.dtOplThursday1400);


                //15:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderThursday1500 = new SqlCommandBuilder(DbClass.daThursday1500);
                DbClass.cmdThursday1500.CommandText = "ALTER TABLE Thursday1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdThursday1500.ExecuteNonQuery();
                DbClass.cmdThursday1500.CommandText = "UPDATE Thursday1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdThursday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1500;";
                DbClass.cmdThursday1500.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1500 = new DataTable();
                DbClass.daThursday1500.Fill(DbClass.dtThursday1500);
                myDataGridThursday1500.ItemsSource = DbClass.dtThursday1500.DefaultView;
                DbClass.daThursday1500.Update(DbClass.dtThursday1500);

                SqlCommandBuilder comandbuilderOplThursday1500 = new SqlCommandBuilder(DbClass.daOplThursday1500);
                DbClass.cmdOplThursday1500.CommandText = "ALTER TABLE ThursdayOplata1500 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplThursday1500.ExecuteNonQuery();
                DbClass.cmdOplThursday1500.CommandText = "UPDATE ThursdayOplata1500 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplThursday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1500;";
                DbClass.cmdOplThursday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1500 = new DataTable();
                DbClass.daOplThursday1500.Fill(DbClass.dtOplThursday1500);
                myDataGridOplataThursday1500.ItemsSource = DbClass.dtOplThursday1500.DefaultView;
                DbClass.daOplThursday1500.Update(DbClass.dtOplThursday1500);

                //16:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderThursday1600 = new SqlCommandBuilder(DbClass.daThursday1600);
                DbClass.cmdThursday1600.CommandText = "ALTER TABLE Thursday1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdThursday1600.ExecuteNonQuery();
                DbClass.cmdThursday1600.CommandText = "UPDATE Thursday1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdThursday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1600;";
                DbClass.cmdThursday1600.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1600 = new DataTable();
                DbClass.daThursday1600.Fill(DbClass.dtThursday1600);
                myDataGridThursday1600.ItemsSource = DbClass.dtThursday1600.DefaultView;
                DbClass.daThursday1600.Update(DbClass.dtThursday1600);

                SqlCommandBuilder comandbuilderOplThursday1600 = new SqlCommandBuilder(DbClass.daOplThursday1600);
                DbClass.cmdOplThursday1600.CommandText = "ALTER TABLE ThursdayOplata1600 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplThursday1600.ExecuteNonQuery();
                DbClass.cmdOplThursday1600.CommandText = "UPDATE ThursdayOplata1600 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplThursday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1600;";
                DbClass.cmdOplThursday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1600 = new DataTable();
                DbClass.daOplThursday1600.Fill(DbClass.dtOplThursday1600);
                myDataGridOplataThursday1600.ItemsSource = DbClass.dtOplThursday1600.DefaultView;
                DbClass.daOplThursday1600.Update(DbClass.dtOplThursday1600);

                //17:00--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderThursday1700 = new SqlCommandBuilder(DbClass.daThursday1700);
                DbClass.cmdThursday1700.CommandText = "ALTER TABLE Thursday1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdThursday1700.ExecuteNonQuery();
                DbClass.cmdThursday1700.CommandText = "UPDATE Thursday1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdThursday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1700;";
                DbClass.cmdThursday1700.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1700 = new DataTable();
                DbClass.daThursday1700.Fill(DbClass.dtThursday1700);
                myDataGridThursday1700.ItemsSource = DbClass.dtThursday1700.DefaultView;
                DbClass.daThursday1700.Update(DbClass.dtThursday1700);

                SqlCommandBuilder comandbuilderOplThursday1700 = new SqlCommandBuilder(DbClass.daOplThursday1700);
                DbClass.cmdOplThursday1700.CommandText = "ALTER TABLE ThursdayOplata1700 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplThursday1700.ExecuteNonQuery();
                DbClass.cmdOplThursday1700.CommandText = "UPDATE ThursdayOplata1700 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplThursday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1700;";
                DbClass.cmdOplThursday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1700 = new DataTable();
                DbClass.daOplThursday1700.Fill(DbClass.dtOplThursday1700);
                myDataGridOplataThursday1700.ItemsSource = DbClass.dtOplThursday1700.DefaultView;
                DbClass.daOplThursday1700.Update(DbClass.dtOplThursday1700);

                //18:10--------------------------------------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderThursday1810 = new SqlCommandBuilder(DbClass.daThursday1810);
                DbClass.cmdThursday1810.CommandText = "ALTER TABLE Thursday1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdThursday1810.ExecuteNonQuery();
                DbClass.cmdThursday1810.CommandText = "UPDATE Thursday1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdThursday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1810;";
                DbClass.cmdThursday1810.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1810 = new DataTable();
                DbClass.daThursday1810.Fill(DbClass.dtThursday1810);
                myDataGridThursday1810.ItemsSource = DbClass.dtThursday1810.DefaultView;
                DbClass.daThursday1810.Update(DbClass.dtThursday1810);

                SqlCommandBuilder comandbuilderOplThursday1810 = new SqlCommandBuilder(DbClass.daOplThursday1810);
                DbClass.cmdOplThursday1810.CommandText = "ALTER TABLE ThursdayOplata1810 ADD [data" + data + "] nchar(10)  NULL; ";
                DbClass.cmdOplThursday1810.ExecuteNonQuery();
                DbClass.cmdOplThursday1810.CommandText = "UPDATE ThursdayOplata1810 SET [data" + data + "] = 0  WHERE [data" + data + "] IS NULL";
                DbClass.cmdOplThursday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1810;";
                DbClass.cmdOplThursday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1810 = new DataTable();
                DbClass.daOplThursday1810.Fill(DbClass.dtOplThursday1810);
                myDataGridOplataThursday1810.ItemsSource = DbClass.dtOplThursday1810.DefaultView;
                DbClass.daOplThursday1810.Update(DbClass.dtOplThursday1810);

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
                SqlCommandBuilder comandbuilderThursday1400 = new SqlCommandBuilder(DbClass.daThursday1400);
                DbClass.cmdThursday1400.CommandText = "ALTER TABLE Thursday1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdThursday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1400;";
                DbClass.cmdThursday1400.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1400 = new DataTable();
                DbClass.daThursday1400.Fill(DbClass.dtThursday1400);
                myDataGridThursday1400.ItemsSource = DbClass.dtThursday1400.DefaultView;
                DbClass.daThursday1400.Update(DbClass.dtThursday1400);

                SqlCommandBuilder comandbuilderOplThursday1400 = new SqlCommandBuilder(DbClass.daOplThursday1400);
                DbClass.cmdOplThursday1400.CommandText = "ALTER TABLE ThursdayOplata1400 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplThursday1400.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1400;";
                DbClass.cmdOplThursday1400.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1400 = new DataTable();
                DbClass.daOplThursday1400.Fill(DbClass.dtOplThursday1400);
                myDataGridOplataThursday1400.ItemsSource = DbClass.dtOplThursday1400.DefaultView;
                DbClass.daOplThursday1400.Update(DbClass.dtOplThursday1400);


                //15:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderThursday1500 = new SqlCommandBuilder(DbClass.daThursday1500);
                DbClass.cmdThursday1500.CommandText = "ALTER TABLE Thursday1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdThursday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1500;";
                DbClass.cmdThursday1500.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1500 = new DataTable();
                DbClass.daThursday1500.Fill(DbClass.dtThursday1500);
                myDataGridThursday1500.ItemsSource = DbClass.dtThursday1500.DefaultView;
                DbClass.daThursday1500.Update(DbClass.dtThursday1500);

                SqlCommandBuilder comandbuilderOplThursday1500 = new SqlCommandBuilder(DbClass.daOplThursday1500);
                DbClass.cmdOplThursday1500.CommandText = "ALTER TABLE ThursdayOplata1500 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplThursday1500.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1500;";
                DbClass.cmdOplThursday1500.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1500 = new DataTable();
                DbClass.daOplThursday1500.Fill(DbClass.dtOplThursday1500);
                myDataGridOplataThursday1500.ItemsSource = DbClass.dtOplThursday1500.DefaultView;
                DbClass.daOplThursday1500.Update(DbClass.dtOplThursday1500);


                //16:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderThursday1600 = new SqlCommandBuilder(DbClass.daThursday1600);
                DbClass.cmdThursday1600.CommandText = "ALTER TABLE Thursday1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdThursday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1600;";
                DbClass.cmdThursday1600.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1600 = new DataTable();
                DbClass.daThursday1600.Fill(DbClass.dtThursday1600);
                myDataGridThursday1600.ItemsSource = DbClass.dtThursday1600.DefaultView;
                DbClass.daThursday1600.Update(DbClass.dtThursday1600);

                SqlCommandBuilder comandbuilderOplThursday1600 = new SqlCommandBuilder(DbClass.daOplThursday1600);
                DbClass.cmdOplThursday1600.CommandText = "ALTER TABLE ThursdayOplata1600 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplThursday1600.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1600;";
                DbClass.cmdOplThursday1600.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1600 = new DataTable();
                DbClass.daOplThursday1600.Fill(DbClass.dtOplThursday1600);
                myDataGridOplataThursday1600.ItemsSource = DbClass.dtOplThursday1600.DefaultView;
                DbClass.daOplThursday1600.Update(DbClass.dtOplThursday1600);


                //17:00-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderThursday1700 = new SqlCommandBuilder(DbClass.daThursday1700);
                DbClass.cmdThursday1700.CommandText = "ALTER TABLE Thursday1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdThursday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1700;";
                DbClass.cmdThursday1700.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1700 = new DataTable();
                DbClass.daThursday1700.Fill(DbClass.dtThursday1700);
                myDataGridThursday1700.ItemsSource = DbClass.dtThursday1700.DefaultView;
                DbClass.daThursday1700.Update(DbClass.dtThursday1700);

                SqlCommandBuilder comandbuilderOplThursday1700 = new SqlCommandBuilder(DbClass.daOplThursday1700);
                DbClass.cmdOplThursday1700.CommandText = "ALTER TABLE ThursdayOplata1700 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplThursday1700.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1700;";
                DbClass.cmdOplThursday1700.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1700 = new DataTable();
                DbClass.daOplThursday1700.Fill(DbClass.dtOplThursday1700);
                myDataGridOplataThursday1700.ItemsSource = DbClass.dtOplThursday1700.DefaultView;
                DbClass.daOplThursday1700.Update(DbClass.dtOplThursday1700);


                //18:10-----------------------------------------------------------------------------------------
                SqlCommandBuilder comandbuilderThursday1810 = new SqlCommandBuilder(DbClass.daThursday1810);
                DbClass.cmdThursday1810.CommandText = "ALTER TABLE Thursday1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdThursday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM Thursday1810;";
                DbClass.cmdThursday1810.CommandText = DbClass.sqlusers;
                DbClass.dtThursday1810 = new DataTable();
                DbClass.daThursday1810.Fill(DbClass.dtThursday1810);
                myDataGridThursday1810.ItemsSource = DbClass.dtThursday1810.DefaultView;
                DbClass.daThursday1810.Update(DbClass.dtThursday1810);

                SqlCommandBuilder comandbuilderOplThursday1810 = new SqlCommandBuilder(DbClass.daOplThursday1810);
                DbClass.cmdOplThursday1810.CommandText = "ALTER TABLE ThursdayOplata1810 DROP COLUMN [data" + data + "] ;";
                DbClass.cmdOplThursday1810.ExecuteNonQuery();
                DbClass.sqlusers = "SELECT * FROM ThursdayOplata1810;";
                DbClass.cmdOplThursday1810.CommandText = DbClass.sqlusers;
                DbClass.dtOplThursday1810 = new DataTable();
                DbClass.daOplThursday1810.Fill(DbClass.dtOplThursday1810);
                myDataGridOplataThursday1810.ItemsSource = DbClass.dtOplThursday1810.DefaultView;
                DbClass.daOplThursday1810.Update(DbClass.dtOplThursday1810);

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

                myDataGridThursday1400.Columns[0].Header = "Залишок";
                myDataGridThursday1400.Columns[1].Header = "ПІБ";
                for (int i = myDataGridThursday1400.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridThursday1400.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridThursday1400.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridThursday1400.Columns[i].Header = column_header;
                }


            }
            catch (Exception)
            {

                //
            }
            //оплата-------------------------------------------------------------------
            try
            {
                myDataGridOplataThursday1400.Columns[0].Header = "Оплачено";
                myDataGridOplataThursday1400.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataThursday1400.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataThursday1400.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataThursday1400.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataThursday1400.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                //
            }
            //15:00--------------------------------------------------------------------
            try
            {

                myDataGridThursday1500.Columns[0].Header = "Залишок";
                myDataGridThursday1500.Columns[1].Header = "ПІБ";
                for (int i = myDataGridThursday1500.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridThursday1500.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridThursday1500.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridThursday1500.Columns[i].Header = column_header;
                }

                myDataGridOplataThursday1500.Columns[0].Header = "Оплачено";
                myDataGridOplataThursday1500.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataThursday1500.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataThursday1500.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataThursday1500.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataThursday1500.Columns[j].Header = column_header;

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
                myDataGridThursday1600.Columns[0].Header = "Залишок";
                myDataGridThursday1600.Columns[1].Header = "ПІБ";
                for (int i = myDataGridThursday1600.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridThursday1600.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridThursday1600.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridThursday1600.Columns[i].Header = column_header;
                }

                myDataGridOplataThursday1600.Columns[0].Header = "Оплачено";
                myDataGridOplataThursday1600.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataThursday1600.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataThursday1600.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataThursday1600.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataThursday1600.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename16");

            }

            //17:00--------------------------------------------------------------------
            try
            {
                myDataGridThursday1700.Columns[0].Header = "Залишок";
                myDataGridThursday1700.Columns[1].Header = "ПІБ";
                for (int i = myDataGridThursday1700.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridThursday1700.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridThursday1700.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridThursday1700.Columns[i].Header = column_header;
                }


                myDataGridOplataThursday1700.Columns[0].Header = "Оплачено";
                myDataGridOplataThursday1700.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataThursday1700.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataThursday1700.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataThursday1700.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataThursday1700.Columns[j].Header = column_header;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("rename17");

            }

            //18:10--------------------------------------------------------------------
            try
            {
                myDataGridThursday1810.Columns[0].Header = "Залишок";
                myDataGridThursday1810.Columns[1].Header = "ПІБ";
                for (int i = myDataGridThursday1810.Columns.Count - 1; i > 1; i--)
                {
                    if (myDataGridThursday1810.Columns[i].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridThursday1810.Columns[i].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridThursday1810.Columns[i].Header = column_header;
                }


                myDataGridOplataThursday1810.Columns[0].Header = "Оплачено";
                myDataGridOplataThursday1810.Columns[1].Header = "ПІБ";

                for (int j = myDataGridOplataThursday1810.Columns.Count - 1; j > 1; j--)
                {
                    if (myDataGridOplataThursday1810.Columns[j].Header.ToString().Length <= 5)
                    {
                        continue;
                    }
                    string column_header = myDataGridOplataThursday1810.Columns[j].Header.ToString();
                    column_header = column_header.Remove(0, 4);
                    column_header = column_header.Insert(2, "/");
                    myDataGridOplataThursday1810.Columns[j].Header = column_header;

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
                for (int i = 0; i < myDataGridOplataThursday1400.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataThursday1400.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplThursday1400.Rows[i][j].ToString());
                        DbClass.dtOplThursday1400.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridThursday1400.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridThursday1400.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtThursday1400.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplThursday1400.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtThursday1400.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }
            //15:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataThursday1500.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataThursday1500.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplThursday1500.Rows[i][j].ToString());
                        DbClass.dtOplThursday1500.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridThursday1500.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridThursday1500.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtThursday1500.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplThursday1500.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtThursday1500.Rows[i][0] = temp.ToString().Trim();


                }


            }
            catch (Exception)
            {
                //
            }

            //16:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataThursday1600.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataThursday1600.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplThursday1600.Rows[i][j].ToString());
                        DbClass.dtOplThursday1600.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridThursday1600.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridThursday1600.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtThursday1600.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplThursday1600.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtThursday1600.Rows[i][0] = temp.ToString().Trim();


                }



            }
            catch (Exception)
            {
                //
            }

            //17:00-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataThursday1700.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataThursday1700.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplThursday1700.Rows[i][j].ToString());
                        DbClass.dtOplThursday1700.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridThursday1700.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridThursday1700.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtThursday1700.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplThursday1700.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtThursday1700.Rows[i][0] = temp.ToString().Trim();


                }
            }
            catch (Exception)
            {
                //
            }

            //18:10-------------------------------------------------------------------------
            try
            {
                for (int i = 0; i < myDataGridOplataThursday1810.Items.Count - 1; i++)
                {
                    int oplataCount = 0;

                    for (int j = myDataGridOplataThursday1810.Columns.Count - 1; j > 1; j--)
                    {
                        oplataCount += int.Parse(DbClass.dtOplThursday1810.Rows[i][j].ToString());
                        DbClass.dtOplThursday1810.Rows[i][0] = oplataCount.ToString().Trim();
                    }

                }

                for (int i = 0; i < myDataGridThursday1810.Items.Count - 1; i++)
                {
                    int plusCount = 0;
                    for (int j = myDataGridThursday1810.Columns.Count - 1; j > 1; j--)
                    {

                        if ((DbClass.dtThursday1810.Rows[i][j].ToString().Trim() == "+"))
                        {
                            plusCount++;
                        }
                    }

                    int temp = int.Parse(DbClass.dtOplThursday1810.Rows[i][0].ToString()) - plusCount;
                    DbClass.dtThursday1810.Rows[i][0] = temp.ToString().Trim();


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

        public Thursday()
        {
            InitializeComponent();

            //вівторок-----------------------------------------------------------------------------------
            //14:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM thursday1400;";
            DbClass.cmdThursday1400.CommandType = CommandType.Text;
            DbClass.cmdThursday1400.CommandText = DbClass.sqlusers;
            DbClass.daThursday1400 = new SqlDataAdapter(DbClass.cmdThursday1400);
            DbClass.dtThursday1400 = new DataTable();
            DbClass.daThursday1400.Fill(DbClass.dtThursday1400);
            SqlCommandBuilder comandbuilderThursday1400 = new SqlCommandBuilder(DbClass.daThursday1400);

            //оплата
            DbClass.sqlusers = "SELECT * FROM thursdayOplata1400;";
            DbClass.cmdOplThursday1400.CommandType = CommandType.Text;
            DbClass.cmdOplThursday1400.CommandText = DbClass.sqlusers;
            DbClass.daOplThursday1400 = new SqlDataAdapter(DbClass.cmdOplThursday1400);
            DbClass.dtOplThursday1400 = new DataTable();
            DbClass.daOplThursday1400.Fill(DbClass.dtOplThursday1400);
            SqlCommandBuilder comandbuilderOplThursday1400 = new SqlCommandBuilder(DbClass.daOplThursday1400);

            //15:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM thursday1500;";
            DbClass.cmdThursday1500.CommandType = CommandType.Text;
            DbClass.cmdThursday1500.CommandText = DbClass.sqlusers;
            DbClass.daThursday1500 = new SqlDataAdapter(DbClass.cmdThursday1500);
            DbClass.dtThursday1500 = new DataTable();
            DbClass.daThursday1500.Fill(DbClass.dtThursday1500);
            SqlCommandBuilder comandbuilderThursday1500 = new SqlCommandBuilder(DbClass.daThursday1500);

            //оплата
            DbClass.sqlusers = "SELECT * FROM thursdayOplata1500;";
            DbClass.cmdOplThursday1500.CommandType = CommandType.Text;
            DbClass.cmdOplThursday1500.CommandText = DbClass.sqlusers;
            DbClass.daOplThursday1500 = new SqlDataAdapter(DbClass.cmdOplThursday1500);
            DbClass.dtOplThursday1500 = new DataTable();
            DbClass.daOplThursday1500.Fill(DbClass.dtOplThursday1500);
            SqlCommandBuilder comandbuilderOplThursday1500 = new SqlCommandBuilder(DbClass.daOplThursday1500);


            //16:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM thursday1600;";
            DbClass.cmdThursday1600.CommandType = CommandType.Text;
            DbClass.cmdThursday1600.CommandText = DbClass.sqlusers;
            DbClass.daThursday1600 = new SqlDataAdapter(DbClass.cmdThursday1600);
            DbClass.dtThursday1600 = new DataTable();
            DbClass.daThursday1600.Fill(DbClass.dtThursday1600);
            SqlCommandBuilder comandbuilderThursday1600 = new SqlCommandBuilder(DbClass.daThursday1600);


            //оплата
            DbClass.sqlusers = "SELECT * FROM thursdayOplata1600;";
            DbClass.cmdOplThursday1600.CommandType = CommandType.Text;
            DbClass.cmdOplThursday1600.CommandText = DbClass.sqlusers;
            DbClass.daOplThursday1600 = new SqlDataAdapter(DbClass.cmdOplThursday1600);
            DbClass.dtOplThursday1600 = new DataTable();
            DbClass.daOplThursday1600.Fill(DbClass.dtOplThursday1600);
            SqlCommandBuilder comandbuilderOplThursday1600 = new SqlCommandBuilder(DbClass.daOplThursday1600);



            //17:00----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM thursday1700;";
            DbClass.cmdThursday1700.CommandType = CommandType.Text;
            DbClass.cmdThursday1700.CommandText = DbClass.sqlusers;
            DbClass.daThursday1700 = new SqlDataAdapter(DbClass.cmdThursday1700);
            DbClass.dtThursday1700 = new DataTable();
            DbClass.daThursday1700.Fill(DbClass.dtThursday1700);
            SqlCommandBuilder comandbuilderThursday1700 = new SqlCommandBuilder(DbClass.daThursday1700);

            //оплата
            DbClass.sqlusers = "SELECT * FROM thursdayOplata1700;";
            DbClass.cmdOplThursday1700.CommandType = CommandType.Text;
            DbClass.cmdOplThursday1700.CommandText = DbClass.sqlusers;
            DbClass.daOplThursday1700 = new SqlDataAdapter(DbClass.cmdOplThursday1700);
            DbClass.dtOplThursday1700 = new DataTable();
            DbClass.daOplThursday1700.Fill(DbClass.dtOplThursday1700);
            SqlCommandBuilder comandbuilderOplThursday1700 = new SqlCommandBuilder(DbClass.daOplThursday1700);

            //18:10----------------------------------------------------------------------------------
            // відвідування
            DbClass.sqlusers = "SELECT * FROM thursday1810;";
            DbClass.cmdThursday1810.CommandType = CommandType.Text;
            DbClass.cmdThursday1810.CommandText = DbClass.sqlusers;
            DbClass.daThursday1810 = new SqlDataAdapter(DbClass.cmdThursday1810);
            DbClass.dtThursday1810 = new DataTable();
            DbClass.daThursday1810.Fill(DbClass.dtThursday1810);
            SqlCommandBuilder comandbuilderThursday1810 = new SqlCommandBuilder(DbClass.daThursday1810);

            //оплата
            DbClass.sqlusers = "SELECT * FROM thursdayOplata1810;";
            DbClass.cmdOplThursday1810.CommandType = CommandType.Text;
            DbClass.cmdOplThursday1810.CommandText = DbClass.sqlusers;
            DbClass.daOplThursday1810 = new SqlDataAdapter(DbClass.cmdOplThursday1810);
            DbClass.dtOplThursday1810 = new DataTable();
            DbClass.daOplThursday1810.Fill(DbClass.dtOplThursday1810);
            SqlCommandBuilder comandbuilderOplThursday1810 = new SqlCommandBuilder(DbClass.daOplThursday1810);

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



        private void TabItemOplataThursday1400_Selected(object sender, RoutedEventArgs e)
        {
            //14:00----------------------------------------------------------------------------------

            rename_Columns();

        }



        private void myDataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            myDataGridThursday1400.ItemsSource = DbClass.dtThursday1400.DefaultView;
            myDataGridOplataThursday1400.ItemsSource = DbClass.dtOplThursday1400.DefaultView;

            myDataGridThursday1500.ItemsSource = DbClass.dtThursday1500.DefaultView;
            myDataGridOplataThursday1500.ItemsSource = DbClass.dtOplThursday1500.DefaultView;

            myDataGridThursday1600.ItemsSource = DbClass.dtThursday1600.DefaultView;
            myDataGridOplataThursday1600.ItemsSource = DbClass.dtOplThursday1600.DefaultView;

            myDataGridThursday1700.ItemsSource = DbClass.dtThursday1700.DefaultView;
            myDataGridOplataThursday1700.ItemsSource = DbClass.dtOplThursday1700.DefaultView;

            myDataGridThursday1810.ItemsSource = DbClass.dtThursday1810.DefaultView;
            myDataGridOplataThursday1810.ItemsSource = DbClass.dtOplThursday1810.DefaultView;

            count_Plus();
            rename_Columns();
        }

        private void myDataGridThursday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daThursday1400.Update(DbClass.dtThursday1400);

        }

        private void myDataGridThursday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daThursday1500.Update(DbClass.dtThursday1500);
        }

        private void myDataGridThursday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daThursday1600.Update(DbClass.dtThursday1600);
        }

        private void myDataGridThursday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daThursday1700.Update(DbClass.dtThursday1700);
        }

        private void myDataGridThursday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daThursday1810.Update(DbClass.dtThursday1810);
        }

        private void myDataGridOplataThursday1400_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplThursday1400.Update(DbClass.dtOplThursday1400);
        }

        private void myDataGridOplataThursday1500_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplThursday1500.Update(DbClass.dtOplThursday1500);
        }

        private void myDataGridOplataThursday1600_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplThursday1600.Update(DbClass.dtOplThursday1600);
        }

        private void myDataGridOplataThursday1700_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplThursday1700.Update(DbClass.dtOplThursday1700);
        }

        private void myDataGridOplataThursday1810_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            count_Plus();
            DbClass.daOplThursday1810.Update(DbClass.dtOplThursday1810);
        }
    }
}