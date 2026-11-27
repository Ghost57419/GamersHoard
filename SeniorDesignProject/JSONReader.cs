using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SeniorDesignProject
{
    internal class JSONReader
    {
        public GameInstance getGameData(string GameID)
        {
            string filePath = GameID + ".json";
            GameInstance game = null;
            // Check if file exists

            string folderPath = Path.Combine(
            Directory.GetParent(
                AppDomain.CurrentDomain.BaseDirectory
                ).Parent.FullName,
            "SteamData"
            );

            filePath = Path.Combine(folderPath, filePath);


            if (File.Exists(filePath))
            {
                Console.WriteLine(filePath + " exists");
            }
            else
            {
                Console.WriteLine("File does not exist");
                return game;
            }

            // Read file data and store within a game instance

            string jsonData = File.ReadAllText(filePath);

            JObject gameData = JObject.Parse(jsonData);

            JToken appdata = gameData[GameID];

            if (appdata == null)
            {
                return game;
            }


            JToken data = appdata["data"];


            game = new GameInstance(
                (string)data["name"],
                ((decimal?)data["price_overview"]?["final"] ?? 0m) / 100m,
                (string)data["short_description"],
                (string)data["header_image"],
                "Steam",
                ((decimal?)data["price_overview"]?["final"] ?? 0m) / 100m,
                ((decimal?)data["price_overview"]?["final"] ?? 0m) / 100m,
                (string)data["screenshots"]?[0]?["path_full"],
                (string)data["background"]
                );


            return game;
        }
    }
}
