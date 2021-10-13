using PRG282Project.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.LogicLayer
{
    class UserLogic
    {
        /// <summary>
        /// Checks for correct user name and password.
        /// </summary>
        /// <param name="users">List of users</param>
        /// <param name="password">User password</param>
        /// <param name="username">User username</param>
        /// <returns>True if details match and false if not.</returns>
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
            }

            return false;
        }

        /// <summary>
        /// Adds a new user to a existing list of users and writes them to a file.
        /// </summary>
        /// <param name="users">List of users</param>
        /// <param name="username">User usersname</param>
        /// <param name="password">User password</param>
        public void RegisterUser(List<User> users, string username, string password)
        {
            users.Add(new User(username, password));

            FileHandler handler = new FileHandler();

            List<string> tmp = FormatData.UserListToString(users);

            handler.WriteUser(tmp);

        }

    }
}
