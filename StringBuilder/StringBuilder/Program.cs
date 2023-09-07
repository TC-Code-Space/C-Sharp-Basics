
using System.Text;

class Program
{
     static void Main(string[] args)
    {
        var builder = new StringBuilder("Hello World");
        //you can chain build
        builder.Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10);
        Console.WriteLine(builder);
        Console.WriteLine();

        builder.Replace('-', '+');
        Console.WriteLine(builder);
        Console.WriteLine();
        
        builder.Remove(0, 10);
        Console.WriteLine(builder);
        Console.WriteLine();
        
        builder.Insert(0, new string('-', 10));
        Console.WriteLine(builder);

        Console.WriteLine("First Character: " + builder[0]);
    }
}