using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wekk7PracticalTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total price is $ {PriceTotal("$20.51", "$30.30")}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"The area of a rectangle  is {RectangleArea(15, 16)}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"The smallest number of three is {SmallestOfThree(5, 16, 8)}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(Login("Ivan", "Chicago1"));
            Console.ReadKey();
            Console.Clear();
        }

        /* 1. Create a static method which takes two strings (prices) in this format:
         * $XX.XX and returns a total price. Call this method from a different class */
        public static double PriceTotal(string priceOne, string priceTwo)
        {
            priceOne = priceOne.Replace("$", String.Empty);
            priceTwo = priceTwo.Replace("$", String.Empty);
            double totalPrice = Convert.ToDouble(priceOne) + Convert.ToDouble(priceTwo);
            return totalPrice;
        }

        /* 2. Created a method which would take two integers and calculate the area of a rectangle.
         * Call the method from another class */
        public static int RectangleArea(int length, int width)
        {
            int recArea = length * width;
            return recArea;
        }

        /* 3. Write a method to find the smallest number among three numbers.
         *  The number should be passed into the method as parameters */
        public static int SmallestOfThree (int numberOne, int numberTwo, int numberThree)
        {
            int smallestNumber;

            if (numberOne < numberTwo)
            {
                if (numberOne < numberThree)
                {
                    smallestNumber = numberOne;
                }
                else
                {
                    smallestNumber = numberThree;
                }
            }
            else if (numberTwo < numberThree)
            {
                smallestNumber = numberTwo;
            }
            else
            {
                smallestNumber = numberThree;
            }

            return smallestNumber;
        }

        /* 4. Create a method, which takes two parameters - username and password.
         * If the username matches your name and password matches "Chicago1",
         * the method prints out a message: "Hello, your name! You are logged in".
         * If not - "Incorect username or password" */
        public static string Login(string username, string password)
        {
            string loginStatus;
            if (username == "Ivan" && password == "Chicago1")
            {
                loginStatus = $"Hello, {username}! You are logged in!";
            }
            else
            {
                loginStatus = $"Incorect username or password!";
            }

            return loginStatus;
        }
    }
}      
