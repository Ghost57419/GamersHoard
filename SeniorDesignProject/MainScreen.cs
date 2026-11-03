using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace SeniorDesignProject
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            MainScreenPreset userControlObject = new MainScreenPreset();

            this.Controls.Clear();

            userControlObject.Dock = DockStyle.Fill;

            this.Controls.Add(userControlObject);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void GameInstance01_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gameArt01_Click(object sender, EventArgs e)
        {

        }

        private async void MainScreen_Load(object sender, EventArgs e)
        {
            Scraper scraper = new Scraper();

            HtmlNodeCollection products = await scraper.GetResponseAsync();

            if(products != null && products.Count > 0)
            {
                MessageBox.Show($"Successfully found {products.Count} products!");
            }
            else
            {
                MessageBox.Show("No products found.");
            }

        }
    }
}
