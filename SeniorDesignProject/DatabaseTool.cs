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
        public DatabaseTool() 
        {
        
        }

        ~DatabaseTool()
        {

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