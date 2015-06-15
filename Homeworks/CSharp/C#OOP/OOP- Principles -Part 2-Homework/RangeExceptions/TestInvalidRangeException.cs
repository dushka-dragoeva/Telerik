﻿/*Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].*/

namespace RangeExceptions
{
    using System;
    using System.Globalization;
    using System.Threading.Tasks;

    class TestInvalidRangeException
    {
        static void Main()
        {
            var numbers = new int[] { -335, 7, 1099 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                if (numbers[i] < 0 || numbers[i] > 100)
                {
                    try
                    {
                        throw new InvalidRangeException<int>("Invalid input!", 1, 100);

                    }
                    catch (InvalidRangeException<int> e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine();
                }
            }
            //Console.WriteLine("Enter  date in format dd/MM/yyyy");
            //DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            DateTime date = new DateTime(1945, 03, 05);
            DateTime start = new DateTime(1980, 01, 01);
            DateTime end = new DateTime(2013, 12, 31);

            if(date<start ||date>end)
            {
                try
                {
                    throw new InvalidRangeException<DateTime>("Invalid input!", new DateTime(1980, 01, 01), new DateTime(2013, 12, 31));

                }
                catch (InvalidRangeException<DateTime> e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}