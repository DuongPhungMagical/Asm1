using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1
{
    public class TruyXuatPhanTu
    {
        public int TruyXuat(int a,List<int> list)
        {
            if(a < 0 || a >= list.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return list[a];
        }
    }
}
