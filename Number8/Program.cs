using System;

namespace Number8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Verilmis ededdin axirdan 3 - cu reqemi ile sonuncu reqeminin cemini tap

            Console.Write("Input a number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            int counter = 1;
            int remainder = 0;
            int sum = 0;
            while (a > 0)
            {
                remainder = a % 10;
                a = a / 10;
                if (counter == 1 || counter == 3)
                {
                    sum = sum + remainder;
                }
                counter++;
            }

            Console.WriteLine($"The result: {sum}");
        }
    }
}
