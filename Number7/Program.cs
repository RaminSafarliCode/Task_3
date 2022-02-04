using System;

namespace Number7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir

            Console.Write("Input a 4-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 1000 && a < 10000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int remainder = 0;
            int reverse = 8;
            int counter = 1;
            while (a>0)
            {
                remainder = a % 10;
                reverse = reverse * 10 + remainder;
                a /= 10;  
                counter++;
                if (counter == 5)
                {
                    reverse = reverse * 10 + 8;
                }
            }

            Console.WriteLine($"The new number: {reverse}");
        }
    }
}
