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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbJmlMobil.Text = dashboardControl.GetJumlahMobil().ToString();
            lbJmlMotor.Text = dashboardControl.GetJumlahMotor().ToString();
            lbJmlUser.Text = dashboardControl.GetJumlahPelanggan().ToString();
        }
    }
}
