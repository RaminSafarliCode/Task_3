using System;

namespace Number12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) 2 dene 5 reqemli eded daxil et.
            //    I ededin reqemleri ceminin usutne
            //    II ededin reqemleri hasilini gel.
            //    Neticenin axirina I ededin en axiinci reqemini artir.

            Console.Write("Input the first 5-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            Console.Write("Input the second 5-digits number: ");
            string value2 = Console.ReadLine();
            int b = Convert.ToInt32(value2);

            bool accepted = a >= 10000 && a < 100000 && b >= 10000 && b < 100000;

            if (!accepted)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            // I ededin reqemlerinin cemi
            int remainder = 0;
            int sum = 0;
            int numberFirst = a;
            while (numberFirst > 0)
            {
                remainder = numberFirst % 10;
                sum = sum + remainder;
                numberFirst /= 10;
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"The sum of digits of first number: {sum}");
            Console.WriteLine("-----------------------------------------");

            // II ededin reqemlerinin hasili
            int remainderR = 0;
            int hasil = 1;
            while (b > 0)
            {
                remainderR = b % 10;
                hasil = hasil * remainderR;    
                b /= 10;
            }

            Console.WriteLine($"The multiplication of digits of second number: {hasil}");
            Console.WriteLine("-----------------------------------------");

            int z = sum + hasil;
            Console.WriteLine($"The sum of results: {z}");
            Console.WriteLine("-----------------------------------------");

            // I ededin en axirinci reqeminin elave olunmasi
            int lastDigit = a % 10;
            int result = z * 10 + lastDigit;
            Console.WriteLine($"The result: {result}");

        }
    }
}
