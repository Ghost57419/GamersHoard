using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace SeniorDesignProject
{
    public partial class MainScreenPreset : UserControl
    {
        private const float BaseW = 1600f;
        private const float BaseH = 865f;

        // Fraction of the total screen width the sidebar will take up
        private const float SidebarFraction = 0.215f;

        private Font _buttonFont, _inputFont, _arrowFont;
        public MainScreenPreset()
        {
            InitializeComponent();

            // Ca
            ApplyLayout();
            ApplyTheme();
            ScaleUi();

            // Re-scales based on control size
            this.Resize += (s, e) => ScaleUi();
            this.Disposed += (s, e) =>
            {
                if (_buttonFont != null) _buttonFont.Dispose();
                if (_inputFont != null) _inputFont.Dispose();
                if (_arrowFont != null) _arrowFont.Dispose();
            };

            int tempDatabase = 1;

            if (tempDatabase > 0)
            {
                databaseContainer.Visible = true;

                databaseInstance db1 = new databaseInstance();
                db1.Dock = DockStyle.Top;
                databaseContainer.Controls.Add(db1);
            }
            else
            {
                databaseContainer.Visible = false;
            }

            if (tempDatabase > 0)
            {
                GameDisplayPnl.Visible = true;

                gamePanel gdp = new gamePanel();

                GameDisplayPnl.Controls.Add(gdp);
            }
        }

        private void ApplyLayout()
        {
            splitContainer1.IsSplitterFixed = true;

            var sidebar = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                Padding = new Padding(12),
                BackColor = Color.Transparent
            };

            sidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            sidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 9f));
            sidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 55f));
            sidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 12f));
            sidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 12f));
            sidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 12f));

            var topBar = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Margin = new Padding(0),
                BackColor = Color.Transparent
            };

            topBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78f));
            topBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22f));
            topBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

            serNav.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            serNav.Margin = new Padding(0, 0, 8, 0);

            button1.Dock = DockStyle.Fill;
            button1.Margin = new Padding(0, 4, 0, 4);

            topBar.Controls.Add(serNav, 0, 0);
            topBar.Controls.Add(button1, 1, 0);
            sidebar.Controls.Add(topBar, 0, 0);

            // Row 1: Library list fills its cell
            databaseContainer.Dock = DockStyle.Fill;
            databaseContainer.Margin = new Padding(0, 8, 0, 8);
            databaseContainer.AutoScroll = true;
            sidebar.Controls.Add(databaseContainer, 0, 1);

            // Rows 2-4: three buttons
            Button[] stacked = { btnHome, btnAdvSer, btnNewLib };
            for (int i = 0; i < stacked.Length; i++)
            {
                stacked[i].Dock = DockStyle.Fill;
                stacked[i].Margin = new Padding(0, 4, 0, 4);
                sidebar.Controls.Add(stacked[i], 0, 2 + i);
            }

            splitContainer1.Panel1.Controls.Add(sidebar);

            // -- Content (Panel2): search bar, game cards
            var content = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                Padding = new Padding(16),
                BackColor = Color.Transparent
            };

            content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            content.RowStyles.Add(new RowStyle(SizeType.Percent, 9f)); // search bar
            content.RowStyles.Add(new RowStyle(SizeType.Percent, 91f)); // game cards\

            serRec.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            serRec.Margin = new Padding(0);
            content.Controls.Add(serRec, 0, 0);

            // scroll when too many games
            GameDisplayPnl.Dock = DockStyle.Fill;
            GameDisplayPnl.Margin = new Padding(0, 8, 0, 0);
            GameDisplayPnl.AutoScroll = true;
            content.Controls.Add(GameDisplayPnl, 0, 1);

            splitContainer1.Panel2.Controls.Add(content);

            // Debugging stuff to see if changes have been applied
            //sidebar.BackColor = Color.Magenta;
            //topBar.BackColor = Color.Cyan;
            //content.BackColor = Color.Yellow;
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.BgApp;
            this.ForeColor = Theme.TextPrimary;

            // Sidebar (Panel1) 
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

            // Search boxes
            Theme.StyleTextBox(serNav);
            Theme.StyleTextBox(serRec);
        }


        private void ScaleUi()
        {
            // Avoids scaling for absurdly small sizes
            if (Width < 100 || Height < 100) return;

            // Scale factor
            float scale = Math.Min(Width / BaseW, Height / BaseH);
            scale = Math.Max(0.6f, Math.Min(scale, 1.8f));

            // Sidebar stuff
            int sidebar = (int)(splitContainer1.Width * SidebarFraction);
            int max = splitContainer1.Width - splitContainer1.Panel2MinSize;
            splitContainer1.SplitterDistance = Math.Max(splitContainer1.Panel1MinSize, Math.Min(sidebar, max));

            // Base font sizes
            SetFont(ref _buttonFont, 12f * scale, FontStyle.Regular, btnHome, btnAdvSer, btnNewLib);
            SetFont(ref _inputFont, 12f * scale, FontStyle.Regular, serNav, serRec);
            SetFont(ref _arrowFont, 12f * scale, FontStyle.Bold, button1);
        }

        private static void SetFont(ref Font cache, float size, FontStyle style, params Control[] targets)
        {
            Font old = cache;
            cache = new Font("Segoe UI", size, style, GraphicsUnit.Point);
            foreach (Control c in targets) c.Font = cache;
            if (old != null) old.Dispose();
        }

        private void button2_Click(object sender, EventArgs e) { }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }

        private void btnHome_Click(object sender, EventArgs e) { }
    }
}
