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
        private bool transaksiCollapse;

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
        private void TransaksiTimer_Tick(object sender, EventArgs e)
        {
            if (transaksiCollapse)
            {
                TransaksiContainer.Height += 10;
                if (TransaksiContainer.Height == TransaksiContainer.MaximumSize.Height)
                {
                    transaksiCollapse = false;
                    TransaksiTimer.Stop();
                }
            }
            else
            {
                TransaksiContainer.Height -= 10;
                if (TransaksiContainer.Height == TransaksiContainer.MinimumSize.Height)
                {
                    transaksiCollapse = true;
                    TransaksiTimer.Stop();
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
            usersData1.Visible = false;
            transaksiPelanggan1.Visible = false;
            //transaksi1.Visible = false;
        }
        private void btnMotor_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            vehicleData1.Visible = true;
            mobilData1.Visible = false;
            usersData1.Visible = false;
            transaksiPelanggan1.Visible = false;
            //transaksi1.Visible = false;
        }
        private void btnMobil_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            vehicleData1.Visible = false;
            mobilData1.Visible = true;
            usersData1.Visible = false;
            transaksiPelanggan1.Visible = false;
            //transaksi1.Visible = false;
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            vehicleData1.Visible = false;
            mobilData1.Visible = false;
            usersData1.Visible = true;
            transaksiPelanggan1.Visible = false;
            //transaksi1.Visible = false;
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            vehicleData1.Visible = false;
            mobilData1.Visible = false;
            usersData1.Visible = false;
            transaksiPelanggan1.Visible = true;
            //transaksi1.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            //dashboard1.Visible = false;
            //vehicleData3.Visible = false;
            //mobilData3.Visible = false;
            //usersData3.Visible = false;
            //transaksiPelanggan2.Visible = true;
            //transaksi1.Visible = false;
        }
    }
}
