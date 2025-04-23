using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
namespace CommonLibrary
{


    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();
        private SqlConnection _connection;

        // Убедитесь, что конструктор недоступен для внешних классов
        private DatabaseConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\ConsoleApp2\\ConsoleApp2\\Database1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"; // Замените на вашу строку подключения
            _connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                    return _instance;
                }
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return _connection;
            }
        }

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
    public class BdManager
    {
        DatabaseConnection dbConnection = DatabaseConnection.Instance;

        public void SaveSelectedValueClientToDatabase(string email, string password)
        {
            email = email.Trim();
            password = password.Trim();

            using (SqlCommand command = new SqlCommand("INSERT INTO LoginClientBD(Email, Password) VALUES (@Email, @Password)", dbConnection.Connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.ExecuteNonQuery();
            }
        }
        public void SaveSelectedValueAdminToDatabase(string email, string password)
        {
            email = email.Trim();
            password = password.Trim();
            using (SqlCommand command = new SqlCommand("INSERT INTO LoginAdminBD(Email, Password) VALUES (@Email, @Password)", dbConnection.Connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.ExecuteNonQuery();
            }
        }
        public void SaveSelectedValueClientToDatabase(string firstname, string lastname, string middlename, int numberphone, string numbercard, string validuntil, int ccvcod)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Clients(FirstName, LastName,MiddleName,Number,NumberCard,ValidUntil,CCVCod) VALUES (@FirstName, @LastName,@MiddleName,@Number,@NumberCard,@ValidUntil,@CCVCod)", dbConnection.Connection))
            {
                command.Parameters.AddWithValue("@FirstName", firstname);
                command.Parameters.AddWithValue("@LastName", lastname);
                command.Parameters.AddWithValue("@MiddleName", middlename);
                command.Parameters.AddWithValue("@Number", numberphone);
                command.Parameters.AddWithValue("@NumberCard", numbercard);
                command.Parameters.AddWithValue("@ValidUntil", validuntil);
                command.Parameters.AddWithValue("@CCVCod", ccvcod);
                command.ExecuteNonQuery();
            }
        }
    }
    public class Authenticator
    {
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        public bool AreCredentialsValidClient(string email, string password)
        {
            email = email.Trim();
            password = password.Trim();
            string query = "SELECT COUNT(*) FROM LoginClientBD WHERE Email = @Email AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public bool AreCredentialsValidAdmin(string email, string password)
        {
            email = email.Trim();
            password = password.Trim();
            string query = "SELECT COUNT(*) FROM LoginAdminBD WHERE Email = @Email AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}