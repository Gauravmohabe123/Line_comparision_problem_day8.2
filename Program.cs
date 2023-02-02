using System;
using System.Buffers.Text;

namespace Line_Comp_Prob
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Get ran = new Get();
            ran.equal();
            
        }

        
        class Get
        {
            public  void equal()
            {
                double one = 0;
                double two = 0;
                for (int i = 1; i <= 2; i++)

                {
                    if (i == 1)
                    {
                        Console.WriteLine("Enter the value for first line:");
                        double LenghtofLine = line();
                        Console.WriteLine(one + " Leangth of one line  and leangth of two ");
                        one = LenghtofLine;
                    }
                    else
                    {
                        Console.WriteLine("Enter the value of second line");
                        double LenghtofLine = line();
                        Console.WriteLine(two + " Leangth of the line and leangth of two");
                        two = LenghtofLine;
                    }
                    if (one == two)
                    {
                        Console.WriteLine(" Two Lines are equaly Preferable");
                        double LenghtofLine = line();
                    }
                    else if (two > one)
                    {
                        Console.WriteLine("  Line one is grater than line two");
                        double LenghtofLine = line();
                    }
                    else
                    {
                        Console.WriteLine("Line Two is grater than line one");
                    }
                }
                static double line()
                {
                    Console.WriteLine("Enter the first two numburs for x1 and y1");
                    Console.WriteLine("Enter x1");
                    double x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y1");
                    double y1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the first two numburs for x2 and y2");
                    Console.WriteLine("Enter x2");
                    double x2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y2");
                    double y2 = int.Parse(Console.ReadLine());

                    double LenghtofLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    Console.WriteLine(LenghtofLine);
                    return LenghtofLine;
                }
            }
        }
    
        
        
    }
}
