using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Mark : IWritableObject
    {
        int number=3;
        string subject="a";

        public void Write(SaveManager man)
        {
            man.WriteLine($"subject:{subject}");
            man.WriteLine($"subject:{number}");

        }
    }
}
