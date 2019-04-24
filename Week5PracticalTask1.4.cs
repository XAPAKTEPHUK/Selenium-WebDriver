using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World";
            var result = hello.Replace("l", "s");

            Console.WriteLine("!" + result + "!");
            Console.ReadKey();
        }
    }
}
