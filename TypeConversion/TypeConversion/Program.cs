using System;
namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/byte b = 1;
            //int i = b;                  //implicit
            
            int i = 1000;                  
            byte b2 = (byte) i;          //casting - explicit
            
            Console.WriteLine(i);
            Console.WriteLine(b2);
            */
            /*
            try
            {
                var number = "1234";
                byte i = Convert.ToByte(number);
                Console.WriteLine(number);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
                throw;
            }
            */

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad conversion");
                throw;
            }
            


           
        }
    }
}

