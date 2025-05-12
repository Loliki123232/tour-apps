using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ChoisHotelForm : Form
    {
        private IHotelBookingBuilder _builder = new HotelBookingBuilder();
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        BdManager bdManager = new BdManager();

        // Базовые цены за ночь для разных звёзд
        private Dictionary<int, decimal> _starPrices = new Dictionary<int, decimal>
        {
            {3, 3000},
            {4, 5000},
            {5, 8000}
        };

        // Цены за доп. услуги
        private Dictionary<string, decimal> _mealPrices = new Dictionary<string, decimal>
        {
            {"Завтрак", 500},
            {"Обед", 800},
            {"Ужин", 1000}
        };

        private Dictionary<string, decimal> _amenityPrices = new Dictionary<string, decimal>
        {
            {"Бассейн", 700},
            {"Массаж", 1500},
            {"SPA", 2000},
            {"Тренажерный зал", 500}
        };

        private Dictionary<string, decimal> _excursionPrices = new Dictionary<string, decimal>
        {
            {"Обзорная", 1200},
            {"Гастрономическая", 2500},
            {"Историческая", 1800}
        };
        string _transportType;
        string _fromCity;
        string _toCity;
        decimal _transportPrice;
        DateTime _departureTime;
        public ChoisHotelForm(string transportType, string fromCity, string toCity, decimal price, DateTime departureTime)
        {
            InitializeComponent();
            _transportType = transportType;
            _fromCity = fromCity;
            _toCity = toCity;
            _transportPrice = price;
            _departureTime = departureTime;
            dbConnection.OpenConnection();
            // Инициализация ComboBox для звёзд
            starComboBox.Items.AddRange(new object[] { 3, 4, 5 });
            starComboBox.SelectedIndex = 0;

            // Заполнение CheckedListBox'ов
            mealsCheckedListBox.Items.AddRange(new string[] { "Завтрак", "Обед", "Ужин" });
            amenitiesCheckedListBox.Items.AddRange(new string[] { "Бассейн", "Массаж", "SPA", "Тренажерный зал" });
            excursionsCheckedListBox.Items.AddRange(new string[] { "Обзорная", "Гастрономическая", "Историческая" });

            UpdatePrice();
        }

        private void starComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            int stars = (int)starComboBox.SelectedItem;
            priceLabel.Text = $"{_starPrices[stars]} руб./ночь";
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            // Очищаем предыдущие выборы
            _builder = new HotelBookingBuilder();

            // Устанавливаем звёзды и базовую цену
            int stars = (int)starComboBox.SelectedItem;
            decimal totalPrice = _starPrices[stars];

            // Добавляем выбранное питание и считаем стоимость
            foreach (var item in mealsCheckedListBox.CheckedItems)
            {
                string meal = item.ToString();
                _builder.AddMeal(meal);
                totalPrice += _mealPrices[meal];
            }

            // Добавляем удобства и считаем стоимость
            foreach (var item in amenitiesCheckedListBox.CheckedItems)
            {
                string amenity = item.ToString();
                _builder.AddAmenity(amenity);
                totalPrice += _amenityPrices[amenity];
            }

            // Добавляем экскурсии и считаем стоимость
            foreach (var item in excursionsCheckedListBox.CheckedItems)
            {
                string excursion = item.ToString();
                _builder.AddExcursion(excursion);
                totalPrice += _excursionPrices[excursion];
            }

            // Устанавливаем итоговую цену
            _builder.SetStars(stars).SetPrice(totalPrice);

            // Выводим результат
            resultTextBox.Text = _builder.Build().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            dbConnection.CloseConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_builder == null)
            {
                MessageBox.Show("Сначала создайте бронирование!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Сохраняем бронирование отеля в БД
                bdManager.SaveBooking(_builder.Build());

                // Сохраняем всю информацию в файл
                SaveToFile();

                MessageBox.Show("Бронирование сохранено!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveToFile()
        {
            string fileName = $"Booking_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("=== ПОЛНАЯ ИНФОРМАЦИЯ О БРОНИРОВАНИИ ===");

                // Данные клиента
                writer.WriteLine("\n--- ДАННЫЕ КЛИЕНТА ---");
                writer.WriteLine(GetClientInfo());

                // Данные транспорта
                writer.WriteLine("\n--- ТРАНСПОРТ ---");
                writer.WriteLine($"Тип: {_transportType}");
                writer.WriteLine($"Маршрут: {_fromCity} → {_toCity}");
                writer.WriteLine($"Цена: {_transportPrice} руб.");
                writer.WriteLine($"Дата: {_departureTime:dd.MM.yyyy}");

                // Данные отеля
                writer.WriteLine("\n--- ОТЕЛЬ ---");
                writer.WriteLine(_builder.Build().ToString());
            }
        }
        private string GetClientInfo()
        {
            try
            {
                // Получаем ID последнего клиента
                int clientId = bdManager.GetCurrentClientId();

                if (clientId <= 0)
                {
                    return "Информация о клиенте не найдена";
                }

                // Используем существующий метод из BdManager
                return bdManager.GetClientInfo(clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении данных клиента: {ex.Message}");
                return "Ошибка при получении данных клиента";
            }
        }
    }
}