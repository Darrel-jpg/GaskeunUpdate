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
    }
}
