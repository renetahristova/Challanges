using System;

namespace Staircase_Challange
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("N = ");
            int stairs = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number of ways = {countWays(stairs)}");
        }
        /*There's a staircase with N steps, and you can climb 1 or 2 steps at a time.
        Given N, write a function that returns the number of unique ways you can climb the staircase.*/
        static int findSteps(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            int result = findSteps(n - 1) + findSteps(n - 2);
            return result;

        }

        static int countWays(int stairs)
        {
            //the value of ways(n) is equal to fibonacci(n+1)
            return findSteps(stairs + 1);
        }

        /* What if, instead of being able to climb 1 or 2 steps at a time, you could climb any number from a set of positive integers X?
         For example, if X = {1, 3, 5}, you could climb 1, 3, or 5 steps at a time. 
         Generalize your function to take in X*/  
    }

}
