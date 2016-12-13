using System;
using System.Windows.Forms;

namespace Demo5_DIP
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }
        ISportCar theCar;
        private void cboPickUpCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var factory = new CarFactory();
            theCar = factory.CreateCar(cboPickUpCar.Text);
            // Event common to all cars
            theCar.LegalLimitCondition += TheCar_LegalLimitCondition;
            // Event specific to cars of type SportsCarWithN
            if (theCar is SportsCarWithN) {
                ((SportsCarWithN)theCar).SpeedLimit += TheCar_SpeedLimit;
            }
            // refresh car's properties
            txtMaxSpeed.Text = theCar.MaxSpeed.ToString();
            pbPhoto.Image = theCar.Photo;
            updateUI();
        }
        public void TheCar_LegalLimitCondition(object sender, int e)
        {
            updateUI(e);
        }
        public void TheCar_SpeedLimit(object sender, EventArgs e)
        {
            var eventData = e as SpeedLimitData;
            MessageBox.Show("Attempt to obtain " + eventData.resultingSpeed +
                " Miles//hr at: " + eventData.moment.ToLongTimeString(), "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            theCar.Accelerate();
            updateUI();
        }
        private void updateUI(int speedExcess = 0)
        {
            txtSpeed.Text = theCar.Speed.ToString();
            if (speedExcess > 0)
            {
                MessageBox.Show("Legal limit exceeded by " + speedExcess + " mi/h");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
