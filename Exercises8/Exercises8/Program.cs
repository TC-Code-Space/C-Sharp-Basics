using System.Runtime;
using System.Text;

namespace Exercises8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //Exercise 1
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            string[] asciiNums = input.Split('-');
            int[] numberSequence = Array.ConvertAll(asciiNums, int.Parse);
            bool isSequential = true;
            for (int i = 0; i < numberSequence.Count(); i++)
            {
                if (i + 1 == numberSequence.Count())
                {
                    break;
                }
                if (Math.Abs(numberSequence[i] - numberSequence[i + 1]) == 1)
                {
                    continue;
                }
                isSequential = false;
            }

            Console.WriteLine(isSequential ? "Consecutive" : "Not Consecutive");

            //Exercise 2
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input2 = Console.ReadLine();
            if (!String.IsNullOrEmpty(input2))
            {
                string[] inputNums = input2.Split('-');
                int[] duplicateSequence = Array.ConvertAll(inputNums, int.Parse);
                var dict = new Dictionary<int, int>();

                foreach (var num in duplicateSequence)
                {
                    if (dict.ContainsKey(num))
                    {
                        dict[num]++;
                        if (dict[num] > 1)
                        {
                            Console.WriteLine("Duplicate");
                            break;
                        }
                    }
                    else
                    {
                        dict[num] = 1;
                    }
                }
            }

            //Exercise 3
            Console.WriteLine("Enter a time in 24 hour format (e.g 19:00): ");
            string time = Console.ReadLine();
            bool hour = false;
            bool minute = false;
            if (!String.IsNullOrEmpty(time))
            {
                Console.WriteLine("Invalid");
            }
            int[] parsedTime = Array.ConvertAll(time.Split(':'), int.Parse);
            if (parsedTime[0] < 24 && parsedTime[0] >= 0)
            {
                hour = true;
            }
            if (parsedTime[1] < 59 && parsedTime[1] >= 0)
            {
                minute = true;
            }

            if (!hour || !minute)
            {
                Console.WriteLine("Invalid Time");
            }
            
            //Exercise 4
            Console.WriteLine("Enter a few words separated by a space: ");
            String input4 = Console.ReadLine();
            if (!String.IsNullOrEmpty(input4))
            {
                string[] words = input4.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                StringBuilder sb = new StringBuilder();
                foreach(string word in words )
                {
                    string lowerCase = word.ToLower();
                    string pascalCase = (char)(lowerCase[0]-32) + lowerCase[1..];
                    sb.Append(pascalCase);
                }
                Console.WriteLine(sb);
            }

            //Exercise 5
            Console.WriteLine("Enter an english word for the count of vowels: ");
            string input5 = Console.ReadLine();
            if (!String.IsNullOrEmpty(input5))
            {
                int count = 0;
                foreach (char letter in input5)
                {
                    switch(letter)
                    {
                        case 'A':
                        case 'a':
                        case 'E':
                        case 'e':
                        case 'I':   
                        case 'i':
                        case 'O':
                        case 'o':
                        case 'U':
                        case 'u':
                            count++;
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine(count);
            }


        }
    }
}
