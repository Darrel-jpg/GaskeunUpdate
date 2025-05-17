using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class PelangganContext
    {
        public List<Pelanggan> listPelanggan = new List<Pelanggan>();
        public bool CekPelanggan(string username, string password)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sqlPelanggan = "SELECT COUNT(1) FROM akun_pelanggan WHERE username = @username AND password = @password";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlPelanggan, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        isSucces = true;
                    }
                    else
                    {
                        isSucces = false;
                    }
                }
            }
            return isSucces;
        }

        public bool Insert(Pelanggan pelanggan)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = @"INSERT INTO public.pelanggan(username, email, password, no_hp)
                                VALUES(@username, @email, @password, @no_hp);";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@username", pelanggan.Username));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", pelanggan.Email));
                    cmd.Parameters.Add(new NpgsqlParameter("@password", pelanggan.Password));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", pelanggan.NoHp));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSucces = true;
                        this.listPelanggan.Add(pelanggan);
                    }
                }
            }

            return isSucces;
        }
    }
}
