namespace WinFormsApp1
{
    partial class LoginForm
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
            EmailLabel = new Label();
            PasswordLable = new Label();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignInButton = new Button();
            SignUpButton = new Button();
            AdminButton = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(32, 38);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 0;
            EmailLabel.Text = "Email";
            // 
            // PasswordLable
            // 
            PasswordLable.AutoSize = true;
            PasswordLable.Location = new Point(32, 99);
            PasswordLable.Name = "PasswordLable";
            PasswordLable.Size = new Size(70, 20);
            PasswordLable.TabIndex = 1;
            PasswordLable.Text = "Password";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(32, 69);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(365, 27);
            EmailTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(32, 131);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '•';
            PasswordTextBox.Size = new Size(365, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(32, 340);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(94, 29);
            SignInButton.TabIndex = 4;
            SignInButton.Text = "войти";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(285, 340);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(112, 29);
            SignUpButton.TabIndex = 4;
            SignUpButton.Text = "регистрация";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(565, 53);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(171, 29);
            AdminButton.TabIndex = 4;
            AdminButton.Text = "вход админа";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(422, 131);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "показать";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(AdminButton);
            Controls.Add(SignUpButton);
            Controls.Add(SignInButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PasswordLable);
            Controls.Add(EmailLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmailLabel;
        private Label PasswordLable;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Button SignInButton;
        private Button SignUpButton;
        private Button AdminButton;
        private CheckBox checkBox1;
    }
}