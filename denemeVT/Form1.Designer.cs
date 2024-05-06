namespace denemeVT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            loginButton = new Button();
            logoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource.Vexels_Office_Key_lock_512;
            pictureBox1.Location = new Point(63, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(310, 106);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(310, 144);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // usernameTextbox
            // 
            usernameTextbox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextbox.Location = new Point(401, 106);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(143, 27);
            usernameTextbox.TabIndex = 3;
            // 
            // passwordTextbox
            // 
            passwordTextbox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextbox.Location = new Point(401, 137);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(143, 27);
            passwordTextbox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.ForestGreen;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(310, 207);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(114, 42);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login ";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Red;
            logoutButton.BackgroundImage = Resource.logout;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(430, 207);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(114, 42);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // Form1
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = logoutButton;
            ClientSize = new Size(622, 364);
            Controls.Add(logoutButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button loginButton;
        private Button logoutButton;
    }
}
