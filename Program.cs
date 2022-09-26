using System;
using System.Diagnostics;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

/*
 * Implementation Project
 * Software Engineering 1
 *
 * Christian Calhoun
 * Micah Crawford
 * Victoria Dixon 
 * Drew Dorris
 * Amanda Lee
 */
namespace Project1
{
    class Program
    {
        /*
         * Start of program
         */
        public static void Main(string[] args)
        {
            string twoNums = Console.ReadLine(); // get both inputted numbers
            if (twoNums == null) {
                Console.WriteLine("Unknown input!");
                return;
            }

            string[] nums = twoNums.Split(' ');
            if (nums.Length < 2) {
                Console.WriteLine("Not enough numbers inputted!");
                return;
            }
            // get parsed versions of both inputted numbers
            int firstNum = Int32.Parse(nums[0]);
            int secondNum = Int32.Parse(nums[1]);

            // add both and input to recursive method
            int added = firstNum + secondNum;
            Console.WriteLine("Added together: " + added);
            int result = GetLastDigitAddedWithRestOfNum(added);

            Console.WriteLine("Result is " + result);
            return;
        }

        // Recursive method which
        public static int GetLastDigitAddedWithRestOfNum(int num) {
            // This retrieves the last digit of he number
            int lastDigit = num % 10;
            // This is the inputted number with the last digit removed. Reduce it by a factor of 10 and remove the last number.
            // Example
            // 953 ---> (953 - 3) / 10 ---> 95
            num = (num - lastDigit) / 10;
            // This would mean that the inputted number was a single digit or less than 10.
            // Therefore we are done!
            if (num <= 0) {
                return lastDigit;
            }

            int added = lastDigit + num;
            if (added < 10) {
                // It's a single digit, so we're done!
                return added;
            }
            Console.WriteLine("Currently at " + added);
            return GetLastDigitAddedWithRestOfNum(added);
        }

    }
}
