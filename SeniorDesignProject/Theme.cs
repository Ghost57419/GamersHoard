using System.Drawing;
using System.Windows.Forms;

namespace SeniorDesignProject
{
    // Create a preset list of colors to use for specific UI elements
    public static class Theme
    {
        public static readonly Color BgApp = Color.FromArgb(15, 25, 35);
        public static readonly Color BgSidebar = Color.FromArgb(20, 30, 43);
        public static readonly Color BgSurface = Color.FromArgb(26, 37, 53);
        public static readonly Color Accent = Color.FromArgb(74, 142, 245);
        public static readonly Color TextPrimary = Color.FromArgb(232, 238, 247);
        public static readonly Color TextSecondary = Color.FromArgb(122, 144, 168);
        public static readonly Color TextMuted = Color.FromArgb(74, 94, 114);
        public static readonly Color Success = Color.FromArgb(52, 199, 128);
        public static readonly Color Warning = Color.FromArgb(245, 166, 35);
        public static readonly Color Danger = Color.FromArgb(245, 90, 90);

        // Used for styling buttons
        public static void StyleButton(Button b, bool primary)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.UseVisualStyleBackColor = false;
            b.BackColor = primary ? Accent : BgSurface;
            b.ForeColor = TextPrimary;
            b.Cursor = Cursors.Hand;
        }

        // Used for styling text boxes
        public static void StyleTextBox(TextBox t)
        {
            t.BorderStyle = BorderStyle.FixedSingle;
            t.BackColor = BgSurface;
            t.ForeColor = TextSecondary;
        }

        private static void ApplyTo(Control root)
        {
            foreach (Control c in root.Controls)
            {
                if (c is Button b)
                    StyleButton(b, primary: false);
            }

        }
    }
}
