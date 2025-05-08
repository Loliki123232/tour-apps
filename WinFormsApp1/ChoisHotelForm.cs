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

        public ChoisHotelForm()
        {
            InitializeComponent();
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

            var booking = _builder.Build();

            try
            {
                bdManager.SaveBooking(booking);
                MessageBox.Show("Бронирование сохранено в базе данных!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}