using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1
{
    public class TruyXuatHoSo
    {
        public class UserProfile
        {
            public string Name { get; set; }
        }

        public class UserService
        {
            public string GetName(UserProfile profile)
            {
                if (profile == null)
                {
                    throw new NullReferenceException("Ho so trong");
                }

                return profile.Name;
            }
        }
    }
}
