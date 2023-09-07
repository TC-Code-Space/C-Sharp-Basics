

namespace StringDemos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fullName = "Bobby Singer ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            fullName.Replace("Bobby", "Bob");
            fullName.Replace('o', 'O');
            fullName.Replace(' ', '-');
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.Replace("Bobby", "Bob"));

            if (String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");
            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");


            //Conversions

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));

            //Text

            var sentence = "This is going to be a really really really reallly really long text.";
            var summary = SummarizeText(sentence);
            Console.WriteLine(summary);

        }
        static string SummarizeText(string sentence, int maxLength = 20) //set default value if not passed
        {
            if (sentence.Length < maxLength)
                return sentence;
            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }



}
