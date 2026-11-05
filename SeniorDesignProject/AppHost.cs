using System;
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
            ClientSize = new Size(1600, 865);
            MinimumSize = new Size(1000, 600);
            BackColor = Theme.BgApp;

            // First screen shown. Navigation code swaps this out via FindForm().
            var home = new MainScreenPreset();
            home.Dock = DockStyle.Fill;
            Controls.Add(home);
        }
    }
}
