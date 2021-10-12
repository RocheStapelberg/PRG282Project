using PRG282Project.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.LogicLayer
{
    class CheckPassword
    {
        public bool CheckUserPassword(List<User> users, string password, string username)
        {
            foreach (User user in users)
            {
                if (user.UserName == username)
                {
                    if (user.Password == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

    }
}
