using System;

namespace Number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2) verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3

            Console.Write("Input a 6-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 100000 && a < 1000000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int qaliq = 0;
            int sum = 0;
            int counter = 1;
            while (a>0)
            {
                a /= 10;    
                counter++;

                if (counter > 3)
                {
                    qaliq = a % 10;
                    sum = sum + qaliq;
                }
            }

            Console.WriteLine($"The sum of digits: {sum}");
        }
    }
}
