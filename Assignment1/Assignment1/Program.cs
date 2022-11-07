using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char op;
            Console.WriteLine("please enter the first number:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("please enter the second number:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("please select the operator ( +,-,*,/)");
            op = Console.ReadLine()[0];
            switch (op)
            {
                case '+':
                    Console.WriteLine("{0} +{1} ={2}",a, b, (a + b));
                    break;
                case '-':
                    Console.WriteLine("{0} -{1}={2}",a, b, (a - b));
                    break;
                case '*':
                    Console.WriteLine("{0} *{1}={2}",a, b, (a *b));
                    break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("we cannot divide {0} by 0",a);
                    else
                    Console.WriteLine("{0} -{1}={2}",a, b, (a - b));
                    break;
                    default:
                    Console.WriteLine(" Invalid operator {0}",op);
                    break;


            }

            Console.ReadKey();
        }
    }
}
