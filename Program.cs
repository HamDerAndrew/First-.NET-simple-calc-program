using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = calculator();
            int result2 = calculator();
            Console.WriteLine(result + result2);

            Console.Read();
        }

        static int calculator(int num1, int num2)
        {
            int result = 0;

            Console.WriteLine("Type two numbers. We'll add them");
            int num1 = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Now add the next number");
            int num2 = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1500);

            result = (num1 + num2);

            return result;

        }
    }
}
