using System;
using MyCalc;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Calc calc = new Calc();
            Console.WriteLine($"Sum = {calc.Add(70,80)}");
            Console.WriteLine($"Multiply = {calc.Add(4, 5)}");
            Console.ReadLine();
        }
    }
}
