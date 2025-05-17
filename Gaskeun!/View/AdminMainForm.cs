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
    public partial class AdminMainForm : Form
    {
        private bool vehicleCollapse;

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VehicleTimer_Tick(object sender, EventArgs e)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            vehicleData1.Visible = false;
            mobilData1.Visible = false;
        }
        private void btnMotor_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            vehicleData1.Visible = true;
            mobilData1.Visible = false;
        }

        private void btnMobil_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            vehicleData1.Visible = false;
            mobilData1.Visible = true;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
