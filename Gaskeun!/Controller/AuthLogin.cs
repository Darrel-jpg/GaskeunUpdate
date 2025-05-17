using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Gaskeun_.Controller
{
    public class AuthLogin
    {
        AdminContext adminContext = new AdminContext();
        PelangganContext pelangganContext = new PelangganContext();

        public bool LoginAdmin(string username, string password)
        {
            return adminContext.CekAdmin(username, password);
        }

        public bool LoginPelanggan(string username, string password)
        {
            return pelangganContext.CekPelanggan(username, password);
        }
    }
}
