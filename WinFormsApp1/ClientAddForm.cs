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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WinFormsApp1
{
    public partial class ClientAddForm : Form
    {
        BdManager bdManager = new BdManager();
        Authenticator authenticator = new Authenticator();
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        private string firstname;
        private string lastname;
        private string middlename;
        private int number;
        private string numbercard;
        private string validuntil;
        private int ccvcode;
        public ClientAddForm()
        {
            InitializeComponent();
            dbConnection.OpenConnection();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            
        }
        private void SaveInfoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text) || string.IsNullOrEmpty(MiddleNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите Имя, Фамилию и Отчество.");
                return;
            }
            if (string.IsNullOrEmpty(NumberCardTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите номер карты.");
                return;
            }

            // Проверяем численные значения и формат номера карты
            if (!int.TryParse(NumberTextBox.Text, out number) || number <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректный номер (положительное целое число).");
                return;
            }

            if (!int.TryParse(CCVTextBox.Text, out ccvcode) || ccvcode <= 0 || ccvcode.ToString().Length < 3 || ccvcode.ToString().Length > 4)
            {
                MessageBox.Show("Пожалуйста, введите корректный CVV-код (3 или 4 цифры).");
                return;
            }
            if (string.IsNullOrEmpty(ValidUntilTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите срок действия карты");
                return;
            }
            bdManager.SaveSelectedValueClientToDatabase(
         FirstNameTextBox.Text,       // FirstName
         LastNameTextBox.Text,       // LastName
         MiddleNameTextBox.Text,       // MiddleName
            number,                // Number (уже проверено)
         NumberCardTextBox.Text,       // NumberCard
         ValidUntilTextBox.Text,       // ValidUntil
         ccvcode                // CCVCod (уже проверено)
     );
            this.Close();
            ChoosingеTransportForm choosingеTransportForm = new ChoosingеTransportForm();
            choosingеTransportForm.Show();
            dbConnection.CloseConnection();
        }

       
    }
}
