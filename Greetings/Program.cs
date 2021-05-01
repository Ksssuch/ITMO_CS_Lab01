using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Insert your name");
            myName = Console.ReadLine();
            Console.WriteLine("hello {0} " , myName);
        }
    }
}
