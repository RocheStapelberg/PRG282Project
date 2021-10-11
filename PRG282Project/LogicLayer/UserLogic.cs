using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282Project.DataLayer;

namespace PRG282Project.LogicLayer
{
    class UserLogic
    {
        public static void RegisterUser(string username, string password, List<User> users)
        {
            User u = new User(username, password);
            users.Add(u);

        }
        public static void CheckDetails(List<User> users)
        {
            
        }
    }
}
