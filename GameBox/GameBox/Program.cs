﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib; // צריך להוסיף
using System.Windows.Forms;
using System.Data.SqlClient; //צריך להוסיף
using System.IO;  //צריך להוסיף
using System.Reflection; //צריך להוסיף


namespace GameBox
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
        public static string user1 = "", user2 = "";
        public static string guest = "";
        public static Boolean TypeUser; // Guest=false, player=true 
        public static Boolean GameChoice; /* true = reversi, false = LAS */
        public static int cnt_players = 0;  //1= 1 player , 2 = 2 players
        public static Boolean music_OnOff = true; //Music on = true , Music off == false
        public static Boolean ManagerConected; // true= manager,false = not manager 
        public static WindowsMediaPlayer Wmp = new WindowsMediaPlayer();  //background music


        public static Boolean Password_Check(string pass) /* function to check if password length is correct */
        {
            if (pass.Length == 5)
                return true;
            return false;
        }
        public static Boolean User_Check(string user) /* function to check if Name length is correct */
        {
            if (user.Length < 2 || user.Length > 10)
                return false;
            return true;
        }

        /* all database function */
        public static string ConectionString(string DBName) /* function to get database conection string */
        {
            string DBConectionString = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); /* get exe path */
            for (int i = 0; i <= 8; i++)
                DBConectionString = DBConectionString.Remove(DBConectionString.Length - 1); /* remove unnecassery files */
            DBConectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + DBConectionString + DBName + ".mdf" + ";Integrated Security = True"; /* create data path string */
            return DBConectionString; /* return path string */
        }

        public static int Check_NAME_exsist(string Name, string DataBaseName)  /* check if name exsist in database */
        {
            string UserConectionString = ConectionString(DataBaseName); /* creat conection string to database */
            using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
            {
                con.Open(); /* open database */
                SqlCommand sqlCommand = new SqlCommand("SELECT Name FROM " + DataBaseName + " WHERE Name= " + "'" + Name + "'", con); /* sql commmand */
                SqlDataAdapter SqlService = new SqlDataAdapter(sqlCommand); /* create adaptar to datatable of sql command */
                int countRows = SqlService.Fill(new DataTable()); /* crate data tabke with command */
                con.Close(); /* close conection */
                return countRows; /* return number of rows created by command */
            }
        }

        public static Boolean Check_Password_Is_correct(string Name, string Password, string DataBaseName) /* check if Password exsist in database */
        {
            string UserConectionString = ConectionString(DataBaseName); /* creat conection string to database */
            using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
            {
                con.Open(); /* open database */
                SqlCommand sqlCommand = new SqlCommand("SELECT Password FROM " + DataBaseName + " WHERE Name=" + "'" + Name + "'" + "AND Password='" + Password + "'", con); /* sql commmand */
                SqlDataAdapter SqlService = new SqlDataAdapter(sqlCommand);/* create adaptar to datatable of sql command */
                int countRows = SqlService.Fill(new DataTable());  /* crate data tabke with command */
                con.Close(); /* close conection */
                if (countRows > 0) /* check number of rows created by command */
                    return true; /* if there password was correct */
                return false; /* if there password was wrong */

            }
        }
        public static void DeleteUser(string Name, string DataBaseName) /* delete user by name */
        {
            string UserConectionString = ConectionString(DataBaseName); /* creat conection string to database */
            using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
            {
                con.Open(); /* open database */
                string cmd = "DELETE FROM " + DataBaseName + " WHERE Name='" + Name + "'"; /* sql commmand string */
                SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                cmd1.ExecuteNonQuery(); /* use command on database */
                con.Close(); /* close conection */
            }

        }

        /* functions on players database */
        public static Boolean Insert_User_PLayers(string Name, string Password) /* insert user to playes database */
        {
            if (Check_NAME_exsist(Name, "Players") == 0) /* check if name alredy exsist */
            {
                string UserConectionString = ConectionString("Players"); /* creat conection string to database */
                using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
                {
                    con.Open(); /* open database */
                    string cmd = "INSERT INTO Players VALUES('" + Name + "','" + Password + "')"; /* sql commmand string */
                    SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                    cmd1.ExecuteNonQuery(); /* use command on database */
                    con.Close(); /* close conection */
                }
                return true; /* if user inserted */
            }
            else /* if name exsist */
                return false;
        }

        public static void Upadte_User_players(string Name, string Password, string NewName) /* update user info in database */
        {

            string UserConectionString = ConectionString("Players");  /* creat conection string to database */
            using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
            {
                con.Open(); /* open database */
                string cmd = "UPDATE Players SET Name='" + NewName + "',Password= '" + Password + "'WHERE Name='" + Name + "'"; /* sql commmand string */
                SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                cmd1.ExecuteNonQuery(); /* use command on database */
                con.Close(); /* close conection */
            }
        }
        /* functions on manager database */
        public static void InsertManager(string Name, string Password) /* insert manager to databse*/
        {

            string UserConectionString = ConectionString("Managers");/* creat conection string to database */
            using (SqlConnection con = new SqlConnection(UserConectionString))  /* open conection */
            {
                con.Open(); /* open database */
                string cmd = "INSERT INTO Managers VALUES('" + Name + "','" + Password + "')"; /* sql commmand string */
                SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                cmd1.ExecuteNonQuery(); /*use command on database */
                con.Close(); /* close conection */
            }
        }
        /* function on login database */
        public static void InsertLogin(string Name, string type) /* insert login to login Database */
        {
            string UserConectionString = ConectionString("Logins"); /* creat conection string to database */
            using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
            {
                con.Open(); /* open database */
                string cmd = "INSERT INTO Logins VALUES('" + Name + "','" + type + "','" + DateTime.Today.ToShortDateString() + "','" + DateTime.Now.ToLongTimeString() + "')"; /* sql commmand string */
                SqlCommand cmd1 = new SqlCommand(cmd, con);/* sql commmand */
                cmd1.ExecuteNonQuery();/* use command on database */
                con.Close(); /* close conection */
            }
        }

        /* functions on scores database*/
        public static void Upadte_User_Scores(string Name, string NewName) /* function to update user in scores*/
        {

            string UserConectionString = ConectionString("Scores"); /* creat conection string to database */
            using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
            {
                con.Open(); /* open database */
                string cmd = "UPDATE Scores SET Name='" + NewName + "' WHERE Name='" + Name + "'"; /* sql commmand string */
                SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                cmd1.ExecuteNonQuery(); /* use command on database */
                con.Close(); /* close conection */
            }
        }
        public static void Insert_User__Scores(string Name) /* function to insurt user in scores*/
        {
            string ScoresConectionString = ConectionString("Scores"); /* creat conection string to database */
            using (SqlConnection con = new SqlConnection(ScoresConectionString)) /* open conection */
            {
                con.Open(); /* open database */
                string cmd = "INSERT INTO Scores (Name)  VALUES ('" + Name + "')"; /* sql commmand string */
                SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                cmd1.ExecuteNonQuery(); /* use command on database */
                con.Close(); /* close conection */
            }
        }
        /* functions on Feedback Database */
        public static void Insert_Feedback(string Name, string Report)  /* function to insurt feedback in feedbacks database*/
        {

            string UserConectionString = ConectionString("FeedBacks"); /* creat conection string to database */
            using (SqlConnection con = new SqlConnection(UserConectionString)) /* open conection */
            {
                con.Open(); /* open database */
                string cmd = "INSERT INTO FeedBacks VALUES('" + Name + "','" + Report + "','" + DateTime.Today.ToShortDateString() + "')"; /* sql commmand string */
                SqlCommand cmd1 = new SqlCommand(cmd, con); /* sql commmand */
                cmd1.ExecuteNonQuery(); /* use command on database */
                con.Close();/* close conection */
            }
        }
    }
}
