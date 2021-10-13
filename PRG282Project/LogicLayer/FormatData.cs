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
        /// <summary>
        /// Formats list of User object to a list of string.
        /// </summary>
        /// <param name="users">List of User objects</param>
        /// <returns></returns>
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
