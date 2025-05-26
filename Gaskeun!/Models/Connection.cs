using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public abstract class Connection
    {
        protected string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(conStr);
        }
    }
}
