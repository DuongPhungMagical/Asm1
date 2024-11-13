using Asm1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Tests
{
    [TestFixture]
    public class TinhThuongTest
    {
        [Test]
        public void B2TinhThuong()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(6, 2);
            double expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B2TinhThuong2()
        {
            TinhThuong tinh = new TinhThuong();
            Assert.Throws<ArgumentException>(() => tinh.TinhThuong2So(5, 0));
        }
        [Test]
        public void B2TinhThuong3()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(10, 2);
            double expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B2TinhThuong4()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(9, 2);
            double expected = 4.5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B2TinhThuong5()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(0, 2);
            double expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B2TinhThuong6()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(4, 2);
            double expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B2TinhThuong7()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(12, 2);
            double expected = 6;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B2TinhThuong8()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(10, 2);
            double expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B2TinhThuong9()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(22, 2);
            double expected = 11;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B2TinhThuong10()
        {
            TinhThuong tinh = new TinhThuong();
            double result = tinh.TinhThuong2So(10, 2);
            double expected = 10;
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
