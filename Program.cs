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
            //instruct user to input the numbers
            Console.WriteLine("Enter Two numbers, which we'll add");
            Console.WriteLine("Type the first number and hit Enter");
            //Read first number
            int number1 = int.Parse(Console.ReadLine());
            //Read second number
            Console.WriteLine("Enter the second number and hit Enter");
            int number2 = int.Parse(Console.ReadLine());
            //inform the user that the 2 numbers are going to be summed up
            Console.WriteLine("Calculating... Please wait");
            Console.WriteLine(calculator(number1, number2));

            Console.Read();
        }
        
        static int calculator(int num1, int num2)
        {
            int result = num1 + num2;
            return result;

        }
    }
}
