using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

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
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Кирилл\\Source\\Repos\\tour-apps\\WinFormsApp1\\Database1.mdf;Integrated Security=True"; // Замените на вашу строку подключения
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