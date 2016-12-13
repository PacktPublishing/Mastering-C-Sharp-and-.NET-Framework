using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1_SRP
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
            // refresh car's properties
            txtMaxSpeed.Text = theCar.MaxSpeed.ToString();
            pbPhoto.Image = theCar.Photo;
            updateUI();
        }
        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            theCar.Accelerate();
            updateUI();
        }
        private void updateUI()
        {
            txtSpeed.Text = theCar.Speed.ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
