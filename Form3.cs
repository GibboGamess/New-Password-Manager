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
using System.Configuration;
using System.Security.Cryptography;

namespace PasswordManager
{
    public partial class Form3 : Form
    {

        private BindingList<string> PasswordList = new BindingList<string>(); //binds passwordlist which provides additional control over list items, i.e. if they can be edited, removed or added
        public Form3()
        {
            InitializeComponent();
            listBox1.DataSource = PasswordList; //sets the datasource, the data that will be stored inside of the listbox as the password list. 
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            PasswordList.Add(txt_newPassword.Text); //adds the text from the text box to the password list. 
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines("C:\\Users\\Joshg\\Desktop\\Password Manager V3\\Passwords.txt", listBox1.Items.Cast<string>().ToArray()); //writes all saved passwords to the list 
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Joshg\Desktop\Password Manager V3\\Passwords.txt");

            foreach (string line in lines) //iterates through every string inside of the array
            {
                PasswordList.Add(line); //adds every line thgat it iterates through to the display list box.
            }


        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_newPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
