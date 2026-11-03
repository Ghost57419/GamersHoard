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
        // Design-time size for font scaling
        private const float BaseW = 1600f;
        private const float BaseH = 865f;

        // Caching fonts for quicker disposal when rescaling
        private Font _titleFont, _bodyFont, _buttonFont, _arrowFont;

        public GameSearch()
        {
            // Place controls using designer file
            InitializeComponent(); 

            // Layout, colors, then fonts and sizes are applied
            ApplyLayout();
            ApplyTheme();
            ScaleUi();

            // Re-scales the fonts and header height when control resized
            this.Resize += (s, e) => ScaleUi();
            this.Disposed += (s, e) =>
            {
                if (_titleFont != null) _titleFont.Dispose();
                if (_bodyFont != null) _bodyFont.Dispose();
                if (_arrowFont != null) _arrowFont.Dispose();
                if (_buttonFont != null) _buttonFont.Dispose();
            };

            // This is a problem this gets disabled somewhere and I've strong armed it.
            splitContainer1.Enabled = true;
        }


        // Layout used for control arrangement
        private void ApplyLayout()
        {
            splitContainer1.IsSplitterFixed = true;

            // Creates the header
            var header = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                Padding = new Padding(12, 8, 12, 8),
                BackColor = Color.Transparent
            };

            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12f));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76f));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12f));
            header.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

            backButton.Dock = DockStyle.Fill;
            backButton.Margin = new Padding(0);

            gameName.AutoSize = false;
            gameName.Dock = DockStyle.Fill;
            gameName.TextAlign = ContentAlignment.MiddleCenter;

            header.Controls.Add(backButton, 0, 0);
            header.Controls.Add(gameName, 1, 0);
            splitContainer1.Panel1.Controls.Add(header);

            // Creates the Bodyf
            var body = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(16),
                BackColor = Color.Transparent
            };
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
            body.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

            gameArt.Dock = DockStyle.Fill;
            gameArt.SizeMode = PictureBoxSizeMode.Zoom; // Preserve aspect ratio
            gameArt.Margin = new Padding(0, 0, 16, 0);
            body.Controls.Add(gameArt, 0, 0);

            // Creates Right Side
            var right = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 2,
                BackColor = Color.Transparent
            };

            right.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8f));
            right.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84f));
            right.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8f));
            right.RowStyles.Add(new RowStyle(SizeType.Percent, 62f));
            right.RowStyles.Add(new RowStyle(SizeType.Percent, 38f));

            lastImg.Dock = DockStyle.Fill;
            lastImg.Margin = new Padding(8, 40, 0, 40);

            nextImg.Dock = DockStyle.Fill;
            nextImg.Margin = new Padding(0, 40, 0, 40);

            // Using arrows instead of text
            lastImg.Text = "\u25C0";
            nextImg.Text = "\u25B6";

            gameImg.Dock = DockStyle.Fill;
            gameImg.SizeMode = PictureBoxSizeMode.Zoom;
            gameImg.Margin = new Padding(0);

            Descr.Dock = DockStyle.Fill;
            Descr.Margin = new Padding(0, 12, 0, 0);
            Descr.AutoEllipsis = true;

            right.Controls.Add(lastImg, 0, 0);
            right.Controls.Add(gameImg, 1, 0);
            right.Controls.Add(nextImg, 2, 0);
            right.Controls.Add(Descr, 0, 1);
            right.SetColumnSpan(Descr, 3);

            body.Controls.Add(right, 1, 0);
            splitContainer1.Panel2.Controls.Add(body);


            // Used for debugging
            //header.BackColor = Color.Magenta;
            //body.BackColor = Color.Cyan;
            //right.BackColor = Color.Yellow;
        }

        // Colors

        private void ApplyTheme()
        {
            this.BackColor = Theme.BgApp;
            this.ForeColor = Theme.TextPrimary;

            splitContainer1.BackColor = Theme.BgApp;
            splitContainer1.BorderStyle = BorderStyle.None;
            splitContainer1.Panel1.BackColor = Theme.BgSidebar;
            splitContainer1.Panel2.BackColor = Theme.BgApp;

            gameName.BackColor = Color.Transparent;
            gameName.ForeColor = Theme.TextPrimary;


            Theme.StyleButton(backButton, primary: false);
            Theme.StyleButton(lastImg, primary: false);
            Theme.StyleButton(nextImg, primary: false);

            gameArt.BorderStyle = BorderStyle.None;
            gameArt.BackColor = Theme.BgSurface;
            gameImg.BorderStyle = BorderStyle.None;
            gameImg.BackColor = Theme.BgSurface;

            Descr.BorderStyle = BorderStyle.None;
            Descr.BackColor = Theme.BgSurface;
            Descr.ForeColor = Theme.TextPrimary;
            Descr.Padding = new Padding(12);
        }

        private void ScaleUi()
        {
            if (Width < 200 || Height < 200) return;

            float scale = Math.Min(Width / BaseW, Height / BaseH);
            scale = Math.Max(0.6f, Math.Min(scale, 1.8f));

            int header = (int)(splitContainer1.Height * 0.14f);
            int max = splitContainer1.Height - splitContainer1.Panel2MinSize;
            splitContainer1.SplitterDistance = Math.Max(splitContainer1.Panel1MinSize, Math.Min(header, max));

            SetFontCool(ref _titleFont, 40f * scale, FontStyle.Bold, gameName);
            SetFont(ref _bodyFont, 16f * scale, FontStyle.Regular, Descr);
            SetFont(ref _buttonFont, 12f * scale, FontStyle.Regular, backButton);
            SetFont(ref _arrowFont, 18f * scale, FontStyle.Regular, lastImg, nextImg);
        }

        private static void SetFont(ref Font cache, float size, FontStyle style, params Control[] targets)
        {
            Font old = cache;
            cache = new Font("Segoe UI", size, style, GraphicsUnit.Point);
            foreach (Control c in targets) c.Font = cache;
            if (old != null) old.Dispose();

        }

        private static void SetFontCool(ref Font cache, float size, FontStyle style, params Control[] targets)
        {
            Font old = cache;
            cache = new Font("Unispace", size, style, GraphicsUnit.Point);
            foreach (Control c in targets) c.Font = cache;
            if (old != null) old.Dispose();

        }

        // Events
        private void button1_Click(object sender, EventArgs e)
        {
            Form host = this.FindForm();
            if (host == null) return;

            MainScreenPreset mainMenu = new MainScreenPreset();
            mainMenu.Dock = DockStyle.Fill;

            host.Controls.Clear();
            host.Controls.Add(mainMenu);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
    }
}

//        private void ApplyTheme()
//        {
//            this.BackColor = Theme.BgApp;
//            this.ForeColor = Theme.TextPrimary;

//            // Split container: Header above, game info below
//            splitContainer1.BackColor = Theme.BgApp;
//            splitContainer1.BorderStyle = BorderStyle.None;
//            splitContainer1.Panel1.BackColor = Theme.BgSidebar;
//            splitContainer1.Panel2.BackColor = Theme.BgApp;

//            // Header
//            gameName.BackColor = Color.Transparent;
//            gameName.ForeColor = Theme.TextPrimary;
//            Theme.StyleButton(backButton, primary: false);

//            // Image Buttons
//            Theme.StyleButton(nextImg, primary: true);
//            Theme.StyleButton(lastImg, primary: true);

//            // Pictures
//            gameArt.BorderStyle = BorderStyle.None;
//            gameArt.BackColor = Theme.BgSurface;
//            gameImg.BorderStyle = BorderStyle.None;
//            gameImg.BackColor = Theme.BgSurface;

//            // Description
//            Descr.BorderStyle = BorderStyle.None;
//            Descr.BackColor = Theme.BgSurface;
//            Descr.ForeColor = Theme.TextSecondary;
//            Descr.Padding = new Padding(12);
//        }
//        private void button1_Click(object sender, EventArgs e)
//        {
//            MainScreenPreset mainMenu = new MainScreenPreset();

//            Form.ActiveForm.Controls.Clear();

//            mainMenu.Dock = DockStyle.Fill;

//            Form.ActiveForm.Controls.Add(mainMenu);
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void label3_Click(object sender, EventArgs e)
//        {

//        }

//        private void button2_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
