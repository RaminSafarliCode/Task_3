using System;

namespace Number5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.

            Console.Write("Input a 6-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 100000 && a < 1000000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int firstDigit = a / 100000;

            int number = a - firstDigit * 100000;

            int newNumber = number * 10 + firstDigit;
            Console.WriteLine($"New number: {newNumber}");
        }
    }
}
