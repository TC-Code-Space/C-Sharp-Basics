
namespace RandomClass
{

    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
            {
                //Console.WriteLine(random.Next());
                //Console.WriteLine(random.Next(1, 10);
                //Console.Write((char)random.Next(97, 122));
                //Console.WriteLine((char)('a' + random.Next(0, 26)));
                buffer[i] = (char)('a' + random.Next(0, 26));

            }

            var password = new string(buffer);
            Console.WriteLine(password);
            //Console.WriteLine((int)'a');
        }
    }
}
