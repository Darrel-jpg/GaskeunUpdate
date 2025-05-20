using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Gaskeun_.Models
{
    public class DashboardContext
    {
        public List<Dashboard> listDataDashboard = new List<Dashboard>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
        public int GetJumlahMobil()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"SELECT COUNT(*) FROM public.mobil";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
        }

        public int GetJumlahMotor()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"SELECT COUNT(*) FROM public.motor";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
        }

        public int GetJumlahPelanggan()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"SELECT COUNT(*) FROM public.akun_pelanggan";
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
                string query = @"SELECT SUM(harga) FROM public.transaksi";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                    return total;
                }
            }
        }
        public bool PelangganHariIni()
        {
            bool isSuccess = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"SELECT t.id_transaksi, p.username, mob.nama_mobil, mot.nama_motor, t.paket_sewa, t.durasi, t.harga
                                FROM transaksi t 
                                LEFT JOIN akun_pelanggan p ON t.id_pelanggan = p.id_akun_pelanggan
                                LEFT JOIN mobil mob ON t.id_mobil = mob.id_mobil
                                LEFT JOIN motor mot ON t.id_motor = mot.id_motor
                                where t.tanggal_sewa = current_date";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    listDataDashboard.Clear();
                    while (reader.Read())
                    {
                        Dashboard dataDashboard = new Dashboard();

                        dataDashboard.IdTransaksi = (int)reader["id_transaksi"];
                        dataDashboard.Username = (string)reader["username"];
                        dataDashboard.Mobil = reader.IsDBNull(reader.GetOrdinal("nama_mobil")) ? "-" : reader["nama_mobil"].ToString();
                        dataDashboard.Motor = reader.IsDBNull(reader.GetOrdinal("nama_motor")) ? "-" : reader["nama_motor"].ToString();
                        dataDashboard.PaketSewa = (string)reader["paket_sewa"];
                        dataDashboard.Durasi = (int)reader["durasi"];
                        dataDashboard.Harga = (decimal)reader["harga"];

                        listDataDashboard.Add(dataDashboard);
                    }
                    isSuccess = true;
                }
            }
            return isSuccess;
        }
    }
}
