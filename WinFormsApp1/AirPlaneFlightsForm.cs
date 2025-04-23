using CommonLibrary;
using URLQueryLibary;
namespace WinFormsApp1
{

    public partial class AirPlaneFlightsForm : Form
    {
        DatabaseConnection dbConnection = DatabaseConnection.Instance;
        string city1;
        string city2;
        public AirPlaneFlightsForm()
        {
            InitializeComponent();
            dbConnection.OpenConnection();

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AirPlaneFlightsForm_Load(object sender, EventArgs e)
        {
            UrlQiery urlQiery = new UrlQiery(city1, city2);
            label1.Text = urlQiery.distanceBetweenCities.ToString();
        }

        private void City1textBox1_TextChanged(object sender, EventArgs e)
        {
            city1=City1textBox1.Text;
        }

        private void City1textBox2_TextChanged(object sender, EventArgs e)
        {
            city2 = City1textBox2.Text;
        }
    }

}
