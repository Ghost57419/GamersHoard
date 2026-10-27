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

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //MainScreenPreset userControlObject = new MainScreenPreset();

            //Form.ActiveForm.Controls.Clear();

            //userControlObject.Dock = DockStyle.Fill;

            //Form.ActiveForm.Controls.Add(userControlObject);
        }
    }
}
