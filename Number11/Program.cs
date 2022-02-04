using System;

namespace Number11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            //    Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            //    Sonra cavabin ozunden onun 18 % ni cix;

            Console.Write("Input a 8-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 10000000 && a < 100000000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int remainder = 0;
            int sum = 0;
            while (a > 0)
            {
                remainder = a % 100;
                Console.WriteLine($"Group: {remainder}");
                sum = sum + remainder;  
                a /= 100;   
            }

            Console.WriteLine($"The sum of groups: {sum}");

            double newNumber = sum * 100 + 99;
            Console.WriteLine($"The new number: {newNumber}");

            double result = newNumber - (newNumber * 18 / 100);
            Console.WriteLine($"The result: {result}");
        }
    }
}
