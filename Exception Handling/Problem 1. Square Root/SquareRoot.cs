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
                string input = Console.ReadLine();

                if (input == null)
                {
                    throw new NullReferenceException();
                }

                int number = int.Parse(input);

                if (number < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (System.FormatException)
            {
                Console.Error.Write("Expected valid integer number\r\n");
            }
            catch (OverflowException)
            {
                Console.Error.Write("Number was too large, please try again with different/smaller number.\r\n");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Number must not be negative.\r\n");
            }
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
