using System;
using System.Buffers.Text;

namespace Line_Comp_Prob
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program");
            double obj = Program.line();
             
        }
        static double line()
        {
            Console.WriteLine("Enter the first two numburs for x1 and y1");
            Console.WriteLine("Enter x1");
            double x1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1");
            double y1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first two numburs for x2 and y2");
            Console.WriteLine("Enter x2");
            double x2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2");
            double y2=int.Parse(Console.ReadLine());

            double LenghtofLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(LenghtofLine);
            return LenghtofLine;
        }
        
        
    }
}
