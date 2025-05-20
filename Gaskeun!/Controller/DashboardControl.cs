using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class DashboardControl
    {
        DashboardContext dataDashboard = new DashboardContext();
        public int GetJumlahMobil()
        {
            return dataDashboard.GetJumlahMobil();
        }
        public int GetJumlahMotor()
        {
            return dataDashboard.GetJumlahMotor();
        }
        public int GetJumlahPelanggan()
        {
            return dataDashboard.GetJumlahPelanggan();
        }
        public decimal GetTotalPenghasilan()
        {
            return dataDashboard.GetTotalPenghasilan();
        }
        public List<Dashboard> ReadPelangganHariIni()
        {
            dataDashboard.PelangganHariIni();
            return dataDashboard.listDataDashboard;
        }
    }
}
