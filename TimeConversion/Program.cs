using System;

namespace TimeConversion
{
    public class TimeConversion
    {
        public static void Main(string[] args)
        {

            //DateTime time = DateTime.Parse(s);
            //return time.ToString("HH:mm:ss"); 

            Console.WriteLine("Enter the date string\n");

            string? str = Console.ReadLine();

            ConverTime(str);

        }
            public static void ConverTime(string str)
            {
                DateTime time = DateTime.Parse(str);
                Console.WriteLine(time.ToString("HH:mm:ss"));
            }

       
    }
}