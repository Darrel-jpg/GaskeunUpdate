using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class AdminContext:Connection
    {
        public bool CekAdmin(string username, string password)
        {
            bool isSucces = false;
            using (var conn = GetConnection())
            {
                string sqlAdmin = "SELECT COUNT(1) FROM akun WHERE username = @username AND password = @password AND id_role = @id_role";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlAdmin, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@username", username));
                    cmd.Parameters.Add(new NpgsqlParameter("@password", password));
                    cmd.Parameters.Add(new NpgsqlParameter("@id_role", 1));

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
