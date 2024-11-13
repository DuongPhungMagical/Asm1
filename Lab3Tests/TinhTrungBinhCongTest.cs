using Asm1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Tests
{
    [TestFixture]
    public class TinhTrungBinhCongTest
    {
        [Test]
        public void B3TrungBinhCong()
        {
            TinhTrungBinhCong tinh = new TinhTrungBinhCong();
            List<int> emptyList = new List<int>();
            Assert.Throws<ArithmeticException>(() => tinh.TrungBinhCong(emptyList));
        }
        [Test]
        public void B3TrungBinhCong1()
        {
            TinhTrungBinhCong tinh = new TinhTrungBinhCong();
            List<int> list = new List<int> { 1,2,3,4};
            double result = tinh.TrungBinhCong(list);
            double expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
