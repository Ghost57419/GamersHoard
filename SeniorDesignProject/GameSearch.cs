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
    public partial class GameSearch : UserControl
    {
        public GameSearch()
        {
            InitializeComponent();

            ApplyTheme();

            // This is a problem this gets disabled somewhere and I've strong armed it.
            splitContainer1.Enabled = true;
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.BgApp;
            this.ForeColor = Theme.TextPrimary;

            // Split container: Header above, game info below
            splitContainer1.BackColor = Theme.BgApp;
            splitContainer1.BorderStyle = BorderStyle.None;
            splitContainer1.Panel1.BackColor = Theme.BgSidebar;
            splitContainer1.Panel2.BackColor = Theme.BgApp;

            // Header
            gameName.BackColor = Color.Transparent;
            gameName.ForeColor = Theme.TextPrimary;
            Theme.StyleButton(backButton, primary: false);

            // Image Buttons
            Theme.StyleButton(nextImg, primary: true);
            Theme.StyleButton(lastImg, primary: true);

            // Pictures
            gameArt.BorderStyle = BorderStyle.None;
            gameArt.BackColor = Theme.BgSurface;
            gameImg.BorderStyle = BorderStyle.None;
            gameImg.BackColor = Theme.BgSurface;

            // Description
            Descr.BorderStyle = BorderStyle.None;
            Descr.BackColor = Theme.BgSurface;
            Descr.ForeColor = Theme.TextSecondary;
            Descr.Padding = new Padding(12);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainScreenPreset mainMenu = new MainScreenPreset();

            Form.ActiveForm.Controls.Clear();

            mainMenu.Dock = DockStyle.Fill;

            Form.ActiveForm.Controls.Add(mainMenu);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
