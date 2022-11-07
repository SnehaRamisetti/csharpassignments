using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ3
    {
        public static void Main()
        {


            int[] number = new int[5];
            Console.WriteLine(" enter the first element:");
            number[0]= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the first element:");
            number[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the first element:");
            number[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the first element:");
            number[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the first element:");
            number[4] = Convert.ToInt32(Console.ReadLine());
            Total(number);

        }
        public static void Total( params int[] number)
        {
            int sum = number[0] + number[1] + number[2] + number[3]+ number[4];
            Console.WriteLine(sum);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
