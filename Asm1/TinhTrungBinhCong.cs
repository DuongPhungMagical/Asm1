using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1
{
    public class TinhTrungBinhCong
    {
        public double TrungBinhCong(List<int> number)
        {
            if(number == null || number.Count == 0)
            {
                throw new ArithmeticException("List rong");
            }
            double kq = 0;
            foreach (int i in number)
            {
                kq += i;
            }
            return (double)kq / number.Count;
        }
    }
}
