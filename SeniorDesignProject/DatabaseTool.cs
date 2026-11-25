using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Data.Sqlite;
// GamersHoard\SeniorDesignProject\bin\x64\Debug
// File location to error logging and location of database


namespace SeniorDesignProject
{
    internal class DatabaseTool
    {

        private SqliteConnection dbConnection;
        private string errorLog = "error.log";
        private string tableName;
        private bool delete = true;

        // The default which will assume that the database already exists, if not report the error in a log
        public DatabaseTool() 
        {
            // Documentation did mention
            // Find the names within a file we create
            string connStr = "Data Source=games.db";

            dbConnection = new SqliteConnection(connStr);
            tableName = "games";

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
            tableName = DatabaseName;
            try
            {
                dbConnection.Open();
                createTable();
                Console.WriteLine("Created a database");

            }
            catch (Exception error)
            {
                logInfo(DateTime.Now.ToString() + error.ToString());    // Logs info to an error log
                Console.WriteLine("Error creating a database");
            }

            
            
        }

        ~DatabaseTool()
        {
            if (delete == false)
            {
                try
                {
                    dbConnection.Close();
                }
                catch (Exception error)
                {
                    logInfo(DateTime.Now.ToString() + error.ToString());
                }
            }
            else
            {
                deleteDatabase();
            }
        }

        private void createTable()
        {
            // NEED TO FIX LATER, GAMES should be the name of the database
            string sql = @"
            CREATE TABLE IF NOT EXISTS games (
                GameID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL UNIQUE,
                LowestPrice REAL,
                Description TEXT,
                Image TEXT,
                BestStore TEXT,
                AveragePrice REAL,
                CurrentPrice REAL,
                Screenshot TEXT,
                GameArt TEXT
            );";

            using (SqliteCommand cmd = new SqliteCommand(sql, dbConnection))
            {
                cmd.ExecuteNonQuery();
            }
        }


        // Logger function for debugging
        private void logInfo(string message)
        {
            Console.WriteLine("Logging error: " + message);
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
                INSERT INTO games
                (Name, LowestPrice, Description, Image, BestStore, AveragePrice, CurrentPrice, Screenshot, GameArt)
                VALUES
                (@name, @lowestPrice, @description, @image, @bestStore, @averagePrice, @currentPrice, @screenshot, @gameart);";

            using (SqliteCommand cmd = new SqliteCommand(sql, dbConnection))
            {
                cmd.Parameters.AddWithValue("@name", game.Name);
                cmd.Parameters.AddWithValue("@lowestPrice", game.LowestPrice);
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@image", game.Image);
                cmd.Parameters.AddWithValue("@bestStore", game.BestStore);
                cmd.Parameters.AddWithValue("@averagePrice", game.AveragePrice);
                cmd.Parameters.AddWithValue("@currentPrice", game.CurrentPrice);
                cmd.Parameters.AddWithValue("@screenshot", game.Screenshot);
                cmd.Parameters.AddWithValue("@gameart", game.GameArt);

                cmd.ExecuteNonQuery();
            }
        }

        public void removeEntry(GameInstance game)
        {
            string commandRemoveElement = $"DELETE FROM {tableName} WHERE Name = \"{game.Name}\";";

            using (SqliteCommand cmd = new SqliteCommand(commandRemoveElement, dbConnection))
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Removed an element");
            }
        }


        // Might want a safety net to stop possible malicious code
        public void deleteDatabase()
        {
            string commandDelete = $"DROP TABLE IF EXISTS {tableName};";

            using (SqliteCommand cmd = new SqliteCommand(commandDelete, dbConnection))
            {
                cmd.ExecuteNonQuery();
            }

        }


        // This would not return a string but return the game instance itself
        public GameInstance getGame(string gameName)
        {
            GameInstance game = null;   // Default value

            string commandRemoveElement = $"SELECT * FROM {tableName} WHERE Name = {gameName};";

            using (SqliteCommand cmd = new SqliteCommand(commandRemoveElement, dbConnection))
            {
                var reader = cmd.ExecuteReader();
                Console.WriteLine("Attempting to find element");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        game.Name = reader.GetString(0);
                        game.LowestPrice = reader.GetDecimal(1);
                        game.Description = reader.GetString(2);
                        game.Image = reader.GetString(3);
                        game.BestStore = reader.GetString(4);
                        game.AveragePrice = reader.GetDecimal(5);
                    }
                }


            }

            return game;

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
                        Convert.ToDecimal(reader.GetDouble(6)),
                        Convert.ToDecimal(reader.GetDouble(7)),
                        reader.GetString(8),
                        reader.GetString(9)
                    );

                    games.Add(game);
                }
            }
            return games;
        }

    }
}