using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class RiwayatContext : Connection
    {
        public List<Transaksi> listRiwayat = new List<Transaksi>();
        public List<Transaksi> Read()
        {
            using (var conn = GetConnection())
            {
                string query = @"SELECT a.username, j.jenis_kendaraan, k.nama_kendaraan, t.tanggal_sewa, t.tanggal_pengembalian, t.tanggal_keterlambatan, ja.nama_jaminan, p.nama_paket, t.durasi, t.denda, t.total_harga
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
                    listRiwayat.Clear();
                    while (reader.Read())
                    {
                        Transaksi dataRiwayat = new Transaksi();
                        dataRiwayat.Username = (string)reader["username"];
                        dataRiwayat.JenisKendaraan = (string)reader["jenis_kendaraan"];
                        dataRiwayat.NamaKendaraan = (string)reader["nama_kendaraan"];
                        dataRiwayat.TanggalSewa = DateOnly.FromDateTime((DateTime)reader["tanggal_sewa"]);
                        dataRiwayat.TanggalKembali = DateOnly.FromDateTime((DateTime)reader["tanggal_pengembalian"]);
                        dataRiwayat.TanggalKeterlambatan = reader["tanggal_keterlambatan"] != DBNull.Value ? DateOnly.FromDateTime((DateTime)reader["tanggal_keterlambatan"]) : DateOnly.MinValue;
                        dataRiwayat.Jaminan = (string)reader["nama_jaminan"];
                        dataRiwayat.PaketSewa = (string)reader["nama_paket"];
                        dataRiwayat.Durasi = (int)reader["durasi"];
                        dataRiwayat.Denda = (decimal)reader["denda"];
                        dataRiwayat.Harga = (decimal)reader["total_harga"];
                        listRiwayat.Add(dataRiwayat);
                    }
                }
            }
            return listRiwayat;
        }
    }
}
