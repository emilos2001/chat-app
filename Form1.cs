using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChatDemo
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost;uid=root;pwd=root;database=users";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool validateInput(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
            {
                showWarning("User name field cannot be empty!");
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                showWarning("Password field cannot be empty!");
                return false;
            }
            return true;
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

        private void signUpButton_Click_1(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void showWarning(string message)
        {
            warningSign.Visible = true;
            warning.Visible = true;
            warning.Text = message;
        }


        private void signInButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            string querry = "select * from login where userName = @userName";
            string userName = userTxt.Text;
            string password = passwordTxt.Text;
            if (validateInput(userName, password))
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(querry, conn);
                        cmd.Parameters.AddWithValue("@userName", userName);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string passwordDB = reader["password"].ToString();
                            if (password == passwordDB)
                            {
                                profile.user = userTxt.Text;
                                profile.password = password;
                                profile.Show();
                                this.Hide();
                            }
                            else
                            {
                                warningSign.Visible = true;
                                warning.Visible = true;
                                warning.Text = "Invalid username or password. Please try again";
                            }
                        }
                        else
                        {
                            warningSign.Visible = true;
                            warning.Visible = true;
                            warning.Text = "Invalid username or password. Please try again";
                        }
                        reader.Close();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            profile.imageRetrieve(userName);
        } 

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
