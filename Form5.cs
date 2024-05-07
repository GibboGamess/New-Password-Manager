using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password123") //checks if master password is the same as 'Password123' if it is it will show the main application.
            {
                Form2 f2 = new Form2();
                f2.Show(); //shows the main application which its main menu is form2 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false; //shows secret password for logging in
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true; //hides master password after you showed it
        }
    }
}
