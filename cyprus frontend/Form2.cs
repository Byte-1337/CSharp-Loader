using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkeetUI;

namespace cyprus_frontend
{
    public partial class Form2 : skeetForm
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Borderless
            this.MaximizeBox = false; // Disable maximize box

            // Subscribe to the Resize event
            this.Resize += Form1_Resize;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Set a fixed size whenever the form is resized
            this.Size = new Size(325, 241);
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("READ INSTRUCTIONS BEFORE USAGE \n 1. Must have Medal Installed and Medal Overlay enbabled \n 2. Make sure game is closed before loading cheat \n 3. When loader comes up makesure to press y to load drivers, only press no if you have already loaded them in the same boot. \n 4. Enjoy");
            //load cheat function here
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_Paint(object sender, PaintEventArgs e)
        {
            // Clear the background
            e.Graphics.Clear(guna2TextBox3.BackColor);

            // Draw the text
            TextRenderer.DrawText(e.Graphics, guna2TextBox3.Text, guna2TextBox3.Font,
            guna2TextBox3.ClientRectangle, guna2TextBox3.ForeColor, Color.Transparent,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void guna2TextBox1_Paint(object sender, PaintEventArgs e)
        {
            // Clear the background
            e.Graphics.Clear(guna2TextBox1.BackColor);

            // Draw the text
            TextRenderer.DrawText(e.Graphics, guna2TextBox1.Text, guna2TextBox1.Font,
            guna2TextBox1.ClientRectangle, guna2TextBox1.ForeColor, Color.Transparent,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void guna2TextBox2_Paint(object sender, PaintEventArgs e)
        {
            // Clear the background
            e.Graphics.Clear(guna2TextBox2.BackColor);

            // Draw the text
            TextRenderer.DrawText(e.Graphics, guna2TextBox2.Text, guna2TextBox2.Font,
             guna2TextBox2.ClientRectangle, guna2TextBox2.ForeColor, Color.Transparent,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
