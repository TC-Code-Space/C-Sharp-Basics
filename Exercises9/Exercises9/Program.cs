using System.Text.RegularExpressions;

namespace Exercises9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var path = @"C:\Users\tcrawford\source\repos\Exercises9\Exercises9\demoText.txt";

            var content = File.ReadAllText(path);
            Console.WriteLine(content);
            var words = Regex.Matches(content, @"\b\w+\b");
            
            var count = words.Count();
            Console.WriteLine("\nWord Count: " + count);

            var longestWord = "a";

            foreach ( var word in words )
            {
                var length = word.ToString().Length;

                if (longestWord.Length > length)
                {
                    continue;
                }
                longestWord = word.ToString();
            }
            Console.WriteLine("\nLongest Word: " + longestWord);

        }
    }

}