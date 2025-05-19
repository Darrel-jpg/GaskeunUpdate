using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class TransaksiContext
    {
        public List<Transaksi> listTransaksi = new List<Transaksi>();
        public bool Read()
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"SELECT t.id_transaksi, p.username, mot.nama_motor, mob.nama_mobil, t.tanggal_sewa, t.tanggal_pengembalian, t.jaminan, t.paket_sewa, t.durasi, t.harga
                                FROM transaksi t LEFT JOIN akun_pelanggan p ON t.id_pelanggan = p.id_akun_pelanggan 
                                LEFT JOIN motor mot ON t.id_motor = mot.id_motor
                                LEFT JOIN mobil mob ON t.id_mobil = mob.id_mobil";
                conn.Open();
                using(NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    listTransaksi.Clear();
                    while (reader.Read())
                    {
                        Transaksi dataTransaksi = new Transaksi();

                        dataTransaksi.IdTransaksi = (int)reader["id_transaksi"];
                        dataTransaksi.Username = (string)reader["username"];
                        dataTransaksi.Motor = reader.IsDBNull(reader.GetOrdinal("nama_motor")) ? "-" : reader["nama_motor"].ToString();
                        dataTransaksi.Mobil = reader.IsDBNull(reader.GetOrdinal("nama_mobil")) ? "-" : reader["nama_mobil"].ToString();
                        dataTransaksi.TanggalSewa = (DateTime)reader["tanggal_sewa"];
                        dataTransaksi.TanggalKembali = (DateTime)reader["tanggal_pengembalian"];
                        dataTransaksi.Jaminan = (string)reader["jaminan"];
                        dataTransaksi.PaketSewa = (string)reader["paket_sewa"];
                        dataTransaksi.Durasi = (int)reader["durasi"];
                        dataTransaksi.Harga = (decimal)reader["harga"];

                        listTransaksi.Add(dataTransaksi);
                    }
                    isSuccess = true;
                }
            }
            return isSuccess;
        }
    }
}
