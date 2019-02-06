using System;
 
namespace ComSciDev.Com.CSharp.MultiplicationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            //รับค่าตัวเลขที่ป้อนเข้าไป
            int mul = int.Parse(Console.ReadLine());
            Console.WriteLine();
             
            //วน 12 รอบเพื่อแสดงผลลัพธ์
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("  " + mul + " x " + i + " = " + mul * i);
            }
 
            Console.ReadLine();
        }
    }
}