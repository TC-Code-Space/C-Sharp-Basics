namespace Exercises { 

    class Program
    {
        public static void Main(string[] args)
        {
            //exercise 1
            Console.WriteLine("Enter a number between 1 and 10: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            if(userNumber <= 10 &&  userNumber > 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //exercise 2
            Console.WriteLine("Enter in 2 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2);
            int max = Math.Max(num1, num2);
            Console.WriteLine("Max: {0}", max);

            //exercise 3
            Console.WriteLine("Enter the width of your image: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of your image: ");
            int height = Convert.ToInt32(Console.ReadLine());
            string orientation;

            if(width > height)
            {
                orientation = "landscape";
            } 
            else
            {
                orientation = "portrait";
            }

            Console.WriteLine("Your image is in {0} orientation", orientation);


            //exercise 4
            Console.WriteLine("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the speed of the car? ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            bool isSpeeding = (carSpeed > speedLimit) ? true : false;
            
            if(isSpeeding)
            {
                double demeritPoints = Math.Ceiling((double)(carSpeed - speedLimit)/5);
                if(demeritPoints > 12) 
                {
                    Console.WriteLine("License Suspended - Demerit Points = {0}", demeritPoints);
                }
                else
                {
                    Console.WriteLine("Demerit Points = {0}", demeritPoints);
                }
            }
            
        }
    }

}
