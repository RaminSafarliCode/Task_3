using System;

namespace Number14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            //    6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            //    Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            //    Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            //    Neticenin 60 % tap.Cavabin axirina 60 artir.
            //    Neticeden 18 % cix.

            Console.Write("Input a 6-digits number: ");
            string value = Console.ReadLine();
            int a = Convert.ToInt32(value);

            Console.Write("Input a 6-digits number: ");
            string value2 = Console.ReadLine();
            int b = Convert.ToInt32(value2);

            Console.Write("Input a 6-digits number: ");
            string value3 = Console.ReadLine();
            int c = Convert.ToInt32(value3);

            Console.Write("Input a 7-digits number: ");
            string value4 = Console.ReadLine();
            int d = Convert.ToInt32(value4);


            bool accepted = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 1000000 && d < 10000000;
            if (!accepted)
            {
                Console.WriteLine("Invalid number");

                return;
            }

            // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.

            int newFirst = a / 1000;
            int newSecond = b / 1000;
            int newThird = c / 1000;

            int sumNew = newFirst + newSecond + newThird;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"The result of first part: {sumNew}");
            Console.WriteLine("-----------------------------------");

            //    Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            
            int counter = 1;
            int remainder = 0;
            int yeniEded = 0;
            int eded = d;
            while (counter < 5)
            {
                remainder = eded % 10;
                eded /= 10;
                yeniEded = yeniEded * 10 + remainder;
                counter++;
            }

            int newNumber = 0;
            while (yeniEded > 0)
            {
                remainder = yeniEded % 10;
                yeniEded /= 10;
                newNumber = newNumber * 10 + remainder;
            }

            int result2 = sumNew + newNumber;
            Console.WriteLine($"The result of second part: {result2}");
            Console.WriteLine("-----------------------------------");

            //    Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            
            counter = 1;
            int hasil = 1;
            while (d > 0)
            {
                if (counter > 4)
                {
                    remainder = d % 10;
                    hasil = hasil * remainder;
                }
                d /= 10;

                counter++;
                
            }
            Console.WriteLine($"The multiplication of first three digit of 7-digits number: {hasil}");

            double result3 = result2 - hasil;
            Console.WriteLine($"The result of third part: {result3}");
            Console.WriteLine("-----------------------------------");

            //    Neticenin 60 % tap.Cavabin axirina 60 artir.

            double percent = (result3 * 60 / 100) * 100 + 60;
            Console.WriteLine($"The result of fourth part: {percent}");
            Console.WriteLine("-----------------------------------");


            //    Neticeden 18 % cix.

            double finalResult = percent - (percent * 18 / 100);
            Console.WriteLine($"The result of last part: {finalResult}");
        }
    }
}
