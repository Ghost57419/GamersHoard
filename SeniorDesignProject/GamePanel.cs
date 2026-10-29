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
    public partial class gamePanel : UserControl
    {
        public gamePanel()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            // The back of the control
            this.BackColor = Theme.BgApp;

            // Card
            gameInstance.BackColor = Theme.BgSurface;
            gameInstance.BorderStyle = BorderStyle.None;

            // Cover art
            gameArt.BorderStyle = BorderStyle.None;
            gameArt.BackColor = Theme.BgSidebar;

            // Text
            title.BackColor = Color.Transparent;
            title.ForeColor = Theme.TextPrimary;
            genre.BackColor = Color.Transparent;
            genre.ForeColor = Theme.TextSecondary;

            // Button
            Theme.StyleButton(gameDetails, primary: true);

        }

        private void gameDetails01_Click(object sender, EventArgs e)
        {

            GameSearch game = new GameSearch();

            Form.ActiveForm.Controls.Clear();

            game.Dock = DockStyle.Fill;

            Form.ActiveForm.Controls.Add(game);

        }
    }
}
