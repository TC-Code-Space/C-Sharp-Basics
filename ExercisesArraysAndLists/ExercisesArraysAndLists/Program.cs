internal class Program
{
    private static void Main(string[] args)
    {
        //Exercise 1
        List<string> names = new List<string>();
        
        while (true)
        {
            Console.WriteLine("Enter a name: ");
            string input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                break;
            }
            names.Add(input);
        }

        switch (names.Count)
        {
            case 0:
                break;
            case 1:
                Console.WriteLine("{0} likes your post.", names[0]);
                break;
            case 2:
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
                break;
            default:
                Console.WriteLine("{0}, {1}, and {2} others like your post.", names[0], names[1], names.Count-2);
                break;
        }

        //Exercise 2
        Console.WriteLine();
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        char[] reverseName = name.ToCharArray();
        Array.Reverse(reverseName);
        string reversedName = new string(reverseName);
        Console.WriteLine(reversedName, name);


        //Exercise 3
        Console.WriteLine();
        Console.WriteLine("Enter 5 different numbers: ");
        int[] userNums = new int[5];
        int count = 0;
        while(true)
        {
            int userNum = Convert.ToInt32(Console.ReadLine());
            if (userNums.Contains(userNum))
            {
                Console.WriteLine("Error: previously entered number. Please input another number: ");
                continue;
            }
            userNums[count++] = userNum;
            if(count == 5) { break; }
        }
        Array.Sort(userNums);
        for (int i = 0; i< 5; i++)
        {
            Console.Write("{0} ", userNums[i]);
        }

        //Exercise 4
        Console.WriteLine();
        List<int> numbers = new List<int>();    
        while(true)
        {
            Console.WriteLine("Enter a number or \"Quit\" to exit: ");
            var input = Console.ReadLine();
            if (input.Equals("Quit") || input.Equals("quit"))
            {
                break;
            } 
            else 
            {
                numbers.Add(Convert.ToInt32(input));
            }
        }
        List<int> distinctNums = numbers.Distinct().ToList();

        foreach (int i in distinctNums)
        {
            Console.Write("{0} ", i);
        }
        //Exercise 5
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("Supply a list of comma seperated numbers (e.g 5, 4, 3, 5, 4) ");
            string line = Console.ReadLine();
            if (String.IsNullOrEmpty(line) || line.Length < 13)
            {
                Console.WriteLine("Invalid List. Retry.");
                continue;
            }
            char[] delimiters = { ' ', ',' };
            string[] values = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(values);
            List<string> distinct = values.Distinct().ToList();
            for(int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", distinct[i]);
            }
            break;

        }

    }
}