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
        }

        private void AirPlaneButton_Click(object sender, EventArgs e)
        {
            AirPlaneFlightsForm airPlaneFlightsForm = new AirPlaneFlightsForm();
            airPlaneFlightsForm.ShowDialog();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            TrainFlightsForm trainFlightsForm = new TrainFlightsForm();
            trainFlightsForm.ShowDialog();
        }

        private void BusButton_Click(object sender, EventArgs e)
        {
            BusFlightsForm busFlightsForm = new BusFlightsForm();
            busFlightsForm.ShowDialog();
        }

        private void ShipButton_Click(object sender, EventArgs e)
        {
            ShipFlightsForm shipFlightsForm = new ShipFlightsForm();
            shipFlightsForm.ShowDialog();
        }
    }
}
