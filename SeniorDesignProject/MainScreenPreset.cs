using System;
using System.Windows.Forms;

namespace SeniorDesignProject
{
    public partial class MainScreenPreset : UserControl
    {
        public MainScreenPreset()
        {
            InitializeComponent();

            ApplyTheme();

            // Insert logic to see if there is an instance of a database to actually display
            int tempDatabase = 1;

            if (tempDatabase > 0)
            {
                databaseContainer.Visible = true;
                // Display the instance of the databases and adjust the size depending on the amount of databases

                // Dont keep this, this is purely testing purpose
                databaseInstance db1 = new databaseInstance();



                databaseContainer.Controls.Add(db1);

            }
            else
            {
                databaseContainer.Visible = false;
            }

            if (tempDatabase > 0)
            {
                GameDisplayPnl.Visible = true;

                GamePanel gdp = new GamePanel();

                GameDisplayPnl.Controls.Add(gdp);
            }

        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.BgApp;

            // Split container: left sidebar vs. main content
            splitContainer1.BackColor = Theme.BgApp;
            splitContainer1.BorderStyle = BorderStyle.None;
            splitContainer1.Panel1.BackColor = Theme.BgSidebar;
            splitContainer1.Panel2.BackColor = Theme.BgApp;

            // Panels
            databaseContainer.BackColor = Theme.BgSurface;
            databaseContainer.BorderStyle = BorderStyle.None;
            GameDisplayPnl.BackColor = Theme.BgApp;

            // Buttons
            Theme.StyleButton(btnNewLib, primary: true);
            Theme.StyleButton(btnHome, primary: false);
            Theme.StyleButton(btnAdvSer, primary: false);
            Theme.StyleButton(button1, primary: false);

            // Search Boxes
            Theme.StyleTextBox(serNav);
            Theme.StyleTextBox(serRec);
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

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
