
namespace ChatDemo
{
    partial class Form2
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
            this.requestToChat = new System.Windows.Forms.Panel();
            this.roundedButtons2 = new ChatDemo.RoundedButtons();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedButtons1 = new ChatDemo.RoundedButtons();
            this.requestToChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // requestToChat
            // 
            this.requestToChat.BackColor = System.Drawing.Color.OliveDrab;
            this.requestToChat.Controls.Add(this.roundedButtons2);
            this.requestToChat.Controls.Add(this.pictureBox5);
            this.requestToChat.Controls.Add(this.label4);
            this.requestToChat.Controls.Add(this.roundedButtons1);
            this.requestToChat.Location = new System.Drawing.Point(151, 237);
            this.requestToChat.Name = "requestToChat";
            this.requestToChat.Size = new System.Drawing.Size(668, 63);
            this.requestToChat.TabIndex = 39;
            this.requestToChat.Visible = false;
            // 
            // roundedButtons2
            // 
            this.roundedButtons2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.roundedButtons2.FlatAppearance.BorderSize = 0;
            this.roundedButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtons2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButtons2.ForeColor = System.Drawing.Color.Black;
            this.roundedButtons2.Location = new System.Drawing.Point(517, 10);
            this.roundedButtons2.Name = "roundedButtons2";
            this.roundedButtons2.Size = new System.Drawing.Size(69, 40);
            this.roundedButtons2.TabIndex = 33;
            this.roundedButtons2.Text = "NO!";
            this.roundedButtons2.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(27, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OliveDrab;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(262, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "has sent you to request to chat";
            // 
            // roundedButtons1
            // 
            this.roundedButtons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.roundedButtons1.FlatAppearance.BorderSize = 0;
            this.roundedButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtons1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButtons1.ForeColor = System.Drawing.Color.Black;
            this.roundedButtons1.Location = new System.Drawing.Point(592, 10);
            this.roundedButtons1.Name = "roundedButtons1";
            this.roundedButtons1.Size = new System.Drawing.Size(69, 40);
            this.roundedButtons1.TabIndex = 20;
            this.roundedButtons1.Text = "YES!";
            this.roundedButtons1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 536);
            this.Controls.Add(this.requestToChat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.requestToChat.ResumeLayout(false);
            this.requestToChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel requestToChat;
        private RoundedButtons roundedButtons2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private RoundedButtons roundedButtons1;
    }
}