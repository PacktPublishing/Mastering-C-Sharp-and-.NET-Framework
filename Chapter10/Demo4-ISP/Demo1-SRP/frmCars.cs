using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo4_ISP
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
            if (cboPickUpCar.Text == "Mercedes")
            {
                theCar = new SportsCarWithN("Mercedes");
             // subscription to SpeedLimit depends on type
               ((SportsCarWithN)theCar).SpeedLimit += TheCar_SpeedLimit;
            }
            else
            {
                theCar = new SportsCar(cboPickUpCar.Text);
            }
            theCar.LegalLimitCondition += TheCar_LegalLimitCondition;
            // refresh car's properties
            txtMaxSpeed.Text = theCar.MaxSpeed.ToString();
            pbPhoto.Image = theCar.Photo;
            updateUI();
        }

        private void TheCar_LegalLimitCondition(object sender, int e)
        {
            updateUI(e);
        }

        private void TheCar_SpeedLimit(object sender, EventArgs e)
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

        private void frmCars_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e holds info about the reason for closing and a cancel property.
        }
    }
}
