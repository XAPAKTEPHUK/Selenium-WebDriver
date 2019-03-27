/*Ivan Boychuk
 * Week 5: Practical Tasks
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task 1: Concatenate one string to the end of another string.
             Make sure you have space between them. */
             string one = "Hello";
             string two = "World!";

             var result = $"{one + " " + two}";
             Console.WriteLine(result);           
             
            /* Task 2: Write a code to get the length of a string. */
            string three = "Hello World!";
            var result2 = three.Length;

            Console.WriteLine(result2);
            
            /* Task 3: "The quick brown fox jumps over the lazy dog". 
             Change fox to cat; change dog to frog. */
            string four = "The quick brown fox jumps over the lazy dog";
            var result3 = four.Replace("fox", "cat");
            var result4 = result3.Replace("dog", "frog");

            Console.WriteLine(result4);
            
            /* Task 4: The Quick BroWn Fox! - convert all letters to lowercase. */
            string five = "The Quick BroWn Fox!";
            var result5 = five.ToLower();

            Console.WriteLine(result5);

            /* Task 5: Remove any leading or trailing whitespace from a string. 
             * Use Trim() method. */
            string six = " No white spaces!   ";
            var result6 = six.Trim();

            Console.WriteLine(result6);
           
            /* Task 6: your Starbucks cofee cost $3 (var price =  "$3";) 
             * How much do you spend per month if you drink cofee every day?*/
            var price = "$3";
            int days = 30;
            string price2 = price.Replace("$", "");
            int price3 = int.Parse(price2); //convert string into integer
            var result7 = days * price3;

            Console.WriteLine($"${result7}");

            /* Use a ternary operator to write "Good morning," ...var with your name...! 
             * "Have you had a cup of" ...your brand of cofee..." cofee yet?" if it's AM 
             * and "Good Afternoon, ...your name...! Let's watch" ...some movie..."tonight" if it's PM.*/

            var myName = "Ivan Boychuk";
            var cofeeBrand = "Pete's Cofee";
            var someMovie = "Pulp Fiction";

            string dayCondition = DateTime.Now.ToLongDateString(); //Date.Time.Now.ToString() returns a string like "03/27/2019 5:22:15 AM"
            var dayOrNight = dayCondition.Contains("AM") ?
                $"Good morning {myName}! Had you had a cup of {cofeeBrand}" : 
                $"Good afternoon, {myName}! Let's watch {someMovie}";

            Console.WriteLine(dayOrNight);

            
            /* Task 8: Find an Output */
            var s1 = "somelongstring";
            Console.WriteLine(s1.Substring(2, 4));
            Console.WriteLine(s1.Substring(2));
            Console.ReadKey();

            /* Output:
             * melo
             * melongstring*/

        }
    }
}
