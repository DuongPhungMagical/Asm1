using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1
{
    public class TinhTich
    {
        public int TinhTich2So(string a, string b)
        {
            if(int.TryParse(a, out int so1) && int.TryParse(b, out int so2))
            {
                return so1 * so2;
            }
            throw new ArgumentException("a va b phai la so nguyen");
        }
    }
}
