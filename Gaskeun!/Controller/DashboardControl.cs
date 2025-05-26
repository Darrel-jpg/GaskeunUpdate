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
        public int GetJumlahKendaraan(string jenis)
        {
            return dataDashboard.GetJumlahKendaraan(jenis);
        }
        public int GetJumlahPelanggan()
        {
            return dataDashboard.GetJumlahPelanggan();
        }
        public decimal GetTotalPenghasilan()
        {
            return dataDashboard.GetTotalPenghasilan();
        }
        public List<Transaksi> ReadPelangganHariIni()
        {
            return dataDashboard.PelangganHariIni();
        }
    }
}
