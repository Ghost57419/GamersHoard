// Packages for Scraping 
using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SeniorDesignProject
{
    public class AppHost : Form
    {
        public AppHost()
        {
            Text = "Senior Design Project";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1300, 700);
            MinimumSize = new Size(500, 300);
            BackColor = Theme.BgApp;

            // First screen shown. Navigation code swaps this out via FindForm().
            var home = new MainScreenPreset();
            home.Dock = DockStyle.Fill;
            Controls.Add(home);
            Load += AppHost_Load;
        }

        private async void AppHost_Load(object sender, EventArgs e)
        {
            Scraper scraper = new Scraper();

            HtmlNodeCollection products = await scraper.GetResponseAsync();

            if (products != null && products.Count > 0)
            {
                Debug.WriteLine($"Successfully found {products.Count} products!");
            }
            else
            {
                Debug.WriteLine("No products found.");
            }
        }
    }
}
