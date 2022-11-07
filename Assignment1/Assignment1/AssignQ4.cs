using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ4
    {
        static void Main(string[] args)
        {

            AssignQ4.swap();


        }
        public static void swap()
        {
            int n1, n2, c;
            Console.WriteLine("enter the first number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" before swaping number1={0} and number2={1}", n1, n2);
            c = n1;
            n1 = n2;
            n2 = c;
            Console.WriteLine(" after swaping number1={0} and number2={1}", n1, n2);
            Console.WriteLine(" press any key to exit");
            Console.ReadKey();
        }
    
    }
}
