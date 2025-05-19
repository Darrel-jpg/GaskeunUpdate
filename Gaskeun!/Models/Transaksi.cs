using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class Transaksi
    {
        public int IdTransaksi { get; set; }
        public string Username { get; set; }
        public string Motor { get; set; }
        public string Mobil { get; set; }
        public DateTime TanggalSewa { get; set; }
        public DateTime TanggalKembali { get; set; }
        public string Jaminan { get; set; }
        public string PaketSewa { get; set; }
        public int Durasi { get; set; }
        public decimal Harga { get; set; }
    }
}
