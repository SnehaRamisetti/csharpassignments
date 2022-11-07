using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ2
    {
        public static void Main()
        {
            int a1, a2, a3, a4, a5;
            Console.WriteLine(" Enter the average marks of student 1:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the average marks of student 2:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the average marks of student 3:");
            a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the average marks of student 4:");
            a4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the average marks of student 5:");
            a5 = Convert.ToInt32(Console.ReadLine());
            if (a1 > a2 && a1 > a3 && a1 > a4 && a1 > a5)
                Console.WriteLine("Highest marks is {0}", a1);
            else if (a2 > a1 && a2 > a3 && a2 > a4 && a2 > a5)
                Console.WriteLine("Highest marks is {0}", a2);
            else if (a3 > a2 && a3 > a1 && a3 > a4 && a3 > a5)
                Console.WriteLine("Highest marks is {0}", a3);
            else if (a4 > a2 && a4 > a3 && a4 > a1 && a4 > a5)
                Console.WriteLine("Highest marks is {0}", a4);
            else
                Console.WriteLine("Highest marks is {0}", a5);
            Console.WriteLine(" Press any key to exit");
            Console.ReadKey();
        }
    }
}
