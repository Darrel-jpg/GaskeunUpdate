using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class AdminContext
    {
        public bool CekAdmin(string username, string password)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sqlAdmin = "SELECT COUNT(1) FROM akun_admin WHERE username = @username AND password = @password";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlAdmin, conn))
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
    }
}
