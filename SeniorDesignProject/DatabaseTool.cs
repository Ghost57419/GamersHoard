using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Data.Sqlite;

namespace SeniorDesignProject
{
    internal class DatabaseTool
    {

        private SqliteConnection dbConnection;
        private string errorLog = "error.log";

        // The default which will assume that the database already exists, if not report the error in a log
        public DatabaseTool() 
        {
            // Documentation did mention
            // Find the names within a file we create
            string connStr = "Data Source=games.db";

            dbConnection = new SqliteConnection(connStr);


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
            dbConnection = new SqliteConnection(
            $"Data Source={DatabaseName}.db");

            try
            {
                dbConnection.Open();
                createTable();
            }
            catch (Exception error)
            {
                logInfo(DateTime.Now.ToString() + error.ToString());    // Logs info to an error log
            }

            Console.Write("Bitch ass was here\n");

            GameInstance temp = new GameInstance("Minecraft", 2.99m, "Did a line of crack off a hookers stomach", "A picture of your dad", "2832 West Avenue Street", 1832.32m);
            addEntry(temp);
            
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

        private void createTable()
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS Games (
                GameID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL UNIQUE,
                LowestPrice REAL,
                Description TEXT,
                Image TEXT,
                BestStore TEXT,
                AveragePrice REAL
            );";

            using (SqliteCommand cmd = new SqliteCommand(sql, dbConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }


        // Logger function for debugging
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


        public void addEntry(GameInstance game)
        {
            string sql = @"
                INSERT INTO Games
                (Name, LowestPrice, Description, Image, BestStore, AveragePrice)
                VALUES
                (@name, @lowestPrice, @description, @image, @bestStore, @averagePrice);";

            using (SqliteCommand cmd = new SqliteCommand(sql, dbConnection))
            {
                cmd.Parameters.AddWithValue("@name", game.Name);
                cmd.Parameters.AddWithValue("@lowestPrice", game.LowestPrice);
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@image", game.Image);
                cmd.Parameters.AddWithValue("@bestStore", game.BestStore);
                cmd.Parameters.AddWithValue("@averagePrice", game.AveragePrice);

                cmd.ExecuteNonQuery();
            }
        }

        public void removeEntry(GameInstance game)
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



        public List<GameInstance> getAllGames()
        {
            List<GameInstance> games = new List<GameInstance>();

            string sql = "SELECT * FROM games;";

            using (SqliteCommand cmd = new SqliteCommand(sql, dbConnection))
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    GameInstance game = new GameInstance(
                        reader.GetString(1),
                        Convert.ToDecimal(reader.GetDouble(2)),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        Convert.ToDecimal(reader.GetDouble(6))
                    );

                    games.Add(game);
                }
            }
            Console.WriteLine("Dumbass was here");
            return games;
        }

    }
}