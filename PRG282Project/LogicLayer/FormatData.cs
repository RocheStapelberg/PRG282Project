using PRG282Project.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.LogicLayer
{
    class FormatData
    {
        public static List<string> UserListToString(List<User> users)
        {
            List<string> tmp = new List<string>();
            foreach (User user in users)
            {
                tmp.Add(user.ToString());
            }

            return tmp;
        }
    }
}
