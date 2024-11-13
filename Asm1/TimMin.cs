using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1
{
    public class TimMin
    {
        public int Min2(List<int> list)
        {
            if(list == null || list.Count == 0)
            {
                throw new ArgumentNullException("list trong");
            }
            return list.Min();
        }
    }
}
