using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ChatDemo
{
    public partial class SignUp : Form
    {
        string connection = "server=localhost;uid=root;pwd=root;database=users";
        public SignUp()
        {
            InitializeComponent();
        }
        static bool validEmailAddress(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

        static bool nameValid(string name)
        {
            string pattern = "^[A-Za-z]+([-']?[A-Za-z]+)*$";
            return Regex.IsMatch(name, pattern);
        }

     
        static string randomPassword()
        {
            int length = 10;
            string uppercase = "ABCDEFGHIJKLMNOPRQSTUWXYZ";
            string lowercase = "abcdefghijklmnoprqstuwxyz";
            string numbers = "1234567890";
            string characters = "<>.-+_,/?;':{}[]()~`|$#@!%^&*";
            char quotation = '"';
            string code = uppercase + lowercase + numbers + characters + quotation;
            Random random = new Random();
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                int randomPassword = random.Next(code.Length);
                password[i] = code[randomPassword];
            }
            return new string(password);
        }

        private bool validateInput(string name, string userName, string email, string password, string rePassword)
        {
            if (string.IsNullOrEmpty(name))
            {
                showWarning("Name field cannot be empty!");
                return false;
            }

            if (!nameValid(name))
            {
                showWarning("Only characters allowed in name!");
                return false;
            }

            if (string.IsNullOrEmpty(userName))
            {
                showWarning("User name field cannot be empty!");
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                showWarning("Email field cannot be empty!");
                return false;
            }

            if (!validEmailAddress(email))
            {
                showWarning("Invalid email address!");
                return false;
            }

         

            if (string.IsNullOrEmpty(password))
            {
                showWarning("Password field cannot be empty!");
                return false;
            }

            if (string.IsNullOrEmpty(rePassword))
            {
                showWarning("Confirm password field cannot be empty!");
                return false;
            }

            if (!terms.Checked)
            {
                showWarning("Please check the box to continue!");
                return false;
            }

            if (password != rePassword)
            {
                showWarning("Passwords do not match!");
                return false;
            }
            return true;
        }

        private void showWarning(string message)
        {
            warningSign.Visible = true;
            warning.Visible = true;
            warning.Text = message;
        }

        private void signUpButton_Click_1(object sender, EventArgs e)
        {
            string fullName = nameTxt.Text;
            string userName = userNameTxt.Text;
            string email = mailTxt.Text;
            string password = passwordTxt.Text;
            string rePassword = rePasswordTxt.Text;
            if (validateInput(fullName, userName, email, password, rePassword))
            {
                string querry = "insert into login(fullName, userName, email, password) values (@fullName, @userName, @email, @password)";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        MySqlCommand cmd = new MySqlCommand(querry, conn);
                        MemoryStream me = new MemoryStream();
                        cmd.Parameters.AddWithValue("fullName", nameTxt.Text);
                        cmd.Parameters.AddWithValue("userName", userNameTxt.Text);
                        cmd.Parameters.AddWithValue("email", mailTxt.Text);
                        cmd.Parameters.AddWithValue("password", passwordTxt.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        autoLogin.Visible = true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void showHideBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showHideBox.Checked)
            {
                showHideBox.Text = "Hide";
                passwordTxt.PasswordChar = '\0';
            }
            else
            {
                showHideBox.Text = "Show";
                passwordTxt.PasswordChar = '*';
            }
        }

        private void showHideBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showHideBox.Checked)
            {
                showHideBox.Text = "Hide";
                passwordTxt.PasswordChar = '\0';
                rePasswordTxt.PasswordChar = '\0';
            }
            else
            {
                showHideBox.Text = "Show";
                passwordTxt.PasswordChar = '*';
                rePasswordTxt.PasswordChar = '*';
            }
        }

        private void generateBox_CheckedChanged(object sender, EventArgs e)
        {
            if (generateBox.Checked)
            {
                string pasword = randomPassword();
                string rePassword = randomPassword();
                passwordTxt.Text = pasword;
                rePasswordTxt.Text = rePassword;
            }
            generateBox.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.user = userNameTxt.Text;
            profile.password = passwordTxt.Text;
            profile.Show();
            this.Hide();
        }

        private void no_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}

