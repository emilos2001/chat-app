namespace ChatDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.showHideBox = new System.Windows.Forms.CheckBox();
            this.warning = new System.Windows.Forms.Label();
            this.warningSign = new System.Windows.Forms.PictureBox();
            this.exit = new ChatDemo.RoundedButtons();
            this.signUpButton = new ChatDemo.RoundedButtons();
            this.signInButton = new ChatDemo.RoundedButtons();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.warningSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(213, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "USER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD";
            // 
            // userTxt
            // 
            this.userTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.userTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTxt.Location = new System.Drawing.Point(192, 203);
            this.userTxt.Margin = new System.Windows.Forms.Padding(4);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(249, 29);
            this.userTxt.TabIndex = 6;
            this.userTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTxt.Location = new System.Drawing.Point(191, 313);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(249, 29);
            this.passwordTxt.TabIndex = 7;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showHideBox
            // 
            this.showHideBox.AutoSize = true;
            this.showHideBox.ForeColor = System.Drawing.Color.Black;
            this.showHideBox.Location = new System.Drawing.Point(449, 319);
            this.showHideBox.Margin = new System.Windows.Forms.Padding(4);
            this.showHideBox.Name = "showHideBox";
            this.showHideBox.Size = new System.Drawing.Size(62, 20);
            this.showHideBox.TabIndex = 9;
            this.showHideBox.Text = "Show";
            this.showHideBox.UseVisualStyleBackColor = true;
            this.showHideBox.CheckedChanged += new System.EventHandler(this.showHideBox_CheckedChanged);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.Location = new System.Drawing.Point(159, 379);
            this.warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 23);
            this.warning.TabIndex = 10;
            this.warning.Visible = false;
            // 
            // warningSign
            // 
            this.warningSign.Image = ((System.Drawing.Image)(resources.GetObject("warningSign.Image")));
            this.warningSign.Location = new System.Drawing.Point(95, 379);
            this.warningSign.Margin = new System.Windows.Forms.Padding(4);
            this.warningSign.Name = "warningSign";
            this.warningSign.Size = new System.Drawing.Size(56, 23);
            this.warningSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.warningSign.TabIndex = 11;
            this.warningSign.TabStop = false;
            this.warningSign.Visible = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(505, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 47);
            this.exit.TabIndex = 12;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.Color.Black;
            this.signUpButton.Location = new System.Drawing.Point(353, 442);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(200, 49);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click_1);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.ForeColor = System.Drawing.Color.Black;
            this.signInButton.Location = new System.Drawing.Point(16, 442);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(200, 49);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "SIGN IN";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatDemo.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(242, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(569, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.warningSign);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.showHideBox);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warningSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChatDemo.RoundedButtons signInButton;
        private RoundedButtons signUpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.CheckBox showHideBox;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.PictureBox warningSign;
        private RoundedButtons exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

