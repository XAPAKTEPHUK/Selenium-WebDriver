using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello world";
            string world = "world ho";

            var result = hello.Substring(1, hello.Length - 1) + "!" + 
                world.Substring(1, world.Length - 1);

            Console.WriteLine("!" + result + "!");
            Console.ReadKey();
        }
    }
}
