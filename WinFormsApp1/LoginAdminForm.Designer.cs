namespace WinFormsApp1
{
    partial class LoginAdminForm
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
            checkBox1 = new CheckBox();
            SignInButton = new Button();
            ExitButton = new Button();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordLable = new Label();
            EmailLabel = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(402, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "показать";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(135, 314);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(94, 29);
            SignInButton.TabIndex = 10;
            SignInButton.Text = "войти";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(16, 314);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 105);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '•';
            PasswordTextBox.Size = new Size(365, 27);
            PasswordTextBox.TabIndex = 9;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(12, 43);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(365, 27);
            EmailTextBox.TabIndex = 8;
            // 
            // PasswordLable
            // 
            PasswordLable.AutoSize = true;
            PasswordLable.Location = new Point(12, 73);
            PasswordLable.Name = "PasswordLable";
            PasswordLable.Size = new Size(70, 20);
            PasswordLable.TabIndex = 7;
            PasswordLable.Text = "Password";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(12, 12);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // LoginAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(SignInButton);
            Controls.Add(ExitButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PasswordLable);
            Controls.Add(EmailLabel);
            Name = "LoginAdminForm";
            Text = "LoginAdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button SignInButton;
        private Button ExitButton;
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private Label PasswordLable;
        private Label EmailLabel;
    }
}