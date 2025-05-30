using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class RiwayatControl
    {
        RiwayatContext riwayatContext;
        public RiwayatControl()
        {
            riwayatContext = new RiwayatContext();
        }
        public List<Transaksi> ReadTransaksi()
        {
            return riwayatContext.Read();
        }
    }
}
