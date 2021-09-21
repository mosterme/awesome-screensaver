using Microsoft.Win32;
using System.Drawing;
using System.Windows.Forms;
using System;
namespace awesomescr
{
    public class Settings : Form
    {
        public CheckBox font_awesome_47 = new CheckBox();
        public CheckBox smileys_classic = new CheckBox();
        public CheckBox smileys_kaomoji = new CheckBox();
        public CheckBox smileys_mini = new CheckBox();
        public CheckBox unicode_egypt = new CheckBox();
        public CheckBox unicode_emoji = new CheckBox();
        public CheckBox unicode_maths = new CheckBox();
        public CheckBox unicode_other = new CheckBox();
        private static int margin = 10;
        public Settings(bool init_gui)
        {
            LoadRegistrySettings();
            if (init_gui) InitializeComponent();
        }
        private void InitializeComponent()
        {
            Button button1 = new Button();
            Button button2 = new Button();
            Label label_awesome = new Label();
            Label label_classic = new Label();
            Label label_kaomoji = new Label();
            Label label_mini = new Label();
            Label label_egypt = new Label();
            Label label_emoji = new Label();
            Label label_maths = new Label();
            Label label_other = new Label();
            label_awesome.Width = label_classic.Width = label_kaomoji.Width = label_mini.Width = 130;
            label_egypt.Width = label_emoji.Width = label_maths.Width = label_other.Width = 130;
            label_awesome.Text = "Font Awesome 4.7";
            label_awesome.Location = new Point(margin, margin);
            font_awesome_47.Location = new Point(label_awesome.Location.X + label_awesome.Bounds.Right + Padding.Right, label_awesome.Location.Y);
            label_classic.Text = "Smileys (classic)";
            label_classic.Location = new Point(margin, 40);
            smileys_classic.Location = new Point(label_classic.Location.X + label_classic.Bounds.Right + Padding.Right, label_classic.Location.Y);
            label_kaomoji.Text = "Smileys (kaomoji)";
            label_kaomoji.Location = new Point(margin, 70);
            smileys_kaomoji.Location = new Point(label_kaomoji.Location.X + label_kaomoji.Bounds.Right + Padding.Right, label_kaomoji.Location.Y);
            label_mini.Text = "Smileys (mini)";
            label_mini.Location = new Point(margin, 100);
            smileys_mini.Location = new Point(label_mini.Location.X + label_mini.Bounds.Right + Padding.Right, label_mini.Location.Y);
            label_egypt.Text = "African Scripts";
            label_egypt.Location = new Point(margin, 130);
            unicode_egypt.Location = new Point(label_egypt.Location.X + label_egypt.Bounds.Right + Padding.Right, label_egypt.Location.Y);
            label_emoji.Text = "Emoji + Pictographs";
            label_emoji.Location = new Point(margin, 160);
            unicode_emoji.Location = new Point(label_emoji.Location.X + label_emoji.Bounds.Right + Padding.Right, label_emoji.Location.Y);
            label_maths.Text = "Mathematical Symbols";
            label_maths.Location = new Point(margin, 190);
            unicode_maths.Location = new Point(label_maths.Location.X + label_maths.Bounds.Right + Padding.Right, label_maths.Location.Y);
            label_other.Text = "Other Symbols";
            label_other.Location = new Point(margin, 220);
            unicode_other.Location = new Point(label_other.Location.X + label_other.Bounds.Right + Padding.Right, label_other.Location.Y);
            button1.Text = "OK";
            button1.Location = new Point(110, 280);
            button1.Click += new EventHandler(okButton_Click);
            button2.Text = "Cancel";
            button2.Location = new Point(button1.Bounds.Right + margin, button1.Location.Y);
            button2.Click += new EventHandler(cancelButton_Click);
            this.Height = 350;
            this.Text = "Awesome Screensaver Settings";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = button1;
            this.CancelButton = button2;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(label_awesome);
            this.Controls.Add(font_awesome_47);
            this.Controls.Add(label_classic);
            this.Controls.Add(smileys_classic);
            this.Controls.Add(label_kaomoji);
            this.Controls.Add(smileys_kaomoji);
            this.Controls.Add(label_mini);
            this.Controls.Add(smileys_mini);
            this.Controls.Add(label_egypt);
            this.Controls.Add(unicode_egypt);
            this.Controls.Add(label_emoji);
            this.Controls.Add(unicode_emoji);
            this.Controls.Add(label_maths);
            this.Controls.Add(unicode_maths);
            this.Controls.Add(label_other);
            this.Controls.Add(unicode_other);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            SaveRegistrySettings();
            Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SaveRegistrySettings()
        {
            // Create or get existing Registry subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Awesome Screensaver");
            key.SetValue("font_awesome_47", font_awesome_47.Checked, RegistryValueKind.DWord);
            key.SetValue("smileys_classic", smileys_classic.Checked, RegistryValueKind.DWord);
            key.SetValue("smileys_kaomoji", smileys_kaomoji.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_egypt", unicode_egypt.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_emoji", unicode_emoji.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_maths", unicode_maths.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_other", unicode_other.Checked, RegistryValueKind.DWord);
        }
        private void LoadRegistrySettings()
        {
            // Get the value stored in the Registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Awesome Screensaver");
            if (key == null)
            {
                smileys_classic.Checked = true;
            }
            else
            {
                object keyvalue = null;
                keyvalue = key.GetValue("font_awesome_47");
                if (keyvalue != null) font_awesome_47.Checked = (int) keyvalue > 0;
                keyvalue = key.GetValue("smileys_classic");
                if (keyvalue != null) smileys_classic.Checked = (int) keyvalue > 0;
                keyvalue = key.GetValue("smileys_kaomoji");
                if (keyvalue != null) smileys_kaomoji.Checked = (int) keyvalue > 0;
                keyvalue = key.GetValue("unicode_egypt");
                if (keyvalue != null) unicode_egypt.Checked = (int) keyvalue > 0;
                keyvalue = key.GetValue("unicode_emoji");
                if (keyvalue != null) unicode_emoji.Checked = (int) keyvalue > 0;
                keyvalue = key.GetValue("unicode_maths");
                if (keyvalue != null) unicode_maths.Checked = (int) keyvalue > 0;
                keyvalue = key.GetValue("unicode_other");
                if (keyvalue != null) unicode_other.Checked = (int) keyvalue > 0;
            }
        }
    }
}