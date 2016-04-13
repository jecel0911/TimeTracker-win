using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Form1 : Form
    {
        KeyboardHook hook = new KeyboardHook();

        public Form1()
        {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(TimeTracker.ModifierKeys.Control | TimeTracker.ModifierKeys.Shift,
                Keys.T);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            Console.WriteLine("Control + Alt + T pressed");
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

        }

    }
}
