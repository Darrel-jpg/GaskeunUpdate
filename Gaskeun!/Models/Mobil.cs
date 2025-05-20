using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class Mobil
    {
        public string Plat { get; set; }
        public string NamaMobil { get; set; }
        public string Merk { get; set; }
        public string Tahun { get; set; }
        public string Warna { get; set; }
        public string Gambar { get; set; }
        public decimal HargaPerHari { get; set; }
        public decimal HargaPerMinggu { get; set; }
        public decimal HargaPerBulan { get; set; }
        public string Status { get; set; }
    }
}
