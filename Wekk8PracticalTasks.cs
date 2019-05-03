using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace Week8PracticalTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Display the first 10 natural numbers.*/

            WriteLine($"The first ten natural numbers are: ");
            for (int i= 1; i<=10; i++)
            {
                WriteLine(i);
            }
            ReadKey();
            Clear();

            /* 2. Find the sum of first 10 natural numbers.*/

            int numbers, sum = 0;
            for (numbers = 1; numbers <= 10; numbers++)
            {
                sum = sum + numbers;
            }
            WriteLine($"The sum of first ten natural numbers is {sum}");
            ReadKey();
            Clear();

            /* 3. Display the multiplication table of a given integer.*/
            WriteLine("Multiplication table of a given integer\n");
            int integer, number;
            WriteLine("Enter a number: ");
            integer = ToInt32(ReadLine());
            for(number=1; number<=10; number++)
            {
                WriteLine("{0} x {1} = {2}", integer, number, integer * number);
            }
            ReadKey();
            Clear();

            /* 4. Calculate the factorial of a given number.*/

            WriteLine("Factorial of a given number/n");
            int x, factorial, numberBelow;
            WriteLine("Enter a number: ");
            numberBelow = ToInt32(ReadLine());
            factorial = numberBelow;
            for(x = numberBelow-1; x>=1; x--)
            {
                factorial = factorial * x;
            }
            WriteLine(factorial);
            ReadKey();
            Clear();


            /* 5. Find the number and sum of all integers between 1 and 50 which are divisible by 9.*/
            int magicNumber=0, 
                ifNumber = 9, 
                sumNumber=0, 
                count=0;
            for (magicNumber = 1; magicNumber <= 50; magicNumber++)
            {
                if (magicNumber%ifNumber==0)
                {
                    count++;
                    sumNumber= sumNumber + magicNumber;
                }
            }
            WriteLine($"There are {count} integers between 1 and 50 which are divisible by 9, " +
                $"and their sum is {sumNumber}");
            ReadKey();
        }
        
    }
}
