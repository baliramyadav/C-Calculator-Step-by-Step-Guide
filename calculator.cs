using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming_Examples
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            int a, b,choice;
            float c;
            Console.WriteLine("=========Calculator Programming=========");
            
            Console.WriteLine("\n Enter your first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter your second number:");
            b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Select your Choice:");
            Console.WriteLine("please select any below mention Choice for your operation");
            Console.WriteLine("1. Addition Operation");
            Console.WriteLine("2. Subtract Operation");
            Console.WriteLine("3. Multiply Operation");
            Console.WriteLine("4. Divide Operation");
            Console.WriteLine("5. Exit the application");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("Addition Result is:- " + c);
                    break;
                case 2:
                    c= a - b;
                    Console.WriteLine("Subtract Result is:- " + c);
                    break;

                case 3:
                    c = a * b;
                    Console.WriteLine("Multiply Result is:- " + c);
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine("Divide Result is:- " + c);
                    break;

                case 5:
                    Environment.Exit(4);
                    break;
            }
            Console.ReadLine();


        }
    }
}
