using Asm1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Tests
{
    public class TruyXuatTest
    {
        [Test]
        public void B4TruyXuat()
        {
            TruyXuatPhanTu t = new TruyXuatPhanTu();
            int result = t.TruyXuat(4 ,new List<int> { 1,2,3,4,5});
            int expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B4TruyXuat2()
        {
            TruyXuatPhanTu t = new TruyXuatPhanTu();
            Assert.Throws<IndexOutOfRangeException>(() => t.TruyXuat(16, new List<int> {1,2,3,4 }));
        }
    }
}
