using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;

namespace first_try.classes
{
   
        class DbClass
        {
            public static string GetConnectionStrings()
            {
                string strConString = ConfigurationManager.ConnectionStrings["conString"].ToString();
                return strConString;
            }
        //лог і пас--------------------------------------------------------------------------------
            public static string sqlusers;
            public static SqlConnection conusers = new SqlConnection();
            public static SqlCommand cmdusers = new SqlCommand("", conusers);
            public static DataTable dtusers;
            public static SqlDataAdapter dausers;
        //Понеділок-----------------------------------------------------------------------------------
            
            public static SqlCommand cmdMonday1400 = new SqlCommand("", conusers);      
            public static DataTable dtMonday1400;
            public static SqlDataAdapter daMonday1400;

            
            public static SqlCommand cmdOplMonday1400 = new SqlCommand("", conusers);
            public static DataTable dtOplMonday1400;
            public static SqlDataAdapter daOplMonday1400;

            
            public static SqlCommand cmdMonday1500 = new SqlCommand("", conusers);
            public static DataTable dtMonday1500;
            public static SqlDataAdapter daMonday1500;

            
            public static SqlCommand cmdOplMonday1500 = new SqlCommand("", conusers);
            public static DataTable dtOplMonday1500;
            public static SqlDataAdapter daOplMonday1500;

           
            public static SqlCommand cmdMonday1600 = new SqlCommand("", conusers);
            public static DataTable dtMonday1600;
            public static SqlDataAdapter daMonday1600;

           
            public static SqlCommand cmdOplMonday1600 = new SqlCommand("", conusers);
            public static DataTable dtOplMonday1600;
            public static SqlDataAdapter daOplMonday1600;

            
            public static SqlCommand cmdMonday1700 = new SqlCommand("", conusers);
            public static DataTable dtMonday1700;
            public static SqlDataAdapter daMonday1700;


            public static SqlCommand cmdOplMonday1700 = new SqlCommand("", conusers);
            public static DataTable dtOplMonday1700;
            public static SqlDataAdapter daOplMonday1700;

      
            public static SqlCommand cmdMonday1810 = new SqlCommand("", conusers);
            public static DataTable dtMonday1810;
            public static SqlDataAdapter daMonday1810;


            public static SqlCommand cmdOplMonday1810 = new SqlCommand("", conusers);
            public static DataTable dtOplMonday1810;
            public static SqlDataAdapter daOplMonday1810;
        //вівторок-----------------------------------------------------------------------------------------
        public static SqlCommand cmdTuesday1400 = new SqlCommand("", conusers);
        public static DataTable dtTuesday1400;
        public static SqlDataAdapter daTuesday1400;


        public static SqlCommand cmdOplTuesday1400 = new SqlCommand("", conusers);
        public static DataTable dtOplTuesday1400;
        public static SqlDataAdapter daOplTuesday1400;


        public static SqlCommand cmdTuesday1500 = new SqlCommand("", conusers);
        public static DataTable dtTuesday1500;
        public static SqlDataAdapter daTuesday1500;


        public static SqlCommand cmdOplTuesday1500 = new SqlCommand("", conusers);
        public static DataTable dtOplTuesday1500;
        public static SqlDataAdapter daOplTuesday1500;


        public static SqlCommand cmdTuesday1600 = new SqlCommand("", conusers);
        public static DataTable dtTuesday1600;
        public static SqlDataAdapter daTuesday1600;


        public static SqlCommand cmdOplTuesday1600 = new SqlCommand("", conusers);
        public static DataTable dtOplTuesday1600;
        public static SqlDataAdapter daOplTuesday1600;


        public static SqlCommand cmdTuesday1700 = new SqlCommand("", conusers);
        public static DataTable dtTuesday1700;
        public static SqlDataAdapter daTuesday1700;


        public static SqlCommand cmdOplTuesday1700 = new SqlCommand("", conusers);
        public static DataTable dtOplTuesday1700;
        public static SqlDataAdapter daOplTuesday1700;


        public static SqlCommand cmdTuesday1810 = new SqlCommand("", conusers);
        public static DataTable dtTuesday1810;
        public static SqlDataAdapter daTuesday1810;


        public static SqlCommand cmdOplTuesday1810 = new SqlCommand("", conusers);
        public static DataTable dtOplTuesday1810;
        public static SqlDataAdapter daOplTuesday1810;
        //середа-------------------------------------------------------------------------------------------

        public static SqlCommand cmdWednesday1400 = new SqlCommand("", conusers);
        public static DataTable dtWednesday1400;
        public static SqlDataAdapter daWednesday1400;


        public static SqlCommand cmdOplWednesday1400 = new SqlCommand("", conusers);
        public static DataTable dtOplWednesday1400;
        public static SqlDataAdapter daOplWednesday1400;


        public static SqlCommand cmdWednesday1500 = new SqlCommand("", conusers);
        public static DataTable dtWednesday1500;
        public static SqlDataAdapter daWednesday1500;


        public static SqlCommand cmdOplWednesday1500 = new SqlCommand("", conusers);
        public static DataTable dtOplWednesday1500;
        public static SqlDataAdapter daOplWednesday1500;


        public static SqlCommand cmdWednesday1600 = new SqlCommand("", conusers);
        public static DataTable dtWednesday1600;
        public static SqlDataAdapter daWednesday1600;


        public static SqlCommand cmdOplWednesday1600 = new SqlCommand("", conusers);
        public static DataTable dtOplWednesday1600;
        public static SqlDataAdapter daOplWednesday1600;


        public static SqlCommand cmdWednesday1700 = new SqlCommand("", conusers);
        public static DataTable dtWednesday1700;
        public static SqlDataAdapter daWednesday1700;


        public static SqlCommand cmdOplWednesday1700 = new SqlCommand("", conusers);
        public static DataTable dtOplWednesday1700;
        public static SqlDataAdapter daOplWednesday1700;


        public static SqlCommand cmdWednesday1810 = new SqlCommand("", conusers);
        public static DataTable dtWednesday1810;
        public static SqlDataAdapter daWednesday1810;


        public static SqlCommand cmdOplWednesday1810 = new SqlCommand("", conusers);
        public static DataTable dtOplWednesday1810;
        public static SqlDataAdapter daOplWednesday1810;
        //четвер-------------------------------------------------------------------------------------------

        public static SqlCommand cmdThursday1400 = new SqlCommand("", conusers);
        public static DataTable dtThursday1400;
        public static SqlDataAdapter daThursday1400;


        public static SqlCommand cmdOplThursday1400 = new SqlCommand("", conusers);
        public static DataTable dtOplThursday1400;
        public static SqlDataAdapter daOplThursday1400;


        public static SqlCommand cmdThursday1500 = new SqlCommand("", conusers);
        public static DataTable dtThursday1500;
        public static SqlDataAdapter daThursday1500;


        public static SqlCommand cmdOplThursday1500 = new SqlCommand("", conusers);
        public static DataTable dtOplThursday1500;
        public static SqlDataAdapter daOplThursday1500;


        public static SqlCommand cmdThursday1600 = new SqlCommand("", conusers);
        public static DataTable dtThursday1600;
        public static SqlDataAdapter daThursday1600;


        public static SqlCommand cmdOplThursday1600 = new SqlCommand("", conusers);
        public static DataTable dtOplThursday1600;
        public static SqlDataAdapter daOplThursday1600;


        public static SqlCommand cmdThursday1700 = new SqlCommand("", conusers);
        public static DataTable dtThursday1700;
        public static SqlDataAdapter daThursday1700;


        public static SqlCommand cmdOplThursday1700 = new SqlCommand("", conusers);
        public static DataTable dtOplThursday1700;
        public static SqlDataAdapter daOplThursday1700;


        public static SqlCommand cmdThursday1810 = new SqlCommand("", conusers);
        public static DataTable dtThursday1810;
        public static SqlDataAdapter daThursday1810;


        public static SqlCommand cmdOplThursday1810 = new SqlCommand("", conusers);
        public static DataTable dtOplThursday1810;
        public static SqlDataAdapter daOplThursday1810;
        //п'ятниця-----------------------------------------------------------------------------------------

        public static SqlCommand cmdFriday1400 = new SqlCommand("", conusers);
        public static DataTable dtFriday1400;
        public static SqlDataAdapter daFriday1400;


        public static SqlCommand cmdOplFriday1400 = new SqlCommand("", conusers);
        public static DataTable dtOplFriday1400;
        public static SqlDataAdapter daOplFriday1400;


        public static SqlCommand cmdFriday1500 = new SqlCommand("", conusers);
        public static DataTable dtFriday1500;
        public static SqlDataAdapter daFriday1500;


        public static SqlCommand cmdOplFriday1500 = new SqlCommand("", conusers);
        public static DataTable dtOplFriday1500;
        public static SqlDataAdapter daOplFriday1500;


        public static SqlCommand cmdFriday1600 = new SqlCommand("", conusers);
        public static DataTable dtFriday1600;
        public static SqlDataAdapter daFriday1600;


        public static SqlCommand cmdOplFriday1600 = new SqlCommand("", conusers);
        public static DataTable dtOplFriday1600;
        public static SqlDataAdapter daOplFriday1600;


        public static SqlCommand cmdFriday1700 = new SqlCommand("", conusers);
        public static DataTable dtFriday1700;
        public static SqlDataAdapter daFriday1700;


        public static SqlCommand cmdOplFriday1700 = new SqlCommand("", conusers);
        public static DataTable dtOplFriday1700;
        public static SqlDataAdapter daOplFriday1700;


        public static SqlCommand cmdFriday1810 = new SqlCommand("", conusers);
        public static DataTable dtFriday1810;
        public static SqlDataAdapter daFriday1810;


        public static SqlCommand cmdOplFriday1810 = new SqlCommand("", conusers);
        public static DataTable dtOplFriday1810;
        public static SqlDataAdapter daOplFriday1810;
        //субота------------------------------------------------------------------------------------

        public static SqlCommand cmdSaturday1400 = new SqlCommand("", conusers);
        public static DataTable dtSaturday1400;
        public static SqlDataAdapter daSaturday1400;


        public static SqlCommand cmdOplSaturday1400 = new SqlCommand("", conusers);
        public static DataTable dtOplSaturday1400;
        public static SqlDataAdapter daOplSaturday1400;


        public static SqlCommand cmdSaturday1500 = new SqlCommand("", conusers);
        public static DataTable dtSaturday1500;
        public static SqlDataAdapter daSaturday1500;


        public static SqlCommand cmdOplSaturday1500 = new SqlCommand("", conusers);
        public static DataTable dtOplSaturday1500;
        public static SqlDataAdapter daOplSaturday1500;


        public static SqlCommand cmdSaturday1600 = new SqlCommand("", conusers);
        public static DataTable dtSaturday1600;
        public static SqlDataAdapter daSaturday1600;


        public static SqlCommand cmdOplSaturday1600 = new SqlCommand("", conusers);
        public static DataTable dtOplSaturday1600;
        public static SqlDataAdapter daOplSaturday1600;


        public static SqlCommand cmdSaturday1700 = new SqlCommand("", conusers);
        public static DataTable dtSaturday1700;
        public static SqlDataAdapter daSaturday1700;


        public static SqlCommand cmdOplSaturday1700 = new SqlCommand("", conusers);
        public static DataTable dtOplSaturday1700;
        public static SqlDataAdapter daOplSaturday1700;


        public static SqlCommand cmdSaturday1810 = new SqlCommand("", conusers);
        public static DataTable dtSaturday1810;
        public static SqlDataAdapter daSaturday1810;


        public static SqlCommand cmdOplSaturday1810 = new SqlCommand("", conusers);
        public static DataTable dtOplSaturday1810;
        public static SqlDataAdapter daOplSaturday1810;

        //неділя--------------------------------------------------------------------------------

        public static SqlCommand cmdSunday1400 = new SqlCommand("", conusers);
        public static DataTable dtSunday1400;
        public static SqlDataAdapter daSunday1400;


        public static SqlCommand cmdOplSunday1400 = new SqlCommand("", conusers);
        public static DataTable dtOplSunday1400;
        public static SqlDataAdapter daOplSunday1400;


        public static SqlCommand cmdSunday1500 = new SqlCommand("", conusers);
        public static DataTable dtSunday1500;
        public static SqlDataAdapter daSunday1500;


        public static SqlCommand cmdOplSunday1500 = new SqlCommand("", conusers);
        public static DataTable dtOplSunday1500;
        public static SqlDataAdapter daOplSunday1500;


        public static SqlCommand cmdSunday1600 = new SqlCommand("", conusers);
        public static DataTable dtSunday1600;
        public static SqlDataAdapter daSunday1600;


        public static SqlCommand cmdOplSunday1600 = new SqlCommand("", conusers);
        public static DataTable dtOplSunday1600;
        public static SqlDataAdapter daOplSunday1600;


        public static SqlCommand cmdSunday1700 = new SqlCommand("", conusers);
        public static DataTable dtSunday1700;
        public static SqlDataAdapter daSunday1700;


        public static SqlCommand cmdOplSunday1700 = new SqlCommand("", conusers);
        public static DataTable dtOplSunday1700;
        public static SqlDataAdapter daOplSunday1700;


        public static SqlCommand cmdSunday1810 = new SqlCommand("", conusers);
        public static DataTable dtSunday1810;
        public static SqlDataAdapter daSunday1810;


        public static SqlCommand cmdOplSunday1810 = new SqlCommand("", conusers);
        public static DataTable dtOplSunday1810;
        public static SqlDataAdapter daOplSunday1810;
        public static void openConnection()
            {

                try
                {
                    if (conusers.State == ConnectionState.Closed)
                    {
                //лог і пас--------------------------------------------------        
                    conusers.ConnectionString = GetConnectionStrings();
                    conusers.Open();
                    /*
                //понеділок--------------------------------------------------
                    conMonday1400.ConnectionString = GetConnectionStrings();
                    conMonday1400.Open();
                    conOplMonday1400.ConnectionString = GetConnectionStrings();
                    conOplMonday1400.Open();
                    
                    conMonday1500.ConnectionString = GetConnectionStrings();
                    conMonday1500.Open();
                    conOplMonday1500.ConnectionString = GetConnectionStrings();
                    conOplMonday1500.Open();

                    conMonday1600.ConnectionString = GetConnectionStrings();
                    conMonday1600.Open();
                    conOplMonday1600.ConnectionString = GetConnectionStrings();
                    conOplMonday1600.Open();

                    conMonday1700.ConnectionString = GetConnectionStrings();
                    conMonday1700.Open();
                    conOplMonday1700.ConnectionString = GetConnectionStrings();
                    conOplMonday1700.Open();

                    conMonday1810.ConnectionString = GetConnectionStrings();
                    conMonday1810.Open();
                    conOplMonday1810.ConnectionString = GetConnectionStrings();
                    conOplMonday1810.Open();
                //вівторок------------------------------------------------------
                    conTuesday1400.ConnectionString = GetConnectionStrings();
                    conTuesday1400.Open();
                    conOplTuesday1400.ConnectionString = GetConnectionStrings();
                    conOplTuesday1400.Open();

                    conTuesday1500.ConnectionString = GetConnectionStrings();
                    conTuesday1500.Open();
                    conOplTuesday1500.ConnectionString = GetConnectionStrings();
                    conOplTuesday1500.Open();

                    conTuesday1600.ConnectionString = GetConnectionStrings();
                    conTuesday1600.Open();
                    conOplTuesday1600.ConnectionString = GetConnectionStrings();
                    conOplTuesday1600.Open();

                    conTuesday1700.ConnectionString = GetConnectionStrings();
                    conTuesday1700.Open();
                    conOplTuesday1700.ConnectionString = GetConnectionStrings();
                    conOplTuesday1700.Open();

                    conTuesday1810.ConnectionString = GetConnectionStrings();
                    conTuesday1810.Open();
                    conOplTuesday1810.ConnectionString = GetConnectionStrings();
                    conOplTuesday1810.Open();

                //середа------------------------------------------------------------------
                    conWednesday1400.ConnectionString = GetConnectionStrings();
                    conWednesday1400.Open();
                    conOplWednesday1400.ConnectionString = GetConnectionStrings();
                    conOplWednesday1400.Open();

                    conWednesday1500.ConnectionString = GetConnectionStrings();
                    conWednesday1500.Open();
                    conOplWednesday1500.ConnectionString = GetConnectionStrings();
                    conOplWednesday1500.Open();

                    conWednesday1600.ConnectionString = GetConnectionStrings();
                    conWednesday1600.Open();
                    conOplWednesday1600.ConnectionString = GetConnectionStrings();
                    conOplWednesday1600.Open();

                    conWednesday1700.ConnectionString = GetConnectionStrings();
                    conWednesday1700.Open();
                    conOplWednesday1700.ConnectionString = GetConnectionStrings();
                    conOplWednesday1700.Open();

                    conWednesday1810.ConnectionString = GetConnectionStrings();
                    conWednesday1810.Open();
                    conOplWednesday1810.ConnectionString = GetConnectionStrings();
                    conOplWednesday1810.Open();

                //четвер-------------------------------------------------------------------
                    conThursday1400.ConnectionString = GetConnectionStrings();
                    conThursday1400.Open();
                    conOplThursday1400.ConnectionString = GetConnectionStrings();
                    conOplThursday1400.Open();

                    conThursday1500.ConnectionString = GetConnectionStrings();
                    conThursday1500.Open();
                    conOplThursday1500.ConnectionString = GetConnectionStrings();
                    conOplThursday1500.Open();

                    conThursday1600.ConnectionString = GetConnectionStrings();
                    conThursday1600.Open();
                    conOplThursday1600.ConnectionString = GetConnectionStrings();
                    conOplThursday1600.Open();

                    conThursday1700.ConnectionString = GetConnectionStrings();
                    conThursday1700.Open();
                    conOplThursday1700.ConnectionString = GetConnectionStrings();
                    conOplThursday1700.Open();

                    conThursday1810.ConnectionString = GetConnectionStrings();
                    conThursday1810.Open();
                    conOplThursday1810.ConnectionString = GetConnectionStrings();
                    conOplThursday1810.Open();
                    
                //п'ятниця------------------------------------------------------
                    conFriday1400.ConnectionString = GetConnectionStrings();
                    conFriday1400.Open();
                    conOplFriday1400.ConnectionString = GetConnectionStrings();
                    conOplFriday1400.Open();

                    conFriday1500.ConnectionString = GetConnectionStrings();
                    conFriday1500.Open();
                    conOplFriday1500.ConnectionString = GetConnectionStrings();
                    conOplFriday1500.Open();

                    conFriday1600.ConnectionString = GetConnectionStrings();
                    conFriday1600.Open();
                    conOplFriday1600.ConnectionString = GetConnectionStrings();
                    conOplFriday1600.Open();

                    conFriday1700.ConnectionString = GetConnectionStrings();
                    conFriday1700.Open();
                    conOplFriday1700.ConnectionString = GetConnectionStrings();
                    conOplFriday1700.Open();

                    conFriday1810.ConnectionString = GetConnectionStrings();
                    conFriday1810.Open();
                    conOplFriday1810.ConnectionString = GetConnectionStrings();
                    conOplFriday1810.Open();

                //субота-----------------------------------------------------------
                    conSaturday1400.ConnectionString = GetConnectionStrings();
                    conSaturday1400.Open();
                    conOplSaturday1400.ConnectionString = GetConnectionStrings();
                    conOplSaturday1400.Open();

                    conSaturday1500.ConnectionString = GetConnectionStrings();
                    conSaturday1500.Open();
                    conOplSaturday1500.ConnectionString = GetConnectionStrings();
                    conOplSaturday1500.Open();

                    conSaturday1600.ConnectionString = GetConnectionStrings();
                    conSaturday1600.Open();
                    conOplSaturday1600.ConnectionString = GetConnectionStrings();
                    conOplSaturday1600.Open();

                    conSaturday1700.ConnectionString = GetConnectionStrings();
                    conSaturday1700.Open();
                    conOplSaturday1700.ConnectionString = GetConnectionStrings();
                    conOplSaturday1700.Open();

                    conSaturday1810.ConnectionString = GetConnectionStrings();
                    conSaturday1810.Open();
                    conOplSaturday1810.ConnectionString = GetConnectionStrings();
                    conOplSaturday1810.Open();

                //неділя------------------------------------------------------------
                    conSunday1400.ConnectionString = GetConnectionStrings();
                    conSunday1400.Open();
                    conOplSunday1400.ConnectionString = GetConnectionStrings();
                    conOplSunday1400.Open();

                    conSunday1500.ConnectionString = GetConnectionStrings();
                    conSunday1500.Open();
                    conOplSunday1500.ConnectionString = GetConnectionStrings();
                    conOplSunday1500.Open();

                    conSunday1600.ConnectionString = GetConnectionStrings();
                    conSunday1600.Open();
                    conOplSunday1600.ConnectionString = GetConnectionStrings();
                    conOplSunday1600.Open();

                    conSunday1700.ConnectionString = GetConnectionStrings();
                    conSunday1700.Open();
                    conOplSunday1700.ConnectionString = GetConnectionStrings();
                    conOplSunday1700.Open();

                    conSunday1810.ConnectionString = GetConnectionStrings();
                    conSunday1810.Open();
                    conOplSunday1810.ConnectionString = GetConnectionStrings();
                    conOplSunday1810.Open();
                    */
                    
                }
                }
                catch (Exception ex)
                {

                 MessageBox.Show("Сервер не відповідає" + Environment.NewLine + ex.Message.ToString(), "c# ...", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            public static void closeConnection()
            {
                try
                {
                    if (conusers.State == ConnectionState.Open)
                    {
                    //лог і пас -------------------------
                    
                    conusers.Close();
                    /*
                    //понеділок--------------------------
                    conOplMonday1400.Close();
                    conMonday1400.Close();

                    conOplMonday1500.Close();
                    conMonday1500.Close();

                    conOplMonday1600.Close();
                    conMonday1600.Close();

                    conOplMonday1700.Close();
                    conMonday1700.Close();

                    conOplMonday1810.Close();
                    conMonday1810.Close();
                    //вівторок---------------------------
                    conOplTuesday1400.Close();
                    conTuesday1400.Close();

                    conOplTuesday1500.Close();
                    conTuesday1500.Close();

                    conOplTuesday1600.Close();
                    conTuesday1600.Close();

                    conOplTuesday1700.Close();
                    conTuesday1700.Close();

                    conOplTuesday1810.Close();
                    conTuesday1810.Close();
                    //середа-----------------------------
                    conOplWednesday1400.Close();
                    conWednesday1400.Close();

                    conOplWednesday1500.Close();
                    conWednesday1500.Close();

                    conOplWednesday1600.Close();
                    conWednesday1600.Close();

                    conOplWednesday1700.Close();
                    conWednesday1700.Close();

                    conOplWednesday1810.Close();
                    conWednesday1810.Close();
                    //четвер-----------------------------
                    conOplThursday1400.Close();
                    conThursday1400.Close();

                    conOplThursday1500.Close();
                    conThursday1500.Close();

                    conOplThursday1600.Close();
                    conThursday1600.Close();

                    conOplThursday1700.Close();
                    conThursday1700.Close();

                    conOplThursday1810.Close();
                    conThursday1810.Close();
                    //п'ятниця---------------------------
                    conOplFriday1400.Close();
                    conFriday1400.Close();

                    conOplFriday1500.Close();
                    conFriday1500.Close();

                    conOplFriday1600.Close();
                    conFriday1600.Close();

                    conOplFriday1700.Close();
                    conFriday1700.Close();

                    conOplFriday1810.Close();
                    conFriday1810.Close();
                    //субота-----------------------------
                    conOplSaturday1400.Close();
                    conSaturday1400.Close();

                    conOplSaturday1500.Close();
                    conSaturday1500.Close();

                    conOplSaturday1600.Close();
                    conSaturday1600.Close();

                    conOplSaturday1700.Close();
                    conSaturday1700.Close();

                    conOplSaturday1810.Close();
                    conSaturday1810.Close();
                    //неділя-----------------------------
                    conOplSunday1400.Close();
                    conSunday1400.Close();

                    conOplSunday1500.Close();
                    conSunday1500.Close();

                    conOplSunday1600.Close();
                    conSunday1600.Close();

                    conOplSunday1700.Close();
                    conSunday1700.Close();

                    conOplSunday1810.Close();
                    conSunday1810.Close();

                    */
                }
                }
                catch (Exception)
                {
                    //
                }
            }
        }
    }


