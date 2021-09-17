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
        private int padding = 3;
        private bool preview = false;
        private Label text;
        private Random random = new Random();
        public Screensaver(Rectangle Bounds)
        {
            this.Bounds = Bounds;
            InitializeComponent();
        }
        public Screensaver(IntPtr PreviewWndHandle)
        {
            preview = true; InitializeComponent();
            // Make the text label font size smaller
            text.Font = new Font(text.Font.FontFamily, 30);
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
            text.Location = randomLocation();
            text.ForeColor = randomColor();
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.text = new Label();
            this.text.AutoSize = true;
            this.text.Font = new Font("sans-serif", 100);
            this.text.ForeColor = randomColor();
            this.text.Location = randomLocation();
            this.text.Text = ":-)";
            this.Controls.Add(this.text); 
            this.Load += new System.EventHandler(this.Screen_Load);
            this.KeyPress += new KeyPressEventHandler(this.Screen_KeyPress);
            this.MouseClick += new MouseEventHandler(this.Screen_MouseClick);
            this.MouseMove += new MouseEventHandler(this.Screen_MouseMove);
            this.timer = new Timer(this.components);
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
    }
}
