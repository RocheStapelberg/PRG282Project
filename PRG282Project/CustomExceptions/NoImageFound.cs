using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.CustomExceptions
{
    class NoImageFound : Exception
    {
        public NoImageFound() { }
        public NoImageFound(string message) : base(message) { }
        public NoImageFound(string message, Exception inner) : base(message, inner) { }
    }
}
