using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class MobilContext
    {
        public List<Mobil> listMobil = new List<Mobil>();
        public bool Insert(Mobil mobil)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";

            using(NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"INSERT INTO public.mobil(plat, nama_mobil, merk, tahun, warna, harga_per_hari, harga_per_minggu, harga_per_bulan, status)
                                VALUES(@plat, @nama_mobil, @merk, @tahun, @warna, @harga_per_hari, @harga_per_minggu, @harga_per_bulan, @status);";
                conn.Open();

                using(NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@plat", mobil.Plat));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_mobil", mobil.NamaMobil));
                    cmd.Parameters.Add(new NpgsqlParameter("@merk", mobil.Merk));
                    cmd.Parameters.Add(new NpgsqlParameter("@tahun", mobil.Tahun));
                    cmd.Parameters.Add(new NpgsqlParameter("@warna", mobil.Warna));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_hari", mobil.HargaPerHari));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_minggu", mobil.HargaPerMinggu));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_bulan", mobil.HargaPerBulan));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", mobil.Status));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSucces = true;
                        this.listMobil.Add(mobil);
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
                string query = @"SELECT plat, nama_mobil, merk, tahun, warna, harga_per_hari, harga_per_minggu, 
                                harga_per_bulan, status FROM public.mobil";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listMobil.Clear();
                    while (reader.Read())
                    {
                        Mobil dataMobil = new Mobil();

                        dataMobil.Plat = (string)reader["plat"];
                        dataMobil.NamaMobil = (string)reader["nama_mobil"];
                        dataMobil.Merk = (string)reader["merk"];
                        dataMobil.Tahun = (string)reader["tahun"];
                        dataMobil.Warna = (string)reader["warna"];
                        dataMobil.HargaPerHari = (decimal)reader["harga_per_hari"];
                        dataMobil.HargaPerMinggu = (decimal)reader["harga_per_minggu"];
                        dataMobil.HargaPerBulan = (decimal)reader["harga_per_bulan"];
                        dataMobil.Status = (string)reader["status"];

                        listMobil.Add(dataMobil);
                    }

                    isSucces = true;
                }
            }

            return isSucces;
        }

        public bool Update(Mobil mobil, string platLama)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";

            using(NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"UPDATE public.mobil
                                SET plat = @plat, nama_mobil = @nama_mobil, merk = @merk, tahun = @tahun, warna = @warna,
                                    harga_per_hari = @harga_per_hari, harga_per_minggu = @harga_per_minggu,
                                    harga_per_bulan = @harga_per_bulan, status = @status
                                WHERE plat = @platLama;";
                conn.Open();

                using(NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@plat", mobil.Plat));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_mobil", mobil.NamaMobil));
                    cmd.Parameters.Add(new NpgsqlParameter("@merk", mobil.Merk));
                    cmd.Parameters.Add(new NpgsqlParameter("@tahun", mobil.Tahun));
                    cmd.Parameters.Add(new NpgsqlParameter("@warna", mobil.Warna));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_hari", mobil.HargaPerHari));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_minggu", mobil.HargaPerMinggu));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_bulan", mobil.HargaPerBulan));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", mobil.Status));
                    cmd.Parameters.Add(new NpgsqlParameter("@platLama", platLama));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataTerupdate = cmd.ExecuteNonQuery();
                    if (jmlDataTerupdate > 0)
                    {
                        isSucces = true;
                        foreach (var temp in this.listMobil)
                        {
                            var t = temp as Mobil;
                            if (t != null && t.Plat.Equals(platLama))
                            {
                                t.Plat = mobil.Plat;
                                t.NamaMobil = mobil.NamaMobil;
                                t.Merk = mobil.Merk;
                                t.Tahun = mobil.Tahun;
                                t.Warna = mobil.Warna;
                                t.HargaPerHari = mobil.HargaPerHari;
                                t.HargaPerMinggu = mobil.HargaPerMinggu;
                                t.HargaPerBulan = mobil.HargaPerBulan;
                                t.Status = mobil.Status;
                            }

                        }
                    }
                }
            }

            return isSucces;
        }

        public bool Delete(Mobil mobil)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"DELETE FROM public.mobil WHERE plat = @plat";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@plat", mobil.Plat));
                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataDihapus = cmd.ExecuteNonQuery();
                    if (jmlDataDihapus > 0)
                    {
                        isSucces = true;
                        var itemToRemove = listMobil.Single(m => m.Plat == mobil.Plat);
                        this.listMobil.Remove(itemToRemove);
                    }
                }
            }

            return isSucces;
        }
    }
}
