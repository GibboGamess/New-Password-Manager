using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordManager
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(home);
            home.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //if the application exit button is clicked, the application will be forcibly closed. 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 home = new Form3(); //makes form3 home
            home.TopLevel = false;
            content.Controls.Clear(); //clears the content controls (panel) if another form is open
            content.Controls.Add(home); //Adds home, which is now form3 to the content controls. 
            home.Show(); //shows home, inside of the panel. 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 home = new Form4();
            home.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(home);
            home.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
