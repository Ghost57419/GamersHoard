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
    public partial class GamePanel : UserControl
    {
        public GamePanel()
        {
            InitializeComponent();
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
