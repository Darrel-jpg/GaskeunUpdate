using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Gaskeun_.Models
{
    public class DashboardContext : Connection
    {
        public List<Transaksi> listDataDashboard = new List<Transaksi>();
        public int GetJumlahKendaraan(int idJenis)
        {
            using (var conn = GetConnection())
            {
                string query = @"SELECT COUNT(*) FROM kendaraan WHERE id_jenis_kendaraan = @id_jenis_kendaraan";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@id_jenis_kendaraan", idJenis));
                    cmd.CommandType = System.Data.CommandType.Text;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
        }
        public int GetJumlahPelanggan()
        {
            using (var conn = GetConnection())
            {
                string query = @"SELECT COUNT(*) FROM akun WHERE id_role = 2";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
        }
        public decimal GetTotalPenghasilan()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"SELECT SUM(total_harga) FROM transaksi";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                    return total;
                }
            }
        }
        public List<Transaksi> PelangganHariIni()
        {
            using (var conn = GetConnection())
            {
                string query = @"SELECT a.username, j.jenis_kendaraan, k.nama_kendaraan, t.durasi, p.nama_paket, t.total_harga
                                FROM transaksi t
                                JOIN akun a ON t.id_pelanggan = a.id_akun
                                JOIN kendaraan k ON t.id_kendaraan = k.id_kendaraan
                                JOIN jenis_kendaraan j ON k.id_jenis_kendaraan = j.id_jenis
								JOIN paket_sewa p ON t.id_paket_sewa = p.id_paket
                                WHERE t.tanggal_sewa = current_date";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    listDataDashboard.Clear();
                    while (reader.Read())
                    {
                        Transaksi dataDashboard = new Transaksi();
                        dataDashboard.Username = (string)reader["username"];
                        dataDashboard.JenisKendaraan = (string)reader["jenis_kendaraan"];
                        dataDashboard.NamaKendaraan = (string)reader["nama_kendaraan"];
                        dataDashboard.Durasi = (int)reader["durasi"];
                        dataDashboard.PaketSewa = (string)reader["nama_paket"];
                        dataDashboard.Harga = (decimal)reader["total_harga"];
                        listDataDashboard.Add(dataDashboard);
                    }
                }
                return listDataDashboard;
            }
        }
    }
}