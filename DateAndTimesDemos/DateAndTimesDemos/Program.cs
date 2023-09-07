internal class Program
{
    private static void Main(string[] args)
    {
        var dateTime = new DateTime(2015, 1, 1);
        var now = DateTime.Now;
        var today = DateTime.Today;

        Console.WriteLine(now.Hour);
        Console.WriteLine(now.Minute);
        Console.WriteLine(now.Second);
        Console.WriteLine(now.Millisecond);

        var tomorrow = now.AddDays(1); //@ curr time
        var yesterday = now.AddDays(-1);

        Console.WriteLine(tomorrow);
        Console.WriteLine(yesterday);
        Console.WriteLine(today);
        Console.WriteLine();

        Console.WriteLine(now.ToLongDateString);
        Console.WriteLine(now.ToShortDateString);
        Console.WriteLine(now.ToLongTimeString);
        Console.WriteLine(now.ToShortTimeString);
        Console.WriteLine(now.ToString());
        Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));      //date time format specifiers

        Console.WriteLine();

        //Creating Timespan Objects
        var timeSpan = new TimeSpan(1, 2, 3);
        var timeSpan1 = new TimeSpan(1, 0, 0);
        var timeSpan2 = TimeSpan.FromHours(1);

        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(2);
        var duration = end - start;
        Console.WriteLine("Duration: " + duration);

        //Timespan Properties
        Console.WriteLine("Minutes: " + timeSpan.Minutes);
        Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

        //Add and Subtract
        Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

        //ToString
        Console.WriteLine("ToString: " + timeSpan.ToString());

        //Parse
        Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

    }
}