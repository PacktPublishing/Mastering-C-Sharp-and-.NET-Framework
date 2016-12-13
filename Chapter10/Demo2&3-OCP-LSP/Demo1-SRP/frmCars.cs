using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2_OCP
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }
        SportsCar theCar;
        private void cboPickUpCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            theCar = new SportsCar(cboPickUpCar.Text);
            theCar.SpeedLimit += TheCar_SpeedLimit;
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
            if (theCar.Brand == "Mercedes")
            {
                theCar.Accelerate(true);
            }
            else { theCar.Accelerate(); }
            updateUI();
        }
        private void updateUI(int speedExcess = 0)
        {
            txtSpeed.Text = theCar.Speed.ToString();
            if (speedExcess > 0)
            {
                MessageBox.Show( "Legal limit exceeded by " + speedExcess + " mi/h");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
