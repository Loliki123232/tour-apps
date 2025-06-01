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
    public partial class ChoosingеTransportForm : Form
    {
        public ChoosingеTransportForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientAddForm clientAddForm = new ClientAddForm();
            clientAddForm.Show();
        }

        private void AirPlaneButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AirPlaneFlightsForm airPlaneFlightsForm = new AirPlaneFlightsForm();
            airPlaneFlightsForm.Show();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainFlightsForm trainFlightsForm = new TrainFlightsForm();
            trainFlightsForm.Show();
        }

        private void BusButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BusFlightsForm busFlightsForm = new BusFlightsForm();
            busFlightsForm.Show();
        }

        private void ShipButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ShipFlightsForm shipFlightsForm = new ShipFlightsForm();
            shipFlightsForm.Show();
            
        }
    }
}
