using System;

namespace Number4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4) verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati

            Console.Write("Input a 5-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 10000 && a < 100000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int counter = 1;
            int qaliq = 0;
            int sum = 0;

            while (a>0)
            {
                if (counter == 1 || counter == 5)
                {
                    qaliq = a % 10;
                    sum = sum + qaliq;
                }

                counter++;
                a /= 10;    
            }

            double sumNew = Math.Pow(sum, 2);
            Console.WriteLine($"The square of the sum of first and last digits: {sumNew}");
        }
    }
}
