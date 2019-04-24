using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace inchesToMetersConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int inches;
            decimal meters;
            WriteLine("Inches to Meters Converter");
            WriteLine("How many inches is it?");
            inches = ToInt32(ReadLine());
            meters = ToDecimal(inches) / 39;
            WriteLine($"{inches} inches is {meters} meters");
            ReadKey();
        }
    }
}
