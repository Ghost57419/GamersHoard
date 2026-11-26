using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SeniorDesignProject
{
    internal class JSONReader
    {
        public GameInstance getGameData(string GameName)
        {
            string filePath = GameName + ".json";
            GameInstance game = null;
            // Check if file exists
            
            string folderPath = Path.Combine(
            Directory.GetParent(
                AppDomain.CurrentDomain.BaseDirectory
                ).Parent.FullName,
            "SteamData"
            );

            filePath = Path.Combine( folderPath, filePath );


            if(File.Exists(filePath))
            {
                Console.WriteLine(filePath + " exists");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

            // Read file data and store within a game instance









            return game;
        }
    }
}
