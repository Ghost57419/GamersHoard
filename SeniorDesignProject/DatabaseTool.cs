using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SeniorDesignProject
{
    internal class DatabaseTool
    {

        private MySqlConnection dbConnection;
        private string errorLog = "error.log";

        // The default which will assume that the database already exists, if not report the error in a log
        public DatabaseTool() 
        {
            // Documentation did mention
            string connStr = "server=localhost;user=root;database=world;port=3306;password=balls";
            // The above variable to be passed into the connection
            dbConnection = new MySqlConnection(connStr);


            try
            {
                dbConnection.Open();
            }
            catch (Exception error)
            {
                logInfo(DateTime.Now.ToString() + error.ToString());    // Logs info to an error log
            }

        }


        // An overloaded constructor meant to be called at the creation of a database
        public DatabaseTool(string DatabaseName)
        {
            // Documentation did mention
            // string connStr = "server=localhost;user=root;database=world;port=3306;password=******";
            // The above variable to be passed into the connection
            dbConnection = new MySqlConnection();


            
        }

        ~DatabaseTool()
        {
            try
            {
                dbConnection.Close();
            }
            catch(Exception error)
            {
                logInfo(DateTime.Now.ToString() + error.ToString());
            }
        }



        private void logInfo(string message)
        {
            message += "\n";
            // Open the file and write the message to it
            if (!File.Exists(errorLog))
            {
                File.WriteAllText(errorLog, message);   // Creates the file
            }
            else
            {
                File.AppendAllText(errorLog, message);
            }
        }


        public void addEntry(string gameName)
        {

        }

        public void removeEntry(string gameName)
        {

        }


        // Might want a safety net to stop possible malicious code
        public void deleteDatabase()
        {

        }


        // This would not return a string but return the game instance itself
        public string getGame(string gameName)
        {

            return "temp";
        }

    }
}