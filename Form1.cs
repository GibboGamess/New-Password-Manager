namespace PasswordManager
{
    public partial class Form1 : Form
    {
        int currentPasswordLength = 0;
        Random character = new Random();

        private void passwordGenerator(int passwordLength) //We load the integer password length from the slider 
        {
            string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz!-^@&$#?>";
            string randomPassword = ""; //declares password string, which is where we stored the password.

            for (int i = 0; i < passwordLength; i++) // here we use a forloop, this is because we take random character from characters and then increment i by 1 all the way until i is the same as the password lenghth the user selected (starts at 0 so if PL was 8 it would iterate from 0-7) 

            {
                int randomNum = character.Next(0, Characters.Length); //This generated a random number from the first index which is 0, with the upper boundry being the length of the characters string
                randomPassword += Characters[randomNum]; // this line of code, helps generate the randomness of the generator, this declares that random password equals the random index value from  randomnum in the characters dataset. 
            }
            PasswordLabel.Text = randomPassword; //after it is done looping and generates the password, this label will update with the final password which is the string random password. 
        }

        public Form1()
        {
            InitializeComponent();
            PasswordLengthSlider.Minimum = 10;// sets minimum length the user can select on the slider
            PasswordLengthSlider.Maximum = 30;// sets maximum length the user can select on the slider
            passwordGenerator(10); //sets the default amount when opening the app to 10 on the slider
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordLabel.Text); //copies whatever is stord in the label, passwordlabel to the clipboard so that you can store it in the storage section of the application. 
        }

        private void PasswordLengthSlider_Scroll(object sender, EventArgs e)
        {
            PasswordLengthLabel.Text = "Password Length: " + PasswordLengthSlider.Value.ToString();
            currentPasswordLength = PasswordLengthSlider.Value;
            passwordGenerator(currentPasswordLength); //the method is being called every time the user slides the slider and the data would be passed into the value to change the value at the bottom.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
