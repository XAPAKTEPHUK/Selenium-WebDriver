/*Ivan Boychuk
 * Week 6 Additional Tasks */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Week6AdditionalTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write a program to print out an absolute value of a number.
             E.G.:
             Input: 1   Output: 1
             Input:-1   Output: 1*/
            Console.WriteLine("Please enter any number to get an absolute value!");
            int numberEntered = Convert.ToInt32(Console.ReadLine());

            if (numberEntered < 0)
            {
                numberEntered *= -1;               
            }
            Console.WriteLine($"Absolute value of an entered number is {numberEntered}");
            Console.ReadKey();
            Console.Clear();

            /* 2. Write a program that accepts three numbers and prints "All numbers are equal", 
             * "All numbers are different" or "Neither are equalor different"*/
            Console.WriteLine("Please enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("All numbers are equal");
            }
            else if (firstNumber != secondNumber && secondNumber != thirdNumber
                && firstNumber != thirdNumber)
            {
                Console.WriteLine("All numbers are different");
            }
            else
            {
                Console.WriteLine("Neither all are equal or different");
            }
            Console.ReadKey();
            Console.Clear();

            /* 3. Write a program that accepts three numbers and prints either 
             * "Increasing", "Decreasing" or "Neither increasing nor increasing"" */
            Console.WriteLine("Please enter the first number:");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first number:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first number:");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            if (numberOne < numberTwo && numberTwo < numberThree)
            {
                Console.WriteLine("Increasing!");
            }
            else if ((numberOne > numberTwo) && (numberTwo > numberThree))
            {
                Console.WriteLine("Decreasing!");
            }
            else
            {
                Console.WriteLine("Neither increasing or decreasing!");
            }
            Console.ReadKey();
            Console.Clear();

            /* 4. Take a phone number in format 8888888888 and format it to (888) 888-8888 */

            Console.WriteLine("Please enter a ten digit phone number:");
            string phoneNumber = Console.ReadLine();
            var formatedNumber = string.Format("{0:(###) ###-####}", Convert.ToInt64(phoneNumber));

            Console.WriteLine($"You phone number is {formatedNumber}");
            Console.ReadKey();
            Console.Clear();

            /* 5. Capitalize a first letter of a string*/
            string capitalize1stLetter = "please capitilize first letter";
            //TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            //capitalize1stLetter = textInfo.ToTitleCase(capitalize1stLetter);
            capitalize1stLetter = char.ToUpper(capitalize1stLetter[0]) + capitalize1stLetter.Substring(1);

            Console.WriteLine(capitalize1stLetter);
            Console.ReadKey();
            Console.Clear();

        }
    }
}
