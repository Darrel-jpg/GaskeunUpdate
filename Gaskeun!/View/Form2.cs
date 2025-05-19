using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaskeun_.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool vehicleCollapse;
        private void bikeTimer_Tick(object sender, EventArgs e)
        {
            if (vehicleCollapse)
            {
                vehicleContainer.Height += 10;
                if (vehicleContainer.Height == vehicleContainer.MaximumSize.Height)
                {
                    vehicleCollapse = false;
                    VehicleTimer.Stop();
                }
            }
            else
            {
                vehicleContainer.Height -= 10;
                if (vehicleContainer.Height == vehicleContainer.MinimumSize.Height)
                {
                    vehicleCollapse = true;
                    VehicleTimer.Stop();
                }
            }
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            VehicleTimer.Start();
        }
    }
}
