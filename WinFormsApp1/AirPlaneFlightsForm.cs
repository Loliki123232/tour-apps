using CommonLibrary;
using URLQueryLibary;
namespace WinFormsApp1
{

    public partial class AirPlaneFlightsForm : Form
    {
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        BdManager bdManager = new BdManager();
        private List<DateTime> allowedDates = new List<DateTime>();
        private Random random = new Random();
        string city1;
        string city2;
        int price;

        public AirPlaneFlightsForm()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            GenerateRandomAllowedDates(10); // Генерируем 10 случайных дат
            dbConnection.OpenConnection();
        }
        private void GenerateRandomAllowedDates(int count)
        {
            for (int i = 0; i < count; i++)
            {
                allowedDates.Add(DateTime.Today.AddDays(random.Next(1, 365))); 
            }
            allowedDates = allowedDates.Distinct().OrderBy(d => d).ToList(); 
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date; 

            if (!allowedDates.Contains(selectedDate))
            {
                
                DateTime nearestDate = allowedDates
                    .OrderBy(d => Math.Abs((d - selectedDate).Ticks))
                    .First();

                MessageBox.Show($"Вы можете выбрать только определённые даты. Ближайшая доступная: {nearestDate:d}");
                dateTimePicker1.Value = nearestDate;
            }
        }

        private void City1textBox1_TextChanged(object sender, EventArgs e)
        {
            city1 = City1textBox.Text;
        }

        private void City1textBox2_TextChanged(object sender, EventArgs e)
        {
            city2 = City2textBox.Text;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            ChoosingеTransportForm choosingеTransportForm = new ChoosingеTransportForm();
            choosingеTransportForm.Show();
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(city1) || string.IsNullOrEmpty(city2))
            {
                label1.Text = "Введите оба города";
                return;
            }

            try
            {
                urlQiery urlQuery = new urlQiery(city1, city2);
                double distance = await urlQuery.GetDistanceAsync();
                if (distance <= 2000)
                {
                    price = Convert.ToInt32(distance * 6);
                }
                else
                   price = Convert.ToInt32(distance * 4.5);
                label1.Text = $"{price}";
            }
            catch (Exception ex)
            {
                label1.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(City1textBox.Text) || string.IsNullOrEmpty(City2textBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите В какой город вам нужно и куда.");
                return;
            }
            bdManager.SaveSelectedValueAirPlaneFlightsToDatabase
                (
                City1textBox.Text,
                City2textBox.Text,
                price,
                dateTimePicker1.Value
                );
            this.Close();
            ChoisHotelForm hotelForm = new ChoisHotelForm(
         "Plane",       // Тип транспорта
         city1,    // Город отправления
         city2,      // Город назначения
         price,       // Стоимость
         dateTimePicker1.Value // Дата отправления
     );
            hotelForm.Show();
            dbConnection.CloseConnection();
        }
    }
}
