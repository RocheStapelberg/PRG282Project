using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282Project.DataLayer
{
    class FileHandler
    {
        public FileHandler() { }

        string filePath = $"{AppContext.BaseDirectory}UserData.txt";
        
        public void CreateFile()
        {
            var dataFile = File.CreateText(filePath);
            dataFile.Close();
        }
        public List<User> GetUsers()
        {
            List<string> tmp = new List<string>();
            List<User> retUsers = new List<User>();
            tmp = File.ReadAllLines(filePath).ToList();

            foreach (string item in tmp)
            {
                string[] split = item.Split(',');
                string username = split[0];
                string password = split[1];
                User user = new User(username, password);
                retUsers.Add(user);
            }

            return retUsers;
        }
        public void WriteUser(List<string> users)
        {
            File.WriteAllLines(filePath, users);
        }


    }
}
