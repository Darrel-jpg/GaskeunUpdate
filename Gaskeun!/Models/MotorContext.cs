using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class MotorContext
    {
        public List<Motor> listMotor = new List<Motor>();

        public bool Insert(Motor motor)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"INSERT INTO public.motor(nama_motor, merk, tahun, plat, warna, gambar, harga_per_hari, harga_per_minggu, harga_per_bulan, status)
                                VALUES(@nama_motor, @merk, @tahun, @plat, @warna, @gambar, @harga_per_hari, @harga_per_minggu, @harga_per_bulan, @status);";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@plat", motor.Plat));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_motor", motor.NamaMotor));
                    cmd.Parameters.Add(new NpgsqlParameter("@merk", motor.Merk));
                    cmd.Parameters.Add(new NpgsqlParameter("@tahun", motor.Tahun));
                    cmd.Parameters.Add(new NpgsqlParameter("@warna", motor.Warna));
                    cmd.Parameters.Add(new NpgsqlParameter("@gambar", motor.Gambar));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_hari", motor.HargaPerHari));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_minggu", motor.HargaPerMinggu));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_bulan", motor.HargaPerBulan));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", motor.Status));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0 )
                    {
                        isSucces = true;
                        this.listMotor.Add(motor);
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
                string query = @"SELECT plat, nama_motor, merk, tahun, warna, gambar, harga_per_hari, harga_per_minggu, 
                                harga_per_bulan, status FROM public.motor";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listMotor.Clear();
                    while (reader.Read())
                    {
                        Motor dataMotor = new Motor();

                        dataMotor.Plat = (string)reader["plat"];
                        dataMotor.NamaMotor = (string)reader["nama_motor"];
                        dataMotor.Merk = (string)reader["merk"];
                        dataMotor.Tahun = (string)reader["tahun"];
                        dataMotor.Warna = (string)reader["warna"];
                        dataMotor.Gambar = (string)reader["gambar"];
                        dataMotor.HargaPerHari = (decimal)reader["harga_per_hari"];
                        dataMotor.HargaPerMinggu = (decimal)reader["harga_per_minggu"];
                        dataMotor.HargaPerBulan = (decimal)reader["harga_per_bulan"];
                        dataMotor.Status = (string)reader["status"];

                        listMotor.Add(dataMotor);
                    }

                    isSucces = true;
                }
            }

            return isSucces;
        }

        public bool Update(Motor motor, string platLama)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";

            using(NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"UPDATE public.motor
                                SET  plat = @plat, nama_motor = @nama_motor, merk = @merk, tahun = @tahun, warna = @warna,  gambar = @gambar,
                                    harga_per_hari = @harga_per_hari, harga_per_minggu = @harga_per_minggu,
                                    harga_per_bulan = @harga_per_bulan, status = @status
                                WHERE plat = @plat_lama";
                conn.Open();

                using(NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@plat", motor.Plat));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_motor", motor.NamaMotor));
                    cmd.Parameters.Add(new NpgsqlParameter("@merk", motor.Merk));
                    cmd.Parameters.Add(new NpgsqlParameter("@tahun", motor.Tahun));
                    cmd.Parameters.Add(new NpgsqlParameter("@warna", motor.Warna));
                    cmd.Parameters.Add(new NpgsqlParameter("@gambar", motor.Gambar));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_hari", motor.HargaPerHari));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_minggu", motor.HargaPerMinggu));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_per_bulan", motor.HargaPerBulan));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", motor.Status));
                    cmd.Parameters.Add(new NpgsqlParameter("@plat_lama", platLama));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataTerupadte = cmd.ExecuteNonQuery();
                    if (jmlDataTerupadte > 0)
                    {
                        isSucces = true;
                        foreach (var temp in this.listMotor)
                        {
                            var t = temp as Motor;
                            if (t != null && t.Plat.Equals(platLama))
                            {
                                t.Plat = motor.Plat;
                                t.NamaMotor = motor.NamaMotor;
                                t.Merk = motor.Merk;
                                t.Tahun = motor.Tahun;
                                t.Warna = motor.Warna;
                                t.Gambar = motor.Gambar;
                                t.HargaPerHari = motor.HargaPerHari;
                                t.HargaPerMinggu = motor.HargaPerMinggu;
                                t.HargaPerBulan = motor.HargaPerBulan;
                                t.Status = motor.Status;
                            }
                        }
                    }
                }
            }

            return isSucces;
        }

        public bool Delete(Motor motor)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string query = @"DELETE FROM public.motor WHERE plat = @plat";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@plat", motor.Plat));
                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataDihapus = cmd.ExecuteNonQuery();
                    if (jmlDataDihapus > 0)
                    {
                        isSucces = true;
                        var itemToRemove = listMotor.Single(m => m.Plat == motor.Plat);
                        this.listMotor.Remove(itemToRemove);
                    }
                }
            }

            return isSucces;
        }
    }
}
