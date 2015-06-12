/*
    Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
    If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100.
    If the user enters an invalid number, let the user to enter again.
 */

using System;

namespace Problem_2.Enter_Numbers
{
    internal class EnterNumbers
    {
        // ERRORS (CLIENT)
        private const string NullArgumentErr = "START/END cannot be NULL.";
        private const string InvalidArgumentFormatErr = "START/END must be a valid integer number.";
        private const string OutOfRangeArgumentErr = "Input was out of range.";

        // PRINT ERROR (CLIENT)
        public static void PrintError(string messageError)
        {
            if (string.IsNullOrEmpty(messageError))
            {
                throw new ArgumentNullException();
            }

            Console.Clear();
            Console.Error.WriteLine("Error: {0}\r\n", messageError);
        }

        // READ NUMBERS METHOD
        public static int ReadNumber(int start, int end)
        {
            // IF START IS GREATER/EQUAL THAN END -> THROW EXCEPTION
            if (start >= end)
            {
                throw new ArgumentOutOfRangeException();
            }

            //GET INPUT
            var input = Console.ReadLine();

            // IF INPUT IS NULL -> THROW EXCEPTION
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            //INIT NUMBER
            int number;

            // IF INPUT IS NOT PARSABLE TO INTEGER NUMBER (number) -> THROW EXCEPTION
            if (!int.TryParse(input, out number))
            {
                throw new FormatException();
            }

            // IF NUMBER IS NOT IN RANGE -> THROW EXCEPTION
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }

            // IF NUMBER IS THE NUMBER BEFORE END -> THROW EXCEPTION
            if (number + 1 > end)
            {
                throw new OverflowException();
            }

            // RETURN NUMBER
            return number;
        }

        // VALIDATE RANGES
        public static void ValidateRanges(int start, int end, int maxEntries)
        {
            // IF RANGES INIT IS NOT VALID (DEVELOPER)
            if (start + 1 >= end)
            {
                throw new ArgumentException("Start cannot be equal to/greater than END.");
            }
        }

        // MAIN
        public static void Main(string[] args)
        {
            // RANGES INIT
            int start = 1,
                end = 100,
                maxEntries = 10;

            // VALIDATE RANGES (DEVELOPER)
            ValidateRanges(start, end, maxEntries);

            // ASK FOR NUMBER WHILE MAX ENTRIES LEFT
            do
            {
                try
                {
                    // COUNT ENTRIES LEFT (DEPENDS OF CURRENT NUMBER COMPARED TO RANGE)
                    if (start + maxEntries > end)
                    {
                        Console.WriteLine("Entries left: {0}\r\n", (end - start) - 1);
                    }
                    // COUNT ENTRIES LEFT
                    else
                    {
                        Console.WriteLine("Entries left: {0}\r\n", maxEntries);
                    }

                    // IF START IS THE NUMBER BEFORE RANGE END
                    if (start + 2 == end)
                    {
                        Console.WriteLine("You can choose only [ {0} ]", end - 1);
                    }
                    // IF RANGE END IS NOT CLOSE
                    else if (start + 1 < end)
                    {
                        Console.WriteLine("Type a number in range [ {0} - {1} ]", start + 1, end - 1);
                    }
                    // IF REACHED THE RANGE END
                    else
                    {
                        Console.WriteLine("You have reached the RANGE END.\r\n");
                        break;
                    }

                    // READ NUMBER
                    var number = ReadNumber(start, end);

                    // CHANGE NEXT START TO CURRENT NUMBER
                    start = number;

                    // DECERASE MAX ENTRIES
                    maxEntries--;
                    Console.Clear();
                }
                // CATCH EXCEPTIONS
                catch (ArgumentNullException)
                {
                    // NULL
                    PrintError(NullArgumentErr);
                }
                catch (FormatException)
                {
                    // FORMAT
                    PrintError(InvalidArgumentFormatErr);
                }
                catch (ArgumentOutOfRangeException)
                {
                    // OUT OF RANGE
                    PrintError(OutOfRangeArgumentErr);
                }
            } while (maxEntries > 0);
        }
    }
}