using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace WinFormsApp1
{

    public partial class AirPlaneFlightsForm : Form
    {
        DatabaseConnection dbConnection = DatabaseConnection.Instance;

        private List<AirPlaneFlight> flights;
        public AirPlaneFlightsForm()
        {
            InitializeComponent();
            dbConnection.OpenConnection();
            LoadAirPlaneFlights();
            comboBoxFlights.DataSource = flights;

        }
        private void LoadAirPlaneFlights()
        {
            flights = new List<AirPlaneFlight>();
            using (SqlCommand command = new SqlCommand("SELECT FromCity, ToCity, Price, DepartureTime FROM AirPlaneFlights", dbConnection.Connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AirPlaneFlight flight = new AirPlaneFlight
                        {
                            FromCity = reader["FromCity"].ToString(),
                            ToCity = reader["ToCity"].ToString(),
                            Price = (decimal)reader["Price"],
                            DepartureTime = (DateTime)reader["DepartureTime"]
                        };
                        flights.Add(flight);

                    }
                }
            }
        }
        private void AirPlaneFlightsComboBox(object sender, EventArgs e)
        {
            UpdatePriceLabel(); 
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceLabel(); 
        }

        private void UpdatePriceLabel()
        {
            AirPlaneFlight selectedFlight = (AirPlaneFlight)comboBoxFlights.SelectedItem;
            decimal finalPrice = selectedFlight.Price;

            if (checkBox1.Checked) 
            {
                finalPrice *= 2; 
            }

            labelPrice.Text = $"Цена: {finalPrice} руб."; 
            labelDate.Text = $"Дата и время: {selectedFlight.DepartureTime} "; 
        }
    }
    public class AirPlaneFlight
    {
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public decimal Price { get; set; }
        public DateTime DepartureTime { get; set; }

        public override string ToString()
        {
            return $"{FromCity} - {ToCity} ({Price} руб.)";
        }
    }
}
