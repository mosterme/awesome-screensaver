using System.Collections.Generic;
using System.Drawing;
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
        private System.ComponentModel.IContainer components = null;
        private Timer timer;
        private Point mouse;
        private int padding = 5;
        private bool preview = false;
        private Provider provider;
        private List<Provider> providers = new List<Provider>();
        private Label info, text;
        private Random random = new Random();
        public Screensaver(Rectangle Bounds)
        {
            this.Bounds = Bounds;
            InitializeComponent();
        }
        public Screensaver(IntPtr PreviewWndHandle)
        {
            padding = 1; preview = true; this.Bounds = new Rectangle(0,0,150,100);
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
        private void InitializeComponent()
        {
            Settings settings = new Settings(false);
            if (settings.font_awesome_47.Checked) providers.Add(new Awesome());
            if (settings.smileys_classic.Checked) providers.Add(new Smileys(Smileys.classic));
            if (settings.smileys_kaomoji.Checked) providers.Add(new Smileys(Smileys.kaomoji));
            if (settings.unicode_egypt.Checked) providers.Add(new Unicode(Unicode.african_scripts));
            if (settings.unicode_emoji.Checked) providers.Add(new Unicode(Unicode.emoji_pictographs));
            if (settings.unicode_maths.Checked) providers.Add(new Unicode(Unicode.mathematical_symbols));
            if (settings.unicode_other.Checked) providers.Add(new Unicode(Unicode.other_symbols));
            this.provider = randomProvider();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.BackColor = Color.Black;
            if (settings.acrylic_desktop.Checked) {
                this.BackgroundImage = randomBackground();
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this.info = new Label();
            this.info.AutoSize = true;
            this.info.BackColor = Color.Transparent;
            this.info.ForeColor = Color.Gainsboro;
            this.info.Location = new Point(padding, padding);
            this.info.BringToFront();
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
        }
        private Bitmap randomBackground()
        {
            int alpha = 200, scale = 3, img = random.Next(2) + 1;
            using (Image bitmap = Image.FromFile("res/desktop-" + img + ".jpg"))
            {
                Rectangle bounds = new Rectangle(0 ,0, bitmap.Width, bitmap.Height);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    using (Brush brush = new SolidBrush(Color.FromArgb(alpha, Color.Black)))
                    {
                        g.FillRectangle(brush, bounds);
                    }
                }
                return new Bitmap(bitmap,new Size(bitmap.Width/scale,bitmap.Height/scale));
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
