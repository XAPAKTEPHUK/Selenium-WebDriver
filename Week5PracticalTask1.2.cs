using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello world";
            string hello1 = "Hello World";

            var result = hello.ToUpper() == hello1.ToUpper();
            var result1 = hello.ToLower() == hello1.ToLower();
            Console.WriteLine("!" + result + "!");
            Console.WriteLine("!" + result1 + "!");
            Console.ReadKey();
        }
    }
}
