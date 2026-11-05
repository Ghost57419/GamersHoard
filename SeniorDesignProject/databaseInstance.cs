using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SeniorDesignProject
{
    public partial class databaseInstance : UserControl
    {
        public databaseInstance()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clark_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clark_Click(object sender, EventArgs e)
        {
            DatabaseTool database = new DatabaseTool();

            List<GameInstance> games = database.getAllGames();

            foreach (GameInstance game in games)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Name: " + game.Name);
                Console.WriteLine("Lowest Price: " + game.LowestPrice);
                Console.WriteLine("Description: " + game.Description);
                Console.WriteLine("Image: " + game.Image);
                Console.WriteLine("Best Store: " + game.BestStore);
                Console.WriteLine("Average Price: " + game.AveragePrice);
            }

            this.Parent.Controls.Remove(this);
        }
    }
}
