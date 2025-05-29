using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Helper
{
    public static class KendaraanHelper
    {
        public static int ConvertJenisKendaraan(string jenis)
        {
            switch (jenis.ToLower())
            {
                case "motor": return 1;
                case "mobil": return 2;
                default: return 0;
            }
        }

        public static string ConvertJenisKendaraan(int idJenis)
        {
            switch (idJenis)
            {
                case 1: return "Motor";
                case 2: return "Mobil";
                default: return "Tidak Diketahui";
            }
        }

        public static string ConvertStatus(int status)
        {
            switch (status)
            {
                case 0: return "Tersedia";
                case 1: return "Disewa";
                default: return "Tidak Diketahui";
            }
        }
        public static int ConvertStatus(string status)
        {
            switch (status.ToLower())
            {
                case "disewa": return 0;
                case "tersedia": return 1;
                default: return -1; // Tidak Diketahui
            }
        }
    }

}
