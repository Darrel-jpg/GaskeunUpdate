using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class Pelanggan
    {
        public int IdRole { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string NoHp { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public string StatusText => Status == 1 ? "Aktif" : "Nonaktif";
    }
}
