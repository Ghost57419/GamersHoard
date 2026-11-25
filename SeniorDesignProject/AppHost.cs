// Packages for Scraping 
using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

// Packages for Steam
using System.Collections.Generic;
using System.Threading.Tasks;

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
            string steamAPIkey = "";

            SteamService steamService = new SteamService(steamAPIkey);

            List<SteamApp> steamApps = await steamService.GetAppListAsync();

            foreach(SteamApp app in steamApps)
            {
                await steamService.SaveAppDetailsAsync(app.AppId);

                await Task.Delay(2000);
            }
        }
    }
}
