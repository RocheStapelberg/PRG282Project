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

        public void WriteUser(List<string> users)
        {
            File.WriteAllLines(filePath, users);
        }
    }
}
