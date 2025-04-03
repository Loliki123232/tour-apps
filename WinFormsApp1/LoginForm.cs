using CommonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace WinFormsApp1
{

    public partial class LoginForm : Form
    {
        BdManager bdManager = new BdManager();
        Authenticator authenticator = new Authenticator();
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        private string selectedEmail;
        private string selectedPassword;
        public LoginForm()
        {
            InitializeComponent();
            dbConnection.OpenConnection();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            dbConnection.CloseConnection();
        }
        private bool IsValidEmail(string email)
        {

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            selectedEmail = EmailTextBox.Text;
            selectedPassword = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(selectedEmail) || string.IsNullOrEmpty(selectedPassword))
            {
                MessageBox.Show("Пожалуйста, введите email и password.");
                return;
            }
            if (!IsValidEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите корректный email.");
                return;
            }
            if (selectedEmail.Equals(selectedPassword, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Пароль не должен совпадать с email.");
                return;
            }
            bdManager.SaveSelectedValueClientToDatabase(selectedEmail, selectedPassword);
            MessageBox.Show("Регистрация прошла успешно");
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            selectedEmail = EmailTextBox.Text;
            selectedPassword = PasswordTextBox.Text;
            if (authenticator.AreCredentialsValidClient(selectedEmail, selectedPassword))
            {
                MessageBox.Show("Успешный вход.");
                dbConnection.CloseConnection();
                ClientAddForm clientAddForm = new ClientAddForm();
                clientAddForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный email или пароль.");
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '•';
            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            //LoginAdminForm loginAdminForm = new LoginAdminForm();
           // loginAdminForm.ShowDialog();
        }
    }
}
