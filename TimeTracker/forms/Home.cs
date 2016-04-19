using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TimeTracker.DB;

namespace TimeTracker
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
            this.TopMost = true;
            registerShowHook();
            registerHideHook();
        }

        //register the show hook (keyboard combination to show the application)
        void registerShowHook()
        {
            KeyboardHook showHook = new KeyboardHook();
            showHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(shoHook_KeyPressed);
            showHook.RegisterHotKey(TimeTracker.ModifierKeys.Control | TimeTracker.ModifierKeys.Shift,
                Keys.Up);
        }
        //Event fired when showHook is activated
        void shoHook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Console.WriteLine("Show Hook Key Pressed");
            this.Show();
            this.Focus();
        }

        //register the hide hook (keyboard combination to hide the application)
        void registerHideHook()
        {
            KeyboardHook hideHook = new KeyboardHook();
            hideHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hideHook_KeyPressed);
            hideHook.RegisterHotKey(TimeTracker.ModifierKeys.Control | TimeTracker.ModifierKeys.Shift,
                Keys.Down);
        }
        //Event fired when showHook is activated
        void hideHook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Console.WriteLine("Hide Hook Key Pressed");
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
            
            //System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            //shape.AddEllipse(0, 0, this.Width*2, this.Height*2);
            //this.Region = new System.Drawing.Region(shape);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainDB db = new MainDB();
        }

    }
}
