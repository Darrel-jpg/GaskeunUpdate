using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Gaskeun_.Models
{
    public class DataDashboard
    {
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
    }
}
