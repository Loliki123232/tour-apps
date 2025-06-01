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

namespace WinFormsApp1
{
    public partial class LoginAdminForm : Form
    {
        BdManager bdManager = new BdManager();
        Authenticator authenticator = new Authenticator();
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        private string selectedEmail;
        private string selectedPassword;
        public LoginAdminForm()
        {
            InitializeComponent();
            dbConnection.OpenConnection();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            selectedEmail = EmailTextBox.Text;
            selectedPassword = PasswordTextBox.Text;
            if (authenticator.AreCredentialsValidAdmin(selectedEmail, selectedPassword))
            {
                MessageBox.Show("Успешный вход.");
                dbConnection.CloseConnection();
                this.Close();
                AdminWorkForm adminWorkFoem = new AdminWorkForm();
                adminWorkFoem.Show();
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
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
