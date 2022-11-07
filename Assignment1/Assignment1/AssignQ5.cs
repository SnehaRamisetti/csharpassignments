using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ5
    {
        public static void Main()
        {
            double radius, area, circumference;
            Console.WriteLine(" enter the radius of the circle:");
            radius=Convert.ToDouble(Console.ReadLine());
            area=2 * 3.14 * radius * radius;
            circumference = 2 * 3.14 * radius;
            Console.WriteLine(" area={0},circumference={1}", area, circumference);
            Console.WriteLine(" press any key to exit");
            Console.ReadKey();
        }
    }
}
