using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Helper
{
    public static class PelangganHelper
    {
        public static string ConvertStatus(int status)
        {
            switch (status)
            {
                case 0: return "Nonaktif";
                case 1: return "Aktif";
                default: return "Tidak Diketahui";
            }
        }
        public static int ConvertStatus(string status)
        {
            switch (status.ToLower())
            {
                case "nonaktif": return 0;
                case "aktif": return 1;
                default: return -1; // Tidak Diketahui
            }
        }
    }
}
