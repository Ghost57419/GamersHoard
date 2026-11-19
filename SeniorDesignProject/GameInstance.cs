using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorDesignProject
{
    internal class GameInstance
    {
        public string Name { get; set; }
        public decimal LowestPrice { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string BestStore { get; set; }
        public decimal AveragePrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public string Screenshot { get; set; }
        public string GameArt { get; set; }


        public GameInstance(string name, decimal lowestPrice,string description,
            string image, string bestStore,
            decimal averagePrice, decimal currentPrice,
            string screenshot, string gameArt)
        {
            Name = name;
            LowestPrice = lowestPrice;
            Description = description;
            Image = image;
            BestStore = bestStore;
            AveragePrice = averagePrice;
            CurrentPrice = currentPrice;
            Screenshot = screenshot;
            GameArt = gameArt;
        }
    }
}
