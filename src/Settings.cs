using Microsoft.Win32;
using System.Drawing;
using System.Windows.Forms;
using System;
namespace awesomescr
{
    public class Settings : Form
    {
        public TextBox acrylic_folder = new TextBox();
        public NumericUpDown acrylic_alpha = new NumericUpDown();
        public NumericUpDown acrylic_blur  = new NumericUpDown();
        public CheckBox acrylic_enabled = new CheckBox();
        public CheckBox font_awesome_47 = new CheckBox();
        public CheckBox smileys_classic = new CheckBox();
        public CheckBox smileys_kaomoji = new CheckBox();
        public CheckBox unicode_african = new CheckBox();
        public CheckBox unicode_american = new CheckBox();
        public CheckBox unicode_emoji = new CheckBox();
        public CheckBox unicode_oceania = new CheckBox();
        public CheckBox unicode_maths = new CheckBox();
        public CheckBox unicode_middle = new CheckBox();
        public CheckBox unicode_other = new CheckBox();
        private FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

        private static int label_x = 10, check_x = 150;
        public Settings(bool init_gui)
        {
            LoadRegistrySettings();
            if (init_gui) InitializeComponent();
        }
        private void InitializeComponent()
        {
            Label label_acrylic = new Label();
            Label label_awesome = new Label();
            Label label_classic = new Label();
            Label label_kaomoji = new Label();
            Label label_african = new Label();
            Label label_american = new Label();
            Label label_emoji = new Label();
            Label label_oceania = new Label();
            Label label_maths = new Label();
            Label label_middle = new Label();
            Label label_other = new Label();
            Label label_alpha = new Label();
            Label label_blur = new Label();
            Label label_folder = new Label();
            label_awesome.Text = "Font Awesome 4.7";
            label_classic.Text = "Smileys (classic)";
            label_kaomoji.Text = "Smileys (kaomoji)";
            label_african.Text = "African Scripts";
            label_american.Text = "American Scripts";
            label_emoji.Text = "Emoji + Pictographs";
            label_oceania.Text = "Indonesia + Oceania Scripts";
            label_maths.Text = "Mathematical Symbols";
            label_middle.Text = "Middle Eastern Scripts";
            label_other.Text = "Other Symbols";
            label_acrylic.Text  = "Enable Acrylic";
            label_alpha.Text = "Acrylic Alpha";
            label_blur.Text  = "Acrylic Blur";
            label_folder.Text  = "Acrylic Images Path";

            label_awesome.Width = label_classic.Width = label_kaomoji.Width = label_acrylic.Width = 
            label_african.Width = label_american.Width = label_emoji.Width = label_oceania.Width = 
            label_maths.Width = label_middle.Width = label_other.Width = 130;
            acrylic_alpha.Width = acrylic_blur.Width = 45;
            acrylic_folder.Width = 175;

            label_awesome.Location = new Point(label_x, 10);
            font_awesome_47.Location = new Point(check_x, label_awesome.Location.Y);
            label_classic.Location = new Point(label_x, 40);
            smileys_classic.Location = new Point(check_x, label_classic.Location.Y);
            label_kaomoji.Location = new Point(label_x, 70);
            smileys_kaomoji.Location = new Point(check_x, label_kaomoji.Location.Y);

            label_african.Location = new Point(label_x, 10);
            unicode_african.Location = new Point(check_x, label_african.Location.Y);
            label_american.Location = new Point(label_x, 40);
            unicode_american.Location = new Point(check_x, label_american.Location.Y);
            label_emoji.Location = new Point(label_x, 70);
            unicode_emoji.Location = new Point(check_x, label_emoji.Location.Y);
            label_oceania.Location = new Point(label_x, 100);
            unicode_oceania.Location = new Point(check_x, label_oceania.Location.Y);
            label_maths.Location = new Point(label_x, 130);
            unicode_maths.Location = new Point(check_x, label_maths.Location.Y);
            label_middle.Location = new Point(label_x, 160);
            unicode_middle.Location = new Point(check_x, label_middle.Location.Y);
            label_other.Location = new Point(label_x, 190);
            unicode_other.Location = new Point(check_x, label_other.Location.Y);

            label_acrylic.Location = new Point(label_x, 10);
            acrylic_enabled.Location = new Point(check_x, label_acrylic.Location.Y);
            label_alpha.Location = new Point(label_x, 40);
            acrylic_alpha.Location = new Point(145, 40);
            label_blur.Location = new Point(label_x, 70);
            acrylic_blur.Location = new Point(145, 70);
            label_folder.Location = new Point(label_x, 115);
            acrylic_folder.Location = new Point(10, 138);
            acrylic_folder.Enabled = false;

            TabControl tabControl1 = new TabControl();
            tabControl1.Location = new Point(5,5);
            TabPage tabPage1 = new TabPage();
            TabPage tabPage2 = new TabPage();
            TabPage tabPage3 = new TabPage();

            tabPage1.Text = "Awesome";
            tabPage1.TabIndex = 0;
            tabPage1.Controls.Add(label_awesome);
            tabPage1.Controls.Add(font_awesome_47);
            tabPage1.Controls.Add(label_classic);
            tabPage1.Controls.Add(smileys_classic);
            tabPage1.Controls.Add(label_kaomoji);
            tabPage1.Controls.Add(smileys_kaomoji);

            tabPage2.Text = "Unicode";
            tabPage2.TabIndex = 1;
            tabPage2.Controls.Add(label_african);
            tabPage2.Controls.Add(unicode_african);
            tabPage2.Controls.Add(label_american);
            tabPage2.Controls.Add(unicode_american);
            tabPage2.Controls.Add(label_emoji);
            tabPage2.Controls.Add(unicode_emoji);
            tabPage2.Controls.Add(label_oceania);
            tabPage2.Controls.Add(unicode_oceania);
            tabPage2.Controls.Add(label_maths);
            tabPage2.Controls.Add(unicode_maths);
            tabPage2.Controls.Add(label_middle);
            tabPage2.Controls.Add(unicode_middle);
            tabPage2.Controls.Add(label_other);
            tabPage2.Controls.Add(unicode_other);

            Button button3 = new Button();
            button3.Text = "📁"; // 🗁 📁 📂
            button3.Width = 30;
            button3.Location = new Point(155, 110);
            button3.Click += new EventHandler(folderButton_Click);

            tabPage3.Text = "Screensaver ";
            tabPage3.TabIndex = 2;
            tabPage3.Controls.Add(label_acrylic);
            tabPage3.Controls.Add(acrylic_enabled);
            tabPage3.Controls.Add(label_alpha);
            tabPage3.Controls.Add(acrylic_alpha);
            tabPage3.Controls.Add(label_blur);
            tabPage3.Controls.Add(acrylic_blur);
            tabPage3.Controls.Add(label_folder);
            tabPage3.Controls.Add(acrylic_folder);
            tabPage3.Controls.Add(button3);

            this.Size = new Size(225, 350);
            tabControl1.Size = new Size(200, 250);

            this.Controls.Add(tabControl1);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);

            Button button1 = new Button();
            Button button2 = new Button();
            button1.Text = "OK";
            button2.Text = "Cancel";
            button1.Location = new Point(Width - button2.Width - button1.Width - 35, Height - button1.Height - 50);
            button2.Location = new Point(Width - button2.Width - 25, button1.Location.Y);
            button1.Click += new EventHandler(okButton_Click);
            button2.Click += new EventHandler(cancelButton_Click);

            this.Text = "Awesome Screensaver Settings";
            this.AcceptButton = button1;
            this.CancelButton = button2;
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private void folderButton_Click(object sender, System.EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if( result == DialogResult.OK )
            {
                acrylic_folder.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void SaveRegistrySettings()
        {
            // Create or get existing Registry subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Awesome Screensaver");
            key.SetValue("font_awesome_47", font_awesome_47.Checked, RegistryValueKind.DWord);
            key.SetValue("smileys_classic", smileys_classic.Checked, RegistryValueKind.DWord);
            key.SetValue("smileys_kaomoji", smileys_kaomoji.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_american", unicode_american.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_african", unicode_african.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_emoji", unicode_emoji.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_oceania", unicode_oceania.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_maths", unicode_maths.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_middle", unicode_middle.Checked, RegistryValueKind.DWord);
            key.SetValue("unicode_other", unicode_other.Checked, RegistryValueKind.DWord);
            key.SetValue("acrylic_enabled", acrylic_enabled.Checked, RegistryValueKind.DWord);
            key.SetValue("acrylic_alpha", acrylic_alpha.Value, RegistryValueKind.DWord);
            key.SetValue("acrylic_blur", acrylic_blur.Value, RegistryValueKind.DWord);
            key.SetValue("acrylic_folder", acrylic_folder.Text, RegistryValueKind.String);
        }
        private void LoadRegistrySettings()
        {
            // Need to initialize Min and Max values for NumberUpDowns
            acrylic_alpha.Minimum = 0; acrylic_alpha.Maximum = 255;
            acrylic_blur.Minimum = 0;  acrylic_blur.Maximum = 100;
            // Get the value stored in the Registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Awesome Screensaver");
            // Some default values
            if (key == null)
            {
                smileys_classic.Checked = true;
                acrylic_alpha.Value = 240;
                acrylic_blur.Value = 5;
            }
            else
            {
                object keyvalue = null;
                keyvalue = key.GetValue("font_awesome_47");
                if (keyvalue != null) font_awesome_47.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("smileys_classic");
                if (keyvalue != null) smileys_classic.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("smileys_kaomoji");
                if (keyvalue != null) smileys_kaomoji.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("unicode_american");
                if (keyvalue != null) unicode_american.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("unicode_african");
                if (keyvalue != null) unicode_african.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("unicode_emoji");
                if (keyvalue != null) unicode_emoji.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("unicode_oceania");
                if (keyvalue != null) unicode_oceania.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("unicode_maths");
                if (keyvalue != null) unicode_maths.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("unicode_middle");
                if (keyvalue != null) unicode_middle.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("unicode_other");
                if (keyvalue != null) unicode_other.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("acrylic_enabled");
                if (keyvalue != null) acrylic_enabled.Checked = Convert.ToBoolean(keyvalue);
                keyvalue = key.GetValue("acrylic_alpha");
                if (keyvalue != null) acrylic_alpha.Value = Convert.ToDecimal(keyvalue);
                keyvalue = key.GetValue("acrylic_blur");
                if (keyvalue != null) acrylic_blur.Value = Convert.ToDecimal(keyvalue);
                keyvalue = key.GetValue("acrylic_folder");
                if (keyvalue != null) acrylic_folder.Text = keyvalue.ToString();
            }
            if (acrylic_folder.Text == null || acrylic_folder.Text.Length < 1)
            {
                folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }
            else
            {
                folderBrowserDialog1.SelectedPath = acrylic_folder.Text;
            }
        }
    }
}