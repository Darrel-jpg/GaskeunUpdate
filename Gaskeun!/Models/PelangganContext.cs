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
                string sql = @"INSERT INTO public.akun_pelanggan(username, email, password, no_hp, status)
                                VALUES(@username, @email, @password, @no_hp, @status);";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@username", pelanggan.Username));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", pelanggan.Email));
                    cmd.Parameters.Add(new NpgsqlParameter("@password", pelanggan.Password));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", pelanggan.NoHp));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", pelanggan.Status));

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

        public bool Read()
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = "SELECT * FROM public.akun_pelanggan";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listPelanggan.Clear();
                    while (reader.Read())
                    {
                        Pelanggan dataPelanggan = new Pelanggan();

                        dataPelanggan.Username = (string)reader["username"];
                        dataPelanggan.Email = (string)reader["email"];
                        dataPelanggan.NoHp = (string)reader["no_hp"];
                        dataPelanggan.Password = (string)reader["password"];
                        dataPelanggan.Status = (string)reader["status"];

                        listPelanggan.Add(dataPelanggan);
                    }
                    isSucces = true;
                }
            }
            return isSucces;
        }

        public bool Update(Pelanggan pelanggan)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"UPDATE public.akun_pelanggan
                                SET username = @username, email = @email, no_hp = @no_hp, status = @status
                                WHERE no_hp = @no_hp";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@username", pelanggan.Username));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", pelanggan.Email));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", pelanggan.NoHp));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", pelanggan.Status));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataTerupdate = cmd.ExecuteNonQuery();
                    if (jmlDataTerupdate > 0)
                    {
                        isSucces = true;
                        foreach(var temp in this.listPelanggan)
                        {
                            var t = temp as Pelanggan;
                            if (t != null && t.NoHp.Equals(pelanggan.NoHp))
                            {
                                t.Username = pelanggan.Username;
                                t.Email = pelanggan.Email;
                                t.NoHp = pelanggan.NoHp;
                                t.Password = pelanggan.Password;
                                t.Status = pelanggan.Status;
                            }
                        }
                    }
                }
            }
            return isSucces;
        }
        public bool Delete(Pelanggan pelanggan)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"DELETE FROM public.akun_pelanggan WHERE no_hp = @no_hp";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", pelanggan.NoHp));
                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataDihapus = cmd.ExecuteNonQuery();
                    if (jmlDataDihapus > 0)
                    {
                        isSucces = true;
                        var itemToRemove = this.listPelanggan.Single(p => p.NoHp == pelanggan.NoHp);
                        this.listPelanggan.Remove(itemToRemove);
                    }
                }
            }
            return isSucces;
        }
    }
}
