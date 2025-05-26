using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class KendaraanControl
    {
        KendaraanContext kendaraanContext;
        public KendaraanControl()
        {
            kendaraanContext = new KendaraanContext();
        }
        public bool AddKendaraan(Kendaraan kendaraan)
        {
            return kendaraanContext.Insert(kendaraan);
        }
        public List<Kendaraan> ReadKendaraan(string jenis)
        {
            return kendaraanContext.Read(jenis);
        }
        public bool UpdateKendaraan(Kendaraan kendaraan, string platLama)
        {
            return kendaraanContext.Update(kendaraan, platLama);
        }
        public bool DeleteKendaraan(Kendaraan kendaraan)
        {
            return kendaraanContext.Delete(kendaraan);
        }
    }
}
