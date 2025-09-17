// My first C# math demo project - Created by antep, September 2025
// This demonstrates basic math operations and is ready for GitHub with DevOps elements.
using System;
namespace MathDemo
{
 class Program
    {
        static void Main(string[] args)
        {
            /* 
             * This program performs simple math operations:
             * 1. Gets the absolute value of a negative number.
             * 2. Rounds it to 2 decimal places.
             * 3. Calculates the difference from Math.PI.
             */

            // Step 1: Calculate the absolute value of -3.556831
            double positiveValue = Math.Abs(-3.556831);
            // Output the positive value
            Console.WriteLine(positiveValue);
            // Step 2: Round the value to 2 decimal places
            double roundedValue = Math.Round(positiveValue, 2);
            // Output the rounded value
            Console.WriteLine(roundedValue);
            // Step 3: Calculate the absolute difference between rounded value and PI
            double difference = Math.Abs(Math.PI - roundedValue);
            // Output the difference
            Console.WriteLine(difference);
            // Pause the console so it doesn't close immediately
            Console.ReadLine();

          }
         }
        }
