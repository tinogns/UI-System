using System;
 
namespace ComSciDev.Com.CSharp.MultiplicationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : 12344");
            
            int mul = int.Parse(Console.ReadLine());
            Console.WriteLine();
             
            
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("  " + mul + " x " + i + " = " + mul * i);
            }
 
            Console.ReadLine();
        }
    }
}
