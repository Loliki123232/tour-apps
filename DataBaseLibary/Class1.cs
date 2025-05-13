using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;


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
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Кирилл\\source\\repos\\tour-apps\\WinFormsApp1\\Database1.mdf;Integrated Security=True"; // Замените на вашу строку подключения
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
        public DataTable GetAllClients()
        {
            DataTable table = new DataTable();
            try
            {
                dbConnection.OpenConnection();
                string query = "SELECT ClientId, Email, Password FROM LoginClientBD";
                using (SqlCommand cmd = new SqlCommand(query, dbConnection.Connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }

                // Переименовываем столбцы для удобства отображения
                if (table.Columns.Contains("ClientId"))
                    table.Columns["ClientId"].ColumnName = "ID";
                if (table.Columns.Contains("Email"))
                    table.Columns["Email"].ColumnName = "Email";
                if (table.Columns.Contains("Password"))
                    table.Columns["Password"].ColumnName = "Password";
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return table;
        }
        public DataTable GetAllHotels()
        {
            DataTable table = new DataTable();
            try
            {
                dbConnection.OpenConnection();
                string query = "SELECT Id, Stars, TotalPrice, Meals, Amenities, Excursions FROM HotelBookings";
                using (SqlCommand cmd = new SqlCommand(query, dbConnection.Connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return table;
        }
        public bool UpdateClient(int id, string email, string password)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "UPDATE LoginClientBD SET Email = @Email, Password = @Password WHERE ClientId = @Id";
                using (SqlCommand cmd = new SqlCommand(query, dbConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
               
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        public bool UpdateHotel(int id, int stars, decimal price, string meals, string amenities, string excursions)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = @"UPDATE HotelBookings SET 
                           Stars = @Stars, 
                           TotalPrice = @Price, 
                           Meals = @Meals, 
                           Amenities = @Amenities, 
                           Excursions = @Excursions 
                           WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, dbConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@Stars", stars);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Meals", meals);
                    cmd.Parameters.AddWithValue("@Amenities", amenities);
                    cmd.Parameters.AddWithValue("@Excursions", excursions);
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
               
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        public bool DeleteClient(int id)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "DELETE FROM LoginClientBD WHERE ClientId = @Id";
                using (SqlCommand cmd = new SqlCommand(query, dbConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        public bool DeleteHotel(int id)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "DELETE FROM HotelBookings WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, dbConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
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
        public void SaveSelectedValueAirPlaneFlightsToDatabase(string fromCity, string toCity, decimal price, DateTime departureTime)
        {
            try
            {
                if (dbConnection.Connection.State != ConnectionState.Open)
                    dbConnection.Connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO AirPlaneFlights(FromCity, ToCity, Price, DepartureTime) " +
                    "VALUES (@FromCity, @ToCity, @Price, @DepartureTime)",
                    dbConnection.Connection))
                {
                    command.Parameters.Add("@FromCity", SqlDbType.NVarChar).Value = fromCity ?? (object)DBNull.Value;
                    command.Parameters.Add("@ToCity", SqlDbType.NVarChar).Value = toCity ?? (object)DBNull.Value;
                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;
                    command.Parameters.Add("@DepartureTime", SqlDbType.DateTime2).Value = departureTime;

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (dbConnection.Connection.State == ConnectionState.Open)
                    dbConnection.Connection.Close();
            }
        }
        public string GetClientInfo(int clientId)
        {
            try
            {
                if (dbConnection.Connection.State != ConnectionState.Open)
                    dbConnection.Connection.Open();

                string query = "SELECT FirstName, LastName, MiddleName, Number FROM Clients WHERE IdClient = @ClientId";
                using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
                {
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return $"{reader["LastName"]} {reader["FirstName"]} {reader["MiddleName"]}, тел.: {reader["Number"]}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении данных клиента: {ex.Message}");
            }
            finally
            {
                if (dbConnection.Connection.State == ConnectionState.Open)
                    dbConnection.Connection.Close();
            }
            return "Информация о клиенте не найдена";
        }
        public void SaveSelectedValueShipFlightsToDatabase(string fromCity, string toCity, decimal price, DateTime departureTime)
        {
            try
            {
                if (dbConnection.Connection.State != ConnectionState.Open)
                    dbConnection.Connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO ShipFlights(FromCity, ToCity, Price, DepartureTime) " +
                    "VALUES (@FromCity, @ToCity, @Price, @DepartureTime)",
                    dbConnection.Connection))
                {
                    command.Parameters.Add("@FromCity", SqlDbType.NVarChar).Value = fromCity ?? (object)DBNull.Value;
                    command.Parameters.Add("@ToCity", SqlDbType.NVarChar).Value = toCity ?? (object)DBNull.Value;
                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;
                    command.Parameters.Add("@DepartureTime", SqlDbType.DateTime2).Value = departureTime;

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (dbConnection.Connection.State == ConnectionState.Open)
                    dbConnection.Connection.Close();
            }
        }
        public void SaveSelectedValueBusFlightsToDatabase(string fromCity, string toCity, decimal price, DateTime departureTime)
        {
            try
            {
                if (dbConnection.Connection.State != ConnectionState.Open)
                    dbConnection.Connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO BusFlights(FromCity, ToCity, Price, DepartureTime) " +
                    "VALUES (@FromCity, @ToCity, @Price, @DepartureTime)",
                    dbConnection.Connection))
                {
                    command.Parameters.Add("@FromCity", SqlDbType.NVarChar).Value = fromCity ?? (object)DBNull.Value;
                    command.Parameters.Add("@ToCity", SqlDbType.NVarChar).Value = toCity ?? (object)DBNull.Value;
                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;
                    command.Parameters.Add("@DepartureTime", SqlDbType.DateTime2).Value = departureTime;

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (dbConnection.Connection.State == ConnectionState.Open)
                    dbConnection.Connection.Close();
            }
        }
        public void SaveSelectedValueTrainFlightsToDatabase(string fromCity, string toCity, decimal price, DateTime departureTime)
        {
            try
            {
                if (dbConnection.Connection.State != ConnectionState.Open)
                    dbConnection.Connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO TrainFlights(FromCity, ToCity, Price, DepartureTime) " +
                    "VALUES (@FromCity, @ToCity, @Price, @DepartureTime)",
                    dbConnection.Connection))
                {
                    command.Parameters.Add("@FromCity", SqlDbType.NVarChar).Value = fromCity ?? (object)DBNull.Value;
                    command.Parameters.Add("@ToCity", SqlDbType.NVarChar).Value = toCity ?? (object)DBNull.Value;
                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;
                    command.Parameters.Add("@DepartureTime", SqlDbType.DateTime2).Value = departureTime;

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (dbConnection.Connection.State == ConnectionState.Open)
                    dbConnection.Connection.Close();
            }
        }
        public void SaveBooking(HotelBooking booking)
        {
            try
            {
                if (dbConnection.Connection.State != ConnectionState.Open)
                    dbConnection.Connection.Open();

                using (SqlCommand command = new SqlCommand(@"INSERT INTO HotelBookings 
                        (Stars, TotalPrice, Meals, Amenities, Excursions) 
                        VALUES 
                        (@Stars, @TotalPrice, @Meals, @Amenities, @Excursions)", dbConnection.Connection))
                {
                    command.Parameters.AddWithValue("@Stars", booking.Stars);
                    command.Parameters.AddWithValue("@TotalPrice", booking.PricePerNight);
                    command.Parameters.AddWithValue("@Meals", booking.Meals.Count > 0 ? string.Join(", ", booking.Meals) : "Нет");
                    command.Parameters.AddWithValue("@Amenities", booking.Amenities.Count > 0 ? string.Join(", ", booking.Amenities) : "Нет");
                    command.Parameters.AddWithValue("@Excursions", booking.Excursions.Count > 0 ? string.Join(", ", booking.Excursions) : "Нет");

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                if (dbConnection.Connection.State == ConnectionState.Open)
                    dbConnection.Connection.Close();
            }
        }
        
        public int GetCurrentClientId()
        {
            try
            {
                if (dbConnection.Connection.State != ConnectionState.Open)
                    dbConnection.Connection.Open();

                string query = "SELECT TOP 1 IdClient FROM Clients ORDER BY IdClient DESC";
                using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
                {
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении ID клиента: {ex.Message}");
                return -1;
            }
            finally
            {
                if (dbConnection.Connection.State == ConnectionState.Open)
                    dbConnection.Connection.Close();
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
            string query = "SELECT COUNT(*) FROM LoginAdminsBD WHERE Email = @Email AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
    public class HotelBooking
    {
        public int Stars { get; set; }
        public decimal PricePerNight { get; set; }
        public List<string> Meals { get; set; } = new List<string>();
        public List<string> Excursions { get; set; } = new List<string>();
        public List<string> Amenities { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Отель {Stars}*\n" +
                   $"Итоговая цена за ночь: {PricePerNight} руб.\n" +
                   $"Питание: {(Meals.Count > 0 ? string.Join(", ", Meals) : "Нет")}\n" +
                   $"Удобства: {(Amenities.Count > 0 ? string.Join(", ", Amenities) : "Нет")}\n" +
                   $"Экскурсии: {(Excursions.Count > 0 ? string.Join(", ", Excursions) : "Нет")}";
        }
    }

    public interface IHotelBookingBuilder
    {
        IHotelBookingBuilder SetStars(int stars);
        IHotelBookingBuilder SetPrice(decimal price);
        IHotelBookingBuilder AddMeal(string meal);
        IHotelBookingBuilder AddExcursion(string excursion);
        IHotelBookingBuilder AddAmenity(string amenity);
        HotelBooking Build();
    }

    public class HotelBookingBuilder : IHotelBookingBuilder
    {
        private HotelBooking _booking = new HotelBooking();

        public IHotelBookingBuilder SetStars(int stars)
        {
            _booking.Stars = stars < 3 ? 3 : (stars > 5 ? 5 : stars);
            return this;
        }

        public IHotelBookingBuilder SetPrice(decimal price)
        {
            _booking.PricePerNight = price;
            return this;
        }

        public IHotelBookingBuilder AddMeal(string meal)
        {
            if (!string.IsNullOrEmpty(meal))
                _booking.Meals.Add(meal);
            return this;
        }

        public IHotelBookingBuilder AddExcursion(string excursion)
        {
            if (!string.IsNullOrEmpty(excursion))
                _booking.Excursions.Add(excursion);
            return this;
        }

        public IHotelBookingBuilder AddAmenity(string amenity)
        {
            if (!string.IsNullOrEmpty(amenity))
                _booking.Amenities.Add(amenity);
            return this;
        }

        public HotelBooking Build() => _booking;
    }
}