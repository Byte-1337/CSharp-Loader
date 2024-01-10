using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using SkeetUI;

namespace cyprus_frontend
{
    public partial class Form1 : skeetForm
    {
        public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: "1.0"
        );
        public Form1()
        {
            InitializeComponent();
            // Set the form properties for a borderless form
            this.FormBorderStyle = FormBorderStyle.None; // Borderless
            this.MaximizeBox = false; // Disable maximize box

            // Subscribe to the Resize event
            this.Resize += Form1_Resize;
            KeyAuthApp.init();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Set a fixed size whenever the form is resized
            this.Size = new Size(325, 241);
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(guna2TextBox1.Text, guna2TextBox2.Text);
            if (KeyAuthApp.response.success)
            {
                Form2 main = new Form2();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Credentials");
        }
    }
}
