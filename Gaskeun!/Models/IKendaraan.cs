using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public interface IKendaraan<T>
    {
        bool Insert(T kendaraan);
        List<T> Read(int idJenis);
        bool Update(T kendaraan, string plat);
        bool Delete(T kendaraan);
    }
}
