using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace averageOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int one, two, three, average;
            WriteLine("Average of Three Input Numbers");
            WriteLine();
            WriteLine("Please enter the first number:");
            one = ToInt32(ReadLine());
            WriteLine("Please enter the second number:");
            two = ToInt32(ReadLine());
            WriteLine("Please enter the third number:");
            three = ToInt32(ReadLine());
            average = (one + two + three) / 3;
            WriteLine($"The Average of Your Numbers is {average}");
            ReadKey();
        }
    }
}
