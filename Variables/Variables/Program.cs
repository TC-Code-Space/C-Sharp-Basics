using System;

namespace Variables
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //FORMAT STRING
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.1415f;
            Pi = 34;                    //note error

            /*
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = true;
            */

            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Mosh";
            var isWorking = true;


            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(character);
            Console.WriteLine(isWorking);
        }
    }
}
