using Google.Apis.Admin.Directory.directory_v1.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace ChatDemo
{
    public partial class Profile : Form
    {
        string connection = "server=localhost;uid=root;pwd=root;database=users";
        public  string user { get; set; }
        public string password { get; set; }
        Form1 form1 = new Form1();
        public int chatId;
        public string request = "Start chat?";
        public Profile()
        {
            InitializeComponent();
        }
        private void randomChatOff()
        {
            startChatPanel.Visible = false;
            findRandomChat.Visible = false;
            textRan.Visible = false;
        }
        private void menu()
        {
            if (panelMenu.Size == panelMenu.MinimumSize)
            {
                close.Visible = true;
                open.Visible = false;
                nameOfUser.Location = new Point(368, 12);
                sentButton.Location = new Point(531, 555);
                panelChat.Location = new Point(242, 0);
                notify.Location = new Point(183, 263);
                panelMenu.Size = panelMenu.MaximumSize;
                panelChat.Size = panelChat.MinimumSize;
                messageSent.Size = messageSent.MinimumSize;
                profilePicture.Size = profilePicture.MaximumSize;
                profilePicture.Left += 50;
                userName.Visible = true;
            }
            else if (panelMenu.Size == panelMenu.MaximumSize)
            {
                close.Visible = false;
                open.Visible = true;
                nameOfUser.Left += 250;
                sentButton.Left += 200;
                panelChat.Location = new Point(69, 0);
                notify.Location = new Point(34,256);
                panelMenu.Size = panelMenu.MinimumSize;
                panelChat.Size = panelChat.MaximumSize;
                messageSent.Size = messageSent.MaximumSize;
                profilePicture.Size = profilePicture.MinimumSize;
                profilePicture.Left -= 50;
                userName.Visible = false;
                randomChatOff();
            }
        }

        private void massegeBox_Click(object sender, EventArgs e)
        {
            menu();
        }

        private void randomBox_Click(object sender, EventArgs e)
        {
            menu();
        }

        private void settingsBox_Click(object sender, EventArgs e)
        {
            menu();
        }

        private void signOutBox_Click(object sender, EventArgs e)
        {
            menu();
        }

        private void close_Click(object sender, EventArgs e)
        {
            menu();
        }

        private void open_Click(object sender, EventArgs e)
        {
            menu();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            userName.Text = user;
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Location = new Point(322, 144);
            settingsPanel.Visible = true;
            randomChatOff();
            quit.Visible = false;
            panelChat.Visible = false;
        }

        private void settingsMinimumSize()
        {
            pictureBox.Location = new Point(153, 21);
            uploadImage.Location = new Point(107, 141);
            changePassword.Location = new Point(107, 203);
            changeUserName.Location = new Point(107, 275);
            deleteButton.Location = new Point(107, 338);
            settingsPanel.Size = settingsPanel.MinimumSize;
            exitSettings.Size = exitSettings.MaximumSize;
        }

        private void settingsMaximumSize()
        {
            pictureBox.Location = new Point(153, 21);
            uploadImage.Location = new Point(14, 141);
            changePassword.Location = new Point(14, 203);
            changeUserName.Location = new Point(14, 275);
            deleteButton.Location = new Point(14, 338);
            settingsPanel.Size = settingsPanel.MaximumSize;
            exitSettings.Size = exitSettings.MinimumSize;
        }
        private void defaultAll()
        {
            oldPasswordChek.Checked = false;
            newPasswordChek.Checked = false;
            oldPasswordTxt.Text = "";
            newPasswordTxt.Text = "";
            passwordChangeWarning.Text = "";
            newUserTxt.Text = "";
            message.Visible = false;
        }
        private void settings()
        {
            if (settingsPanel.Size == settingsPanel.MinimumSize)
            {
                settingsMaximumSize();
            }
            else if (settingsPanel.Size == settingsPanel.MaximumSize)
            {
                settingsMaximumSize();
            }
        }
        private void uploadImage_Click(object sender, EventArgs e)
        {
            settings();
            if (settingsPanel.Size == settingsPanel.MaximumSize)
            {
                pictureBox.Location = new Point(360, 87);
                editImageButton.Visible = true;
            }
            else if (settingsPanel.Size == settingsPanel.MinimumSize)
            {
                defaultAll();
                pictureBox.Location = new Point(153, 21);
                editImageButton.Visible = false;
            }
            changePasswordPanel.Visible = false;
            changeUsernamePanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void changeUserName_Click(object sender, EventArgs e)
        {
            settings();
            if (settingsPanel.Size == settingsPanel.MaximumSize)
            {
                changeUsernamePanel.Visible = true;
            }
            else if (settingsPanel.Size == settingsPanel.MinimumSize)
            {
                defaultAll();
                changeUsernamePanel.Visible = false;
            }
            changePasswordPanel.Visible = false;
            editImageButton.Visible = false;
            deletePanel.Visible = false;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            settings();
            if (settingsPanel.Size == settingsPanel.MaximumSize)
            {
                changePasswordPanel.Visible = true;
            }
            else if (settingsPanel.Size == settingsPanel.MinimumSize)
            {
                defaultAll();
                changePasswordPanel.Visible = false;
            }
            editImageButton.Visible = false;
            changeUsernamePanel.Visible = false;
            deletePanel.Visible = false;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            settings();
            if (settingsPanel.Size == settingsPanel.MaximumSize)
            {
                deletePanel.Visible = true;
            }
            else if (settingsPanel.Size == settingsPanel.MinimumSize)
            {
                defaultAll();
                deletePanel.Visible = false;
            }
            editImageButton.Visible = false;
            changeUsernamePanel.Visible = false;
            changePasswordPanel.Visible = false;
        }
        private void exitSettings_Click(object sender, EventArgs e)
        {
            settingsMinimumSize();
            defaultAll();
            editImageButton.Visible = false;
            changeUsernamePanel.Visible = false;
            changePasswordPanel.Visible = false;
            deletePanel.Visible = false;
            settingsPanel.Visible = false;
        }
        private void oldPasswordChek_CheckedChanged(object sender, EventArgs e)
        {
            if (oldPasswordChek.Checked)
            {
                oldPasswordChek.Text = "Hide";
                oldPasswordTxt.PasswordChar = '\0';
            }
            else
            {
                oldPasswordChek.Text = "Show";
                oldPasswordTxt.PasswordChar = '*';
            }
        }

        private void newPasswordChek_CheckedChanged(object sender, EventArgs e)
        {
            if (newPasswordChek.Checked)
            {
                newPasswordChek.Text = "Hide";
                newPasswordTxt.PasswordChar = '\0';
            }
            else
            {
                newPasswordChek.Text = "Show";
                newPasswordTxt.PasswordChar = '*';
            }
        }

        private void newUserTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newUserTxt.Text))
            {
                okUserNameButton.Visible = true;
            }
            else
            {
                okUserNameButton.Visible = false;
            }
        }


        private void no_Click(object sender, EventArgs e)
        {
            settingsMaximumSize();
            deletePanel.Visible = false;
        }
        private void okUserNameButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                string query = "update login set userName = @NewUserName where userName = @OldUserName";
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewUserName", newUserTxt.Text);
                        cmd.Parameters.AddWithValue("@OldUserName", userName.Text);
                        userName.Text = newUserTxt.Text;
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            userName.Text = reader[1].ToString();
                        }
                        message.Visible = true;
                        newUserTxt.Text = "";
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void okPasswordButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    if (oldPasswordTxt.Text.Equals(password))
                    {
                        conn.Open();
                        string query = "update login set password = @NewPassword where password = @OldPassword";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@OldPassword", oldPasswordTxt.Text);
                            cmd.Parameters.AddWithValue("@NewPassword", newPasswordTxt.Text);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            reader.Read();
                            if (reader.HasRows)
                            {
                                newPasswordTxt.Text = reader[3].ToString();
                            }
                            passwordChangeWarning.Visible = true;
                            passwordChangeWarning.Text = "PASSWORD HAS BEEN CHANGED \n WITH SUCCESS!";
                            okPasswordButton.Visible = false;
                        }
                        conn.Close();
                    }
                    else
                    {
                        warning.Visible = true;
                        passwordChangeWarning.Visible = true;
                        passwordChangeWarning.Text = "PASSWORD IS INCORECT!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void yes_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    string query = "delete from login where userName = @userName";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", userName.Text);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            form1.Show();
            this.Hide();
        }
        private void newPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newPasswordTxt.Text))
            {
                okPasswordButton.Visible = true;
            }
            else
            {
                warning.Visible = false;
                passwordChangeWarning.Visible = false;
                okPasswordButton.Visible = false;
            }
        }

        private void editImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = dialog.FileName;
                imageRetrieve(imagePath);
                imageUploader(imagePath);
            }
        }

        public void imageRetrieve(string userName)
        {
            string imagePath = null;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "select userImage from login where userName = @userName";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            imagePath = reader["userImage"].ToString();
                        }
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            profilePicture.ImageLocation = imagePath;
                            pictureBox.ImageLocation = imagePath;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public void imageUploader(string imagePath)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "update login set userImage = @userImage where userName = @userName";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userImage", imagePath);
                    cmd.Parameters.AddWithValue("@userName", userName.Text);
                    cmd.ExecuteNonQuery();
                    pictureBox.ImageLocation = imagePath;
                    profilePicture.ImageLocation = imagePath;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void signOut_Click_1(object sender, EventArgs e)
        {
            quit.Visible = true;
            quit.Location = new Point(294, 226);
            panelChat.Visible = false;
            settingsPanel.Visible = false;
            randomChatOff();
        }

        private void noExitButton_Click(object sender, EventArgs e)
        {
            quit.Visible = false;
        }

        private void yesExitButton_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void random_Click(object sender, EventArgs e)
        {
            findRandomChat.Visible = true;
            findRandomChat.Location = new Point(387, 106);
            textRan.Visible = true;
            panelChat.Visible = false;
            textRan.Text = "PUSH THE BUTTON TO FIND A RANDOM USER";
            quit.Visible = false;
            settingsPanel.Visible = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Stop();
            textRan.Visible = false;
        }
        private void findRandomChat_Click(object sender, EventArgs e)
        {
            if (textRan.Text == null)
            {
                timer1 = new Timer();
                timer1.Interval = 2000;
                timer1.Tick += timer1_Tick;
                timer1.Start();
            }
            else
            {

                timer1.Start();
            }
            changeRandomUser();
            startChatPanel.Visible = true;
            textRan.Visible = false;
        }
        private void startChatPanel_Paint(object sender, PaintEventArgs e)
        {
            changeRandomUser();
        }
        private void changeRandomUser()
        {
            try
            { 
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    string query = "select * from login where userName != @userName order by rand() limit 1;";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userName", userName.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (randomUsername.Text != userName.Text)
                        {
                            randomUsername.Text = reader[1].ToString();
                            randomProfilePicture.ImageLocation = reader[4].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startChat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string checkQuery1 = "select count(*) from chat where (userOne = @userOne and userTwo = @userTwo) or (userOne = @userTwo and userTwo = @userOne)";
                MySqlCommand checkCmd1 = new MySqlCommand(checkQuery1, conn);
                checkCmd1.Parameters.AddWithValue("@userOne", userName.Text);
                checkCmd1.Parameters.AddWithValue("@userTwo", randomUsername.Text);

                int existId = Convert.ToInt32(checkCmd1.ExecuteScalar());

                if (existId == 0)
                { 
                    string insertQuery = "insert into chat (id, userOne, userTwo) values (@id, @userOne, @userTwo)";
                    MySqlCommand insertcmd = new MySqlCommand(insertQuery, conn);
                    insertcmd.Parameters.AddWithValue("@id", chatId);
                    insertcmd.Parameters.AddWithValue("@userOne", userName.Text);
                    insertcmd.Parameters.AddWithValue("@userTwo", randomUsername.Text);
                    insertcmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            randomChatOff();
            nameOfUser.Text = randomUsername.Text;
            pictureOfUser.Image = randomProfilePicture.Image;
            panelChat.Location = new Point(242, 0);
            panelChat.Visible = true;
            settingsPanel.Visible = false;
            quit.Visible = false;
        }

        /* public void SendRequest(int chatId, string filePath)
         {
             using (StreamWriter writer = File.AppendText(filePath))
             {
                 writer.WriteLine(userName.Text + " -> " + randomUsername.Text + "\n");
                 writer.WriteLine("___________________________________________________________");
             }
             using(MySqlConnection conn = new MySqlConnection(connection))
             {
                 conn.Open();
                 string query = "select request = @request from chat where id = @id";
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                 cmd.Parameters.AddWithValue("@id", chatId);
                 conn.Close();
             }
         }*/


        private void sentButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Emil\Desktop\chats\chat.txt " + chatId;
            string message = writeFileTxt(filePath);
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "update chat set message = @message where (userOne = @userOne and userTwo = @userTwo) or (userOne = @userTwo and userTwo = @userOne)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userOne", userName.Text);
                cmd.Parameters.AddWithValue("@userTwo", randomUsername.Text);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            mess.Visible = true;
            mess.Text = messageSent.Text;
            messageSent.Text = " ";
            prevmess.Visible = true;
            prevmess.Text = readFileTxt(message);
        }

        private string writeFileTxt(string filePath)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(userName.Text + " : " + messageSent.Text + "\n");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return filePath;
        }

        private string readFileTxt(string filePath)
        {
            try
            {
                string line = File.ReadLines(filePath).Skip(6).First();
                return line;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void chats_Click(object sender, EventArgs e)
        {
            randomChatOff();
            panelRequest.Visible = true;
            panelChat.Visible = false;
            sadFace.Visible = true;
            noRequest.Visible = true;
            settingsPanel.Visible = false;
            quit.Visible = false;
        }
    }
}