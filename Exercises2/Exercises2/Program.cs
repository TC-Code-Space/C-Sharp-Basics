namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //Exercise 1
            int count = 0;
            for(var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count += 1;
            }
            Console.WriteLine(count);

            Console.WriteLine();

            //Exercise 2
            int sum = 0;
            while(true)
            {
                Console.WriteLine("Enter a number or \"ok\" to exit: ");
                var input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        sum += Convert.ToInt32(input);
                    }
                    catch (Exception)
                    {
                        if (input.Equals("ok"))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Bad Input. Enter number or \"ok\"");
                        }
                    }
                }
            }
            Console.WriteLine(sum);

            Console.WriteLine();

            //Exercise 3
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", number, Factorial(number));

            Console.WriteLine();

            //Exercise 4
            Random random = new Random();
            int rand = random.Next(1, 10);
            Console.WriteLine(rand);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == rand)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if(i == 3)
                {
                    Console.WriteLine("You Lost!");
                }
            }
           
            Console.WriteLine();

            //Exercise 5
            Console.WriteLine("Enter a series of numbers separated by a comma: ");
            string line = Console.ReadLine();
            string[] values = line.Split(',');
            int max = 0;

            foreach(string num in values)
            {
                int intNum = Convert.ToInt32(num);
                if (intNum > max)
                {
                    max = intNum;
                }
            }
            Console.WriteLine(max);

        }

        //Execise 3 method
        static int Factorial(int number)
        {
            if(number == 1)
            {
                return number;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }

}
