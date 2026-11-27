using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SeniorDesignProject
{
    internal class gamesDictionary
    {
        private string fileName;
        private Dictionary<string, string> gamesDict;   // Key, Value  ::  GameName, ID

        public gamesDictionary(string filename) // filename would be the file name, like steam.txt 
        {
            gamesDict = new Dictionary<string, string>();
            fileName = filename;

            if(!File.Exists(fileName))
            {
                File.Create(fileName);
            }
            else
            {
                // Read the file and store it within the dictionary
                // File will be in the form of 
                // Key Value, OR for example  counterstrike 10
                // So it will be seperated by generic name with no special characters and no spaces, all lower case and then something like its
                // Steam ID, or other ID in the future
                foreach (string line in File.ReadLines(fileName))
                {
                    string[] values = line.Split(' ');
                    gamesDict.Add(values[0], values[1]);
                }
            }
            
        }

        ~gamesDictionary() 
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Add all of the information to the file
                foreach(KeyValuePair<string, string> game in gamesDict)
                {
                    writer.WriteLine(game.Key + " " + game.Value);
                }
            }
        }


        public void addGame(string gameName, string gameID)
        {
            if (!gamesDict.ContainsKey(gameName))
            {
                gamesDict.Add(gameName, gameID);    // Would probably be smart to add error handling but whatever
            }
        }


        public string retrieveID(string gameName)
        {
            if(gamesDict.TryGetValue(gameName, out string gameID))
            {
                return gameID;
            }

            return "";
        }
    }
}
