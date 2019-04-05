/* Ivan Boychuk
 * Week 6
 * Practical Tasks*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week6PracticalTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Get a number from the user and print whether it is positive or negative */
            Console.WriteLine("Please enter a number: ");
            var numberEntered = Convert.ToInt32(Console.ReadLine());

            if (numberEntered < 0)
            {
                Console.WriteLine($"{numberEntered}. This is a negative number.");
            }
            else
            {
                Console.WriteLine($"{numberEntered}. This is a positive number.");
            }
            Console.ReadKey();
            Console.Clear();

            /* 2. Write code to read the age of a person and determine whether a person is eligible for voting.
             * If the person is not eligible - print out message with information of how many years the person
             * should wait to be eligible to vote */
            Console.WriteLine("How old are you?");
            var yearsOfAge = Convert.ToInt32(Console.ReadLine());

            if (yearsOfAge >= 18)
            {
                Console.WriteLine($"Based on you age ({yearsOfAge}), you are eligible to vote!");
            }
            else
            {
                if (yearsOfAge == 17)
                {
                    Console.WriteLine($"Please wait {Math.Abs(yearsOfAge -= 18)}" +
                        $" year before you are eligible to vote.");
                }
                else
                {
                    Console.WriteLine($"Please wait {Math.Abs(yearsOfAge -= 18)} " +
                        $"years before you are eligible to vote.");
                }
            }
            Console.ReadKey();
            Console.Clear();

            /* 3. Write a program to check whether a given number is even or odd.
             * If the number is even - print out "The number ...your number... is even"
             * If the number is odd - print out "The number ...your number... is odd" */
            Random  random = new Random();
            int randomNumber = random.Next(100);

            if ((randomNumber%2)==0)
            {
                Console.WriteLine($"The random number {randomNumber} is even.");
            }
            else
            {
                Console.WriteLine($"The random number {randomNumber} is odd.");
            }
            Console.ReadKey();
            Console.Clear();

            /* 4. Write a program which takes a number between 1 and 7 and prints out the name of the weekday.
             * If the number is not within 1-7 range - produce a massage which would inform the user about the mistake. */
            Console.WriteLine("Please enter a number between 1 and 7:");
            int weekNumber = Convert.ToInt32(Console.ReadLine());

            if ( (weekNumber > 0) && (weekNumber < 8))
            {
                if (weekNumber == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if (weekNumber ==2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (weekNumber == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (weekNumber == 4)
                {
                    Console.WriteLine("Thursday");
                }
                else if (weekNumber == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (weekNumber == 6)
                {
                    Console.WriteLine("Saturday");
                }
                else 
                {
                    Console.WriteLine("Sunday");
                }
            }
            else
            {
                Console.WriteLine($"{weekNumber} is not in the range");
            }
            Console.ReadKey();
            Console.Clear();

            /* 5. Come up with a year and print whether that year is a leap year or not */
            Random year = new Random();
            int randomYear = year.Next(2019);
            //randomYear = 2020;

            if (((randomYear%4)==0) && ((randomYear%100) != 0) || ((randomYear%400) ==0))
            {
                Console.WriteLine($"{randomYear} is a leap year");
            }
            else
            {
                Console.WriteLine($"{randomYear} is not a leap year");
            }
            Console.ReadKey();
            Console.Clear();

            /* 6. A company decided to give bonus of 5% to employee if his/her year of service is more than 5 years.
             *Come up with a salary and a year of service and print the net bonus amount */
            double percentage = 0.05;
            Random experience = new Random();
            int yearsOfExperience = experience.Next(10);
            double salary = 100000.00;

            if (yearsOfExperience >= 5)
            {
                Console.WriteLine($"Congradulations, based on your {yearsOfExperience} years of experience," +
                    $" you qulify for 5% bonus of ${salary * percentage}. " +
                    $"Your new salary is ${salary += (salary * percentage)}");
            }
            else
            {
                Console.WriteLine($"You have been {yearsOfExperience} years with us.");
            }
            Console.ReadKey();
            Console.Clear();

            /* 7. A school has the following rules for grading system:
             * a. Below 25 - F
             * b. 25 to 45 - E
             * c. 45 to 50 - D
             * d. 50 to 60 - C
             * e. 60 to 80 - B
             * f. Above 80 - A
             Ask the user to enter marks and print the corresponding grade. 
             If the grade is greater than 60 - print out "Good Job!"
             If it's greater than 80 - print "Excellent!!!*/
            Console.WriteLine("What was your score on he test?");
            int score = Convert.ToInt32(Console.ReadLine());
            char grade;

            if (score<25)
            {
                grade = 'F';
                Console.WriteLine($"You got a {grade}");
            }
            else if (score > 25 && score <=45)
            {
                grade = 'E';
                Console.WriteLine($"You got a {grade}");
            }
            else if (score > 45 && score <=50)
            {
                grade = 'D';
                Console.WriteLine($"You got a {grade}");
            }
            else if (score > 50 && score <= 60)
            {
                grade = 'C';
                Console.WriteLine($"You got a {grade}");
            }
            else if (score > 60 && score <= 80)
            {
                grade = 'B';
                Console.WriteLine($"You got a {grade}");
                Console.WriteLine("Good Job!");
            }
            else if (score > 80 && score <= 100)
            {
                grade = 'A';
                Console.WriteLine($"You got a {grade}");
                Console.WriteLine("Excellent!!!");
            }
            else
            {
                Console.WriteLine("That's not possible!!!");
            }
            Console.ReadKey();
            Console.Clear();

            /* 8. Write a program to calculate your BMI and give you a recomendation 
             * if you should gain/lose some weight or if you should stay as you are */
            Console.WriteLine("What is your weight in kilograms?");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your height in centimeters?");
            double height = Convert.ToDouble(Console.ReadLine());
            double BMI = (weight) / (Math.Pow((height / 100) , 2));
            if (BMI<18.5)
            {
                Console.WriteLine($"Your BMI is {BMI}. You should gain weight.");
            }
            else if (BMI > 18.5 && BMI < 24.9)
            {
                Console.WriteLine($"Your BMI is {BMI}. You should stay as you are.");
            }
            else if (BMI > 25)
            {
                Console.WriteLine($"Your BMI is {BMI}. You should lose weight");
            }
            else
            {
                Console.WriteLine("Are you sure your numbers are right?");
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
