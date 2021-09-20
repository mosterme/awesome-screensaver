using System.Drawing;
using System.Windows.Forms;
namespace awesomescr
{
    public class Settings : Form
    {
        public static bool font_awesome_47 = true;
        public static bool smileys_classic = true;
        public static bool smileys_kaomoji = true;
        public static bool smileys_mini = false;
        public static bool unicode = false;
        private static int margin = 10;
        public Settings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            Button button1 = new Button();
            Button button2 = new Button();
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Label label4 = new Label();
            Label label5 = new Label();
            Label label6 = new Label(); 
            Label label7 = new Label();
            Label label8 = new Label();
            label1.Width = label2.Width = label3.Width = label4.Width = label5.Width = label6.Width = label7.Width = label8.Width = 130;
            CheckBox field1 = new CheckBox();
            CheckBox field2 = new CheckBox();
            CheckBox field3 = new CheckBox();
            CheckBox field4 = new CheckBox();
            CheckBox field5 = new CheckBox();
            CheckBox field6 = new CheckBox();
            CheckBox field7 = new CheckBox();
            CheckBox field8 = new CheckBox();
            label1.Text = "Font Awesome 4.7";
            label1.Location = new Point(margin, margin);
            field1.Location = new Point(label1.Location.X + label1.Bounds.Right + Padding.Right, label1.Location.Y);
            field1.Checked  = font_awesome_47;
            label2.Text = "Smileys (classic)";
            label2.Location = new Point(margin, 40);
            field2.Location = new Point(label2.Location.X + label2.Bounds.Right + Padding.Right, label2.Location.Y);
            field2.Checked = smileys_classic;
            label3.Text = "Smileys (kaomoji)";
            label3.Location = new Point(margin, 70);
            field3.Location = new Point(label3.Location.X + label3.Bounds.Right + Padding.Right, label3.Location.Y);
            field3.Checked = smileys_kaomoji;
            label4.Text = "Smileys (mini)";
            label4.Location = new Point(margin, 100);
            field4.Location = new Point(label4.Location.X + label4.Bounds.Right + Padding.Right, label4.Location.Y);
            field4.Checked = smileys_mini;
            label5.Text = "Unicode (Asian)";
            label5.Location = new Point(margin, 130);
            field5.Location = new Point(label5.Location.X + label5.Bounds.Right + Padding.Right, label5.Location.Y);
            field5.Checked = smileys_mini;
            label6.Text = "Unicode (Emoticons)";
            label6.Location = new Point(margin, 160);
            field6.Location = new Point(label6.Location.X + label6.Bounds.Right + Padding.Right, label6.Location.Y);
            field6.Checked = smileys_mini;
            label7.Text = "Unicode (Hieroglyphs)";
            label7.Location = new Point(margin, 190);
            field7.Location = new Point(label7.Location.X + label7.Bounds.Right + Padding.Right, label7.Location.Y);
            field7.Checked = smileys_mini;
            label8.Text = "Unicode (Symbols)";
            label8.Location = new Point(margin, 220);
            field8.Location = new Point(label8.Location.X + label8.Bounds.Right + Padding.Right, label8.Location.Y);
            field8.Checked = smileys_mini;
            button1.Text = "OK";
            button1.Location = new Point(110, 280);
            button2.Text = "Cancel";
            button2.Location = new Point(button1.Bounds.Right + margin, button1.Location.Y);
            this.Height = 350;
            this.Text = "Awesome Screensaver Settings";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = button1;
            this.CancelButton = button2;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(label1);
            this.Controls.Add(field1);
            this.Controls.Add(label2);
            this.Controls.Add(field2);
            this.Controls.Add(label3);
            this.Controls.Add(field3);
            this.Controls.Add(label4);
            this.Controls.Add(field4);
            this.Controls.Add(label5);
            this.Controls.Add(field5);
            this.Controls.Add(label6);
            this.Controls.Add(field6);
            this.Controls.Add(label7);
            this.Controls.Add(field7);
            this.Controls.Add(label8);
            this.Controls.Add(field8);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
        }
    }
}