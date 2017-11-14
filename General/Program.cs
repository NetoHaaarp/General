using System;
namespace prog
{
    class General
    {
        public static void Main(String[] args)
        {
            double x1 = 0;
            double x2 = 0;
            Console.WriteLine("Formula General");
            Console.WriteLine("Inserte a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte c");
            double c = double.Parse(Console.ReadLine());
            c = ((b * b) - (4) * (a) * (c));
            if (c < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                c = Math.Sqrt(c);
                x1 = (((-1) * (b)) + c) / (2 * (a));
                x2 = (((-1) * (b)) - c) / (2 * (a));
                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            Console.ReadKey();
        }

    }
}
