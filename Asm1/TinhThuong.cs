using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1
{
    public class TinhThuong
    {
        public double TinhThuong2So(int a, int b)
        {
            if(b != 0)
            {
                return a / b;
            }
            throw new ArgumentException("b phai la so khac 0");
        }
    }
}
