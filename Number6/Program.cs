using System;

namespace Number6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et

            Console.Write("Input a 8-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 10000000 && a < 100000000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int firstDigit = a / 10000000;
            int lastDigit = a % 10;

            int newNumber = ((a - firstDigit * 10000000) - lastDigit) / 10;

            Console.WriteLine($"The new number: { newNumber}");
        }
    }
}
