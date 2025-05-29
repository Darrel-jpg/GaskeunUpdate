using Gaskeun_.Controller;
using Npgsql;
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
    public partial class Dashboard : UserControl
    {
        DashboardControl dashboardControl = new DashboardControl();
        public Dashboard()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dashboardControl.ReadPelangganHariIni();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbJmlMobil.Text = dashboardControl.GetJumlahKendaraan(2).ToString();
            lbJmlMotor.Text = dashboardControl.GetJumlahKendaraan(1).ToString();
            lbJmlUser.Text = dashboardControl.GetJumlahPelanggan().ToString();
            lbIncome.Text = dashboardControl.GetTotalPenghasilan().ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID"));
        }

    }
}
