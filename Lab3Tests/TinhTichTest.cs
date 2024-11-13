using Asm1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Tests
{
    [TestFixture]
    public class TinhTichTest
    {
        [Test]
        public void B1TinhTich()
        {
            TinhTich tinh = new TinhTich();
            int result = tinh.TinhTich2So("1","10");
            int expected = 10;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B1TinhTong2()
        {
            TinhTich tinh = new TinhTich();
            Assert.Throws<ArgumentException>(() => tinh.TinhTich2So("a", "11"));
        }
        [Test]
        public void B1TinhTich3()
        {
            TinhTich tinh = new TinhTich();
            int result = tinh.TinhTich2So("2", "9");
            int expected = 18;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B1TinhTich4()
        {
            TinhTich tinh = new TinhTich();
            int result = tinh.TinhTich2So("-1", "11");
            int expected = -11;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B1TinhTich5()
        {
            TinhTich tinh = new TinhTich();
            int result = tinh.TinhTich2So("5", "5");
            int expected = 25;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B1TinhTich6()
        {
            TinhTich tinh = new TinhTich();
            int result = tinh.TinhTich2So("3", "7");
            int expected = 21;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B1TinhTich7()
        {
            TinhTich tinh = new TinhTich();
            int result = tinh.TinhTich2So("6", "8");
            int expected = 48;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B1TinhTich8()
        {
            TinhTich tinh = new TinhTich();
            int result = tinh.TinhTich2So("2", "2");
            int expected = 4;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B1TinhTich9()
        {
            TinhTich tinh = new TinhTich();
            int result = tinh.TinhTich2So("1", "1");
            int expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void B1TinhTich10()
        {
            TinhTich tinh = new TinhTich();
            Assert.Throws<ArgumentException>(() => tinh.TinhTich2So("5.5", "11"));
        }
    }
}
