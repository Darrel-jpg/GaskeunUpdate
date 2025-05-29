using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class TransaksiContext : Connection
    {
        public List<Transaksi> listTransaksi = new List<Transaksi>();
        public List<Transaksi> Read()
        {
            using (var conn = GetConnection())
            {
                string query = @"SELECT a.username, j.jenis_kendaraan, k.nama_kendaraan, t.tanggal_sewa, t.tanggal_pengembalian, ja.nama_jaminan, p.nama_paket, t.durasi, t.total_harga
                                FROM transaksi t 
                                JOIN akun a ON t.id_pelanggan = a.id_akun 
                                JOIN kendaraan k ON t.id_kendaraan = k.id_kendaraan
                                JOIN jenis_kendaraan j ON k.id_jenis_kendaraan = j.id_jenis
                                JOIN jaminan ja ON t.id_jaminan = ja.id_jaminan
                                JOIN paket_sewa p ON t.id_paket_sewa = p.id_paket;";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    listTransaksi.Clear();
                    while (reader.Read())
                    {
                        Transaksi dataTransaksi = new Transaksi();
                        dataTransaksi.Username = (string)reader["username"];
                        dataTransaksi.JenisKendaraan = (string)reader["jenis_kendaraan"];
                        dataTransaksi.NamaKendaraan = (string)reader["nama_kendaraan"];
                        dataTransaksi.TanggalSewa = (DateTime)reader["tanggal_sewa"];
                        dataTransaksi.TanggalKembali = (DateTime)reader["tanggal_pengembalian"];
                        dataTransaksi.Jaminan = (string)reader["nama_jaminan"];
                        dataTransaksi.PaketSewa = (string)reader["nama_paket"];
                        dataTransaksi.Durasi = (int)reader["durasi"];
                        dataTransaksi.Harga = (decimal)reader["total_harga"];
                        listTransaksi.Add(dataTransaksi);
                    }
                }
            }
            return listTransaksi;
        }
    }
}
