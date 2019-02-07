using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the base and height of your triangle.");
            Console.WriteLine("Enter base");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = Convert.ToInt32(Console.ReadLine());
            double area = 0.5 * bas * height;
            Console.Clear();
            Console.WriteLine("Base = "+bas);
            Console.WriteLine("Height = "+height);
            Console.WriteLine( ""+ 
                $"The area is {area} metres squared");
            Console.ReadKey();

        }
    }
}