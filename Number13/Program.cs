using System;

namespace Number13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) 3 dene 5 reqemli eded var.
            //    Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            //    Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.

            Console.Write("Input the first 5-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            Console.Write("Input the second 5-digits number: ");
            string value2 = Console.ReadLine();
            int b = Convert.ToInt32(value2);

            Console.Write("Input the third 5-digits number: ");
            string value3 = Console.ReadLine();
            int c = Convert.ToInt32(value3);

            bool accepted = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            Console.WriteLine("--------------------------");
            // I eded
            int counter = 0;
            int remainder = 0;
            int number = 0;
            while (a > 0)
            {
                remainder = a % 10;
                counter++;
                a /= 10;
                if (counter == 1 || counter == 5)
                {
                    number = number * 10 + remainder; 
                }
            }

            int remainderFirst = 0;
            int numberFirst = 0;
            while (number > 0)
            {
                remainderFirst = number % 10;
                number /= 10;   
                numberFirst = numberFirst * 10 + remainderFirst;
            }

            Console.WriteLine($"The first new number: {numberFirst}");
            Console.WriteLine("--------------------------");

            // II eded
            int counterR = 0;
            int remainderR = 0;
            int numberR = 0;
            while (b > 0)
            {
                remainderR = b % 10;
                counterR++;
                b /= 10;
                if (counterR == 1 || counterR == 5)
                {
                    numberR = numberR * 10 + remainderR;
                }
            }

            int remainderSecond = 0;
            int numberSecond = 0;
            while (numberR > 0)
            {
                remainderSecond = numberR % 10;
                numberR /= 10;
                numberSecond = numberSecond * 10 + remainderSecond;
            }

            Console.WriteLine($"The second new number: {numberSecond}");
            Console.WriteLine("--------------------------");


            // III eded
            int counterRR = 0;
            int remainderRR = 0;
            int numberRR = 0;
            while (c > 0)
            {
                remainderRR = c % 10;
                counterRR++;
                c /= 10;
                if (counterRR == 1 || counterRR == 5)
                {
                    numberRR = numberRR * 10 + remainderRR; 
                }
            }

            int remainderThird = 0;
            int numberThird = 0;
            while (numberRR > 0)
            {
                remainderThird = numberRR % 10;
                numberRR /= 10;   
                numberThird = numberThird * 10 + remainderThird;
            }

            Console.WriteLine($"The third new number: {numberThird}");
            Console.WriteLine("--------------------------");
            
            double sum = numberFirst + numberSecond + numberThird;
            Console.WriteLine($"Sum of new numbers: {sum}");

            Console.WriteLine("--------------------------");

            double result = (sum * 50 / 100) + sum;
            Console.WriteLine($"Result: {result}");

        }
    }
}
