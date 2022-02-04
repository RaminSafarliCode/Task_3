using System;

namespace Number1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) verilmish 4 reqemli ededin reqemlerinin cemini tap

            Console.Write("Input a 4-digits number: ");
            string value = Console.ReadLine();  
            int a = Convert.ToInt32(value);

            bool accepted = a >= 1000 && a < 10000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }
            
            int sum = 0;
            int qaliq = 0;

            while (a > 0)
            {
                qaliq = a % 10;
                sum = sum + qaliq;
                a = a / 10;
            }

            Console.WriteLine($"The sum of digits: {sum}");
        }
    }
}
