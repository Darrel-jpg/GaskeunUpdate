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
                string query = @"SELECT a.username, j.jenis_kendaraan, k.nama_kendaraan, t.tanggal_sewa, t.tanggal_pengembalian, t.tanggal_keterlambatan, t.durasi, p.nama_paket, t.denda, m.nama_metode, t.total_harga, t.berjalan
                                FROM transaksi t 
                                JOIN akun a ON t.id_pelanggan = a.id_akun 
                                JOIN kendaraan k ON t.id_kendaraan = k.id_kendaraan
                                JOIN jenis_kendaraan j ON k.id_jenis_kendaraan = j.id_jenis
                                JOIN paket_sewa p ON t.id_paket_sewa = p.id_paket
                                JOIN metode_pembayaran m ON t.id_metode_pembayaran = m.id_metode;";
                conn.Open();
                using (Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    Npgsql.NpgsqlDataReader reader = cmd.ExecuteReader();
                    listTransaksi.Clear();
                    while (reader.Read())
                    {
                        Transaksi dataTransaksi = new Transaksi();
                        dataTransaksi.Username = (string)reader["username"];
                        dataTransaksi.JenisKendaraan = (string)reader["jenis_kendaraan"];
                        dataTransaksi.NamaKendaraan = (string)reader["nama_kendaraan"];
                        dataTransaksi.TanggalSewa = DateOnly.FromDateTime((DateTime)reader["tanggal_sewa"]);
                        dataTransaksi.TanggalKembali = DateOnly.FromDateTime((DateTime)reader["tanggal_pengembalian"]);
                        dataTransaksi.TanggalKeterlambatan = reader["tanggal_keterlambatan"] != DBNull.Value ? DateOnly.FromDateTime((DateTime)reader["tanggal_keterlambatan"]) : DateOnly.MinValue;
                        dataTransaksi.Durasi = (int)reader["durasi"];
                        dataTransaksi.PaketSewa = (string)reader["nama_paket"];
                        dataTransaksi.Denda = (decimal)reader["denda"];
                        dataTransaksi.MetodePembayaran = (string)reader["nama_metode"];
                        dataTransaksi.Harga = (decimal)reader["total_harga"];
                        dataTransaksi.Berjalan = (int)reader["berjalan"]; // 0 = selesai, 1 = berjalan
                        listTransaksi.Add(dataTransaksi);
                    }   
                }
            }
            return listTransaksi;
        }
        public bool Update(Transaksi transaksi)
        {
            bool isSuccess = false;
            using (var conn = GetConnection())
            {
                string query = @"UPDATE transaksi SET tanggal_keterlambatan = @tanggal_keterlambatan, denda = @denda, total_harga = @total_harga, berjalan = @berjalan
                                WHERE id_transaksi = @id_transaksi;";
                conn.Open();
                using (Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new Npgsql.NpgsqlParameter("@id_transaksi", transaksi.IdTransaksi));
                    cmd.Parameters.Add(new Npgsql.NpgsqlParameter("@tanggal_keterlambatan", transaksi.TanggalKeterlambatan.ToDateTime(TimeOnly.MinValue)));
                    cmd.Parameters.Add(new Npgsql.NpgsqlParameter("@denda", transaksi.Denda));
                    cmd.Parameters.Add(new Npgsql.NpgsqlParameter("@total_harga", transaksi.Harga));
                    cmd.Parameters.Add(new Npgsql.NpgsqlParameter("@berjalan", transaksi.Berjalan));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataTerupdate = cmd.ExecuteNonQuery();
                    if (jmlDataTerupdate > 0)
                    {
                        isSuccess = true;
                        foreach (var temp in this.listTransaksi)
                        {
                            var t = temp as Transaksi;
                            if (t != null && t.IdTransaksi.Equals(transaksi.IdTransaksi))
                            {
                                t.TanggalKeterlambatan = transaksi.TanggalKeterlambatan;
                                t.Denda = transaksi.Denda;
                                t.Harga = transaksi.Harga;
                                t.Berjalan = transaksi.Berjalan;
                            }
                        }
                    }
                }
                return isSuccess;
            }
        }
    }
}
