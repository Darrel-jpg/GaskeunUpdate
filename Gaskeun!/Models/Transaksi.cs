using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gaskeun_.Models
{
    public class Transaksi
    {
        public int IdTransaksi { get; set; }
        public string Username { get; set; }
        //public int IdJenisKendaraan { get; set; }
        public string JenisKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public DateOnly TanggalSewa { get; set; }
        public DateOnly TanggalKembali { get; set; }
        public DateOnly TanggalKeterlambatan { get; set; }
        //public int IdJaminan { get; set; }
        public string Jaminan { get; set; }
        public int Durasi { get; set; }
        //public int IdPaketSewa { get; set; }
        public string PaketSewa { get; set; }
        public decimal Denda { get; set; }
        public string MetodePembayaran { get; set; }
        public decimal Harga { get; set; }
        public int Berjalan { get; set; } // 0 = selesai, 1 = berjalan
        public string StatusText => Berjalan == 1 ? "Berjalan" : "Selesai";
    }
}