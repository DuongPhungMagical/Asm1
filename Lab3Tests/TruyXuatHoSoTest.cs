using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Asm1.TruyXuatHoSo;

namespace Lab3Tests
{
    public class TruyXuatHoSoTest
    {
        [TestFixture]
        public class HoSoTest
        {
            [Test]
            public void B5TruyXuatHoSo()
            {
                UserService service = new UserService();

                Assert.Throws<NullReferenceException>(() => service.GetName(null));
            }

            [Test]
            public void B5TruyXuatHoSo1()
            {
                UserService service = new UserService();
                UserProfile profile = new UserProfile { Name = "John Doe" };

                string result = service.GetName(profile);

                Assert.AreEqual("John Doe", result);
            }
        }
    }
}
