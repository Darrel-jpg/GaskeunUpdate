using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaskeun_.Helper;

namespace Gaskeun_.Models
{
    public class Kendaraan
    {
        public string Plat { get; set; }
        public int IdJenisKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public string Merk { get; set; }
        public string Tahun { get; set; }
        public string CC { get; set; }
        public string KapasitasBensin { get; set; }
        public string Gambar { get; set; }
        public decimal HargaHari { get; set; }
        public decimal HargaMinggu { get; set; }
        public decimal HargaBulan { get; set; }
        public int Status { get; set; }
        public string StatusText => Status == 1 ? "Tersedia" : "Disewa";
    }
}