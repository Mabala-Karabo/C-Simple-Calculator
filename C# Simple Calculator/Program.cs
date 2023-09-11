using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = Convert.ToInt32("45");
           // Console.WriteLine(num1);
            Console.WriteLine("Enter a first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num1 + " mod " + num2 + " = " + (num1 % num2) + " That is the remainder of " + num1 + " and " + num2);

            //freeeze the console
            Console.ReadLine();

        }
    }
}
