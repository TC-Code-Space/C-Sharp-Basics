using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public class People
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            Console.WriteLine("\n\nArrays\n");

            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            flags[1] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "john", "mary" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);


            Console.WriteLine("\n\nStrings \n");

            //no difference
            string firstName = "Mosh";
            String lastName = "Hammy";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var formattedNames = string.Join(", ", names);

            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(formattedNames);

            var text = @"Hi Mosh
Look at this:
             c:\folder1\folder2";
            Console.WriteLine(text);

            Console.WriteLine("\n\nEnums\n");

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //int to enum
            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            //String to enum
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

            //Memory Examples
            Console.WriteLine("\n\nMemory examples\n");
            var a = 1;
            var b = a;
            b++;
            Console.WriteLine(string.Format("A: {0} B: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine("Array 1[0]: {0}, Array 2[0]: {1}", array1[0], array2[0]);

            //Reference Person example
            Console.WriteLine("\n\nPerson Class Age\n");
            var num = 1;
            Increment(num);
            Console.WriteLine(num);     //note how it did not become 11

            var people = new People() { Age = 20 };
            MakeOld(people);
            Console.WriteLine(people.Age);  //note how age became 30

        }

        //Reference Person example methods
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(People people)
        {
            people.Age += 10;
        }

    }
}