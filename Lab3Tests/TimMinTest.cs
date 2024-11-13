using Asm1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Tests
{
    [TestFixture]
    public class TimMinTest
    {
        [Test]
        public void B6TimMin()
        {
            TimMin min = new TimMin();
            List<int> list = new List<int> { 1, 2, 3, 4 };
            int result = min.Min2(list);
            int expected = 1;
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void B6TimMin2()
        {
            TimMin min = new TimMin();
            List<int> list = new List<int>();
            Assert.Throws<ArgumentException>(() => min.Min2(list));
        }
    }
}
