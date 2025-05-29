using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class PelangganControl
    {
        PelangganContext pelangganContext;
        public PelangganControl()
        {
            pelangganContext = new PelangganContext();
        }
        public (string pesan, string field) ValidasiInput(string username, string email, string noHp, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username))
            {
                return ("Username tidak boleh kosong", "username");
            }
            if (!email.EndsWith("@gmail.com"))
            {
                return ("Email harus menggunakan domain @gmail.com", "email");
            }
            if (!noHp.All(char.IsDigit))
            {
                return ("Nomor HP hanya boleh berisi angka", "nohp");
            }
            if (string.IsNullOrEmpty(password))
            {
                return ("Password tidak boleh kosong!", "pw");
            }
            if (password != confirmPassword)
            {
                return ("Konfirmasi Password tidak sama", "confirm");
            }
            else
            {
                return ("", "");
            }
        }
        public bool TambahPelanggan(Pelanggan pelanggan)
        {
            return pelangganContext.Insert(pelanggan);
        }
        public List<Pelanggan> ReadPelanggan()
        {
             return pelangganContext.Read();
        }
        public bool UpdatePelanggan(Pelanggan pelanggan)
        {
            return pelangganContext.Update(pelanggan);
        }
        public bool DeletePelanggan(Pelanggan pelanggan)
        {
            return pelangganContext.Delete(pelanggan);
        }
    }
}
