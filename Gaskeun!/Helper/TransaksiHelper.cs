using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Helper
{
    public static class TransaksiHelper
    {
        public static string ConvertPaketSewa(int idPaket)
        {
            switch (idPaket)
            {
                case 1: return "Hari";
                case 2: return "Minggu";
                case 3: return "Bulan";
                default: return "Tidak Diketahui";
            }
        }
        public static int ConvertPaketSewa(string paket)
        {
            switch (paket.ToLower())
            {
                case "hari": return 1;
                case "minggu": return 2;
                case "bulan": return 3;
                default: return -1; // Tidak Diketahui
            }
        }
        public static string ConvertStatusTransaksi(int status)
        {
            switch (status)
            {
                case 1: return "Berjalan"; // Berjalan
                case 0: return "Selesai"; // Selesai
                default: return "Tidak Diketahui"; // Tidak Diketahui
            }
        }
        public static int ConvertStatusTransaksi(string status)
        {
            switch (status.ToLower())
            {
                case "berjalan": return 1; // Berjalan
                case "selesai": return 0; // Selesai
                default: return -1; // Tidak Diketahui
            }
        }
    }
}
