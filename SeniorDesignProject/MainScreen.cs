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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            // Insert logic to see if there is an instance of a database to actually display
            int tempDatabase = 1;

            if(tempDatabase > 0)
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
    }
}
