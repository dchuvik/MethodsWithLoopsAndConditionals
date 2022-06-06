using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintNums();

            //CountBy3();

            //Check if Equal
            Console.WriteLine("Enter two numbers to check if they're equal: ");
            IsEqual(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            //Even/Odd
            Console.WriteLine("Enter a number to see if its even/odd: ");
            IsOddOrEven(Convert.ToInt32(Console.ReadLine()));

            //Postive/Negative
            Console.WriteLine("Enter a number to see if its postive/negative: ");
            IsPosOrNeg(Convert.ToInt32(Console.ReadLine()));

            //Voting Age
            Console.WriteLine("Enter your age: ");
            VoteAge(Convert.ToInt32(Console.ReadLine()));
        }
        //Write a method that will print to the console all numbers 1000 through -1000
        public static void PrintNums()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountBy3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void IsEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("NOT Equal");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void IsOddOrEven(int i)
        {
            if (i == 0)
            {
                Console.WriteLine("the number is 0");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void IsPosOrNeg(int i)
        {
            if (i > 0)
            {
                Console.WriteLine("positive");
            }
            else if (i < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("num is 0");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void VoteAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("you can't vote");
            }
        }

        public static void MultTable()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer: ");
                userResponse = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponse);
            for (var x = 1; x <= 12; x++)
        }
      


        

        
    }
}

