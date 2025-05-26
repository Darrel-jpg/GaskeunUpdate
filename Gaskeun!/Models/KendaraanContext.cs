using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class KendaraanContext : Connection, IKendaraan<Kendaraan>
    {
        public List<Kendaraan> listKendaraan = new List<Kendaraan>();
        public bool Insert(Kendaraan kendaraan)
        {
            bool isSuccess = false;
            using (var conn = GetConnection())
            {
                string query = @"INSERT INTO kendaraan(plat, jenis_kendaraan, nama_kendaraan, merk, tahun, cc, kapasitas_bensin, gambar, harga_hari, harga_minggu, harga_bulan, status)
                                VALUES(@plat, @jenis_kendaraan, @nama_kendaraan, @merk, @tahun, @cc, @kapasitas_bensin, @gambar, @harga_hari, @harga_minggu, @harga_bulan, @status);";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(@"plat", kendaraan.Plat));
                    cmd.Parameters.Add(new NpgsqlParameter(@"jenis_kendaraan", kendaraan.JenisKendaraan));
                    cmd.Parameters.Add(new NpgsqlParameter(@"nama_kendaraan", kendaraan.NamaKendaraan));
                    cmd.Parameters.Add(new NpgsqlParameter(@"merk", kendaraan.Merk));
                    cmd.Parameters.Add(new NpgsqlParameter(@"tahun", kendaraan.Tahun));
                    cmd.Parameters.Add(new NpgsqlParameter(@"cc", kendaraan.CC));
                    cmd.Parameters.Add(new NpgsqlParameter(@"kapasitas_bensin", kendaraan.KapasitasBensin));
                    cmd.Parameters.Add(new NpgsqlParameter(@"gambar", kendaraan.Gambar));
                    cmd.Parameters.Add(new NpgsqlParameter(@"harga_hari", kendaraan.HargaHari));
                    cmd.Parameters.Add(new NpgsqlParameter(@"harga_minggu", kendaraan.HargaMinggu));
                    cmd.Parameters.Add(new NpgsqlParameter(@"harga_bulan", kendaraan.HargaBulan));
                    cmd.Parameters.Add(new NpgsqlParameter(@"status", kendaraan.Status));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;
                        this.listKendaraan.Add(kendaraan);
                    }
                }
            }
            return isSuccess;
        }

        public List<Kendaraan> Read(string jenis)
        {
            using (var conn = GetConnection())
            {
                string query = @"SELECT * FROM kendaraan WHERE jenis_kendaraan = @jenis_kendaraan";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@jenis_kendaraan", jenis));
                    cmd.CommandText = query;
                    NpgsqlDataReader reader =cmd.ExecuteReader();
                    listKendaraan.Clear();
                    while (reader.Read())
                    {
                        Kendaraan dataKendaraan = new Kendaraan();
                        
                        dataKendaraan.Plat = (string)reader["plat"];
                        dataKendaraan.NamaKendaraan = (string)reader["nama_kendaraan"];
                        dataKendaraan.Merk = (string)reader["merk"];
                        dataKendaraan.Tahun = (string)reader["tahun"];
                        dataKendaraan.CC = (string)reader["cc"];
                        dataKendaraan.KapasitasBensin = (string)reader["kapasitas_bensin"];
                        dataKendaraan.Gambar = (string)reader["gambar"];
                        dataKendaraan.HargaHari = (decimal)reader["harga_hari"];
                        dataKendaraan.HargaMinggu = (decimal)reader["harga_minggu"];
                        dataKendaraan.HargaBulan = (decimal)reader["harga_bulan"];
                        dataKendaraan.Status = (string)reader["status"];

                        listKendaraan.Add(dataKendaraan);
                    }
                }
            }
            return listKendaraan;
        }

        public bool Update(Kendaraan kendaraan, string platLama)
        {
            bool isSuccess = false;
            using(var conn = GetConnection())
            {
                string query = @"UPDATE kendaraan SET plat = @plat, nama_kendaraan = @nama_kendaraan, 
                                merk = @merk, tahun = @tahun, cc = @cc, kapasitas_bensin = @kapasitas_bensin, gambar = @gambar, 
                                harga_hari = @harga_hari, harga_minggu = @harga_minggu, harga_bulan = @harga_bulan, status = @status 
                                WHERE plat = @platLama;";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(@"plat", kendaraan.Plat));
                    cmd.Parameters.Add(new NpgsqlParameter(@"nama_kendaraan", kendaraan.NamaKendaraan));
                    cmd.Parameters.Add(new NpgsqlParameter(@"merk", kendaraan.Merk));
                    cmd.Parameters.Add(new NpgsqlParameter(@"tahun", kendaraan.Tahun));
                    cmd.Parameters.Add(new NpgsqlParameter(@"cc", kendaraan.CC));
                    cmd.Parameters.Add(new NpgsqlParameter(@"kapasitas_bensin", kendaraan.KapasitasBensin));
                    cmd.Parameters.Add(new NpgsqlParameter(@"gambar", kendaraan.Gambar));
                    cmd.Parameters.Add(new NpgsqlParameter(@"harga_hari", kendaraan.HargaHari));
                    cmd.Parameters.Add(new NpgsqlParameter(@"harga_minggu", kendaraan.HargaMinggu));
                    cmd.Parameters.Add(new NpgsqlParameter(@"harga_bulan", kendaraan.HargaBulan));
                    cmd.Parameters.Add(new NpgsqlParameter(@"status", kendaraan.Status));
                    cmd.Parameters.Add(new NpgsqlParameter(@"platLama", platLama));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataTerupdate = cmd.ExecuteNonQuery();
                    if (jmlDataTerupdate > 0)
                    {
                        isSuccess = true;
                        foreach (var temp in this.listKendaraan)
                        {
                            var t = temp as Kendaraan;
                            if (t != null && t.Plat.Equals(platLama))
                            {
                                t.Plat = kendaraan.Plat;
                                t.NamaKendaraan = kendaraan.NamaKendaraan;
                                t.Merk = kendaraan.Merk;
                                t.Tahun = kendaraan.Tahun;
                                t.CC = kendaraan.CC;
                                t.KapasitasBensin = kendaraan.KapasitasBensin;
                                t.Gambar = kendaraan.Gambar;
                                t.HargaHari = kendaraan.HargaHari;
                                t.HargaMinggu = kendaraan.HargaMinggu;
                                t.HargaBulan = kendaraan.HargaBulan;
                                t.Status = kendaraan.Status;
                            }
                        }
                    }
                }
            }
            return isSuccess;
        }

        public bool Delete(Kendaraan kendaraan)
        {
            bool isSuccess = false;
            using (var conn = GetConnection())
            {
                string query = @"DELETE FROM kendaraan WHERE plat = @plat;";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(@"plat", kendaraan.Plat));
                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataTerhapus = cmd.ExecuteNonQuery();
                    if (jmlDataTerhapus > 0)
                    {
                        isSuccess = true;
                        var itemToRemove = listKendaraan.Single(k => k.Plat == kendaraan.Plat);
                        this.listKendaraan.Remove(itemToRemove);
                    }
                }
            }
            return isSuccess;
        }
    }
}
