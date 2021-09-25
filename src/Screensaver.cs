using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
namespace awesomescr
{
    public class Screensaver : Form
    {
        #region Win32 API functions
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);
        #endregion
        private static List<Provider> providers = new List<Provider>();
        private static Settings settings = new Settings(false);
        private static Random random = new Random();
        private static String[] backgrounds = Directory.GetFiles(settings.acrylic_folder.Text);
        private System.ComponentModel.IContainer components = null;
        private Timer timer;
        private Point mouse;
        private int padding = 5;
        private bool preview = false;
        private Provider provider;
        private Label info, text;
        public Screensaver(Rectangle Bounds)
        {
            this.Bounds = Bounds;
            InitializeProviders();
            InitializeComponent();
        }
        public Screensaver(IntPtr PreviewWndHandle)
        {
            padding = 1; preview = true; this.Bounds = new Rectangle(0,0,150,100);
            InitializeProviders();
            InitializeComponent();
            // Make the info and text label font size smaller
            info.Font = new Font(info.Font.FontFamily, info.Font.Size / 2);
            text.Font = new Font(text.Font.FontFamily, text.Font.Size / 10);
            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);
            // Make this a child window so it will close when the parent dialog closes
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));
            Rectangle ParentRect; // Place our window inside the parent
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size; Location = new Point(0, 0);
        }
        private void Screen_Load(object sender, EventArgs e)
        {
            Cursor.Hide(); TopMost = true;
            timer.Interval = 3000;
            timer.Tick += new EventHandler(move_Tick);
            timer.Start();
        }
        private void move_Tick(object sender, System.EventArgs e)
        {
            text.Text = randomText();
            text.Location = randomLocation();
            text.ForeColor = randomColor();
            this.provider = randomProvider();
        }
        private void Screen_MouseMove(object sender, MouseEventArgs e)
        {
            if (!preview)
            {
                if (!mouse.IsEmpty)
                {
                    // Terminate if mouse is moved a significant distance
                    if (Math.Abs(mouse.X - e.X) > 5 || Math.Abs(mouse.Y - e.Y) > 5)
                        Application.Exit();
                }
                // Update current mouse location
                mouse = e.Location;
            }
        }
        private void Screen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!preview) Application.Exit();
        }
        private void Screen_MouseClick(object sender, MouseEventArgs e)
        {
            if (!preview) Application.Exit();
        }
        private void InitializeProviders()
        {
            if (providers.Count == 0)
            {
                if (settings.font_awesome_47.Checked) providers.Add(new Awesome());
                if (settings.smileys_classic.Checked) providers.Add(new Smileys(Smileys.classic));
                if (settings.smileys_kaomoji.Checked) providers.Add(new Smileys(Smileys.kaomoji));
                if (settings.unicode_emoji.Checked) providers.Add(new Unicode(Unicode.emoji_pictographs));
                if (settings.unicode_maths.Checked) providers.Add(new Unicode(Unicode.mathematical_symbols));
                if (settings.unicode_other.Checked) providers.Add(new Unicode(Unicode.other_symbols));
                if (settings.unicode_african.Checked) providers.Add(new Unicode(Unicode.african_scripts));
                if (settings.unicode_american.Checked) providers.Add(new Unicode(Unicode.american_scripts));
                if (settings.unicode_c_asian.Checked) providers.Add(new Unicode(Unicode.central_asian_scripts));
                if (settings.unicode_e_asian.Checked) providers.Add(new Unicode(Unicode.east_asian_scripts));
                if (settings.unicode_oceania.Checked) providers.Add(new Unicode(Unicode.indonesia_oceania_scripts));
                if (settings.unicode_middle.Checked) providers.Add(new Unicode(Unicode.middle_eastern_scripts));
                if (settings.unicode_se_asian.Checked) providers.Add(new Unicode(Unicode.southeast_asian_scripts));
                if (settings.unicode_s_asian.Checked) providers.Add(new Unicode(Unicode.south_asian_scripts));
                if (providers.Count == 0) providers.Add(new Smileys(Smileys.classic)); // fallback
            }
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.BackColor = Color.Black;
            if (settings.acrylic_enabled.Checked) {
                this.BackgroundImage = randomBackground(Decimal.ToInt32(settings.acrylic_alpha.Value), Decimal.ToInt32(settings.acrylic_blur.Value));
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this.info = new Label();
            this.info.AutoSize = true;
            this.info.BackColor = Color.Transparent;
            this.info.ForeColor = Color.Gainsboro;
            this.info.Location = new Point(padding, padding);
            this.info.BringToFront();
            this.provider = randomProvider();
            this.text = new Label();
            this.text.AutoSize = true;
            this.text.BackColor = Color.Transparent;
            this.text.Font = new Font("FontAwesome", 200);
            this.text.Text = randomText();
            this.text.ForeColor = randomColor();
            this.text.Location = randomLocation();
            this.Controls.Add(this.info);
            this.Controls.Add(this.text);
            this.Load += new System.EventHandler(this.Screen_Load);
            this.KeyPress += new KeyPressEventHandler(this.Screen_KeyPress);
            this.MouseClick += new MouseEventHandler(this.Screen_MouseClick);
            this.MouseMove += new MouseEventHandler(this.Screen_MouseMove);
            this.timer = new Timer(this.components);
            this.StartPosition = FormStartPosition.Manual;
        }
        private Bitmap randomBackground(int alpha, int blur)
        {
            using (Image bitmap = Image.FromFile(backgrounds[random.Next(backgrounds.Length)]))
            {
                Rectangle bounds = new Rectangle(0 ,0, bitmap.Width, bitmap.Height);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    using (Brush brush = new SolidBrush(Color.FromArgb(alpha, Color.Black)))
                    {
                        g.FillRectangle(brush, bounds);
                    }
                }
                return new Bitmap(bitmap,new Size(bitmap.Width/blur,bitmap.Height/blur));
            }
        }
        private Color randomColor()
        {
            int m = 255, r = random.Next(m), g = random.Next(m), b = random.Next(m);
            Color c = Color.Gray;
            r = Math.Min((r + c.R) / 2, m);
            g = Math.Min((g + c.G) / 2, m);
            b = Math.Min((b + c.B) / 2, m);
            return Color.FromArgb(r, g, b);
        }
        private Point randomLocation()
        {
            int x = random.Next(Math.Max(padding, Bounds.Width - text.Width - padding));
            int y = random.Next(Math.Max(padding, Bounds.Height - text.Height - padding));
            return new Point(x,y);
        }
        private Provider randomProvider()
        {
            return providers[random.Next(providers.Count)];
        }
        private string randomText()
        {
            String result  = provider.next();
            this.info.Text = provider.info(result);
            return result;
        }
    }
}
