using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = new[] { 3, 24, 5, 14, 7, 23, 45, 22, 99, 41, 33, 67, 83, 72 };

        //Length
        Console.WriteLine("LengthL: " + numbers.Length);

        //IndexOf()
        var index = Array.IndexOf(numbers, 14);
        Console.WriteLine("Index: " + index);

        //Clear()
        Array.Clear(numbers, 0, 2);
        //Clear sets:
        //ints to zero
        //bools to false
        //objects to null
        Console.WriteLine("Effect of clear: ");
        printArr(numbers);

        //Copy()
        int[] another = new int[5];
        Array.Copy(numbers, another, 5);

        Console.WriteLine("Effect of copy:");
        printArr(another);

        //Sort()
        Array.Sort(numbers);
        Console.WriteLine("Effect of sort: ");
        printArr(numbers);

        //Reverse()
        Array.Reverse(numbers);
        Console.WriteLine("Effect of reverse: ");
        printArr(numbers);

    }

    public static void printArr(int[] numbers)
    {
        foreach(var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}