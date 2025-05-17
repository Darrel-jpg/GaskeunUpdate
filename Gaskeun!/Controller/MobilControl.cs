using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class MobilControl
    {
        MobilContext mobilContext;
        public MobilControl()
        {
            mobilContext = new MobilContext();
        }
        public bool AddMobil(Mobil mobil)
        {
            return mobilContext.Insert(mobil);
        }
        public List<Mobil> ReadMobil()
        {
            mobilContext.Read();
            return mobilContext.listMobil;
        }
        public bool UpdateMobil(Mobil mobil, string platLama)
        {
            return mobilContext.Update(mobil, platLama);
        }
        public bool DeleteMobil(Mobil mobil)
        {
            return mobilContext.Delete(mobil);
        }
    }
}
