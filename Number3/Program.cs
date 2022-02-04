using System;

namespace Number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi

            Console.Write("Input a 9-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 100000000 && a < 1000000000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int qaliq = 0;
            int sum = 0;
            int counter = 1;
            
            while (a > 0)
            {
                a /= 10;
                counter++;
                if (counter > 3 && counter < 7)
                {
                    qaliq = a % 10;
                    sum = sum + qaliq;  
                }
            }

            Console.WriteLine($"The sum of digits: {sum}");

        }
    }
}
