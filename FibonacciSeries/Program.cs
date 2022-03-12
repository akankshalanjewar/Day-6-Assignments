using System;

namespace FibonacciSeries
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Num;

            Console.Write("Enter the number of elements : ");
            Num = int.Parse(Console.ReadLine());



            int s1 = 0, s2 = 1;
            int fSeries;
            int i;
            Console.WriteLine("Fibonacci sequence : " + s1);
            Console.WriteLine("Fibonacci sequence : " + s2);
            for (i = 2; i < Num; i++)
            {
                fSeries = s1 + s2;
                Console.WriteLine("Fibonacci sequence : " + fSeries);
                s1 = s2;
                s2 = fSeries;



            }
            
        }
    }
}
