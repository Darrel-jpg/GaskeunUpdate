using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaskeun_.Models;

namespace Gaskeun_.Controller
{
    public class TransaksiControl
    {
        TransaksiContext transaksiContext = new TransaksiContext();

        public List<Transaksi> ReadTransaksi()
        {
            return transaksiContext.Read();
        }
        public bool UpdateTransaksi(Transaksi transaksi)
        {
            return transaksiContext.Update(transaksi);
        }
    }
}
