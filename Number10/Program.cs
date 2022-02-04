using System;

namespace Number10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            //     sonra cut yerde dayanlarinda bir eded duzlet,
            //     sonra onlari topla

            Console.Write("Input a 9-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            bool accepted = a >= 100000000 && a < 1000000000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            // Tek yerde dayananlar
            
            int counter = 1;
            int number = 0;
            int remainder = 0;
            int nineDigit = a;
            
            while (nineDigit > 0)
            {
                remainder = nineDigit % 10;
                nineDigit = nineDigit / 10;

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

            Console.WriteLine($"The number in odd places: {newNumber}");
            
            // Cut yerde dayananlar

            int counterR = 0;
            int numberR = 0;
            int remainderR = 0;

            while (a > 0)
            {
                remainderR = a % 10;    
                a = a / 10;

                if (counterR % 2 != 0)
                {
                    numberR = numberR * 10 + remainderR;
                }
                counterR++;
            }

            int remainderRNew = 0;
            int newWNumber = 0;

            while (numberR > 0)
            {
                remainderRNew = numberR % 10;
                numberR = numberR / 10; 

                newWNumber = newWNumber * 10 + remainderRNew;
            }

            Console.WriteLine($"The number in even places: {newWNumber}");

            // cem
            
            int result = newNumber + newWNumber;

            Console.WriteLine($"The result: {result}");

        }
    }
}
