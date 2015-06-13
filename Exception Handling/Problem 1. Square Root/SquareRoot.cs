/*
    Write a program that reads an integer number and calculates and prints its square root.
    If the number is invalid or negative, print "Invalid number". 
    In all cases finally print "Good bye". Use try-catch-finally.
*/

﻿namespace Problem_1.Square_Root
{
    using System;

    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                // GET INPUT FROM CONSOLE
                string input = Console.ReadLine();

                // IF INPUT IS NULL
                if (input == null)
                {
                    throw new NullReferenceException();
                }

                // PARSE INPUT TO INTEGER NUMBER
                int number = int.Parse(input);

                // IF THE NUMBER IS SMALLER THAN 1
                if (number < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // PRINT THE SQARE ROOT OF NUMBER
                Console.WriteLine(Math.Sqrt(number));
            }
            // CATCH EXCEPTIONS
            catch (System.FormatException)
            {   // FORMAT$
                Console.Error.Write("Expected valid integer number\r\n");
            }   // OVERFLOW
            catch (OverflowException)
            {
                Console.Error.Write("Number was too large, please try again with different/smaller number.\r\n");
            }   // OUT OF RANGE
            catch (ArgumentOutOfRangeException)
            {   // NEGATIVE NUMBER
                Console.Error.WriteLine("Number must not be negative.\r\n");
            }   // NULL
            catch (NullReferenceException)
            {
                Console.Error.Write("Cannot calculate square root of NULL.\r\n");
            }
            finally
            {
                Console.WriteLine("Good bye.\r\n");
            }
        }
    }
}
