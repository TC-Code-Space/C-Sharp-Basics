internal class Program
{
    private static void Main(string[] args)
    {
        //For loops
        for (var i = 1; i <= 10;  i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("");

        for (var i = 10; i >= 1; i--)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("");

        //ForEach
        var name = "John Smith";

        for(var i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }

        Console.WriteLine("");

        foreach (var character in name)
        {
            Console.WriteLine(character);
        }

        Console.WriteLine("");

        var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

        foreach(var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("");

        //While Loops
        var j = 1;
        while (j <= 10)
        {
            if(j % 2 != 0)
            {
                Console.WriteLine(j);
            }
            j++;
        }

        //break

        while (true)
        {
            Console.WriteLine("Type your name: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                break;
            }

        }

        //continue

        while (true)
        {
            Console.WriteLine("Type your name: ");
            var input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Echo: " + input);
                continue;
            }

            break;
        }

    }
}