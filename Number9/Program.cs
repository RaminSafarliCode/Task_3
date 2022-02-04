using System;

namespace Number9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389 = 12439

            Console.Write("Input a 9-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 100000000 && a < 1000000000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            
            int counter = 1;
            int number = 0;
            int remainder = 0;
            
            while (a > 0)
            {
                remainder = a % 10;
                a = a / 10;

                if (counter % 2 != 0)
                {
                    number = number * 10 + remainder;
                }
                counter++;
            }

            int remainderNew = 0;
            int newNumber = 0;

            while (number > 0)
            {
                remainderNew = number % 10; 
                number = number / 10;

                newNumber = newNumber * 10 + remainderNew;  
            }

            Console.WriteLine($"The result: {newNumber}");
        }
    }
}
